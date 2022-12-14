
namespace Form_Ban_Laptop
{
    partial class Hoa_Don_Ban_Form
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
            this.crp_HoaDon = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crp_HoaDon
            // 
            this.crp_HoaDon.ActiveViewIndex = -1;
            this.crp_HoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crp_HoaDon.Cursor = System.Windows.Forms.Cursors.Default;
            this.crp_HoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crp_HoaDon.Location = new System.Drawing.Point(0, 0);
            this.crp_HoaDon.Name = "crp_HoaDon";
            this.crp_HoaDon.Size = new System.Drawing.Size(800, 450);
            this.crp_HoaDon.TabIndex = 0;
            // 
            // Hoa_Don_Ban_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crp_HoaDon);
            this.Name = "Hoa_Don_Ban_Form";
            this.Text = "Hoa_Don_Ban_Form";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crp_HoaDon;
    }
}