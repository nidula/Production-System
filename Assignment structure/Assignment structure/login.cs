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


namespace Assignment_structure
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            new signup().Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("Enter username and password");
                }
                else
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\c# Assignment Software\product.mdf';Integrated Security=True;Connect Timeout=30");
                    SqlCommand com = new SqlCommand("SELECT* FROM login WHERE username=@user and password=@pw", con);
                    con.Open();
                    com.Parameters.AddWithValue("@user", textBox1.Text);
                    com.Parameters.AddWithValue("@pw", textBox2.Text);
                    SqlDataReader Dr = com.ExecuteReader();
                    if (Dr.HasRows == true)
                    {
                        MessageBox.Show("You login successfully");
                        new Form1().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Check you username and password");
                    }
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }
    }
}
