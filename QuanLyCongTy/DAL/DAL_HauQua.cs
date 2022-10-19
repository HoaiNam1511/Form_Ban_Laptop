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
    public class DAL_HauQua:Connection
    {

        SqlDataAdapter da = new SqlDataAdapter();
        public DataTable thongTinHauQua()
        {
            try
            {
                conn.Open();
                string SQL = string.Format("SELECT * FROM TB_HAUQUA ORDER BY id_hau_qua DESC");
                da.SelectCommand = new SqlCommand(SQL, conn);
                DataTable dtHauQua = new DataTable();
                da.Fill(dtHauQua);
                return dtHauQua;
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

        public bool themHauQua(DTO_HauQua thongTinHauQua)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"INSERT INTO TB_HAUQUA(Hau_qua_nguoi,Phuong_tien,Nguyen_vat_lieu,Hau_qua_khac) VALUES(@nguoi,@phuongTien,@nguyenVatLieu,@khac)", conn);
                cmd.Parameters.AddWithValue("nguoi", thongTinHauQua.Nguoi);
                cmd.Parameters.AddWithValue("phuongTien", thongTinHauQua.PhuongTien);
                cmd.Parameters.AddWithValue("nguyenVatLieu", thongTinHauQua.NguyenVatLieu);
                cmd.Parameters.AddWithValue("khac", thongTinHauQua.Khac);
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

        public bool suaHauQua(DTO_HauQua thongTinHauQua,string maHauQua)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"UPDATE TB_HAUQUA SET Hau_qua_nguoi = @nguoi,Phuong_tien = @phuongTien,Nguyen_vat_lieu = @nguyenVatLieu,Hau_qua_khac = @khac WHERE Ma_hau_qua = @maHauQua", conn);
                cmd.Parameters.AddWithValue("nguoi", thongTinHauQua.Nguoi);
                cmd.Parameters.AddWithValue("phuongTien", thongTinHauQua.PhuongTien);
                cmd.Parameters.AddWithValue("nguyenVatLieu", thongTinHauQua.NguyenVatLieu);
                cmd.Parameters.AddWithValue("khac", thongTinHauQua.Khac);
                cmd.Parameters.AddWithValue("maHauQua", maHauQua);
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
        public bool xoaHauQua(string maHauQua)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"DELETE TB_HauQua WHERE Ma_hau_qua = @maHauQua", conn);
                cmd.Parameters.AddWithValue("maHauQua", maHauQua);
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
