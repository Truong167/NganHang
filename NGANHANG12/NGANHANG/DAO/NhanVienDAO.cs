using DangTinThueTro.DAO;
using NGANHANG.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NGANHANG.DAO
{
    public class NhanVienDAO
    {
        private static NhanVienDAO instance = null;

        public const int XOA_THATBAI = -1;
        public const int XOA_MEM = 0;
        public const int XOA_CUNG = 1;
        
        public static NhanVienDAO Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new NhanVienDAO();
                }
                return instance;
            }
        }
        public bool ThemNhanVien(NhanVien nhanVien)
        {
            string query = "EXEC SP_THEM_NHANVIEN @MANV , @HO , @TEN , @DIACHI , @PHAI , @SODT";
            try
            {
                DataProvider.Instance.ExecuteNonQuerry(query,
                    new object[] {nhanVien.MaNV, nhanVien.Ho, nhanVien.Ten, nhanVien.DiaChi, 
                        nhanVien.Phai, nhanVien.SoDT});
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show("ERROR: Có lỗi khi thêm nhân viên. " + e.Message);
                return false;
            }
        }
        public bool CapNhatNhanVien(NhanVien nhanVien)
        {
            string query = "EXEC SP_CAPNHAT_NHANVIEN @MANV , @HO , @TEN , @DIACHI , @PHAI , @SODT , @TRANGTHAIXOA";
            try
            {
                DataProvider.Instance.ExecuteNonQuerry(query,
                    new object[] {nhanVien.MaNV, nhanVien.Ho, nhanVien.Ten, nhanVien.DiaChi,
                        nhanVien.Phai, nhanVien.SoDT, nhanVien.TrangThaiXoa});
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR: Có lỗi khi cập nhật nhân viên. " + e.Message);
                return false;
            }
        }
        public int XoaNhanVien(string maNV)
        {
            string query = "EXEC SP_XOA_NHANVIEN @MANV";
            try
            {
                DataTable dt = DataProvider.Instance.ExecuteQuerry(query, new object[] {maNV });
                DataRow dr = dt.Rows[0];
                return (int)dr["KetQua"];
            }
            catch(Exception e)
            {
                MessageBox.Show("ERROR: Có lỗi khi xóa nhân viên. " + e.Message);
                return XOA_THATBAI;
            }
        }
        public bool ChuyenCNNhanVien(string maNVMoi, NhanVien nhanVien)
        {
            string query = "exec SP_CHUYEN_CN_NHANVIEN @MANVCU , @MANVMOI , @HO , @TEN , @DIACHI , @PHAI , @SODT ";
            try
            {
                DataProvider.Instance.ExecuteNonQuerry(query, new object[] {
                    nhanVien.MaNV, maNVMoi, nhanVien.Ho, nhanVien.Ten, nhanVien.DiaChi, nhanVien.Phai, nhanVien.SoDT
                });
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "", MessageBoxButtons.OK);
                return false;
            }
        }
        public bool ChuyenChiNhanh(string maNVMoi, NhanVien nhanVien, string serverMoi)
        {
            string maNVCu = nhanVien.MaNV;
            nhanVien.MaNV = maNVMoi;

            DataProvider.Instance.SetConnectionStr(serverMoi, DataProvider.LOGIN_HTKN, DataProvider.PASSWORD_HTKN);
            if (ThemNhanVien(nhanVien)) // Thêm nhân viên vào chi nhánh mới thành công
            {
                nhanVien.MaNV = maNVCu;
                nhanVien.TrangThaiXoa = 1;
                DataProvider.Instance.SetConnectionStr(TaiKhoanLoginDAO.Instance.Server, TaiKhoanLoginDAO.Instance.TaiKhoan, TaiKhoanLoginDAO.Instance.MatKhau);
                if (CapNhatNhanVien(nhanVien)) // Xóa nhân viên chi nhánh cũ thành công
                {
                    return true;
                }
                else
                {
                    DataProvider.Instance.SetConnectionStr(serverMoi, DataProvider.LOGIN_HTKN, DataProvider.PASSWORD_HTKN);
                    XoaNhanVien(maNVMoi);
                }
            }
            DataProvider.Instance.SetConnectionStr(TaiKhoanLoginDAO.Instance.Server, TaiKhoanLoginDAO.Instance.TaiKhoan, TaiKhoanLoginDAO.Instance.MatKhau);
            return false;
        }
    }
}
