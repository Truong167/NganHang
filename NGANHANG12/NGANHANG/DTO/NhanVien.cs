using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGANHANG.DTO
{
    public class NhanVien
    {
        private string maNV;
        private string ho;
        private string ten;
        private string diaChi;
        private string phai;
        private string soDT;
        private string maCN;
        private int trangThaiXoa;

        public const string ROLE_CHINHANH = "CHINHANH";
        public const string ROLE_NGANHANG = "NGANHANG";

        // Contructor insert db
        public NhanVien(string maNV, string ho, string ten, string diaChi, string phai, string soDT, string maCN)
        {
            this.maNV = maNV;
            this.ho = ho;
            this.ten = ten;
            this.diaChi = diaChi;
            this.phai = phai;
            this.soDT = soDT;
            this.maCN = maCN;
        }
        // Constructor phục hồi
        public NhanVien(string maNV, string ho, string ten, string diaChi, string phai, string soDT, string maCN, int trangThaiXoa)
        {
            this.maNV = maNV;
            this.ho = ho;
            this.ten = ten;
            this.diaChi = diaChi;
            this.phai = phai;
            this.soDT = soDT;
            this.maCN = maCN;
            this.trangThaiXoa = trangThaiXoa;
        }

        public string MaNV { get => maNV; set => maNV = value; }
        public string Ho { get => ho; set => ho = value; }
        public string Ten { get => ten; set => ten = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Phai { get => phai; set => phai = value; }
        public string SoDT { get => soDT; set => soDT = value; }
        public string MaCN { get => maCN; set => maCN = value; }
        public int TrangThaiXoa { get => trangThaiXoa; set => trangThaiXoa = value; }
    }
}
