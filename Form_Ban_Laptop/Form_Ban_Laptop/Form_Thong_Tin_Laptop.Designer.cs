
namespace Form_Ban_Laptop
{
    partial class Form_Thong_Tin_Laptop
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
            this.lb_thongbao = new System.Windows.Forms.Label();
            this.dgvdanhsach = new System.Windows.Forms.DataGridView();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtma = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.txtram = new System.Windows.Forms.TextBox();
            this.rdo120 = new System.Windows.Forms.RadioButton();
            this.rdo256 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.box_hinhanh = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ckb_magie = new System.Windows.Forms.CheckBox();
            this.ckb_nhom = new System.Windows.Forms.CheckBox();
            this.ckb_nhua = new System.Windows.Forms.CheckBox();
            this.ckb_kimloai = new System.Windows.Forms.CheckBox();
            this.cbomaloai = new System.Windows.Forms.ComboBox();
            this.cbotenloai = new System.Windows.Forms.ComboBox();
            this.cbomamau = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbotenmau = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbomahang = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbotenhang = new System.Windows.Forms.ComboBox();
            this.txtcard = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdo1tb = new System.Windows.Forms.RadioButton();
            this.rdo512 = new System.Windows.Forms.RadioButton();
            this.txtcpu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lb_thongbao_1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_resert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsach)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box_hinhanh)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_thongbao
            // 
            this.lb_thongbao.AutoSize = true;
            this.lb_thongbao.Location = new System.Drawing.Point(183, 572);
            this.lb_thongbao.Name = "lb_thongbao";
            this.lb_thongbao.Size = new System.Drawing.Size(0, 17);
            this.lb_thongbao.TabIndex = 31;
            // 
            // dgvdanhsach
            // 
            this.dgvdanhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdanhsach.Location = new System.Drawing.Point(51, 627);
            this.dgvdanhsach.Name = "dgvdanhsach";
            this.dgvdanhsach.RowHeadersWidth = 51;
            this.dgvdanhsach.RowTemplate.Height = 24;
            this.dgvdanhsach.Size = new System.Drawing.Size(1287, 187);
            this.dgvdanhsach.TabIndex = 30;
            this.dgvdanhsach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdanhsach_CellClick);
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Location = new System.Drawing.Point(1040, 538);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(111, 39);
            this.btnthoat.TabIndex = 29;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnxem
            // 
            this.btnxem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnxem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxem.Location = new System.Drawing.Point(874, 538);
            this.btnxem.Name = "btnxem";
            this.btnxem.Size = new System.Drawing.Size(111, 39);
            this.btnxem.TabIndex = 28;
            this.btnxem.Text = "Xem";
            this.btnxem.UseVisualStyleBackColor = false;
            this.btnxem.Click += new System.EventHandler(this.btnxem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(541, 538);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(111, 39);
            this.btnxoa.TabIndex = 27;
            this.btnxoa.Text = "Xoá";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(383, 538);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(111, 39);
            this.btnsua.TabIndex = 26;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.SystemColors.Info;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(231, 538);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(111, 39);
            this.btnthem.TabIndex = 25;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(483, 488);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(467, 27);
            this.textBox4.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(296, 495);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Tìm kiếm nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(476, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 38);
            this.label1.TabIndex = 21;
            this.label1.Text = "BẢNG THÔNG TIN LAPTOP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã laptop";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên laptop";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giá bán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ram";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "SSD";
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(193, 49);
            this.txtma.MaxLength = 10;
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(236, 27);
            this.txtma.TabIndex = 6;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(193, 97);
            this.txtten.MaxLength = 25;
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(236, 27);
            this.txtten.TabIndex = 7;
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(193, 140);
            this.txtgia.MaxLength = 11;
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(236, 27);
            this.txtgia.TabIndex = 8;
            // 
            // txtram
            // 
            this.txtram.Location = new System.Drawing.Point(193, 294);
            this.txtram.MaxLength = 50;
            this.txtram.Name = "txtram";
            this.txtram.Size = new System.Drawing.Size(236, 27);
            this.txtram.TabIndex = 9;
            // 
            // rdo120
            // 
            this.rdo120.AutoSize = true;
            this.rdo120.Location = new System.Drawing.Point(84, 33);
            this.rdo120.Name = "rdo120";
            this.rdo120.Size = new System.Drawing.Size(82, 24);
            this.rdo120.TabIndex = 11;
            this.rdo120.TabStop = true;
            this.rdo120.Text = "120GB";
            this.rdo120.UseVisualStyleBackColor = true;
            // 
            // rdo256
            // 
            this.rdo256.AutoSize = true;
            this.rdo256.Location = new System.Drawing.Point(193, 33);
            this.rdo256.Name = "rdo256";
            this.rdo256.Size = new System.Drawing.Size(82, 24);
            this.rdo256.TabIndex = 12;
            this.rdo256.TabStop = true;
            this.rdo256.Text = "256GB";
            this.rdo256.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpload);
            this.groupBox1.Controls.Add(this.txtFile);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.box_hinhanh);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.cbomaloai);
            this.groupBox1.Controls.Add(this.cbotenloai);
            this.groupBox1.Controls.Add(this.cbomamau);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cbotenmau);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cbomahang);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbotenhang);
            this.groupBox1.Controls.Add(this.txtcard);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtcpu);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtram);
            this.groupBox1.Controls.Add(this.txtgia);
            this.groupBox1.Controls.Add(this.txtten);
            this.groupBox1.Controls.Add(this.txtma);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(51, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1287, 406);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin laptop";

            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(1121, 354);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(118, 30);
            this.btnUpload.TabIndex = 30;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(603, 355);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(497, 27);
            this.txtFile.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(494, 358);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "Tên file";
            // 
            // box_hinhanh
            // 
            this.box_hinhanh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.box_hinhanh.Location = new System.Drawing.Point(1003, 188);
            this.box_hinhanh.Name = "box_hinhanh";
            this.box_hinhanh.Size = new System.Drawing.Size(236, 144);
            this.box_hinhanh.TabIndex = 27;
            this.box_hinhanh.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ckb_magie);
            this.groupBox3.Controls.Add(this.ckb_nhom);
            this.groupBox3.Controls.Add(this.ckb_nhua);
            this.groupBox3.Controls.Add(this.ckb_kimloai);
            this.groupBox3.Location = new System.Drawing.Point(477, 167);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(339, 116);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chất liệu";
            // 
            // ckb_magie
            // 
            this.ckb_magie.AutoSize = true;
            this.ckb_magie.Location = new System.Drawing.Point(193, 86);
            this.ckb_magie.Name = "ckb_magie";
            this.ckb_magie.Size = new System.Drawing.Size(76, 24);
            this.ckb_magie.TabIndex = 3;
            this.ckb_magie.Text = "Magie";
            this.ckb_magie.UseVisualStyleBackColor = true;
            // 
            // ckb_nhom
            // 
            this.ckb_nhom.AutoSize = true;
            this.ckb_nhom.Location = new System.Drawing.Point(59, 86);
            this.ckb_nhom.Name = "ckb_nhom";
            this.ckb_nhom.Size = new System.Drawing.Size(75, 24);
            this.ckb_nhom.TabIndex = 2;
            this.ckb_nhom.Text = "Nhôm";
            this.ckb_nhom.UseVisualStyleBackColor = true;
            // 
            // ckb_nhua
            // 
            this.ckb_nhua.AutoSize = true;
            this.ckb_nhua.Location = new System.Drawing.Point(193, 43);
            this.ckb_nhua.Name = "ckb_nhua";
            this.ckb_nhua.Size = new System.Drawing.Size(70, 24);
            this.ckb_nhua.TabIndex = 1;
            this.ckb_nhua.Text = "Nhựa";
            this.ckb_nhua.UseVisualStyleBackColor = true;
            // 
            // ckb_kimloai
            // 
            this.ckb_kimloai.AutoSize = true;
            this.ckb_kimloai.Location = new System.Drawing.Point(59, 43);
            this.ckb_kimloai.Name = "ckb_kimloai";
            this.ckb_kimloai.Size = new System.Drawing.Size(91, 24);
            this.ckb_kimloai.TabIndex = 0;
            this.ckb_kimloai.Text = "Kim loại";
            this.ckb_kimloai.UseVisualStyleBackColor = true;
            // 
            // cbomaloai
            // 
            this.cbomaloai.FormattingEnabled = true;
            this.cbomaloai.Location = new System.Drawing.Point(193, 350);
            this.cbomaloai.Name = "cbomaloai";
            this.cbomaloai.Size = new System.Drawing.Size(236, 28);
            this.cbomaloai.TabIndex = 26;
            this.cbomaloai.Visible = false;
            // 
            // cbotenloai
            // 
            this.cbotenloai.FormattingEnabled = true;
            this.cbotenloai.Location = new System.Drawing.Point(1003, 41);
            this.cbotenloai.Name = "cbotenloai";
            this.cbotenloai.Size = new System.Drawing.Size(236, 28);
            this.cbotenloai.TabIndex = 25;
            this.cbotenloai.VisibleChanged += new System.EventHandler(this.Form_Thong_Tin_Laptop_Load);
            // 
            // cbomamau
            // 
            this.cbomamau.FormattingEnabled = true;
            this.cbomamau.Location = new System.Drawing.Point(193, 350);
            this.cbomamau.Name = "cbomamau";
            this.cbomamau.Size = new System.Drawing.Size(236, 28);
            this.cbomamau.TabIndex = 24;
            this.cbomamau.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(868, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "Loại";
            // 
            // cbotenmau
            // 
            this.cbotenmau.FormattingEnabled = true;
            this.cbotenmau.Location = new System.Drawing.Point(1003, 89);
            this.cbotenmau.Name = "cbotenmau";
            this.cbotenmau.Size = new System.Drawing.Size(236, 28);
            this.cbotenmau.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(868, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Màu";
            // 
            // cbomahang
            // 
            this.cbomahang.FormattingEnabled = true;
            this.cbomahang.Location = new System.Drawing.Point(193, 350);
            this.cbomahang.Name = "cbomahang";
            this.cbomahang.Size = new System.Drawing.Size(236, 28);
            this.cbomahang.TabIndex = 20;
            this.cbomahang.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(868, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Hãng";
            // 
            // cbotenhang
            // 
            this.cbotenhang.FormattingEnabled = true;
            this.cbotenhang.Location = new System.Drawing.Point(1003, 143);
            this.cbotenhang.Name = "cbotenhang";
            this.cbotenhang.Size = new System.Drawing.Size(236, 28);
            this.cbotenhang.TabIndex = 18;
            // 
            // txtcard
            // 
            this.txtcard.Location = new System.Drawing.Point(193, 245);
            this.txtcard.MaxLength = 10;
            this.txtcard.Name = "txtcard";
            this.txtcard.Size = new System.Drawing.Size(236, 27);
            this.txtcard.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Card";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdo1tb);
            this.groupBox2.Controls.Add(this.rdo512);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.rdo120);
            this.groupBox2.Controls.Add(this.rdo256);
            this.groupBox2.Location = new System.Drawing.Point(477, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 116);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bộ nhớ";
            // 
            // rdo1tb
            // 
            this.rdo1tb.AutoSize = true;
            this.rdo1tb.Location = new System.Drawing.Point(193, 70);
            this.rdo1tb.Name = "rdo1tb";
            this.rdo1tb.Size = new System.Drawing.Size(61, 24);
            this.rdo1tb.TabIndex = 14;
            this.rdo1tb.TabStop = true;
            this.rdo1tb.Text = "1TB";
            this.rdo1tb.UseVisualStyleBackColor = true;
            // 
            // rdo512
            // 
            this.rdo512.AutoSize = true;
            this.rdo512.Location = new System.Drawing.Point(84, 70);
            this.rdo512.Name = "rdo512";
            this.rdo512.Size = new System.Drawing.Size(82, 24);
            this.rdo512.TabIndex = 13;
            this.rdo512.TabStop = true;
            this.rdo512.Text = "512GB";
            this.rdo512.UseVisualStyleBackColor = true;
            // 
            // txtcpu
            // 
            this.txtcpu.Location = new System.Drawing.Point(193, 198);
            this.txtcpu.MaxLength = 10;
            this.txtcpu.Name = "txtcpu";
            this.txtcpu.Size = new System.Drawing.Size(236, 27);
            this.txtcpu.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(58, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "CPU";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(136, 588);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 20);
            this.label14.TabIndex = 32;
            this.label14.Text = "Thông báo";
            // 
            // lb_thongbao_1
            // 
            this.lb_thongbao_1.AutoSize = true;
            this.lb_thongbao_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thongbao_1.Location = new System.Drawing.Point(240, 588);
            this.lb_thongbao_1.Name = "lb_thongbao_1";
            this.lb_thongbao_1.Size = new System.Drawing.Size(14, 20);
            this.lb_thongbao_1.TabIndex = 33;
            this.lb_thongbao_1.Text = ":";
            // 
            // btn_resert
            // 
            this.btn_resert.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_resert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resert.Location = new System.Drawing.Point(702, 538);
            this.btn_resert.Name = "btn_resert";
            this.btn_resert.Size = new System.Drawing.Size(111, 39);
            this.btn_resert.TabIndex = 34;
            this.btn_resert.Text = "Nhập lại";
            this.btn_resert.UseVisualStyleBackColor = false;
            this.btn_resert.Click += new System.EventHandler(this.btn_resert_Click);
            // 
            // Form_Thong_Tin_Laptop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 855);
            this.Controls.Add(this.btn_resert);
            this.Controls.Add(this.lb_thongbao_1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lb_thongbao);
            this.Controls.Add(this.dgvdanhsach);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnxem);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form_Thong_Tin_Laptop";
            this.Text = "Form_Thong_Tin_Laptop";
            this.Load += new System.EventHandler(this.Form_Thong_Tin_Laptop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box_hinhanh)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_thongbao;
        private System.Windows.Forms.DataGridView dgvdanhsach;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.TextBox txtram;
        private System.Windows.Forms.RadioButton rdo120;
        private System.Windows.Forms.RadioButton rdo256;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdo1tb;
        private System.Windows.Forms.RadioButton rdo512;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtcpu;
        private System.Windows.Forms.TextBox txtcard;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbotenmau;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbomahang;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbotenhang;
        private System.Windows.Forms.ComboBox cbomaloai;
        private System.Windows.Forms.ComboBox cbotenloai;
        private System.Windows.Forms.ComboBox cbomamau;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox ckb_nhua;
        private System.Windows.Forms.CheckBox ckb_kimloai;
        private System.Windows.Forms.CheckBox ckb_magie;
        private System.Windows.Forms.CheckBox ckb_nhom;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox box_hinhanh;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lb_thongbao_1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_resert;
    }
}