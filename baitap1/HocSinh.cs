using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace baitap1
{
    internal class HocSinh
    {
       
        public string Mahs { get; set; }
        public string Hoten { get; set; }
        public string Phai { get; set; }
        public string Diachi { get; set; }
        public float Điemtoan { get; set; }
        public float Diemhoa { get; set; }
        public float Diemly { get; set; } 
       
       
        public float Dtb
        {
            get
            {
                return (Điemtoan + Diemhoa + Diemly) / 3;

            }
        }
        public HocSinh (string mahs, string hoten, string phai, string diachi, float toan, float hoa, float ly)
        {
           Mahs = mahs;
            Hoten = hoten; 
            Phai = phai;
            Diachi = diachi;
              Diemly = ly;
            Diemhoa = hoa;
            Điemtoan = toan;

       


    }
}
}
