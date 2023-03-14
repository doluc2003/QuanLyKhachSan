using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            setDefault();
        }
        void setDefault()
        {
            labelName.Text =  "Xin chào, "+FrmDangNhap.UserName;
            if (FrmDangNhap.Role.ToUpper() == "USER")
            {
                quảnLýTàiKhoảnToolStripMenuItem.Enabled = false;
                quảnLýNhânViênToolStripMenuItem1.Enabled = false;
            }
            else
            {
                quảnLýTàiKhoảnToolStripMenuItem.Enabled = true;
                quảnLýNhânViênToolStripMenuItem1.Enabled = true;
            }


        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không ", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                FrmDangNhap frm = new FrmDangNhap();
                frm.ShowDialog();
                this.Close();
            }
            else return;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDoanhThu frm = new FrmDoanhThu();
            frm.MdiParent = this;
            frm.Show();
    
            
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQuanlyTaiKhoan frm = new FrmQuanlyTaiKhoan();
            frm.MdiParent = this;
            frm.Show();
      
        }

        private void sựKiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQLSukien frm = new FrmQLSukien();
            frm.MdiParent = this;
            frm.Show();
            
        }

        private void đặtPhòngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmDatPhong frm = new FrmDatPhong();
            frm.MdiParent = this;
            frm.Show();
        }

        private void nhậnPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTraPhong frm = new FrmTraPhong();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTraPhong frm = new FrmTraPhong();
            frm.MdiParent = this;
            frm.Show();
        }

        private void đăngKíCaLàmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
