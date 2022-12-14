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
    public class DAL_Hoa_Don:DBConnect
    {
        SqlDataAdapter da = new SqlDataAdapter();

        public DataTable lay_thong_tin_hoa_don()
        {
            try
            {
                conn.Open();
                string SQL = string.Format("SELECT dbo.hoa_don_ban.ma_hoa_don,dbo.hoa_don_ban.ten_khach, dbo.hoa_don_ban.dia_chi, dbo.hoa_don_ban.so_dt, dbo.hoa_don_ban.ngay_ban, dbo.hoa_don_ban.bao_hanh, dbo.hoa_don_ban.so_luong, " +
                "dbo.hoa_don_ban.don_gia,dbo.hoa_don_ban.tong_tien, dbo.hoa_don_ban.ma_laptop, dbo.hoa_don_ban.ma_nv, dbo.thong_tin_laptop.ten_laptop, dbo.nhan_vien.ten_nv " +
                "FROM dbo.hoa_don_ban INNER JOIN dbo.thong_tin_laptop ON dbo.hoa_don_ban.ma_laptop = dbo.thong_tin_laptop.ma_laptop INNER JOIN dbo.nhan_vien ON dbo.hoa_don_ban.ma_nv = dbo.nhan_vien.ma_nv");
                da.SelectCommand = new SqlCommand(SQL, conn);
                DataTable dt_hoa_don = new DataTable();
                da.Fill(dt_hoa_don);
                return dt_hoa_don;
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
        public bool them_hoa_don(DTO_Hoa_Don hoa_don)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("INSERT INTO hoa_don_ban(ma_hoa_don, ten_khach, dia_chi, so_dt, ngay_ban, bao_hanh, so_luong, don_gia, tong_tien, ma_laptop, ma_nv) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')",
                    hoa_don.Ma_hoa_don, hoa_don.Ten_khach, hoa_don.Dia_chi, hoa_don.So_dt, hoa_don.Ngay_ban, hoa_don.Bao_hanh, hoa_don.So_luong, hoa_don.Don_gia, hoa_don.Tong_tien, hoa_don.Ma_laptop, hoa_don.Ma_nv);
                da.InsertCommand = new SqlCommand(SQL, conn);
                if(da.InsertCommand.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public bool xoa_hoa_don(string ma)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("DELETE hoa_don_ban WHERE ma_hoa_don = '{0}' ", ma);
                da.DeleteCommand = new SqlCommand(SQL, conn);
                if(da.DeleteCommand.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public bool sua_hoa_don(DTO_Hoa_Don hoa_don)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("UPDATE hoa_don set ten_khach = '{0}', dia_chi = '{1}', so_dt = '{2}', ngay_ban = '{3}', bao_hanh = '{4}', so_luong = '{5}', giam_gia = '{6}', tong_tien = '{7}', ma_laptop = '{8}', ma_nv = '{9}' WHERE ma_hoa_don = '{10}'",
                    hoa_don.Ten_khach, hoa_don.Dia_chi, hoa_don.So_dt, hoa_don.Ngay_ban, hoa_don.Bao_hanh, hoa_don.So_luong, hoa_don.Don_gia, hoa_don.Tong_tien, hoa_don.Ma_laptop, hoa_don.Ma_nv, hoa_don.Ma_hoa_don);
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
    }
}
