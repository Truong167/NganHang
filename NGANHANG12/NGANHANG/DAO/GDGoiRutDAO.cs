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
    public class GDGoiRutDAO
    {
        private static GDGoiRutDAO instance;
        public static GDGoiRutDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new GDGoiRutDAO();
                return instance;
            }
        }
        public string GetTenKhachCoSoTK(string soTK)
        {
            string query = "EXEC SP_TIM_KHACHHANG_SOTK @SOTK";
            try
            {
                DataTable dt = DataProvider.Instance.ExecuteQuerry(query, new object[] { soTK });
                return (string)dt.Rows[0]["HoTen"];
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
                return "";
            }
        }
        public bool ThucHienGDGoiRut(GDGoiRut giaoDich)
        {
            string query = "EXEC SP_THEM_GD_GOIRUT @SOTK , @LOAIGD , @SOTIEN , @MANV";
            try
            {
                DataProvider.Instance.ExecuteNonQuerry(query,
                    new object[] { giaoDich.SoTK, giaoDich.LoaiGD, giaoDich.SoTien, giaoDich.MaNV });
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show("ERROR: Có lỗi khi thực hiện giao dịch gởi rút. " + e.Message);
                return false;
            }
        }
    }
}
