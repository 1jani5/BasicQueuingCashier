using System;
using System.Collections;
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
    public partial class CashierWindowQueueForm : Form
    {

        Timer timer = new Timer();
        private CashierClass cashier;
        CustomerView newform = new CustomerView();
        public CashierWindowQueueForm()
        {
            InitializeComponent();
            timer.Interval = (1 * 1000);// 1 sec.
            timer.Tick += new EventHandler(timer1_Tick); //timer1_tick represents the name of Tick Event
            timer.Start();
            panel1.BackColor = Color.FromArgb(100, Color.WhiteSmoke);

            cashier = new CashierClass();
            newform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(CashierClass.CashierQueue.Count > 0)
            {
                string remove = CashierClass.CashierQueue.Dequeue();              
                DisplayCashierQueue(CashierClass.CashierQueue);
                newform.UpdateNowServing(remove);
            }
            else
            {
                MessageBox.Show("No customers in the queue.");
            }
        }

        private void refbut1_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }


        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void CashierWindowQueueForm_Load(object sender, EventArgs e)
        {

        }
    }
    }

