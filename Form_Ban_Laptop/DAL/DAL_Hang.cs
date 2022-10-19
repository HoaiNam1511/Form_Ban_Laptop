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
    public class DAL_Hang:DBConnect
    {
        SqlDataAdapter da = new SqlDataAdapter();
        public DataTable lay_thong_tin_HANG()
        {
            da.SelectCommand = new SqlCommand("SELECT * FROM hang_laptop", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool them_hang(DTO_Hang hang)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("INSERT INTO hang_laptop(ma_hang,ten_hang) VALUES('{0}','{1}')", hang.Ma_hang, hang.Ten_hang);
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
        public bool sua_hang(DTO_Hang hang)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("UPDATE hang_laptop set ten_hang = '{0}' WHERE ma_hang = '{1}' ", hang.Ten_hang, hang.Ma_hang);
                da.UpdateCommand = new SqlCommand(SQL, conn);
                if(da.UpdateCommand.ExecuteNonQuery() > 0)
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

        public bool xoa_hang(string ma)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("DELETE hang_laptop WHERE ma_hang = '{0}' ", ma);
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
