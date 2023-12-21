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

namespace HMS
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\hp\Documents\SQL Server Management Studio\HMSDB.mdf"";Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DocName.Text == "" && Pass.Text == "")
            {
                lbltext.Text = "please insert the username and password";
            }
                if (DocName.Text == "Administrator" && Pass.Text == "Ad123")
            {
                this.Hide();
                Home Home = new Home();
                Home.ShowDialog();
            }
            SqlDataAdapter sda=new SqlDataAdapter("select count(*) from Doctors where Doc_Name='"+DocName.Text+"' and Doc_Pass='"+Pass.Text+"'",con);
            DataTable dt=new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() =="1")
            {
                this.Hide();
                D_Home Doctor_Home = new D_Home();
                Doctor_Home.ShowDialog();
            }
            else
            {
                lbltext.Text="Wrong Password OR User Name";
                lbltext.Visible=true;
               
            }
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want  To Exit ","Exit",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                this.Close();

            }
            else
            {
                this.Show();
            }
        }
    }
}
