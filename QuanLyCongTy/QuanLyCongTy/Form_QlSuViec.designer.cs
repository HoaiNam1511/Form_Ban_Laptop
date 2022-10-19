
namespace QuanLyCongTy
{
    partial class Form_QlSuViec
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_QlSuViec));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSuViec = new System.Windows.Forms.DataGridView();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lbThongTinSuViec = new System.Windows.Forms.Label();
            this.lbThoiGianBD = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbThoiGianKT = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbHqKhac = new System.Windows.Forms.Label();
            this.lbHqNguyenVatLieu = new System.Windows.Forms.Label();
            this.lbHqPhuongTien = new System.Windows.Forms.Label();
            this.lbHqNguoi = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbKqNguoi = new System.Windows.Forms.Label();
            this.lbKqTDanhHVi = new System.Windows.Forms.Label();
            this.lbKqNhom = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuViec)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(693, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ SỰ VIỆC";
            // 
            // dgvSuViec
            // 
            this.dgvSuViec.AllowUserToAddRows = false;
            this.dgvSuViec.BackgroundColor = System.Drawing.Color.White;
            this.dgvSuViec.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(235)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSuViec.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSuViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuViec.EnableHeadersVisualStyles = false;
            this.dgvSuViec.Location = new System.Drawing.Point(40, 186);
            this.dgvSuViec.Name = "dgvSuViec";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSuViec.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSuViec.RowHeadersWidth = 51;
            this.dgvSuViec.RowTemplate.Height = 24;
            this.dgvSuViec.Size = new System.Drawing.Size(1006, 650);
            this.dgvSuViec.TabIndex = 25;
            this.dgvSuViec.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSuViec_CellClick);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(115, 38);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(582, 27);
            this.txtTimKiem.TabIndex = 26;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // lbThongTinSuViec
            // 
            this.lbThongTinSuViec.AutoSize = true;
            this.lbThongTinSuViec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongTinSuViec.Location = new System.Drawing.Point(15, 30);
            this.lbThongTinSuViec.MaximumSize = new System.Drawing.Size(565, 300);
            this.lbThongTinSuViec.Name = "lbThongTinSuViec";
            this.lbThongTinSuViec.Size = new System.Drawing.Size(141, 20);
            this.lbThongTinSuViec.TabIndex = 28;
            this.lbThongTinSuViec.Text = "Thông tin sự việc:";
            // 
            // lbThoiGianBD
            // 
            this.lbThoiGianBD.AutoSize = true;
            this.lbThoiGianBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThoiGianBD.Location = new System.Drawing.Point(18, 153);
            this.lbThoiGianBD.MaximumSize = new System.Drawing.Size(565, 300);
            this.lbThoiGianBD.Name = "lbThoiGianBD";
            this.lbThoiGianBD.Size = new System.Drawing.Size(101, 20);
            this.lbThoiGianBD.TabIndex = 29;
            this.lbThoiGianBD.Text = "Thời gian từ:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbThoiGianKT);
            this.groupBox1.Controls.Add(this.lbThongTinSuViec);
            this.groupBox1.Controls.Add(this.lbThoiGianBD);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1067, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 252);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sự việc";
            // 
            // lbThoiGianKT
            // 
            this.lbThoiGianKT.AutoSize = true;
            this.lbThoiGianKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThoiGianKT.Location = new System.Drawing.Point(18, 197);
            this.lbThoiGianKT.MaximumSize = new System.Drawing.Size(565, 300);
            this.lbThoiGianKT.Name = "lbThoiGianKT";
            this.lbThoiGianKT.Size = new System.Drawing.Size(114, 20);
            this.lbThoiGianKT.TabIndex = 30;
            this.lbThoiGianKT.Text = "Thời gian đến:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbHqKhac);
            this.groupBox2.Controls.Add(this.lbHqNguyenVatLieu);
            this.groupBox2.Controls.Add(this.lbHqPhuongTien);
            this.groupBox2.Controls.Add(this.lbHqNguoi);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1067, 356);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(580, 287);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hậu quả";
            // 
            // lbHqKhac
            // 
            this.lbHqKhac.AutoSize = true;
            this.lbHqKhac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHqKhac.Location = new System.Drawing.Point(15, 211);
            this.lbHqKhac.MaximumSize = new System.Drawing.Size(565, 300);
            this.lbHqKhac.Name = "lbHqKhac";
            this.lbHqKhac.Size = new System.Drawing.Size(52, 20);
            this.lbHqKhac.TabIndex = 33;
            this.lbHqKhac.Text = "Khác:";
            // 
            // lbHqNguyenVatLieu
            // 
            this.lbHqNguyenVatLieu.AutoSize = true;
            this.lbHqNguyenVatLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHqNguyenVatLieu.Location = new System.Drawing.Point(15, 153);
            this.lbHqNguyenVatLieu.MaximumSize = new System.Drawing.Size(565, 300);
            this.lbHqNguyenVatLieu.Name = "lbHqNguyenVatLieu";
            this.lbHqNguyenVatLieu.Size = new System.Drawing.Size(70, 20);
            this.lbHqNguyenVatLieu.TabIndex = 32;
            this.lbHqNguyenVatLieu.Text = "Vật liệu:";
            // 
            // lbHqPhuongTien
            // 
            this.lbHqPhuongTien.AutoSize = true;
            this.lbHqPhuongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHqPhuongTien.Location = new System.Drawing.Point(18, 97);
            this.lbHqPhuongTien.MaximumSize = new System.Drawing.Size(565, 300);
            this.lbHqPhuongTien.Name = "lbHqPhuongTien";
            this.lbHqPhuongTien.Size = new System.Drawing.Size(102, 20);
            this.lbHqPhuongTien.TabIndex = 31;
            this.lbHqPhuongTien.Text = "Phương tiện:";
            // 
            // lbHqNguoi
            // 
            this.lbHqNguoi.AutoSize = true;
            this.lbHqNguoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHqNguoi.Location = new System.Drawing.Point(15, 42);
            this.lbHqNguoi.MaximumSize = new System.Drawing.Size(565, 300);
            this.lbHqNguoi.Name = "lbHqNguoi";
            this.lbHqNguoi.Size = new System.Drawing.Size(57, 20);
            this.lbHqNguoi.TabIndex = 30;
            this.lbHqNguoi.Text = "Người:";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(183, 23);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(84, 63);
            this.btnXoa.TabIndex = 62;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Transparent;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(93, 23);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(84, 63);
            this.btnSua.TabIndex = 61;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(3, 23);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(84, 63);
            this.btnThem.TabIndex = 60;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtTimKiem);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(321, 86);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(725, 96);
            this.groupBox4.TabIndex = 63;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm kiếm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 45);
            this.label2.MaximumSize = new System.Drawing.Size(320, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Từ khóa";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnSua);
            this.groupBox5.Controls.Add(this.btnXoa);
            this.groupBox5.Controls.Add(this.btnThem);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(41, 86);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(274, 96);
            this.groupBox5.TabIndex = 64;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chức năng";
            // 
            // lbKqNguoi
            // 
            this.lbKqNguoi.AutoSize = true;
            this.lbKqNguoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKqNguoi.Location = new System.Drawing.Point(18, 35);
            this.lbKqNguoi.MaximumSize = new System.Drawing.Size(565, 300);
            this.lbKqNguoi.Name = "lbKqNguoi";
            this.lbKqNguoi.Size = new System.Drawing.Size(57, 20);
            this.lbKqNguoi.TabIndex = 30;
            this.lbKqNguoi.Text = "Người:";
            // 
            // lbKqTDanhHVi
            // 
            this.lbKqTDanhHVi.AutoSize = true;
            this.lbKqTDanhHVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKqTDanhHVi.Location = new System.Drawing.Point(15, 84);
            this.lbKqTDanhHVi.MaximumSize = new System.Drawing.Size(565, 300);
            this.lbKqTDanhHVi.Name = "lbKqTDanhHVi";
            this.lbKqTDanhHVi.Size = new System.Drawing.Size(78, 20);
            this.lbKqTDanhHVi.TabIndex = 31;
            this.lbKqTDanhHVi.Text = "Tội danh:";
            // 
            // lbKqNhom
            // 
            this.lbKqNhom.AutoSize = true;
            this.lbKqNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKqNhom.Location = new System.Drawing.Point(18, 131);
            this.lbKqNhom.MaximumSize = new System.Drawing.Size(565, 300);
            this.lbKqNhom.Name = "lbKqNhom";
            this.lbKqNhom.Size = new System.Drawing.Size(58, 20);
            this.lbKqNhom.TabIndex = 33;
            this.lbKqNhom.Text = "Nhóm:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbKqNhom);
            this.groupBox3.Controls.Add(this.lbKqTDanhHVi);
            this.groupBox3.Controls.Add(this.lbKqNguoi);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(1067, 671);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(580, 165);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kết quả";
            // 
            // Form_QlSuViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1708, 887);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvSuViec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox5);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_QlSuViec";
            this.Text = "Form_QlSuViec";
            this.Load += new System.EventHandler(this.Form_QlSuViec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuViec)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSuViec;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lbThongTinSuViec;
        private System.Windows.Forms.Label lbThoiGianBD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbHqKhac;
        private System.Windows.Forms.Label lbHqNguyenVatLieu;
        private System.Windows.Forms.Label lbHqPhuongTien;
        private System.Windows.Forms.Label lbHqNguoi;
        private System.Windows.Forms.Label lbThoiGianKT;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbKqNguoi;
        private System.Windows.Forms.Label lbKqTDanhHVi;
        private System.Windows.Forms.Label lbKqNhom;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}