using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaShopManagement
{
    public partial class OrderDetails : Form
    {
        public OrderDetails()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form Home = new Home();
            this.Hide();
            Home.ShowDialog();
            this.Show();
        }

        private void btnOrderNow_Click(object sender, EventArgs e)
        {
            Form OrderNowForm = new OrderNowForm();
            this.Hide();
            OrderNowForm.ShowDialog();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            {
                dataSet41.Clear();
                sqlDataAdapter1.Fill(dataSet41);
            }
        }
    }
}
