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
    public partial class datagrid : Form
    {
       
        public static object Rows { get; private set; }

        public datagrid()
        {
            InitializeComponent();
        }

        private void Datagrid_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productDataSet1.oee' table. You can move, or remove it, as needed.
            this.oeeTableAdapter1.Fill(this.productDataSet1.oee);
            // TODO: This line of code loads data into the 'productDataSet.oee' table. You can move, or remove it, as needed.
            this.oeeTableAdapter.Fill(this.productDataSet.oee);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\c# Assignment Software\product.mdf';Integrated Security=True;Connect Timeout=30");
            //sda = new SqlDataAdapter("");

        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            //DataGrid dataList = new DataGrid();

            String A = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            String B = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            String C = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            String D = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
            String E = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
            String F = dataGridView1.Rows[rowIndex].Cells[6].Value.ToString();
            String G = dataGridView1.Rows[rowIndex].Cells[9].Value.ToString();
            String H = dataGridView1.Rows[rowIndex].Cells[10].Value.ToString();
            String I = dataGridView1.Rows[rowIndex].Cells[11].Value.ToString();
            String J = dataGridView1.Rows[rowIndex].Cells[12].Value.ToString();
            String K = dataGridView1.Rows[rowIndex].Cells[13].Value.ToString();
            String L = dataGridView1.Rows[rowIndex].Cells[14].Value.ToString();
            String M = dataGridView1.Rows[rowIndex].Cells[15].Value.ToString();
            String N = dataGridView1.Rows[rowIndex].Cells[16].Value.ToString();
            String O = dataGridView1.Rows[rowIndex].Cells[17].Value.ToString();
            String P = dataGridView1.Rows[rowIndex].Cells[18].Value.ToString();
            String Q = dataGridView1.Rows[rowIndex].Cells[22].Value.ToString();
            String R = dataGridView1.Rows[rowIndex].Cells[23].Value.ToString();
            String S = dataGridView1.Rows[rowIndex].Cells[24].Value.ToString();
            String T = dataGridView1.Rows[rowIndex].Cells[25].Value.ToString();
            String Z = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();

            Form2 f2 = new Form2();

            f2.set_textBox19(Convert.ToString(A));
            f2.set_textBox20(Convert.ToString(B));
            f2.set_textBox21(Convert.ToString(C));
            f2.set_textBox22(Convert.ToString(D));
            f2.set_textBox23(Convert.ToString(E));
            f2.set_textBox24(Convert.ToString(F));
            f2.set_textBox2(Convert.ToString(G));
            f2.set_textBox4(Convert.ToString(H));
            f2.set_textBox5(Convert.ToString(I));
            f2.set_textBox6(Convert.ToString(J));
            f2.set_textBox7(Convert.ToString(K));
            f2.set_textBox8(Convert.ToString(L));
            f2.set_textBox9(Convert.ToString(M));
            f2.set_textBox10(Convert.ToString(N));
            f2.set_textBox11(Convert.ToString(O));
            f2.set_textBox12(Convert.ToString(P));
            f2.set_textBox25(Convert.ToString(Q));
            f2.set_textBox27(Convert.ToString(R));
            f2.set_textBox28(Convert.ToString(S));
            f2.set_textBox29(Convert.ToString(T));
            f2.set_id(Convert.ToString(Z));

            f2.Show();
            

            //MessageBox.Show(A);
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void Button1_Click_1(object sender, EventArgs e)
        {
            
           
            
        }

        private void Button1_Click_2(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
