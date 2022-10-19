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
    public class DAL_NhanSu : Connection
    {
        SqlDataAdapter da = new SqlDataAdapter();
        public bool themThongTinNhanSu(DTO_NhanSu thongTinNhanSu)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("INSERT INTO TB_NHANSU(Ma_nhan_vien,Ho_ten,Quoc_tich,Nam_sinh,Ho_khau,Ma_chuc_vu,Thong_tin_khac,Ma_cong_ty,CCCD) VALUES(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}')",
                    thongTinNhanSu.MaNhanVien,thongTinNhanSu.HoTen, thongTinNhanSu.QuocTich, thongTinNhanSu.NamSinh, thongTinNhanSu.NoiDangKyThuongTru, thongTinNhanSu.ChucVu, thongTinNhanSu.ThongTinKhac, thongTinNhanSu.MaCongTy,thongTinNhanSu.CCCD1);
                da.InsertCommand = new SqlCommand(SQL, conn);
                if (da.InsertCommand.ExecuteNonQuery() > 0)
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
        public bool suaThongTinNhanSu( DTO_NhanSu thongTinNhanSu)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("UPDATE TB_NHANSU SET Ho_ten = N'{0}',Quoc_tich = N'{1}',Nam_sinh = N'{2}',Ho_khau= N'{3}',Ma_chuc_vu = N'{4}',Thong_tin_khac = N'{5}',Ma_cong_ty= N'{6}', CCCD = N'{7}' WHERE Ma_nhan_vien = '{8}' ",
                    thongTinNhanSu.HoTen, thongTinNhanSu.QuocTich, thongTinNhanSu.NamSinh, thongTinNhanSu.NoiDangKyThuongTru, thongTinNhanSu.ChucVu, thongTinNhanSu.ThongTinKhac, thongTinNhanSu.MaCongTy,thongTinNhanSu.CCCD1, thongTinNhanSu.MaNhanVien);
                da.UpdateCommand = new SqlCommand(SQL, conn);
                if (da.UpdateCommand.ExecuteNonQuery() > 0)
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

        public DataTable thongTinNhanSu()
        {
            try
            {
                conn.Open();
                string SQL = string.Format("SELECT dbo.TB_NHANSU.*, dbo.TB_CONGTY.Ten_cong_ty, dbo.TB_CHUCVU.Ten_chuc_vu, dbo.TB_NHOMCHUCVU.Ten_nhom_chuc_vu FROM dbo.TB_NHANSU INNER JOIN dbo.TB_CONGTY ON dbo.TB_NHANSU.Ma_cong_ty = dbo.TB_CONGTY.Ma_cong_ty INNER JOIN dbo.TB_CHUCVU ON dbo.TB_NHANSU.Ma_chuc_vu = dbo.TB_CHUCVU.Ma_chuc_vu INNER JOIN dbo.TB_NHOMCHUCVU ON dbo.TB_CHUCVU.Ma_nhom_chuc_vu = dbo.TB_NHOMCHUCVU.Ma_nhom_chuc_vu");
                
                da.SelectCommand = new SqlCommand(SQL, conn);
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

        public bool xoaThongTinNhanSu(string maNhanSu)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("DELETE TB_NHANSU WHERE Ma_nhan_vien = '{0}' ", maNhanSu);
                da.DeleteCommand = new SqlCommand(SQL, conn);
                if (da.DeleteCommand.ExecuteNonQuery() > 0)
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

        public DataTable thongTinNhanVienExport(string maCongTy)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("SELECT dbo.TB_NHANSU.*, dbo.TB_CHUCVU.Ten_chuc_vu, dbo.TB_CONGTY.Ten_cong_ty, dbo.TB_CONGTY.Dia_chi_cong_ty FROM dbo.TB_CONGTY INNER JOIN dbo.TB_NHANSU INNER JOIN dbo.TB_CHUCVU ON dbo.TB_NHANSU.Ma_chuc_vu = dbo.TB_CHUCVU.Ma_chuc_vu ON dbo.TB_CONGTY.Ma_cong_ty = dbo.TB_NHANSU.Ma_cong_ty WHERE dbo.TB_NHANSU.Ma_cong_ty= '{0}' ", maCongTy);
                da.SelectCommand = new SqlCommand(SQL, conn);
                DataTable dtNhanVienExport = new DataTable();
                da.Fill(dtNhanVienExport);
                return dtNhanVienExport;
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
    }
}

