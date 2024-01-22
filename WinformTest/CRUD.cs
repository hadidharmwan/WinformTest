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
        string sql = "Data Source =XC6089/MSSQLSERVERS;Initial Catalog=db_test;User ID=sa;Password=123";
     
        public string insert(string nmKaryawan, string tglMasukKerja, int usia)
        {
            string pesan = "Gagal";
  
            string nama = nmKaryawan;
            string tgl = tglMasukKerja;
            int umur = usia;

            string query = String.Format("INSERT INTO karyawan(NmKaryawan,TglMasukKerja,Usia) values (@nmKaryawan , @tglMasukKerja , @usia) ");
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("nmKaryawan", nama));
            cmd.Parameters.Add(new SqlParameter("tglMasukKerja", tgl));
            cmd.Parameters.Add(new SqlParameter("usia", usia));
            cmd.ExecuteNonQuery();
            con.Close();
            pesan = "Sukses Daftar";
            return pesan;

        }
        public string update(string id,string nmKaryawan, string tglMasukKerja, int usia)
        {

            string pesan = "sukses";

            string query = String.Format("update [HRD].[Mahasiswa] set NmKaryawan=@nmKaryawan, TglMasukKerja=@tglMasukKerja,Usia=@usia where IDKaryawan =@iDkaryawan");
            con.ConnectionString = sql;
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();



            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("iDkaryawan", id));
            cmd.Parameters.Add(new SqlParameter("nmKaryawan", nmKaryawan));
            cmd.Parameters.Add(new SqlParameter("tglMasukKerja", tglMasukKerja));
            cmd.Parameters.Add(new SqlParameter("usia", usia));



            cmd.ExecuteNonQuery();
            con.Close();



            return pesan;

        }

        public void view()
        {
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter("select * from karyawan ", sql);
            adpt.Fill(dt);

            con.Close();
        }

        public string delete(string delete)
        {
            string str = "";
            string nb = delete;
            string con = "Data Source=XC6089;Initial Catalog=ProdiTI;User ID=sa;Password=bintangterang32";

            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = con;
            koneksi.Open();

            str = "delete from [HRD].[Mahasiswa] where NamaMhs=@nb";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;


            cmd.Parameters.Add(new SqlParameter("nb", nb));
            cmd.ExecuteNonQuery();
            koneksi.Close();

            return str;
        }


        public DataTable viewdata()
        {

            DataTable table;
            string con = "Data Source =XC6089\\MSSQLSERVERS;Initial Catalog=db_test;User ID=sa;Password=123";
            string query = "select * from karyawan";

            SqlDataAdapter adpt = new SqlDataAdapter(query, con);
            table = new DataTable();
            adpt.Fill(table);
            return table;
        }
    }
}
