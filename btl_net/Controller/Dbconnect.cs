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
                string sql = "UPDATE tbl_chuyennganh SET is_xoa = 0 WHERE id_chuyennganh = @IdChuyenNganh";
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
                string sql = "UPDATE tbl_chuyennganh SET is_xoa = 1 WHERE id_chuyennganh = @IdChuyenNganh";
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
        public DataTable th_list_monhoc()
        {
            DataTable dt = new DataTable();
            try
            {
                open_csdl();

                // Câu lệnh SQL để lấy tất cả dữ liệu từ bảng tbl_monhoc và tên loại môn học từ tbl_phanloai_monhoc
                string sql = "select * from tbl_monhoc";

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                close_csdl();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL: " + ex.Message);
                throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                throw;
            }

            return dt;
        }

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
        public DataTable th_list_kyhoc()
        {
            DataTable dt = new DataTable();
            try
            {
                open_csdl();
                string sql = "select * from tbl_kyhoc";
                SqlCommand cmd = new SqlCommand(sql, conn);
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
                string sql = "UPDATE tbl_kyhoc SET is_xoa = 0 WHERE id_kyhoc = @IdKyhoc";
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
                string sql = "UPDATE tbl_kyhoc SET is_xoa = 1 WHERE id_kyhoc = @IdKyhoc";
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

        // Lop hoc *****************************************

        public DataTable list_lophoc()
        {
            DataTable dt = new DataTable();
            try
            {
                open_csdl();
                string sql = "SELECT lh.id_lophoc, lh.tenlophoc, lh.sinhvientoida, lh.is_xoa, kh.kyhoc, mh.tenmonhoc " +
                             "FROM tbl_lophoc AS lh " +
                             "INNER JOIN tbl_kyhoc AS kh ON lh.id_kyhoc = kh.id_kyhoc " +
                             "INNER JOIN tbl_monhoc AS mh ON lh.id_monhoc = mh.id_monhoc";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }

                dt.Columns.Add("ti_le_sinh_vien", typeof(string));

                foreach (DataRow row in dt.Rows)
                {
                    int id_lophoc = Convert.ToInt32(row["id_lophoc"]); // Sửa lỗi: chuyển đổi sang int
                    int sinhvientoida = Convert.ToInt32(row["sinhvientoida"]); // Sửa lỗi: chuyển đổi sang int

                    int conHocCount = count_sinhvien_conhoc_theo_lop(id_lophoc);

                    // Xử lý trường hợp sinhvientoida = 0
                    string tiLe = sinhvientoida > 0 ? $"{conHocCount}/{sinhvientoida}" : $"{conHocCount}/0";

                    row["ti_le_sinh_vien"] = tiLe;
                }

                dt.Columns.Remove("sinhvientoida");
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
        public DataTable search_lophoc(string tenlophoc, string kyhoc, string tenmonhoc)
        {
            DataTable dt = new DataTable();
            try
            {
                open_csdl();
                string sql = "SELECT lh.id_lophoc, lh.tenlophoc, lh.sinhvientoida,lh.is_xoa, kh.kyhoc, mh.tenmonhoc " +
                             "FROM tbl_lophoc AS lh " +
                             "INNER JOIN tbl_kyhoc AS kh ON lh.id_kyhoc = kh.id_kyhoc " +
                             "INNER JOIN tbl_monhoc AS mh ON lh.id_monhoc = mh.id_monhoc " +
                             "WHERE lh.tenlophoc LIKE @tenlophoc AND kh.kyhoc LIKE @kyhoc AND mh.tenmonhoc LIKE @tenmonhoc";


                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@tenlophoc", "%" + tenlophoc + "%"); // Sửa lỗi LIKE
                    cmd.Parameters.AddWithValue("@kyhoc", "%" + kyhoc + "%"); // Thêm tham số cho kyhoc
                    cmd.Parameters.AddWithValue("@tenmonhoc", "%" + tenmonhoc + "%"); // Thêm tham số cho tenmonhoc

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    dt.Columns.Add("ti_le_sinh_vien", typeof(string));

                    foreach (DataRow row in dt.Rows)
                    {
                        int id_lophoc = Convert.ToInt32(row["id_lophoc"]); // Sửa lỗi: chuyển đổi sang int
                        int sinhvientoida = Convert.ToInt32(row["sinhvientoida"]); // Sửa lỗi: chuyển đổi sang int

                        int conHocCount = count_sinhvien_conhoc_theo_lop(id_lophoc);

                        // Xử lý trường hợp sinhvientoida = 0
                        string tiLe = sinhvientoida > 0 ? $"{conHocCount}/{sinhvientoida}" : $"{conHocCount}/0";

                        row["ti_le_sinh_vien"] = tiLe;
                    }

                    dt.Columns.Remove("sinhvientoida");
                }
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

        public int count_sinhvien_conhoc_theo_lop(int id_lophoc)
        {
            try
            {
                // KHÔNG cần open_csdl() ở đây vì kết nối đã được mở trong list_lophoc()

                string sql = "SELECT COUNT(*)" +
                    " FROM tbl_ghidanh AS gd" +
                    " INNER JOIN tbl_sinhvien AS sv ON gd.id_sv = sv.id_sv" +
                    " WHERE sv.is_conhoc = 1 AND gd.id_lophoc = @id_lophoc"; // Sửa lỗi: Thêm sv. và gd.


                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id_lophoc", id_lophoc);
                    return (int)cmd.ExecuteScalar();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL: " + ex.Message);
                throw;
            }
        }

        public void them_lophoc(lophoc_Model lh)
        {
            try
            {
                open_csdl();
                string sql = "INSERT INTO tbl_lophoc (id_monhoc, tenlophoc, sinhvientoida, id_kyhoc) " +
                             "VALUES (@id_monhoc, @tenlophoc, @sinhvientoida, @id_kyhoc)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                // Thêm các tham số, đảm bảo kiểu dữ liệu phù hợp với kiểu dữ liệu của cột trong database
                cmd.Parameters.AddWithValue("@id_monhoc", lh.Id_monhoc);
                cmd.Parameters.AddWithValue("@tenlophoc", lh.Tenlophoc);
                cmd.Parameters.AddWithValue("@sinhvientoida", lh.Sinhvientoida);
                cmd.Parameters.AddWithValue("@id_kyhoc", lh.Id_kyhoc);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm lớp học thành công!"); // Hiển thị thông báo thành công
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm lớp học: " + ex.Message);
            }
            finally
            {
                close_csdl();
            }
        }
        public void sua_lophoc(lophoc_Model lh)
        {
            try
            {
                open_csdl();
                string sql = "UPDATE tbl_lophoc SET id_monhoc = @id_monhoc, tenlophoc = @tenlophoc, " +
                             "sinhvientoida = @sinhvientoida, id_kyhoc = @id_kyhoc " +
                             "WHERE id_lophoc = @id_lophoc"; // Cần có điều kiện WHERE để xác định lớp học cần sửa

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id_monhoc", lh.Id_monhoc);
                cmd.Parameters.AddWithValue("@tenlophoc", lh.Tenlophoc);
                cmd.Parameters.AddWithValue("@sinhvientoida", lh.Sinhvientoida);
                cmd.Parameters.AddWithValue("@id_kyhoc", lh.Id_kyhoc);
                cmd.Parameters.AddWithValue("@id_lophoc", lh.Id_lophoc);


                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Sửa lớp học thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa lớp học: " + ex.Message);
            }
            finally
            {
                close_csdl();
            }
        }
        public void xoa_lophoc(int id_lophoc)
        {
            try
            {
                open_csdl();
                string sql = "UPDATE tbl_lophoc SET is_xoa = 1" +
                             "WHERE id_lophoc = @id_lophoc"; // Cần có điều kiện WHERE để xác định lớp học cần sửa

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id_lophoc", id_lophoc);


                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xóa lớp học thành công!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi Xóa lớp học: " + ex.Message);
            }
            finally
            {
                close_csdl();
            }
        }
        public void khoiphuc_lophoc(int id_lophoc)
        {
            try
            {
                open_csdl();
                string sql = "UPDATE tbl_lophoc SET is_xoa = 0" +
                             "WHERE id_lophoc = @id_lophoc"; // Cần có điều kiện WHERE để xác định lớp học cần sửa

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id_lophoc", id_lophoc);


                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Khôi phục lớp học thành công!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi khôi phục lớp học: " + ex.Message);
            }
            finally
            {
                close_csdl();
            }
        }

        // form thống kê ***************
        public DataTable search_thongke(string masv, string tensv, string tenlophoc, string kyhoc, string monhoc, string nganhhoc)
        {
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            try
            {
                open_csdl();
                string sql = "SELECT sv.msv, sv.hoten, gd.sobuoinghi,kh.kyhoc ,cn.tenchuyennganh, lh.tenlophoc, mh.tenmonhoc, mh.diemquamon, mh.max_bh_chophep, dd.tendaudiem, dd.tyle, d.diem " +
                            "FROM tbl_sinhvien AS sv " +
                            "INNER JOIN tbl_chuyennganh AS cn ON sv.id_chuyennganh = cn.id_chuyennganh " +
                            "INNER JOIN tbl_ghidanh AS gd ON sv.id_sv = gd.id_sv " +
                            "INNER JOIN tbl_lophoc AS lh ON gd.id_lophoc = lh.id_lophoc " +
                            "INNER JOIN tbl_kyhoc AS kh ON lh.id_kyhoc = kh.id_kyhoc " +
                            "INNER JOIN tbl_monhoc AS mh ON lh.id_monhoc = mh.id_monhoc " +
                            "INNER JOIN tbl_daudiem AS dd ON mh.id_monhoc = dd.id_monhoc " +
                            "INNER JOIN tbl_diem AS d ON dd.id_daudiem = d.id_daudiem AND sv.id_sv = d.id_sv " +
                            "WHERE lh.tenlophoc LIKE @tenlophoc AND kh.kyhoc LIKE @kyhoc AND mh.tenmonhoc LIKE @tenmonhoc AND cn.tenchuyennganh LIKE @tenchuyennganh AND sv.msv LIKE @msv AND sv.hoten LIKE @hoten " +
                            "ORDER BY sv.msv ASC ";


                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@tenlophoc", "%" + tenlophoc + "%");
                    cmd.Parameters.AddWithValue("@kyhoc", "%" + kyhoc + "%");
                    cmd.Parameters.AddWithValue("@tenmonhoc", "%" + monhoc +"%");
                    cmd.Parameters.AddWithValue("@tenchuyennganh", "%" + nganhhoc + "%");
                    cmd.Parameters.AddWithValue("@msv", "%" + masv + "%");
                    cmd.Parameters.AddWithValue("@hoten", "%" + tensv + "%");

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt1);
                    }
                    dt2.Columns.Add("is_pass", typeof(bool));
                    dt2.Columns.Add("msv", typeof(string));
                    dt2.Columns.Add("hoten", typeof(string));
                    dt2.Columns.Add("kyhoc", typeof(string));
                    dt2.Columns.Add("tenchuyennganh", typeof(string));
                    dt2.Columns.Add("tenlophoc", typeof(string));
                    dt2.Columns.Add("tenmonhoc", typeof(string));
                    dt2.Columns.Add("diemquamon", typeof(string));
                    dt2.Columns.Add("max_bh_chophep", typeof(string));
                    dt2.Columns.Add("detail", typeof(string));

                    if(dt1.Rows.Count <= 0)
                    {
                        MessageBox.Show("Không tồn tại !!!");
                        return dt2;
                    }




                    string current_msv = dt1.Rows[0]["msv"].ToString();
                    float diem_tong_ket = float.Parse(dt1.Rows[0]["tyle"].ToString()) * float.Parse(dt1.Rows[0]["diem"].ToString()); // Khởi tạo điểm tổng kết cho msv đầu tiên




                    for (int i = 1; i < dt1.Rows.Count; i++)
                    {
                        string msv = dt1.Rows[i]["msv"].ToString();

                        if (current_msv != msv)
                        {
                            AddRowToDt2(current_msv, i - 1, diem_tong_ket);  //Thêm row cho msv trước đó
                            diem_tong_ket = 0; // Reset điểm tổng kết
                            current_msv = msv;// Cập nhật msv hiện tại
                        }

                        diem_tong_ket += float.Parse(dt1.Rows[i]["tyle"].ToString()) * float.Parse(dt1.Rows[i]["diem"].ToString());
                        if (i == dt1.Rows.Count - 1)
                        {
                            AddRowToDt2(current_msv, i, diem_tong_ket); // Thêm dòng cuối cùng
                        }
                    }

                    void AddRowToDt2(string msv, int currentIndex, float diem_tong_ket1)
                    {

                        DataRow row2 = dt2.NewRow();
                        row2["msv"] = msv;
                        row2["hoten"] = dt1.Rows[currentIndex]["hoten"];
                        row2["tenchuyennganh"] = dt1.Rows[currentIndex]["tenchuyennganh"];
                        row2["tenmonhoc"] = dt1.Rows[currentIndex]["tenmonhoc"];
                        row2["diemquamon"] = dt1.Rows[currentIndex]["diemquamon"];
                        row2["max_bh_chophep"] = dt1.Rows[currentIndex]["max_bh_chophep"];

                        row2["kyhoc"] = dt1.Rows[currentIndex]["kyhoc"];
                        row2["tenlophoc"] = dt1.Rows[currentIndex]["tenlophoc"];

                        if (diem_tong_ket1 > float.Parse(dt1.Rows[currentIndex]["diemquamon"].ToString()) && float.Parse(dt1.Rows[currentIndex]["sobuoinghi"].ToString()) <= float.Parse(dt1.Rows[currentIndex]["max_bh_chophep"].ToString()))
                        {
                            row2["is_pass"] = 1;

                        }
                        else
                        {
                            row2["is_pass"] = 0;
                        }

                        row2["detail"] = $"Điểm tổng kết = {diem_tong_ket1} \nSố buổi nghỉ = {float.Parse(dt1.Rows[currentIndex]["sobuoinghi"].ToString())}";

                        dt2.Rows.Add(row2);

                    }

                    dt1.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi truy vấn cơ sở dữ liệu: " + ex.Message);
            }
            finally
            {
                close_csdl();
            }
            return dt2;
        }

    }
}

