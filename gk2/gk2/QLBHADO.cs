using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace gk2
{
    public class QLBHADO
    {
        string connetString = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
        public DataTable getTable (string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, connetString);
            da.Fill(dt);
            return dt;
        }
        public bool checkMaKH(string makh)
        {
            string sql = @"select count(*) from KHACHHANG where MAKH=@mkh";
            SqlConnection con = new SqlConnection(connetString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@mkh", makh);
            con.Open();
            int count = (int)cmd.ExecuteScalar();
            con.Close();
            return (count >= 1);
        }
        public bool insertKH(KHang kh)
        {
            string sql = @"insert into KHACHHANG values (@mkh, @tkh, @sdt)";
            SqlConnection con = new SqlConnection(connetString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@mkh", kh.MAKH);
            cmd.Parameters.AddWithValue("@tkh", kh.TENKH);
            cmd.Parameters.AddWithValue("@sdt", kh.SDT);
            con.Open();
            int count = cmd.ExecuteNonQuery();
            con.Close();
            return (count >= 1);
        }
        public bool updateKH(KHang kh)
        {
            string sql = @"update KHACHHANG set HOTEN=@tkh, SDT=@sdt where MAKH = @mkh";
            SqlConnection con = new SqlConnection(connetString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@mkh", kh.MAKH);
            cmd.Parameters.AddWithValue("@tkh", kh.TENKH);
            cmd.Parameters.AddWithValue("@sdt", kh.SDT);
            con.Open();
            int count = (int)cmd.ExecuteNonQuery();
            con.Close();
            return (count >= 1);
        }
        public bool searchTenKH(string tenkh)
        {
            string sql = @"select count(*) from KHACHHANG where HOTEN=@tkh";
            SqlConnection con = new SqlConnection(connetString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@tkh", tenkh);
            con.Open();
            int count = (int)cmd.ExecuteScalar();
            con.Close();
            return (count >= 1);
        }
        public int checkSL(string mamh)
        {
            string sql = @"select SOLUONG from MATHANG where MAMH=@mmh";
            SqlConnection con = new SqlConnection(connetString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@mmh", mamh);
            con.Open();
            SqlDataReader read = cmd.ExecuteReader();
            read.Read();
            int count = 0;
            count = Convert.ToInt32(read["SOLUONG"].ToString());
            con.Close();
            return count;
        }
        public double checkDG(string mamh)
        {
            string sql = @"select DONGIA from MATHANG where MAMH=@mmh";
            SqlConnection con = new SqlConnection(connetString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@mmh", mamh);
            con.Open();
            SqlDataReader read = cmd.ExecuteReader();
            read.Read();
            double count = 0;
            count = Convert.ToDouble(read["DONGIA"].ToString());
            con.Close();
            return count;
        }
        public bool insertBH(BHang bh)
        {
            string sql = @"insert into BANHANG values (@mmh, @mkh, @nb, @sl)";
            SqlConnection con = new SqlConnection(connetString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@mmh", bh.MatHang);
            cmd.Parameters.AddWithValue("@mkh", bh.KhachHang);
            cmd.Parameters.AddWithValue("@nb", bh.NgayBan);
            cmd.Parameters.AddWithValue("@sl", bh.SoLuongBan);
            con.Open();
            int count = cmd.ExecuteNonQuery();
            con.Close();
            return (count >= 1);
        }
        public bool updateMH(int sluong, string mmh)
        {
            string sql = @"update MATHANG set SOLUONG=@sl where MAMH = @mamh";
            SqlConnection con = new SqlConnection(connetString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@sl", sluong);
            cmd.Parameters.AddWithValue("@mamh", mmh);
            con.Open();
            int count = (int)cmd.ExecuteNonQuery();
            con.Close();
            return (count >= 1);
        }
        public bool deleteKH(string makh)
        {
            string sql = @"delete KHACHHANG where MAKH = @mkh";
            SqlConnection con = new SqlConnection(connetString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@mkh", makh);
            con.Open();
            int count = (int)cmd.ExecuteNonQuery();
            con.Close();
            return (count >= 1);
        }
    }
}