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


















    }
}

