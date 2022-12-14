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
    public class DAL_Loai_Laptop:DBConnect
    {
        SqlDataAdapter da = new SqlDataAdapter();
        public DataTable lay_thong_tin_Loai()
        {
            try
            {
                conn.Open();
                string SQL = string.Format("SELECT * FROM loai_laptop");
                da.SelectCommand = new SqlCommand(SQL, conn);
                DataTable dt_loai = new DataTable();
                da.Fill(dt_loai);
                return dt_loai;
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
        public bool them_loai(DTO_Loai_Laptop loai)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("INSERT INTO loai_laptop(ma_loai,ten_loai) VALUES('{0}','{1}')", loai.Ma_loai, loai.Ten_loai);
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
        public bool sua_loai(DTO_Loai_Laptop loai)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("UPDATE loai_laptop set ten_loai = '{0}' WHERE ma_loai = '{1}' ", loai.Ten_loai, loai.Ma_loai);
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

        public bool xoa_loai(string ma)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("DELETE loai_laptop WHERE ma_loai = '{0}' ", ma);
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
