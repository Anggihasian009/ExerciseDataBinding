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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);
            // TODO: This line of code loads data into the 'adventureWorksDataSet.Address' table. You can move, or remove it, as needed.
            this.addressTableAdapter1.Fill(this.adventureWorksDataSet.Address);
            // TODO: This line of code loads data into the 'adventureWorksDataSet1.Address' table. You can move, or remove it, as needed.
            this.addressTableAdapter.Fill(this.adventureWorksDataSet1.Address);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
