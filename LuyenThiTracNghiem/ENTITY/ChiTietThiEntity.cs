using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuyenThiTracNghiem
{
    class ChiTietThiEntity
    {
        public int idCTT { get; set; }
        public DateTime ngayThi { get; set; }
        public double diem { get; set; }
        public string maTaiKhoan { get; set; }
        public string maMonHoc { get; set; }
        public TaiKhoanEntity taiKhoanEntity { get; set; }
        public MonHocEntity monHocEntity { get; set; }

    }
}
