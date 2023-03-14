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
using static DevExpress.Utils.HashCodeHelper;

namespace QuanLyKhachSan
{
    public partial class FrmQLSukien : Form
    {
        string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
        SqlConnection conn;
        DataSet ds;
        string trangthai;
        public FrmQLSukien()
        {
            InitializeComponent();
            getdata();
        }
        void setTrangThai(string trangThai)
        {
            if (trangThai == "macdinh")
            {
               

                txt1.Enabled = false;
                txt2.Enabled = false;
             
               
                cbo2.Enabled = false;
                dtp1.Enabled = false;
                dtp2.Enabled = false;

                btn1.Enabled = true;
                btn2.Enabled = true;
                btn3.Enabled = true;
                btn4.Enabled = false;
   

            }
            else if (trangThai == "them")
            {
                txt1.Text = "";
                txt2.Text = "";
      
                cbo2.SelectedIndex = 0;
                dtp1.Enabled = true;
                dtp2.Enabled = true;

                txt1.Enabled = true;
                txt2.Enabled = true;

                cbo2.Enabled = true;
                dtp1.Enabled=true;
                dtp2.Enabled = false;
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = true;
         


            }
            else if (trangThai == "sua")
            {
                cbo2.SelectedIndex = 0;
                dtp1.Enabled = true;
                dtp2.Enabled = true;

                txt1.Enabled = true;
                txt2.Enabled = true;
                
                cbo2.Enabled = true;
                dtp1.Enabled = true;
                dtp2.Enabled = false;
                btn1.Enabled = false;
                btn2.Enabled = true;
                btn3.Enabled = true;
                btn4.Enabled = true;                   
            }
        }
        
        private void btn1_Click(object sender, EventArgs e)
        {
            trangthai = "them";
            setTrangThai(trangthai);
            
        }
        void getdata()
        {
            // khai báo SqlConnection
            conn = new SqlConnection(ConnectionString);
            //Mở kết nối 
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            //Khai báo câu truy vấn 
            string sql = "Select * from tbl_SuKien,tbl_PhongSuKien where tbl_SuKien.MaPhongSuKien=tbl_PhongSuKien.MaPhongSuKien ";

            //Khai báo SqlCommand, SqlDataAdapter
            SqlCommand command = new SqlCommand(sql, conn);

            SqlDataAdapter da = new SqlDataAdapter(command);
            //Khai báo Dataset
            ds = new DataSet();
            //fill dữ liệu 
            da.Fill(ds);
         

            dgvDatphong.AutoGenerateColumns = false;
            dgvDatphong.DataSource = ds.Tables[0];

        }

        private void dgvDatphong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               

                DataGridViewRow row = new DataGridViewRow();
                if (e.RowIndex >= 0)
                {
                    row = dgvDatphong.Rows[e.RowIndex];
                    txt1.Text = Convert.ToString(row.Cells["TenKhachHang"].Value);
                    txt2.Text = Convert.ToString(row.Cells["SoDienThoai"].Value); ;
                    cbo2.SelectedIndex = (Convert.ToString(row.Cells["LoaiPhong"].Value) == "Đám cưới" ? 1 : 0);
                    dtp1.Text = Convert.ToString(row.Cells["NgayVao"].Value);
                    dtp2.Text = Convert.ToString(row.Cells["NgayRa"].Value);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo");
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            trangthai = "sua";
            setTrangThai(trangthai);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            // khai báo SqlConnection
            conn = new SqlConnection(ConnectionString);

            //Mở kết nối 
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            //Khai báo câu truy vấn 
            string query = "DELETE FROM tbl_SuKien WHERE TenTaiKhoan ='" + txt2.Text + "'";

            //Khai báo SqlCommand, SqlDataAdapter
            SqlCommand command = new SqlCommand(query, conn);
            command.ExecuteNonQuery();
            getdata();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            setTrangThai("macdinh");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (trangthai == "them")
            {
                // khai báo SqlConnection
                conn = new SqlConnection(ConnectionString);

                //Mở kết nối 
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                //Khai báo câu truy vấn 
                string query = "INSERT INTO tbl_SuKien(TenKhachHang,SoDienThoai,NgayVao,NgayRa)\r\nVALUES ('" + txt1.Text + "','" + txt2.Text + "','" + (cbo2.SelectedIndex == 1 ? "Đám cưới" : "Meeting") + "')";

                //Khai báo SqlCommand, SqlDataAdapter
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
                getdata();
            }
            else if (trangthai == "sua")
            {
                // khai báo SqlConnection
                conn = new SqlConnection(ConnectionString);

                //Mở kết nối 
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                //Khai báo câu truy vấn 
                string query = "Update tbl_SuKien,tbl_PhongSuKien \r\n set TenKhachHang ='" + txt1.Text + "',SoDienThoai ='" + txt2.Text + "',LoaiPhong = '" + (cbo2.SelectedIndex == 1 ? "Đám cưới" : "Meeting") + "' where SoDienThoai ='" + txt2.Text + "'";

                //Khai báo SqlCommand, SqlDataAdapter
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
                getdata();
            }
        }
        
    }
}
