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
    public class DAL_Hoa_Don_Ban:DBConnect
    {
        SqlDataAdapter da = new SqlDataAdapter();
        //public DataTable thong_tin_hoa_don()
        //{
        //    da.SelectCommand = new SqlCommand("SELECT dbo.thongtin_hoa_don.ma_hoa_don, dbo.thongtin_hoa_don.ten_khach, dbo.thongtin_hoa_don.so_dien_thoai, dbo.thongtin_hoa_don.dia_chi, dbo.thongtin_hoa_don.ngay_ban, dbo.thongtin_hoa_don.ma_nv , dbo.nhan_vien.ten_nv FROM dbo.thongtin_hoa_don INNER JOIN dbo.nhan_vien ON dbo.thongtin_hoa_don.ma_nv = dbo.nhan_vien.ma_nv", conn);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    return dt;
        //}

        public DataTable thong_tin_hoa_don()
        {
            try
            {
                conn.Open();

                string SQl = string.Format("SELECT dbo.thongtin_hoa_don.ma_hoa_don, dbo.thongtin_hoa_don.ten_khach, dbo.thongtin_hoa_don.so_dien_thoai, dbo.thongtin_hoa_don.dia_chi, dbo.thongtin_hoa_don.ngay_ban, dbo.thongtin_hoa_don.ma_nv , dbo.nhan_vien.ten_nv FROM dbo.thongtin_hoa_don INNER JOIN dbo.nhan_vien ON dbo.thongtin_hoa_don.ma_nv = dbo.nhan_vien.ma_nv");
                da.SelectCommand = new SqlCommand(SQl, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
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
        public DataTable thong_tin_1_hoa_don(string ma)
        {
            try
            {
                conn.Open();

                string SQl = string.Format("SELECT dbo.thongtin_hoa_don.ma_hoa_don, dbo.thongtin_hoa_don.ten_khach, dbo.thongtin_hoa_don.so_dien_thoai, dbo.thongtin_hoa_don.dia_chi, dbo.thongtin_hoa_don.ngay_ban, dbo.thongtin_hoa_don.ma_nv , dbo.nhan_vien.ten_nv FROM dbo.thongtin_hoa_don INNER JOIN dbo.nhan_vien ON dbo.thongtin_hoa_don.ma_nv = dbo.nhan_vien.ma_nv WHERE dbo.thongtin_hoa_don.ma_hoa_don = '{0}' ", ma);
                da.SelectCommand = new SqlCommand(SQl, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
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

        public bool them_hoa_don(DTO_Hoa_Don_Ban hoa_don)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("INSERT INTO thongtin_hoa_don(ma_hoa_don, ten_khach, dia_chi, so_dien_thoai, ngay_ban, ma_nv) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')",
                    hoa_don.Ma_hoa_don, hoa_don.Ten_khach, hoa_don.Dia_chi, hoa_don.So_dt, hoa_don.Ngay_ban, hoa_don.Ma_nv);
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

        public bool sua_hoa_don(DTO_Hoa_Don_Ban hoa_don)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("UPDATE thongtin_hoa_don set ten_khach ='{0}', so_dien_thoai='{1}',dia_chi='{2}', ngay_ban='{3}', ma_nv='{4}' WHERE ma_hoa_don = '{5}'",
                     hoa_don.Ten_khach, hoa_don.So_dt, hoa_don.Dia_chi, hoa_don.Ngay_ban, hoa_don.Ma_nv, hoa_don.Ma_hoa_don);
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
        public bool sua_tong_thanh_toan(string ma,int tong_thanh_toan)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("UPDATE thongtin_hoa_don SET tong_thanh_toan = '{0}' WHERE ma_hoa_don = '{1}' ", tong_thanh_toan,ma);
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
        public bool xoa_hoa_don(string ma)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("DELETE thongtin_hoa_don WHERE ma_hoa_don = '{0}' ", ma);
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
    }
    
}
