namespace QuanLyKhachSan
{
    partial class FrmTraPhong
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
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtRoomID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtSĐT = new System.Windows.Forms.TextBox();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCheckRoom = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cboRoomType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnReturnRoom = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnBlank = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTongso = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.dgvRoom = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.colOrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayRa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHopDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtRoomName);
            this.panel3.Controls.Add(this.btnPay);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtID);
            this.panel3.Controls.Add(this.txtRoomID);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.txtCustomerName);
            this.panel3.Controls.Add(this.txtSĐT);
            this.panel3.Controls.Add(this.dtpCheckIn);
            this.panel3.Controls.Add(this.txtPrice);
            this.panel3.Controls.Add(this.dtpCheckOut);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.btnCheckRoom);
            this.panel3.Controls.Add(this.btnEnd);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.cboRoomType);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.btnReturnRoom);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnEdit);
            this.panel3.Controls.Add(this.btnBlank);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnUndo);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 401);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1039, 279);
            this.panel3.TabIndex = 5;
            // 
            // txtRoomName
            // 
            this.txtRoomName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRoomName.Location = new System.Drawing.Point(235, 121);
            this.txtRoomName.Margin = new System.Windows.Forms.Padding(4);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(160, 22);
            this.txtRoomName.TabIndex = 167;
            // 
            // btnPay
            // 
            this.btnPay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPay.Location = new System.Drawing.Point(779, 142);
            this.btnPay.Margin = new System.Windows.Forms.Padding(4);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(143, 47);
            this.btnPay.TabIndex = 166;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click_1);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(109, 207);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 16);
            this.label10.TabIndex = 165;
            this.label10.Text = "Mã khách hàng :";
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtID.Location = new System.Drawing.Point(235, 203);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(160, 22);
            this.txtID.TabIndex = 164;
            // 
            // txtRoomID
            // 
            this.txtRoomID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRoomID.Location = new System.Drawing.Point(589, 162);
            this.txtRoomID.Margin = new System.Windows.Forms.Padding(4);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.Size = new System.Drawing.Size(160, 22);
            this.txtRoomID.TabIndex = 163;
            this.txtRoomID.Text = " ";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(497, 162);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 162;
            this.label7.Text = "Mã phòng :";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.Location = new System.Drawing.Point(123, 236);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 161;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCustomerName.Location = new System.Drawing.Point(235, 73);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(160, 22);
            this.txtCustomerName.TabIndex = 158;
            // 
            // txtSĐT
            // 
            this.txtSĐT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSĐT.Location = new System.Drawing.Point(589, 71);
            this.txtSĐT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSĐT.Name = "txtSĐT";
            this.txtSĐT.Size = new System.Drawing.Size(160, 22);
            this.txtSĐT.TabIndex = 160;
            this.txtSĐT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSĐT_KeyPress);
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckIn.Location = new System.Drawing.Point(235, 27);
            this.dtpCheckIn.Margin = new System.Windows.Forms.Padding(4);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(160, 22);
            this.dtpCheckIn.TabIndex = 139;
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPrice.Location = new System.Drawing.Point(589, 116);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(160, 22);
            this.txtPrice.TabIndex = 156;
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckOut.Location = new System.Drawing.Point(589, 26);
            this.dtpCheckOut.Margin = new System.Windows.Forms.Padding(4);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(160, 22);
            this.dtpCheckOut.TabIndex = 140;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(497, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 155;
            this.label1.Text = "Thành tiền :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 141;
            this.label2.Text = "Ngày Nhận :";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(497, 79);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 16);
            this.label9.TabIndex = 159;
            this.label9.Text = "SĐT : ";
            // 
            // btnCheckRoom
            // 
            this.btnCheckRoom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCheckRoom.Location = new System.Drawing.Point(779, 26);
            this.btnCheckRoom.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckRoom.Name = "btnCheckRoom";
            this.btnCheckRoom.Size = new System.Drawing.Size(143, 52);
            this.btnCheckRoom.TabIndex = 144;
            this.btnCheckRoom.Text = "Tìm Phòng";
            this.btnCheckRoom.UseVisualStyleBackColor = true;
            this.btnCheckRoom.Click += new System.EventHandler(this.btnCheckRoom_Click_1);
            // 
            // btnEnd
            // 
            this.btnEnd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEnd.Location = new System.Drawing.Point(769, 236);
            this.btnEnd.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(100, 28);
            this.btnEnd.TabIndex = 154;
            this.btnEnd.Text = "Kết thúc";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click_1);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(497, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 145;
            this.label5.Text = "Ngày Trả :";
            // 
            // cboRoomType
            // 
            this.cboRoomType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboRoomType.FormattingEnabled = true;
            this.cboRoomType.Items.AddRange(new object[] {
            "Đơn",
            "Đôi"});
            this.cboRoomType.Location = new System.Drawing.Point(235, 162);
            this.cboRoomType.Margin = new System.Windows.Forms.Padding(4);
            this.cboRoomType.Name = "cboRoomType";
            this.cboRoomType.Size = new System.Drawing.Size(160, 24);
            this.cboRoomType.TabIndex = 142;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 121);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 146;
            this.label6.Text = "Tên phòng :";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(107, 80);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 16);
            this.label8.TabIndex = 157;
            this.label8.Text = "Tên khách hàng :";
            // 
            // btnReturnRoom
            // 
            this.btnReturnRoom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReturnRoom.Location = new System.Drawing.Point(779, 86);
            this.btnReturnRoom.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturnRoom.Name = "btnReturnRoom";
            this.btnReturnRoom.Size = new System.Drawing.Size(143, 47);
            this.btnReturnRoom.TabIndex = 148;
            this.btnReturnRoom.Text = "Trả phòng";
            this.btnReturnRoom.UseVisualStyleBackColor = true;
            this.btnReturnRoom.Click += new System.EventHandler(this.btnReturnRoom_Click_1);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 143;
            this.label3.Text = "Loại phòng:";
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEdit.Location = new System.Drawing.Point(229, 235);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 28);
            this.btnEdit.TabIndex = 149;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // btnBlank
            // 
            this.btnBlank.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBlank.Location = new System.Drawing.Point(661, 236);
            this.btnBlank.Margin = new System.Windows.Forms.Padding(4);
            this.btnBlank.Name = "btnBlank";
            this.btnBlank.Size = new System.Drawing.Size(100, 28);
            this.btnBlank.TabIndex = 153;
            this.btnBlank.Text = "Xóa trắng";
            this.btnBlank.UseVisualStyleBackColor = true;
            this.btnBlank.Click += new System.EventHandler(this.btnBlank_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.Location = new System.Drawing.Point(337, 235);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 150;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnUndo
            // 
            this.btnUndo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUndo.Location = new System.Drawing.Point(553, 236);
            this.btnUndo.Margin = new System.Windows.Forms.Padding(4);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(100, 28);
            this.btnUndo.TabIndex = 152;
            this.btnUndo.Text = "Không Ghi";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.Location = new System.Drawing.Point(445, 236);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 151;
            this.btnSave.Text = "Ghi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTongso);
            this.panel2.Controls.Add(this.lblError);
            this.panel2.Controls.Add(this.dgvRoom);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1039, 321);
            this.panel2.TabIndex = 4;
            // 
            // lblTongso
            // 
            this.lblTongso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTongso.AutoSize = true;
            this.lblTongso.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTongso.Location = new System.Drawing.Point(800, 7);
            this.lblTongso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongso.Name = "lblTongso";
            this.lblTongso.Size = new System.Drawing.Size(63, 16);
            this.lblTongso.TabIndex = 27;
            this.lblTongso.Text = "Tổng số :";
            // 
            // lblError
            // 
            this.lblError.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblError.Location = new System.Drawing.Point(81, 7);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(79, 16);
            this.lblError.TabIndex = 26;
            this.lblError.Text = "Thông báo :";
            // 
            // dgvRoom
            // 
            this.dgvRoom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrderNumber,
            this.TenKhachHang,
            this.SoDienThoai,
            this.NgayNhan,
            this.NgayRa,
            this.TenPhong,
            this.MaHopDong,
            this.MaPhong,
            this.GiaPhong,
            this.LoaiPhong});
            this.dgvRoom.Location = new System.Drawing.Point(0, 66);
            this.dgvRoom.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRoom.Name = "dgvRoom";
            this.dgvRoom.RowHeadersWidth = 51;
            this.dgvRoom.Size = new System.Drawing.Size(1039, 255);
            this.dgvRoom.TabIndex = 25;
            this.dgvRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoom_CellClick_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 80);
            this.panel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(448, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "Trả Phòng";
            // 
            // colOrderNumber
            // 
            this.colOrderNumber.DataPropertyName = "colOrderNumber";
            this.colOrderNumber.HeaderText = "STT";
            this.colOrderNumber.MinimumWidth = 6;
            this.colOrderNumber.Name = "colOrderNumber";
            this.colOrderNumber.Width = 50;
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.DataPropertyName = "TenKhachHang";
            this.TenKhachHang.HeaderText = "Tên khách hàng";
            this.TenKhachHang.MinimumWidth = 6;
            this.TenKhachHang.Name = "TenKhachHang";
            this.TenKhachHang.Width = 125;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.DataPropertyName = "SoDienThoai";
            this.SoDienThoai.HeaderText = "SĐT";
            this.SoDienThoai.MinimumWidth = 6;
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.Width = 125;
            // 
            // NgayNhan
            // 
            this.NgayNhan.DataPropertyName = "NgayNhan";
            this.NgayNhan.HeaderText = "Ngày Nhận";
            this.NgayNhan.MinimumWidth = 6;
            this.NgayNhan.Name = "NgayNhan";
            this.NgayNhan.Width = 125;
            // 
            // NgayRa
            // 
            this.NgayRa.DataPropertyName = "NgayRa";
            this.NgayRa.HeaderText = "Ngày Trả";
            this.NgayRa.MinimumWidth = 6;
            this.NgayRa.Name = "NgayRa";
            this.NgayRa.Width = 125;
            // 
            // TenPhong
            // 
            this.TenPhong.DataPropertyName = "TenPhong";
            this.TenPhong.HeaderText = "Tên Phòng";
            this.TenPhong.MinimumWidth = 6;
            this.TenPhong.Name = "TenPhong";
            this.TenPhong.Width = 50;
            // 
            // MaHopDong
            // 
            this.MaHopDong.DataPropertyName = "MaHopDong";
            this.MaHopDong.HeaderText = "ID";
            this.MaHopDong.MinimumWidth = 6;
            this.MaHopDong.Name = "MaHopDong";
            this.MaHopDong.Visible = false;
            this.MaHopDong.Width = 125;
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "RoomID";
            this.MaPhong.MinimumWidth = 6;
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.Visible = false;
            this.MaPhong.Width = 125;
            // 
            // GiaPhong
            // 
            this.GiaPhong.DataPropertyName = "GiaPhong";
            this.GiaPhong.HeaderText = "Giá Phòng";
            this.GiaPhong.MinimumWidth = 6;
            this.GiaPhong.Name = "GiaPhong";
            this.GiaPhong.Width = 125;
            // 
            // LoaiPhong
            // 
            this.LoaiPhong.DataPropertyName = "LoaiPhong";
            this.LoaiPhong.HeaderText = "Loại Phòng";
            this.LoaiPhong.MinimumWidth = 6;
            this.LoaiPhong.Name = "LoaiPhong";
            this.LoaiPhong.Width = 50;
            // 
            // FrmTraPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 710);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmTraPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trả Phòng Khách Sạn ";
            this.Load += new System.EventHandler(this.FrmTraPhong_Load_1);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtRoomID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtSĐT;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCheckRoom;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboRoomType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnReturnRoom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnBlank;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTongso;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.DataGridView dgvRoom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayRa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHopDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiPhong;
    }
}