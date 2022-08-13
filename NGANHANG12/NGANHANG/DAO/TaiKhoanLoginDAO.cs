using DangTinThueTro.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NGANHANG.DTO
{
    public class TaiKhoanLoginDAO
    {
        private static TaiKhoanLoginDAO instance;
        private string maNV;
        private string hoTen;
        private string nhomQuyen;
        private string maCN = "";

        private string taiKhoan;
        private string matKhau;
        private string server;

        private BindingSource bindingSourceChiNhanh;
        public static TaiKhoanLoginDAO Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new TaiKhoanLoginDAO();
                }
                return instance;
            }
        }

        // Đăng nhập
        public bool DangNhap(string taiKhoan, string matKhau, string server)
        {
            DataProvider.Instance.SetConnectionStr(server, taiKhoan, matKhau);
            string query = "EXEC SP_Lay_Thong_Tin_NV_Tu_Login @TENLOGIN";
            try
            {
                if (DataProvider.Instance.OpenConnection()) // Nếu kết nối thành công
                {
                    // Lấy dữ liệu từ db bằng data reader
                    SqlDataReader reader = DataProvider.Instance.ExecuteSqlDataReader(query, new object[] { taiKhoan });
                    // Đọc dữ liệu
                    reader.Read();
                    if (reader == null)
                    {
                        reader.Close();
                        return false;
                    }
                    if (Convert.IsDBNull(reader.GetString(0)))
                    {
                        MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu", "", MessageBoxButtons.OK);
                        reader.Close();
                        return false;
                    }
                    maNV = reader.GetString(0);
                    if(!maNV.Equals("")) // Nếu nhân viên đã nghỉ việc thì mã nv = ""
                    {
                        this.taiKhoan = taiKhoan;
                        this.matKhau = matKhau;
                        this.server = server;
                        hoTen = reader.GetString(1);
                        nhomQuyen = reader.GetString(2);
                        reader.Close();
                        DataProvider.Instance.CloseConnection();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                return false;
            }
            catch(Exception e)
            {
                MessageBox.Show("ERROR: Có lỗi khi đăng nhập. " + e.Message);
                return false;
            }
        }
        public void LoadMaCN()
        {
            if (DataProvider.Instance.OpenConnection())
            {
                SqlDataReader reader = DataProvider.Instance.ExecuteSqlDataReader("SELECT MACN FROM CHINHANH", null);
                reader.Read();
                maCN = reader.GetString(0);
                reader.Close();
                DataProvider.Instance.CloseConnection();
            }
        }
        public BindingSource GetListNhanVienChuaCoTK()
        {
            string query = "EXEC SP_GET_NHANVIEN_KO_TK";
            try
            {
                DataTable dt = DataProvider.Instance.ExecuteQuerry(query);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt;
                return bindingSource;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "", MessageBoxButtons.OK);
                return null;
            }
        }
        public bool ThemLogin(TaiKhoanLogin taiKhoan)
        {
            string query = "EXEC SP_THEM_LOGIN @LGNAME , @PASS , @USERNAME , @ROLE";
            try
            {
                DataProvider.Instance.ExecuteNonQuerry(query, new object[]
                {
                    taiKhoan.LoginName, taiKhoan.Password, taiKhoan.LoginName, taiKhoan.Role
                });
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR: Có lỗi khi thêm login. " + e.Message);
                return false;
            }
        }
        public bool XoaLogin(TaiKhoanLogin taiKhoan)
        {
            string query = "EXEC SP_XOA_LOGIN @LGNAME , @USERNAME";
            try
            {
                DataProvider.Instance.ExecuteNonQuerry(query, new object[] { taiKhoan.LoginName, taiKhoan.LoginName });
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR: Có lỗi khi xóa login. " + e.Message);
                return false;
            }
        }
        public string MaNV { get => maNV;}
        public string HoTen { get => hoTen;}
        public string NhomQuyen { get => nhomQuyen;}
        public string MaCN { get => maCN;}
        public BindingSource BindingSourceChiNhanh { get => bindingSourceChiNhanh; set => bindingSourceChiNhanh = value; }
        public string TaiKhoan { get => taiKhoan; }
        public string MatKhau { get => matKhau; }
        public string Server { get => server;}
    }
}
