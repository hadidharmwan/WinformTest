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
            
            textID.Text = Form1.IDKaryawan;
            textNama.Text = Form1.NmKaryawn;
            textTgl.Text = Form1.TglmasukKerja;
            textUsia.Text = Form1.Usia;
            if(textID.Text == "")
            {

            btnSave.Text = "Save";
            }
            else
            {
                btnSave.Text ="Update";
            }
           
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
            CRUD crd = new CRUD();
            if(btnSave.Text == "Save")
            {
                crd.insert(id,nama,tgl,usia);
                Form1 toForm = new Form1();
                this.Hide();
                toForm.ShowDialog();
                this.Close();

            }
            else if(btnSave.Text == "Update")
            {
                crd.update(id, nama, tgl, usia);
                Form1 toForm = new Form1();
                this.Hide();
                toForm.ShowDialog();
                this.Close();

            }



        }


        void refreshForm()
        {
            textID.Text = "";
            textNama.Text = "";
            textTgl.Text = "";
            textUsia.Text = "";
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 toForm = new Form1();
            this.Hide();
            toForm.ShowDialog();
            this.Close();
        }
    }
}
