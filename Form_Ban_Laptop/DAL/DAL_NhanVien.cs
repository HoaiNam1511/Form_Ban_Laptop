using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class DAL_NhanVien:DBConnect
    {
        SqlDataAdapter da = new SqlDataAdapter();
        
        public bool them_thong_tin_nv(DTO_NhanVien nv)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("INSERT INTO nhan_vien(ma_nv,ten_nv,dia_chi,gioi_tinh,so_dt,ngay_sinh) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", nv.Manv, nv.Tennv, nv.Diachi, nv.Gioitinh, nv.Sodt, nv.Ngaysinh);
                da.InsertCommand = new SqlCommand(SQL, conn);
                if(da.InsertCommand.ExecuteNonQuery() > 0)
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
        public bool sua_nhan_vien(DTO_NhanVien nv)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("UPDATE nhan_vien SET ten_nv = '{0}',dia_chi = '{1}',gioi_tinh = '{2}',so_dt = '{3}',ngay_sinh = '{4}' WHERE ma_nv = '{5}' ", nv.Tennv, nv.Diachi, nv.Gioitinh, nv.Sodt, nv.Ngaysinh, nv.Manv);
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
        public bool xoa_nhan_vien(string ma)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("DELETE nhan_vien WHERE ma_nv = '{0}' ", ma);
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
        public DataTable lay_thong_tin_NV()
        {
            da.SelectCommand = new SqlCommand("SELECT * FROM nhan_vien", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable thong_tin_1_nv(string ma)
        {
            string SQL = string.Format("SELECT * FROM nhan_vien WHERE ma_nv = '{0}' ", ma);
            da.SelectCommand = new SqlCommand(SQL, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //public bool kiem_tra_ma_NV(string manv)
        //{
        //    try
        //    {
        //        conn.Open();
        //        string SQL = string.Format("SELECT count(*) from nhan_vien_1 WHERE ma_nv = '{0}' ", manv);
        //        da.SelectCommand = new SqlCommand(SQL, conn);
        //        if (da.SelectCommand.ExecuteNonQuery > 0)
        //        {
        //            return true;

        //        }
        //    }
        //     catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //    return false;
        //}
    }
}
