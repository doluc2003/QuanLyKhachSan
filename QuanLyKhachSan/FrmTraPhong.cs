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
    public partial class FrmTraPhong : Form
    {
        #region Variable
        public string connectionString = ConfigurationManager.AppSettings["connectionString"];
        SqlConnection conn;
        DataSet ds;
        string trangThai;
        #endregion
        public FrmTraPhong()
        {
            InitializeComponent();
        }
        #region Public Function
        void setTrangThai(string trangThai)
        {
            if (trangThai == "macdinh")
            {
                lblError.Text = "";

                //txtMatKhau.Enabled = false;
                //txtTenDangNhap.Enabled = false;
                //txtManv.Enabled = false;
                //cboQuyenTruyCap.Enabled = false;
                txtCustomerName.Enabled = true;
                txtPrice.Enabled = true;
                txtRoomName.Enabled = true;
                txtSĐT.Enabled = true;
                dtpCheckIn.Enabled = true;
                dtpCheckOut.Enabled = true;
                cboRoomType.Enabled = true;
                txtID.Enabled = true;
                txtRoomID.Enabled = true;


                btnReturnRoom.Enabled = true;
                btnSave.Enabled = false;
                btnUndo.Enabled = false;
                btnEdit.Enabled = true;
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
                btnBlank.Enabled = true;

            }
            else if (trangThai == "them")
            {
                //txtRoomName.Text = "";
                //txtPrice.Text = "";
                //txtCustomerName.Text = "";
                //txtSĐT.Text = "";
                //cboRoomType.SelectedIndex = 0;
                //txtRoomID.Text = "";
                txtID.Enabled = false;
                txtCustomerName.Enabled = true;
                txtSĐT.Enabled = true;
                txtRoomName.Enabled = false;
                txtPrice.Enabled = false;
                cboRoomType.Enabled = false;
                dtpCheckIn.Enabled = true;
                dtpCheckOut.Enabled = true;
                txtRoomID.Enabled = true;

                btnPay.Enabled = false;
                btnCheckRoom.Enabled = true;
                btnReturnRoom.Enabled = false;
                btnSave.Enabled = true;
                btnUndo.Enabled = true;
                btnEdit.Enabled = false;
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;

            }
            else if (trangThai == "sua")
            {

                txtCustomerName.Enabled = true;
                txtSĐT.Enabled = true;
                dtpCheckIn.Enabled = true;
                dtpCheckOut.Enabled = true;
                txtID.Enabled = false;
                txtRoomID.Enabled = true;
                cboRoomType.Enabled = false;
                txtPrice.Enabled = false;
                txtRoomName.Enabled = false;

                btnPay.Enabled = false;
                btnCheckRoom.Enabled = true;
                btnReturnRoom.Enabled = false;
                btnSave.Enabled = true;
                btnUndo.Enabled = true;
                btnEdit.Enabled = false;
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
            }
            else if (trangThai == "thanhtoan")
            {
                //txtRoomName.Text = "";
                //txtPrice.Text = "";
                //txtCustomerName.Text = "";
                //txtSĐT.Text = "";
                cboRoomType.SelectedIndex = 0;
                txtRoomID.Text = "";

                txtPrice.Enabled = false;
                txtRoomName.Enabled = false;
                cboRoomType.Enabled = false;
                txtID.Enabled = false;
                txtCustomerName.Enabled = true;
                txtSĐT.Enabled = true;
                dtpCheckIn.Enabled = false;
                dtpCheckOut.Enabled = false;
                txtRoomID.Enabled = false;

                btnCheckRoom.Enabled = true;
                btnReturnRoom.Enabled = false;
                btnSave.Enabled = false;
                btnUndo.Enabled = true;
                btnEdit.Enabled = false;
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;

            }
        }
        bool ktratrung()
        {
            // khai báo SqlConnection
            conn = new SqlConnection(connectionString);
            //Mở kết nối 
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            //Khai báo câu truy vấn 
            string sql = "Select * from tbl_HopDong where MaPhong = '" + txtRoomID.Text + "'";

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
        //private bool KiemTraPhong()
        //{
        //    // khai báo SqlConnection
        //    conn = new SqlConnection(connectionString);
        //    //Mở kết nối 
        //    if (conn.State == ConnectionState.Closed)
        //        conn.Open();
        //    //Khai báo câu truy vấn 
        //    string sql = "Select * from tbl_HopDong A,tbl_Phong B where A.MaPhong = B.MaPhong AND B.TrangThai = '1' AND A.TenKhachHang != '" + txtCustomerName.Text.Trim() + "' ";

        //    //Khai báo SqlCommand, SqlDataAdapter
        //    SqlCommand command = new SqlCommand(sql, conn);

        //    SqlDataAdapter da = new SqlDataAdapter(command);
        //    //Khai báo Dataset
        //    ds = new DataSet();
        //    //fill dữ liệu 
        //    da.Fill(ds);
        //    if (ds.Tables[0].Rows.Count > 0)
        //    {

        //        return true;
        //    }
        //    else return false;
        //}
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
                string query = "SELECT *  FROM tbl_HopDong A, tbl_Phong B WHERE A.MaPhong = B.MaPhong AND B.TrangThai='1' ";

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

                dgvRoom.AutoGenerateColumns = false;
                dgvRoom.DataSource = ds.Tables[0];


            }

            catch (Exception ex)
            {

                lblError.Text = "Error: " + ex.Message;
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

                if (txtRoomName.Text != "")
                {
                    query = "SELECT * FROM tbl_HopDong A,tbl_Phong B WHERE B.MaPhong=A.MaPhong AND B.TrangThai='1' AND B.TenPhong LIKE '%" + txtRoomName.Text + "%'";
                }
                if (cboRoomType.Text != "")
                {
                    query = "SELECT * FROM tbl_HopDong A, tbl_Phong B WHERE B.MaPhong=A.MaPhong AND B.TrangThai='1' AND B.LoaiPhong = N'" + cboRoomType.SelectedItem + "'";
                }
                if (txtSĐT.Text != "")
                {
                    query = "SELECT * FROM tbl_HopDong A, tbl_Phong B WHERE B.MaPhong=A.MaPhong AND B.TrangThai='1' AND A.SoDienThoai = '" + txtSĐT.Text + "'";
                }
                if (txtCustomerName.Text != "")
                {
                    query = "SELECT * FROM tbl_HopDong A, tbl_Phong B WHERE B.MaPhong=A.MaPhong AND B.TrangThai='1' AND A.TenKhachHang LIKE N'%" + txtCustomerName.Text + "%'";
                }
                if (txtCustomerName.Text != "" && txtSĐT.Text != "")
                {
                    query = "SELECT * FROM tbl_HopDong A, tbl_Phong B WHERE B.MaPhong=A.MaPhong AND B.TrangThai='1' AND A.TenKhachHang LIKE '%" + txtCustomerName.Text + "%' AND A.SoDienThoai ='" + txtSĐT.Text + "'";
                }
                if (txtCustomerName.Text != "" && txtRoomName.Text != "")
                {
                    query = "SELECT * FROM tbl_HopDong A, tbl_Phong B WHERE B.MaPhong=A.MaPhong AND B.TrangThai='1' AND A.TenKhachHang LIKE '%" + txtCustomerName.Text + "%' AND B.TenPhong LIKE N'%" + txtRoomName.Text + "%'";
                }
                if (txtCustomerName.Text != "" && cboRoomType.Text != "")
                {
                    query = "SELECT * FROM tbl_HopDong A, tbl_Phong B WHERE B.MaPhong=A.MaPhong AND B.TrangThai='1' AND A.TenKhachHang LIKE '%" + txtCustomerName.Text + "%' AND B.LoaiPhong ='" + cboRoomType.Text + "'";
                }
                if (txtRoomName.Text != "" && txtSĐT.Text != "")
                {
                    query = "SELECT * FROM tbl_HopDong A, tbl_Phong B WHERE B.MaPhong=A.MaPhong AND B.TrangThai='1' AND B.TenPhong LIKE N'%" + txtRoomName.Text + "%' AND A.SoDienThoai ='" + txtSĐT.Text + "'";
                }
                if (cboRoomType.Text != "" && txtSĐT.Text != "")
                {
                    query = "SELECT * FROM tbl_HopDong A, tbl_Phong B WHERE B.MaPhong=A.MaPhong AND B.TrangThai='1' AND B.LoaiPhong = '" + cboRoomType.Text + "' AND A.SoDienThoai ='" + txtSĐT.Text + "'";
                }
                if (txtRoomName.Text != "" && cboRoomType.Text != "")
                {
                    query = "SELECT * FROM tbl_HopDong A, tbl_Phong B WHERE B.MaPhong=A.MaPhong AND B.TrangThai='1' AND B.TenPhong LIKE N'%" + txtRoomName.Text + "%' AND B.LoaiPhong ='" + cboRoomType.Text + "'";
                }

                //query = "SELECT * FROM tbl_HopDong A, tbl_Phong B WHERE A.MaPhong = B.MaPhong AND A.CheckIn >= '" + dtpCheckIn.Text + "' AND A.Checkout <= '" + dtpCheckOut.Text + "' and B.LoaiPhong = N'" + cboRoomType.SelectedItem + "'";
                if (cboRoomType.Text == "" && txtPrice.Text == "" && txtRoomName.Text == "" && txtCustomerName.Text == "" && txtSĐT.Text == "")
                    query = "SELECT * FROM tbl_HopDong A,tbl_Phong B WHERE B.MaPhong=A.MaPhong AND B.TrangThai='1' ";
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
                    dgvRoom.DataSource = ds.Tables[0];
                }
                lblTongso.Text = "Tổng số : " + ds.Tables[0].Rows.Count + " phòng ";
            }

            catch (Exception ex)
            {

                lblError.Text = "Error: " + ex.Message;
            }
            finally
            {
                conn.Dispose();
            }
        }
        #endregion

        #region Events
        private void FrmTraPhong_Load_1(object sender, EventArgs e)
        {
            GetData();
            dgvRoom.ReadOnly = true;
        }
        private void btnCheckRoom_Click_1(object sender, EventArgs e)
        {
            GetRoom();
        }
        private void btnReturnRoom_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn trả phòng " + txtRoomName.Text + "? ", "Thông báo ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (MessageBox.Show("Mời thanh toán cho thu ngân" + Environment.NewLine + " Quý khách : " + txtCustomerName.Text + "" + Environment.NewLine + " SĐT : " + txtSĐT.Text + "" + Environment.NewLine + " Số tiền :" + txtPrice.Text + " đồng ", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        // khai báo SqlConnection
                        conn = new SqlConnection(connectionString);

                        //Mở kết nối 
                        if (conn.State == ConnectionState.Closed)
                            conn.Open();
                        //Khai báo câu truy vấn 
                        string query = "DELETE FROM tbl_HopDong WHERE tbl_HopDong.MaPhong ='" + txtRoomID.Text + "' UPDATE tbl_Phong SET TrangThai = '0', MoTa = '' WHERE TenPhong = '" + txtRoomName.Text + "'";

                        //Khai báo SqlCommand, SqlDataAdapter
                        SqlCommand command = new SqlCommand(query, conn);
                        command.ExecuteNonQuery();
                        GetData();
                        lblError.Text = "Trả phòng thành công!";
                    }
                }
            }
            catch (Exception ex)
            {

                lblError.Text = "Error: " + ex.Message;
            }
        }

        private void btnBlank_Click_1(object sender, EventArgs e)
        {
            cboRoomType.Text = "";
            txtPrice.Text = "";
            txtCustomerName.Text = "";
            txtSĐT.Text = "";
            txtRoomName.Text = "";
            txtID.Text = "";
            txtRoomID.Text = "";
            //txtRoomID.Text = "";
            dtpCheckIn.Value = DateTime.Now;
            dtpCheckOut.Value = DateTime.Now;
        }

        private void btnEnd_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnUndo_Click_1(object sender, EventArgs e)
        {
            setTrangThai("macdinh");
            //txtRoomID.Text = "";
            txtCustomerName.Text = "";
            txtPrice.Text = "";
            txtRoomName.Text = "";
            txtSĐT.Text = "";
            txtRoomID.Text = "";
            cboRoomType.Text = "";
            txtID.Text = "";
            dtpCheckIn.Value = DateTime.Now;
            dtpCheckOut.Value = DateTime.Now;
        }
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (trangThai == "them")
            {

                if (ktratrung())
                {

                    lblError.Text = "Phòng đã được đặt";
                    return;
                }


                // khai báo SqlConnection
                conn = new SqlConnection(connectionString);

                //Mở kết nối 
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                //int id = Convert.ToInt32(txtRoomID.Text);
                //Khai báo câu truy vấn 
                string query = "INSERT INTO tbl_HopDong(TenKhachHang,SoDienThoai,NgayVao,NgayRa,MaPhong) VALUES (N'" + txtCustomerName.Text + "','" + txtSĐT.Text + "','" + dtpCheckIn.Value + "','" + dtpCheckOut.Value + "',N'" + txtRoomID.Text + "')  UPDATE tbl_Phong SET TrangThai = '1' WHERE MaPhong = N'" + txtRoomID.Text.Trim() + "' ";

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
                if (txtRoomName.Text != txtRoomID.Text.Substring(2, 3))
                {
                     query = "Update tbl_HopDong set MaPhong=N'" + txtRoomID.Text.Trim() + "', TenKhachHang=N'" + txtCustomerName.Text + "',SoDienThoai ='" + txtSĐT.Text + "',NgayVao='" + dtpCheckIn.Value + "',NgayRa='" + dtpCheckOut.Value + "' where MaHopDong =N'" + txtID.Text + "' Update tbl_Phong set TrangThai = '1' where MaPhong = N'" + txtRoomID.Text + "' Update tbl_Phong set TrangThai = '0' where TenPhong = N'" + txtRoomName.Text + "' ";

                }
                else
                    query = "Update tbl_HopDong set MaPhong=N'" + txtRoomID.Text.Trim() + "', TenKhachHang=N'" + txtCustomerName.Text + "',SoDienThoai ='" + txtSĐT.Text + "',NgayVao='" + dtpCheckIn.Value + "',NgayRa='" + dtpCheckOut.Value + "' where MaHopDong =N'" + txtID.Text + "' ";

                //Khai báo SqlCommand, SqlDataAdapter
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
                GetData();
            }
        }
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            lblTongso.Text = "";
            lblError.Text = "";

            if (MessageBox.Show("Bạn có muốn xóa ? ", "Thông báo ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // khai báo SqlConnection
                conn = new SqlConnection(connectionString);

                //Mở kết nối 
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                //int id = Convert.ToInt32(txtRoomID.Text);
                //Khai báo câu truy vấn 
                string query = "DELETE FROM tbl_HopDong WHERE tbl_HopDong.MaPhong ='" + txtRoomID.Text + "' UPDATE tbl_Phong SET TrangThai = '0' WHERE TenPhong = '" + txtRoomName.Text + "'";

                //Khai báo SqlCommand, SqlDataAdapter
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
                GetData();

            }
            cboRoomType.Text = "";
            txtPrice.Text = "";
            txtCustomerName.Text = "";
            txtSĐT.Text = "";
            txtRoomName.Text = "";
            txtID.Text = "";
            txtRoomID.Text = "";
            //txtRoomID.Text = "";
            dtpCheckIn.Value = DateTime.Now;
            dtpCheckOut.Value = DateTime.Now;
        }
        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            trangThai = "sua";
            setTrangThai(trangThai);
        }
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            trangThai = "them";
            setTrangThai(trangThai);
        }
        private void dgvRoom_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvRoom.Rows[e.RowIndex];
                //txtID.Text = Convert.ToString(row.Cells["ID"].Value);
                txtRoomName.Text = Convert.ToString(row.Cells["TenPhong"].Value);
                
                dtpCheckIn.Text = Convert.ToString(row.Cells["NgayNhan"].Value);
                dtpCheckOut.Text = Convert.ToString(row.Cells["NgayRa"].Value);
                DateTime NgayNhan = Convert.ToDateTime(row.Cells["NgayNhan"].Value);
                DateTime NgayTra = Convert.ToDateTime(row.Cells["NgayRa"].Value);
                TimeSpan Day = NgayTra - NgayNhan ;
                int NgayO = Day.Days + 1;
                txtPrice.Text = Convert.ToString(Convert.ToInt32(row.Cells["GiaPhong"].Value)*NgayO);
                txtCustomerName.Text = Convert.ToString(row.Cells["TenKhachHang"].Value);
                txtSĐT.Text = Convert.ToString(row.Cells["SoDienThoai"].Value);
                cboRoomType.Text = Convert.ToString(row.Cells["LoaiPhong"].Value);
                txtRoomID.Text = Convert.ToString(row.Cells["MaPhong"].Value);
                txtID.Text = Convert.ToString(row.Cells["MaHopDong"].Value);

            }
            catch (Exception ex)
            {
                lblError.Text = "Error: " + ex.Message;
            }
        }
        private void btnPay_Click_1(object sender, EventArgs e)
        {
            try
            {
                setTrangThai("thanhtoan");
                // khai báo SqlConnection
                conn = new SqlConnection(connectionString);

                //Mở kết nối 
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                //Khai báo câu truy vấn 
                string query = "SELECT * FROM tbl_HopDong A, tbl_Phong B WHERE A.MaPhong=B.MaPhong AND A.TenKhachHang=N'" + txtCustomerName.Text + "' ";

                //Khai báo SqlCommand, SqlDataAdapter
                SqlCommand command = new SqlCommand(query, conn);
                //command.CommandType = CommandType.TableDirect;
                //command.Parameters.AddWithValue("@Status", "1");

                SqlDataAdapter da = new SqlDataAdapter(command);
                //Khai báo Dataset
                ds = new DataSet();
                //fill dữ liệu 
                da.Fill(ds);

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dgvRoom.DataSource = ds.Tables[0];
                    DataColumn colOrderNumber = new DataColumn();
                    colOrderNumber.ColumnName = "colOrderNumber";
                    ds.Tables[0].Columns.Add(colOrderNumber);
                    int icount = 1;
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        dr["colOrderNumber"] = icount.ToString();
                        icount++;
                    }


                }
                lblTongso.Text = "Tổng số : " + ds.Tables[0].Rows.Count + " Phòng ";
                int tien = dgvRoom.Rows.Count;
                float thanhtien = 0;
                for (int i = 0; i < tien - 1; i++)
                {
                    thanhtien += float.Parse(dgvRoom.Rows[i].Cells["GiaPhong"].Value.ToString());
                }
                txtPrice.Text = thanhtien.ToString();
            }

            catch (Exception ex)
            {

                lblError.Text = "Error: " + ex.Message;
            }
            finally
            {
                conn.Dispose();
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
