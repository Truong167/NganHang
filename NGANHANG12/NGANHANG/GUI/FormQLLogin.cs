using DangTinThueTro.DAO;
using NGANHANG.DTO;
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
    public partial class FormQLLogin : Form
    {
        private BindingSource bindingSourceNhanVien;
        private Stack<TaiKhoanLogin> stackPhucHoi = new Stack<TaiKhoanLogin>();
        public FormQLLogin()
        {
            InitializeComponent();
            LoadData();
            LoadComboxChiNhanh();
        }
        private void LoadData()
        {
            bindingSourceNhanVien = TaiKhoanLoginDAO.Instance.GetListNhanVienChuaCoTK();
            gridControlNhanVien.DataSource = bindingSourceNhanVien;
        }
        private void LoadComboxChiNhanh()
        {
            comboxChiNhanh.DataSource = TaiKhoanLoginDAO.Instance.BindingSourceChiNhanh;
            comboxChiNhanh.DisplayMember = "TENCN";
            comboxChiNhanh.ValueMember = "TENSERVER";
            if (TaiKhoanLoginDAO.Instance.NhomQuyen.Equals(NhanVien.ROLE_NGANHANG))
            {
                comboxChiNhanh.Enabled = true;
            }
        }

        private void gridViewNhanVien_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if(bindingSourceNhanVien != null)
            {
                DataRowView current = (DataRowView)bindingSourceNhanVien.Current;
                if (current != null)
                {
                    txtTaiKhoan.Text = ((string)current["MaNV"]).Trim();
                }
            }
        }

        private bool InputHopLe()
        {
            if(txtMatKhau.Text.Equals("") || txtMatKhauXacNhan.Text.Equals(""))
            {
                MessageBox.Show("Input không được trống");
                return false;
            }
            if (!txtMatKhau.Text.Equals(txtMatKhauXacNhan.Text))
            {
                MessageBox.Show("Xác nhận mật khẩu không khớp");
                return false;
            }
            return true;
        }
        private void ResetComponent()
        {
            btnPhucHoi.Enabled = stackPhucHoi.Count > 0 ? true : false;
            txtTaiKhoan.ResetText();
            txtMatKhau.ResetText();
            txtMatKhauXacNhan.ResetText();
        }
        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (InputHopLe())
            {
                string loginName = txtTaiKhoan.Text;
                string password = txtMatKhau.Text;
                string role = TaiKhoanLoginDAO.Instance.NhomQuyen;
                TaiKhoanLogin taiKhoan = new TaiKhoanLogin(loginName, password, role);
                if (TaiKhoanLoginDAO.Instance.ThemLogin(taiKhoan))
                {
                    MessageBox.Show("Thêm login thành công");
                    stackPhucHoi.Push(taiKhoan);
                    ResetComponent();
                    LoadData();
                }
                else
                    MessageBox.Show("Thêm login thất bại");
            }
        }

        private void comboxChiNhanh_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboxChiNhanh.SelectedValue.ToString().Equals("System.Data.DataRowView"))
                return;

            if (!comboxChiNhanh.SelectedValue.ToString().Equals(TaiKhoanLoginDAO.Instance.Server))
            {
                DataProvider.Instance.SetConnectionStr(
                    comboxChiNhanh.SelectedValue.ToString(),
                    DataProvider.LOGIN_HTKN,
                    DataProvider.PASSWORD_HTKN);
            }
            else
            {
                DataProvider.Instance.SetConnectionStr(
                    TaiKhoanLoginDAO.Instance.Server,
                    TaiKhoanLoginDAO.Instance.TaiKhoan,
                    TaiKhoanLoginDAO.Instance.MatKhau);
            }
            LoadData();
        }

        private void btnPhucHoi_Click(object sender, EventArgs e)
        {
            TaiKhoanLogin taiKhoan = stackPhucHoi.Pop();
            if (TaiKhoanLoginDAO.Instance.XoaLogin(taiKhoan))
                MessageBox.Show("Phục hồi thao tác thành công");
            else
                MessageBox.Show("Phục hồi thao tác thất bại");
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
