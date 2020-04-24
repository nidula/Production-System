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
    public partial class Form2 : Form
    {
        private string id;
        
        public Form2()
        {
            InitializeComponent();
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
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
            if (textBox39.Text == "")
            {
                MessageBox.Show("Please calculate and update data");
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\c# Assignment Software\product.mdf';Integrated Security=True;Connect Timeout=30");
                string query = "update oee set date ='" + textBox19.Text + "',start_time='" + textBox20.Text + "' ,end_time='" + textBox21.Text + "' ,no_production='" + textBox22.Text + "',development_time='" + textBox23.Text + "',planned_downtime='" + textBox24.Text + "',planned_pro_time_hrs='" + textBox1.Text + "',total_min='" + textBox2.Text + "',mc_bd='" + textBox4.Text + "',changeover_production='" + textBox5.Text + "',changeover_reel='" + textBox6.Text + "',batch_co='" + textBox7.Text + "',less_workers='" + textBox8.Text + "',material_issues='" + textBox9.Text + "',tablet_crashing='" + textBox10.Text + "',startup_time='" + textBox11.Text + "',cleaning='" + textBox12.Text + "',misc='" + textBox13.Text + "',total_downtime='" + textBox14.Text + "',total_min_available_pro='" + textBox15.Text + "',availability_rate='" + textBox17.Text + "',actual_production='" + textBox25.Text + "',rework='" + textBox27.Text + "',defects='" + textBox28.Text + "',sample='" + textBox29.Text + "',total_rejectins='" + textBox30.Text + "',actual_output='" + textBox31.Text + "',quality_rate='" + textBox33.Text + "',target_output_shift='" + textBox35.Text + "',performance_rate='" + textBox37.Text + "',OEE='" + textBox39.Text + "' where id='" + get_id() + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Updated");
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

        public void set_textBox19(String value)
        {
            this.textBox19.Text = value;
        }
        public void set_textBox20(String value)
        {
            this.textBox20.Text = value;
        }
        public void set_textBox21(String value)
        {
            this.textBox21.Text = value;
        }
        public void set_textBox22(String value)
        {
            this.textBox22.Text = value;
        }
        public void set_textBox23(String value)
        {
            this.textBox23.Text = value;
        }
        public void set_textBox24(String value)
        {
            this.textBox24.Text = value;
        }
        public void set_textBox2(String value)
        {
            this.textBox2.Text = value;
        }
        public void set_textBox4(String value)
        {
            this.textBox4.Text = value;
        }
        public void set_textBox5(String value)
        {
            this.textBox5.Text = value;
        }
        public void set_textBox6(String value)
        {
            this.textBox6.Text = value;
        }
        public void set_textBox7(String value)
        {
            this.textBox7.Text = value;
        }
        public void set_textBox8(String value)
        {
            this.textBox8.Text = value;
        }
        public void set_textBox9(String value)
        {
            this.textBox9.Text = value;
        }
        public void set_textBox10(String value)
        {
            this.textBox10.Text = value;
        }
        public void set_textBox11(String value)
        {
            this.textBox11.Text = value;
        }
        public void set_textBox12(String value)
        {
            this.textBox12.Text = value;
        }
        public void set_textBox25(String value)
        {
            this.textBox25.Text = value;
        }
        public void set_textBox27(String value)
        {
            this.textBox27.Text = value;
        }
        public void set_textBox28(String value)
        {
            this.textBox28.Text = value;
        }
        public void set_textBox29(String value)
        {
            this.textBox29.Text = value;
        }
        public void set_id(string value)
        {
            id = value;
        }
        public string get_id()
        {
            return id;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("Please Fill Required fields");
            }

            else
            {

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\c# Assignment Software\product.mdf';Integrated Security=True;Connect Timeout=30");
                string query = "delete from oee where id = '" + textBox3.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record deleted");
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.ToString());

                }
                finally
                {
                    con.Close();


                }
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
