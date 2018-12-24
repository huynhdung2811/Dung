using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1706020012_ThachHuynhDung
{
    class ClsPhong
    {
        public int Maphong { get; set; }
        public string Tenphong { get; set; }
        public double Dongia { get; set; }
        public int Sogiuong { get; set; }
        public int Ma_Trangthai { get; set; }
        public string Trangthai
        {
            get
            {
                if(Ma_Trangthai == 0)
                {
                    return "Phong Trong";
                }
                else
                {
                    return "Co khach";
                }
            }
        }
        public ClsPhong()
        { }
    }
}
