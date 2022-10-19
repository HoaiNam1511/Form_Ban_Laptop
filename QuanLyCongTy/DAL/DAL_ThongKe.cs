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
    public class DAL_ThongKe : Connection
    {
        SqlDataAdapter da = new SqlDataAdapter();
        public DataTable timKiemAllSuviec(string tuKhoa)
        {
                                                                                             
            try
            {
                conn.Open();
                string SQL = string.Format("SELECT * FROM View_TB_SUVIEC " +
                "WHERE Ma_su_viec like '%{0}%' or Tom_tat_su_viec like '%{0}%' or Thoi_gian_bd like '%{0}%' or Thoi_gian_kt  like '%{0}%'" +
                "or Hau_qua_nguoi  like '%{0}%' or Phuong_tien like '%{0}%'or Nguyen_vat_lieu like '%{0}%' or Hau_qua_khac like '%{0}%' or " +
                "Toi_danh like '%{0}%' or Hanh_vi  like '%{0}%' or Toi_danh_nguoi like '%{0}%' or Hanh_chinh_nguoi like '%{0}%' or Nhom like '%{0}%' or Ket_qua_khac  like '%{0}%'" +
                " or Ten_cong_ty like '%{0}%'", tuKhoa);
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
        public DataTable timKiemAllNhanSu(string tuKhoa)
        {

            try
            {
                conn.Open();
                string SQL = string.Format("SELECT * FROM View_TB_NHANSU " +
                "WHERE Ma_nhan_vien like '%{0}%' or Ho_ten like '%{0}%' or Quoc_tich like '%{0}%' or Nam_sinh  like '%{0}%'" +
                "or Ho_khau  like '%{0}%' or Ma_chuc_vu like '%{0}%'or Thong_tin_khac like '%{0}%' or Ma_cong_ty like '%{0}%' or " +
                "Ten_cong_ty like '%{0}%' or Ten_chuc_vu  like '%{0}%' or Ten_nhom_chuc_vu like '%{0}%'", tuKhoa);
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

    }
}
