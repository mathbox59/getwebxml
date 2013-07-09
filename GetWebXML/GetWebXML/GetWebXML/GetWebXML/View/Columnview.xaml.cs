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
            CreatChart();
            
        }
        public Columnview(Node_BasicChart nodebasicchart, BasicChartGeneric bcview)
        {
            bc_column = bcview;
            nbc_column = nodebasicchart;
        }
        public void CreatChart()
        {
            Visifire.Charts.Chart chart = new Visifire.Charts.Chart();
            // Create new DataSeries
            DataSeries dataseries = new DataSeries();
            for(int index=0;index<nbc_column.ChartOptions.xAxis.categories.Length;index++)
            {
                dataseries.DataPoints.Add(new DataPoint { AxisXLabel = nbc_column.ChartOptions.xAxis.categories[index], YValue = 53});
            }
            chart.Series.Add(dataseries);
        }
    }
}