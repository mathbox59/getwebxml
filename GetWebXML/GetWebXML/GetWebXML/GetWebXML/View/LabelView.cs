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
using GetWebXML.Parser;
using GetWebXML.utils;
using GetWebXML.Common;

namespace GetWebXML.View
{
    public class LabelView
    {
        Node_Label labelInfo = new Node_Label();
        TextBlock label_view = new TextBlock();

        public LabelView(TextBlock label, Node_Label nodelabel) 
        {
            labelInfo = nodelabel;
            label_view = label;
        }
        public TextBlock Labelconfig()
        {
            //字体，大小 ，内容
            label_view.FontSize = labelInfo.LabelBasicProperty.fontSize;
            stringFontweight sfw=new stringFontweight(labelInfo.LabelBasicProperty.fontWeight);
            label_view.FontWeight = sfw.toFontweight();
            label_view.FontFamily = new FontFamily(labelInfo.LabelBasicProperty.fontFamily);
            label_view.Text = labelInfo.LabelBasicProperty.FontText;
            //label_view.Foreground = 

            return label_view;
        }
    }
}
