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

namespace GetWebXML.core
{

    public class Position
    {
        public double top;
        public double left;
        public double right;
        public double bottom;
        public Position(NodeInfo nodeInfo, int i)
        {
            left = double.Parse(nodeInfo.data.ControlList[i].Position.Left);
            top = double.Parse(nodeInfo.data.ControlList[i].Position.Top);
            right = double.Parse(nodeInfo.data.ControlList[i].Position.Right);
            bottom = double.Parse(nodeInfo.data.ControlList[i].Position.Bottom);
        }

    }
}
