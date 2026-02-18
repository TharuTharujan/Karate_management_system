using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;  //SQL Header


namespace Assignment
{
    public partial class Form6 : Form
    {
        SqlConnection con = new SqlConnection(@" Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Assignment\Assignment\Assignment\Kickblast_Judo_Management_System.mdf;Integrated Security=True ");
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kickblast_Judo_Management_SystemDataSet9.Competition' table. You can move, or remove it, as needed.
            this.competitionTableAdapter.Fill(this.kickblast_Judo_Management_SystemDataSet9.Competition);


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Competition WHERE Competition_ID LIKE '" + TbId.Text + "' ", con);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                datecrcomp.Text = sdr["Date_of_competition_creation"].ToString();
                TbcoachId.Text = sdr["Coaching_ID"].ToString();
                datecrcoach.Text = sdr["Date_of_coaching_creation"].ToString();
                TbathId.Text = sdr["Athlete_ID"].ToString();
                Tbathname.Text = sdr["Athlete_name"].ToString();
                Tbweightcurr.Text = sdr["Current_weight"].ToString();
                Tbweighcat.Text = sdr["Weight_category"].ToString();
                datecomp.Text = sdr["Date_of_competition"].ToString();
            }
            else
            {
                ClearCode();
                MessageBox.Show("Data Not Found");
            }
            con.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(@" Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Assignment\Assignment\Assignment\Kickblast_Judo_Management_System.mdf;Integrated Security=True ");
            SqlCommand cmd = new SqlCommand("SELECT Athlete_name,Current_weight,Weight_category FROM Athlete WHERE Athlete_ID LIKE '" + TbathId.Text + "' ", con1);
            con1.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                Tbathname.Text = sdr["Athlete_name"].ToString();
                Tbweightcurr.Text = sdr["Current_weight"].ToString();
                Tbweighcat.Text = sdr["Weight_category"].ToString();

            }
            con1.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (TbId.Text == "" || datecrcomp.Text == "" || TbcoachId.Text == "" || datecrcoach.Text == "" || TbathId.Text == "" || Tbathname.Text == "" || Tbweightcurr.Text == "" || Tbweighcat.Text == "" || datecomp.Text == "")
            {
                MessageBox.Show("Please Fill the Empty Fields");
            }
            else
            {
                //Save Button Code
                con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO Competition(Competition_ID,Date_of_competition_creation,Coaching_ID,Date_of_coaching_creation,Athlete_ID,Athlete_name,Current_weight,Weight_category,Date_of_competition) Values('" + TbId.Text + "','" + datecrcomp.Text + "','" + TbcoachId.Text + "','" + datecrcoach.Text + "','" + TbathId.Text + "','" + Tbathname.Text + "','" + Tbweightcurr.Text + "','" + Tbweighcat.Text + "','" + datecomp.Text + "')", con);
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
            TbcoachId.Clear();
            TbathId.Clear();
            Tbathname.Clear();
            Tbweightcurr.Clear();
            Tbweighcat.Clear();             
        }

        // Grid view Refresh code
        public void gridviewUpdate()
        {

            string select = "SELECT * from Competition";
            SqlDataAdapter da = new SqlDataAdapter(select, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Competition");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Competition";
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do You Want to Update the Data ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Competition SET Date_of_competition_creation='" + datecrcomp.Text + "',Coaching_ID='" + TbcoachId.Text + "',Date_of_coaching_creation='" + datecrcoach.Text + "',Athlete_ID='" + TbathId.Text + "',Athlete_name='" + Tbathname.Text + "',Current_weight='" + Tbweightcurr.Text + "',Weight_category='" + Tbweighcat.Text + "',Date_of_competition='" + datecomp.Text + "' where Competition_ID='" + TbId.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully");
                gridviewUpdate();
                con.Close();
                ClearCode();

            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want To Remove This Data", "Remove Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Competition WHERE Competition_ID LIKE '" + TbId.Text + "' ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Existing Competition Details Deleted Successfull", "Competition Details Deleted", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                gridviewUpdate();
                con.Close();
                ClearCode();
            }

            else
            {
                ClearCode();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Tbweighcat_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbcoachId_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con2 = new SqlConnection(@" Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Assignment\Assignment\Assignment\Kickblast_Judo_Management_System.mdf;Integrated Security=True ");
            SqlCommand cmd = new SqlCommand("SELECT Date_of_coaching_creation FROM Coaching WHERE Coaching_ID LIKE '" + TbcoachId.Text + "' ", con2);
            con2.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                datecrcoach.Text = sdr["Date_of_coaching_creation"].ToString();              

            }
            con2.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form2 frn = new Form2();
            frn.Show();
            this.Hide();
        }
    }
}
