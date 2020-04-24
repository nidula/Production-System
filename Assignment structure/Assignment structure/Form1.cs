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

namespace Assignment_structure
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

     
        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToLongDateString();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox18_TextChanged(object sender, EventArgs e)
        {

        }

        internal void show()
        {
            throw new NotImplementedException();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox19.Text == "" || textBox20.Text == "" || textBox21.Text == "" || textBox22.Text == "" || textBox23.Text == "" || textBox24.Text == "" || textBox2.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "" || textBox11.Text == "" || textBox12.Text == "" || textBox25.Text == "" || textBox27.Text == "" || textBox28.Text == "" || textBox29.Text == "")
            {
                MessageBox.Show("Please Fill Required data");
            }
            else
            {
                //textBox39.Text = Convert.ToString(oee);
                Main obj1 = new Main();
                obj1.set_et(Convert.ToDouble(textBox21.Text));
                obj1.set_st(Convert.ToDouble(textBox20.Text));
                obj1.set_nopro(Convert.ToDouble(textBox22.Text));
                obj1.set_devetime(Convert.ToDouble(textBox23.Text));
                obj1.set_plandown(Convert.ToDouble(textBox24.Text));
                double x = obj1.total_hours_work_bymin();
                textBox1.Text = Convert.ToString(x);

                Ar obj2 = new Ar();
                textBox17.Text = Convert.ToString(obj2.total_hours_work_byhrs(x));

                Ar obj3 = new Ar();
                obj3.set_mc(Convert.ToDouble(textBox2.Text));
                obj3.set_chpro(Convert.ToDouble(textBox4.Text));
                obj3.set_chreel(Convert.ToDouble(textBox5.Text));
                obj3.set_batchco(Convert.ToDouble(textBox6.Text));
                obj3.set_lesswo(Convert.ToDouble(textBox7.Text));
                obj3.set_materialiss(Convert.ToDouble(textBox8.Text));
                obj3.set_tacrashing(Convert.ToDouble(textBox9.Text));
                obj3.set_stuptime(Convert.ToDouble(textBox10.Text));
                obj3.set_cleaning(Convert.ToDouble(textBox11.Text));
                obj3.set_misc(Convert.ToDouble(textBox12.Text));
                double y = obj3.total_downtime();
                textBox13.Text = Convert.ToString(y);

                Ar obj4 = new Ar();
                double z = obj4.total_min_for_production(x, y);
                textBox14.Text = Convert.ToString(z);

                Ar obj5 = new Ar();
                textBox15.Text = Convert.ToString(obj5.availability_rate(x, z));

                Qr obj6 = new Qr();
                obj6.set_rwork(Convert.ToDouble(textBox27.Text));
                obj6.set_samples(Convert.ToDouble(textBox29.Text));
                obj6.set_defect(Convert.ToDouble(textBox28.Text));
                double p = obj6.total_rejections();
                textBox30.Text = Convert.ToString(p);

                Qr obj7 = new Qr();
                obj7.set_actpro(Convert.ToDouble(textBox25.Text));
                double q = obj7.actual_output(p);
                textBox31.Text = Convert.ToString(q);

                Qr obj8 = new Qr();
                obj8.set_actpro(Convert.ToDouble(textBox25.Text));
                textBox33.Text = Convert.ToString(Convert.ToString(obj8.quality_rate(q)));

                Pr obj9 = new Pr();
                double r = obj9.target_output_shift(z);
                textBox35.Text = Convert.ToString(r);

                Pr obj10 = new Pr();
                double s = obj10.perfomence_rate(q, r);
                textBox37.Text = Convert.ToString(s);

                oee obj11 = new oee();
                double t = obj11.calculate_oee(obj5.availability_rate(x, z), obj8.quality_rate(q), s);
                textBox39.Text = Convert.ToString(t);
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            if (textBox19.Text == ""|| textBox20.Text==""|| textBox21.Text==""|| textBox22.Text==""|| textBox23.Text == "" || textBox24.Text == ""|| textBox2.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "" || textBox11.Text == ""|| textBox12.Text=="" || textBox25.Text == "" || textBox27.Text == "" || textBox28.Text == "" || textBox29.Text == ""|| textBox39.Text=="")
            {
                MessageBox.Show("Please enter data and calculate them");
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\c# Assignment Software\product.mdf';Integrated Security=True;Connect Timeout=30");
                string query = "insert into oee(date,start_time,end_time,no_production,development_time,planned_downtime,planned_pro_time_hrs,total_min,mc_bd,changeover_production,changeover_reel,batch_co,less_workers,material_issues,tablet_crashing,startup_time,cleaning,misc,total_downtime,total_min_available_pro,availability_rate,actual_production,rework,defects,sample,total_rejectins,actual_output,quality_rate,target_output_shift,performance_rate,OEE)values('" + textBox19.Text + "','" + textBox20.Text + "','" + textBox21.Text + "','" + textBox22.Text + "','" + textBox23.Text + "','" + textBox24.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + textBox13.Text + "','" + textBox14.Text + "','" + textBox15.Text + "','" + textBox17.Text + "','" + textBox25.Text + "','" + textBox27.Text + "','" + textBox28.Text + "','" + textBox29.Text + "','" + textBox30.Text + "','" + textBox31.Text + "','" + textBox33.Text + "','" + textBox35.Text + "','" + textBox37.Text + "','" + textBox39.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Added");
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.ToString());
                    MessageBox.Show(ex.ToString());

                }
                finally
                {
                    con.Close();

                }
            }
            
           
        }

        private void Label47_Click(object sender, EventArgs e)
        {

        }

        private void Label43_Click(object sender, EventArgs e)
        {

        }

        private void TextBox33_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            new datagrid().Show();
            this.Hide();

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
