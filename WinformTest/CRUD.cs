using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WinformTest
{
    class CRUD
    {
        SqlConnection con = new SqlConnection();
        string sql = "Data Source =XC6089\\MSSQLSERVERS;Initial Catalog=db_test;User ID=sa;Password=123";
     
        public string insert(string idKaryawan, string nmKaryawan, string tglMasukKerja, string usia)
        {
          
            string pesan = "Gagal";
            string id = idKaryawan;
            string nama = nmKaryawan;
            string tgl = tglMasukKerja;
            string umur = usia;
            //string query = "";

            con.ConnectionString = sql;
            con.Open();

            //if (ubahButton == "Save") query = "INSERT INTO karyawan(IDKaryawan,NmKaryawan,TglMasukKerja,Usia) values (@idKaryawan,@nmKaryawan , @tglMasukKerja , @usia) ";
            //if (ubahButton == "Update") query = "update karyawan set NmKaryawan=@nmKaryawan, TglMasukKerja=@tglMasukKerja,Usia=@usia where IDKaryawan =@idKaryawan";
           string query = String.Format("INSERT INTO karyawan(IDKaryawan,NmKaryawan,TglMasukKerja,Usia) values (@idKaryawan,@nmKaryawan , @tglMasukKerja , @usia) ");
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("idKaryawan", id));
            cmd.Parameters.Add(new SqlParameter("nmKaryawan", nama));
            cmd.Parameters.Add(new SqlParameter("tglMasukKerja", tgl));
            cmd.Parameters.Add(new SqlParameter("usia", umur));
            cmd.ExecuteNonQuery();
            con.Close();
            pesan = "Sukses Daftar";
            return pesan;

        }
        public string update(string idKaryawan, string nmKaryawan, string tglMasukKerja, string usia)
        {

            string pesan = "sukses";

            string query = String.Format("update karyawan set NmKaryawan=@nmKaryawan, TglMasukKerja=@tglMasukKerja,Usia=@usia where IDKaryawan =@iDkaryawan");
            con.ConnectionString = sql;
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("iDkaryawan", idKaryawan));
            cmd.Parameters.Add(new SqlParameter("nmKaryawan", nmKaryawan));
            cmd.Parameters.Add(new SqlParameter("tglMasukKerja", tglMasukKerja));
            cmd.Parameters.Add(new SqlParameter("usia", usia));
            cmd.ExecuteNonQuery();
            con.Close();
            return pesan;

        }


        public string delete(string delete)
        {
            string str = "";
            string nb = delete;
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = sql;
            koneksi.Open();
            str = "delete from karyawan where IDKaryawan=@id";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("id", nb));
            cmd.ExecuteNonQuery();
            koneksi.Close();

            return str;
        }


        public DataTable viewdata()
        {
            DataTable table;
            string query = "select * from karyawan";
            SqlDataAdapter adpt = new SqlDataAdapter(query, sql);
            table = new DataTable();
            adpt.Fill(table);
            return table;
        }


        public DataTable searchByUsia(string usia, string usia1)
        {
            DataTable table;
            string query = "select * from karyawan where Usia Between "+usia+" and " +usia1;
         
            SqlDataAdapter adpt = new SqlDataAdapter(query, sql);
            table = new DataTable();
            adpt.Fill(table);
            return table;

        }

        public DataTable searchByTgl(string tgl, string tgl1)
        {
            DataTable table;
            string query = "select * from karyawan where TglMasukKerja Between " + tgl + " and " + tgl1;

            SqlDataAdapter adpt = new SqlDataAdapter(query, sql);
            table = new DataTable();
            adpt.Fill(table);
            return table;
        }
    }
}
