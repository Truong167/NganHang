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
    class ChuyenTienDAO
    {
        private static ChuyenTienDAO instance;

        public static ChuyenTienDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChuyenTienDAO();
                return instance;
            }
        }

        public bool ThucHienGDChuyenTien(GDChuyenTien giaoDich)
        {
            string query = "EXEC SP_CHUYEN_TIEN @SOTK_CHUYEN , @SOTK_NHAN , @SOTIEN , @MANV";
            try
            {
                DataProvider.Instance.ExecuteNonQuerry(query,
                    new object[] { giaoDich.SoTKC, giaoDich.SoTKN, giaoDich.SoTien, giaoDich.MaNV });
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR: Có lỗi khi thực hiện giao dịch gởi rút. " + e.Message);
                return false;
            }
        }
    }
}
