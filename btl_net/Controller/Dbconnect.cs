﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using btl_net.Model;

namespace btl_net.Controller
{
    internal class Dbconnect
    {
        SqlConnection conn;
        public void open_csdl()
        {
            string str = "Data Source=HDAT\\SQLEXPRESS;Initial Catalog=QuanLySinhVien;User ID=sa;Password=12348765;TrustServerCertificate=True";
            string str_thong = "Data Source=DESKTOP-EVH1REF;Initial Catalog=btn_net;Integrated Security=True;TrustServerCertificate=True";
            string str_thinh = "Data Source=DESKTOP-6GBA1KF;Initial Catalog=QLDiem;Integrated Security=True;TrustServerCertificate=True";
            conn = new SqlConnection(str_thong);
            conn.Open();
        }
        public void close_csdl()
        {
            conn.Close();
        }


        // SINH VIEN **********************************************
        public DataTable list_sinhvien()
        {
            DataTable dt = new DataTable();
            try
            {
                open_csdl();

                // Sử dụng INNER JOIN để lấy tên chuyên ngành từ tbl_chuyennganh
                string sql = @"
                    SELECT sv.id_sv, sv.msv, sv.hoten, sv.email,sv.cccd, sv.ngaysinh, sv.diachi, sv.gioitinh,  sv.sdt, 
                   sv.khoahoc, sv.is_conhoc, 
                   cn.tenchuyennganh, cn.id_chuyennganh
                    FROM tbl_sinhvien sv
                    INNER JOIN tbl_chuyennganh cn ON sv.id_chuyennganh = cn.id_chuyennganh";

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                close_csdl();
            }
            catch (SqlException ex)
            {
                Console.Error.WriteLine("Lỗi SQL: " + ex.Message);
                throw;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Đã xảy ra lỗi: " + ex.Message);
                throw;
            }

            return dt;
        }

        public string them_sinhvien(sinhvien_Model sv)
        {
            try
            {
                open_csdl();
                string sql = "INSERT INTO tbl_sinhvien (email, diachi, gioitinh, cccd, sdt, khoahoc, ngaysinh, hoten, id_chuyennganh, msv) " +
                             "VALUES (@Email, @Diachi, @Gioitinh, @Cccd, @Sdt, @Khoahoc, @Ngaysinh, @Hoten, @Id_chuyennganh, @Msv)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Gán giá trị cho các tham số
                cmd.Parameters.AddWithValue("@Email", sv.Email);
                cmd.Parameters.AddWithValue("@Diachi", sv.Diachi);
                cmd.Parameters.AddWithValue("@Gioitinh", sv.Gioitinh);
                cmd.Parameters.AddWithValue("@Cccd", sv.Cccd);
                cmd.Parameters.AddWithValue("@Sdt", sv.Sdt);
                cmd.Parameters.AddWithValue("@Khoahoc", sv.Khoahoc);
                cmd.Parameters.AddWithValue("@Ngaysinh", sv.Ngaysinh);
                cmd.Parameters.AddWithValue("@Hoten", sv.Hoten);
                cmd.Parameters.AddWithValue("@Id_chuyennganh", sv.Id_chuyennganh);
                cmd.Parameters.AddWithValue("@Msv", sv.Msv);

                cmd.ExecuteNonQuery();
                return "success";
            }
            catch (SqlException ex)
            {
                return $"LỖI SQL:\n"+ ex.Message;
            }
            catch (Exception ex)
            {
                return "Đã xảy ra lỗi: " + ex.Message;
            }
            finally
            {
                close_csdl();
            }

        }

        public string sua_sinhvien(sinhvien_Model sv)
        {
            try
            {
                open_csdl();
                string sql = "UPDATE tbl_sinhvien SET email = @email, diachi = @diachi, gioitinh = @gioitinh, cccd = @cccd, khoahoc = @khoahoc, ngaysinh = @ngaysinh, hoten = @hoten, id_chuyennganh = @id_chuyennganh,  msv = @msv, sdt = @sdt WHERE id_sv = @id_sv";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("id_sv", sv.Id_sv);
                cmd.Parameters.AddWithValue("email", sv.Email);
                cmd.Parameters.AddWithValue("diachi", sv.Diachi);
                cmd.Parameters.AddWithValue("gioitinh", sv.Gioitinh);
                cmd.Parameters.AddWithValue("cccd", sv.Cccd);
                cmd.Parameters.AddWithValue("khoahoc", sv.Khoahoc);
                cmd.Parameters.AddWithValue("ngaysinh", sv.Ngaysinh);
                cmd.Parameters.AddWithValue("hoten", sv.Hoten);
                cmd.Parameters.AddWithValue("sdt", sv.Sdt);
                cmd.Parameters.AddWithValue("id_chuyennganh", sv.Id_chuyennganh);
                cmd.Parameters.AddWithValue("msv", sv.Msv);

                cmd.ExecuteNonQuery();
                close_csdl();

                return "success";
            }
            catch (SqlException ex)
            {
                return ("lỖI SQL: \n" + ex.Message);
            }
            catch (Exception ex)
            {
                return("Lỗi chung : " + ex.Message);
            }
        }
        public string xoa_sinhvien(int id_sv)
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

                return "success";
            }
            catch (SqlException ex)
            {
                return ("lỖI SQL: \n" + ex.Message);
            }
            catch (Exception ex)
            {
                return ("Lỗi chung : " + ex.Message);
            }
        }
        public string khoiphuc_sinhvien(int id_sv)
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

                return "success";
            }
            catch (SqlException ex)
            {
                return ("lỖI SQL: \n" + ex.Message);
            }
            catch (Exception ex)
            {
                return ("Lỗi chung : " + ex.Message);
            }
        }


        // Chuyen nganh *******************************************
        public DataTable list_chuyennganh()
        {
            DataTable dt = new DataTable();
            try
            {
                open_csdl();
                string sql = "select * from tbl_chuyennganh";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                close_csdl();
            }
            catch (Exception ex)
            {
                throw;
            }
            return dt;
        }
        public string them_chuyennganh(chuyennganh_Model cn)
        {
            try
            {
                open_csdl();
                string sql = "insert into tbl_chuyennganh (tenchuyennganh) VALUES (@tenchuyennganh)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("tenchuyennganh", cn.Tenchuyennganh);
                cmd.ExecuteNonQuery();
                close_csdl();
                return "success";
            }
            catch (SqlException ex)
            {
                return "LỖI SQL: " + ex.Message;
                throw;
            }
            catch (Exception ex)
            {
                return "Đã xảy ra lỗi tbl_chuyennganh: " + ex.Message;
                throw;
            }
        }
        public int get_id_chuyenganh_by_name(string tenchuyennganh)
        {
            int id = 0;
            try
            {
                open_csdl();
                string sql = "select id_chuyennganh from tbl_chuyennganh WHERE tenchuyennganh = @tenchuyennganh";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@tenchuyennganh", tenchuyennganh);

                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value) // Kiểm tra kết quả có phải là null hay không
                {
                    id = (int)result; // Ép kiểu kết quả về int
                }
            }
            catch (SqlException ex)
            {
                Console.Error.WriteLine("Lỗi SQL get_id_chuyenganh_by_name: " + ex.Message);
                throw;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Đã xảy ra lỗi get_id_chuyenganh_by_name: " + ex.Message);
                throw;
            }
            finally
            {
                close_csdl();
            }
            return id;
        }

        // mon hoc **********************************************

        public DataTable list_monhoc()
        {
            DataTable dt = new DataTable();
            try
            {
                open_csdl();

                // Câu lệnh SQL để lấy tất cả dữ liệu từ bảng tbl_monhoc và tên loại môn học từ tbl_phanloai_monhoc
                string sql = @"
            SELECT mh.id_monhoc, mh.tenmonhoc, mh.sotc, mh.tongsobh, mh.max_bh_chophep, 
                   mh.id_phanloai_monhoc, pl.loaimh AS LoaiMH
            FROM tbl_monhoc mh
            INNER JOIN tbl_phanloai_monhoc pl ON mh.id_phanloai_monhoc = pl.id_phanloai_monhoc";

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                close_csdl();
            }
            catch (SqlException ex)
            {
                Console.Error.WriteLine("Lỗi SQL: " + ex.Message);
                throw;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Đã xảy ra lỗi: " + ex.Message);
                throw;
            }

            return dt;
        }
        public void them_monhoc(monhoc_Model mh)
        {
            try
            {
                open_csdl();

                string sql = "INSERT INTO tbl_monhoc (tenmonhoc, sotc, tongsobh, max_bh_chophep, id_phanloai_monhoc) " +
                             "VALUES (@Tenmonhoc, @Sotc, @Tongsobh, @Max_bh_chophep, @Id_phanloai_monhoc)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                // Gán giá trị cho các tham số
                cmd.Parameters.AddWithValue("@Tenmonhoc", mh.Tenmonhoc);
                cmd.Parameters.AddWithValue("@Sotc", mh.Sotc);
                cmd.Parameters.AddWithValue("@Tongsobh", mh.Tongsobh);
                cmd.Parameters.AddWithValue("@Max_bh_chophep", mh.Max_bh_chophep);
                cmd.Parameters.AddWithValue("@Id_phanloai_monhoc", mh.Id_phanloai_mh);

                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    MessageBox.Show("ID môn học hoặc tên môn học đã tồn tại. Vui lòng nhập giá trị khác.");
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
            finally
            {
                close_csdl();
            }
        }
        public DataTable list_loaimonhoc()
        {
            DataTable dt = new DataTable();
            try
            {
                open_csdl();
                string sql = "select * from tbl_phanloai_monhoc";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                close_csdl();
            }
            catch (Exception ex)
            {
                throw;
            }
            return dt;
        }
        public void sua_monhoc(monhoc_Model mh)
        {
            try
            {
                open_csdl();
                string sql = "UPDATE tbl_monhoc SET tenmonhoc = @Tenmonhoc, sotc = @Sotc, tongsobh = @Tongsobh, max_bh_chophep = @Max_bh_chophep, id_phanloai_monhoc = @Id_phanloai_monhoc " +
                             "WHERE id_monhoc = @Id_monhoc";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id_monhoc", mh.Id_monhoc);
                cmd.Parameters.AddWithValue("@Tenmonhoc", mh.Tenmonhoc);
                cmd.Parameters.AddWithValue("@Sotc", mh.Sotc);
                cmd.Parameters.AddWithValue("@Tongsobh", mh.Tongsobh);
                cmd.Parameters.AddWithValue("@Max_bh_chophep", mh.Max_bh_chophep);
                cmd.Parameters.AddWithValue("@Id_phanloai_monhoc", mh.Id_phanloai_mh);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra: " + ex.Message);
            }
            finally
            {
                close_csdl();
            }
        }

        public void xoa_monhoc(int id_monhoc)
        {
            try
            {
                open_csdl();
                string sql = "DELETE FROM tbl_monhoc WHERE id_monhoc = @Id_monhoc";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id_monhoc", id_monhoc);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra: " + ex.Message);
            }
            finally
            {
                close_csdl();
            }
        }
        public bool kiemTraIdPhanLoaiMonHoc(int idPhanLoai)
        {
            bool exists = false;
            try
            {
                open_csdl();

                string sql = "SELECT COUNT(*) FROM tbl_phanloai_monhoc WHERE id_phanloai_monhoc = @IdPhanLoai";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@IdPhanLoai", idPhanLoai);

                int count = (int)cmd.ExecuteScalar();
                exists = (count > 0);

                close_csdl();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi kiểm tra id_phanloai_monhoc: " + ex.Message);
            }
            finally
            {
                close_csdl();
            }

            return exists;
        }
        public DataTable list_daudiem()
        {
            DataTable dt = new DataTable();
            try
            {
                open_csdl();

                // Lấy dữ liệu từ tbl_daudiem và tbl_monhoc
                string sql = @"
            SELECT d.id_daudiem, d.id_monhoc, m.tenmonhoc AS TenMonHoc, d.tendaudiem, d.tyle
            FROM tbl_daudiem d
            INNER JOIN tbl_monhoc m ON d.id_monhoc = m.id_monhoc";

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                close_csdl();
            }
            catch (SqlException ex)
            {
                Console.Error.WriteLine("Lỗi SQL: " + ex.Message);
                throw;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Đã xảy ra lỗi: " + ex.Message);
                throw;
            }

            return dt;
        }

        public void them_daudiem(daudiem_Model daudiem)
        {
            try
            {
                open_csdl();
                string sql = "INSERT INTO tbl_daudiem (id_monhoc, tendaudiem, tyle) VALUES (@Id_monhoc, @Tendaudiem, @Tyle)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Gán giá trị cho các tham số
                cmd.Parameters.AddWithValue("@Id_monhoc", daudiem.Id_monhoc);
                cmd.Parameters.AddWithValue("@Tendaudiem", daudiem.Tendaudiem);
                cmd.Parameters.AddWithValue("@Tyle", daudiem.Tyle);

                // Thực thi câu lệnh
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
            finally
            {
                close_csdl();
            }
        }

        public bool KiemTraTonTaiMonHoc(int id_monhoc)
        {
            bool exists = false;
            try
            {
                open_csdl();
                string sql = "SELECT COUNT(*) FROM tbl_monhoc WHERE id_monhoc = @Id_monhoc";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id_monhoc", id_monhoc);

                exists = (int)cmd.ExecuteScalar() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
            finally
            {
                close_csdl();
            }
            return exists;
        }

        
    }
}
