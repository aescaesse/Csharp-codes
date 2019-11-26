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
    public partial class Economy : UserControl
    {
        public string Allearnings
        {
            get { return allEarnings.Text; }
            set { allEarnings.Text = value; }
        }
        public string Allspendings
        {
            get { return allSpendings.Text; }
            set { allSpendings.Text = value; }
        }
        public Economy()
        {
            InitializeComponent();
        }
    }
}
