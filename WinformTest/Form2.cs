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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string id = textID.Text.ToString();
            string nama = textNama.Text.ToString();
            string tgl = textTgl.Text.ToString();
            string usia = textUsia.Text.ToString();
         

            string btn = btnSave.Name;


            CRUD create = new CRUD();

            create.insert(id,nama,tgl,usia);
            refreshForm();
        }


        void refreshForm()
        {
            textID.Text = "";
            textNama.Text = "";
            textTgl.Text = "";
            textUsia.Text = "";
           
        }
    }
}
