using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_SuViec:Connection
    {
        SqlDataAdapter da = new SqlDataAdapter();
        public DataTable thongTinSuViec()
        {
            try
            {
                conn.Open();
                //string SQL = string.Format("SELECT dbo.TB_SUVIEC., dbo.TB_HAUQUA., dbo.TB_KETQUA., dbo.TB_CONGTY. FROM dbo.TB_SUVIEC INNER JOIN dbo.TB_HAUQUA ON dbo.TB_SUVIEC.Ma_hau_qua = dbo.TB_HAUQUA.Ma_hau_qua INNER JOIN dbo.TB_KETQUA ON dbo.TB_SUVIEC.Ma_ket_qua = dbo.TB_KETQUA.Ma_ket_qua INNER JOIN dbo.TB_CONGTY ON dbo.TB_SUVIEC.Ma_cong_ty = dbo.TB_CONGTY.Ma_cong_ty");
                string SQL = string.Format("SELECT * FROM View_TB_SUVIEC");
                da.SelectCommand = new SqlCommand(SQL, conn);
                DataTable dtSuViec = new DataTable();
                da.Fill(dtSuViec);
                return dtSuViec;
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
        public DataTable thongTinMotSuViec(string maSuViec)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("SELECT dbo.TB_SUVIEC.*, dbo.TB_HAUQUA.*, dbo.TB_KETQUA.*, dbo.TB_CONGTY.* FROM dbo.TB_SUVIEC INNER JOIN dbo.TB_HAUQUA ON dbo.TB_SUVIEC.Ma_hau_qua = dbo.TB_HAUQUA.Ma_hau_qua INNER JOIN dbo.TB_KETQUA ON dbo.TB_SUVIEC.Ma_ket_qua = dbo.TB_KETQUA.Ma_ket_qua INNER JOIN dbo.TB_CONGTY ON dbo.TB_SUVIEC.Ma_cong_ty = dbo.TB_CONGTY.Ma_cong_ty WHERE dbo.TB_SUVIEC.Ma_su_viec = '{0}' ", maSuViec);
                da.SelectCommand = new SqlCommand(SQL, conn);
                DataTable dtSuViec = new DataTable();
                da.Fill(dtSuViec);
                return dtSuViec;
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
        public bool themThongTinSuViec(DTO_SuViec thongTinSuViec, string maHauQua, string maKetQua)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"INSERT INTO TB_SUVIEC(Tom_tat_su_viec,Thoi_gian_bd,Thoi_gian_kt,Ma_hau_qua,Ma_ket_qua,Ma_cong_ty) VALUES(@tomTatSuViec,@thoiGianBD,@thoiGianKT,@maHauQua,@maKetQua,@maCongTy)", conn);
                cmd.Parameters.AddWithValue("tomTatSuViec", thongTinSuViec.TomTatSuViec);
                cmd.Parameters.AddWithValue("thoiGianBD", thongTinSuViec.ThoiGianBD);
                cmd.Parameters.AddWithValue("thoiGianKT", thongTinSuViec.ThoiGianKT);
                cmd.Parameters.AddWithValue("maHauQua", maHauQua);
                cmd.Parameters.AddWithValue("maKetQua", maKetQua);
                cmd.Parameters.AddWithValue("maCongTy", thongTinSuViec.MaCongTy);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public bool suaThongSuViec(DTO_SuViec thongTinSuViec, string maSuViec)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"UPDATE TB_SUVIEC SET Tom_tat_su_viec = @tomTatSuViec,Thoi_gian_bd = @thoiGianBD,Thoi_gian_kt =@thoiGianKT, Ma_cong_ty = @maCongTy WHERE Ma_su_viec = @maSuViec", conn);
                cmd.Parameters.AddWithValue("tomTatSuViec", thongTinSuViec.TomTatSuViec);
                cmd.Parameters.AddWithValue("thoiGianBD", thongTinSuViec.ThoiGianBD);
                cmd.Parameters.AddWithValue("thoiGianKT", thongTinSuViec.ThoiGianKT);
                cmd.Parameters.AddWithValue("maCongTy", thongTinSuViec.MaCongTy);
                cmd.Parameters.AddWithValue("maSuViec", maSuViec);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public bool xoaThongTinSuViec(string maSuViec)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"DELETE TB_SUVIEC WHERE Ma_su_viec = @maSuViec", conn);
                cmd.Parameters.AddWithValue("maSuViec", maSuViec);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return false;

        }
    }
}
