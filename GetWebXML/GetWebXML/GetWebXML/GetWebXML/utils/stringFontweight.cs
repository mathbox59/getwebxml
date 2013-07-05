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

namespace GetWebXML.utils
{
    public  class stringFontweight
    {
        FontWeight fw = new FontWeight();
        string flag = "";
        public stringFontweight(string fongtweight) 
        {
            flag = fongtweight;
        }
        public  FontWeight toFontweight() 
        {
            switch (flag) 
            {
                case"normal":
                    fw= FontWeights.Normal;
                    break;
                case"medium":
                    fw = FontWeights.Medium;
                    break;
            }

            return fw;
        }
    }
}
