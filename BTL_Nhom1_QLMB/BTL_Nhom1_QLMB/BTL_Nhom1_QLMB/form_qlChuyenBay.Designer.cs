namespace BTL_Nhom1_QLMB
{
    partial class form_qlChuyenBay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_qlChuyenBay));
            this.dgvQLCB = new System.Windows.Forms.DataGridView();
            this.macb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sohieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sbdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sbden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giodi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaydi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.tbSanBayDen = new System.Windows.Forms.TextBox();
            this.tbSanBayDi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMaChuyenBay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgayDen = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayDi = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpGioDi = new System.Windows.Forms.DateTimePicker();
            this.dtpGioDen = new System.Windows.Forms.DateTimePicker();
            this.cbSoHieu = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
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
            this.dgvQLCB.Location = new System.Drawing.Point(34, 548);
            this.dgvQLCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvQLCB.Name = "dgvQLCB";
            this.dgvQLCB.ReadOnly = true;
            this.dgvQLCB.RowHeadersWidth = 51;
            this.dgvQLCB.RowTemplate.Height = 24;
            this.dgvQLCB.Size = new System.Drawing.Size(1192, 266);
            this.dgvQLCB.TabIndex = 67;
            this.dgvQLCB.SelectionChanged += new System.EventHandler(this.dgvQLCB_SelectionChanged);
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
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(1010, 425);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(155, 57);
            this.btnThoat.TabIndex = 63;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(1010, 339);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(155, 57);
            this.btnXoa.TabIndex = 64;
            this.btnXoa.Text = "  Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(1010, 247);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(155, 57);
            this.btnSua.TabIndex = 65;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(1010, 160);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(155, 57);
            this.btnThem.TabIndex = 66;
            this.btnThem.Text = "  Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // tbSanBayDen
            // 
            this.tbSanBayDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSanBayDen.Location = new System.Drawing.Point(245, 313);
            this.tbSanBayDen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSanBayDen.Name = "tbSanBayDen";
            this.tbSanBayDen.Size = new System.Drawing.Size(268, 26);
            this.tbSanBayDen.TabIndex = 60;
            // 
            // tbSanBayDi
            // 
            this.tbSanBayDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSanBayDi.Location = new System.Drawing.Point(245, 247);
            this.tbSanBayDi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSanBayDi.Name = "tbSanBayDi";
            this.tbSanBayDi.Size = new System.Drawing.Size(268, 26);
            this.tbSanBayDi.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(573, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 52;
            this.label7.Text = "Giờ đến";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(119, 316);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(101, 20);
            this.label.TabIndex = 53;
            this.label.Text = "Sân bay đến";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(573, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 54;
            this.label6.Text = "Giờ đi";
            // 
            // tbMaChuyenBay
            // 
            this.tbMaChuyenBay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaChuyenBay.Location = new System.Drawing.Point(245, 167);
            this.tbMaChuyenBay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMaChuyenBay.Name = "tbMaChuyenBay";
            this.tbMaChuyenBay.Size = new System.Drawing.Size(268, 26);
            this.tbMaChuyenBay.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(119, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 55;
            this.label4.Text = "Sân bay đi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 56;
            this.label2.Text = "Mã chuyến bay";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(375, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 36);
            this.label1.TabIndex = 57;
            this.label1.Text = "QUẢN LÝ CHUYẾN BAY";
            // 
            // dtpNgayDen
            // 
            this.dtpNgayDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDen.Location = new System.Drawing.Point(666, 392);
            this.dtpNgayDen.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayDen.Name = "dtpNgayDen";
            this.dtpNgayDen.Size = new System.Drawing.Size(209, 22);
            this.dtpNgayDen.TabIndex = 73;
            // 
            // dtpNgayDi
            // 
            this.dtpNgayDi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDi.Location = new System.Drawing.Point(666, 317);
            this.dtpNgayDi.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayDi.Name = "dtpNgayDi";
            this.dtpNgayDi.Size = new System.Drawing.Size(209, 22);
            this.dtpNgayDi.TabIndex = 72;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(567, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 70;
            this.label3.Text = "Ngày đến";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(567, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 71;
            this.label5.Text = "Ngày đi";
            // 
            // dtpGioDi
            // 
            this.dtpGioDi.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpGioDi.Location = new System.Drawing.Point(666, 168);
            this.dtpGioDi.Margin = new System.Windows.Forms.Padding(4);
            this.dtpGioDi.Name = "dtpGioDi";
            this.dtpGioDi.ShowUpDown = true;
            this.dtpGioDi.Size = new System.Drawing.Size(209, 22);
            this.dtpGioDi.TabIndex = 74;
            // 
            // dtpGioDen
            // 
            this.dtpGioDen.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpGioDen.Location = new System.Drawing.Point(666, 243);
            this.dtpGioDen.Margin = new System.Windows.Forms.Padding(4);
            this.dtpGioDen.Name = "dtpGioDen";
            this.dtpGioDen.ShowUpDown = true;
            this.dtpGioDen.Size = new System.Drawing.Size(209, 22);
            this.dtpGioDen.TabIndex = 75;
            // 
            // cbSoHieu
            // 
            this.cbSoHieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSoHieu.FormattingEnabled = true;
            this.cbSoHieu.Location = new System.Drawing.Point(245, 391);
            this.cbSoHieu.Margin = new System.Windows.Forms.Padding(4);
            this.cbSoHieu.Name = "cbSoHieu";
            this.cbSoHieu.Size = new System.Drawing.Size(268, 28);
            this.cbSoHieu.TabIndex = 76;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(119, 395);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 77;
            this.label8.Text = "Số hiệu";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel1.BackgroundImage")));
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(105, 26);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(115, 100);
            this.flowLayoutPanel1.TabIndex = 78;
            // 
            // form_qlChuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BTL_Nhom1_QLMB.Properties.Resources.aaa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 858);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbSoHieu);
            this.Controls.Add(this.dtpGioDen);
            this.Controls.Add(this.dtpGioDi);
            this.Controls.Add(this.dtpNgayDen);
            this.Controls.Add(this.dtpNgayDi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvQLCB);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.tbSanBayDen);
            this.Controls.Add(this.tbSanBayDi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbMaChuyenBay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_qlChuyenBay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Chuyến Bay";
            this.Load += new System.EventHandler(this.form_qlChuyenBay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLCB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQLCB;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox tbSanBayDen;
        private System.Windows.Forms.TextBox tbSanBayDi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMaChuyenBay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayDen;
        private System.Windows.Forms.DateTimePicker dtpNgayDi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpGioDi;
        private System.Windows.Forms.DateTimePicker dtpGioDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn macb;
        private System.Windows.Forms.DataGridViewTextBoxColumn sohieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn sbdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sbden;
        private System.Windows.Forms.DataGridViewTextBoxColumn giodi;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioden;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaydi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayden;
        private System.Windows.Forms.ComboBox cbSoHieu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}