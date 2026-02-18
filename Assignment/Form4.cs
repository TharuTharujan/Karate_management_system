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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Xml.Linq;
using System.Data.SqlClient; //SQL Header


namespace Assignment
{
    public partial class Form4 : Form
    {
        SqlConnection con = new SqlConnection(@" Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Assignment\Assignment\Assignment\Kickblast_Judo_Management_System.mdf;Integrated Security=True "); //connection string
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kickblast_Judo_Management_SystemDataSet4.Trainer' table. You can move, or remove it, as needed.
            this.trainerTableAdapter.Fill(this.kickblast_Judo_Management_SystemDataSet4.Trainer);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Trainer WHERE Trainer_ID LIKE '" + TbId.Text + "' ", con);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                Tbname.Text = sdr["Trainer_name"].ToString();
                Tbnic.Text = sdr["NIC_No"].ToString();
                Tbcon.Text = sdr["Contact_No"].ToString();
                Tbadd.Text = sdr["Address"].ToString();
                Tbexp.Text = sdr["Experience"].ToString();
                Tbqual.Text = sdr["Qualification"].ToString();
                Tbsal.Text = sdr["Salary"].ToString();
            }
            else
            {
                ClearCode();
                MessageBox.Show("Data Not Found");
            }
            con.Close();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            //Number Only Validation
            if (System.Text.RegularExpressions.Regex.IsMatch(Tbsal.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Tbsal.Text = Tbsal.Text.Remove(Tbsal.Text.Length - 1);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Tbcon.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Tbcon.Text = Tbcon.Text.Remove(Tbcon.Text.Length - 1);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Tbnic.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Tbnic.Text = Tbnic.Text.Remove(Tbnic.Text.Length - 1);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TbId.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                TbId.Text = TbId.Text.Remove(TbId.Text.Length - 1);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (TbId.Text == "" || Tbname.Text == "" || Tbnic.Text == "" || Tbcon.Text == "" || Tbadd.Text == "" || Tbexp.Text == "" || Tbqual.Text == "" || Tbsal.Text == "")
            {
                MessageBox.Show("Please fill the empty fields", "Sorry!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Save Button Code
                con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO Trainer(Trainer_ID,Trainer_name,NIC_No,Contact_No,Address,Qualification,Experience,Salary) Values('" + TbId.Text + "','" + Tbname.Text + "','" + Tbnic.Text + "','" + Tbcon.Text + "','" + Tbadd.Text + "','" + Tbqual.Text + "','" + Tbexp.Text + "','" + Tbsal.Text + "')", con);
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
            Tbqual.Clear();
            Tbexp.Clear();
            Tbsal.Clear();         
        }

        // Grid view Refresh code
        public void gridviewUpdate()
        {

            string select = "SELECT * from Trainer";
            SqlDataAdapter da = new SqlDataAdapter(select, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Trainer");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Trainer";

        }


        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do You Want to Update the Data ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Trainer SET Trainer_name='" + Tbname.Text + "',NIC_No='" + Tbnic.Text + "',Contact_No='" + Tbcon.Text + "',Address='" + Tbadd.Text + "',Qualification='" + Tbqual.Text + "',Experience='" + Tbexp.Text + "',Salary='" + Tbsal.Text + "' where Trainer_ID='" + TbId.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully");
                gridviewUpdate();
                con.Close();
                ClearCode();

            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (TbId.Text == "")
            {
                MessageBox.Show("Please Fill the ID");

            }
            else
            {
                if (MessageBox.Show("Do You Want To Remove This Data", "Remove Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Trainer WHERE Trainer_ID LIKE '" + TbId.Text + "' ", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Existing Trainer Details Deleted Successfull", "Trainer Details Deleted", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    gridviewUpdate();
                    con.Close();
                    ClearCode() ;
                }

                else
                {

                }

            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form2 frn = new Form2();
            frn.Show();
            this.Hide();
        }
    }
}
