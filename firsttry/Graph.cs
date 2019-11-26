using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows.Forms.DataVisualization.Charting;

namespace firsttry
{
    public partial class Graph : UserControl
    {
        
        Timer timer1 = new Timer();
        public Graph()
        {
            InitializeComponent();
            LoadGraphParams();
            timer1.Interval = (1000);
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }
        int a = 1;
        int b = 2;
        string[] seriesArray = { "Earnings", "Time" };
        private void LoadGraphParams()
        {
            // Set palette.
            this.chart1.Palette = ChartColorPalette.SeaGreen;

            // Set title.
            this.chart1.Titles.Add("Earnings");

            // Add series
            this.chart1.Series.Clear();
            for (int i = 0; i < seriesArray.Length; i++)
            {
                chart1.Series.Add(seriesArray[i]);
            }
            // hook up timer event
            timer1.Tick += timer1_Tick;
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            a++;
            b++;
            int[] pointsArray = { a, b };

            for (int i = 0; i < pointsArray.Length; i++)
            {
                // Add point.
                chart1.Series[i].Points.Add(pointsArray[i]);
            }
        }
    }
}
