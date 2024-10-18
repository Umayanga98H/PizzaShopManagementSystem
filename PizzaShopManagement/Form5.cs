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
    public partial class SignUp : Form
    {
        public SignUp()
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

        private void btnOrder_Click(object sender, EventArgs e)
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text != "" && txtLastName.Text != "" && txtEmail.Text != "" && txtContact.Text != "" && txtCity.Text != "")
            {
                string firstName = txtFirstName.Text;

                MessageBox.Show($"Congratulations {firstName}! You have successfully registered for rewards. Stay with us.","Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sorry, you should fill all the fields to register!","Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
    }
