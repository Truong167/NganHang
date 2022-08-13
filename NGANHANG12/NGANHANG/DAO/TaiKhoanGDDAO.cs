using DangTinThueTro.DAO;
using NGANHANG.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NGANHANG.DAO
{
    class TaiKhoanGDDAO
    {
        private static TaiKhoanGDDAO instance = null;

        public static TaiKhoanGDDAO Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new TaiKhoanGDDAO();
                }
                return instance;
            }
        }

        public bool ThemTaiKhoanKH(TaiKhoanGD taiKhoan)
        {
            string query = "EXEC SP_THEM_TAIKHOAN @SOTK , @CMND , @SODU , @MACN , @NGAYMOTK";
            try
            {
                DataProvider.Instance.ExecuteNonQuerry(query,
                    new object[] {taiKhoan.SoTK, taiKhoan.Cmnd, taiKhoan.SoDu, taiKhoan.MaCN, taiKhoan.NgayMoTK});
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show("ERROR: Có lỗi khi cấp tài khoản. " + e.Message);
                return false;
            }
        }
        public bool XoaTaiKhoanKH(string soTK)
        {
            string query = "EXEC SP_XOA_TAIKHOAN_GD @SOTK";
            try
            {
                DataProvider.Instance.ExecuteNonQuerry(query, new object[] {soTK });
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR: Có lỗi khi xóa tài khoản. " + e.Message);
                return false;
            }
        }
        public string TimKhachHang(string cmnd)
        {
            string query = "EXEC SP_TIM_KHACHHANG @CMND";
            try
            {
                DataTable dt = DataProvider.Instance.ExecuteQuerry(query,
                    new object[] {cmnd});
                return dt.Rows[0].Field<string>("Họ và tên");
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR: " + e.Message);
                return "";
            }
        }
    }
}
