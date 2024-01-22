using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            display();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void display()
        {
            CRUD cek = new CRUD();
            dataGridView1.DataSource = cek.viewdata();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
