
namespace LuyenThiTracNghiem
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mainContainer = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.controlThiTracNghiem = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.controlGroupTaiKhoan = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.controlCTTK = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.controlGroupGiangVien = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.controlQLGiangVien = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.controlQLSinhVien = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.controlQLMonHoc = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.controlQLDeThi = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.controlCTThi = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.controlGroupSinhVien = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.controlLuyenThi = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.controlLichSuThi = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.controlDangNhap = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.controlDangXuat = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.lbTieuDe = new DevExpress.XtraBars.BarStaticItem();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(326, 39);
            this.mainContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(1465, 974);
            this.mainContainer.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.controlThiTracNghiem,
            this.controlDangNhap,
            this.controlDangXuat});
            this.accordionControl1.Location = new System.Drawing.Point(0, 39);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(326, 974);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // controlThiTracNghiem
            // 
            this.controlThiTracNghiem.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.controlGroupTaiKhoan,
            this.controlGroupGiangVien,
            this.controlGroupSinhVien});
            this.controlThiTracNghiem.Name = "controlThiTracNghiem";
            this.controlThiTracNghiem.Text = "Thi Trắc Nghiệm";
            // 
            // controlGroupTaiKhoan
            // 
            this.controlGroupTaiKhoan.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.controlCTTK});
            this.controlGroupTaiKhoan.Expanded = true;
            this.controlGroupTaiKhoan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("controlGroupTaiKhoan.ImageOptions.SvgImage")));
            this.controlGroupTaiKhoan.Name = "controlGroupTaiKhoan";
            this.controlGroupTaiKhoan.Text = "Tài Khoản";
            // 
            // controlCTTK
            // 
            this.controlCTTK.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("controlCTTK.ImageOptions.SvgImage")));
            this.controlCTTK.Name = "controlCTTK";
            this.controlCTTK.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.controlCTTK.Text = "Chi Tiết Tài Khoản";
            this.controlCTTK.Click += new System.EventHandler(this.controlCTTK_Click);
            // 
            // controlGroupGiangVien
            // 
            this.controlGroupGiangVien.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.controlQLGiangVien,
            this.controlQLSinhVien,
            this.controlQLMonHoc,
            this.controlQLDeThi,
            this.controlCTThi});
            this.controlGroupGiangVien.Expanded = true;
            this.controlGroupGiangVien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("controlGroupGiangVien.ImageOptions.SvgImage")));
            this.controlGroupGiangVien.Name = "controlGroupGiangVien";
            this.controlGroupGiangVien.Text = "Giảng Viên";
            // 
            // controlQLGiangVien
            // 
            this.controlQLGiangVien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("controlQLGiangVien.ImageOptions.SvgImage")));
            this.controlQLGiangVien.Name = "controlQLGiangVien";
            this.controlQLGiangVien.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.controlQLGiangVien.Text = "Quản Lý Giảng Viên";
            this.controlQLGiangVien.Click += new System.EventHandler(this.controlQLGiangVien_Click);
            // 
            // controlQLSinhVien
            // 
            this.controlQLSinhVien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("controlQLSinhVien.ImageOptions.SvgImage")));
            this.controlQLSinhVien.Name = "controlQLSinhVien";
            this.controlQLSinhVien.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.controlQLSinhVien.Text = "Quản Lý Sinh Viên";
            this.controlQLSinhVien.Click += new System.EventHandler(this.controlQLSinhVien_Click);
            // 
            // controlQLMonHoc
            // 
            this.controlQLMonHoc.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("controlQLMonHoc.ImageOptions.SvgImage")));
            this.controlQLMonHoc.Name = "controlQLMonHoc";
            this.controlQLMonHoc.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.controlQLMonHoc.Text = "Quản Lý Môn Học";
            this.controlQLMonHoc.Click += new System.EventHandler(this.controlQLMonHoc_Click);
            // 
            // controlQLDeThi
            // 
            this.controlQLDeThi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("controlQLDeThi.ImageOptions.SvgImage")));
            this.controlQLDeThi.Name = "controlQLDeThi";
            this.controlQLDeThi.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.controlQLDeThi.Text = "Quản Lý Đề Thi";
            this.controlQLDeThi.Click += new System.EventHandler(this.controlQLDeThi_Click);
            // 
            // controlCTThi
            // 
            this.controlCTThi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("controlCTThi.ImageOptions.SvgImage")));
            this.controlCTThi.Name = "controlCTThi";
            this.controlCTThi.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.controlCTThi.Text = "Xem Chi Tiết Thi";
            this.controlCTThi.Click += new System.EventHandler(this.controlCTThi_Click);
            // 
            // controlGroupSinhVien
            // 
            this.controlGroupSinhVien.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.controlLuyenThi,
            this.controlLichSuThi});
            this.controlGroupSinhVien.Expanded = true;
            this.controlGroupSinhVien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("controlGroupSinhVien.ImageOptions.SvgImage")));
            this.controlGroupSinhVien.Name = "controlGroupSinhVien";
            this.controlGroupSinhVien.Text = "Sinh Viên";
            // 
            // controlLuyenThi
            // 
            this.controlLuyenThi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("controlLuyenThi.ImageOptions.SvgImage")));
            this.controlLuyenThi.Name = "controlLuyenThi";
            this.controlLuyenThi.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.controlLuyenThi.Text = "Luyện Thi";
            this.controlLuyenThi.Click += new System.EventHandler(this.controlLuyenThi_Click);
            // 
            // controlLichSuThi
            // 
            this.controlLichSuThi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("controlLichSuThi.ImageOptions.SvgImage")));
            this.controlLichSuThi.Name = "controlLichSuThi";
            this.controlLichSuThi.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.controlLichSuThi.Text = "Lịch Sử Thi";
            this.controlLichSuThi.Click += new System.EventHandler(this.controlLichSuThi_Click);
            // 
            // controlDangNhap
            // 
            this.controlDangNhap.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("controlDangNhap.ImageOptions.SvgImage")));
            this.controlDangNhap.Name = "controlDangNhap";
            this.controlDangNhap.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.controlDangNhap.Text = "Đăng Nhập";
            this.controlDangNhap.Click += new System.EventHandler(this.controlDangNhap_Click);
            // 
            // controlDangXuat
            // 
            this.controlDangXuat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("controlDangXuat.ImageOptions.SvgImage")));
            this.controlDangXuat.Name = "controlDangXuat";
            this.controlDangXuat.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.controlDangXuat.Text = "Đăng Xuất";
            this.controlDangXuat.Click += new System.EventHandler(this.controlDangXuat_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.lbTieuDe});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1791, 39);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.lbTieuDe);
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.Caption = "Trang Chủ";
            this.lbTieuDe.Id = 0;
            this.lbTieuDe.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("lbTieuDe.ImageOptions.SvgImage")));
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // frmMain
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1791, 1013);
            this.ControlContainer = this.mainContainer;
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.NavigationControl = this.accordionControl1;
            this.Text = "TRANG CHỦ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer mainContainer;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement controlGroupTaiKhoan;
        private DevExpress.XtraBars.Navigation.AccordionControlElement controlCTTK;
        private DevExpress.XtraBars.Navigation.AccordionControlElement controlGroupGiangVien;
        private DevExpress.XtraBars.Navigation.AccordionControlElement controlQLGiangVien;
        private DevExpress.XtraBars.Navigation.AccordionControlElement controlQLMonHoc;
        private DevExpress.XtraBars.Navigation.AccordionControlElement controlQLDeThi;
        private DevExpress.XtraBars.Navigation.AccordionControlElement controlCTThi;
        private DevExpress.XtraBars.Navigation.AccordionControlElement controlGroupSinhVien;
        private DevExpress.XtraBars.Navigation.AccordionControlElement controlLuyenThi;
        private DevExpress.XtraBars.Navigation.AccordionControlElement controlDangXuat;
        private DevExpress.XtraBars.BarStaticItem lbTieuDe;
        private DevExpress.XtraBars.Navigation.AccordionControlElement controlQLSinhVien;
        private DevExpress.XtraBars.Navigation.AccordionControlElement controlLichSuThi;
        private DevExpress.XtraBars.Navigation.AccordionControlElement controlDangNhap;
        public DevExpress.XtraBars.Navigation.AccordionControlElement controlThiTracNghiem;
    }
}

