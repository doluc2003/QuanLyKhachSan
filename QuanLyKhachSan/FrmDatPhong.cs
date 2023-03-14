using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class FrmDatPhong : Form
    {
        #region Variable
        public string connectionString = ConfigurationManager.AppSettings["connectionString"];
        SqlConnection conn;
        DataSet ds;
        string trangThai;
        
        #endregion
        public FrmDatPhong()
        {
            InitializeComponent();
            ckbGhiChu.Enabled = false;

        }
        #region Public Functions

        bool ktratrung()
        {
            // khai báo SqlConnection
            conn = new SqlConnection(connectionString);
            //Mở kết nối 
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            //Khai báo câu truy vấn 
            string sql = "Select * from tbl_Phong where MaPhong = '" + txtMaPhong.Text + "'";

            //Khai báo SqlCommand, SqlDataAdapter
            SqlCommand command = new SqlCommand(sql, conn);

            SqlDataAdapter da = new SqlDataAdapter(command);
            //Khai báo Dataset
            ds = new DataSet();
            //fill dữ liệu 
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {

                return true;
            }
            else return false;
        }
        void setTrangThai(string trangThai)
        {
            if (trangThai == "macdinh")
            {
                lblThongBao.Text = "";

                //txtMatKhau.Enabled = false;
                //txtTenDangNhap.Enabled = false;
                //txtManv.Enabled = false;
                //cboQuyenTruyCap.Enabled = false;
                txtTenKhachHang.Enabled = true;
                txtThanhTien.Enabled = true;
                txtTenPhong.Enabled = true;
                txtSĐT.Enabled = true;
                dtpNgayDat.Enabled = true;
                dtpNgayTra.Enabled = true;
                dtpNgayNhan.Enabled = false;
                txtMaPhong.Enabled = true;

                btnHuyDatPhong.Enabled = false;
                btnNhanPhong.Enabled = true;
                btnGhi.Enabled = false;
                btnTimPhong.Enabled = true;
                btnDatPhong.Enabled = true;
                btnKhongGhi.Enabled = false;
                btnSua.Enabled = true;
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnXoaTrang.Enabled = true;

            }
            else if (trangThai == "them")
            {
                txtTenPhong.Text = "";
                txtThanhTien.Text = "";
                txtTenKhachHang.Text = "";
                txtSĐT.Text = "";
                cboLoaiPhong.SelectedIndex = 0;
                txtMaPhong.Text = "";

                txtThanhTien.Enabled = true;
                txtTenPhong.Enabled = true;
                txtTenKhachHang.Enabled = false;
                txtSĐT.Enabled = false;
                dtpNgayDat.Enabled = false;
                dtpNgayTra.Enabled = false;
                dtpNgayNhan.Enabled=false;
                txtMaPhong.Enabled = true;

                btnTimPhong.Enabled = false;
                btnHuyDatPhong.Enabled = false;
                btnNhanPhong.Enabled = false;
                btnDatPhong.Enabled = false;
                btnGhi.Enabled = true;
                btnKhongGhi.Enabled = true;
                btnSua.Enabled = false;
                btnThem.Enabled = false;
                btnXoa.Enabled = false;

            }
            else if (trangThai == "sua")
            {

                txtTenKhachHang.Enabled = true;
                txtSĐT.Enabled = true;
                dtpNgayDat.Enabled = false;
                dtpNgayTra.Enabled = false;
                dtpNgayNhan.Enabled = false;

                btnHuyDatPhong.Enabled=true;
                btnNhanPhong.Enabled=false; 
                btnTimPhong.Enabled = true;
                btnDatPhong.Enabled = false;
                btnGhi.Enabled = true;
                btnKhongGhi.Enabled = true;
                btnSua.Enabled = false;
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
            }
            
        }
        private void GetData()
        {
            try
            {
                // khai báo SqlConnection
                conn = new SqlConnection(connectionString);

                //Mở kết nối 
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                //Khai báo câu truy vấn 
                string query = "SELECT * FROM tbl_Phong B WHERE B.TrangThai = '0' ";

                //Khai báo SqlCommand, SqlDataAdapter
                SqlCommand command = new SqlCommand(query, conn);
                //command.CommandType = CommandType.TableDirect;
                //command.Parameters.AddWithValue("@Status", "1");

                SqlDataAdapter da = new SqlDataAdapter(command);
                //Khai báo Dataset
                ds = new DataSet();
                //fill dữ liệu 
                da.Fill(ds);

                DataColumn colOrderNumber = new DataColumn();
                colOrderNumber.ColumnName = "colOrderNumber";
                ds.Tables[0].Columns.Add(colOrderNumber);


                int icount = 1;
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dr["colOrderNumber"] = icount.ToString();
                    icount++;


                }
                lblTongso.Text = "Tổng số phòng : " + ds.Tables[0].Rows.Count;

                dgvPhong.AutoGenerateColumns = false;
                dgvPhong.DataSource = ds.Tables[0];
            }

            catch (Exception ex)
            {

                lblThongBao.Text = "Error: " + ex.Message;
            }
            finally
            {
                conn.Dispose();
            }
        }
        private void GetRoom()
        {
            try
            {
                // khai báo SqlConnection
                conn = new SqlConnection(connectionString);

                //Mở kết nối 
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                //Khai báo câu truy vấn 
                string query = "";

                if (txtThanhTien.Text != "")
                {
                    query = "SELECT * FROM tbl_Phong B WHERE B.TrangThai='0' AND B.GiaPhong LIKE N'%" + txtThanhTien.Text + "%'";
                }
                if (cboLoaiPhong.Text != "")
                {
                    query = "SELECT * FROM tbl_Phong B WHERE B.TrangThai='0' AND B.LoaiPhong = N'" + cboLoaiPhong.Text + "'";
                }
                if (txtTenPhong.Text != "")
                {
                    query = "SELECT * FROM tbl_Phong B WHERE B.TrangThai='0' AND B.TenPhong LIKE N'%" + txtTenPhong.Text + "%'";
                }
                if(txtThanhTien.Text !=""&& cboLoaiPhong.Text != "")
                {
                    query = "SELECT * FROM tbl_Phong B WHERE B.TrangThai='0' AND B.LoaiPhong = N'" + cboLoaiPhong.Text + "' AND B.GiaPhong LIKE N'%" + txtThanhTien.Text + "%'";
                }
                if (txtThanhTien.Text != "" && txtTenPhong.Text != "")
                {
                    query = "SELECT * FROM tbl_Phong B WHERE B.TrangThai='0' AND B.GiaPhong LIKE N'%" + txtThanhTien.Text + "%' AND B.TenPhong LIKE N'%" + txtTenPhong.Text + "%'";
                }
                if (cboLoaiPhong.Text != "" && txtTenPhong.Text != "")
                {
                    query = "SELECT * FROM tbl_Phong B WHERE B.TrangThai='0' AND B.LoaiPhong = N'" + cboLoaiPhong.Text + "' AND B.TenPhong LIKE N'%" + txtTenPhong.Text + "%'";
                }

                //query = "SELECT * FROM tbl_Rent A, tbl_Phong B WHERE A.RoomID = B.ID AND A.CheckIn >= '" + dtpNgayDat.Text + "' AND A.Checkout <= '" + dtpNgayTra.Text + "' and B.LoaiPhong = N'" + cboRoomType.SelectedItem + "'";
                if (cboLoaiPhong.Text == "Tất cả" && txtThanhTien.Text == "" && txtTenPhong.Text == "")
                    query = "SELECT * FROM tbl_Phong B WHERE B.TrangThai='0' ";
                //Khai báo SqlCommand, SqlDataAdapter
                SqlCommand command = new SqlCommand(query, conn);
                //command.CommandType = CommandType.TableDirect;
                //command.Parameters.AddWithValue("@Status", "1");

                SqlDataAdapter da = new SqlDataAdapter(command);
                //Khai báo Dataset
                ds = new DataSet();
                //fill dữ liệu 
                da.Fill(ds);
                DataColumn colOrderNumber = new DataColumn();
                colOrderNumber.ColumnName = "colOrderNumber";
                ds.Tables[0].Columns.Add(colOrderNumber);


                int icount = 1;
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dr["colOrderNumber"] = icount.ToString();
                    icount++;


                }

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dgvPhong.DataSource = ds.Tables[0];
                }
                lblTongso.Text = "Tổng số : " + ds.Tables[0].Rows.Count + " phòng ";
            }

            catch (Exception ex)
            {

                lblThongBao.Text = "Error: " + ex.Message;
            }
            finally
            {
                conn.Dispose();
            }
        }
        #endregion

        #region Events
        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnBlank_Click(object sender, EventArgs e)
        {
            cboLoaiPhong.Text = "";
            txtThanhTien.Text = "";
            txtTenKhachHang.Text = "";
            txtSĐT.Text = "";
            txtTenPhong.Text = "";
            txtMaPhong.Text = "";
            dtpNgayDat.Value = DateTime.Now;
            dtpNgayTra.Value = DateTime.Now;
            dtpNgayNhan.Value= DateTime.Now;
            cboLoaiPhong.Items.Clear();
        }
        private void btnTimPhong_Click(object sender, EventArgs e)
        {
            GetRoom();
        }
        private void btnUndo_Click(object sender, EventArgs e)
        {
            setTrangThai("macdinh");
            txtMaPhong.Text = "";
            txtTenKhachHang.Text = "";
            txtThanhTien.Text = "";
            txtTenPhong.Text = "";
            txtSĐT.Text = "";
            cboLoaiPhong.Text = "";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (trangThai == "them")
            {

                if (ktratrung())
                {

                    lblThongBao.Text = "Tên phòng đã tồn tại";
                    return;
                }


                // khai báo SqlConnection
                conn = new SqlConnection(connectionString);

                //Mở kết nối 
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                //Khai báo câu truy vấn 
                string query = "INSERT INTO tbl_Phong(MaPhong,TenPhong,LoaiPhong,GiaPhong,TrangThai) VALUES ('"+txtMaPhong.Text+"','" + txtTenPhong.Text + "',N'" + cboLoaiPhong.SelectedItem + "','" + txtThanhTien.Text + "','0')";

                //Khai báo SqlCommand, SqlDataAdapter
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
                GetData();
            }
            else if (trangThai == "sua")
            {
                string query = "";
                // khai báo SqlConnection
                conn = new SqlConnection(connectionString);

                //Mở kết nối 
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                //Khai báo câu truy vấn 
                //if (txtTenKhachHang.Text==""&& txtSĐT.Text == "")
                //{
                //     query = "Update tbl_Phong set MaPhong='" + txtMaPhong.Text + "', TenPhong ='" + txtTenPhong.Text + "',GiaPhong ='" + txtThanhTien.Text + "',LoaiPhong = N'" + cboLoaiPhong.Text + "' where MaPhong ='" + txtMaPhong.Text + "' UPDATE tbl_HopDong SET TenKhachHang='" + txtTenKhachHang.Text + "', SoDienThoai='" + txtSĐT.Text + "' WHERE MaPhong='" + txtMaPhong.Text + "'";

                //}
                //else
                query = "Update tbl_Phong set MaPhong='"+txtMaPhong.Text+"', TenPhong ='" + txtTenPhong.Text + "',GiaPhong ='" + txtThanhTien.Text + "',LoaiPhong = N'" + cboLoaiPhong.Text + "' where MaPhong ='" + txtMaPhong.Text + "' UPDATE tbl_HopDong SET TenKhachHang='"+txtTenKhachHang.Text+"', SoDienThoai='"+txtSĐT.Text+ "' WHERE MaPhong='"+txtMaPhong.Text+"'";

                //Khai báo SqlCommand, SqlDataAdapter
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
                GetData();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            lblTongso.Text = "";
            lblThongBao.Text = "";

            if (MessageBox.Show("Bạn có muốn xóa phòng " + txtTenPhong.Text + "? ", "Thông báo ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // khai báo SqlConnection
                conn = new SqlConnection(connectionString);

                //Mở kết nối 
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                //Khai báo câu truy vấn 
                string query = "DELETE FROM tbl_Phong WHERE MaPhong = '" + txtMaPhong.Text + "'";

                //Khai báo SqlCommand, SqlDataAdapter
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
                GetData();
                if ((ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count == 1))
                {
                    MessageBox.Show("Bạn không thể xóa hết phòng", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            trangThai = "sua";
            setTrangThai(trangThai);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            trangThai = "them";
            setTrangThai(trangThai);
        }
        private void frmDatPhong_Load(object sender, EventArgs e)
        {
            GetData();
            dgvPhong.ReadOnly = true;
            trangThai = "macdinh";
            setTrangThai(trangThai);
        }
        private void dgvRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                DataGridViewRow row = new DataGridViewRow();
                row = dgvPhong.Rows[e.RowIndex];
                //txtID.Text = Convert.ToString(row.Cells["ID"].Value);
                txtTenPhong.Text = Convert.ToString(row.Cells["TenPhong"].Value);
                txtThanhTien.Text = Convert.ToString(row.Cells["GiaPhong"].Value);
                txtMaPhong.Text = Convert.ToString(row.Cells["MaPhong"].Value);
                cboLoaiPhong.Text = Convert.ToString(row.Cells["LoaiPhong"].Value);
                if(Convert.ToString(row.Cells["MoTa"].Value)!="")
                    ckbGhiChu.Checked=true;
                else
                    ckbGhiChu.Checked=false;

                if (ckbGhiChu.Checked == true)
                {
                    
                    btnHuyDatPhong.Enabled=true;
                }
                else
                {
                    
                    btnHuyDatPhong.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                lblThongBao.Text = "Error: " + ex.Message;
            }
        }
        private void btnDatPhong_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtTenKhachHang.Text == "")
                {
                    lblThongBao.Text = "Bạn chưa nhập tên khách hàng !";
                    txtTenKhachHang.Focus();
                    return;

                }
                else if (txtTenPhong.Text == "")
                {
                    lblThongBao.Text = "bạn chưa nhập tên phòng !";
                    txtTenPhong.Focus();
                    return;

                }
                else if (txtSĐT.Text == "")
                {
                    lblThongBao.Text = "bạn chưa nhập sđt !";

                    txtSĐT.Focus();
                    return;
                }
                else if (txtThanhTien.Text == "")
                {
                    lblThongBao.Text = "bạn chưa nhập giá !";

                    txtThanhTien.Focus();
                    return;
                }
                else if (cboLoaiPhong.Text == "")
                {
                    lblThongBao.Text = "bạn chưa chọn loại phòng !";
                    return;
                }
                // khai báo SqlConnection
                conn = new SqlConnection(connectionString);

                //Mở kết nối 
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                //Khai báo câu truy vấn 
                string query = "UPDATE tbl_Phong SET MoTa = N'Khách hàng " + txtTenKhachHang.Text + " đặt từ ngày " + dtpNgayDat.Text + " dến " + dtpNgayTra.Text + "' WHERE MaPhong = '" + txtMaPhong.Text + "' INSERT INTO tbl_HopDong (TenKhachHang,SoDienThoai,NgayVao,NgayNhan,NgayRa,MaPhong) VALUES ('" + txtTenKhachHang.Text + "','" + txtSĐT.Text + "','" + dtpNgayDat.Value + "','" + dtpNgayNhan.Value + "','" + dtpNgayTra.Value + "','" + txtMaPhong.Text + "')";

                //Khai báo SqlCommand, SqlDataAdapter
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
                GetData();
                lblThongBao.Text = "Đặt phòng thành công !";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: "+ ex.Message,"Thông báo");
            }
        }

        private void btnNhanPhong_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "";
                // khai báo SqlConnection
                conn = new SqlConnection(connectionString);

                //Mở kết nối 
                if (conn.State == ConnectionState.Closed)
                    conn.Open();


                //Khai báo câu truy vấn 
                if (ckbGhiChu.Checked == true)
                {
                     query = "UPDATE tbl_Phong SET TrangThai = '1' WHERE MaPhong = '" + txtMaPhong.Text + "' ";
                }
                else
                     query = " INSERT INTO tbl_HopDong (TenKhachHang,SoDienThoai,NgayVao,NgayNhan,NgayRa,MaPhong) VALUES ('" + txtTenKhachHang.Text + "','" + txtSĐT.Text + "','" + dtpNgayDat.Value + "','" + dtpNgayNhan.Value + "','" + dtpNgayTra.Value + "','" + txtMaPhong.Text + "') UPDATE tbl_Phong SET TrangThai = '1' WHERE MaPhong = '" + txtMaPhong.Text + "' ";


                //Khai báo SqlCommand, SqlDataAdapter
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
                GetData();
                lblThongBao.Text = "Nhận phòng thành công !";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Thông báo");
            }
        }

        private void btnHuyDatPhong_Click(object sender, EventArgs e)
        {
            try
            {
                if (ckbGhiChu.Checked == true)
                {
                    if (MessageBox.Show("Bạn có muốn hủy đặt phòng " + txtTenPhong.Text + "? ", "Thông báo ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        // khai báo SqlConnection
                        conn = new SqlConnection(connectionString);

                        //Mở kết nối 
                        if (conn.State == ConnectionState.Closed)
                            conn.Open();

                        //Khai báo câu truy vấn 
                        string query = "UPDATE tbl_Phong SET MoTa='' WHERE MaPhong = '" + txtMaPhong.Text + "' DELETE FROM tbl_HopDong WHERE MaPhong = '" + txtMaPhong.Text + "' ";

                        //Khai báo SqlCommand, SqlDataAdapter
                        SqlCommand command = new SqlCommand(query, conn);
                        command.ExecuteNonQuery();
                        GetData();
                        lblThongBao.Text = "Đã hủy đặt phòng!";
                    }
                }
                else
                    return;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Thông báo");
            }
        }

        private void txtSĐT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }


        #endregion

        
    }
}
