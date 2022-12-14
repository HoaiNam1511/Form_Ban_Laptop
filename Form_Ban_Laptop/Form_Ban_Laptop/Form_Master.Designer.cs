
namespace Form_Ban_Laptop
{
    partial class Form_Master
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
            this.left_panel = new System.Windows.Forms.Panel();
            this.btn_dangxuat = new System.Windows.Forms.Button();
            this.btn_kho = new System.Windows.Forms.Button();
            this.txt_tentk = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_loai = new System.Windows.Forms.Button();
            this.btn_mausac = new System.Windows.Forms.Button();
            this.btn_hang = new System.Windows.Forms.Button();
            this.btn_nhanvien = new System.Windows.Forms.Button();
            this.btn_hoadon = new System.Windows.Forms.Button();
            this.btn_thongtin_laptop = new System.Windows.Forms.Button();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.left_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // left_panel
            // 
            this.left_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.left_panel.Controls.Add(this.btn_dangxuat);
            this.left_panel.Controls.Add(this.btn_kho);
            this.left_panel.Controls.Add(this.txt_tentk);
            this.left_panel.Controls.Add(this.pictureBox1);
            this.left_panel.Controls.Add(this.btn_loai);
            this.left_panel.Controls.Add(this.btn_mausac);
            this.left_panel.Controls.Add(this.btn_hang);
            this.left_panel.Controls.Add(this.btn_nhanvien);
            this.left_panel.Controls.Add(this.btn_hoadon);
            this.left_panel.Controls.Add(this.btn_thongtin_laptop);
            this.left_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.left_panel.Location = new System.Drawing.Point(0, 0);
            this.left_panel.Name = "left_panel";
            this.left_panel.Size = new System.Drawing.Size(314, 884);
            this.left_panel.TabIndex = 0;
            // 
            // btn_dangxuat
            // 
            this.btn_dangxuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_dangxuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_dangxuat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_dangxuat.FlatAppearance.BorderSize = 0;
            this.btn_dangxuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dangxuat.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangxuat.ForeColor = System.Drawing.Color.White;
            this.btn_dangxuat.Image = global::Form_Ban_Laptop.Properties.Resources.logout1;
            this.btn_dangxuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dangxuat.Location = new System.Drawing.Point(0, 802);
            this.btn_dangxuat.Name = "btn_dangxuat";
            this.btn_dangxuat.Size = new System.Drawing.Size(311, 54);
            this.btn_dangxuat.TabIndex = 10;
            this.btn_dangxuat.Text = "ĐĂNG XUẤT";
            this.btn_dangxuat.UseVisualStyleBackColor = false;
            this.btn_dangxuat.Click += new System.EventHandler(this.btn_dangxuat_Click);
            // 
            // btn_kho
            // 
            this.btn_kho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_kho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_kho.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_kho.FlatAppearance.BorderSize = 0;
            this.btn_kho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kho.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kho.ForeColor = System.Drawing.Color.White;
            this.btn_kho.Image = global::Form_Ban_Laptop.Properties.Resources.Kho;
            this.btn_kho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kho.Location = new System.Drawing.Point(3, 343);
            this.btn_kho.Name = "btn_kho";
            this.btn_kho.Size = new System.Drawing.Size(311, 54);
            this.btn_kho.TabIndex = 9;
            this.btn_kho.Text = "KHO HÀNG";
            this.btn_kho.UseVisualStyleBackColor = false;
            this.btn_kho.Click += new System.EventHandler(this.btn_kho_Click);
            // 
            // txt_tentk
            // 
            this.txt_tentk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txt_tentk.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_tentk.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tentk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_tentk.Location = new System.Drawing.Point(0, 175);
            this.txt_tentk.Name = "txt_tentk";
            this.txt_tentk.ReadOnly = true;
            this.txt_tentk.Size = new System.Drawing.Size(314, 35);
            this.txt_tentk.TabIndex = 8;
            this.txt_tentk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Form_Ban_Laptop.Properties.Resources.icon_admin;
            this.pictureBox1.Location = new System.Drawing.Point(72, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_loai
            // 
            this.btn_loai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_loai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_loai.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_loai.FlatAppearance.BorderSize = 0;
            this.btn_loai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loai.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loai.ForeColor = System.Drawing.Color.White;
            this.btn_loai.Image = global::Form_Ban_Laptop.Properties.Resources.loai;
            this.btn_loai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_loai.Location = new System.Drawing.Point(-3, 583);
            this.btn_loai.Name = "btn_loai";
            this.btn_loai.Size = new System.Drawing.Size(311, 54);
            this.btn_loai.TabIndex = 6;
            this.btn_loai.Text = "LOẠI";
            this.btn_loai.UseVisualStyleBackColor = false;
            this.btn_loai.Click += new System.EventHandler(this.btn_loai_Click);
            // 
            // btn_mausac
            // 
            this.btn_mausac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_mausac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_mausac.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_mausac.FlatAppearance.BorderSize = 0;
            this.btn_mausac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mausac.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mausac.ForeColor = System.Drawing.Color.White;
            this.btn_mausac.Image = global::Form_Ban_Laptop.Properties.Resources.mau;
            this.btn_mausac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_mausac.Location = new System.Drawing.Point(-3, 523);
            this.btn_mausac.Name = "btn_mausac";
            this.btn_mausac.Size = new System.Drawing.Size(311, 54);
            this.btn_mausac.TabIndex = 5;
            this.btn_mausac.Text = "MÀU SẮC";
            this.btn_mausac.UseVisualStyleBackColor = false;
            this.btn_mausac.Click += new System.EventHandler(this.btn_mausac_Click);
            // 
            // btn_hang
            // 
            this.btn_hang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_hang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_hang.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_hang.FlatAppearance.BorderSize = 0;
            this.btn_hang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hang.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hang.ForeColor = System.Drawing.Color.White;
            this.btn_hang.Image = global::Form_Ban_Laptop.Properties.Resources.hang;
            this.btn_hang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hang.Location = new System.Drawing.Point(-3, 463);
            this.btn_hang.Name = "btn_hang";
            this.btn_hang.Size = new System.Drawing.Size(311, 54);
            this.btn_hang.TabIndex = 4;
            this.btn_hang.Text = "HÃNG LAPTOP";
            this.btn_hang.UseVisualStyleBackColor = false;
            this.btn_hang.Click += new System.EventHandler(this.btn_hang_Click);
            // 
            // btn_nhanvien
            // 
            this.btn_nhanvien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_nhanvien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_nhanvien.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_nhanvien.FlatAppearance.BorderSize = 0;
            this.btn_nhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nhanvien.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhanvien.ForeColor = System.Drawing.Color.White;
            this.btn_nhanvien.Image = global::Form_Ban_Laptop.Properties.Resources.nhanvien;
            this.btn_nhanvien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nhanvien.Location = new System.Drawing.Point(-3, 403);
            this.btn_nhanvien.Name = "btn_nhanvien";
            this.btn_nhanvien.Size = new System.Drawing.Size(311, 54);
            this.btn_nhanvien.TabIndex = 3;
            this.btn_nhanvien.Text = "NHÂN VIÊN";
            this.btn_nhanvien.UseVisualStyleBackColor = false;
            this.btn_nhanvien.Click += new System.EventHandler(this.btn_nhanvien_Click);
            // 
            // btn_hoadon
            // 
            this.btn_hoadon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_hoadon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_hoadon.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_hoadon.FlatAppearance.BorderSize = 0;
            this.btn_hoadon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hoadon.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hoadon.ForeColor = System.Drawing.Color.White;
            this.btn_hoadon.Image = global::Form_Ban_Laptop.Properties.Resources.bill4;
            this.btn_hoadon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hoadon.Location = new System.Drawing.Point(0, 283);
            this.btn_hoadon.Name = "btn_hoadon";
            this.btn_hoadon.Size = new System.Drawing.Size(311, 54);
            this.btn_hoadon.TabIndex = 2;
            this.btn_hoadon.Text = "HOÁ ĐƠN";
            this.btn_hoadon.UseVisualStyleBackColor = false;
            this.btn_hoadon.Click += new System.EventHandler(this.btn_hoadon_Click);
            // 
            // btn_thongtin_laptop
            // 
            this.btn_thongtin_laptop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_thongtin_laptop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_thongtin_laptop.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_thongtin_laptop.FlatAppearance.BorderSize = 0;
            this.btn_thongtin_laptop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thongtin_laptop.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thongtin_laptop.ForeColor = System.Drawing.Color.White;
            this.btn_thongtin_laptop.Image = global::Form_Ban_Laptop.Properties.Resources.laptop2;
            this.btn_thongtin_laptop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thongtin_laptop.Location = new System.Drawing.Point(0, 223);
            this.btn_thongtin_laptop.Name = "btn_thongtin_laptop";
            this.btn_thongtin_laptop.Size = new System.Drawing.Size(311, 54);
            this.btn_thongtin_laptop.TabIndex = 1;
            this.btn_thongtin_laptop.Text = "LAPTOP";
            this.btn_thongtin_laptop.UseVisualStyleBackColor = false;
            this.btn_thongtin_laptop.Click += new System.EventHandler(this.btn_thongtin_laptop_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.BackgroundImage = global::Form_Ban_Laptop.Properties.Resources.bg4;
            this.mainpanel.Location = new System.Drawing.Point(314, 0);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1329, 884);
            this.mainpanel.TabIndex = 1;
            // 
            // Form_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1640, 884);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.left_panel);
            this.Name = "Form_Master";
            this.Text = "Form_Master";
            this.Load += new System.EventHandler(this.Form_Master_Load);
            this.left_panel.ResumeLayout(false);
            this.left_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel left_panel;
        private System.Windows.Forms.Button btn_thongtin_laptop;
        private System.Windows.Forms.Button btn_loai;
        private System.Windows.Forms.Button btn_mausac;
        private System.Windows.Forms.Button btn_hang;
        private System.Windows.Forms.Button btn_nhanvien;
        private System.Windows.Forms.Button btn_hoadon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.TextBox txt_tentk;
        private System.Windows.Forms.Button btn_kho;
        private System.Windows.Forms.Button btn_dangxuat;
    }
}