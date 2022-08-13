using DevExpress.XtraReports.UI;
using NGANHANG.DTO;
using NGANHANG.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NGANHANG.GUI
{
    public partial class FormMain : Form
    {
        private int btnThucThi = -1;
        private const int BTN_QLNHANVIEN = 0;
        private const int BTN_QLLOGIN = 1;
        private const int BTN_QLKHACHHANG = 2;
        private const int BTN_MOTAIKHOANGD = 3;
        private const int BTN_GOIRUT = 4;
        private const int BTN_CHUYENTIEN = 5;

        private bool isDangXuat = false;
        private FormDangNhap formDangNhap;

        private FormQLNhanVien formNhanVien;
        private FormQLLogin formQLLogin;
        private FormQLKhachHang formKhachHang;
        private FormMoTaiKhoanGD formMoTaiKhoanGD;
        private FormGDGoiRut formGDGoiRut;
        private FormGDChuyenTien formChuyenTien;
        public FormMain(FormDangNhap formDangNhap)
        {
            InitializeComponent();
            this.formDangNhap = formDangNhap;
            LoadData();
            LoadUI();
        }
        private void LoadData()
        {
            formNhanVien = new FormQLNhanVien();
            formQLLogin = new FormQLLogin();
            formKhachHang = new FormQLKhachHang();
            if (!TaiKhoanLoginDAO.Instance.NhomQuyen.Equals(NhanVien.ROLE_NGANHANG))
            {
                formMoTaiKhoanGD = new FormMoTaiKhoanGD();
                formGDGoiRut = new FormGDGoiRut();
                formChuyenTien = new FormGDChuyenTien();
            }
        }
        private void LoadUI()
        {
            if (TaiKhoanLoginDAO.Instance.NhomQuyen.Equals(NhanVien.ROLE_NGANHANG))
            {
                btnGuiRut.Visible = false;
                btnChuyenTien.Visible = false;
                btnMoTaiKhoanGD.Visible = false;
                splitter1.Visible = false;
            }
        }

        private void MoFormCon(Form formCon)
        {
            if (!panelFormContainer.Controls.Contains(formCon))
            {
                formCon.TopLevel = false;
                panelFormContainer.Controls.Clear();
                panelFormContainer.Controls.Add(formCon);
                formCon.Show();
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            txtHoTenNV.Text = "Họ tên NV: " + TaiKhoanLoginDAO.Instance.HoTen;
            txtMaNV.Text = "Mã NV: " + TaiKhoanLoginDAO.Instance.MaNV;
            txtNhom.Text = "Nhóm: " + TaiKhoanLoginDAO.Instance.NhomQuyen;
            btnAccount.Text = "      " + TaiKhoanLoginDAO.Instance.HoTen;
        }
        private void EnableButton()
        {
            Color enableColor = Color.FromArgb(33, 35, 55);
            switch (btnThucThi)
            {
                case BTN_QLNHANVIEN:
                    btnNhanVien.Enabled = true;
                    btnNhanVien.BackColor = enableColor;
                    break;
                case BTN_QLLOGIN:
                    btnQLTaiKhoan.Enabled = true;
                    btnQLTaiKhoan.BackColor = enableColor;
                    break;
                case BTN_QLKHACHHANG:
                    btnKhachHang.Enabled = true;
                    btnKhachHang.BackColor = enableColor;
                    break;
                case BTN_MOTAIKHOANGD:
                    btnMoTaiKhoanGD.Enabled = true;
                    btnMoTaiKhoanGD.BackColor = enableColor;
                    break;
                case BTN_GOIRUT:
                    btnGuiRut.Enabled = true;
                    btnGuiRut.BackColor = enableColor;
                    break;
                case BTN_CHUYENTIEN:
                    btnChuyenTien.Enabled = true;
                    btnChuyenTien.BackColor = enableColor;
                    break;
            }
        }
        private void DisableButton()
        {
            Color disableColor = Color.FromArgb(157, 78, 221);
            switch (btnThucThi)
            {
                case BTN_QLNHANVIEN:
                    btnNhanVien.BackColor = disableColor;
                    break;
                case BTN_QLLOGIN:
                    btnQLTaiKhoan.BackColor = disableColor;
                    break;
                case BTN_QLKHACHHANG:
                    btnKhachHang.BackColor = disableColor;
                    break;
                case BTN_MOTAIKHOANGD:
                    btnMoTaiKhoanGD.BackColor = disableColor;
                    break;
                case BTN_GOIRUT:
                    btnGuiRut.BackColor = disableColor;
                    break;
                case BTN_CHUYENTIEN:
                    btnChuyenTien.BackColor = disableColor;
                    break;
            }
        }
        private void btn_employ_Click(object sender, EventArgs e)
        {
            EnableButton();
            btnThucThi = BTN_QLNHANVIEN;
            DisableButton();
            MoFormCon(formNhanVien);
        }
        private void btnQLTaiKhoan_Click(object sender, EventArgs e)
        {
            EnableButton();
            btnThucThi = BTN_QLLOGIN;
            DisableButton();
            MoFormCon(formQLLogin);
        }
        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            EnableButton();
            btnThucThi = BTN_QLKHACHHANG;
            DisableButton();
            MoFormCon(formKhachHang);
        }
        private void btnMoTaiKhoanGD_Click(object sender, EventArgs e)
        {
            EnableButton();
            btnThucThi = BTN_MOTAIKHOANGD;
            DisableButton();
            MoFormCon(formMoTaiKhoanGD);
        }
        private void btnGuiRut_Click(object sender, EventArgs e)
        {
            EnableButton();
            btnThucThi = BTN_GOIRUT;
            DisableButton();
            MoFormCon(formGDGoiRut);
        }
        private void btnChuyenTien_Click(object sender, EventArgs e)
        {
            EnableButton();
            btnThucThi = BTN_CHUYENTIEN;
            DisableButton();
            MoFormCon(formChuyenTien);
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (isDangXuat)
            {
                formDangNhap.Visible = true;
            }
            else
            {
                base.OnFormClosing(e);
                Application.Exit();
            }
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            contextMenuStripOption.Show(this.btnAccount, new Point(50, -(contextMenuStripOption.Height)));
        }
        private void toolStripMenuItemDangXuat_Click(object sender, EventArgs e)
        {
            isDangXuat = true;
            this.Close();
        }
    }
}
