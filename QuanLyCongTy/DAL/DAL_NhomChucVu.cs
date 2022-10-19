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
    public class DAL_NhomChucVu:Connection
    {
        SqlDataAdapter da = new SqlDataAdapter();
        public DataTable layThongTinNhomChucVu()
        {
            try
            {
                conn.Open();
                string SQL = string.Format("SELECT * FROM TB_NHOMCHUCVU ");
                da.SelectCommand = new SqlCommand(SQL, conn);
                DataTable dtNhomChucVu = new DataTable();
                da.Fill(dtNhomChucVu);
                return dtNhomChucVu;
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
        //public bool themThongTinChucVu(DTO_ChucVu thongTinChucVu)
        //{
        //    try
        //    {
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand(@"INSERT INTO TB_CHUCVU(Ten_chuc_vu) VALUES(@tenChucVu)", conn);
        //        cmd.Parameters.AddWithValue("tenChucVu", thongTinChucVu.TenChucVu);
        //        if (cmd.ExecuteNonQuery() > 0)
        //        {
        //            return true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //    return false;
        //}
        //public bool suaThongTinChucVu(string maChucVu, DTO_ChucVu thongTinChucVu)
        //{

        //    try
        //    {
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand(@"UPDATE TB_CHUCVU SET Ten_chuc_vu = @tenChucVu WHERE Ma_chuc_vu = @maChucVu", conn);
        //        cmd.Parameters.AddWithValue("tenChucVu", thongTinChucVu.TenChucVu);
        //        cmd.Parameters.AddWithValue("maChucVu", maChucVu);
        //        if (cmd.ExecuteNonQuery() > 0)
        //        {
        //            return true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //    return false;


        //}

        //public bool xoaThongTinChucVu(string maChucVu)
        //{
        //    try
        //    {
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand(@"DELETE TB_CHUCVU WHERE Ma_chuc_vu = @maChucVu", conn);
        //        cmd.Parameters.AddWithValue("maChucVu", maChucVu);
        //        if (cmd.ExecuteNonQuery() > 0)
        //        {
        //            return true;
        //        }
        //    }
        //    catch (Exception ex)
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
