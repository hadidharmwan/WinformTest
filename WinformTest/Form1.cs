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
        public static string IDKaryawan = "";
        public static string NmKaryawn = "";
        public static string TglmasukKerja ="";
        public static string Usia ="";
      



        private void button1_Click(object sender, EventArgs e)
        {
            Form2 toForm = new Form2();
            //this.Hide();
            //formNew.ShowDialog();
            //this.Close();
            toForm.Show();
        }

        public void display()
        {
            CRUD cek = new CRUD();
            dataGridView1.DataSource = cek.viewdata();
        }
        void refreshForm()
        {
            textID.Text = "";
            textNama.Text = "";
            textTgl.Text = "";
            textUsia.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

     
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string usia = textUsia.Text.ToString();
            string usia1 = textUsia1.Text.ToString();
            CRUD sc = new CRUD();
            //sc.searchByUsia(usia)


            if (textUsia.Text == "" && textUsia1.Text == "")
            {
                dataGridView1.DataSource = sc.viewdata();
            }
            else { dataGridView1.DataSource = sc.searchByUsia(textUsia.Text, textUsia1.Text); }




        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            IDKaryawan = textID.Text;
            NmKaryawn = textNama.Text;
            TglmasukKerja = textTgl.Text;
            Usia = textUsia.Text;

            Form2 toForm = new Form2();
            toForm.Show();
            //string id = textID.Text.ToString();
            //string nama = textNama.Text.ToString();
            //string tgl = textTgl.Text.ToString();
            //string usia = textUsia.Text.ToString();
            //string btn = btnEdit.Name;
            //CRUD crd = new CRUD();
            //crd.update(id,nama,tgl,usia);
            //refreshForm();
            //display();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = textID.Text.ToString();
            CRUD cre = new CRUD();
            cre.delete(id);
            display();
            refreshForm();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            string id = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            string nm = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            string tg = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            string us = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
     
            textID.Text = id;
            textNama.Text = nm;
            textTgl.Text = tg;
            textUsia.Text = us;
    
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
