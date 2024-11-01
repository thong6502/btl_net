using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using btl_net.Model;

namespace btl_net.Controller
{
    internal class Dbconnect
    {
        SqlConnection conn;
        public void open_csdl()
        {
            string str = "Data Source=DESKTOP-EVH1REF;Initial Catalog=btn_net;Integrated Security=True;TrustServerCertificate=True";
            conn = new SqlConnection(str);
            conn.Open();
        }
        public void close_csdl()
        {
            conn.Close();
        }


        // SINH VIEN
        public DataTable list_sinhvien()
        {
            DataTable dt = new DataTable();
            try
            {
                open_csdl();
                string sql = "select * from tbl_sinhvien";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                close_csdl();

            }
            catch (SqlException ex)
            {
                Console.Error.WriteLine("Lỗi sql: " + ex.Message);
                throw;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Đã xảy ra lỗi: " + ex.Message);
                throw;
            }
            
            return dt;
            
        }
        public void them_sinhvien(sinhvien_Model sv)
        {
            try
            {
                open_csdl();
                string sql = "insert into tbl_sinhvien (email, diachi, gioitinh, cccd, khoahoc, ngaysinh, hoten, id_chuyennganh, msv) values (@email, @diachi, @gioitinh, @cccd, @khoahoc, @ngaysinh, @hoten, @id_chuyennganh, @msv)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("email", sv.Email);
                cmd.Parameters.AddWithValue("diachi", sv.Diachi);
                cmd.Parameters.AddWithValue("gioitinh", sv.Gioitinh);
                cmd.Parameters.AddWithValue("cccd", sv.Cccd);
                cmd.Parameters.AddWithValue("khoahoc", sv.Khoahoc);
                cmd.Parameters.AddWithValue("ngaysinh", sv.Ngaysinh);
                cmd.Parameters.AddWithValue("hoten", sv.Hoten);
                cmd.Parameters.AddWithValue("id_chuyennganh", sv.Id_chuyennganh);
                cmd.Parameters.AddWithValue("msv", sv.Msv);
                cmd.ExecuteNonQuery();
                close_csdl();
            }catch(SqlException ex)
            {
                Console.Error.WriteLine("Lỗi sql: " + ex.Message);
                throw;
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine("Đã xảy ra lỗi: " + ex.Message);
                throw;
            }
        }
        public void sua_sinhvien(sinhvien_Model sv)
        {
            try
            {
                open_csdl();
                string sql = "UPDATE tbl_sinhvien SET email = @email, diachi = @diachi, gioitinh = @gioitinh, cccd = @cccd, khoahoc = @khoahoc, ngaysinh = @ngaysinh, hoten = @hoten, id_chuyennganh = @id_chuyennganh,  msv = @msv WHERE id_sv = @id_sv";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("id_sv", sv.Id_sv);
                cmd.Parameters.AddWithValue("email", sv.Email);
                cmd.Parameters.AddWithValue("diachi", sv.Diachi);
                cmd.Parameters.AddWithValue("gioitinh", sv.Gioitinh);
                cmd.Parameters.AddWithValue("cccd", sv.Cccd);
                cmd.Parameters.AddWithValue("khoahoc", sv.Khoahoc);
                cmd.Parameters.AddWithValue("ngaysinh", sv.Ngaysinh);
                cmd.Parameters.AddWithValue("hoten", sv.Hoten);
                cmd.Parameters.AddWithValue("id_chuyennganh", sv.Id_chuyennganh);
                cmd.Parameters.AddWithValue("msv", sv.Msv);

                cmd.ExecuteNonQuery();

                close_csdl(); 
            }
            catch (SqlException ex)
            {
                Console.Error.WriteLine("Lỗi SQL: " + ex.Message);
                throw;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Lỗi chung: " + ex.Message);
                throw;
            }
        }
        public void xoa_sinhvien(int id_sv)
        {
            try
            {
                open_csdl();
                string sql = "UPDATE tbl_sinhvien SET is_conhoc = @is_conhoc WHERE id_sv = @id_sv";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id_sv", id_sv);
                cmd.Parameters.AddWithValue("is_conhoc", 0);

                cmd.ExecuteNonQuery();

                close_csdl();
            }
            catch (SqlException ex)
            {
                Console.Error.WriteLine("Lỗi SQL: " + ex.Message);
                throw;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Lỗi chung: " + ex.Message);
                throw;
            }
        }
        public void khoiphuc_sinhvien(int id_sv)
        {
            try
            {
                open_csdl();
                string sql = "UPDATE tbl_sinhvien SET is_conhoc = @is_conhoc WHERE id_sv = @id_sv";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id_sv", id_sv);
                cmd.Parameters.AddWithValue("is_conhoc", 1);

                cmd.ExecuteNonQuery();

                close_csdl();
            }
            catch (SqlException ex)
            {
                Console.Error.WriteLine("Lỗi SQL: " + ex.Message);
                throw;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Lỗi chung: " + ex.Message);
                throw;
            }
        }
    }
}
