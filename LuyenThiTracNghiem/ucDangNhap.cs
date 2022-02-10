using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuyenThiTracNghiem
{
    public partial class ucDangNhap : UserControl
    {
        public ucDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Đăng Nhập Thành Công!", "Sucessfully!", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                frmMain trangChu = new frmMain();
                trangChu.Show();
            }
            else return;
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn thật sự muốn Thoát?", "Danger!!!", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
            else return;
        }

        private void btnSVDangNhap_Click(object sender, EventArgs e)
        {

        }
    }
}
