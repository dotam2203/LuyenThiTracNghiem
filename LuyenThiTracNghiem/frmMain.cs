using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LuyenThiTracNghiem
{
    public partial class frmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        ucDangNhap dangNhap;

        ucTrangChu trangChu;
        ucChiTietTaiKhoan CTTaiKhoan;
        
        ucQLGiangVien QLGiangVien;
        ucQLSinhVien QLSinhVien;
        ucQLMonHoc QLMonHoc;
        ucQLDeThi QLDeThi;
        ucChiTietThi CTThi;

        ucLuyenThi LuyenThi;
        ucLichSuThi LichSuThi;
        public frmMain()
        {
            InitializeComponent();
        }
        private void HienThiMenu()
        {

        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            dangNhap = new ucDangNhap();
            dangNhap.Dock = DockStyle.Fill;
            mainContainer.Controls.Add(dangNhap);
            controlThiTracNghiem.Visible = false;
        }
        private void controlDangNhap_Click(object sender, EventArgs e)
        {
            dangNhap = new ucDangNhap();
            dangNhap.Dock = DockStyle.Fill;
            mainContainer.Controls.Add(dangNhap);
        }
        private void controlCTTK_Click(object sender, EventArgs e)
        {
            if (CTTaiKhoan == null)
            {
                CTTaiKhoan = new ucChiTietTaiKhoan();
                CTTaiKhoan.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(CTTaiKhoan);
                CTTaiKhoan.BringToFront();//đưa lên trước
            }
            else
                CTTaiKhoan.BringToFront();
            lbTieuDe.Caption = controlCTTK.Text;
        }

        private void controlQLGiangVien_Click(object sender, EventArgs e)
        {
            if (QLGiangVien == null)
            {
                QLGiangVien = new ucQLGiangVien();
                QLGiangVien.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(QLGiangVien);
                QLGiangVien.BringToFront();//đưa lên trước
            }
            else
                QLGiangVien.BringToFront();
            lbTieuDe.Caption = controlQLGiangVien.Text;
        }

        private void controlQLSinhVien_Click(object sender, EventArgs e)
        {
            if (QLSinhVien == null)
            {
                QLSinhVien = new ucQLSinhVien();
                QLSinhVien.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(QLSinhVien);
                QLSinhVien.BringToFront();//đưa lên trước
            }
            else
                QLSinhVien.BringToFront();
            lbTieuDe.Caption = controlQLSinhVien.Text;
        }

        private void controlQLMonHoc_Click(object sender, EventArgs e)
        {
            if (QLMonHoc == null)
            {
                QLMonHoc = new ucQLMonHoc();
                QLMonHoc.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(QLMonHoc);
                QLMonHoc.BringToFront();//đưa lên trước
            }
            else
                QLMonHoc.BringToFront();
            lbTieuDe.Caption = controlQLMonHoc.Text;
        }

        private void controlQLDeThi_Click(object sender, EventArgs e)
        {
            if (QLDeThi == null)
            {
                QLDeThi = new ucQLDeThi();
                QLDeThi.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(QLDeThi);
                QLDeThi.BringToFront();//đưa lên trước
            }
            else
                QLDeThi.BringToFront();
            lbTieuDe.Caption = controlQLDeThi.Text;
        }

        private void controlCTThi_Click(object sender, EventArgs e)
        {
            if (CTThi == null)
            {
                CTThi = new ucChiTietThi();
                CTThi.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(CTThi);
                CTThi.BringToFront();//đưa lên trước
            }
            else
                CTThi.BringToFront();
            lbTieuDe.Caption = controlCTThi.Text;
        }

        private void controlLuyenThi_Click(object sender, EventArgs e)
        {
            if (LuyenThi == null)
            {
                LuyenThi = new ucLuyenThi();
                LuyenThi.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(LuyenThi);
                LuyenThi.BringToFront();//đưa lên trước
            }
            else
                LuyenThi.BringToFront();
            lbTieuDe.Caption = controlLuyenThi.Text;
        }
       
       

        private void controlLichSuThi_Click(object sender, EventArgs e)
        {
            if (LichSuThi == null)
            {
                LichSuThi = new ucLichSuThi();
                LichSuThi.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(LichSuThi);
                LichSuThi.BringToFront();//đưa lên trước
            }
            else
                LichSuThi.BringToFront();
            lbTieuDe.Caption = controlLichSuThi.Text;
        }
        private void controlDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn thật sự muốn Đăng Xuất?", "Cảnh Báo!!!", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                frmDangNhap login = new frmDangNhap();
                login.Show();
            }
            else return;
        }

       
    }
}
