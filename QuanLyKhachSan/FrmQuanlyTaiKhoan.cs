using DevExpress.CodeParser;
using DevExpress.XtraTreeList;
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
    public partial class FrmQuanlyTaiKhoan : Form
    {
        string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
        SqlConnection conn;
        DataSet ds;
        string trangthai;
        public FrmQuanlyTaiKhoan()
        {
            InitializeComponent();
          
        }
        void setTrangThai(string trangThai)
        {
            if(trangThai=="macdinh")
            {
                lbLoi.Text = "";

                txtMatKhau.Enabled = false;
                txtTenDangNhap.Enabled = false;
                txtManv.Enabled = false;
                cboQuyenTruyCap.Enabled = false;
         
                btnGhi.Enabled = false;
                btnHuyBo.Enabled = false;
                btnSua.Enabled = true;
                btnThem.Enabled = true;
                btnXoa.Enabled = true;

            }
            else if (trangThai == "them")
            {
                txtMatKhau.Text = "";
                txtTenDangNhap.Text = "";
                txtManv.Text = "";
                cboQuyenTruyCap.SelectedIndex = 0;
               
                txtMatKhau.Enabled = true;
                txtTenDangNhap.Enabled = true;
                txtManv.Enabled = true;
                cboQuyenTruyCap.Enabled = true;
             
                btnGhi.Enabled = true;
                btnHuyBo.Enabled = true;
                btnSua.Enabled = false;
                btnThem.Enabled = false;
                btnXoa.Enabled = false;

            }else if( trangThai == "sua")
            {
                txtMatKhau.Enabled = true;
                txtTenDangNhap.Enabled = true;
                txtManv.Enabled = false;
                cboQuyenTruyCap.Enabled = true;
               
                btnGhi.Enabled = true;
                btnHuyBo.Enabled = true;
                btnSua.Enabled = false;
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
            }
        }
        void getdata()
        {
            // khai báo SqlConnection
            conn = new SqlConnection(ConnectionString);
            //Mở kết nối 
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            //Khai báo câu truy vấn 
            string sql = "Select * from tbl_TaiKhoan,tbl_NhanVien where tbl_TaiKhoan.MaNV=tbl_NhanVien.MaNV ";

            //Khai báo SqlCommand, SqlDataAdapter
            SqlCommand command = new SqlCommand(sql, conn);

            SqlDataAdapter da = new SqlDataAdapter(command);
            //Khai báo Dataset
            ds = new DataSet();
            //fill dữ liệu 
            da.Fill(ds);
            DataColumn colOrderNumber = new DataColumn();
            colOrderNumber.ColumnName = "colOrderNumber";
            ds.Tables[0].Columns.Add(colOrderNumber);
            DataColumn colViewStatus = new DataColumn();
            colViewStatus.ColumnName = "ViewStatus";
            ds.Tables[0].Columns.Add(colViewStatus);
            int icount = 1;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                dr["colOrderNumber"] = icount.ToString();
                icount++;
                if (dr["Quyen"].ToString() == "admin")

                    dr["ViewStatus"] = "Quản trị viên  ";
                else
                    dr["ViewStatus"] = "Người dùng ";

            }
            lbThongbao.Text = "Tổng số bản ghi : " + ds.Tables[0].Rows.Count;

            dgvTaiKhoan.AutoGenerateColumns = false;
            dgvTaiKhoan.DataSource = ds.Tables[0];
           
        }
      
     

        

        private void FrmQuanlyTaiKhoan_Load(object sender, EventArgs e)
        {
            getdata();
            setTrangThai("macdinh");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text != "")
            {
                // khai báo SqlConnection
                conn = new SqlConnection(ConnectionString);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                //Khai báo câu truy vấn 
                string sql = "Select * from tbl_TaiKhoan,tbl_NhanVien where tbl_TaiKhoan.MaNV=tbl_NhanVien.MaNV and TenTaiKhoan like '" + txtSearch.Text.Trim() +"%' ";

                //Khai báo SqlCommand, SqlDataAdapter
                SqlCommand command = new SqlCommand(sql, conn);

                SqlDataAdapter da = new SqlDataAdapter(command);
                //Khai báo Dataset
                ds = new DataSet();
                //fill dữ liệu 
                da.Fill(ds);
                DataColumn colOrderNumber = new DataColumn();
                colOrderNumber.ColumnName = "colOrderNumber";
                ds.Tables[0].Columns.Add(colOrderNumber);
                DataColumn colViewStatus = new DataColumn();
                colViewStatus.ColumnName = "ViewStatus";
                ds.Tables[0].Columns.Add(colViewStatus);
                int icount = 1;
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dr["colOrderNumber"] = icount.ToString();
                    icount++;
                    if (dr["Quyen"].ToString() == "admin")

                        dr["ViewStatus"] = "Quản trị viên  ";
                    else
                        dr["ViewStatus"] = "Người dùng ";

                }
                lbThongbao.Text = "Tổng số bản ghi : " + ds.Tables[0].Rows.Count;
                dgvTaiKhoan.DataSource = ds.Tables[0];
            }else
            {
                getdata();
            }
           
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            txtSearch.ForeColor = Color.Black;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            trangthai = "them";
            setTrangThai(trangthai);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            trangthai = "sua";
            setTrangThai(trangthai);
        }
     
        bool ktratrung()
        {
            // khai báo SqlConnection
            conn = new SqlConnection(ConnectionString);
            //Mở kết nối 
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            //Khai báo câu truy vấn 
            string sql = "Select * from tbl_TaiKhoan,tbl_NhanVien where TenTaiKhoan = '"+txtTenDangNhap.Text+"'";

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
            else  return false;
        }
        bool ktraManv()
        {
            // khai báo SqlConnection
            conn = new SqlConnection(ConnectionString);
            //Mở kết nối 
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            //Khai báo câu truy vấn 
            string sql = "Select * from tbl_TaiKhoan,tbl_NhanVien where tbl_NhanVien.MaNV = '" + txtManv.Text + "'";

            //Khai báo SqlCommand, SqlDataAdapter
            SqlCommand command = new SqlCommand(sql, conn);

            SqlDataAdapter da = new SqlDataAdapter(command);
            //Khai báo Dataset
            ds = new DataSet();
            //fill dữ liệu 
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count == 0)
            {
               
                return true;
            }else return false;
        }
        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (txtManv.Text == "")
            {
                lbLoi.Text = "Bạn chưa nhập mã nhân viên !";
                txtManv.Focus();
                return;

            }
            else if (txtTenDangNhap.Text == "")
            {
                lbLoi.Text = "bạn chưa nhập Tên đăng nhập !";
                txtTenDangNhap.Focus();
                return;

            }
            else if (txtMatKhau.Text == "")
            {
                lbLoi.Text = "bạn chưa nhập mật khẩu !";

                txtMatKhau.Focus();
                return;
            }

            if (trangthai== "them")
            {
               if(ktraManv())
                {
                    lbLoi.Text = "Sai mã nhân viên hoặc mã nhân viên không tồn tại ";
                    return;
                };
                if (ktratrung())
                {
                    
                    lbLoi.Text = "Tài khoản đã tồn tại";
                    return;
                }
                

                // khai báo SqlConnection
                conn = new SqlConnection(ConnectionString);

                //Mở kết nối 
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                //Khai báo câu truy vấn 
                string query = "INSERT INTO tbl_TaiKhoan(TenTaiKhoan,MatKhau,MaNV,Quyen)\r\nVALUES ('"+txtTenDangNhap.Text+"','"+txtMatKhau.Text+"','"+txtManv.Text+"','"+(cboQuyenTruyCap.SelectedIndex == 1 ? "admin" :"user" )+"')";

                //Khai báo SqlCommand, SqlDataAdapter
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
                getdata();
            }
            else if(trangthai== "sua")
            {
                // khai báo SqlConnection
                conn = new SqlConnection(ConnectionString);

                //Mở kết nối 
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                //Khai báo câu truy vấn 
                string query = "Update tbl_TaiKhoan \r\n set TenTaiKhoan ='" + txtTenDangNhap.Text + "',MatKhau ='" + txtMatKhau.Text + "',Quyen = '" + (cboQuyenTruyCap.SelectedIndex == 1 ? "admin" : "user") + "' where MaNV ='" + txtManv.Text + "'";

                //Khai báo SqlCommand, SqlDataAdapter
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
                getdata();
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            setTrangThai("macdinh");
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lbLoi.Text = "";
              
                DataGridViewRow row = new DataGridViewRow();
                if (e.RowIndex >= 0)
                {
                    row = dgvTaiKhoan.Rows[e.RowIndex];
                    txtTenDangNhap.Text = Convert.ToString(row.Cells["TenTaiKhoan"].Value);
                    txtMatKhau.Text = Convert.ToString(row.Cells["MatKhau"].Value); ;
                    cboQuyenTruyCap.SelectedIndex =( Convert.ToString(row.Cells["Role"].Value) == "admin" ? 1 :0 );
                    txtManv.Text = Convert.ToString(row.Cells["MaNV"].Value);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // khai báo SqlConnection
            conn = new SqlConnection(ConnectionString);

            //Mở kết nối 
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            //Khai báo câu truy vấn 
            string query = "DELETE FROM tbl_TaiKhoan WHERE TenTaiKhoan ='"+txtTenDangNhap.Text+"'";

            //Khai báo SqlCommand, SqlDataAdapter
            SqlCommand command = new SqlCommand(query, conn);
            command.ExecuteNonQuery();
            getdata();
        }

        private void FrmQuanlyTaiKhoan_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.Text = "Nhập tài khoản cần tìm kiếm";
            txtSearch.ForeColor = Color.Silver;
            getdata();
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '*')
            {
                label3.Text = "hide";
                txtMatKhau.PasswordChar = '\0';
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
                label3.Text = "show";
            }
        }
    }
}
