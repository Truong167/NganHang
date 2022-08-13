using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGANHANG.DTO
{
    class KhachHang
    {
        private string cmnd;
        private string ho;
        private string ten;
        private string diaChi;
        private string phai;
        private DateTime ngayCap;
        private string soDT;
        private string maCN;

        public KhachHang(string cmnd, string ho, string ten, string diaChi, string phai, DateTime ngayCap, string soDT, string maCN)
        {
            this.cmnd = cmnd;
            this.ho = ho;
            this.ten = ten;
            this.diaChi = diaChi;
            this.phai = phai;
            this.ngayCap = ngayCap;
            this.soDT = soDT;
            this.maCN = maCN;
        }

        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string Ho { get => ho; set => ho = value; }
        public string Ten { get => ten; set => ten = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Phai { get => phai; set => phai = value; }
        public DateTime NgayCap { get => ngayCap; set => ngayCap = value; }
        public string SoDT { get => soDT; set => soDT = value; }
        public string MaCN { get => maCN; set => maCN = value; }
    }
}
