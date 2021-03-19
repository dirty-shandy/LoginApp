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

namespace loginSystem
{
    public partial class Form1 : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sasha\OneDrive\מסמכים\LogimForm.mdf;Integrated Security=True;Connect Timeout=30");   
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select COUNT(*) FROM UserTable where UserName = '" + usernametb.Text + "'and Password= '"+ passwordtb.Text +"'" , cn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                new HomeForm().Show();
            }
            else
                MessageBox.Show("Invalid Username or Password");


            cn.Close();


        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
