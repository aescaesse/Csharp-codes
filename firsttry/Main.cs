using System;
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
        private int money;
        private int income;
        private int allearnings;
        private int allspendings;
        private int day;
        public int Money
        {
            get { return money; }
            set { money = value; }
        }
        public int Income
        {
            get { return income; }
            set { income = value; }
        }
        public int AllSpendings
        {
            get { return allspendings; }
            set { allspendings = value; }
        }
        public int AllEarnings
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
       
    }
}
