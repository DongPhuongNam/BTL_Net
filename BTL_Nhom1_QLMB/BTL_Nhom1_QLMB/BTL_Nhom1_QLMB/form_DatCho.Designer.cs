namespace BTL_Nhom1_QLMB
{
    partial class form_DatCho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_DatCho));
            this.label2 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDatCho = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.tbSoHieu = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbSanBayDen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSanBayDi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbMaCb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTenDN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCMT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSdt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTenKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMaKh = new System.Windows.Forms.TextBox();
            this.dgvLichBay = new System.Windows.Forms.DataGridView();
            this.macb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sohieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sbdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sbden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giodi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaydi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpGioDen = new System.Windows.Forms.DateTimePicker();
            this.dtpGioDi = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpNgayDen = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayDi = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichBay)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(723, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 36);
            this.label2.TabIndex = 133;
            this.label2.Text = "Đặt chỗ";
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.BackColor = System.Drawing.Color.Salmon;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(1039, 670);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(175, 62);
            this.btnThoat.TabIndex = 132;
            this.btnThoat.Text = "  Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Salmon;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.Location = new System.Drawing.Point(463, 670);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(171, 62);
            this.btnReset.TabIndex = 131;
            this.btnReset.Text = "  Reset";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDatCho
            // 
            this.btnDatCho.BackColor = System.Drawing.Color.Salmon;
            this.btnDatCho.Image = ((System.Drawing.Image)(resources.GetObject("btnDatCho.Image")));
            this.btnDatCho.Location = new System.Drawing.Point(763, 670);
            this.btnDatCho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDatCho.Name = "btnDatCho";
            this.btnDatCho.Size = new System.Drawing.Size(171, 62);
            this.btnDatCho.TabIndex = 130;
            this.btnDatCho.Text = "  Đặt chỗ";
            this.btnDatCho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDatCho.UseVisualStyleBackColor = false;
            this.btnDatCho.Click += new System.EventHandler(this.btnDatCho_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(588, 452);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 18);
            this.label14.TabIndex = 129;
            this.label14.Text = "Số hiệu";
            // 
            // tbSoHieu
            // 
            this.tbSoHieu.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbSoHieu.Enabled = false;
            this.tbSoHieu.Location = new System.Drawing.Point(690, 452);
            this.tbSoHieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSoHieu.Name = "tbSoHieu";
            this.tbSoHieu.Size = new System.Drawing.Size(280, 22);
            this.tbSoHieu.TabIndex = 128;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(588, 506);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 18);
            this.label11.TabIndex = 121;
            this.label11.Text = "Sân bay đến";
            // 
            // tbSanBayDen
            // 
            this.tbSanBayDen.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbSanBayDen.Enabled = false;
            this.tbSanBayDen.Location = new System.Drawing.Point(690, 507);
            this.tbSanBayDen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSanBayDen.Name = "tbSanBayDen";
            this.tbSanBayDen.Size = new System.Drawing.Size(280, 22);
            this.tbSanBayDen.TabIndex = 120;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(136, 507);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 18);
            this.label8.TabIndex = 119;
            this.label8.Text = "Sân bay đi";
            // 
            // tbSanBayDi
            // 
            this.tbSanBayDi.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbSanBayDi.Enabled = false;
            this.tbSanBayDi.Location = new System.Drawing.Point(239, 506);
            this.tbSanBayDi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSanBayDi.Name = "tbSanBayDi";
            this.tbSanBayDi.Size = new System.Drawing.Size(280, 22);
            this.tbSanBayDi.TabIndex = 118;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(108, 459);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 18);
            this.label9.TabIndex = 117;
            this.label9.Text = "Mã chuyến bay";
            // 
            // tbMaCb
            // 
            this.tbMaCb.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbMaCb.Enabled = false;
            this.tbMaCb.Location = new System.Drawing.Point(239, 456);
            this.tbMaCb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMaCb.Name = "tbMaCb";
            this.tbMaCb.Size = new System.Drawing.Size(280, 22);
            this.tbMaCb.TabIndex = 116;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(83, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 16);
            this.label7.TabIndex = 115;
            this.label7.Text = "Tên đăng nhập";
            // 
            // tbTenDN
            // 
            this.tbTenDN.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbTenDN.Enabled = false;
            this.tbTenDN.Location = new System.Drawing.Point(239, 393);
            this.tbTenDN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTenDN.Name = "tbTenDN";
            this.tbTenDN.Size = new System.Drawing.Size(280, 22);
            this.tbTenDN.TabIndex = 114;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 113;
            this.label6.Text = "Số CMT";
            // 
            // tbCMT
            // 
            this.tbCMT.Enabled = false;
            this.tbCMT.Location = new System.Drawing.Point(239, 330);
            this.tbCMT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCMT.Name = "tbCMT";
            this.tbCMT.Size = new System.Drawing.Size(280, 22);
            this.tbCMT.TabIndex = 112;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 111;
            this.label5.Text = "Số điện thoại";
            // 
            // tbSdt
            // 
            this.tbSdt.Enabled = false;
            this.tbSdt.Location = new System.Drawing.Point(239, 272);
            this.tbSdt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSdt.Name = "tbSdt";
            this.tbSdt.Size = new System.Drawing.Size(280, 22);
            this.tbSdt.TabIndex = 110;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 109;
            this.label4.Text = "Địa chỉ";
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Enabled = false;
            this.tbDiaChi.Location = new System.Drawing.Point(239, 213);
            this.tbDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(280, 22);
            this.tbDiaChi.TabIndex = 108;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 107;
            this.label3.Text = "Tên khách hàng";
            // 
            // tbTenKH
            // 
            this.tbTenKH.Enabled = false;
            this.tbTenKH.Location = new System.Drawing.Point(239, 167);
            this.tbTenKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTenKH.Name = "tbTenKH";
            this.tbTenKH.Size = new System.Drawing.Size(280, 22);
            this.tbTenKH.TabIndex = 106;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 105;
            this.label1.Text = "Mã khách hàng";
            // 
            // tbMaKh
            // 
            this.tbMaKh.Enabled = false;
            this.tbMaKh.Location = new System.Drawing.Point(239, 105);
            this.tbMaKh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMaKh.Name = "tbMaKh";
            this.tbMaKh.Size = new System.Drawing.Size(280, 22);
            this.tbMaKh.TabIndex = 104;
            // 
            // dgvLichBay
            // 
            this.dgvLichBay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichBay.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvLichBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichBay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.macb,
            this.sohieu,
            this.sbdi,
            this.sbden,
            this.giodi,
            this.gioden,
            this.ngaydi,
            this.ngayden});
            this.dgvLichBay.Location = new System.Drawing.Point(576, 108);
            this.dgvLichBay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvLichBay.Name = "dgvLichBay";
            this.dgvLichBay.ReadOnly = true;
            this.dgvLichBay.RowHeadersWidth = 51;
            this.dgvLichBay.RowTemplate.Height = 24;
            this.dgvLichBay.Size = new System.Drawing.Size(1005, 304);
            this.dgvLichBay.TabIndex = 136;
            this.dgvLichBay.SelectionChanged += new System.EventHandler(this.dgvLichBay_SelectionChanged);
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
            // dtpGioDen
            // 
            this.dtpGioDen.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dtpGioDen.Enabled = false;
            this.dtpGioDen.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpGioDen.Location = new System.Drawing.Point(690, 561);
            this.dtpGioDen.Margin = new System.Windows.Forms.Padding(4);
            this.dtpGioDen.Name = "dtpGioDen";
            this.dtpGioDen.ShowUpDown = true;
            this.dtpGioDen.Size = new System.Drawing.Size(280, 22);
            this.dtpGioDen.TabIndex = 140;
            // 
            // dtpGioDi
            // 
            this.dtpGioDi.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dtpGioDi.Enabled = false;
            this.dtpGioDi.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpGioDi.Location = new System.Drawing.Point(1175, 451);
            this.dtpGioDi.Margin = new System.Windows.Forms.Padding(4);
            this.dtpGioDi.Name = "dtpGioDi";
            this.dtpGioDi.ShowUpDown = true;
            this.dtpGioDi.Size = new System.Drawing.Size(280, 22);
            this.dtpGioDi.TabIndex = 139;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(588, 564);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 18);
            this.label10.TabIndex = 137;
            this.label10.Text = "Giờ đến";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1082, 451);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 18);
            this.label12.TabIndex = 138;
            this.label12.Text = "Giờ đi";
            // 
            // dtpNgayDen
            // 
            this.dtpNgayDen.Enabled = false;
            this.dtpNgayDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDen.Location = new System.Drawing.Point(1175, 561);
            this.dtpNgayDen.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayDen.Name = "dtpNgayDen";
            this.dtpNgayDen.Size = new System.Drawing.Size(280, 22);
            this.dtpNgayDen.TabIndex = 144;
            // 
            // dtpNgayDi
            // 
            this.dtpNgayDi.Enabled = false;
            this.dtpNgayDi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDi.Location = new System.Drawing.Point(1175, 503);
            this.dtpNgayDi.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayDi.Name = "dtpNgayDi";
            this.dtpNgayDi.Size = new System.Drawing.Size(280, 22);
            this.dtpNgayDi.TabIndex = 143;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1082, 561);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 18);
            this.label13.TabIndex = 141;
            this.label13.Text = "Ngày đến";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1082, 503);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 18);
            this.label15.TabIndex = 142;
            this.label15.Text = "Ngày đi";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel1.BackgroundImage")));
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(624, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(69, 64);
            this.flowLayoutPanel1.TabIndex = 145;
            // 
            // form_DatCho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1643, 823);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dtpNgayDen);
            this.Controls.Add(this.dtpNgayDi);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dtpGioDen);
            this.Controls.Add(this.dtpGioDi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgvLichBay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDatCho);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tbSoHieu);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbSanBayDen);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbSanBayDi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbMaCb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbTenDN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbCMT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbSdt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDiaChi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTenKH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMaKh);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_DatCho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_DatCho";
            this.Load += new System.EventHandler(this.form_DatCho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichBay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDatCho;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbSoHieu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbSanBayDen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbSanBayDi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbMaCb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTenDN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCMT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSdt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTenKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMaKh;
        private System.Windows.Forms.DataGridView dgvLichBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn macb;
        private System.Windows.Forms.DataGridViewTextBoxColumn sohieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn sbdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sbden;
        private System.Windows.Forms.DataGridViewTextBoxColumn giodi;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioden;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaydi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayden;
        private System.Windows.Forms.DateTimePicker dtpGioDen;
        private System.Windows.Forms.DateTimePicker dtpGioDi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpNgayDen;
        private System.Windows.Forms.DateTimePicker dtpNgayDi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}