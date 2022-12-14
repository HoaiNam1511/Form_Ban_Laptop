using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using DTO;
using BUS;
using System.IO;


namespace Form_Ban_Laptop
{
    public partial class Form_Thong_Tin_Laptop : Form
    {
        BUS_Hang busHang = new BUS_Hang();
        BUS_Mau_Sac busMau = new BUS_Mau_Sac();
        BUS_Loai_Laptop busLoai = new BUS_Loai_Laptop();
        BUS_Thong_Tin_Laptop busThongTinLaptop = new BUS_Thong_Tin_Laptop();
        public Form_Thong_Tin_Laptop()
        {
            InitializeComponent();
        }

        public void Hienthi()
        {
            DataTable dt_laptop = busThongTinLaptop.thong_tin_laptop();
            dgvdanhsach.DataSource = dt_laptop;
            dgvdanhsach.Columns["ma_laptop"].HeaderText = "Mã Laptop";
            dgvdanhsach.Columns["ten_laptop"].HeaderText = "Tên";
            dgvdanhsach.Columns["gia_ban"].HeaderText = "Giá";
            dgvdanhsach.Columns["chat_lieu"].HeaderText = "Chất liệu";
            dgvdanhsach.Columns["ram"].HeaderText = "Ram";
            dgvdanhsach.Columns["cpu"].HeaderText = "Cpu";
            dgvdanhsach.Columns["gpu"].HeaderText = "Card";
            dgvdanhsach.Columns["bo_nho"].HeaderText = "Bộ nhớ";
            dgvdanhsach.Columns["ma_loai"].HeaderText = "Mã loại";
            dgvdanhsach.Columns["ma_mau"].HeaderText = "Mã màu";
            dgvdanhsach.Columns["ma_hang"].HeaderText = "Mã hãng";
            dgvdanhsach.Columns["file_name"].Visible = false;
            //dgvdanhsach.Columns["ma_loai"].Visible = false;
            //dgvdanhsach.Columns["ma_mau"].Visible = false;
            //dgvdanhsach.Columns["ma_hang"].Visible = false;
        }

        private void Form_Thong_Tin_Laptop_Load(object sender, EventArgs e)
        {
           Hienthi();
            DataTable dt_hang = busHang.thong_tin_HANG();
            DataTable dt_mau = busMau.thong_tin_mau_sac();
            DataTable dt_loai = busLoai.thong_tin_LOAI();
            cbotenhang.Items.Clear();
            cbomahang.Items.Clear();
            cbotenmau.Items.Clear();
            cbomamau.Items.Clear();
            cbotenloai.Items.Clear();
            cbomaloai.Items.Clear();
            foreach (DataRow r in dt_hang.Rows)
            {
                cbotenhang.Items.Add(r["ten_hang"].ToString());
                cbomahang.Items.Add(r["ma_hang"].ToString());
            }
            foreach (DataRow r1 in dt_mau.Rows)
            {
                cbotenmau.Items.Add(r1["ten_mau"].ToString());
                cbomamau.Items.Add(r1["ma_mau"].ToString());
            }
            foreach (DataRow r2 in dt_loai.Rows)
            {
                cbotenloai.Items.Add(r2["ten_loai"].ToString());
                cbomaloai.Items.Add(r2["ma_loai"].ToString());
            }
            // Them thong tin vao combobox

     
        }
       
        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (kiem_tra_nhap(true))
            {
                string chatlieu = "";
                if (ckb_kimloai.Checked)
                {
                    chatlieu += "Kim loại,";
                }
                if (ckb_magie.Checked)
                {
                    chatlieu += "Magie,";
                }
                if (ckb_nhom.Checked)
                {
                    chatlieu += "Nhôm,";
                }
                if (ckb_nhua.Checked)
                {
                    chatlieu += "Nhựa,";
                }
                int gia = Convert.ToInt32(txtgia.Text);
                string bo_nho = "";
                if (rdo120.Checked)
                {
                    bo_nho = "120GB";
                }
                else
                {
                    if (rdo256.Checked)
                    {
                        bo_nho = "256GB";
                    }
                    else
                    {
                        if (rdo512.Checked)
                        {
                            bo_nho = "512GB";
                        }
                        else
                        {
                            if (rdo1tb.Checked)
                            {
                                bo_nho = "1TB";
                            }
                        }
                    }
                }
                string ma_loai = cbomaloai.Items[cbotenloai.SelectedIndex].ToString();
                string ma_mau = cbomamau.Items[cbotenmau.SelectedIndex].ToString();
                string ma_hang = cbomahang.Items[cbotenhang.SelectedIndex].ToString();

                DTO_Thong_Tin_Laptop thong_tin = new DTO_Thong_Tin_Laptop(txtma.Text, txtten.Text, gia, chatlieu, txtram.Text, txtcpu.Text, txtcard.Text, bo_nho, ma_loai,ma_mau,ma_hang,txtFile.Text);

                if (busThongTinLaptop.them_thong_tin_laptop(thong_tin))
                {
                    lb_thongbao_1.Text  = "Thêm thành công";
                    dgvdanhsach.DataSource = busThongTinLaptop.thong_tin_laptop();
                }
            }
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            if (kiem_tra_nhap(true))
            {
                string chatlieu = "";
                if (ckb_kimloai.Checked)
                {
                    chatlieu += "Kim loại,";
                }
                if (ckb_magie.Checked)
                {
                    chatlieu += "Magie,";
                }
                if (ckb_nhom.Checked)
                {
                    chatlieu += "Nhôm,";
                }
                if (ckb_nhua.Checked)
                {
                    chatlieu += "Nhựa,";
                }
                int gia = Convert.ToInt32(txtgia.Text);
                int can_nang = Convert.ToInt32(txtram.Text);
                string bo_nho = "";
                if (rdo120.Checked)
                {
                    bo_nho = "120GB";
                }
                else
                {
                    if (rdo256.Checked)
                    {
                        bo_nho = "256GB";
                    }
                    else
                    {
                        if (rdo512.Checked)
                        {
                            bo_nho = "512GB";
                        }
                        else
                        {
                            if (rdo1tb.Checked)
                            {
                                bo_nho = "1TB";
                            }
                        }
                    }
                }
                string ma_loai = cbomaloai.Items[cbotenloai.SelectedIndex].ToString();
                string ma_mau = cbomamau.Items[cbotenmau.SelectedIndex].ToString();
                string ma_hang = cbomahang.Items[cbotenhang.SelectedIndex].ToString();

                DTO_Thong_Tin_Laptop thong_tin = new DTO_Thong_Tin_Laptop(txtma.Text, txtten.Text, gia, chatlieu, txtram.Text, txtcpu.Text, txtcard.Text, bo_nho, ma_loai, ma_mau, ma_hang, txtFile.Text);

                if (busThongTinLaptop.sua_thong_tin_laptop(thong_tin))
                {
                    lb_thongbao_1.Text = "Sửa thành công";
                    dgvdanhsach.DataSource = busThongTinLaptop.thong_tin_laptop();
                }
            }

        }

        private void dgvdanhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = dgvdanhsach.CurrentCell.RowIndex;
            txtma.Text = dgvdanhsach.Rows[vitri].Cells[0].Value.ToString();
            txtten.Text = dgvdanhsach.Rows[vitri].Cells[1].Value.ToString();
            txtgia.Text = dgvdanhsach.Rows[vitri].Cells[2].Value.ToString();
            //Phan checkbox
            string str = null;
            string[] strArr = null;
            str = dgvdanhsach.Rows[vitri].Cells[3].Value.ToString();
            char[] splitchar = { ',' };
            strArr = str.Split(splitchar);
            ckb_kimloai.Checked = false;
            ckb_nhom.Checked = false;
            ckb_nhua.Checked = false;
            ckb_magie.Checked = false;
            for (int i = 0; i <= strArr.Length - 1; i++)
            {
                //MessageBox.Show(strArr[i]);
                if (strArr[i].ToString() == "Kim loại")
                {
                    ckb_kimloai.Checked = true;
                }
                if (strArr[i].ToString() == "Magie")
                {
                    ckb_magie.Checked = true;
                }
                if (strArr[i].ToString() == "Nhựa")
                {
                    ckb_nhua.Checked = true;
                }
                if (strArr[i].ToString() == "Nhôm")
                {
                    ckb_nhom.Checked = true;
                }
            }
            str = null;
      
            txtram.Text = dgvdanhsach.Rows[vitri].Cells[4].Value.ToString();
            txtcpu.Text = dgvdanhsach.Rows[vitri].Cells[5].Value.ToString();
            txtcard.Text = dgvdanhsach.Rows[vitri].Cells[6].Value.ToString();
            if(dgvdanhsach.Rows[vitri].Cells[7].Value.ToString() == "120GB")
            {
                rdo120.Checked = true;
            }
            else
            {
                if (dgvdanhsach.Rows[vitri].Cells[7].Value.ToString() == "256GB")
                {
                    rdo256.Checked = true;
                }
                else
                {
                    if (dgvdanhsach.Rows[vitri].Cells[7].Value.ToString() == "512GB")
                    {
                        rdo512.Checked = true;
                    }
                    else
                    {
                        if (dgvdanhsach.Rows[vitri].Cells[7].Value.ToString() == "1TB")
                        {
                            rdo1tb.Checked = true;
                        }
                    }
                }
            }

            for (int i = 0; i < cbomaloai.Items.Count; i++)
            {
                if (cbomaloai.Items[i].ToString() == dgvdanhsach.Rows[vitri].Cells[8].Value.ToString())
                {
                    cbotenloai.SelectedIndex = i;
                }
            }

            for (int i = 0; i < cbomamau.Items.Count; i++)
            {
                if (cbomamau.Items[i].ToString() == dgvdanhsach.Rows[vitri].Cells[9].Value.ToString())
                {
                    cbotenmau.SelectedIndex = i;
                }
            }

            for (int i = 0; i < cbomahang.Items.Count; i++)
            {
                if (cbomahang.Items[i].ToString() == dgvdanhsach.Rows[vitri].Cells[10].Value.ToString())
                {
                    cbotenhang.SelectedIndex = i;
                }
            }
            txtFile.Text = dgvdanhsach.Rows[vitri].Cells[11].Value.ToString();
            if (txtFile.Text != "")
            {
                string path = Path.Combine(dgvdanhsach.Rows[vitri].Cells[11].Value.ToString());
                box_hinhanh.Image = Image.FromFile(path);
                box_hinhanh.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }
        private bool kiem_tra_nhap(bool check)
        {
            string thong_bao = "Vui lòng nhập: ";
            bool kiem_tra = false;
          
            if(txtma.Text.Trim().Length == 0)
            {
                thong_bao += " - Mã ";
                kiem_tra = true;
            }
            if (txtten.Text.Trim().Length == 0)
            {
                thong_bao += " - Tên laptop ";
                kiem_tra = true;
            }
            
            if (txtgia.Text.Trim().Length == 0)
            {
                thong_bao += " - Giá ";
                kiem_tra = true;
            }
            if (txtcpu.Text.Trim().Length == 0)
            {
                thong_bao += " - Cpu ";
                kiem_tra = true;
            }
            if (txtcard.Text.Trim().Length == 0)
            {
                thong_bao += " - Card ";
                kiem_tra = true;
            }
            if (txtram.Text.Trim().Length == 0)
            {
                thong_bao += " - Ram ";
                kiem_tra = true;
            }

            if (rdo120.Checked || rdo256.Checked || rdo512.Checked || rdo1tb.Checked)
            {
                
            }
            else
            {
                thong_bao += " - Bộ nhớ ";
                kiem_tra = true;
            }
            if(ckb_kimloai.Checked || ckb_magie.Checked || ckb_nhom.Checked || ckb_nhua.Checked)
            {

            }
            else
            {
                thong_bao += " - Chất liệu ";
            }
            if (cbotenloai.Text.Trim().Length == 0)
            {
                thong_bao += " - Loại ";
                kiem_tra = true;
            }
            if (cbotenmau.Text.Trim().Length == 0)
            {
                thong_bao += " - Màu ";
                kiem_tra = true;
            }
            if (cbotenhang.Text.Trim().Length == 0)
            {
                thong_bao += " - Hãng ";
                kiem_tra = true;
            }
            if (txtFile.Text.Trim().Length == 0)
            {
                thong_bao += " - Ảnh ";
                kiem_tra = true;
            }
            if (kiem_tra == true)
            {
                MessageBox.Show(thong_bao, "Lỗi nhập dữ liệu", MessageBoxButtons.OK);
                return false;
            }
            else
            {
                return true;
            }
        }
        byte[] ConvertImg(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        public Image ConvertByteImage(byte[] data)
        {
            using(MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*" })
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    //hien thi anh trong box
                    box_hinhanh.Image = Image.FromFile(ofd.FileName);
                    // Set duong dan
                    txtFile.Text = ofd.FileName;
                }
            }
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            if(txtma.Text != "")
            {
                string ma = txtma.Text;
                if (busThongTinLaptop.xoa_thong_tin_laptop(ma))
                {
                    lb_thongbao_1.Text = "Xoá thành công";
                    dgvdanhsach.DataSource = busThongTinLaptop.thong_tin_laptop();
                }
            }
        }
        private void btnxem_Click(object sender, EventArgs e)
        {
            Form_Xem_Thong_Tin_Laptop form_xem = new Form_Xem_Thong_Tin_Laptop();
            Form_Xem_Thong_Tin_Laptop.ma_laptop = txtma.Text;
            form_xem.ShowDialog();
        }
        private void btn_resert_Click(object sender, EventArgs e)
        {
            txtcard.Clear();
            txtcpu.Clear();
            txtFile.Clear();
            txtgia.Clear();
            txtma.Clear();
            txtram.Clear();
            txtten.Clear();
            box_hinhanh.Image = null;
            ckb_kimloai.Checked = false;
            ckb_magie.Checked = false;
            ckb_nhom.Checked = false;
            ckb_nhua.Checked = false;
            rdo120.Checked = true;
        }

        private void txt_tukhoa_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = busThongTinLaptop.thong_tin_laptop();
            DataRow[] row = dt.Select("ma_laptop like '%" + txt_tukhoa.Text + "%'");
            if (row.Length > 0)
            {
                DataTable dt1 = row.CopyToDataTable();
                dgvdanhsach.DataSource = dt1;
            }
            else
            {

            }
        }
    }
}
