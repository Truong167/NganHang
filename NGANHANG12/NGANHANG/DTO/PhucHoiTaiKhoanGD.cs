using NGANHANG.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGANHANG.DTO
{
    public class PhucHoiTaiKhoanGD
    {
        private TaiKhoanGD taiKhoanGD;
        private int chucNang;

        public const int CHUCNANG_MOTK = 0;

        public PhucHoiTaiKhoanGD(TaiKhoanGD taiKhoanGD, int chucNang)
        {
            this.taiKhoanGD = taiKhoanGD;
            this.chucNang = chucNang;
        }
        public string PhucHoi()
        {
            if (taiKhoanGD == null)
                return null;
            if (chucNang == CHUCNANG_MOTK)
            {
                if (TaiKhoanGDDAO.Instance.XoaTaiKhoanKH(taiKhoanGD.SoTK))
                    return taiKhoanGD.SoTK;
            }
            return null;
        }
    }
}
