using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace HMS
{
    public partial class DoctorForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\hp\Documents\SQL Server Management Studio\HMSDB.mdf"";Integrated Security=True;Connect Timeout=30");
    
        public DoctorForm()
        {
            InitializeComponent();
        }
        void populate()
        {
            con.Open();
            string query = "select * from Doctors";
            SqlDataAdapter ad = new SqlDataAdapter(query,con);  
            SqlCommandBuilder builder= new SqlCommandBuilder(ad);
            var ds = new DataSet();
            ad.Fill(ds);
            DoctorGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {  if (Doc_ID.Text == "" || Doc_Name.Text == "" || Doc_Exp.Text == "" || Doc_Pass.Text == "")
                MessageBox.Show("No Missing Parts");
           

         
            con.Open();
            string i_d = Doc_ID.Text;
            string name = Doc_Name.Text.ToString();
            string exp = Doc_Exp.Text;
            int pass = (int.Parse(Doc_Pass.Text));

            string query = "INSERT INTO Doctors values("+Doc_ID.Text+",'"+Doc_Name.Text+"','"+Doc_Exp.Text+"','"+Doc_Pass.Text+"')";
            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\hp\Documents\SQL Server Management Studio\HMSDB.mdf"";Integrated Security=True;Connect Timeout=30"))

            {
                


                SqlCommand cmd = new SqlCommand(query, con);
                
                   
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doctor Succesefully Added");
                    con.Close();
                    populate();

                }

            }

        private void DoctorGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Doc_ID.Text = DoctorGV.SelectedRows[0].Cells[0].Value.ToString();
            Doc_Name.Text = DoctorGV.SelectedRows[1].Cells[0].Value.ToString();
            Doc_Exp.Text = DoctorGV.SelectedRows[2].Cells[0].Value.ToString();
            Doc_Pass.Text = DoctorGV.SelectedRows[3].Cells[0].Value.ToString();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "update Doctors set Doc_Name= '" + Doc_Name.Text + "', Doc_Exp='" + Doc_Exp.Text + "', Doc_Pass='" + Doc_Pass.Text + "' where Doc_ID='" + Doc_ID.Text + "'";
            SqlCommand cmd =new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Doctor Udated Sucessfully");
            con.Close();
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "delete from  Doctors where Doc_ID='" + Doc_ID.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Doctor Sucessfully Deleted");
            con.Close();
            populate();
        }
    }
    }

