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
using GetWebXML.core;

namespace GetWebXML.View
{
    public class BasicChartGeneric
    {
        public double top;
        public double left;
        public double right;
        public double bottom;
        public BasicChartGeneric(Position position )
        {
            this.left = position.left;
            this.top = position.top;
            this.right = position.right;
            this.bottom = position.bottom;
        }
    }
}
