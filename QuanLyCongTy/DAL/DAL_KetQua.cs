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
    public class DAL_KetQua:Connection
    {
        SqlDataAdapter da = new SqlDataAdapter();
        public DataTable thongTinKetQua()
        {
            try
            {
                conn.Open();
                string SQL = string.Format("SELECT * FROM TB_KETQUA ORDER BY id_ket_qua DESC");
                da.SelectCommand = new SqlCommand(SQL, conn);
                DataTable dtKetQua = new DataTable();
                da.Fill(dtKetQua);
                return dtKetQua;
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

        public bool themKetQua(DTO_KetQua thongTinKetQua)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"INSERT INTO TB_KETQUA(Toi_danh_nguoi,Toi_danh,Hanh_chinh_nguoi, Hanh_vi,Ket_qua_khac,Nhom) VALUES(@ToiDanhNguoi,@toiDanh,@HanhChinhNguoi,@hanhVi,@khac,@nhom)", conn);
                cmd.Parameters.AddWithValue("ToiDanhNguoi", thongTinKetQua.ToiDanhNguoi);
                cmd.Parameters.AddWithValue("toiDanh", thongTinKetQua.ToiDanh);
                cmd.Parameters.AddWithValue("HanhChinhNguoi", thongTinKetQua.HanhChinhNguoi);
                cmd.Parameters.AddWithValue("hanhVi", thongTinKetQua.HanhVi);
                cmd.Parameters.AddWithValue("khac", thongTinKetQua.Khac);
                cmd.Parameters.AddWithValue("nhom", thongTinKetQua.Nhom);
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

        public bool suaKetQua(DTO_KetQua thongTinKetQua, string maKetQua)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"UPDATE TB_KETQUA SET Toi_danh_nguoi = @ToiDanhNguoi,Toi_danh = @toiDanh,Hanh_chinh_nguoi = @HanhChinhNguoi,Hanh_vi =@hanhVi,Ket_qua_khac = @khac,Nhom = @nhom WHERE Ma_ket_qua = @maKetQua", conn);
                cmd.Parameters.AddWithValue("ToiDanhNguoi", thongTinKetQua.ToiDanhNguoi);
                cmd.Parameters.AddWithValue("toiDanh", thongTinKetQua.ToiDanh);
                cmd.Parameters.AddWithValue("HanhChinhNguoi", thongTinKetQua.HanhChinhNguoi);
                cmd.Parameters.AddWithValue("hanhVi", thongTinKetQua.HanhVi);
                cmd.Parameters.AddWithValue("khac", thongTinKetQua.Khac);
                cmd.Parameters.AddWithValue("nhom", thongTinKetQua.Nhom);
                cmd.Parameters.AddWithValue("maKetQua", maKetQua);
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

        public bool xoaKetQua(string maKetQua)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"DELETE TB_KETQUA WHERE Ma_ket_qua = @maKetQua", conn);
                cmd.Parameters.AddWithValue("maKetQua", maKetQua);
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
