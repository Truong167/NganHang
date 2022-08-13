using NGANHANG.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NGANHANG.DTO
{
    public class PhucHoiNhanVien
    {
        // Nếu thêm: nhanVien là nhân viên vừa thêm
        // Nếu xóa: nhanVien là nhân viên vừa xóa
        // Nếu sửa: nhanVien là nhân viên trước khi sửa
        private NhanVien nhanVien;
        private int chucNang;

        public const int CHUCNANG_THEM = 0;
        public const int CHUCNANG_XOA = 1;
        public const int CHUCNANG_SUA = 2;

        public PhucHoiNhanVien(NhanVien nhanVien, int chucNang)
        {
            this.nhanVien = nhanVien;
            this.chucNang = chucNang;
        }

        public string PhucHoi()
        {
            if (nhanVien == null)
                return null;
            if(chucNang == CHUCNANG_THEM)
            {
                if (NhanVienDAO.Instance.XoaNhanVien(nhanVien.MaNV) == NhanVienDAO.XOA_CUNG)
                {
                    return nhanVien.MaNV;
                }
            }
            else if(chucNang == CHUCNANG_XOA)
            {
                if (NhanVienDAO.Instance.ThemNhanVien(nhanVien))
                {
                    return nhanVien.MaNV;
                }
            }
            else if(chucNang == CHUCNANG_SUA)
            {
                if (NhanVienDAO.Instance.CapNhatNhanVien(nhanVien))
                {
                    return nhanVien.MaNV;
                }
            }
            return null;
        }
    }
}
