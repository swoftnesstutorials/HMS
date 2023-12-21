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
    public partial class PatientForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\hp\Documents\SQL Server Management Studio\HMSDB.mdf"";Integrated Security=True;Connect Timeout=30");
        public PatientForm()
        {
            InitializeComponent();
        }
        void populate()
        {
            con.Open();
            string query = "select * from   Patient";
            SqlDataAdapter ad = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(ad);
            var ds = new DataSet();
            ad.Fill(ds);
            PatientGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
              //if (PatID.Text = "" || Pat_Name.Text == "" || Pat_Address.Text == "" || Pat_Phone.Text == "" || PatAge.Text==""|| PatGender.Text=="" || PatBload.Text="" || PatAddress.Text=="")
                   // MessageBox.Show("No Missing Parts");



                con.Open();
                string disease=PatDisease.Text.ToString();
                int Patage=int.Parse(PatAge.Text);
                string query = "INSERT INTO Patient values(" + PatID.Text + ",'" + PatName.Text + "','" + PatAddress.Text + "','" + PatPhone.Text + "','"+Patage+"','"+PatGender.SelectedItem.ToString()+"','"+PatBload.SelectedItem.ToString()+"','"+disease+"')";
                using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\hp\Documents\SQL Server Management Studio\HMSDB.mdf"";Integrated Security=True;Connect Timeout=30"))

                {



                    SqlCommand cmd = new SqlCommand(query, con);


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Succesefully Added");
                    con.Close();
                    populate();

                }

            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            populate(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string disease = PatDisease.Text.ToString();
            int Patage = int.Parse(PatAge.Text);
            string query = "update Patient set Pat_Name='" +Pat_Name.Text + "', Pat_Address='" + PatAddress.Text + "',Pat_Phone='" + PatPhone.Text + "',Pat_Age='"+Patage+ "',Pat_Gender='" + PatGender.SelectedItem.ToString()+ "',Pat_Bload='" + PatBload.SelectedItem.ToString()+ "',Pat_Disease='" + disease+"' where Pat_ID='"+PatID.Text+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Patient Udated Sucessfully");
            con.Close();
            populate();
        }

        private void PatientGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PatID.Text = PatientGV.SelectedRows[0].Cells[0].Value.ToString();
            PatName.Text = PatientGV.SelectedRows[0].Cells[1].Value.ToString();
            PatAddress.Text = PatientGV.SelectedRows[0].Cells[2].Value.ToString();
            PatPhone.Text = PatientGV.SelectedRows[0].Cells[3].Value.ToString();
            PatAge.Text = PatientGV.SelectedRows[0].Cells[4].Value.ToString();
            PatDisease.Text = PatientGV.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void PatID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pat_Name_Click(object sender, EventArgs e)
        {

        }

        private void Pat_Phone_Click(object sender, EventArgs e)
        {

        }

        private void PatDisease_TextChanged(object sender, EventArgs e)
        {

        }

        private void PatBload_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
