using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuyenThiTracNghiem
{
    class CauHoiEntity
    {
        public int idCH { get; set; }
        public string noiDung { get; set; }
        public string a { get; set; }
        public string b { get; set; }
        public string c { get; set; }
        public string d { get; set; }
        public string dapAn { get; set; }
        public string luaChon { get; set; }
        public string maMonHoc { get; set; }
        public string maTaiKhoan { get; set; }
        public MonHocEntity monHocEntity { get; set; }
        public TaiKhoanEntity taiKhoanEntity { get; set; }

    }
}
