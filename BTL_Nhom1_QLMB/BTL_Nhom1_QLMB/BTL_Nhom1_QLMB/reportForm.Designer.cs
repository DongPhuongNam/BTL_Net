namespace BTL_Nhom1_QLMB
{
    partial class reportForm
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
            this.reportViewerThonTin = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerThonTin
            // 
            this.reportViewerThonTin.LocalReport.ReportEmbeddedResource = "BTL_Nhom1_QLMB.reportThongTinChuyenBay.rdlc";
            this.reportViewerThonTin.Location = new System.Drawing.Point(16, 15);
            this.reportViewerThonTin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportViewerThonTin.Name = "reportViewerThonTin";
            this.reportViewerThonTin.ServerReport.BearerToken = null;
            this.reportViewerThonTin.Size = new System.Drawing.Size(1589, 935);
            this.reportViewerThonTin.TabIndex = 0;
            this.reportViewerThonTin.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // reportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1621, 965);
            this.Controls.Add(this.reportViewerThonTin);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "reportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report From";
            this.Load += new System.EventHandler(this.reportForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerThonTin;
    }
}