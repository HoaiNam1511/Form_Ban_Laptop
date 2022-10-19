using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public class DAL_Thong_Tin_Laptop:DBConnect
    {
        SqlDataAdapter da = new SqlDataAdapter();
        public DataTable lay_thong_tin_laptop()
        {
            try
            {
                //INNER JOIN dbo.mau_sac ON dbo.thong_tin_laptop.ma_mau = dbo.mau_sac.ma_mau INNER JOIN dbo.loai_laptop ON dbo.thong_tin_laptop.ma_loai = dbo.loai_laptop.ma_loai INNER JOIN dbo.hang_laptop ON dbo.thong_tin_laptop.ma_hang = dbo.hang_laptop.ma_hang
                da.SelectCommand = new SqlCommand("SELECT * FROM dbo.thong_tin_laptop ", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch(Exception ex)
            {
                throw ex;
            }  
        }
        public DataTable chi_tiet_thong_tin(string ma)
        {
            string SQL = string.Format("SELECT * FROM dbo.thong_tin_laptop INNER JOIN dbo.hang_laptop ON dbo.thong_tin_laptop.ma_hang = dbo.hang_laptop.ma_hang INNER JOIN dbo.loai_laptop ON dbo.thong_tin_laptop.ma_loai = dbo.loai_laptop.ma_loai INNER JOIN dbo.mau_sac ON dbo.thong_tin_laptop.ma_mau = dbo.mau_sac.ma_mau WHERE ma_laptop = '{0}' ",ma);
            da.SelectCommand = new SqlCommand(SQL, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable thong_tin_1_laptop(string ma)
        {
            string SQL = string.Format("SELECT * FROM thong_tin_laptop WHERE ma_laptop = '{0}' ", ma);
            da.SelectCommand = new SqlCommand(SQL, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool them_thong_tin_Laptop(DTO_Thong_Tin_Laptop tt_lap)
        {
            try
            {
                conn.Open();
                //String.Format -> dinh dang chuoi, {0} => placeholder 
                string SQL = string.Format("INSERT INTO thong_tin_laptop(ma_laptop, ten_laptop, gia_ban, chat_lieu, ram, cpu, gpu, bo_nho, ma_loai,ma_mau,ma_hang,file_name) VALUES('{0}','{1}','{2}',N'{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}') "
                    , tt_lap.Ma_laptop, tt_lap.Ten_laptop, tt_lap.Gia_ban, tt_lap.Chat_lieu, tt_lap.Ram, tt_lap.Cpu, tt_lap.Card, tt_lap.Bo_nho, tt_lap.Ma_loai, tt_lap.Ma_mau, tt_lap.Ma_hang,tt_lap.Ten_file);
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

        public bool sua_thong_tin_Laptop(DTO_Thong_Tin_Laptop tt_lap)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("UPDATE thong_tin_laptop set ten_laptop = '{0}', gia_ban = '{1}', chat_lieu = N'{2}', ram = '{3}', cpu = '{4}', gpu ='{5}', bo_nho = '{6}', ma_loai = '{7}',ma_mau = '{8}',ma_hang = '{9}',file_name='{10}' WHERE ma_laptop = '{11}' "
                    , tt_lap.Ten_laptop, tt_lap.Gia_ban, tt_lap.Chat_lieu, tt_lap.Ram, tt_lap.Cpu, tt_lap.Card, tt_lap.Bo_nho, tt_lap.Ma_loai, tt_lap.Ma_mau, tt_lap.Ma_hang, tt_lap.Ten_file, tt_lap.Ma_laptop);
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

        public bool xoa_thong_tin_Laptop(string ma)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("DELETE thong_tin_laptop where ma_laptop = '{0}' ",ma);
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
