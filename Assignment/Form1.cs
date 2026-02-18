using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void S_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Tb1.Text == "" && Tb2.Text == "")
            {
                MessageBox.Show("Enter username and password", "Invalid Login", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }

            if (Tb1.Text == "Admin" && Tb2.Text == "123")
            {
                Form2 frn = new Form2();
                frn.Show();
                this.Hide();
            }
            else
            {
                if (Tb1.Text != ("Admin") && Tb2.Text != ("123"))
                {
                    MessageBox.Show("Invalid username and password", "Invalid Login", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                else
                {
                    if (Tb1.Text != "Admin")
                    {
                        MessageBox.Show("Invalid username", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (Tb2.Text != "123")
                    {
                        MessageBox.Show("Invalid password", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                Tb1.Clear();
                Tb2.Clear();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            if(Tb1.Text == "" && Tb2.Text == "")
            {
                MessageBox.Show("Enter username and password", "Invalid Login", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }

            if (Tb1.Text == "Admin" && Tb2.Text == "123")
            {
                Form2 frn = new Form2();
                frn.Show();
                this.Hide();
            }
            else
            {
                if (Tb1.Text != "Admin" && Tb2.Text != "123")
                {
                    MessageBox.Show("Invalid username and password", "Invalid Login", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                else
                {
                    if (Tb1.Text != "Admin")
                    {
                        MessageBox.Show("Invalid username", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (Tb2.Text != "123")
                    {
                        MessageBox.Show("Invalid password", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                Tb1.Clear();
                Tb2.Clear();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Tb1.Clear();
            Tb2.Clear();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Tb1.Clear();
            Tb2.Clear();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Tb1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Tb2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
