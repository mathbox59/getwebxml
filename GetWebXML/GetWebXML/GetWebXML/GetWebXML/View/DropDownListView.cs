using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using GetWebXML.Common;
using GetWebXML.Parser;


namespace GetWebXML.View
{
    public class DropDownListView
    {
        Node_Dropdownlist dropdownvInfo= new Node_Dropdownlist();
        ListPicker dropdownlist_view = new ListPicker();

        public DropDownListView(ListPicker dropdownlist,Node_Dropdownlist nodedropdown)
        {
            dropdownlist_view = dropdownlist;
            dropdownvInfo=nodedropdown;
        }

        public ListPicker Dropdownlistconfig()
        {
            string[] item1 = { "hello", "world" };
            dropdownlist_view.Header = dropdownvInfo.ControlID;
           // dropdownlist_view.Margin=new Thickness(dropdownvinfo.Position.Left)
            dropdownlist_view.BorderBrush = new SolidColorBrush(hexcolor.ToColor("#e3e0e0"));
            dropdownlist_view.ItemsSource = item1;
            return dropdownlist_view;

        }

    }
}
