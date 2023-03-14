using DevExpress.Utils.Extensions;
using DevExpress.Utils.Filtering.Internal;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraRichEdit.Export.Rtf;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyKhachSan
{
    public partial class FrmDoanhThu : Form
    {
        #region Variables
        string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
        SqlConnection conn;
        DataSet ds;
        public static string Role;

        #endregion
        public FrmDoanhThu()
        {
            InitializeComponent();
            rdoTheoNam.Checked = true;

            getCombobox2();
            GetData();
        }

        void getCombobox2()
        {
            try
            {
             
                // khai báo SqlConnection
                conn = new SqlConnection(ConnectionString);

                //Mở kết nối 
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                //Khai báo câu truy vấn 


                string sql = "SELECT  DATEPART(yyyy,B.NgayRa) as Year FROM tbl_HopDong b  GROUP BY DATEPART(yyyy,B.NgayRa) ORDER BY DATEPART(yyyy,B.NgayRa) DESC";
                SqlCommand command = new SqlCommand(sql, conn);

                SqlDataAdapter da = new SqlDataAdapter(command);
                //Khai báo Dataset
                ds = new DataSet();
                //fill dữ liệu 
                da.Fill(ds);

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    cbo1.DataSource = ds.Tables[0];
                    cbo1.DisplayMember = "Year";
                    cbo1.ValueMember = "Year";

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo");

            }
            finally
            {
                conn.Dispose();
            }
        }
        void getCombobox1()
        {
            try
            {

                // khai báo SqlConnection
                conn = new SqlConnection(ConnectionString);

                //Mở kết nối 
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                //Khai báo câu truy vấn 


                string sql = "SELECT  DATEPART(MM,B.NgayRa) as Year FROM tbl_HopDong b where DATEPART(YYYY,B.NgayRa) =" + cbo1.Text + " GROUP BY DATEPART(MM,B.NgayRa)";
                SqlCommand command = new SqlCommand(sql, conn);

                SqlDataAdapter da = new SqlDataAdapter(command);
                //Khai báo Dataset
                ds = new DataSet();
                //fill dữ liệu 
                da.Fill(ds);

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    cbo2.DataSource = ds.Tables[0];
                    cbo2.DisplayMember = "Year";
                    cbo2.ValueMember = "Year";

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo");

            }
            finally
            {
                conn.Dispose();
            }
        }
        void GetData()
        {
            try
            {

                // khai báo SqlConnection
                conn = new SqlConnection(ConnectionString);

                //Mở kết nối 
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                //Khai báo câu truy vấn 


                string sql = "Select DATEPART(MM,B.NgayRa) as Thang , Sum(B.GIaThue) as ThuePhong, Sum(A.TongTien) as total, sum(A.TongTien-B.GIaThue) as DichVu from tbl_HopDong B inner join tblHoaDon A  on DATEPART(MM,B.NgayRa) = DATEPART(MM,A.NgayLap) where DATEPART(YYYY,B.NgayRa) = " + DateTime.Now.Year + " group by DATEPART(MM,B.NgayRa)";
                SqlCommand command = new SqlCommand(sql, conn);

                SqlDataAdapter da = new SqlDataAdapter(command);
                //Khai báo Dataset
                ds = new DataSet();
                //fill dữ liệu 
                da.Fill(ds);
                dgvDoanhThu.DataSource = ds.Tables[0];
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    decimal sumTotal = 0;
                    decimal sumDichVu = 0;
                    decimal SumPhongThue = 0;
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                     
                        sumTotal += Convert.ToDecimal(dr["total"]);
                        sumDichVu += Convert.ToDecimal(dr["DichVu"]);
                        SumPhongThue += Convert.ToDecimal(dr["ThuePhong"]);
                    }
                    txtThongke.Text = "Tổng doanh thu năm 2022 " + sumTotal + " vnđ \r\n" + "trong đó :\r\n Doanh thu dịch vụ :" + sumDichVu + "vnđ\r\n Doanh Thu thêu Phòng : " + sumTotal + "vnđ";
                    chart1.Titles.Clear();
                    chart1.DataSource = ds;

                    chart1.Series["Thuê phòng"].XValueMember = "Thang";
                    chart1.Series["Thuê phòng"].YValueMembers = "ThuePhong";
                    chart1.Series["Dịch vụ"].XValueMember = "Thang";
                    chart1.Series["Dịch vụ"].YValueMembers = "DichVu";
                    chart1.Series["Tổng"].XValueMember = "Thang";
                    chart1.Series["Tổng"].YValueMembers = "total";
                    chart1.Titles.Add("BẢNG THỐNG KÊ DOANH THU THEO THÁNG");



                }
            }

            catch (Exception ex)
            {

                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo");

            }
            finally
            {
                conn.Dispose();
            }
        }

        private void dgvDoanhThu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rdoTheoNam.Checked)
            {
                chart2.Series.Clear();
                Series s = chart2.Series.Add("pie");
                s.ChartType = SeriesChartType.Pie;
                s.IsValueShownAsLabel = true;

                DataGridViewRow row = new DataGridViewRow();
                if (e.RowIndex >= 0)
                {
                    row = dgvDoanhThu.Rows[e.RowIndex];

                    cbo2.Text = Convert.ToString(row.Cells["thang"].Value);
                    s.Points.AddXY("dichvu", Convert.ToDecimal(row.Cells["DichVu"].Value));
                    s.Points.AddXY("ThuePhong", Convert.ToDecimal(row.Cells["ThuePhong"].Value));

                }
            }
            if (rdoTheoNgay.Checked || rdoTheoThang.Checked)
            {
                chart2.Series.Clear();
                Series s = chart2.Series.Add("pie");
                s.ChartType = SeriesChartType.Pie;
                s.IsValueShownAsLabel = true;

                DataGridViewRow row = new DataGridViewRow();
                if (e.RowIndex >= 0)
                {
                    row = dgvDoanhThu.Rows[e.RowIndex];

                    s.Points.AddXY("dichvu", Convert.ToDecimal(row.Cells["DichVu"].Value));
                    s.Points.AddXY("ThuePhong", Convert.ToDecimal(row.Cells["ThuePhong"].Value));

                }
            }




        }

        private void rdoTheoNam_CheckedChanged(object sender, EventArgs e)
        {
            dtpNgay1.Enabled = false;
            dtpNgay2.Enabled = false;
            cbo2.Enabled = false;
            cbo1.Enabled = true;
        }

        private void rdoTheoThang_CheckedChanged(object sender, EventArgs e)
        {
            dtpNgay1.Enabled = false;
            dtpNgay2.Enabled = false;
            cbo2.Enabled = true;
            cbo1.Enabled = false;
            getCombobox1();
        }

        private void rdoTheoNgay_CheckedChanged(object sender, EventArgs e)
        {
            dtpNgay1.Enabled = true;
            dtpNgay2.Enabled = true;
            cbo2.Enabled = false;
            cbo1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdoTheoNam.Checked)
            {
                lbThongbao.Text = "BẢNG THỐNG KÊ DOANH THU NĂM "+ cbo1.Text;
                // khai báo SqlConnection
                conn = new SqlConnection(ConnectionString);

                //Mở kết nối 
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                //Khai báo câu truy vấn 


                string sql = "Select DATEPART(MM,B.NgayRa) as Thang , Sum(B.GIaThue) as ThuePhong, Sum(A.TongTien) as total, sum(A.TongTien-B.GIaThue) as DichVu from tbl_HopDong B inner join tblHoaDon A  on DATEPART(MM,B.NgayRa) = DATEPART(MM,A.NgayLap) where DATEPART(YYYY,B.NgayRa) = " + cbo1.Text + " group by DATEPART(MM,B.NgayRa)";
                SqlCommand command = new SqlCommand(sql, conn);

                SqlDataAdapter da = new SqlDataAdapter(command);
                //Khai báo Dataset
                ds = new DataSet();
                //fill dữ liệu 
                da.Fill(ds);
                dgvDoanhThu.DataSource = ds.Tables[0];
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    DataColumn Month = new DataColumn();
                    Month.ColumnName = "Month";
                    ds.Tables[0].Columns.Add(Month);
                    decimal sumTotal = 0;
                    decimal sumDichVu = 0;
                    decimal SumPhongThue = 0;
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        dr["Month"] = "tháng " + dr["Thang"];
                        sumTotal += Convert.ToDecimal(dr["total"]);
                        sumDichVu += Convert.ToDecimal(dr["DichVu"]);
                        SumPhongThue += Convert.ToDecimal(dr["ThuePhong"]);
                    }
                    txtThongke.Text = "Tổng doanh thu năm " + cbo1.Text + " :" + sumTotal + " vnđ \r\n" + "trong đó :\r\n Doanh thu dịch vụ :" + sumDichVu + "vnđ\r\n Doanh Thu thêu Phòng : " + sumTotal + "vnđ";
                    chart1.Titles.Clear();
                    chart1.DataSource = ds;

                    chart1.Series["Thuê phòng"].XValueMember = "Thang";
                    chart1.Series["Thuê phòng"].YValueMembers = "ThuePhong";
                    chart1.Series["Dịch vụ"].XValueMember = "Thang";
                    chart1.Series["Dịch vụ"].YValueMembers = "DichVu";
                    chart1.Series["Tổng"].XValueMember = "Thang";
                    chart1.Series["Tổng"].YValueMembers = "total";
                    chart1.Titles.Add("BIỂU ĐỒ THỐNG KÊ DOANH THU NĂM "+cbo1.Text);

                    conn.Dispose();

                }
            }


            if (rdoTheoThang.Checked)
            {
                lbThongbao.Text = "BẢNG THỐNG KÊ DOANH THU THÁNG " + cbo2.Text +" NĂM "+cbo1.Text;
                // khai báo SqlConnection
                conn = new SqlConnection(ConnectionString);

                //Mở kết nối 
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                //Khai báo câu truy vấn 


                string sql = "Select B.NgayRa as Ngay , B.GIaThue as ThuePhong, A.TongTien as total, A.TongTien-B.GIaThue as DichVu from tbl_HopDong B inner join tblHoaDon A  on DATEPART(MM,B.NgayRa) = DATEPART(MM,A.NgayLap) where DATEPART(MM,B.NgayRa)=" + cbo2.Text + "and DATEPART(YYYY,B.NgayRa)=" + cbo1.Text;
                SqlCommand command = new SqlCommand(sql, conn);

                SqlDataAdapter da = new SqlDataAdapter(command);
                //Khai báo Dataset
                ds = new DataSet();
                //fill dữ liệu 
                da.Fill(ds);
                dgvDoanhThu.DataSource = ds.Tables[0];
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    decimal sumTotal = 0;
                    decimal sumDichVu = 0;
                    decimal SumPhongThue = 0;
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {

                        sumTotal += Convert.ToDecimal(dr["total"]);
                        sumDichVu += Convert.ToDecimal(dr["DichVu"]);
                        SumPhongThue += Convert.ToDecimal(dr["ThuePhong"]);
                    }
                    txtThongke.Text = "Tổng doanh thu tháng " + cbo2.Text + "năm " + cbo1.Text + ": " + sumTotal + " vnđ \r\n" + "Trong đó :\r\n Doanh thu dịch vụ :" + sumDichVu + "vnđ\r\n Doanh Thu thêu Phòng : " + SumPhongThue + "vnđ";
                    chart1.Titles.Clear();
                    chart1.DataSource = ds;


                    chart1.Series["Thuê phòng"].XValueType = ChartValueType.DateTime;
                    chart1.Series["Thuê phòng"].XValueMember = "Ngay";
            
                
                    chart1.Series["Thuê phòng"].YValueMembers = "ThuePhong";
                    chart1.Series["Dịch vụ"].XValueType = ChartValueType.DateTime;
                    chart1.Series["Dịch vụ"].XValueMember = "Ngay";
                    chart1.Series["Dịch vụ"].YValueMembers = "DichVu";
                    chart1.Series["Tổng"].XValueType = ChartValueType.DateTime;
                    chart1.Series["Tổng"].XValueMember = "Ngay";
                    chart1.Series["Tổng"].YValueMembers = "total";
                    chart1.Titles.Add("BIỂU ĐỒ THỐNG KÊ DOANH THU THÁNG "+cbo2.Text + " NĂM "+cbo1.Text);

                    conn.Dispose();


                }
            }
            if (rdoTheoNgay.Checked)
            {   
                if(dtpNgay1.Text == dtpNgay2.Text)
                {
                    MessageBox.Show("cần nhập ngày khác nhau");
                    return;
                }
                if(dtpNgay1.Value >= dtpNgay2.Value)
                {
                    MessageBox.Show("cần nhập ngày ");
                    return;
                }
                lbThongbao.Text = "BẢNG THỐNG KÊ DOANH THU TỪ NGÀY " + dtpNgay1.Text + " ĐẾN NGÀY " + dtpNgay2.Text;

                // khai báo SqlConnection
                conn = new SqlConnection(ConnectionString);

                //Mở kết nối 
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                //Khai báo câu truy vấn 


                string sql = "Select B.NgayRa as Ngay , B.GIaThue as ThuePhong, A.TongTien as total, A.TongTien-B.GIaThue as DichVu from tbl_HopDong B inner join tblHoaDon A  on DATEPART(MM,B.NgayRa) = DATEPART(MM,A.NgayLap) where B.NgayRa >= '"+dtpNgay1.Value+"'and B.NgayRa <='"+dtpNgay2.Value+"'";
                SqlCommand command = new SqlCommand(sql, conn);

                SqlDataAdapter da = new SqlDataAdapter(command);
                //Khai báo Dataset
                ds = new DataSet();
                //fill dữ liệu 
                da.Fill(ds);
                dgvDoanhThu.DataSource = ds.Tables[0];
                decimal sumTotal = 0;
                decimal sumDichVu = 0;
                decimal SumPhongThue = 0;
                foreach (DataRow dr in ds.Tables[0].Rows)
                {

                    sumTotal += Convert.ToDecimal(dr["total"]);
                    sumDichVu += Convert.ToDecimal(dr["DichVu"]);
                    SumPhongThue += Convert.ToDecimal(dr["ThuePhong"]);
                }
                txtThongke.Text = "Tổng doanh thu tháng " + cbo2.Text + "năm " + cbo1.Text + ": " + sumTotal + " vnđ \r\n" + "Trong đó :\r\n Doanh thu dịch vụ :" + sumDichVu + "vnđ\r\n Doanh Thu thêu Phòng : " + SumPhongThue + "vnđ";
                chart1.Titles.Clear();
                
                chart1.DataSource = ds;

                chart1.Series["Thuê phòng"].XValueType = ChartValueType.DateTime;
             
                chart1.Series["Thuê phòng"].XValueMember = "Ngay";
                chart1.Series["Thuê phòng"].YValueMembers = "ThuePhong";
                chart1.Series["Dịch vụ"].XValueType = ChartValueType.DateTime;
                chart1.Series["Dịch vụ"].XValueMember = "Ngay";
                chart1.Series["Dịch vụ"].YValueMembers = "DichVu";
                chart1.Series["Tổng"].XValueType = ChartValueType.DateTime;
                chart1.Series["Tổng"].XValueMember = "Ngay";
                chart1.Series["Tổng"].YValueMembers = "total";
                chart1.Titles.Add("BIỂU ĐỒ THỐNG KÊ DOANH THU Từ NGÀY "+dtpNgay1.Text + " ĐẾN NGÀY "+dtpNgay2.Text );

                conn.Dispose();
            }
        }



    }
}
