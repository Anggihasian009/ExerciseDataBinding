using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBinding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            textUserName.Clear();
            textPassword.Clear();
            textUserName.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textUserName.Text == "Anggi" && textPassword.Text == "1234") 

            {
                new Form3().Show();
                this.Hide();
               
            }

            else

            
        
            {
                MessageBox.Show("The user name of password you entered in incorrecte, try Again");
                textUserName.Clear();
                textPassword.Clear();
                textUserName.Focus();


            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void textUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
