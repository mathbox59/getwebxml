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

namespace GetWebXML.Parser
{
    public class Node_Dropdownlist
    {
        public string ControlType { get; set; }
        public string ControlID { get; set; }
        public string ControlBaseObj { get; set; }
        public string HTMLElement { get; set; }
        public entity[] Entity { get; set; }
        public basicproperty BasicProperty { get; set; }
        public Dposition Position { get; set; }
        public object ThemeInfo { get; set; }
        public object SelectValue { get; set; }
        public CScript[] script { get; set; }
        public string zIndex { get; set; }
    }
    public class CScript { }
    public class entity
    {
        public string Key { get; set; }
        public parameter[] Parameters { get; set; }
        public object Data { get; set; }
        public object Columns { get; set; }
    }
    public class parameter { }
    public class basicproperty
    {
        public string selectTextField { get; set; }
        public string selectValueField { get; set; }
        public controlbgcolor controlBgColor { get; set; }
        public string dropdownMenuBgColor { get; set; }
        public string fontColor { get; set; }
        public string borderColor { get; set; }
        public string borderWidth { get; set; }
        public string borderRadius { get; set; }
    }
    public class controlbgcolor
    {
        public int type { get; set; }
        public string rgba { get; set; }
        public string hex { get; set; }
        public string ahex { get; set; }
        public Value value { get; set; }
    }
    public class Value
    {
        public string background { get; set; }
    }
    public class Dposition
    {
        public string Left { get; set; }
        public string Top { get; set; }
        public string Right { get; set; }
        public string Bottom { get; set; }
    }

}
