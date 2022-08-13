using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGANHANG.DTO
{
    class GDChuyenTien
    {
        private string soTKC;
        private string soTKN;
        private double soTien;
        private string maNV;

        public GDChuyenTien(string soTKC, string soTKN, double soTien, string maNV)
        {
            this.soTKC = soTKC;
            this.soTKN = soTKN;
            this.SoTien = soTien;
            this.maNV = maNV;
        }

        public string SoTKC { get => soTKC; set => soTKC = value; }
        public string SoTKN { get => soTKN; set => soTKN = value; }
        public double SoTien { get => soTien; set => soTien = value; }
        public string MaNV { get => maNV; set => maNV = value; }
    }
}
