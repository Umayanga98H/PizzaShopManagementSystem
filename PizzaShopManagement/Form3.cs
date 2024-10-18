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
    public partial class PizzaDetails : Form
    {
        public PizzaDetails()
        {
            InitializeComponent();
        }

        private void PizzaDetails_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataSet51.Clear();
            sqlDataAdapter1.Fill(dataSet51);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
            btn_save.Enabled = true;
            btn_add.Enabled = false;
            btn_delete.Enabled = false;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Do you want to delete this row? ", "Delete", MessageBoxButtons.YesNo);if (result == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                    sqlDataAdapter1.Update(dataSet51);
                }
            }
            catch
            {
                MessageBox.Show("Please select the whole row instead of a cell");
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            sqlDataAdapter1.Update(dataSet51);
            dataGridView1.ReadOnly = true;
            btn_save.Enabled = false;
            btn_add.Enabled = true;
            btn_delete.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form Home = new Home();
            this.Hide();
            Home.ShowDialog();
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
