using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicQueuingCashier
{
    public partial class CustomerView : Form
    {
        public CustomerView()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(100, Color.WhiteSmoke);
            panel2.BackColor = Color.FromArgb(100, Color.WhiteSmoke);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void UpdateNowServing(string Number)
        {
            label2.Text = Number;
        }
    }
}
