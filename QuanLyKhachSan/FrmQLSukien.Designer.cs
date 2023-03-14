namespace QuanLyKhachSan
{
    partial class FrmQLSukien
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
            this.cbo2 = new System.Windows.Forms.ComboBox();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDatphong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayVao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayRa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatphong)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo2
            // 
            this.cbo2.FormattingEnabled = true;
            this.cbo2.Items.AddRange(new object[] {
            "Phòng Họp",
            "Phòng Cưới"});
            this.cbo2.Location = new System.Drawing.Point(104, 306);
            this.cbo2.Margin = new System.Windows.Forms.Padding(2);
            this.cbo2.Name = "cbo2";
            this.cbo2.Size = new System.Drawing.Size(159, 21);
            this.cbo2.TabIndex = 39;
            // 
            // dtp1
            // 
            this.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp1.Location = new System.Drawing.Point(470, 275);
            this.dtp1.Margin = new System.Windows.Forms.Padding(2);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(160, 20);
            this.dtp1.TabIndex = 38;
            // 
            // dtp2
            // 
            this.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp2.Location = new System.Drawing.Point(104, 341);
            this.dtp2.Margin = new System.Windows.Forms.Padding(2);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(159, 20);
            this.dtp2.TabIndex = 37;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(472, 309);
            this.txt2.Margin = new System.Windows.Forms.Padding(2);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(158, 20);
            this.txt2.TabIndex = 35;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(104, 276);
            this.txt1.Margin = new System.Windows.Forms.Padding(2);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(159, 20);
            this.txt1.TabIndex = 34;
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(562, 390);
            this.btn6.Margin = new System.Windows.Forms.Padding(2);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(59, 26);
            this.btn6.TabIndex = 33;
            this.btn6.Text = "Kết Thúc";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(493, 390);
            this.btn4.Margin = new System.Windows.Forms.Padding(2);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(65, 26);
            this.btn4.TabIndex = 31;
            this.btn4.Text = "Ghi";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(428, 390);
            this.btn3.Margin = new System.Windows.Forms.Padding(2);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(61, 26);
            this.btn3.TabIndex = 30;
            this.btn3.Text = "Xóa";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(359, 390);
            this.btn2.Margin = new System.Windows.Forms.Padding(2);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(65, 26);
            this.btn2.TabIndex = 29;
            this.btn2.Text = "Sửa";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(285, 390);
            this.btn1.Margin = new System.Windows.Forms.Padding(2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(66, 25);
            this.btn1.TabIndex = 28;
            this.btn1.Text = "Thêm";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(417, 308);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "SĐT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(417, 275);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Ngày Trả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 344);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Ngày Đặt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 309);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Loại Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 275);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Họ Tên";
            // 
            // dgvDatphong
            // 
            this.dgvDatphong.AllowUserToAddRows = false;
            this.dgvDatphong.AllowUserToDeleteRows = false;
            this.dgvDatphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatphong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenKhachHang,
            this.LoaiPhong,
            this.NgayVao,
            this.NgayRa,
            this.SoDienThoai});
            this.dgvDatphong.Location = new System.Drawing.Point(34, 44);
            this.dgvDatphong.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDatphong.Name = "dgvDatphong";
            this.dgvDatphong.ReadOnly = true;
            this.dgvDatphong.RowHeadersWidth = 51;
            this.dgvDatphong.RowTemplate.Height = 24;
            this.dgvDatphong.Size = new System.Drawing.Size(596, 214);
            this.dgvDatphong.TabIndex = 21;
            this.dgvDatphong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatphong_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 36);
            this.label1.TabIndex = 20;
            this.label1.Text = "Quản Lý Đặt Phòng Sự Kiện \r\n\r\n";
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.DataPropertyName = "TenKhachHang";
            this.TenKhachHang.HeaderText = "Họ Tên";
            this.TenKhachHang.MinimumWidth = 6;
            this.TenKhachHang.Name = "TenKhachHang";
            this.TenKhachHang.ReadOnly = true;
            this.TenKhachHang.Width = 80;
            // 
            // LoaiPhong
            // 
            this.LoaiPhong.DataPropertyName = "LoaiPhong";
            this.LoaiPhong.HeaderText = "Loại Phòng";
            this.LoaiPhong.MinimumWidth = 6;
            this.LoaiPhong.Name = "LoaiPhong";
            this.LoaiPhong.ReadOnly = true;
            this.LoaiPhong.Width = 90;
            // 
            // NgayVao
            // 
            this.NgayVao.DataPropertyName = "NgayVao";
            this.NgayVao.HeaderText = "Ngày Đặt ";
            this.NgayVao.MinimumWidth = 6;
            this.NgayVao.Name = "NgayVao";
            this.NgayVao.ReadOnly = true;
            // 
            // NgayRa
            // 
            this.NgayRa.DataPropertyName = "NgayRa";
            this.NgayRa.HeaderText = "Ngày Trả";
            this.NgayRa.MinimumWidth = 6;
            this.NgayRa.Name = "NgayRa";
            this.NgayRa.ReadOnly = true;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.DataPropertyName = "SoDienThoai";
            this.SoDienThoai.HeaderText = "Số Điện Thoại";
            this.SoDienThoai.MinimumWidth = 6;
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.ReadOnly = true;
            this.SoDienThoai.Width = 110;
            // 
            // FrmQLSukien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 436);
            this.Controls.Add(this.cbo2);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.dtp2);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDatphong);
            this.Controls.Add(this.label1);
            this.Name = "FrmQLSukien";
            this.Text = "Sự kiện";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatphong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo2;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDatphong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayVao;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayRa;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
    }
}