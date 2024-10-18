using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PizzaShopManagement
{
    public partial class OrderNowForm : Form
    {

        private double pizzaPrice = 0;
        private int quantity = 0;
        private bool isTakeaway = false;

        // Event handler for the Takeaway option
        private void rdoTakeaway_CheckedChanged(object sender, EventArgs e)
        {
            isTakeaway = radioButtonTakeaway.Checked;
            UpdateTotalPrice();
        }

        // Event handler for the Dine-In option
        private void rdoDineIn_CheckedChanged(object sender, EventArgs e)
        {
            isTakeaway = !radioButtonDineIn.Checked;
            UpdateTotalPrice();
        }

        private void btnQuantity_Click_1(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter quantity:", "Quantity", "0", -1, -1);

            if (int.TryParse(input, out int result) && result >= 0)
            {
                quantity = result;
                lblQuantity.Text = quantity.ToString();
                UpdateTotalPrice();
            }
            else
            {
                MessageBox.Show("Please enter a valid quantity.");
            }
        }

        // Update the total price based on pizza price, quantity, and takeaway
        private void UpdateTotalPrice()
        {
            double totalPrice = pizzaPrice * quantity;

            if (isTakeaway)
            {
                totalPrice += 20 * quantity;  // Rs. 20 for each pizza in takeaway option
            }

            lblTotalPrice.Text = $"Rs. {totalPrice:0.00}";
        }

        private void btnTotalPrice_Click_1(object sender, EventArgs e)
        {
            if (double.TryParse(txtPrice.Text, out pizzaPrice))
            {
                UpdateTotalPrice();
            }
            else
            {
                MessageBox.Show("Please enter a valid pizza price.");
            }
        }

        private void Count()
        {
            int records, current;
            records = this.BindingContext[dataSet31, "Pizza_Details"].Count;
            current = this.BindingContext[dataSet31, "Pizza_Details"].Position + 1;
            lblCount2.Text = "Item " + current + " of " + records;
        }

        public OrderNowForm()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dataSet31.Clear();
            sqlDataAdapter1.Fill(dataSet31);
            Count();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            this.BindingContext[dataSet31, "Pizza_Details"].Position -= 1;
            Count();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.BindingContext[dataSet31, "Pizza_Details"].Position += 1;
            Count();

        }

        private void OrderNowForm_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Home = new Home();
            this.Hide();
            Home.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text) || string.IsNullOrEmpty(txtContactNumber.Text))
            {
                MessageBox.Show("Please fill in all customer details.");
                return;
            }

            string customerDetails = $"Customer Details:\nFirst Name: {txtFirstName.Text}\nLast Name: {txtLastName.Text}\nContact: {txtContactNumber.Text}";
            string orderDetails = $"\nOrder Details:\nChoice: {txtChoice.Text}\nCategory: {txtCategory.Text}\nPrice: Rs. {pizzaPrice}\nQuantity: {quantity}\nTotal Price: {lblTotalPrice.Text}\nMethod: {(isTakeaway ? "Takeaway" : "Dine-In")}";

            try
            {
                using (StreamWriter sw = new StreamWriter("D:\\DEMO\\Academic yr 2022_23\\Visual Programming\\22_23_Visual\\PP\\PizzaShop-EXAM\\PizzaShopManagement\\PizzaShopManagement\\Order.txt"))
                {
                    sw.WriteLine(customerDetails);
                    sw.WriteLine(orderDetails);
                }

                MessageBox.Show("Order saved to file successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving to file: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                
                Process.Start(@"D:\\DEMO\\Academic yr 2022_23\\Visual Programming\\22_23_Visual\\PP\\PizzaShop-EXAM\\PizzaShopManagement\\PizzaShopManagement\\Order.txt");
            }
            catch
            {
                MessageBox.Show("No file found.");
            }
        }
    }
}
