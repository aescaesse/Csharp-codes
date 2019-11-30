using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows.Forms.DataVisualization.Charting;

namespace firsttry
{
    public partial class Graph : UserControl
    {
        private int a;
        private int b;
        Timer timer3 = new Timer();
        public Graph()
        {
            InitializeComponent();
            LoadGraphParams();
            timer3.Interval = (1000);
            timer3.Tick += new EventHandler(timer3_Tick);
            timer3.Start();
        }
        string[] seriesArray = { "Current Money", "Current Income" };
        private void LoadGraphParams()
        {

            this.chart1.Palette = ChartColorPalette.SeaGreen;
            this.chart1.Titles.Add("Earnings");
            this.chart1.Series.Clear();
            for (int i = 0; i < seriesArray.Length; i++)
                chart1.Series.Add(seriesArray[i]);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            a = f1.Mon();
            b = f1.Inc();
            int[] pointsArray = { a, b };
            for (int i = 0; i < pointsArray.Length; i++)
            {
                chart1.Series[i].Points.Add(pointsArray[i]);
            }
        }
    }
}
