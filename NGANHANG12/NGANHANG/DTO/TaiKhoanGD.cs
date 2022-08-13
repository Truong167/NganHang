using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGANHANG.DTO
{
    public class TaiKhoanGD
    {
        private string soTK;
        private string cmnd;
        private double soDu;
        private string maCN;
        private DateTime ngayMoTK;

        public TaiKhoanGD(string soTK, string cmnd, double soDu, string maCN, DateTime ngayMoTK)
        {
            this.soTK = soTK;
            this.cmnd = cmnd;
            this.soDu = soDu;
            this.maCN = maCN;
            this.ngayMoTK = ngayMoTK;
        }

        public string SoTK { get => soTK; set => soTK = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public double SoDu { get => soDu; set => soDu = value; }
        public string MaCN { get => maCN; set => maCN = value; }
        public DateTime NgayMoTK { get => ngayMoTK; set => ngayMoTK = value; }
    }
}
