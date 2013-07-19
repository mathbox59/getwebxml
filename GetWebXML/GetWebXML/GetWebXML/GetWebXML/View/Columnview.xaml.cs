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
            //InitializeComponent();
            //Visifire.Charts.Chart chart = new Visifire.Charts.Chart();
            ////DataSeries dataseries = new DataSeries { RenderAs = RenderAs.Column };
            ////DataSeries dataseries = new DataSeries { RenderAs = RenderAs.Area };
            //DataSeries dataseries = new DataSeries { RenderAs = RenderAs.Line };
            //// DataSeries dataseries = new DataSeries { RenderAs = RenderAs.Pie };
            //dataseries.DataPoints.Add(new DataPoint { AxisXLabel = "07:00", YValue = 53, XValue = 0 });
            //dataseries.DataPoints.Add(new DataPoint { AxisXLabel = "08:00", YValue = 73, XValue = 1 });
            //dataseries.DataPoints.Add(new DataPoint { AxisXLabel = "09:00", YValue = 123, XValue = 2 });
            //dataseries.DataPoints.Add(new DataPoint { AxisXLabel = "10:00", YValue = 33, XValue = 3 });
            //chart.Series.Add(dataseries);
            //LayoutRoot.Children.Add(chart);
            //System.Diagnostics.Debug.WriteLine("killlllll meeeeeeee");
        }
        public Columnview(Node_BasicChart nodebasicchart, BasicChartGeneric bcview)
        {
            InitializeComponent();
            bc_column = bcview;
            nbc_column = nodebasicchart;
            CreatChart();
        }
        public void CreatChart()
        {
            Visifire.Charts.Chart chart = new Visifire.Charts.Chart();
            // Create new DataSeries
            DataSeries dataseries = new DataSeries();
            //int num = nbc_column.ChartOptions.xAxis.categories.Length;
            for(int index=0;index<nbc_column.ChartOptions.xAxis.categories.Length;index++)
            {
                dataseries.DataPoints.Add(new DataPoint { AxisXLabel = nbc_column.ChartOptions.xAxis.categories[index], YValue = 53+index*10, XValue = index });
            }
            
            chart.Series.Add(dataseries);
            LayoutRoot.Children.Add(chart);
        }
    }
}