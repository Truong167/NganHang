using DangTinThueTro.DAO;
using NGANHANG.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NGANHANG.DAO
{
    class KhachHangDAO
    {
        public static KhachHangDAO instance = null;

        public static KhachHangDAO Instance {
            get
            {
                if (instance == null)
                {
                    instance = new KhachHangDAO();
                }
                return instance;
            }
        }

        public bool ThemKhachHang(KhachHang khachHang)
        {
            string query = "EXEC SP_THEM_KHACHHANG @CMND , @HO , @TEN , @DIACHI , @PHAI , @NGAYCAP , @SODT , @MACN";
            try
            {
                DataProvider.Instance.ExecuteNonQuerry(query,
                    new object[] {khachHang.Cmnd, khachHang.Ho, khachHang.Ten, khachHang.DiaChi,
                        khachHang.Phai, khachHang.NgayCap, khachHang.SoDT, khachHang.MaCN});
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR: Có lỗi khi thêm khách hàng. " + e.Message);
                return false;
            }
        }

        public bool CapNhatKhachHang(KhachHang khachHang)
        {
            string query = "EXEC SP_CAPNHAT_KHACHHANG @CMND , @HO , @TEN , @DIACHI , @PHAI , @NGAYCAP , @SODT";
            try
            {
                DataProvider.Instance.ExecuteNonQuerry(query,
                    new object[] {khachHang.Cmnd, khachHang.Ho, khachHang.Ten, khachHang.DiaChi, khachHang.Phai, khachHang.NgayCap, khachHang.SoDT});
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR: Có lỗi khi cập nhật khách hàng. " + e.Message);
                return false;
            }
        }

        public bool XoaKhachHang(string cmnd)
        {
            string query = "EXEC SP_XOA_KHACHHANG @CMND";
            try
            {
                DataProvider.Instance.ExecuteNonQuerry(query, new object[] { cmnd });
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR: Có lỗi khi xóa khách hàng. " + e.Message);
                return false;
            }
        }
    }
}
