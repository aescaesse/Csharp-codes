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
        Timer timer1 = new Timer();
        Main main1 = new Main();
        int a;
        int b = 1;
        public Graph()
        {
            InitializeComponent();
            LoadGraphParams();
            timer1.Interval = (1000);
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }
        string[] seriesArray = { "Current Money", "Current Income" };
        private void LoadGraphParams()
        {
            this.chart1.Palette = ChartColorPalette.SeaGreen;
            this.chart1.Titles.Add("Earnings");
            this.chart1.Series.Clear();
            for (int i = 0; i < seriesArray.Length; i++)
                chart1.Series.Add(seriesArray[i]);
            timer1.Tick += timer1_Tick; 
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
           /* int.TryParse(main1.IncomeLabel, out b);*/
            if (int.TryParse(main1.MoneyLabel, out a))
            {
                throw new Exception(main1.IncomeLabel);
            }
            int[] pointsArray = { a, b };
            for (int i = 0; i < pointsArray.Length; i++)
            {
                chart1.Series[i].Points.Add(pointsArray[i]);
            }
        }
    }
}
