using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Visifire.Charts;
using GetWebXML.Parser;

namespace GetWebXML.View
{
    public partial class Columnview : PhoneApplicationPage
    {
        BasicChartGeneric bc_column=new BasicChartGeneric();
        Node_BasicChart nbc_column = new Node_BasicChart();
        public Columnview()
        {
            InitializeComponent();
            
        }
        public Columnview(Node_BasicChart nodebasicchart, BasicChartGeneric bcview)
        {
            bc_column = bcview;
            nbc_column = nodebasicchart;
        }
        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            // Create new DataSeries
            DataSeries dataseries = new DataSeries();
            for(int index=0;index<nbc_column.ChartOptions.xAxis.categories.Length;index++)
            dataseries.DataPoints.Add(new DataPoint{})
        
        }
    }
}using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Visifire.Charts;

namespace GetWebXML.View
{
    public partial class Columnview : PhoneApplicationPage
    {
        public Columnview()
        {
            InitializeComponent();
        }
        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            // Create new DataSeries
            DataSeries dataSeries = new DataSeries();
            //dataSeries.Foreground
        }
    }
}