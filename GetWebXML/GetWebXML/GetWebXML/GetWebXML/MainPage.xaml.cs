using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.Xml;
using System.IO;
using System.Text;
using System.Runtime.Serialization.Json;
using GetWebXML.DES;
using GetWebXML.Parser;
using GetWebXML.View;
using GetWebXML.core;
//using GetWebXML.Control;

namespace GetWebXML
{
    public partial class MainPage : PhoneApplicationPage
    {
        string stringJson;
        string url;
        int a = 0;
        // 构造函数
        public MainPage()
        {
            InitializeComponent();
            //url = "{\"url\":\"DROPDOWN/DROPDOWN_1\"}";
            //Hereeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee
            //Hereeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee
            //url = "{\"url\":\"BL/BL_1\"}"; 
            url = "{\"url\":\"LYW/LYW_1\"}";
            System.Diagnostics.Debug.WriteLine(url);
            //加密
            url = Encryption_Base64.Base64Code(url);
            // 实例化客户端代理类
            ServiceReference1.Service1SoapClient MyClient = new ServiceReference1.Service1SoapClient();
            // 绑定回调事件
            MyClient.IOS_VSFileReadByIDCompleted += (s, arg) =>
                {
                    textstate.Text = "请求完成";
                    if (arg.Error != null)
                    {
                        System.Diagnostics.Debug.WriteLine(arg.Error);
                        return;
                    }
                    if (arg.Result != null)
                    {
                        System.Diagnostics.Debug.WriteLine("**********Result**********");
                        //解密返回json
                        stringJson = Decryption_Base64.Base64Decode(arg.Result);
                        // json 格式化
                       stringJson=FormatJson(stringJson);
                       System.Diagnostics.Debug.WriteLine(stringJson);
                        //解析
                        NodeInfo nodeInfo = JsonParser.Deserialize<NodeInfo>(stringJson);                       
                        System.Diagnostics.Debug.WriteLine(nodeInfo.message);
                        //获取所有控件类型
                        List<string> ctltype=new List<string>();
                        if (nodeInfo.data.ControlCount == 1) {
                            int indexstart = stringJson.IndexOf("ControlType" );
                            int indexend = stringJson.IndexOf("ControlCount" );
                            string ss = stringJson.Substring(indexstart - 2, indexend - indexstart - 1);
                            ctltype.Add(ss);
                        }else
                        {
                            int tempstart = 0;
                            for (int i = 0; i < nodeInfo.data.ControlCount; i++) 
                            {
                                if (i == nodeInfo.data.ControlCount-1)
                                {
                                    int start = stringJson.IndexOf("ControlType", 1 + tempstart);
                                    int end = stringJson.IndexOf("ControlCount");
                                    string sl = stringJson.Substring(start - 2, end - start - 1);
                                    ctltype.Add(sl);
                                    break;
                                }
                                else
                                {
                                    int indexstart = stringJson.IndexOf("ControlType", 1 + tempstart);
                                    int indexend = stringJson.IndexOf("ControlType", 1 + indexstart);
                                    tempstart = indexstart;
                                    string ss = stringJson.Substring(indexstart - 2, indexend - indexstart - 1);
                                    ctltype.Add(ss);
                                }
                            } 
                        }

                        //本地生成控件
                        for (int i = 0; i < nodeInfo.data.ControlCount; i++) 
                        {
                            switch (nodeInfo.data.ControlList[i].ControlType) 
                            {
                                case "DropDownList":
                                    Node_Dropdownlist nodedropdown = JsonParser.Deserialize<Node_Dropdownlist>(ctltype.ElementAt(i));
                                    ListPicker dropdownlist = new ListPicker();
                                    DropDownListView dropdownlistview = new DropDownListView( dropdownlist, nodedropdown);
                                    dropdownlist=dropdownlistview.Dropdownlistconfig();
                                    //添加到界面
                                    this.panel.Children.Add(dropdownlist);
                                    //生成下拉菜单控件
                                    System.Diagnostics.Debug.WriteLine(nodedropdown.ControlType);
                                    break;
                                case "BasicChart":
                                    Node_BasicChart nodebasicchart = JsonParser.Deserialize<Node_BasicChart>(ctltype.ElementAt(i));
                                    Position basicchart_p = new Position(nodeInfo, i);
                                    BasicChartGeneric bcview = new BasicChartGeneric(basicchart_p);
                                    switch (nodebasicchart.SeriesData[0].type) 
                                    {
                                        case "column":
                                            this.NavigationService.Navigate(new Uri("/View/Columnview.xaml", UriKind.Relative));
                                            break;
                                        case "area":
                                            break;
                                        case "line":
                                            this.NavigationService.Navigate(new Uri("/View/ColumnChart.xaml", UriKind.Relative));
                                            break;
                                        case "bar":
                                            break;
                                        case "pie":
                                            break;
                                    }
                                    System.Diagnostics.Debug.WriteLine(nodebasicchart.ControlID);
                                    
                                    break;
                                case "DataGrid":
                                    Node_DataGrid nodedatagrid = JsonParser.Deserialize<Node_DataGrid>(ctltype.ElementAt(i));
                                    System.Diagnostics.Debug.WriteLine(nodedatagrid.ControlID);
                                    break;
                                case "Label":
                                    Node_Label nodelabel = JsonParser.Deserialize<Node_Label>(ctltype.ElementAt(i));
                                    TextBlock label = new TextBlock();
                                    LabelView labelview = new LabelView(label, nodelabel);
                                    label = labelview.Labelconfig();
                                    this.panel.Children.Add(label);
                                    System.Diagnostics.Debug.WriteLine(nodeInfo.data.ControlList[i].ControlType);
                                    break;
                            }
                        }
                    
                    }            
                };
            //调用异步方法
            textstate.Text = "正在请求，请等候……";
            MyClient.IOS_VSFileReadByIDAsync(url);
        }
        // json 格式化
        public string FormatJson(string stringJson)
        {
           stringJson = stringJson.Replace("\\", "");
           stringJson = stringJson.Replace("\"{", "{");
           stringJson = stringJson.Replace("}\"", "}");
           stringJson = stringJson.Replace("\"[", "[");
           stringJson = stringJson.Replace("]\"", "]");
           return stringJson;
        }

    }
 }