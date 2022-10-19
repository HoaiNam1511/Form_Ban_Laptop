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
    public class DAL_CongTy : Connection
    {
        SqlDataAdapter da = new SqlDataAdapter();


        public DataTable layIdCongTy(string Ten_cong_ty)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("SELECT * FROM TB_CONGTY WHERE Ten_cong_ty = '{0}'", Ten_cong_ty);
                da.SelectCommand = new SqlCommand(SQL, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
                
        }

        public DataTable thongTinCongTy()
        {
            try
            {
                conn.Open();
                string SQL = string.Format("SELECT * FROM TB_CONGTY");
                da.SelectCommand = new SqlCommand(SQL, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool themThongTinCongTy(DTO_CongTy thongTinCongTy)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"INSERT INTO TB_CONGTY(Ten_cong_ty,Dia_chi_cong_ty) VALUES(@tenCongTy,@diaChi)", conn);
                cmd.Parameters.AddWithValue("tenCongTy", thongTinCongTy.TenCongTy);
                cmd.Parameters.AddWithValue("diaChi", thongTinCongTy.DiaChi);
                if (cmd.ExecuteNonQuery() > 0)
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
        public bool suaThongTinCongTy(string maCongTy, DTO_CongTy thongTinCongTy)
        {

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"UPDATE TB_CONGTY SET Ten_cong_ty = @tenCongTy,Dia_chi_cong_ty = @diaChi WHERE Ma_cong_ty = @maCongTy", conn);
                cmd.Parameters.AddWithValue("tenCongTy", thongTinCongTy.TenCongTy);
                cmd.Parameters.AddWithValue("diaChi", thongTinCongTy.DiaChi);
                cmd.Parameters.AddWithValue("maCongTy", maCongTy);
                if (cmd.ExecuteNonQuery() > 0)
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

        public bool xoaThongTinCongTy(string maCongTy)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"DELETE TB_CONGTY WHERE Ma_cong_ty = @maCongTy", conn);
                cmd.Parameters.AddWithValue("maCongTy", maCongTy);
                if (cmd.ExecuteNonQuery() > 0)
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
