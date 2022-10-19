using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAL_TaiKhoan : Connection
    {
        SqlDataAdapter da = new SqlDataAdapter();

        public DataTable layThongTinQuyen()
        {
            try
            {
                conn.Open();
                da = new SqlDataAdapter("SELECT * FROM TB_QUYEN", conn);
                DataTable dtNhanSu = new DataTable();
                da.Fill(dtNhanSu);
                return dtNhanSu;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable layThongTinTaiKhoan()
        {
            try
            {
                conn.Open();
                da = new SqlDataAdapter("SELECT dbo.TB_TAIKHOAN.Id_tai_khoan, dbo.TB_TAIKHOAN.Ma_tai_khoan, dbo.TB_TAIKHOAN.Ten_tai_khoan, dbo.TB_TAIKHOAN.Mat_khau, dbo.TB_TAIKHOAN.Ma_quyen, dbo.TB_QUYEN.Ten_quyen FROM dbo.TB_QUYEN INNER JOIN dbo.TB_TAIKHOAN ON dbo.TB_QUYEN.Ma_quyen = dbo.TB_TAIKHOAN.Ma_quyen", conn);
                DataTable dtNhanSu = new DataTable();
                da.Fill(dtNhanSu);
                return dtNhanSu;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable chiTietTaiKhoan(string maTaiKhoan)
        {
                Console.WriteLine(maTaiKhoan);
            try
            {
                conn.Open();
                string SQL = string.Format("SELECT * FROM TB_TAIKHOAN WHERE Ma_tai_khoan = '{0}'", maTaiKhoan);
                da.SelectCommand = new SqlCommand(SQL, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool themTaiKhoan(DTO_TaiKhoan tk)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(@"INSERT INTO TB_TAIKHOAN(Ten_tai_khoan, Mat_khau, Ma_quyen) VALUES (@taikhoan, @matkhau, @maquyen)", conn);
                cmd.Parameters.AddWithValue("taikhoan", tk.TaiKhoan);
                cmd.Parameters.AddWithValue("matkhau", tk.MatKhau);
                cmd.Parameters.AddWithValue("maquyen", tk.MaQuyen);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public bool xoaTaiKhoan(string maTaiKhoan)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(@"Delete TB_TAIKHOAN where Ma_tai_khoan = @mataikhoan", conn);
                cmd.Parameters.AddWithValue("mataikhoan", maTaiKhoan);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public bool suaTaiKhoan(DTO_TaiKhoan tk, string maTaiKhoan)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(@"Update TB_TAIKHOAN set Ten_tai_khoan = @taikhoan, Mat_khau = @matkhau,  Ma_quyen = @maquyen where Ma_tai_khoan = @mataikhoan", conn);
                cmd.Parameters.AddWithValue("mataikhoan", maTaiKhoan);
                cmd.Parameters.AddWithValue("taikhoan", tk.TaiKhoan);
                cmd.Parameters.AddWithValue("matkhau", tk.MatKhau);
                cmd.Parameters.AddWithValue("maquyen", tk.MaQuyen);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                Console.WriteLine(cmd.ExecuteNonQuery().ToString());
                Console.WriteLine(maTaiKhoan);
                Console.WriteLine(tk.TaiKhoan);
                Console.WriteLine(tk.MatKhau);
                Console.WriteLine(tk.MaQuyen);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }

            return false;
        }

    }
}
