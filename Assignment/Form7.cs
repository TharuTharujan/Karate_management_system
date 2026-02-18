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
using System.Data.SqlClient;

namespace Assignment
{
    public partial class Form7 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Assignment\Assignment\Assignment\Kickblast_Judo_Management_System.mdf;Integrated Security=True ");
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kickblast_Judo_Management_SystemDataSet10.Coaching' table. You can move, or remove it, as needed.
            this.coachingTableAdapter.Fill(this.kickblast_Judo_Management_SystemDataSet10.Coaching);
            gridviewUpdate();
            


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        public void gridviewUpdate()
        {

            string select = "SELECT * from Coaching";
            SqlDataAdapter da = new SqlDataAdapter(select, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Coaching");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Coaching";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form5 frn = new Form5();
            frn.Show();
            this.Hide();
        }
    }
}
