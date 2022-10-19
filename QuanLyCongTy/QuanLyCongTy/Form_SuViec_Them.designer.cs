
namespace QuanLyCongTy
{
    partial class Form_SuViec_Them
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.lbLoai = new System.Windows.Forms.Label();
            this.txtKqToiDanhHanhVi = new System.Windows.Forms.TextBox();
            this.Người = new System.Windows.Forms.Label();
            this.txtKqNguoi = new System.Windows.Forms.TextBox();
            this.lbNguoi = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtHqKhac = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHqVatLieu = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtHqPhuongTien = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtHqNguoi = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnTaiLen = new System.Windows.Forms.Button();
            this.txtLinkFile = new System.Windows.Forms.TextBox();
            this.btnChonFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTomTat = new System.Windows.Forms.TextBox();
            this.cboCongTy = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpThoiGianKT = new System.Windows.Forms.DateTimePicker();
            this.dtpThoiGianBD = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÊM THÔNG TIN SỰ VIỆC";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboLoai);
            this.groupBox1.Controls.Add(this.lbLoai);
            this.groupBox1.Controls.Add(this.txtKqToiDanhHanhVi);
            this.groupBox1.Controls.Add(this.Người);
            this.groupBox1.Controls.Add(this.txtKqNguoi);
            this.groupBox1.Controls.Add(this.lbNguoi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 522);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1070, 140);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kết quả xử lý";
            // 
            // cboLoai
            // 
            this.cboLoai.FormattingEnabled = true;
            this.cboLoai.Location = new System.Drawing.Point(213, 39);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(306, 28);
            this.cboLoai.TabIndex = 0;
            this.cboLoai.SelectedIndexChanged += new System.EventHandler(this.cboLoai_SelectedIndexChanged);
            // 
            // lbLoai
            // 
            this.lbLoai.AutoSize = true;
            this.lbLoai.Location = new System.Drawing.Point(39, 93);
            this.lbLoai.Name = "lbLoai";
            this.lbLoai.Size = new System.Drawing.Size(96, 20);
            this.lbLoai.TabIndex = 5;
            this.lbLoai.Text = "Tội danh (*)";
            // 
            // txtKqToiDanhHanhVi
            // 
            this.txtKqToiDanhHanhVi.Location = new System.Drawing.Point(213, 90);
            this.txtKqToiDanhHanhVi.Name = "txtKqToiDanhHanhVi";
            this.txtKqToiDanhHanhVi.Size = new System.Drawing.Size(306, 27);
            this.txtKqToiDanhHanhVi.TabIndex = 1;
            // 
            // Người
            // 
            this.Người.AutoSize = true;
            this.Người.Location = new System.Drawing.Point(562, 93);
            this.Người.Name = "Người";
            this.Người.Size = new System.Drawing.Size(75, 20);
            this.Người.TabIndex = 3;
            this.Người.Text = "Người (*)";
            // 
            // txtKqNguoi
            // 
            this.txtKqNguoi.Location = new System.Drawing.Point(666, 90);
            this.txtKqNguoi.Name = "txtKqNguoi";
            this.txtKqNguoi.Size = new System.Drawing.Size(378, 27);
            this.txtKqNguoi.TabIndex = 2;
            // 
            // lbNguoi
            // 
            this.lbNguoi.AutoSize = true;
            this.lbNguoi.Location = new System.Drawing.Point(39, 47);
            this.lbNguoi.Name = "lbNguoi";
            this.lbNguoi.Size = new System.Drawing.Size(64, 20);
            this.lbNguoi.TabIndex = 1;
            this.lbNguoi.Text = "Loại (*)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtHqKhac);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtHqVatLieu);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtHqPhuongTien);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtHqNguoi);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(34, 321);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1070, 195);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hậu quả thiệt hại";
            // 
            // txtHqKhac
            // 
            this.txtHqKhac.Location = new System.Drawing.Point(666, 29);
            this.txtHqKhac.Multiline = true;
            this.txtHqKhac.Name = "txtHqKhac";
            this.txtHqKhac.Size = new System.Drawing.Size(378, 132);
            this.txtHqKhac.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(567, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Khác";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Nguyên vật liệu (*)";
            // 
            // txtHqVatLieu
            // 
            this.txtHqVatLieu.Location = new System.Drawing.Point(213, 90);
            this.txtHqVatLieu.Name = "txtHqVatLieu";
            this.txtHqVatLieu.Size = new System.Drawing.Size(306, 27);
            this.txtHqVatLieu.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "Phương tiện (*)";
            // 
            // txtHqPhuongTien
            // 
            this.txtHqPhuongTien.Location = new System.Drawing.Point(213, 140);
            this.txtHqPhuongTien.Name = "txtHqPhuongTien";
            this.txtHqPhuongTien.Size = new System.Drawing.Size(306, 27);
            this.txtHqPhuongTien.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Người (*)";
            // 
            // txtHqNguoi
            // 
            this.txtHqNguoi.Location = new System.Drawing.Point(213, 36);
            this.txtHqNguoi.Name = "txtHqNguoi";
            this.txtHqNguoi.Size = new System.Drawing.Size(306, 27);
            this.txtHqNguoi.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(966, 786);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(112, 40);
            this.btnThoat.TabIndex = 27;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapLai.Location = new System.Drawing.Point(826, 786);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(112, 40);
            this.btnNhapLai.TabIndex = 26;
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.UseVisualStyleBackColor = true;
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(684, 786);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 40);
            this.btnThem.TabIndex = 25;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.btnTaiLen);
            this.groupBox3.Controls.Add(this.txtLinkFile);
            this.groupBox3.Controls.Add(this.btnChonFile);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(34, 668);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1070, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nhập dữ liệu từ excel";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(39, 45);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 20);
            this.label15.TabIndex = 9;
            this.label15.Text = "Đường dẫn";
            // 
            // btnTaiLen
            // 
            this.btnTaiLen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiLen.Location = new System.Drawing.Point(932, 36);
            this.btnTaiLen.Name = "btnTaiLen";
            this.btnTaiLen.Size = new System.Drawing.Size(107, 38);
            this.btnTaiLen.TabIndex = 2;
            this.btnTaiLen.Text = "Tải lên";
            this.btnTaiLen.UseVisualStyleBackColor = true;
            this.btnTaiLen.Click += new System.EventHandler(this.btnTaiLen_Click);
            // 
            // txtLinkFile
            // 
            this.txtLinkFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLinkFile.Location = new System.Drawing.Point(212, 42);
            this.txtLinkFile.Name = "txtLinkFile";
            this.txtLinkFile.Size = new System.Drawing.Size(574, 27);
            this.txtLinkFile.TabIndex = 0;
            // 
            // btnChonFile
            // 
            this.btnChonFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonFile.Location = new System.Drawing.Point(825, 36);
            this.btnChonFile.Name = "btnChonFile";
            this.btnChonFile.Size = new System.Drawing.Size(101, 38);
            this.btnChonFile.TabIndex = 1;
            this.btnChonFile.Text = "Chọn file";
            this.btnChonFile.UseVisualStyleBackColor = true;
            this.btnChonFile.Click += new System.EventHandler(this.btnChonFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(462, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "THÊM THÔNG TIN SỰ VIỆC";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(73, 796);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(264, 20);
            this.label16.TabIndex = 67;
            this.label16.Text = "Chú thích: (*) là thông tin bắt buộc";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtpThoiGianBD);
            this.groupBox4.Controls.Add(this.dtpThoiGianKT);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.cboCongTy);
            this.groupBox4.Controls.Add(this.txtTomTat);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(34, 90);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1070, 225);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin sự việc";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tóm tắt vụ việc";
            // 
            // txtTomTat
            // 
            this.txtTomTat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTomTat.Location = new System.Drawing.Point(213, 36);
            this.txtTomTat.Multiline = true;
            this.txtTomTat.Name = "txtTomTat";
            this.txtTomTat.Size = new System.Drawing.Size(831, 77);
            this.txtTomTat.TabIndex = 0;
            // 
            // cboCongTy
            // 
            this.cboCongTy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCongTy.FormattingEnabled = true;
            this.cboCongTy.Location = new System.Drawing.Point(666, 135);
            this.cboCongTy.Name = "cboCongTy";
            this.cboCongTy.Size = new System.Drawing.Size(378, 28);
            this.cboCongTy.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 65;
            this.label6.Text = "Từ ngày: (*)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(561, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Công ty (*)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(27, 183);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 20);
            this.label12.TabIndex = 66;
            this.label12.Text = "Đến ngày: (*)";
            // 
            // dtpThoiGianKT
            // 
            this.dtpThoiGianKT.CustomFormat = "dd/MM/yyyy";
            this.dtpThoiGianKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThoiGianKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiGianKT.Location = new System.Drawing.Point(213, 183);
            this.dtpThoiGianKT.Name = "dtpThoiGianKT";
            this.dtpThoiGianKT.Size = new System.Drawing.Size(194, 27);
            this.dtpThoiGianKT.TabIndex = 2;
            // 
            // dtpThoiGianBD
            // 
            this.dtpThoiGianBD.CustomFormat = "dd/MM/yyyy";
            this.dtpThoiGianBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThoiGianBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiGianBD.Location = new System.Drawing.Point(213, 137);
            this.dtpThoiGianBD.Name = "dtpThoiGianBD";
            this.dtpThoiGianBD.Size = new System.Drawing.Size(194, 28);
            this.dtpThoiGianBD.TabIndex = 1;
            // 
            // Form_SuViec_Them
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1223, 849);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnNhapLai);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form_SuViec_Them";
            this.Text = "Thêm sự việc";
            this.Load += new System.EventHandler(this.Form_SuViec_Them_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbLoai;
        private System.Windows.Forms.TextBox txtKqToiDanhHanhVi;
        private System.Windows.Forms.Label Người;
        private System.Windows.Forms.TextBox txtKqNguoi;
        private System.Windows.Forms.Label lbNguoi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtHqKhac;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtHqVatLieu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtHqPhuongTien;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtHqNguoi;
        private System.Windows.Forms.ComboBox cboLoai;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTaiLen;
        private System.Windows.Forms.TextBox txtLinkFile;
        private System.Windows.Forms.Button btnChonFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dtpThoiGianBD;
        private System.Windows.Forms.DateTimePicker dtpThoiGianKT;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboCongTy;
        private System.Windows.Forms.TextBox txtTomTat;
        private System.Windows.Forms.Label label7;
    }
}