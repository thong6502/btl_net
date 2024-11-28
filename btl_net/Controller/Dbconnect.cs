using System;
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
            string str_thinh = "Data Source=DESKTOP-6GBA1KF;Initial Catalog=btn_net;Integrated Security=True;TrustServerCertificate=True";
            conn = new SqlConnection(str);
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
        public DataTable list_cbsinhvien()
        {
            DataTable dt = new DataTable();
            try
            {
                open_csdl();
                string sql = "SELECT id_sv, msv + ' - ' + hoten AS display_name FROM tbl_sinhvien WHERE is_conhoc = 1";
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
                return $"LỖI SQL:\n" + ex.Message;
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
                return ("Lỗi chung : " + ex.Message);
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

        public DataTable GetSinhVienTheoChuyenNganh(string tenChuyenNganh)
        {
            DataTable dt = new DataTable();
            try
            {
                open_csdl();
                string query = @"
                SELECT sv.id_sv, sv.hoten, sv.msv, sv.khoahoc, sv.gioitinh, sv.sdt, sv.ngaysinh, sv.cccd, sv.email, sv.diachi
                FROM tbl_sinhvien sv
                INNER JOIN tbl_chuyennganh cn ON sv.id_chuyennganh = cn.id_chuyennganh
                WHERE cn.tenchuyennganh = @tenChuyenNganh AND sv.is_conhoc = 1 AND cn.is_xoa = 0";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tenChuyenNganh", tenChuyenNganh);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
            finally
            {
                close_csdl();
            }
            return dt;
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
        public DataTable list_chuyennganhvaslsv(bool is_xoa)
        {
            DataTable dt = new DataTable();
            try
            {
                open_csdl();
                string sql = @"
                SELECT c.id_chuyennganh, c.tenchuyennganh, 
                        COUNT(s.id_sv) AS SoLuongSinhVien
                FROM tbl_chuyennganh c
                LEFT JOIN tbl_sinhvien s ON s.id_chuyennganh = c.id_chuyennganh 
                WHERE c.is_xoa = @IsXoa
                GROUP BY c.id_chuyennganh, c.tenchuyennganh";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@IsXoa", is_xoa);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi truy vấn cơ sở dữ liệu: " + ex.Message);
            }
            finally
            {
                close_csdl();
            }
            return dt;
        }

        // Sửa chuyên ngành
        public void sua_chuyennganh(chuyennganh_Model chuyennganh)
        {
            try
            {
                open_csdl();
                string sql = "UPDATE tbl_chuyennganh SET tenchuyennganh = @TenChuyenNganh WHERE id_chuyennganh = @IdChuyenNganh";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TenChuyenNganh", chuyennganh.Tenchuyennganh);
                cmd.Parameters.AddWithValue("@IdChuyenNganh", chuyennganh.Id_chuyennganh);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa chuyên ngành: " + ex.Message);
            }
            finally
            {
                close_csdl();
            }
        }

        // Xóa mềm chuyên ngành
        public void xoa_chuyennganh(int id_chuyennganh)
        {
            try
            {
                open_csdl();
                string sql = "UPDATE tbl_chuyennganh SET is_xoa = 1 WHERE id_chuyennganh = @IdChuyenNganh";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@IdChuyenNganh", id_chuyennganh);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa chuyên ngành: " + ex.Message);
            }
            finally
            {
                close_csdl();
            }
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
        public void khoi_phuc_chuyenganh(int id_chuyennganh)
        {
            try
            {
                open_csdl();
                string sql = "UPDATE tbl_chuyennganh SET is_xoa = 0 WHERE id_chuyennganh = @IdChuyenNganh";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@IdChuyenNganh", id_chuyennganh);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi khôi phục chuyên ngành: " + ex.Message);
            }
            finally
            {
                close_csdl();
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

        public DataTable list_monhoc(bool is_xoa)
        {
            DataTable dt = new DataTable();
            try
            {
                open_csdl();
                string sql = @"
                SELECT mh.id_monhoc, mh.tenmonhoc, mh.sotc, mh.tongsobh, mh.max_bh_chophep, 
                    mh.diemquamon, pl.loaimh AS LoaiMH
                FROM tbl_monhoc mh
                JOIN tbl_phanloai_monhoc pl ON mh.id_phanloai_monhoc = pl.id_phanloai_monhoc
                WHERE mh.is_xoa = @IsXoa";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@IsXoa", is_xoa);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi truy vấn danh sách môn học: " + ex.Message);
            }
            finally
            {
                close_csdl();
            }
            return dt;
        }
        public void them_monhoc(monhoc_Model monhoc)
        {
            try
            {
                open_csdl();
                string sql = @"
                INSERT INTO tbl_monhoc (tenmonhoc, sotc, tongsobh, max_bh_chophep, diemquamon, id_phanloai_monhoc)
                VALUES (@TenMonHoc, @SoTC, @TongSoBH, @MaxBHChoPhep, @DiemQuaMon, @IdPhanLoai)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TenMonHoc", monhoc.Tenmonhoc);
                cmd.Parameters.AddWithValue("@SoTC", monhoc.Sotc);
                cmd.Parameters.AddWithValue("@TongSoBH", monhoc.Tongsobh);
                cmd.Parameters.AddWithValue("@MaxBHChoPhep", monhoc.Max_bh_chophep);
                cmd.Parameters.AddWithValue("@DiemQuaMon", monhoc.Diemquamon);
                cmd.Parameters.AddWithValue("@IdPhanLoai", monhoc.Id_phanloai_mh);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm môn học: " + ex.Message);
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
                string sql = "select * from tbl_phanloai_monhoc where is_xoa = 0";
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

        public DataTable list_cbmonhoc()
        {
            DataTable dt = new DataTable();
            try
            {
                open_csdl();
                string sql = "select * from tbl_monhoc where is_xoa = 0";
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
        public void sua_monhoc(monhoc_Model monhoc)
        {
            try
            {
                open_csdl();
                string sql = @"
                UPDATE tbl_monhoc
                SET tenmonhoc = @TenMonHoc, sotc = @SoTC, tongsobh = @TongSoBH, 
                    max_bh_chophep = @MaxBHChoPhep, diemquamon = @DiemQuaMon, 
                    id_phanloai_monhoc = @IdPhanLoai
                WHERE id_monhoc = @IdMonHoc";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TenMonHoc", monhoc.Tenmonhoc);
                cmd.Parameters.AddWithValue("@SoTC", monhoc.Sotc);
                cmd.Parameters.AddWithValue("@TongSoBH", monhoc.Tongsobh);
                cmd.Parameters.AddWithValue("@MaxBHChoPhep", monhoc.Max_bh_chophep);
                cmd.Parameters.AddWithValue("@DiemQuaMon", monhoc.Diemquamon);
                cmd.Parameters.AddWithValue("@IdPhanLoai", monhoc.Id_phanloai_mh);
                cmd.Parameters.AddWithValue("@IdMonHoc", monhoc.Id_monhoc);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa môn học: " + ex.Message);
            }
            finally
            {
                close_csdl();
            }
        }

        // Xóa mềm môn học
        public void xoa_monhoc(int id_monhoc)
        {
            try
            {
                open_csdl();
                string sql = "UPDATE tbl_monhoc SET is_xoa = 1 WHERE id_monhoc = @IdMonHoc";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@IdMonHoc", id_monhoc);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa môn học: " + ex.Message);
            }
            finally
            {
                close_csdl();
            }
        }

        // Khôi phục môn học
        public void khoi_phuc_monhoc(int id_monhoc)
        {
            try
            {
                open_csdl();
                string sql = "UPDATE tbl_monhoc SET is_xoa = 0 WHERE id_monhoc = @IdMonHoc";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@IdMonHoc", id_monhoc);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi khôi phục môn học: " + ex.Message);
            }
            finally
            {
                close_csdl();
            }
        }
        public DataTable search_daudiem_by_id_monhoc(int id_monhoc)
        {
            DataTable dt = new DataTable();
            try
            {
                open_csdl();
                string sql = "select * from tbl_daudiem where id_monhoc = @id_monhoc";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id_monhoc", id_monhoc);
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
        public void sua_daudiem(daudiem_Model daudiem)
        {
            try
            {
                open_csdl();
                string sql = "UPDATE tbl_daudiem SET id_monhoc = @Id_monhoc, tendaudiem = @Tendaudiem, tyle = @Tyle WHERE id_daudiem = @Id_daudiem";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Id_monhoc", daudiem.Id_monhoc);
                cmd.Parameters.AddWithValue("@Tendaudiem", daudiem.Tendaudiem);
                cmd.Parameters.AddWithValue("@Tyle", daudiem.Tyle);
                cmd.Parameters.AddWithValue("@Id_daudiem", daudiem.Id_daudiem);


                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected == 0)
                {
                    MessageBox.Show("Không tìm thấy đầu điểm để sửa.");
                }
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

        public void xoa_daudiem(int id_daudiem)
        {
            try
            {
                open_csdl();
                string sql = "DELETE FROM tbl_daudiem WHERE id_daudiem = @Id_daudiem";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Id_daudiem", id_daudiem);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected == 0)
                {
                    MessageBox.Show("Không tìm thấy đầu điểm để xóa.");
                }

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

        // ------------------------------Bang đầu điểm-----------------------------s
        public DataTable TraDSDiem()
        {
            open_csdl();
            string sql = "select * from tbl_daudiem";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            close_csdl();
            return dt;
        }
        // lấy dữ liệu mã môn học
        public DataTable LayDLMon()
        {
            open_csdl();
            string sql = "select * from tbl_monhoc";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            close_csdl();
            return dt;
        }
        //Xử lý hàm phân loại môn học ------------

        public void ThemPhanLoaiMonHoc(phanloaimonhoc_Model phanLoai)
        {
            try
            {
                open_csdl(); // Mở kết nối đến cơ sở dữ liệu
                string sql = "INSERT INTO tbl_phanloai_monhoc (id_phanloai_monhoc, loaimh) VALUES (@idPhanLoai, @loaiMH)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@idPhanLoai", phanLoai.Id_phanloai_mh);
                    cmd.Parameters.AddWithValue("@loaiMH", phanLoai.Loaimh);

                    cmd.ExecuteNonQuery(); // Thực thi câu lệnh SQL
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm phân loại môn học: " + ex.Message, "Thông báo");
            }
            finally
            {
                close_csdl(); // Đóng kết nối cơ sở dữ liệu
            }
        }
        public void SuaPhanLoaiMonHoc(phanloaimonhoc_Model phanLoai)
        {
            try
            {
                open_csdl(); // Mở kết nối đến cơ sở dữ liệu
                string sql = "UPDATE tbl_phanloai_monhoc SET loaimh = @loaiMH WHERE id_phanloai_monhoc = @idPhanLoai";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@idPhanLoai", phanLoai.Id_phanloai_mh);
                    cmd.Parameters.AddWithValue("@loaiMH", phanLoai.Loaimh);

                    cmd.ExecuteNonQuery(); // Thực thi câu lệnh SQL
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa phân loại môn học: " + ex.Message, "Thông báo");
            }
            finally
            {
                close_csdl(); // Đóng kết nối cơ sở dữ liệu
            }
        }



        // xoa và khôi phục
        public void XoaPhanLoaiMonHoc(int idPhanLoai)
        {
            try
            {
                open_csdl(); // Mở kết nối đến cơ sở dữ liệu
                string sql = "UPDATE tbl_phanloai_monhoc SET is_xoa = @isXoa WHERE id_phanloai_monhoc = @idPhanLoai";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@idPhanLoai", idPhanLoai);
                    cmd.Parameters.AddWithValue("@isXoa", 0); // Giả sử rằng true nghĩa là đã xóa

                    cmd.ExecuteNonQuery(); // Thực thi câu lệnh SQL
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa phân loại môn học: " + ex.Message, "Thông báo");
            }
            finally
            {
                close_csdl(); // Đóng kết nối cơ sở dữ liệu
            }
        }
        public void KhoiPhucPhanLoaiMonHoc(int idPhanLoai)
        {
            try
            {
                open_csdl(); // Mở kết nối đến cơ sở dữ liệu
                string sql = "UPDATE tbl_phanloai_monhoc SET is_xoa = @isXoa WHERE id_phanloai_monhoc = @idPhanLoai";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@idPhanLoai", idPhanLoai);
                    cmd.Parameters.AddWithValue("@isXoa", 1); // Giả sử rằng true nghĩa là đã xóa

                    cmd.ExecuteNonQuery(); // Thực thi câu lệnh SQL
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa phân loại môn học: " + ex.Message, "Thông báo");
            }
            finally
            {
                close_csdl(); // Đóng kết nối cơ sở dữ liệu
            }
        }
        public DataTable list_phanloaimonhoc()
        {
            DataTable dt = new DataTable();
            try
            {
                open_csdl();

                string sql = @"SELECT id_phanloai_monhoc, loaimh, is_xoa FROM tbl_phanloai_monhoc";

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

        //Kỳ học*************************************
        public DataTable list_kyhoc(bool is_xoa)
        {
            DataTable dt = new DataTable();
            try
            {
                open_csdl();
                string sql = @"
                SELECT k.id_kyhoc, k.kyhoc, 
                       COUNT(l.id_lophoc) AS SoLuongLopHoc
                FROM tbl_kyhoc k
                LEFT JOIN tbl_lophoc l ON k.id_kyhoc = l.id_kyhoc
                WHERE k.is_xoa = @IsXoa
                GROUP BY k.id_kyhoc, k.kyhoc";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@IsXoa", is_xoa);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi truy vấn cơ sở dữ liệu: " + ex.Message);
            }
            finally
            {
                close_csdl();
            }
            return dt;
        }

        public DataTable list_cbkyhoc()
        {
            DataTable dt = new DataTable();
            try
            {
                open_csdl();
                string sql = "select * from tbl_kyhoc where is_xoa = 0";
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

        // Thêm học kỳ
        public void them_kyhoc(kyhoc_Model kyhoc)
        {
            try
            {
                open_csdl();
                string sql = "INSERT INTO tbl_kyhoc (kyhoc) VALUES (@Kyhoc)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Kyhoc", kyhoc.Kyhoc);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm học kỳ: " + ex.Message);
            }
            finally
            {
                close_csdl();
            }
        }

        // Sửa học kỳ
        public void sua_kyhoc(kyhoc_Model kyhoc)
        {
            try
            {
                open_csdl();
                string sql = "UPDATE tbl_kyhoc SET kyhoc = @Kyhoc WHERE id_kyhoc = @IdKyhoc";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Kyhoc", kyhoc.Kyhoc);
                cmd.Parameters.AddWithValue("@IdKyhoc", kyhoc.Id_kyhoc);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa học kỳ: " + ex.Message);
            }
            finally
            {
                close_csdl();
            }
        }

        // Xóa mềm học kỳ
        public void xoa_kyhoc(int id_kyhoc)
        {
            try
            {
                open_csdl();
                string sql = "UPDATE tbl_kyhoc SET is_xoa = 1 WHERE id_kyhoc = @IdKyhoc";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@IdKyhoc", id_kyhoc);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa học kỳ: " + ex.Message);
            }
            finally
            {
                close_csdl();
            }
        }

        // Khôi phục học kỳ
        public void khoi_phuc_kyhoc(int id_kyhoc)
        {
            try
            {
                open_csdl();
                string sql = "UPDATE tbl_kyhoc SET is_xoa = 0 WHERE id_kyhoc = @IdKyhoc";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@IdKyhoc", id_kyhoc);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi khôi phục học kỳ: " + ex.Message);
            }
            finally
            {
                close_csdl();
            }
        }

        //Lớp học*************************************

        public DataTable GetLopHocTheoHocKy(string tenHocKy)
        {
            DataTable dt = new DataTable();
            try
            {
                open_csdl();
                string query = @"
                SELECT tbl_lophoc.id_lophoc, tbl_lophoc.tenlop 
                FROM tbl_lophoc 
                INNER JOIN tbl_kyhoc ON tbl_lophoc.id_kyhoc = tbl_kyhoc.id_kyhoc 
                WHERE tbl_kyhoc.kyhoc = @tenHocKy AND tbl_lophoc.is_xoa = 0";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tenHocKy", tenHocKy);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                // Ghi log lỗi hoặc xử lý lỗi nếu cần
                Console.WriteLine("Lỗi: " + ex.Message);
            }
            finally
            {
                close_csdl();
            }
            return dt;
        }

        public DataTable GetLopHocTheoMon(string tenMonHoc)
        {
            DataTable dt = new DataTable();
            try
            {
                open_csdl();
                string query = @"
                SELECT lh.id_lophoc, lh.tenlop, kh.kyhoc , lh.sinhvientoida 
                FROM tbl_lophoc lh
                INNER JOIN tbl_monhoc mh ON lh.id_monhoc = mh.id_monhoc
                INNER JOIN tbl_kyhoc kh ON lh.id_kyhoc = kh.id_kyhoc
                WHERE mh.tenmonhoc = @tenMonHoc AND lh.is_xoa = 0 AND mh.is_xoa = 0";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tenMonHoc", tenMonHoc);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
            finally
            {
                close_csdl();
            }
            return dt;
        }
        public DataTable list_cblophoc()
        {
            DataTable dt = new DataTable();
            try
            {
                open_csdl();
                string sql = @"
            SELECT 
                l.id_lophoc, 
                l.tenlop + ' - ' + k.kyhoc + ' - ' + m.tenmonhoc AS display_name
            FROM 
                tbl_lophoc l
            JOIN 
                tbl_monhoc m ON l.id_monhoc = m.id_monhoc
            JOIN 
                tbl_kyhoc k ON l.id_kyhoc = k.id_kyhoc
            WHERE 
                l.is_xoa = 0";
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

        //Ghi danh*********************************************

        //Ghi danh theo lớp---------------------
        public DataTable list_ghidanh1(int id_lophoc, bool is_xoa)
        {
            DataTable dt = new DataTable();
            try
            {
                open_csdl();
                string sql = @"
        SELECT gd.id_ghidanh, gd.id_sv, gd.id_lophoc, gd.sobuoinghi, gd.xeplichthi, 
                sv.msv AS MSV, sv.hoten AS HoTen, lh.tenlop AS TenLop, 
                ky.kyhoc AS KyHoc, mh.tenmonhoc AS TenMonHoc
        FROM tbl_ghidanh gd
        JOIN tbl_sinhvien sv ON gd.id_sv = sv.id_sv
        JOIN tbl_lophoc lh ON gd.id_lophoc = lh.id_lophoc
        JOIN tbl_monhoc mh ON lh.id_monhoc = mh.id_monhoc
        JOIN tbl_kyhoc ky ON lh.id_kyhoc = ky.id_kyhoc
        WHERE gd.id_lophoc = @IdLopHoc AND gd.is_xoa = @IsXoa";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@IdLopHoc", id_lophoc);
                cmd.Parameters.AddWithValue("@IsXoa", is_xoa);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi truy vấn danh sách ghi danh: " + ex.Message);
            }
            finally
            {
                close_csdl();
            }
            return dt;
        }

        public bool Ktratontaisv(int idSv, int idLopHoc)
        {
            try
            {
                open_csdl();
                string sql = @"
        SELECT COUNT(*) 
        FROM tbl_ghidanh 
        WHERE id_sv = @IdSv AND id_lophoc = @IdLopHoc AND is_xoa = 0"; // Kiểm tra ghi danh chưa xóa

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@IdSv", idSv);
                cmd.Parameters.AddWithValue("@IdLopHoc", idLopHoc);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0; // Nếu > 0 nghĩa là sinh viên đã tồn tại trong lớp học
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kiểm tra sinh viên: " + ex.Message);
                return false;
            }
            finally
            {
                close_csdl();
            }
        }
        public void them_ghidanh(ghidanh_Model ghidanh)
        {
            try
            {
                open_csdl();
                string sql = @"
                INSERT INTO tbl_ghidanh (id_sv, id_lophoc, sobuoinghi, xeplichthi)
                VALUES (@IdSv, @IdLopHoc, @SoBuoiNghi, @XepLichThi)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@IdSv", ghidanh.Id_sv);
                cmd.Parameters.AddWithValue("@IdLopHoc", ghidanh.Id_lophoc);
                cmd.Parameters.AddWithValue("@SoBuoiNghi", ghidanh.Sobuoinghi);
                cmd.Parameters.AddWithValue("@XepLichThi", ghidanh.Xeplichthi);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm ghi danh: " + ex.Message);
            }
            finally
            {
                close_csdl();
            }
        }

        // Sửa ghi danh
        public void sua_ghidanh(ghidanh_Model ghidanh)
        {
            try
            {
                open_csdl();
                string sql = @"
                UPDATE tbl_ghidanh
                SET id_sv = @IdSv, id_lophoc = @IdLopHoc, sobuoinghi = @SoBuoiNghi, xeplichthi = @XepLichThi
                WHERE id_ghidanh = @IdGhiDanh";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@IdSv", ghidanh.Id_sv);
                cmd.Parameters.AddWithValue("@IdLopHoc", ghidanh.Id_lophoc);
                cmd.Parameters.AddWithValue("@SoBuoiNghi", ghidanh.Sobuoinghi);
                cmd.Parameters.AddWithValue("@XepLichThi", ghidanh.Xeplichthi);
                cmd.Parameters.AddWithValue("@IdGhiDanh", ghidanh.Id_ghidanh);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa ghi danh: " + ex.Message);
            }
            finally
            {
                close_csdl();
            }
        }

        // Xóa mềm ghi danh
        public void xoa_ghidanh(int id_ghidanh)
        {
            try
            {
                open_csdl();
                string sql = "UPDATE tbl_ghidanh SET is_xoa = 1 WHERE id_ghidanh = @IdGhiDanh";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@IdGhiDanh", id_ghidanh);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa ghi danh: " + ex.Message);
            }
            finally
            {
                close_csdl();
            }
        }

        // Khôi phục ghi danh
        public void khoi_phuc_ghidanh(int id_ghidanh)
        {
            try
            {
                open_csdl();
                string sql = "UPDATE tbl_ghidanh SET is_xoa = 0 WHERE id_ghidanh = @IdGhiDanh";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@IdGhiDanh", id_ghidanh);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi khôi phục ghi danh: " + ex.Message);
            }
            finally
            {
                close_csdl();
            }
        }



        // Điểm*****************************************
        public DataTable list_diem()
        {
            DataTable dt = new DataTable();
            try
            {
                open_csdl();
                string sql = @"
            SELECT 
                d.id_diem, sv.msv, sv.hoten, dd.tendaudiem, mh.tenmonhoc, d.diem
            FROM 
                tbl_diem d
            JOIN 
                tbl_sinhvien sv ON d.id_sv = sv.id_sv
            JOIN 
                tbl_daudiem dd ON d.id_daudiem = dd.id_daudiem
            JOIN 
                tbl_monhoc mh ON dd.id_monhoc = mh.id_monhoc";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                close_csdl();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        

        // Lấy danh sách đầu điểm theo lớp học
        public DataTable list_daudiem_by_lophoc(int idLopHoc)
        {
            DataTable dt = new DataTable();
            try
            {
                open_csdl();
                string sql = @"
                    SELECT dd.id_daudiem, dd.tendaudiem 
                    FROM tbl_daudiem dd
                    JOIN tbl_monhoc mh ON dd.id_monhoc = mh.id_monhoc
                    JOIN tbl_lophoc lh ON mh.id_monhoc = lh.id_monhoc
                    WHERE lh.id_lophoc = @idLopHoc";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@idLopHoc", idLopHoc);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                close_csdl();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }

        // Thêm điểm vào bảng diem
        public void them_diem(diem_Model diem)
        {
            try
            {
                open_csdl();
                string sql = @"
                    INSERT INTO tbl_diem(id_sv, id_daudiem, diem, is_xoa)
                    VALUES (@idSinhVien, @idDauDiem, @diem, 0)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@idSinhVien", diem.Id_sv);
                cmd.Parameters.AddWithValue("@idDauDiem", diem.Id_daudiem);
                cmd.Parameters.AddWithValue("@diem", diem.Diem);
                cmd.ExecuteNonQuery();
                close_csdl();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Cập nhật điểm
        public void sua_diem(diem_Model diem)
        {
            try
            {
                open_csdl();
                string sql = "UPDATE tbl_diem SET id_daudiem = @idDauDiem, diem = @diem WHERE id_diem = @idDiem";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@idDauDiem", diem.Id_daudiem);
                cmd.Parameters.AddWithValue("@diem", diem.Diem);
                cmd.Parameters.AddWithValue("@idDiem", diem.Id_diem);
                cmd.ExecuteNonQuery();
                close_csdl();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable list_sinhvien_by_lophoc(int idLopHoc)
        {
            DataTable dt = new DataTable();
            try
            {
                open_csdl();
                string sql = @"
                SELECT 
                    sv.id_sv, 
                    sv.msv, 
                    sv.hoten,
                    gd.id_lophoc
                FROM tbl_sinhvien sv
                JOIN tbl_ghidanh gd ON sv.id_sv = gd.id_sv
                WHERE gd.id_lophoc = @idLopHoc AND sv.is_conhoc = 1 AND gd.is_xoa = 0";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@idLopHoc", idLopHoc);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                close_csdl();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }

        // Lấy thông tin số sinh viên hiện có và số sinh viên tối đa trong lớp học
        public void GetStudentCountInfo(int idLopHoc, out int currentCount, out int maxCount)
        {
            currentCount = 0;
            maxCount = 0;
            try
            {
                open_csdl();
                open_csdl();
                string sql = @"
                            SELECT 
                            (SELECT COUNT(*) 
                            FROM tbl_ghidanh gd
                            JOIN tbl_sinhvien sv ON gd.id_sv = sv.id_sv
                            WHERE gd.id_lophoc = @idLopHoc AND gd.is_xoa = 0 AND sv.is_conhoc = 1) AS current_count,
                            l.sinhvientoida 
                            FROM tbl_lophoc l
                            WHERE l.id_lophoc = @idLopHoc";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@idLopHoc", idLopHoc);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    currentCount = reader.GetInt32(0); // Số sinh viên hiện có
                    maxCount = reader.GetInt32(1);    // Số sinh viên tối đa
                }

                close_csdl();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetSinhVienDuDiem(int idLopHoc)
        {
            DataTable dt = new DataTable();
            try
            {
                // Mở kết nối với cơ sở dữ liệu
                open_csdl();

                // Chuỗi truy vấn SQL
                string sql = @"
            SELECT sv.id_sv, sv.msv, sv.hoten,
                CASE 
                    WHEN COUNT(daudiem.id_daudiem) = (
                        SELECT COUNT(*) 
                        FROM tbl_daudiem 
                        WHERE id_monhoc = (SELECT id_monhoc FROM tbl_lophoc WHERE id_lophoc = @idLopHoc)
                    ) THEN 1  -- Đủ điểm
                    ELSE 0  -- Thiếu điểm
                END AS DuDiem
            FROM tbl_sinhvien sv
            JOIN tbl_ghidanh gd ON sv.id_sv = gd.id_sv
            LEFT JOIN tbl_diem diem ON diem.id_sv = sv.id_sv
            LEFT JOIN tbl_daudiem daudiem ON diem.id_daudiem = daudiem.id_daudiem
            WHERE gd.id_lophoc = @idLopHoc
            GROUP BY sv.id_sv, sv.msv, sv.hoten";

                // Khởi tạo SqlCommand và thêm tham số
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@idLopHoc", idLopHoc); // Truyền idLopHoc vào tham số SQL

                // Khởi tạo SqlDataAdapter và lấy dữ liệu vào DataTable
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                // Đóng kết nối
                close_csdl();
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                throw new Exception("Lỗi khi lấy dữ liệu sinh viên đủ điểm: " + ex.Message);
            }

            // Trả về DataTable chứa kết quả
            return dt;
        }


        //Nhap diem
        // Lấy danh sách sinh viên (MSV - Tên sinh viên)
        public DataTable GetSinhVien()
        {
            DataTable dt = new DataTable();
            try
            {
                open_csdl();
                string sql = "SELECT id_sv, msv + ' - ' + hoten AS display_name FROM tbl_sinhvien WHERE is_conhoc = 1";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                close_csdl() ;
            }
            return dt;
        }

        // Lấy danh sách lớp học (Lớp học - Kỳ học - Tên môn học)
        public DataTable GetLopHoc()
        {
            DataTable dt = new DataTable();
            try
            {
                open_csdl() ;   
                string sql = @"
            SELECT 
                l.id_lophoc, 
                l.tenlop + ' - ' + k.kyhoc + ' - ' + m.tenmonhoc AS display_name
            FROM 
                tbl_lophoc l
            JOIN 
                tbl_monhoc m ON l.id_monhoc = m.id_monhoc
            JOIN 
                tbl_kyhoc k ON l.id_kyhoc = k.id_kyhoc
            WHERE 
                l.is_xoa = 0";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                close_csdl();
            }
            return dt;
        }

        // Lấy danh sách điểm dựa vào id_sv và id_lophoc
        public DataTable GetDiem(int id_sv, int id_lophoc)
        {
            DataTable dt = new DataTable();
            try
            {
                open_csdl();
                string sql = @"
            SELECT 
                d.id_sv, d.id_daudiem, dd.tendaudiem, d.diem, id_diem
            FROM 
                tbl_diem d
            JOIN 
                tbl_daudiem dd ON d.id_daudiem = dd.id_daudiem
            WHERE 
                d.id_sv = @id_sv AND dd.id_monhoc IN 
                (SELECT id_monhoc FROM tbl_lophoc WHERE id_lophoc = @id_lophoc)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id_sv", id_sv);
                cmd.Parameters.AddWithValue("@id_lophoc", id_lophoc);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                close_csdl();
            }
            return dt;
        }

        // Lấy danh sách đầu điểm cho ComboBox dựa vào id_lophoc
        public DataTable GetDauDiem(int id_lophoc)
        {
            DataTable dt = new DataTable();
            try
            {
                open_csdl();
                string sql = @"
            SELECT 
                dd.id_daudiem, dd.tendaudiem
            FROM 
                tbl_daudiem dd
            WHERE 
                dd.id_monhoc IN (SELECT id_monhoc FROM tbl_lophoc WHERE id_lophoc = @id_lophoc)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id_lophoc", id_lophoc);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                close_csdl() ;
            }
            return dt;
        }

        public bool KiemTraTonTaiDiem(int idSinhVien, int idDauDiem)
        {
            try
            {
                open_csdl();
                string sql = "SELECT COUNT(*) FROM tbl_diem WHERE id_sv = @idSinhVien AND id_daudiem = @idDauDiem AND is_xoa = 0";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@idSinhVien", idSinhVien);
                cmd.Parameters.AddWithValue("@idDauDiem", idDauDiem);
                int count = (int)cmd.ExecuteScalar();
                close_csdl();

                // Trả về true nếu đã tồn tại, false nếu chưa
                return count > 0;
            }
            catch (Exception ex)
            {
                close_csdl();
                throw new Exception("Lỗi kiểm tra tồn tại điểm: " + ex.Message);
            }
        }

        public bool KiemTraTonTaiDiemSua(int idSinhVien, int idDauDiem, int idDiem)
        {
            try
            {
                open_csdl();
                // Kiểm tra tồn tại điểm, loại trừ bản ghi đang được sửa
                string sql = "SELECT COUNT(*) FROM tbl_diem WHERE id_sv = @idSinhVien AND id_daudiem = @idDauDiem AND id_diem != @idDiem AND is_xoa = 0";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@idSinhVien", idSinhVien);
                cmd.Parameters.AddWithValue("@idDauDiem", idDauDiem);
                cmd.Parameters.AddWithValue("@idDiem", idDiem);
                int count = (int)cmd.ExecuteScalar();
                close_csdl();

                // Trả về true nếu đã tồn tại, false nếu chưa
                return count > 0;
            }
            catch (Exception ex)
            {
                close_csdl();
                throw new Exception("Lỗi kiểm tra tồn tại điểm: " + ex.Message);
            }
        }
    }
}

