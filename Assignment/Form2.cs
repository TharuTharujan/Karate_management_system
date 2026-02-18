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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kickblast_Judo_Management_SystemDataSet1.Weight_category' table. You can move, or remove it, as needed.
            this.weight_categoryTableAdapter.Fill(this.kickblast_Judo_Management_SystemDataSet1.Weight_category);
            // TODO: This line of code loads data into the 'kickblast_Judo_Management_SystemDataSet.Training_plan' table. You can move, or remove it, as needed.
            this.training_planTableAdapter.Fill(this.kickblast_Judo_Management_SystemDataSet.Training_plan);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form3 frn = new Form3();
            frn.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form3 frn = new Form3();
            frn.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form4 frn = new Form4();
            frn.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form4 frn = new Form4();
            frn.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form5 frn = new Form5();
            frn.Show();
            this.Hide();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form5 frn = new Form5();
            frn.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form6 frn = new Form6();
            frn.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Form6 frn = new Form6();
            frn.Show();
            this.Hide();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form1 frn = new Form1();
            frn.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
