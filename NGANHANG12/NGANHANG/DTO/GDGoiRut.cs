using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGANHANG.DTO
{
    public class GDGoiRut
    {
        private string soTK;
        private string loaiGD;
        private double soTien;
        private string maNV;

        public static string GD_GOITIEN = "GT";
        public static string GD_RUTTIEN = "RT";
        public static double SOTIEN_MIN = 100000;

        public GDGoiRut(string soTK, string loaiGD, double soTien, string maNV)
        {
            this.soTK = soTK;
            this.loaiGD = loaiGD;
            this.soTien = soTien;
            this.maNV = maNV;
        }
        public string SoTK { get => soTK; set => soTK = value; }
        public string LoaiGD { get => loaiGD; set => loaiGD = value; }
        public double SoTien { get => soTien; set => soTien = value; }
        public string MaNV { get => maNV; set => maNV = value; }
    }
}
