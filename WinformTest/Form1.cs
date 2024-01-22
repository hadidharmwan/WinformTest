﻿using System;
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
            Form2 formNew = new Form2();
            this.Hide();
            formNew.ShowDialog();
            this.Close();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
        

            string id = textID.Text.ToString();
            string nama = textNama.Text.ToString();
            string tgl = textTgl.Text.ToString();
            string usia = textUsia.Text.ToString();
          


            string btn = btnEdit.Name;


            CRUD crd = new CRUD();

            crd.update(id,nama,tgl,usia);

            refreshForm();
            display();
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
