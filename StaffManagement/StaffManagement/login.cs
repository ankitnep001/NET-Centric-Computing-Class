using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaffManagement
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text ==  "")
            {
                MessageBox.Show("Please enter username and passowrd");
            }

            else if (textBox1.Text == "admin" && textBox2.Text =="123")
            {
                Form1 form = new Form1();
                form.Show();
            }

            else
            {
                MessageBox.Show("Please enter correct Details");
            }
        }
    }
}
