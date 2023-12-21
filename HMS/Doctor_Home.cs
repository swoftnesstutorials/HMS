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

namespace HMS
{
    public partial class Doctor_Home : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\hp\Documents\SQL Server Management Studio\HMSDB.mdf"";Integrated Security=True;Connect Timeout=30");
        public Doctor_Home()
        {
            InitializeComponent();
        }
        void populate()
        {
            con.Open();
            string query = "select * from patient"; 
            SqlDataAdapter ad = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(ad);
            var ds = new DataSet();
            ad.Fill(ds);
            doctorhomeGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void Doctor_Home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void PatientGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
