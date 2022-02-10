using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LuyenThiTracNghiem
{
    class MonHocRepository
    {
        private string url = "https://qlttn.herokuapp.com/api/monhoc";
        HttpClient client = new HttpClient();
        public async Task GetMonHoc()
        {
            string response = await client.GetStringAsync(url);
            client.Dispose();
        }
    }
}
