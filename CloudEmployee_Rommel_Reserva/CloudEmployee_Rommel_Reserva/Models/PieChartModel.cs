using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudEmployee_Rommel_Reserva.Models
{
    public class PieChartModel
    {
        public class ChartData
        {

            public static List<ChartData> GetPieChartData()
            {
                var data = new List<ChartData>();

                data.Add(new ChartData("Apple", 65));
                data.Add(new ChartData("Asus", 58));
                data.Add(new ChartData("Dell", 30));
                data.Add(new ChartData("Lenovo", 60));
                data.Add(new ChartData("Acer", 65));
                data.Add(new ChartData("Sony", 75));

                return data;
            }

            public ChartData(string label, double value1)
            {
                this.Label = label;
                this.Value1 = value1;
            }

            public string Label { get; set; }
            public double Value1 { get; set; }
        }
    }
}