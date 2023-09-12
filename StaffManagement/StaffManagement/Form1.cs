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

namespace StaffManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Staffdb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            con.Open();

            SqlCommand cnn = new SqlCommand("insert into Stafftable values(@id,@Name,@Email,@Salary)", con);

            cnn.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@Name", textBox2.Text);
            cnn.Parameters.AddWithValue("@Email", textBox3.Text);
            cnn.Parameters.AddWithValue("@Salary", int.Parse(textBox4.Text));

            cnn.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Record Saved Successfully");

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Staffdb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            con.Open();

            SqlCommand cnn = new SqlCommand("Select * from Stafftable", con);


            SqlDataAdapter da = new SqlDataAdapter(cnn);

            DataTable table = new DataTable();

            da.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Staffdb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();

            SqlCommand cnn = new SqlCommand("update Stafftable set Name=@Name, Email=@Email,Salary=@Salary where Id=@Id", con);

            cnn.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@Name", textBox2.Text);
            cnn.Parameters.AddWithValue("@Email", textBox3.Text);
            cnn.Parameters.AddWithValue("@Salary", int.Parse(textBox4.Text));

            cnn.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Record Updated Successfully");

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Staffdb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();

            SqlCommand cnn = new SqlCommand("delete Stafftable where Id=@Id", con);

            cnn.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));

            cnn.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Record Deleted Successfully");
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Staffdb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();

            SqlCommand cnn = new SqlCommand("Select * from Stafftable", con);


            SqlDataAdapter da = new SqlDataAdapter(cnn);

            DataTable table = new DataTable();

            da.Fill(table);

            dataGridView1.DataSource = table;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Staffdb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();

            SqlCommand cnn = new SqlCommand("Select * from Stafftable", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);

            DataTable table = new DataTable();

            da.Fill(table);

            dataGridView1.DataSource = table;

            label7.Text = table.Rows.Count.ToString();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            label8.Text = "0";

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                label8.Text = Convert.ToString(double.Parse(label8.Text) + double.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()));

            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap imagebmp = new Bitmap(dataGridView1.Width, dataGridView1.Height);

            dataGridView1.DrawToBitmap(imagebmp, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            e.Graphics.DrawImage(imagebmp, 5, 20);
        }
    }
}
