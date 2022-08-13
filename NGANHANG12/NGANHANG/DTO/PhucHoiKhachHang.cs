using NGANHANG.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGANHANG.DTO
{
    class PhucHoiKhachHang
    {
       
        private KhachHang khachHang;
        private int chucNang;

        public const int CHUCNANG_THEM = 0;
        public const int CHUCNANG_SUA = 1;
        public const int CHUCNANG_XOA = 2;

        public PhucHoiKhachHang(KhachHang khachHang, int chucNang)
        {
            this.khachHang = khachHang;
            this.chucNang = chucNang;
        }

        public string PhucHoi()
        {
            if (khachHang == null)
                return null;
            if (chucNang == CHUCNANG_THEM)
            {
                if (KhachHangDAO.Instance.XoaKhachHang(khachHang.Cmnd))
                {
                    return khachHang.Cmnd;
                }
            }
            else if (chucNang == CHUCNANG_SUA)
            {
                if (KhachHangDAO.Instance.CapNhatKhachHang(khachHang))
                {
                    return khachHang.Cmnd;
                }
            }
            else if (chucNang == CHUCNANG_XOA)
            {
                if (KhachHangDAO.Instance.ThemKhachHang(khachHang))
                {
                    return khachHang.Cmnd;
                }
            }
            return null;
        }
    }
}
