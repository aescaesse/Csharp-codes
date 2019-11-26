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
    public partial class Form1 : Form
    {
        Point lastClick;
        Main start = new Main(100, 40,0,0);
        public Form1()
        {
            InitializeComponent();
            SetEverything();
            BottomPanel.Width = button1.Width;
            main1.BringToFront();
            main1.MoneyLabel = start.Money.ToString();
            main1.IncomeLabel = start.Income.ToString();
            Timer MyTimer = new Timer();
            MyTimer.Interval = (1000);
            MyTimer.Tick += new EventHandler(MyTimer_Tick);
            MyTimer.Start();
            Timer MyTimer2 = new Timer();
            MyTimer2.Interval = (1);
            MyTimer2.Tick += new EventHandler(MyTimer2_Tick);
            MyTimer2.Start();
        }
        private void ShowData()
        {
            main1.MoneyLabel = start.Money.ToString();
            main1.IncomeLabel = start.Income.ToString();
            economy1.Allearnings = start.AllEarnings.ToString();
            economy1.Allspendings = start.AllSpendings.ToString();
        }
        private void MyTimer_Tick(object sender, EventArgs e)
        {
            CalculateIncome();
            CheckIfOptionIsPossible();
            ShowData();
        }
        private void MyTimer2_Tick(object sender, EventArgs e)
        {
            CheckIfOptionIsPossible();
        }
        private void SetEverything()
        {
            main1.button1.Enabled = false;
            main1.button2.Enabled = false;
            main1.button3.Enabled = false;
        }
        private void CheckIfOptionIsPossible()
        {
            if (start.Money >= 150)
                main1.button1.Enabled = true;
            else
                main1.button1.Enabled = false;
            if (start.Money >= 500)
                main1.button2.Enabled = true;
            else
                main1.button2.Enabled = false;
            if (start.Money >= 700)
                main1.button3.Enabled = true;
            else
                main1.button3.Enabled = false;
        }
        private void CalculateIncome()
        {
            start.Money += start.Income;
            start.AllEarnings += start.Income;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            main1.MoneyLabel = start.Money.ToString();
            main1.IncomeLabel = start.Income.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            BottomPanel.Width = button1.Width;
            main1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BottomPanel.Width = button2.Width;
            economy1.BringToFront();
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
        }
        private void main1_button1_Click(object sender, EventArgs e)
        {
            start.Money -= 150;
            start.Income += 2;
            start.AllSpendings += 150;
            ShowData();
        }
        private void main1_button2_Click(object sender, EventArgs e)
        {
            start.Money -= 500;
            start.Income += 5;
            start.AllSpendings += 500;
            ShowData();
        }
        private void main1_button3_Click(object sender, EventArgs e)
        {
            start.Money -= 750;
            start.Income += 10;
            start.AllSpendings += 750;
            ShowData();
        }
    }
}
