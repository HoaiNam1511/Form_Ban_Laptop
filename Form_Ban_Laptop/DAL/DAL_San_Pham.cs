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
    public class DAL_San_Pham:DBConnect
    {
        SqlDataAdapter da = new SqlDataAdapter();

        public DataTable thong_tin_san_pham(string ma_hd)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("SELECT * FROM thong_tin_san_pham WHERE ma_hoa_don = '{0} '", ma_hd);
                da.SelectCommand = new SqlCommand(SQL, conn);
                DataTable dt_SanPham = new DataTable();
                da.Fill(dt_SanPham);
                return dt_SanPham;
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
        public DataTable list_san_pham(string ma_hd)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("SELECT * FROM thong_tin_san_pham WHERE ma_hoa_don = '{0} '", ma_hd);
                da.SelectCommand = new SqlCommand(SQL, conn);
                DataTable dt_SanPham = new DataTable();
                da.Fill(dt_SanPham);
                return dt_SanPham;
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
        // Su dung cho du Report
        public DataTable san_pham_theo_ma(string ma_hoa_don)
        {
         
            try
            {
                conn.Open();
                string SQL = string.Format("SELECT dbo.thongtin_hoa_don.ma_hoa_don, dbo.thongtin_hoa_don.ten_khach, dbo.thongtin_hoa_don.so_dien_thoai, dbo.thongtin_hoa_don.dia_chi, dbo.thongtin_hoa_don.ngay_ban, dbo.thongtin_hoa_don.ma_nv,dbo.thongtin_hoa_don.tong_thanh_toan,dbo.thong_tin_san_pham.ma_sp, dbo.thong_tin_san_pham.ma_laptop, dbo.thong_tin_san_pham.don_gia, dbo.thong_tin_san_pham.so_luong, dbo.thong_tin_san_pham.tong_tien, dbo.thong_tin_laptop.ten_laptop, dbo.thong_tin_laptop.ram, dbo.thong_tin_laptop.cpu, dbo.thong_tin_laptop.gpu, dbo.thong_tin_laptop.bo_nho,dbo.nhan_vien.ten_nv FROM dbo.thongtin_hoa_don INNER JOIN dbo.thong_tin_san_pham ON dbo.thongtin_hoa_don.ma_hoa_don = dbo.thong_tin_san_pham.ma_hoa_don INNER JOIN dbo.thong_tin_laptop ON dbo.thong_tin_san_pham.ma_laptop = dbo.thong_tin_laptop.ma_laptop INNER JOIN dbo.nhan_vien ON dbo.thongtin_hoa_don.ma_nv = dbo.nhan_vien.ma_nv WHERE dbo.thong_tin_san_pham.ma_hoa_don = '{0}' ", ma_hoa_don);
                da.SelectCommand = new SqlCommand(SQL, conn);
                DataTable dt_HoaDon = new DataTable();
                da.Fill(dt_HoaDon);
                return dt_HoaDon;
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
        // Su dung cho kho_hang
        public DataTable san_pham_theo_ma_laptop(string ma_laptop)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("SELECT ma_laptop,so_luong FROM thong_tin_san_pham WHERE ma_laptop = '{0}' ", ma_laptop);
                da.SelectCommand = new SqlCommand(SQL, conn);
                DataTable dt_So_luong = new DataTable();
                da.Fill(dt_So_luong);
                return dt_So_luong;
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
        public bool them_san_pham(DTO_San_Pham sanpham)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("INSERT INTO thong_tin_san_pham(ma_laptop,don_gia,so_luong,tong_tien,ma_hoa_don) VALUES('{0}','{1}','{2}','{3}','{4}')",sanpham.Ma_laptop,sanpham.Don_gia,sanpham.So_luong,sanpham.Tong_tien,sanpham.Ma_hoa_don);
                da.InsertCommand = new SqlCommand(SQL, conn);
                if (da.InsertCommand.ExecuteNonQuery() > 0)
                {
                    return true;
                }
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
        public bool sua_san_pham(DTO_San_Pham sanpham)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("UPDATE thong_tin_san_pham SET ma_laptop = '{0}', don_gia = '{1}',so_luong = '{2}',tong_tien = '{3}',ma_hoa_don = '{4}' WHERE ma_sp = '{5}'", sanpham.Ma_laptop, sanpham.Don_gia, sanpham.So_luong, sanpham.Tong_tien, sanpham.Ma_hoa_don,sanpham.Ma_sp);
                da.UpdateCommand = new SqlCommand(SQL, conn);
                if (da.UpdateCommand.ExecuteNonQuery() > 0)
                {
                    return true;
                }
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
        public bool xoa_san_pham(string ma)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("DELETE thong_tin_san_pham WHERE ma_sp = '{0}' ", ma);
                da.DeleteCommand = new SqlCommand(SQL, conn);
                if (da.DeleteCommand.ExecuteNonQuery() > 0)
                {
                    return true;
                }
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
