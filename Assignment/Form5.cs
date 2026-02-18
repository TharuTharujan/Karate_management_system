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
using System.Data.SqlClient;

namespace Assignment
{
    public partial class Form5 : Form
    {
        SqlConnection con = new SqlConnection(@" Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Assignment\Assignment\Assignment\Kickblast_Judo_Management_System.mdf;Integrated Security=True ");
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kickblast_Judo_Management_SystemDataSet7.Training_plan' table. You can move, or remove it, as needed.
            this.training_planTableAdapter.Fill(this.kickblast_Judo_Management_SystemDataSet7.Training_plan);

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Coaching WHERE Coaching_ID LIKE '" + TbcoachId.Text + "' ", con);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                datecrcoach.Text = sdr["Date_of_coaching_creation"].ToString();
                TbathId.Text = sdr["Athlete_ID"].ToString();
                Tbathname.Text = sdr["Athlete_name"].ToString();
                Tbcurrweigh.Text = sdr["Current_weight"].ToString();
                Tbweicat.Text = sdr["Weight_category"].ToString();
                TbtrainerId.Text = sdr["Trainer_ID"].ToString();
                Tbtrainername.Text = sdr["Trainer_name"].ToString();
                Tbtrainplan.Text = sdr["Training_plan"].ToString();
                Tbtrainfees.Text = sdr["Training_fees"].ToString();
                trainstartdate.Text = sdr["Training_start_date"].ToString();
                trainenddate.Text = sdr["Training_end_date"].ToString();
                Tbnoweeks.Text = sdr["No_of_weeks"].ToString();
                Tbtottrain.Text = sdr["Total_Amount_for_Training"].ToString();
                Tbpricoachhrs.Text = sdr["Private_Coaching_Hours"].ToString();
                Tbpricoachfees.Text = sdr["Private_coaching_fees"].ToString();
                pricoachstartdate.Text = sdr["Private_Coaching_Start_Date"].ToString();
                pricoachenddate.Text = sdr["Private_Coaching_End_Date"].ToString();
                Tbtotcoach.Text = sdr["Total_Amount_for_Coaching"].ToString();
                Tbnoofweeks.Text = sdr["No_of_weeks1"].ToString();
                Tbtottraincoach.Text = sdr["Total_Training_and_Coaching_Amount "].ToString();
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (TbcoachId.Text == "" || datecrcoach.Text == "" || TbathId.Text == "" || Tbathname.Text == "" || Tbcurrweigh.Text == "" || Tbweicat.Text == "" || TbtrainerId.Text == "" || Tbtrainername.Text == "" || Tbtrainplan.Text == "" || trainstartdate.Text == "" || trainenddate.Text == "" || Tbnoweeks.Text == "" || Tbtottrain.Text == "" || Tbpricoachhrs.Text == "" || pricoachstartdate.Text == "" || pricoachenddate.Text == "" || Tbtotcoach.Text == "" || Tbnoofweeks.Text == "" || Tbtottraincoach.Text == "" || Tbtrainfees.Text == "" || Tbpricoachfees.Text == "")
            {
                MessageBox.Show("Please Fill the Empty Fields");
            }
            else
            {
                //Save Button Code
                con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO Coaching(Coaching_ID,Date_of_coaching_creation,Athlete_ID,Athlete_name,Current_weight,Weight_category,Trainer_ID,Trainer_name,Training_plan,Training_fees,Training_start_date,Training_end_date,No_of_weeks,Total_Amount_for_Training,Private_Coaching_Hours,Private_coaching_fees,Private_Coaching_Start_Date,Private_Coaching_End_Date,Total_Amount_for_Coaching,No_of_weeks1,Total_Training_and_Coaching_Amount) Values('" + TbcoachId.Text + "','" + datecrcoach.Text + "','" + TbathId.Text + "','" + Tbathname.Text + "','" + Tbcurrweigh.Text + "','" + Tbweicat.Text + "','" + TbtrainerId.Text + "','" + Tbtrainername.Text + "','" + Tbtrainplan.Text + "','"+Tbtrainfees.Text+"','" + trainstartdate.Text + "','"+ trainenddate.Text + "','"+ Tbnoweeks.Text + "','"+ Tbtottrain.Text + "','"+ Tbpricoachhrs.Text + "','"+Tbpricoachfees.Text+"','"+ pricoachstartdate.Text + "','"+ pricoachenddate.Text + "','"+ Tbtotcoach.Text + "','"+ Tbnoofweeks.Text + "','"+ Tbtottraincoach.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved Successfully");
                
                con.Close();
                ClearCode(); //calling clear code
            }
        }
        public void ClearCode()
        {
            TbcoachId.Clear();           
            TbathId.Clear();
            Tbathname.Clear();
            Tbcurrweigh.Clear();
            Tbweicat.Clear();
            TbtrainerId.Clear();
            Tbtrainername.Clear();                        
            Tbnoweeks.Text ="0";
            Tbtottrain.Text ="0";
            Tbpricoachhrs.Text = "0";           
            Tbtotcoach.Text = "0";
            Tbnoofweeks.Text = "0";
            Tbtottraincoach.Text= "0";
            Tbtrainfees.Text = "0";
            Tbpricoachfees.Text = "0";

        }
               

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do You Want to Update the Data ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Coaching SET Coaching_ID='" + TbcoachId.Text + "',Date_of_coaching_creation='" + datecrcoach.Text + "',Athlete_ID='" + TbathId.Text + "',Athlete_name='" + Tbathname.Text + "',Current_weight='" + Tbcurrweigh.Text + "',Weight_category='" + Tbweicat.Text + "',Trainer_ID='" + TbtrainerId.Text + "',Trainer_name='" + Tbtrainername.Text + "',Training_plan='" + Tbtrainplan.Text + "',Training_fees='"+Tbtrainfees.Text+"',Training_start_date='" + trainstartdate.Text + "',Training_end_date='"+ trainenddate.Text + "',No_of_weeks='"+ Tbnoweeks.Text + "',Total_Amount_for_Training='"+ Tbtottrain.Text + "',Private_Coaching_Hours='"+ Tbpricoachhrs.Text + "',Private_coaching_fees='"+Tbpricoachfees.Text+"',Private_Coaching_Start_Date='" + pricoachstartdate.Text + "',Private_Coaching_End_Date='"+ pricoachenddate.Text + "',Total_Amount_for_Coaching='"+ Tbtotcoach.Text + "',No_of_weeks1='"+ Tbnoofweeks.Text + "',Total_Training_and_Coaching_Amount='"+ Tbtottraincoach.Text + "'  where Coaching_ID='" + TbcoachId.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully");
                
                con.Close();
                ClearCode();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do You Want Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Coaching WHERE Coaching_ID LIKE '" + TbcoachId.Text + "' ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Existing Coaching Details Deleted Successfull", "Coaching Details Deleted", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                
                con.Close();
                ClearCode();
            }
        }

        private void TbathId_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Assignment\Assignment\Assignment\Kickblast_Judo_Management_System.mdf;Integrated Security=True ");
            SqlCommand cmd = new SqlCommand("SELECT Athlete_name,Current_weight,Weight_category FROM Athlete WHERE Athlete_ID LIKE '" + TbathId.Text + "' ", con1);
            con1.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                Tbathname.Text = sdr["Athlete_name"].ToString();
                Tbcurrweigh.Text = sdr["Current_weight"].ToString();
                Tbweicat.Text = sdr["Weight_category"].ToString();

            }
            con1.Close();
        }

        private void TbtrainerId_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Assignment\Assignment\Assignment\Kickblast_Judo_Management_System.mdf;Integrated Security=True ");
            SqlCommand cmd = new SqlCommand("SELECT Trainer_name FROM Trainer WHERE Trainer_ID LIKE '" + TbtrainerId.Text + "' ", con2);
            con2.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                Tbtrainername.Text = sdr["Trainer_name"].ToString();             

            }
            con2.Close();
        }

        private void trainenddate_ValueChanged(object sender, EventArgs e)
        {
            DateTime startDate = trainstartdate.Value;
            DateTime endDate = trainenddate.Value;
            if (startDate > endDate)
            {
                MessageBox.Show("Start date should be earlier than end date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int totalDays = (endDate - startDate).Days;
            int totalWeeks = totalDays / 7;
            if (totalWeeks <= 0)
            {
                Tbnoweeks.Text = "1";
            }
            Tbnoweeks.Text = totalWeeks.ToString();

            if (Tbtrainfees.Text == "" || Tbnoweeks.Text == "")
            {
                MessageBox.Show("Please Fill the Empty Fields");
            }
            else
            {
                float num1 = float.Parse(Tbtrainfees.Text);
                float num2 = float.Parse(Tbnoweeks.Text);
                float sum = num1 * num2;
                Tbtottrain.Text = sum.ToString();
                Tbtottrain.Update();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void pricoachenddate_ValueChanged(object sender, EventArgs e)
        {
            DateTime startDate = pricoachstartdate.Value;
            DateTime endDate = pricoachenddate.Value;

            if (startDate > endDate)
            {
                MessageBox.Show("Start date should be earlier than end date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int totalDays = (endDate - startDate).Days;
            int totalWeeks = totalDays / 7;
            if (totalWeeks <= 0)
            {
                Tbnoofweeks.Text = "1";
            }
            Tbnoofweeks.Text = totalWeeks.ToString();

            if (Tbpricoachfees.Text == "" || Tbnoofweeks.Text == "")
            {
                MessageBox.Show("Please Fill the Empty Fields");
            }
            else
            {
                float num1 = float.Parse(Tbpricoachfees.Text);
                float num2 = float.Parse(Tbnoofweeks.Text);
                float num3 = float.Parse(Tbpricoachhrs.Text);
                float sum = num1 * num2 * num3;
                Tbtotcoach.Text = sum.ToString();
                Tbtotcoach.Update();
            }
        }

        private void Tbtotcoach_TextChanged(object sender, EventArgs e)
        {
            double tac, tat, ta;
            tat = double.Parse(Tbtottrain.Text);
            tac = double.Parse(Tbtotcoach.Text);
            ta = tat + tac;
            Tbtottraincoach.Text = ta.ToString();
        }

        private void Tbtottrain_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tbpricoachhrs_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tbpricoachfees_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tbnoofweeks_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form7 frn = new Form7();
            frn.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form2 frn = new Form2();
            frn.Show();
            this.Hide();
        }

        private void trainstartdate_ValueChanged(object sender, EventArgs e)
        {
            if (trainstartdate.Value <= trainenddate.Value)
            {
                MessageBox.Show("Change Training End Date!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Tbtrainplan_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con5 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Assignment\Assignment\Assignment\Kickblast_Judo_Management_System.mdf;Integrated Security=True ");
            SqlCommand cmd = new SqlCommand("SELECT Price FROM Training_plan WHERE Training_plan LIKE '" + Tbtrainplan.Text + "' ", con5);
            con5.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                Tbtrainfees.Text = sdr["Price"].ToString();
            }
            con5.Close();
        }

        private void pricoachstartdate_ValueChanged(object sender, EventArgs e)
        {
            if (pricoachstartdate.Value <= pricoachenddate.Value)
            {
                MessageBox.Show("Change Private Coaching End Date!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TbcoachId_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TbcoachId.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                TbcoachId.Text = TbcoachId.Text.Remove(TbcoachId.Text.Length - 1);
            }
        }
    }
}
