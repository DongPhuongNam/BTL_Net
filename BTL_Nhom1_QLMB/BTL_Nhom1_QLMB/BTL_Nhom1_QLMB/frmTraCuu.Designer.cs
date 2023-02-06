namespace BTL_Nhom1_QLMB
{
    partial class frmTraCuu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTraCuu));
            this.dgvQLCB = new System.Windows.Forms.DataGridView();
            this.macb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sohieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sbdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sbden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giodi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaydi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMachuyenBay = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSanbaydi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLCB)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvQLCB
            // 
            this.dgvQLCB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQLCB.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvQLCB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLCB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.macb,
            this.sohieu,
            this.sbdi,
            this.sbden,
            this.giodi,
            this.gioden,
            this.ngaydi,
            this.ngayden});
            this.dgvQLCB.Location = new System.Drawing.Point(34, 339);
            this.dgvQLCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvQLCB.Name = "dgvQLCB";
            this.dgvQLCB.ReadOnly = true;
            this.dgvQLCB.RowHeadersWidth = 51;
            this.dgvQLCB.RowTemplate.Height = 24;
            this.dgvQLCB.Size = new System.Drawing.Size(1216, 327);
            this.dgvQLCB.TabIndex = 68;
            // 
            // macb
            // 
            this.macb.DataPropertyName = "macb";
            this.macb.HeaderText = "Mã chuyến bay";
            this.macb.MinimumWidth = 6;
            this.macb.Name = "macb";
            this.macb.ReadOnly = true;
            // 
            // sohieu
            // 
            this.sohieu.DataPropertyName = "sohieu";
            this.sohieu.HeaderText = "Số hiệu";
            this.sohieu.MinimumWidth = 6;
            this.sohieu.Name = "sohieu";
            this.sohieu.ReadOnly = true;
            // 
            // sbdi
            // 
            this.sbdi.DataPropertyName = "sbdi";
            this.sbdi.HeaderText = "Sân bay đi";
            this.sbdi.MinimumWidth = 6;
            this.sbdi.Name = "sbdi";
            this.sbdi.ReadOnly = true;
            // 
            // sbden
            // 
            this.sbden.DataPropertyName = "sbden";
            this.sbden.HeaderText = "Sân bay đến";
            this.sbden.MinimumWidth = 6;
            this.sbden.Name = "sbden";
            this.sbden.ReadOnly = true;
            // 
            // giodi
            // 
            this.giodi.DataPropertyName = "giodi";
            this.giodi.HeaderText = "Giờ đi";
            this.giodi.MinimumWidth = 6;
            this.giodi.Name = "giodi";
            this.giodi.ReadOnly = true;
            // 
            // gioden
            // 
            this.gioden.DataPropertyName = "gioden";
            this.gioden.HeaderText = "Giờ đến";
            this.gioden.MinimumWidth = 6;
            this.gioden.Name = "gioden";
            this.gioden.ReadOnly = true;
            // 
            // ngaydi
            // 
            this.ngaydi.DataPropertyName = "ngaydi";
            this.ngaydi.HeaderText = "Ngày đi";
            this.ngaydi.MinimumWidth = 6;
            this.ngaydi.Name = "ngaydi";
            this.ngaydi.ReadOnly = true;
            // 
            // ngayden
            // 
            this.ngayden.DataPropertyName = "ngayden";
            this.ngayden.HeaderText = "Ngày đến";
            this.ngayden.MinimumWidth = 6;
            this.ngayden.Name = "ngayden";
            this.ngayden.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(478, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 69;
            this.label1.Text = "Tra Cứu Lịch Bay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 70;
            this.label2.Text = "Mẫ Chyến Bay";
            // 
            // txtMachuyenBay
            // 
            this.txtMachuyenBay.Location = new System.Drawing.Point(291, 149);
            this.txtMachuyenBay.Multiline = true;
            this.txtMachuyenBay.Name = "txtMachuyenBay";
            this.txtMachuyenBay.Size = new System.Drawing.Size(394, 34);
            this.txtMachuyenBay.TabIndex = 71;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(828, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 62);
            this.button1.TabIndex = 72;
            this.button1.Text = " Tra Cứu";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSanbaydi
            // 
            this.txtSanbaydi.Location = new System.Drawing.Point(291, 213);
            this.txtSanbaydi.Multiline = true;
            this.txtSanbaydi.Name = "txtSanbaydi";
            this.txtSanbaydi.Size = new System.Drawing.Size(394, 35);
            this.txtSanbaydi.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 73;
            this.label3.Text = "Sân Bay Đi";
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(828, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 63);
            this.button2.TabIndex = 75;
            this.button2.Text = " Hiển Thị";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(1060, 130);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 62);
            this.button3.TabIndex = 76;
            this.button3.Text = "   Đặt Vé";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(1060, 230);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(163, 62);
            this.button4.TabIndex = 77;
            this.button4.Text = "  Thoát";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.flowLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel1.BackgroundImage")));
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(176, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(125, 100);
            this.flowLayoutPanel1.TabIndex = 78;
            // 
            // frmTraCuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BTL_Nhom1_QLMB.Properties.Resources.aaa;
            this.ClientSize = new System.Drawing.Size(1283, 677);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtSanbaydi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMachuyenBay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvQLCB);
            this.Name = "frmTraCuu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra Cứu Lịch Bay";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLCB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQLCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn macb;
        private System.Windows.Forms.DataGridViewTextBoxColumn sohieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn sbdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sbden;
        private System.Windows.Forms.DataGridViewTextBoxColumn giodi;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioden;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaydi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMachuyenBay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSanbaydi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}