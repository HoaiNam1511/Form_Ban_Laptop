using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using System.Data.SqlClient;
namespace DAL
{
    public class DAL_Kho_Hang:DBConnect
    {
        SqlDataAdapter da = new SqlDataAdapter();

        public bool them_kho_hang(DTO_Kho_Hang kho)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("INSERT INTO kho_hang(ma_laptop,ten_laptop,gia_ban,so_luong_nhap,so_luong_ban,ton_kho) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", kho.Ma_laptop,kho.Ten_laptop,kho.Gia_ban,kho.So_luong_nhap,kho.So_luong_ban,kho.So_luong_ton);
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
        public bool sua_kho_hang(DTO_Kho_Hang kho)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("UPDATE kho_hang SET so_luong_nhap = {0},so_luong_ban = {1},ton_kho = {2} WHERE ma_laptop ='{3}' ", kho.So_luong_nhap,kho.So_luong_ban,kho.So_luong_ton,kho.Ma_laptop);
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
        public bool cap_nhat_sl_ban(DTO_Kho_Hang kho)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("UPDATE kho_hang SET so_luong_ban = {0} WHERE ma_laptop ='{1}' ", kho.So_luong_ban, kho.Ma_laptop);
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
     
        public bool xoa_kho_hang(string ma)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("DELETE kho_hang WHERE ma_laptop = '{0}' ", ma);
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
        public DataTable thong_tin_kho()
        {
            DataTable dt_kho = new DataTable();
            try
            {
                conn.Open();
                string SQL = string.Format("SELECT * FROM kho_hang");
                da.SelectCommand = new SqlCommand(SQL, conn);
                da.Fill(dt_kho);
                if (da.SelectCommand.ExecuteNonQuery() > 0)
                {
                    return dt_kho;
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
            return dt_kho;
        }
        // Cap nhat so luong phan san pham
        public DataTable so_luong_ton_kho(string ma_laptop)
        {
            DataTable dt_kho = new DataTable();
            try
            {
                conn.Open();
                string SQL = string.Format("SELECT ma_laptop,so_luong_nhap,so_luong_ban,ton_kho FROM kho_hang WHERE ma_laptop ='{0}' ", ma_laptop);
                da.SelectCommand = new SqlCommand(SQL, conn);
                da.Fill(dt_kho);
                if (da.SelectCommand.ExecuteNonQuery() > 0)
                {
                    return dt_kho;
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
            return dt_kho;
        }
        public bool cap_nhat_sl_them_sp(DTO_Kho_Hang so_luong)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("UPDATE kho_hang SET so_luong_ban = '{0}',ton_kho = '{1}' WHERE ma_laptop = '{2}' ", so_luong.So_luong_ban, so_luong.So_luong_ton, so_luong.Ma_laptop);
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
