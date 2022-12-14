
namespace Form_Ban_Laptop
{
    partial class Form_Hoa_Don_Ban
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
            this.btn_resert = new System.Windows.Forms.Button();
            this.lb_thongbao_1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lb_thongbao = new System.Windows.Forms.Label();
            this.dgv_hoa_don = new System.Windows.Forms.DataGridView();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btn_chon = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtsodt = new System.Windows.Forms.TextBox();
            this.txt_tennv = new System.Windows.Forms.TextBox();
            this.cbomanv = new System.Windows.Forms.ComboBox();
            this.dtpngayban = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttenkhach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_mahoadon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_mahoadon = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoa_don)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_resert
            // 
            this.btn_resert.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_resert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resert.Location = new System.Drawing.Point(697, 412);
            this.btn_resert.Name = "btn_resert";
            this.btn_resert.Size = new System.Drawing.Size(129, 39);
            this.btn_resert.TabIndex = 60;
            this.btn_resert.Text = "Làm mới";
            this.btn_resert.UseVisualStyleBackColor = false;
            this.btn_resert.Click += new System.EventHandler(this.btn_resert_Click);
            // 
            // lb_thongbao_1
            // 
            this.lb_thongbao_1.AutoSize = true;
            this.lb_thongbao_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thongbao_1.Location = new System.Drawing.Point(322, 468);
            this.lb_thongbao_1.Name = "lb_thongbao_1";
            this.lb_thongbao_1.Size = new System.Drawing.Size(14, 20);
            this.lb_thongbao_1.TabIndex = 59;
            this.lb_thongbao_1.Text = ":";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(218, 468);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 20);
            this.label14.TabIndex = 58;
            this.label14.Text = "Thông báo";
            // 
            // lb_thongbao
            // 
            this.lb_thongbao.AutoSize = true;
            this.lb_thongbao.Location = new System.Drawing.Point(110, 445);
            this.lb_thongbao.Name = "lb_thongbao";
            this.lb_thongbao.Size = new System.Drawing.Size(0, 17);
            this.lb_thongbao.TabIndex = 57;
            // 
            // dgv_hoa_don
            // 
            this.dgv_hoa_don.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_hoa_don.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hoa_don.Location = new System.Drawing.Point(10, 503);
            this.dgv_hoa_don.Name = "dgv_hoa_don";
            this.dgv_hoa_don.RowHeadersWidth = 51;
            this.dgv_hoa_don.RowTemplate.Height = 24;
            this.dgv_hoa_don.Size = new System.Drawing.Size(866, 188);
            this.dgv_hoa_don.TabIndex = 56;
            this.dgv_hoa_don.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hoa_don_CellClick);
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Location = new System.Drawing.Point(862, 412);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(111, 39);
            this.btnthoat.TabIndex = 55;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btn_chon
            // 
            this.btn_chon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_chon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chon.Location = new System.Drawing.Point(205, 39);
            this.btn_chon.Name = "btn_chon";
            this.btn_chon.Size = new System.Drawing.Size(111, 39);
            this.btn_chon.TabIndex = 54;
            this.btn_chon.Text = "Chọn";
            this.btn_chon.UseVisualStyleBackColor = false;
            this.btn_chon.Click += new System.EventHandler(this.btn_chon_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.LightBlue;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(550, 412);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(111, 39);
            this.btnxoa.TabIndex = 53;
            this.btnxoa.Text = "Xoá";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(404, 412);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(111, 39);
            this.btnsua.TabIndex = 52;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.AliceBlue;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(250, 412);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(128, 39);
            this.btnthem.TabIndex = 51;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timkiem.Location = new System.Drawing.Point(423, 357);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(467, 27);
            this.txt_timkiem.TabIndex = 50;
            this.txt_timkiem.TextChanged += new System.EventHandler(this.txt_timkiem_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(236, 364);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 20);
            this.label13.TabIndex = 49;
            this.label13.Text = "Tìm mã hoá đơn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtsodt);
            this.groupBox1.Controls.Add(this.txt_tennv);
            this.groupBox1.Controls.Add(this.cbomanv);
            this.groupBox1.Controls.Add(this.dtpngayban);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtdiachi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txttenkhach);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_mahoadon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1245, 212);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // txtsodt
            // 
            this.txtsodt.Location = new System.Drawing.Point(196, 167);
            this.txtsodt.MaxLength = 50;
            this.txtsodt.Name = "txtsodt";
            this.txtsodt.Size = new System.Drawing.Size(199, 27);
            this.txtsodt.TabIndex = 28;
            this.txtsodt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsodt_KeyPress);
            // 
            // txt_tennv
            // 
            this.txt_tennv.Enabled = false;
            this.txt_tennv.Location = new System.Drawing.Point(546, 80);
            this.txt_tennv.Name = "txt_tennv";
            this.txt_tennv.Size = new System.Drawing.Size(191, 27);
            this.txt_tennv.TabIndex = 27;
            // 
            // cbomanv
            // 
            this.cbomanv.FormattingEnabled = true;
            this.cbomanv.Location = new System.Drawing.Point(546, 46);
            this.cbomanv.Name = "cbomanv";
            this.cbomanv.Size = new System.Drawing.Size(191, 28);
            this.cbomanv.TabIndex = 25;
            this.cbomanv.SelectedIndexChanged += new System.EventHandler(this.cbomanv_SelectedIndexChanged);
            // 
            // dtpngayban
            // 
            this.dtpngayban.Location = new System.Drawing.Point(897, 99);
            this.dtpngayban.Name = "dtpngayban";
            this.dtpngayban.Size = new System.Drawing.Size(318, 27);
            this.dtpngayban.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(420, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Mã nhân viên";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(761, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Ngày bán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Số điện thoại";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(897, 42);
            this.txtdiachi.MaxLength = 50;
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(192, 27);
            this.txtdiachi.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(761, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Địa chỉ";
            // 
            // txttenkhach
            // 
            this.txttenkhach.Location = new System.Drawing.Point(196, 102);
            this.txttenkhach.MaxLength = 50;
            this.txttenkhach.Name = "txttenkhach";
            this.txttenkhach.Size = new System.Drawing.Size(199, 27);
            this.txttenkhach.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tên khách hàng";
            // 
            // txt_mahoadon
            // 
            this.txt_mahoadon.Location = new System.Drawing.Point(196, 43);
            this.txt_mahoadon.MaxLength = 50;
            this.txt_mahoadon.Name = "txt_mahoadon";
            this.txt_mahoadon.Size = new System.Drawing.Size(199, 27);
            this.txt_mahoadon.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hoá đơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(438, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 39);
            this.label1.TabIndex = 63;
            this.label1.Text = "HOÁ ĐƠN BÁN HÀNG ";
            // 
            // cbo_mahoadon
            // 
            this.cbo_mahoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_mahoadon.FormattingEnabled = true;
            this.cbo_mahoadon.ItemHeight = 20;
            this.cbo_mahoadon.Location = new System.Drawing.Point(6, 39);
            this.cbo_mahoadon.Name = "cbo_mahoadon";
            this.cbo_mahoadon.Size = new System.Drawing.Size(180, 28);
            this.cbo_mahoadon.TabIndex = 64;
            this.cbo_mahoadon.SelectedIndexChanged += new System.EventHandler(this.cbo_mahoadon_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbo_mahoadon);
            this.groupBox2.Controls.Add(this.btn_chon);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(896, 503);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 138);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thêm sản phẩm";
            // 
            // Form_Hoa_Don_Ban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_resert);
            this.Controls.Add(this.lb_thongbao_1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lb_thongbao);
            this.Controls.Add(this.dgv_hoa_don);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.label13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Hoa_Don_Ban";
            this.Text = "Form_Hoa_Don_Ban";
            this.Load += new System.EventHandler(this.Form_Hoa_Don_Ban_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoa_don)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_resert;
        private System.Windows.Forms.Label lb_thongbao_1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lb_thongbao;
        private System.Windows.Forms.DataGridView dgv_hoa_don;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btn_chon;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_tennv;
        private System.Windows.Forms.ComboBox cbomanv;
        private System.Windows.Forms.DateTimePicker dtpngayban;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttenkhach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_mahoadon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsodt;
        private System.Windows.Forms.ComboBox cbo_mahoadon;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}