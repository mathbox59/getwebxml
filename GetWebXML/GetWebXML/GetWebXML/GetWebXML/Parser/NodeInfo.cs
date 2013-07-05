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

namespace GetWebXML
{
    public class NodeInfo
    {
        public string result { get; set; }
        public string message { get; set; }
        public Data data { get; set; }
    }
    public class Data
    {
        //public Pageconfig PageConfig { get; set; }
        
        public controlist[] ControlList { get; set; }
        public int ControlCount { get; set; }
    }
//    public class Pageconfig
//    {
//        public Pagesize PageSize { get; set; }
//        public string SelectPageSize { get; set; }
//        public string BackgroundImg { get; set; }
//        public string SurplusWithText { get; set; }
//        public string SurplusHeithtText { get; set; }
//        public Pagestyle PageStyle { get; set; }
//        public bool IsExistRealTime { get; set; }
//        public string ParaRelationalExpression { get; set; }
//        public string ParaRealTimelExpression { get; set; }
//        public string UrlParas { get; set; }
//        public object Parameter { get; set; }
//        public object Variables { get; set; }
//        public object RealTimeVariables { get; set; }
//        public object ScriptEvents { get; set; }
//        public Scripttimer ScriptTimer { get; set; }
//        public object ShareDatasource { get; set; }
//        public object ShareDataSourceAndControl { get; set; }
//        public object ShareDataFilterRule { get; set; }
//        public object ButtonBindControlsRelation { get; set; }
//        public Pagescript PageScript { get; set; }
//    }

//    public class Pagesize
//    {
//        public bool AutoSize { get; set; }
//        public string Width { get; set; }
//        public string Height { get; set; }
//    }
//    public class Pagestyle
//    {
//        public string type { get; set; }
//        public string showScale { get; set; }
//        public string pageSize { get; set; }
//        public string backGround { get; set; }
//        public string gridLine { get; set; }
//        public Row[] rows { get; set; }
//    }

//    public class Row
//    {
//    }
//    public class Scripttimer 
//{
//        public object TimerPeriod { get; set; }
//        public object ScriptContent { get; set; }
//    }
//    public class Pagescript 
//    {
//        public int timerInterval { get; set; }
//        public PScript[] script { get; set; }
//    }
//    public class PScript { } 
    public class controlist
    {
        public string ControlType { get; set; }
        //public string ControlID { get; set; }
        //public string ControlBaseObj { get; set; }
        //public string HTMLElement { get; set; }
        //public entity[] Entity { get; set; }
        //public basicproperty BasicProperty { get; set; }
        public position Position { get; set; }
        //public object ThemeInfo { get; set; }
        //public object SelectValue { get; set; }
        //public CScript[] script { get; set; }
        //public string zIndex { get; set; }
    }
    // public class CScript { }
    // public class entity 
    // {
    //    public string Key { get; set; }
    //    public parameter[] Parameters { get; set; }
    //    public object Data { get; set; }
    //    public object Columns { get; set; }
    // }
    // public class parameter { }
    // public class basicproperty
    // {
    //    public string selectTextField { get; set; }
    //    public string selectValueField { get; set; }
    //    public controlbgcolor controlBgColor { get; set; }
    //    public string dropdownMenuBgColor { get; set; }
    //    public string fontColor { get; set; }
    //    public string borderColor { get; set; }
    //    public string borderWidth { get; set; }
    //    public string borderRadius { get; set; }
    // }
    //public class controlbgcolor
    //{
    //    public int type { get; set; }
    //    public string rgba { get; set; }
    //    public string hex { get; set; }
    //    public string ahex { get; set; }
    //    public Value value { get; set; }
    //}
    //public class Value
    //{
    //    public string background { get; set; }
    //}
    public class position
    {
        public string Left { get; set; }
        public string Top { get; set; }
        public string Right { get; set; }
        public string Bottom { get; set; }
    }

 
}
