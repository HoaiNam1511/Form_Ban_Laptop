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
    public class DAL_ChucVu:Connection
    {
        SqlDataAdapter da = new SqlDataAdapter();

        public DataTable layIdChucVu(string Ten_chuc_vu)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("SELECT * FROM TB_CHUCVU WHERE Ten_chuc_vu = '{0}'", Ten_chuc_vu);
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
        public DataTable layThongTinChucVu()
        {
            try
            {
                conn.Open();
                string SQL = string.Format("SELECT * FROM TB_CHUCVU");
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
        public DataTable layThongTinMotChucVuDESC()
        {
            try
            {
                conn.Open();
                string SQL = string.Format("SELECT Ma_chuc_vu FROM TB_CHUCVU ORDER BY Id_chuc_vu DESC");
                da.SelectCommand = new SqlCommand(SQL, conn);
                DataTable dtChucVu = new DataTable();
                da.Fill(dtChucVu);
                return dtChucVu;
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
        public DataTable layThongTinChucVuNhom(string maNhomChucVu)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("SELECT * FROM TB_CHUCVU WHERE Ma_nhom_chuc_vu = '{0}' OR Ma_nhom_chuc_vu = '' ORDER BY Id_chuc_vu desc ", maNhomChucVu);
                da.SelectCommand = new SqlCommand(SQL, conn);
                DataTable dtChucVuNhom = new DataTable();
                da.Fill(dtChucVuNhom);
                return dtChucVuNhom;
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
  
        public bool themThongTinChucVu(DTO_ChucVu thongTinChucVu)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"INSERT INTO TB_CHUCVU(Ten_chuc_vu,Ma_nhom_chuc_vu) VALUES(@tenChucVu,@maNhomChucVu)", conn);
                cmd.Parameters.AddWithValue("tenChucVu", thongTinChucVu.TenChucVu);
                cmd.Parameters.AddWithValue("maNhomChucVu", thongTinChucVu.MaNhomChucVu);
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
        public bool suaThongTinChucVu(string maChucVu, DTO_ChucVu thongTinChucVu)
        {

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"UPDATE TB_CHUCVU SET Ten_chuc_vu = @tenChucVu,Ma_nhom_chuc_vu = @maNhomChucVu WHERE Ma_chuc_vu = @maChucVu", conn);
                cmd.Parameters.AddWithValue("tenChucVu", thongTinChucVu.TenChucVu);
                cmd.Parameters.AddWithValue("maNhomChucVu", thongTinChucVu.MaNhomChucVu);
                cmd.Parameters.AddWithValue("maChucVu", maChucVu);
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

        public bool xoaThongTinChucVu(string maChucVu)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"DELETE TB_CHUCVU WHERE Ma_chuc_vu = @maChucVu", conn);
                cmd.Parameters.AddWithValue("maChucVu", maChucVu);
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
