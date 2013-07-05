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
    public class Node_Label
    {
        public string ControlType { get; set; }
        public string ControlID { get; set; }
        public string ControlBaseObj { get; set; }
        public string HTMLElement { get; set; }
        public Lentity[] Entity { get; set; }
        //public Lposition Position { get; set; }
        public labelBasicProperty LabelBasicProperty { get; set; }
        public HrefUrl hrefUrl { get; set; }
        public object ThemeName { get; set; }
        public LScript[] script { get; set; }
        public string zIndex { get; set; }
    }
        public class LScript { }
        public class Lentity
        {
            public string Key { get; set; }
            public parameter[] Parameters { get; set; }
            public object Data { get; set; }
            public object Columns { get; set; }
        }
        public class Lposition
        {
            public string Left { get; set; }
            public string Top { get; set; }
            public string Right { get; set; }
            public string Bottom { get; set; }
        }
        public class labelBasicProperty
        {
            public object labelTextField { get; set; }
            public object labelValueField { get; set; }
            public int LeftFillet1 { get; set; }
            public int RightFillet1 { get; set; }
            public int LeftFillet2 { get; set; }
            public int RightFillet2 { get; set; }
            public int fontSize { get; set; }
            public string fontColor { get; set; }
            public string fontWeight { get; set; }
            public string fontFamily { get; set; }
            public BgColor bgColor { get; set; }
            public string FontText { get; set; }
            public bool IsShowText { get; set; }
            public string hrefAddress { get; set; }
            public string OpenPosition { get; set; }
            public string InsideLinkAddress { get; set; }
            public string IsDisabledhrefAddress { get; set; }
            public string IsDisabledOpenPosition { get; set; }
            public object IsDisabledInsideLinkAddress { get; set; }
            public object IsLink { get; set; }
        }
            public class BgColor 
            {
                public int type { get; set; }
                public string rgba { get; set; }
                public string hex { get; set; }
                public string ahex { get; set; }
                public BValue value { get; set; }
            }
                public class BValue
                {
                    public string background { get; set; }
                }
        public class HrefUrl 
        {
            public string InsideLink { get; set; }
            public string OutsideLink { get; set; }
            public string OutsideLinkOpenPosition { get; set; }
            public object IsOutSideLink { get; set; }
        }
}
