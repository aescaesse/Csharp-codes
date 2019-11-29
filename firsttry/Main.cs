﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firsttry
{
    public partial class Main : UserControl
    {
        private double money;
        private double income;
        private double allearnings;
        private double allspendings;
 
        public double Money
        {
            get { return money; }
            set { money = value; }
        }
        public double Income
        {
            get { return income; }
            set { income = value; }
        }
        public double AllSpendings
        {
            get { return allspendings; }
            set { allspendings = value; }
        }
        public double AllEarnings
        {
            get { return allearnings; }
            set { allearnings = value; }
        }
        public string MoneyLabel
        {
            get { return moneyLabel.Text; }
            set { moneyLabel.Text = value; }
        }
        public string IncomeLabel
        {
            get { return incomeLabel.Text; }
            set { incomeLabel.Text = value; }
        }
        public Main(int money, int income, int allearnings, int allspendings)
        {
            this.money = money;
            this.income = income;
            this.allearnings = allearnings;
            this.allspendings = allspendings;
        }
        public Main()
        {
            InitializeComponent();
        }
        public void button1_Click(object sender, EventArgs e)
        {
            Form1 formz = new Form1();
            formz.Change();
        }
    }
}
