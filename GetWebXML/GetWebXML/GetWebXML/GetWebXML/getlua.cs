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
using System.Windows.Resources;
using System.IO;

namespace GetWebXML
{
    public   class getlua
    {
        string pname;
        static string result;
        static string lua2json;
        public getlua(string pagename)
        {
            pname = pagename;
        }
       public string readlua()
       {
           //string filename = "SampleScript.txt";
           StreamResourceInfo resourceInfo = Application.GetResourceStream(new Uri(pname, UriKind.Relative));
           using (StreamReader reader = new StreamReader(resourceInfo.Stream))
           {
               result= reader.ReadToEnd();
               reader.Close();
           }
           lua2json = "{" + "\"" + pname.Replace(".txt", "") + "\"" + ":" + "\"" + result + "\"" + "}";
           return lua2json; 
       }
    }
}
