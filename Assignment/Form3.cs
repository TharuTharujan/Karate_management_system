using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient; //SQL Header

namespace Assignment
{
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Assignment\Assignment\Assignment\Kickblast_Judo_Management_System.mdf;Integrated Security=True "); //connection string
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kickblast_Judo_Management_SystemDataSet3.Athlete' table. You can move, or remove it, as needed.
            this.athleteTableAdapter.Fill(this.kickblast_Judo_Management_SystemDataSet3.Athlete);
            // TODO: This line of code loads data into the 'kickblast_Judo_Management_SystemDataSet2.Weight_category' table. You can move, or remove it, as needed.
            this.weight_categoryTableAdapter.Fill(this.kickblast_Judo_Management_SystemDataSet2.Weight_category);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (Tbheight.Text == "")
            {
                Tbheight.Text = "0";
            }
            if (Tbcurweight.Text == "")
            {
                Tbcurweight.Text = "0";
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(Tbcurweight.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Tbcurweight.Text = Tbcurweight.Text.Remove(Tbcurweight.Text.Length - 1);
            }

            double weight, height, bmi;
            weight = double.Parse(Tbcurweight.Text);
            height = double.Parse(Tbheight.Text);
            bmi = weight / (height * height);
            Tbbmi.Text = bmi.ToString();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Athlete WHERE Athlete_ID LIKE '" + TbId.Text + "' ", con);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                Tbname.Text = sdr["Athlete_name"].ToString();
                Tbnic.Text = sdr["NIC_No"].ToString();
                Tbcon.Text = sdr["Contact_No"].ToString();
                Tbadd.Text = sdr["Address"].ToString();
                Cmbweightcat.Text = sdr["Weight_category"].ToString();
                Tbheight.Text = sdr["Height"].ToString();
                Tbcurweight.Text = sdr["Current_weight"].ToString();
                Tbbmi.Text = sdr["BMI_index"].ToString();
                Tbbloodgrp.Text = sdr["Blood_group"].ToString();
            }
            else
            {
                ClearCode();
                MessageBox.Show("Data Not Found");
            }
            con.Close();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (TbId.Text == "" || Tbname.Text == "" || Tbnic.Text == "" || Tbcon.Text == "" || Tbadd.Text == "" || Tbcurweight.Text == "" || Tbheight.Text == "" || Tbbmi.Text == "" || Tbbloodgrp.Text == "")
            {
                MessageBox.Show("Please Fill the Empty Fields");
            }
            else
            {
                //Save Button Code
                con.Open();
                
                SqlCommand cmd = new SqlCommand("INSERT INTO Athlete(Athlete_ID,Athlete_name,NIC_No,Contact_No,Address,Height,Current_weight,Weight_category,Blood_group,BMI_index) Values('" + TbId.Text + "','" + Tbname.Text + "','" + Tbnic.Text + "','" + Tbcon.Text + "','" + Tbadd.Text + "','" + Tbheight.Text + "','" + Tbcurweight.Text + "','" + Cmbweightcat.Text + "','" + Tbbloodgrp.Text + "','" + Tbbmi.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved Successfully");
                gridviewUpdate();
                con.Close();
                ClearCode(); //calling clear code
            }
          
        }
        public void ClearCode()
        {
            TbId.Clear();
            Tbname.Clear();
            Tbnic.Clear();
            Tbcon.Clear();
            Tbadd.Clear();
            Tbcurweight.Text="0";           
            Tbheight.Text="0";
            Tbbmi.Text = "0";            
        }
        // Grid view Refresh code
        public void gridviewUpdate()
        {

            string select = "SELECT * from Athlete";
            SqlDataAdapter da = new SqlDataAdapter(select, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Athlete");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Athlete";

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do You Want to Update the Data ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Athlete SET Athlete_name='" + Tbname.Text + "',NIC_No='" + Tbnic.Text + "',Contact_No='" + Tbcon.Text + "',Address='" + Tbadd.Text + "',Current_weight='" + Tbcurweight.Text + "',Weight_category='" + Cmbweightcat.Text + "',Height='" + Tbheight.Text + "',BMI_index='" + Tbbmi.Text + "',Blood_group='" + Tbbloodgrp.Text + "'  where Athlete_ID='" + TbId.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully");
                gridviewUpdate();
                con.Close();
                ClearCode();
            }
        }
          
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do You Want Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Athlete WHERE Athlete_ID LIKE '" + TbId.Text + "' ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Existing Athlete Details Deleted Successfull", "Athlete Details Deleted", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                gridviewUpdate();
                con.Close();
                ClearCode() ;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 frn = new Form2();
            frn.Show();
            this.Hide();
        }

        private void TbId_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TbId.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                TbId.Text = TbId.Text.Remove(TbId.Text.Length - 1);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Tbbmi_TextChanged(object sender, EventArgs e)
        {
               
        }

        private void Tbcon_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Tbcon.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Tbcon.Text = Tbcon.Text.Remove(Tbcon.Text.Length - 1);
            }
        }

        private void Tbheight_TextChanged(object sender, EventArgs e)
        {
           
            
            if (System.Text.RegularExpressions.Regex.IsMatch(Tbheight.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Tbheight.Text = Tbheight.Text.Remove(Tbheight.Text.Length - 1);
                Tbcurweight.Text = "0";
                Tbbmi.Text = "0";
            }
            Tbcurweight.Text = "0";
            Tbbmi.Text = "0";
           
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Tbnic_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Tbnic.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Tbnic.Text = Tbnic.Text.Remove(Tbnic.Text.Length - 1);
            }
        }
    }
}
