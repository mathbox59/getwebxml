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
    public class Node_BasicChart
    {
        public string ControlType { get; set; }
        public string ControlID { get; set; }
        public object Entity { get; set; }
        public string ControlBaseObj { get; set; }
        public string HTMLElement { get; set; }
        public seriesdata[] SeriesData { get; set; }
       // public position Position { get; set; }
        public chartoptions ChartOptions { get; set; }
        public object StandardLines { get; set; }
        public object ChartThemeName { get; set; }
        public object ChartType { get; set; }
        public CScript[] script { get; set; }
        public string zIndex { get; set; }

    }
        public class seriesdata
        {
            public string name { get; set; }
            public object data { get; set; } 
            public string type { get; set; }
            public string color { get; set; }
            public sentity Entity { get; set; }
            public string XColumn { get; set; }
            public string YColumn { get; set; }
            public extdata ExtData { get; set; }

         }
            public class sentity
            {
                public string Key { get; set; }
                public parameter[] Parameters { get; set; }
                public object Data { get; set; }
                public string [] Columns { get; set; }
            }
            public class extdata 
            {
                public Datalabels dataLabels { get; set; }
                public tips Tips { get; set; }
                public marker Marker { get; set; }
            }
                public class Datalabels 
                {
                    public bool enabled { get; set; }
                }
                public class tips 
                {
                    public bool enabled { get; set; }
                }
                public class marker 
                {
                    public bool enabled { get; set; }
                    public string fillColor { get; set; }
                    public string lineColor { get; set; }
                    public int lineWidth { get; set; }
                    public int radius { get; set; }
                    public string symbol { get; set; }
                }
        public class chartoptions 
        {
            public string name { get; set; }
            public string[] colors { get; set; }
            public Chart chart { get; set; }
            public XAxis xAxis { get; set; }
            public YAxis yAxis { get; set; }
            public Legend legend { get; set; }
            public Clabels labels { get; set; }
            public PlotOptions plotOptions { get; set; }
            public Toolbar toolbar { get; set; }
            public Navigation navigation { get; set; }
            public RangeSelector rangeSelector { get; set; }
            public Navigator navigator { get; set; }
            public Scrollbar scrollbar { get; set; }
            public string legendBackgroundColor { get; set; }
            public string legendBackgroundColorSolid { get; set; }
            public string dataLabelsColor { get; set; }
            public string textColor { get; set; }
            public string maskColor { get; set; }
            public CTitle title { get; set; }
            public CTooltip tooltip { get; set; }
            public object pane { get; set; }

        }
            public class Chart 
            {
                public Backgroundcolor backgroundColor { get; set; }
                public string borderColor { get; set; }
                public int borderWidth { get; set; }
                public int borderRadius { get; set; }
                public object  plotBackgroundColor { get; set; }
                public int plotBorderWidth { get; set; }
                public bool polar { get; set; }

            
            }
            public class Backgroundcolor 
            {
                public LinearGradient linearGradient { get; set; }
                public object stops { get; set; }
            }
                public class LinearGradient
                {
                    public int x1 { get; set; }
                    public int y1 { get; set; }
                    public int x2 { get; set; }
                    public int y2 { get; set; }
                }
            public class XAxis 
            {
                public Labels labels { get; set; }
                public string gridLineWidth { get; set; }
                public string lineColor { get; set; }
                public int lineWidth { get; set; }
                public int tickWidth { get; set; }
                public Title title { get; set; }
                public string[] categories { get; set; }
                public string gridLineColor { get; set; }
                public int tickLength { get; set; }
                public string tickPosition { get; set; }
                public string XTimeFormat { get; set; }

            }
                public class Labels 
                {
                    public string rotation { get; set; }
                    public string align { get; set; }
                    public Style style { get; set; }
                    public bool enabled { get; set; }
                }
                    public class Style 
                    {
                        public string color { get; set; }
                        public string fontFamily { get; set; }
                        public string fontWeight { get; set; }
                        public string fontSize { get; set; }
                    }
                public class Title 
                {
                    public Tstyle style { get; set; } 

                }
                    public class Tstyle 
                    {
                        public string color { get; set; }
                        public string font { get; set; }
                    }
            public class YAxis
            {
                public object alternateGridColor { get; set; }
                public object minorTickInterval { get; set; }
                public string lineColor { get; set; }
                public string gridLineColor { get; set; }
                public string gridLineWidth { get; set; }
                public int lineWidth { get; set; }
                public int tickWidth { get; set; }
                public YLabels labels { get; set; }
                public YTitle title { get; set; }
                public int tickLength { get; set; }
                public string tickColor { get; set; }
                public string tickPosition { get; set; }


            }
                public class YLabels
                {
                    public Style style { get; set; }
                    public bool enabled { get; set; }
                }
                public class    YTitle
                {
                    public YTstyle style { get; set; }

                }
                    public class YTstyle
                    {
                        public string color { get; set; }
                        public string font { get; set; }
                        public string text { get; set; }
                    }
                public class Legend 
                {
                    public ItemStyle itemStyle { get; set; }
                    public ItemHoverStyle itemHoverStyle { get; set; }
                    public ItemHiddenStyle itemHiddenStyle { get; set; }
                }
                    public class ItemStyle
                    {
                        public string color { get; set; }
                    }
                    public class ItemHoverStyle
                    {
                        public string color { get; set; }
                    }
                    public class ItemHiddenStyle
                    {
                        public string color { get; set; }
                    }
                    public class Clabels 
                    {
                        public clstyle style { get; set; }
                    }
                        public class clstyle
                        {
                            public string color { get; set; }
                        }
                    public class PlotOptions
                    {
                        public Area area { get; set; }
                        public Pcolumn column { get; set; }
                        public Line line { get; set; }
                        public Bar bar { get; set; }
                        public Pie pie { get; set; }
                        public PSeries series { get; set; }

                    }
                        public class Area 
                        {
                            public int lineWidth { get; set; }
                            public Amarker marker { get; set; }
                            public bool shadow { get; set; }
                            public Astates states { get; set; }

                        } 
                            public class Amarker 
                            {
                                public bool enabled { get; set; }
                                public mstates states { get; set; }
                            }
                                public class mstates
                                { 
                                    public Hover hover { get; set; }
                                }
                                    public class Hover
                                    {
                                        public bool enabled { get; set; }
                                        public int radius { get; set; }
                                    }
                            public class Astates 
                            {
                                public AHover hover { get; set; }
                            }
                                public class AHover
                                {
                                    public int lineWidth { get; set; }
                                }
                        public class Pcolumn 
                        {
                            public int lineWidth { get; set; }
                            public string borderColor { get; set; }
                            public object stacking { get; set; }
                            public Series series { get; set; }
                            public Cmarker marker { get; set; }
                        }
                            public class Series
                            {
                                public string pointPadding { get; set; }
                            }
                            public class Cmarker
                            {
                                public bool enabled { get; set; }
                                public cmstates states { get; set; }
                            }
                                public class cmstates
                                {
                                    public cHover hover { get; set; }
                                }
                                    public class cHover
                                    {
                                        public bool enabled { get; set; }
                                        public int lineWidth { get; set; }
                                    }
                        public class Line
                        {
                            public lmarker marker { get; set; }
                        }
                            public class lmarker
                            {
                                public bool enabled { get; set; }
                                public lmstates states { get; set; }
                            }
                                public class lmstates
                                {
                                    public lHover hover { get; set; }
                                }
                                    public class lHover
                                    {
                                        public bool enabled { get; set; }
                                        public int radius { get; set; }
                                    }
                        public class Bar 
                        {
                            public int lineWidth { get; set; }
                            public string borderColor { get; set; }
                            public BSeries series { get; set; }
                            public Bmarker marker { get; set; }
                        }
                            public class BSeries
                            {
                                public string pointPadding { get; set; }
                            }
                            public class Bmarker
                            {
                                public bool enabled { get; set; }
                                public bmstates states { get; set; }
                            }
                                public class bmstates
                                {
                                    public bHover hover { get; set; }
                                }
                                    public class bHover
                                    {
                                        public bool enabled { get; set; }
                                        public int lineWidth { get; set; }
                                    }
                        public class Pie 
                        {
                            public bool allowPointSelect { get; set; }
                            public string cursor { get; set; }
                            public PDatalabels dataLabels { get; set; }
                        }
                            public class PDatalabels
                            {
                                public bool enabled { get; set; }
                            }
                        public class PSeries 
                        {
                            public pmarker marker { get; set; }
                            public string cursor { get; set; }
                            public PPoint point { get; set; }
                            public pstates states { get; set; }
                            public object stacking { get; set; }
                        }
                            public class pmarker 
                            {
                                public int radius { get; set; } 
                            }
                            public class PPoint
                            {
                                public Events events { get; set; }
                            }
                                public class Events { }
                            public class pstates 
                            {
                                public phover hover { get; set; }
                            }
                                public class phover 
                                {
                                    public bool enabled;
                                 }
                        public class Toolbar
                        {
                            public TitemStyle itemStyle { get; set; }
                        }
                            public class TitemStyle 
                            {
                                public string color { get; set; }
                            }
                        public class Navigation 
                        {
                            public ButtonOptions buttonOptions { get; set; }
                        }
                            public class ButtonOptions 
                            {
                                public BackgroundColor backgroundColor { get; set; }
                                public string borderColor { get; set; }
                                public string symbolStroke { get; set; }
                                public string hoverSymbolStroke { get; set; }
                            }
                                public class BackgroundColor 
                                {
                                    public int[] linearGradient { get; set; }
                                    public object[] stops { get; set; }
                                }
                        public class RangeSelector
                        {
                            public ButtonTheme buttonTheme { get; set; }
                            public InputStyle inputStyle { get; set; }
                            public LabelStyle labelStyle { get; set; }

                        }
                            public class InputStyle 
                            {
                                public string backgroundColor{ get; set; }
                            }
                            public class LabelStyle 
                            {
                                public string color { get; set; }
                            }
                            public class ButtonTheme 
                            {
                                public Fill fill { get; set; }
                                public string stroke { get; set; }
                                public Rstyle style { get; set; }
                                public Rstates states { get; set; }
                            }
                                public class Fill 
                                {
                                    public int []linearGradient { get; set; }
                                    public object[] stops { get; set; }
                                }
                            public class Rstyle 
                            {
                                public string color { get; set; }
                                public string frontWeight { get; set; }
                            }
                            public class Rstates 
                            {
                                public Rhover hover { get; set; }
                                public Select select { get; set; }
                            }
                                public class Rhover 
                                {
                                    public Rfill fill { get; set; }
                                    public string stroke { get; set; }
                                    public RRstyle style { get; set; }

                                }
                                     public class Rfill 
                                     {
                                         public int[] linearGradient { get; set; }
                                         public object[] stops { get; set; }
                                     }
                                     public class RRstyle
                                     {
                                         public string color { get; set; }

                                     }
                                public class Select 
                                {
                                    public Sfill fill { get; set; }
                                    public string stroke { get; set; }
                                    public SRstyle style { get; set; }
                                }
                                    public class Sfill 
                                    {
                                        public int[] linearGradient { get; set; }
                                        public object[] stops { get; set; }
                                    }
                                    public class SRstyle
                                    {
                                        public string color { get; set; }
                                    }
            public class Navigator
            {
                public Handles handles { get; set; }
                public string outlineColor { get; set; }
                public string maskFill { get; set; }
                public NSeries series { get; set; }
            }
                public class Handles 
                {
                    public string backgroundColor { get; set; }
                    public string borderColor { get; set; }
                }
                public class NSeries 
                {
                    public string color { get; set; }
                    public string lineColor { get; set; }
                }
            public class Scrollbar
            {
                public BarBackgroundColor barBackgroundColor { get; set; }
                public string barBorderColor { get; set; }
                public string buttonArrowColor { get; set; }
                public ButtonBackgroundColor buttonBackgroundColor { get; set; }
                public string buttonBorderColor { get; set; }
                public string rifleColor { get; set; }
                public TrackBackgroundColor trackBackgroundColor { get; set; }
                public string trackBorderColor { get; set; }
            }
                public class BarBackgroundColor 
                {
                    public int[] linearGradient { get; set; }
                    public object[] stops { get; set; }
                }
                public class ButtonBackgroundColor
                {
                    public int[] linearGradient { get; set; }
                    public object[] stops { get; set; }
                }
                public class TrackBackgroundColor 
                {
                    public int[] linearGradient { get; set; }
                    public object[] stops { get; set; }
                }
            public class CTitle {
                public string align { get; set; }
                public bool floating { get; set; }
                public string text { get; set; }
                public object verticalAlign { get; set; }
                public CStyle style { get; set; }
            } 
               public class CStyle
               {
                   public string fontFamily { get; set; }
                   public string fontWeight { get; set; }
                   public string color { get; set; }
                   public string fontSize { get; set; }
               }
            public class CTooltip
            {
                public object  formatter { get; set; }
                public bool enabled { get; set; }
            }

}
    