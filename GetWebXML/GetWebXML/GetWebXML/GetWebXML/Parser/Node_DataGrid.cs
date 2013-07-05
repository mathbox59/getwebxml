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
    public class Node_DataGrid
    {
        public string ControlType { get; set; }
        public string ControlID { get; set; }
        public string ControlBaseObj { get; set; }
        public string HTMLElement { get; set; }
        public Dentity[] Entity { get; set; }
        public Dbasicproperty BasicProperty { get; set; }
        //public Daposition Position { get; set; }
        public object ThemeInfo { get; set; }
        public gridDefaultConfig GridDefaultConfig { get; set; }
        public ColumnConfig[] ColumnConfig { get; set; }
        public bool snycTheme { get; set; }
        public DScript[] script { get; set; }
        public string zIndex { get; set; }
    }
    public class DScript { }
        public class Dentity
        {
            public string Key { get; set; }
            public parameter[] Parameters { get; set; }
            public object Data { get; set; }
            public object Columns { get; set; }
        }
        public class Dbasicproperty
        {
        }
        public class Daposition
        {
            public string Left { get; set; }
            public string Top { get; set; }
            public string Right { get; set; }
            public string Bottom { get; set; }
        }
        public class gridDefaultConfig 
        {
            public double customShellWidth { get; set; }
            public int customShellHeight { get; set; }
            public string customIntervalRowColor { get; set; }
            public CustomInvervalRowBgColor customInvervalRowBgColor { get; set; }
            public int customFreezeColCount { get; set; }
            public string customRowColor { get; set; }
            public string customFontSize { get; set; }
            public CustomRowBgColor customRowBgColor { get; set; }
            public string customTableLineModel { get; set; }
            public string customHlineColor { get; set; }
            public int customRowHeight { get; set; }
            public string customTheme { get; set; }
            public string customBackgroundColor { get; set; }
            public string customHeaderShowModel { get; set; }
            public string customHeaderColor { get; set; }
            public string customVlineColor { get; set; }
            public string customHeaderBgColor { get; set; }
            public string customTextAlign { get; set; }
            public bool customAutoColumnWidth { get; set; }
            public ColsConfig[] colsConfig { get; set; }
            public bool spc { get; set; }
            public bool ensureColumnsPxWidth { get; set; }
            public bool showFilter { get; set; }
            public bool allowSorting { get; set; }
            public bool allowPaging { get; set; }
            public int pageSize { get; set; }
            public GridData[] data { get; set; }
            public Gridcolumns[] columns { get; set; }
            public string loadingText { get; set; }
            public string scrollMode { get; set; }
        }
            public class CustomInvervalRowBgColor 
            {
                public int type { get; set; }
                public string rgba { get; set; }
                public string hex { get; set; }
                public string ahex { get; set; }
                public CValue value { get; set; }
            }
                public class CValue 
                {
                    public string background { get; set; }
                }
            public class CustomRowBgColor
            {
                public int type { get; set; }
                public string rgba { get; set; }
                public string hex { get; set; }
                public string ahex { get; set; }
                public CValue value { get; set; }
            }
            public class CustomHeaderBgColor 
            {
                public int type { get; set; }
                public string direction { get; set; }
                public StopMarker[] stopMarker { get; set; }
                public CValue value { get; set; }
            }
                public class StopMarker
                {
                    public int position { get; set; }
                    public string color { get; set; }
                    public string ahex { get; set; }
                }
            public class ColsConfig 
            {
                public int dataIndex { get; set; }
                public string dataKey { get; set; }
                public string headerText { get; set; }
                public string dataType { get; set; }
              //  public AlarmRule[] alarmRule { get; set; }
                public object[] alarmRule { get; set; }
                public int columnWidth { get; set; }
                public int fontSize { get; set; }
                public string fontFamily { get; set; }
                public string fontWeight { get; set; }
                public string columnColor { get; set; }
                public string columnFormate { get; set; }
                public bool visible { get; set; }

            }
                public class AlarmRule 
                {
                    public string dataKey { get; set; }
                    public string compareOperate { get; set; }
                    public string compareTyle { get; set; }
                    public string[] compareValue { get; set; }
                    public AlarmColor alarmColor { get; set; }
                }
                    public class AlarmColor 
                    {
                        public int type { get; set; }
                        public string rgba { get; set; }
                        public string hex { get; set; }
                        public string ahex { get; set; }
                        public AValue value { get; set; }
                    }
                        public class AValue 
                        {
                            public string background { get; set; }
                            public string rgba { get; set; }
                        }
            public class GridData 
            {
                public string pciTHY { get; set; }
                public int pciTHMain { get; set; }
                public int pciTHMax { get; set; }
            }
            public class Gridcolumns 
            {
                public string dataKey { get; set; }
                public string dataType { get; set; }
                public string headerText { get; set; }
                public bool visible { get; set; }
            }
        public class ColumnConfig
        {
            public int dataIndex { get; set; }
            public string dataKey { get; set; }
            public string headerText { get; set; }
            public string dataType { get; set; }
            public AlarmRule[] alarmRule { get; set; }
            public int columnWidth { get; set; }
            public int fontSize { get; set; }
            public string fontFamily { get; set; }
            public string fontWeight { get; set; }
            public string columnColor { get; set; }
            public string columnFormate { get; set; }
            public bool visible { get; set; }
        }
}
