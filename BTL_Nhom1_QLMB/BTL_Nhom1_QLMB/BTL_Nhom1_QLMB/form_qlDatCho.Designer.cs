namespace BTL_Nhom1_QLMB
{
    partial class form_qlDatCho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_qlDatCho));
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNgayDi = new System.Windows.Forms.DateTimePicker();
            this.tbMaKh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbSoGhe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbMaChuyenBay = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvDatCho = new System.Windows.Forms.DataGridView();
            this.soghe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.macb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoigiandi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.makhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dadatcho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatCho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Salmon;
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(345, 608);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(164, 60);
            this.btnThoat.TabIndex = 52;
            this.btnThoat.Text = "  Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Salmon;
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(39, 608);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(153, 60);
            this.btnXoa.TabIndex = 51;
            this.btnXoa.Text = "  Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Salmon;
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(345, 498);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(164, 60);
            this.btnSua.TabIndex = 50;
            this.btnSua.Text = "  Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 18);
            this.label4.TabIndex = 47;
            this.label4.Text = "Mã chuyến bay";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 46;
            this.label3.Text = "Ngày đi";
            // 
            // dtpNgayDi
            // 
            this.dtpNgayDi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDi.Location = new System.Drawing.Point(188, 175);
            this.dtpNgayDi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayDi.Name = "dtpNgayDi";
            this.dtpNgayDi.Size = new System.Drawing.Size(255, 24);
            this.dtpNgayDi.TabIndex = 45;
            // 
            // tbMaKh
            // 
            this.tbMaKh.Location = new System.Drawing.Point(188, 120);
            this.tbMaKh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMaKh.Name = "tbMaKh";
            this.tbMaKh.Size = new System.Drawing.Size(255, 24);
            this.tbMaKh.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 42;
            this.label2.Text = "Mã khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label1.Location = new System.Drawing.Point(556, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 41);
            this.label1.TabIndex = 41;
            this.label1.Text = "QUẢN LÝ ĐẶT CHỖ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::BTL_Nhom1_QLMB.Properties.Resources.aaa;
            this.groupBox1.Controls.Add(this.tbSoGhe);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbMaChuyenBay);
            this.groupBox1.Controls.Add(this.dtpNgayDi);
            this.groupBox1.Controls.Add(this.tbMaKh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(39, 137);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(495, 314);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đặt chỗ";
            // 
            // tbSoGhe
            // 
            this.tbSoGhe.Enabled = false;
            this.tbSoGhe.Location = new System.Drawing.Point(188, 57);
            this.tbSoGhe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSoGhe.Name = "tbSoGhe";
            this.tbSoGhe.Size = new System.Drawing.Size(255, 24);
            this.tbSoGhe.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 43;
            this.label5.Text = "Số ghế";
            // 
            // cbMaChuyenBay
            // 
            this.cbMaChuyenBay.FormattingEnabled = true;
            this.cbMaChuyenBay.Location = new System.Drawing.Point(188, 230);
            this.cbMaChuyenBay.Margin = new System.Windows.Forms.Padding(4);
            this.cbMaChuyenBay.Name = "cbMaChuyenBay";
            this.cbMaChuyenBay.Size = new System.Drawing.Size(255, 26);
            this.cbMaChuyenBay.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Salmon;
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(39, 498);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(153, 60);
            this.btnThem.TabIndex = 54;
            this.btnThem.Text = "  Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvDatCho
            // 
            this.dgvDatCho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatCho.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvDatCho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatCho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.soghe,
            this.makh,
            this.macb,
            this.thoigiandi});
            this.dgvDatCho.Location = new System.Drawing.Point(619, 353);
            this.dgvDatCho.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDatCho.Name = "dgvDatCho";
            this.dgvDatCho.RowHeadersWidth = 51;
            this.dgvDatCho.Size = new System.Drawing.Size(693, 305);
            this.dgvDatCho.TabIndex = 55;
            this.dgvDatCho.SelectionChanged += new System.EventHandler(this.dgvDatCho_SelectionChanged);
            // 
            // soghe
            // 
            this.soghe.DataPropertyName = "soghe";
            this.soghe.HeaderText = "Số ghế";
            this.soghe.MinimumWidth = 6;
            this.soghe.Name = "soghe";
            this.soghe.ReadOnly = true;
            // 
            // makh
            // 
            this.makh.DataPropertyName = "makh";
            this.makh.HeaderText = "Mã khách hàng";
            this.makh.MinimumWidth = 6;
            this.makh.Name = "makh";
            this.makh.ReadOnly = true;
            // 
            // macb
            // 
            this.macb.DataPropertyName = "macb";
            this.macb.HeaderText = "Mã chuyến bay";
            this.macb.MinimumWidth = 6;
            this.macb.Name = "macb";
            this.macb.ReadOnly = true;
            // 
            // thoigiandi
            // 
            this.thoigiandi.DataPropertyName = "thoigiandi";
            this.thoigiandi.HeaderText = "Ngày đi";
            this.thoigiandi.MinimumWidth = 6;
            this.thoigiandi.Name = "thoigiandi";
            this.thoigiandi.ReadOnly = true;
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachHang.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.makhach,
            this.dadatcho});
            this.dgvKhachHang.Location = new System.Drawing.Point(619, 143);
            this.dgvKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.Size = new System.Drawing.Size(693, 185);
            this.dgvKhachHang.TabIndex = 56;
            // 
            // makhach
            // 
            this.makhach.DataPropertyName = "makh";
            this.makhach.HeaderText = "Mã khách hàng";
            this.makhach.MinimumWidth = 6;
            this.makhach.Name = "makhach";
            this.makhach.ReadOnly = true;
            // 
            // dadatcho
            // 
            this.dadatcho.DataPropertyName = "dadatcho";
            this.dadatcho.HeaderText = "Trạng thái đặt chỗ";
            this.dadatcho.MinimumWidth = 6;
            this.dadatcho.Name = "dadatcho";
            this.dadatcho.ReadOnly = true;
            // 
            // form_qlDatCho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1404, 714);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.dgvDatCho);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_qlDatCho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Đặt Chỗ";
            this.Load += new System.EventHandler(this.form_qlDatCho_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatCho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNgayDi;
        private System.Windows.Forms.TextBox tbMaKh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbMaChuyenBay;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox tbSoGhe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvDatCho;
        private System.Windows.Forms.DataGridViewTextBoxColumn soghe;
        private System.Windows.Forms.DataGridViewTextBoxColumn makh;
        private System.Windows.Forms.DataGridViewTextBoxColumn macb;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoigiandi;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn makhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn dadatcho;
    }
}