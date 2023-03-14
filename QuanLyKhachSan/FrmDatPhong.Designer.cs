namespace QuanLyKhachSan
{
    partial class FrmDatPhong
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTongso = new System.Windows.Forms.Label();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ckbGhiChu = new System.Windows.Forms.CheckBox();
            this.btnHuyDatPhong = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpNgayNhan = new System.Windows.Forms.DateTimePicker();
            this.btnNhanPhong = new System.Windows.Forms.Button();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtSĐT = new System.Windows.Forms.TextBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.cboLoaiPhong = new System.Windows.Forms.ComboBox();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXoaTrang = new System.Windows.Forms.Button();
            this.btnKhongGhi = new System.Windows.Forms.Button();
            this.btnGhi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTimPhong = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayDat = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblTongso);
            this.panel3.Controls.Add(this.lblThongBao);
            this.panel3.Controls.Add(this.dgvPhong);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 358);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1057, 324);
            this.panel3.TabIndex = 5;
            // 
            // lblTongso
            // 
            this.lblTongso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTongso.AutoSize = true;
            this.lblTongso.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTongso.Location = new System.Drawing.Point(489, 14);
            this.lblTongso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongso.Name = "lblTongso";
            this.lblTongso.Size = new System.Drawing.Size(63, 16);
            this.lblTongso.TabIndex = 18;
            this.lblTongso.Text = "Tổng số :";
            // 
            // lblThongBao
            // 
            this.lblThongBao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblThongBao.Location = new System.Drawing.Point(72, 14);
            this.lblThongBao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(79, 16);
            this.lblThongBao.TabIndex = 17;
            this.lblThongBao.Text = "Thông báo :";
            // 
            // dgvPhong
            // 
            this.dgvPhong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenPhong,
            this.LoaiPhong,
            this.GiaPhong,
            this.MoTa,
            this.Status,
            this.MaPhong});
            this.dgvPhong.Location = new System.Drawing.Point(0, 68);
            this.dgvPhong.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.RowHeadersWidth = 51;
            this.dgvPhong.Size = new System.Drawing.Size(1057, 256);
            this.dgvPhong.TabIndex = 16;
            this.dgvPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoom_CellClick);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "colOrderNumber";
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 50;
            // 
            // TenPhong
            // 
            this.TenPhong.DataPropertyName = "TenPhong";
            this.TenPhong.HeaderText = "Tên Phòng";
            this.TenPhong.MinimumWidth = 6;
            this.TenPhong.Name = "TenPhong";
            this.TenPhong.Width = 125;
            // 
            // LoaiPhong
            // 
            this.LoaiPhong.DataPropertyName = "LoaiPhong";
            this.LoaiPhong.HeaderText = "Loại Phòng";
            this.LoaiPhong.MinimumWidth = 6;
            this.LoaiPhong.Name = "LoaiPhong";
            this.LoaiPhong.Width = 125;
            // 
            // GiaPhong
            // 
            this.GiaPhong.DataPropertyName = "GiaPhong";
            this.GiaPhong.HeaderText = "Giá Phòng";
            this.GiaPhong.MinimumWidth = 6;
            this.GiaPhong.Name = "GiaPhong";
            this.GiaPhong.Width = 125;
            // 
            // MoTa
            // 
            this.MoTa.DataPropertyName = "MoTa";
            this.MoTa.HeaderText = "Ghi chú ";
            this.MoTa.MinimumWidth = 6;
            this.MoTa.Name = "MoTa";
            this.MoTa.Width = 300;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "TrangThai";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Visible = false;
            this.Status.Width = 125;
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "MaPhong";
            this.MaPhong.MinimumWidth = 6;
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.Visible = false;
            this.MaPhong.Width = 125;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ckbGhiChu);
            this.panel2.Controls.Add(this.btnHuyDatPhong);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.dtpNgayNhan);
            this.panel2.Controls.Add(this.btnNhanPhong);
            this.panel2.Controls.Add(this.txtMaPhong);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.txtSĐT);
            this.panel2.Controls.Add(this.txtThanhTien);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btnKetThuc);
            this.panel2.Controls.Add(this.cboLoaiPhong);
            this.panel2.Controls.Add(this.txtTenKhachHang);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnXoaTrang);
            this.panel2.Controls.Add(this.btnKhongGhi);
            this.panel2.Controls.Add(this.btnGhi);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnDatPhong);
            this.panel2.Controls.Add(this.txtTenPhong);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnTimPhong);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dtpNgayTra);
            this.panel2.Controls.Add(this.dtpNgayDat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 68);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1057, 290);
            this.panel2.TabIndex = 4;
            // 
            // ckbGhiChu
            // 
            this.ckbGhiChu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ckbGhiChu.AutoSize = true;
            this.ckbGhiChu.Location = new System.Drawing.Point(527, 214);
            this.ckbGhiChu.Name = "ckbGhiChu";
            this.ckbGhiChu.Size = new System.Drawing.Size(75, 20);
            this.ckbGhiChu.TabIndex = 99;
            this.ckbGhiChu.Text = "Ghi Chú";
            this.ckbGhiChu.UseVisualStyleBackColor = true;
            // 
            // btnHuyDatPhong
            // 
            this.btnHuyDatPhong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHuyDatPhong.Location = new System.Drawing.Point(789, 189);
            this.btnHuyDatPhong.Name = "btnHuyDatPhong";
            this.btnHuyDatPhong.Size = new System.Drawing.Size(143, 43);
            this.btnHuyDatPhong.TabIndex = 96;
            this.btnHuyDatPhong.Text = "Hủy Đặt Phòng";
            this.btnHuyDatPhong.UseVisualStyleBackColor = true;
            this.btnHuyDatPhong.Click += new System.EventHandler(this.btnHuyDatPhong_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(128, 218);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 16);
            this.label10.TabIndex = 95;
            this.label10.Text = "Ngày Nhận :";
            // 
            // dtpNgayNhan
            // 
            this.dtpNgayNhan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpNgayNhan.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpNgayNhan.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayNhan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayNhan.Location = new System.Drawing.Point(256, 212);
            this.dtpNgayNhan.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayNhan.Name = "dtpNgayNhan";
            this.dtpNgayNhan.Size = new System.Drawing.Size(160, 22);
            this.dtpNgayNhan.TabIndex = 94;
            // 
            // btnNhanPhong
            // 
            this.btnNhanPhong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNhanPhong.Location = new System.Drawing.Point(789, 139);
            this.btnNhanPhong.Name = "btnNhanPhong";
            this.btnNhanPhong.Size = new System.Drawing.Size(143, 44);
            this.btnNhanPhong.TabIndex = 93;
            this.btnNhanPhong.Text = "Nhận Phòng";
            this.btnNhanPhong.UseVisualStyleBackColor = true;
            this.btnNhanPhong.Click += new System.EventHandler(this.btnNhanPhong_Click);
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaPhong.Location = new System.Drawing.Point(611, 161);
            this.txtMaPhong.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(160, 22);
            this.txtMaPhong.TabIndex = 92;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(521, 161);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 91;
            this.label7.Text = "Mã phòng :";
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.Location = new System.Drawing.Point(136, 254);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 28);
            this.btnThem.TabIndex = 90;
            this.btnThem.Text = "Thêm Phòng";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSĐT
            // 
            this.txtSĐT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSĐT.Location = new System.Drawing.Point(611, 66);
            this.txtSĐT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSĐT.Name = "txtSĐT";
            this.txtSĐT.Size = new System.Drawing.Size(160, 22);
            this.txtSĐT.TabIndex = 89;
            this.txtSĐT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSĐT_KeyPress);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtThanhTien.Location = new System.Drawing.Point(611, 111);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(160, 22);
            this.txtThanhTien.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(519, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 84;
            this.label1.Text = "Đơn giá :";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(524, 75);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 16);
            this.label9.TabIndex = 88;
            this.label9.Text = "SĐT : ";
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnKetThuc.Location = new System.Drawing.Point(784, 254);
            this.btnKetThuc.Margin = new System.Windows.Forms.Padding(4);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(100, 28);
            this.btnKetThuc.TabIndex = 83;
            this.btnKetThuc.Text = "Kết Thúc";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            this.btnKetThuc.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // cboLoaiPhong
            // 
            this.cboLoaiPhong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiPhong.FormattingEnabled = true;
            this.cboLoaiPhong.Items.AddRange(new object[] {
            "Ðơn",
            "Đôi",
            "Tất cả"});
            this.cboLoaiPhong.Location = new System.Drawing.Point(256, 158);
            this.cboLoaiPhong.Margin = new System.Windows.Forms.Padding(4);
            this.cboLoaiPhong.Name = "cboLoaiPhong";
            this.cboLoaiPhong.Size = new System.Drawing.Size(160, 24);
            this.cboLoaiPhong.TabIndex = 71;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenKhachHang.Location = new System.Drawing.Point(256, 68);
            this.txtTenKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(160, 22);
            this.txtTenKhachHang.TabIndex = 87;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(125, 77);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 16);
            this.label8.TabIndex = 86;
            this.label8.Text = "Tên khách hàng :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 72;
            this.label3.Text = "Loại phòng:";
            // 
            // btnXoaTrang
            // 
            this.btnXoaTrang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoaTrang.Location = new System.Drawing.Point(676, 255);
            this.btnXoaTrang.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaTrang.Name = "btnXoaTrang";
            this.btnXoaTrang.Size = new System.Drawing.Size(100, 28);
            this.btnXoaTrang.TabIndex = 82;
            this.btnXoaTrang.Text = "Xóa Trắng";
            this.btnXoaTrang.UseVisualStyleBackColor = true;
            this.btnXoaTrang.Click += new System.EventHandler(this.btnBlank_Click);
            // 
            // btnKhongGhi
            // 
            this.btnKhongGhi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnKhongGhi.Location = new System.Drawing.Point(568, 255);
            this.btnKhongGhi.Margin = new System.Windows.Forms.Padding(4);
            this.btnKhongGhi.Name = "btnKhongGhi";
            this.btnKhongGhi.Size = new System.Drawing.Size(100, 28);
            this.btnKhongGhi.TabIndex = 81;
            this.btnKhongGhi.Text = "Không Ghi";
            this.btnKhongGhi.UseVisualStyleBackColor = true;
            this.btnKhongGhi.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnGhi
            // 
            this.btnGhi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGhi.Location = new System.Drawing.Point(460, 255);
            this.btnGhi.Margin = new System.Windows.Forms.Padding(4);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(100, 28);
            this.btnGhi.TabIndex = 80;
            this.btnGhi.Text = "Ghi";
            this.btnGhi.UseVisualStyleBackColor = true;
            this.btnGhi.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.Location = new System.Drawing.Point(352, 254);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 28);
            this.btnXoa.TabIndex = 79;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.Location = new System.Drawing.Point(244, 254);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 28);
            this.btnSua.TabIndex = 78;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDatPhong.Location = new System.Drawing.Point(789, 84);
            this.btnDatPhong.Margin = new System.Windows.Forms.Padding(4);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(143, 47);
            this.btnDatPhong.TabIndex = 77;
            this.btnDatPhong.Text = "Đặt Phòng";
            this.btnDatPhong.UseVisualStyleBackColor = true;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenPhong.Location = new System.Drawing.Point(256, 112);
            this.txtTenPhong.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(160, 22);
            this.txtTenPhong.TabIndex = 76;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 116);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 75;
            this.label6.Text = "Tên phòng :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(521, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 74;
            this.label5.Text = "Ngày Trả :";
            // 
            // btnTimPhong
            // 
            this.btnTimPhong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTimPhong.Location = new System.Drawing.Point(789, 21);
            this.btnTimPhong.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimPhong.Name = "btnTimPhong";
            this.btnTimPhong.Size = new System.Drawing.Size(143, 52);
            this.btnTimPhong.TabIndex = 73;
            this.btnTimPhong.Text = "Tìm Phòng";
            this.btnTimPhong.UseVisualStyleBackColor = true;
            this.btnTimPhong.Click += new System.EventHandler(this.btnTimPhong_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 70;
            this.label2.Text = "Ngày Đặt :";
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpNgayTra.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTra.Location = new System.Drawing.Point(611, 21);
            this.dtpNgayTra.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(160, 22);
            this.dtpNgayTra.TabIndex = 69;
            // 
            // dtpNgayDat
            // 
            this.dtpNgayDat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpNgayDat.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayDat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDat.Location = new System.Drawing.Point(256, 22);
            this.dtpNgayDat.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayDat.Name = "dtpNgayDat";
            this.dtpNgayDat.Size = new System.Drawing.Size(160, 22);
            this.dtpNgayDat.TabIndex = 68;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 68);
            this.panel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(432, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "Thuê Phòng";
            // 
            // FrmDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 700);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDatPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thuê Phòng Khách Sạn ";
            this.Load += new System.EventHandler(this.frmDatPhong_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTongso;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtSĐT;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.ComboBox cboLoaiPhong;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXoaTrang;
        private System.Windows.Forms.Button btnKhongGhi;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTimPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.DateTimePicker dtpNgayDat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNhanPhong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpNgayNhan;
        private System.Windows.Forms.Button btnHuyDatPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.CheckBox ckbGhiChu;
    }
}