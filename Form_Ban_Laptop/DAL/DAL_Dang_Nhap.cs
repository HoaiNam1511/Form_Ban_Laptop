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
    public class DAL_Dang_Nhap:DBConnect
    {
        SqlDataAdapter da = new SqlDataAdapter();
        public DataTable thong_tin_tai_khoan(DTO_Dang_Nhap tai_khoan)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("SELECT * FROM tai_khoan where tai_khoan = '{0}' and mat_khau = '{1}' ", tai_khoan.Ten_tai_khoan,tai_khoan.Mat_khau);
                da.SelectCommand = new SqlCommand(SQL, conn);
                DataTable tb_tai_khoan = new DataTable();
                da.Fill(tb_tai_khoan);
                return tb_tai_khoan;
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
