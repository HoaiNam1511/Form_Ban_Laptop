
namespace Form_Ban_Laptop
{
    partial class In_Kho_Hang_Form
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
            this.crp_Khohang = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crp_Khohang
            // 
            this.crp_Khohang.ActiveViewIndex = -1;
            this.crp_Khohang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crp_Khohang.Cursor = System.Windows.Forms.Cursors.Default;
            this.crp_Khohang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crp_Khohang.Location = new System.Drawing.Point(0, 0);
            this.crp_Khohang.Name = "crp_Khohang";
            this.crp_Khohang.Size = new System.Drawing.Size(800, 450);
            this.crp_Khohang.TabIndex = 0;
            // 
            // In_Kho_Hang_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crp_Khohang);
            this.Name = "In_Kho_Hang_Form";
            this.Text = "In_Kho_Hang_Form";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crp_Khohang;
    }
}