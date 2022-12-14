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
    public class DAL_Mau_Sac:DBConnect
    {
        SqlDataAdapter da = new SqlDataAdapter();

        public DataTable lay_thong_tin_Mau()
        {
            try
            {
                conn.Open();
                string SQL = string.Format("SELECT * FROM mau_sac");
                da.SelectCommand = new SqlCommand(SQL, conn);
                DataTable dt_mau = new DataTable();
                da.Fill(dt_mau);
                return dt_mau;
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
        public bool them_mau_sac(DTO_Mau_Sac mau)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("INSERT INTO mau_sac(ma_mau,ten_mau) VALUES('{0}','{1}')", mau.Ma_mau, mau.Ten_mau);
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
        public bool sua_mau_sac(DTO_Mau_Sac mau)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("UPDATE mau_sac set ten_mau = '{0}' WHERE ma_mau = '{1}' ", mau.Ten_mau, mau.Ma_mau);
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

        public bool xoa_mau_sac(string ma)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("DELETE mau_sac WHERE ma_mau = '{0}' ", ma);
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
