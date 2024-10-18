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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form OrderNowForm = new OrderNowForm();
            this.Hide();  
            OrderNowForm.ShowDialog();  
            this.Show();  
        }

        private void homeToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void piToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form PizzaDetails = new PizzaDetails();
            this.Hide();
            PizzaDetails.ShowDialog();
            this.Show();
        }

        private void orderDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form OrderDetails = new OrderDetails();
            this.Hide();  
            OrderDetails.ShowDialog();  
            this.Show();  
        }

        private void signUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form SignUp = new SignUp();
            this.Hide();  
            SignUp.ShowDialog();  
            this.Show();  
        }
    }
}
    