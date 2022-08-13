using DangTinThueTro.DAO;
using NGANHANG.DAO;
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
    public partial class FormGDChuyenTien : Form
    {
        private string soTK = "";
        public FormGDChuyenTien()
        {
            InitializeComponent();
            txtMaNV.Text = TaiKhoanLoginDAO.Instance.MaNV;
        }

        private void FormChuyenTien_Load(object sender, EventArgs e)
        {
            this.dataSet.EnforceConstraints = false;
            this.taiKhoanTableAdapter.Connection.ConnectionString = DataProvider.Instance.GetConnectionStr();
            LoadTaiKhoan();
        }

        private void LoadTaiKhoan()
        {
            this.taiKhoanTableAdapter.Fill(this.dataSet.TaiKhoan);
        }

        private void resetForm()
        {
            this.txtSoTKC.ResetText();
            this.txtSoTKN.ResetText();
            this.txtHoTenNN.ResetText();
            this.txtHoTenNC.ResetText();
            this.txtSoTien.ResetText();
        }

        private bool InputHopLe()
        {
            if (txtSoTien.Text.Trim().Equals("") || txtSoTKC.Text.Trim().Equals("") 
                || txtSoTKN.Text.Trim().Equals(""))
            {
                MessageBox.Show("Các dữ liệu cần thiết không được trống");
                return false;
            }
            if (txtHoTenNC.Text.Trim().Equals("") || txtHoTenNN.Text.Trim().Equals(""))
            {
                MessageBox.Show("Các số tài khoản phải hợp lệ");
                return false;
            }

            if (txtSoTien.Text.Trim().Equals(""))
            {
                MessageBox.Show("Input nhập không hợp lệ:" + txtSoTien.Text.Trim());
                return false;
            }
            if (txtSoTKC.Text.Trim().Equals(txtSoTKN.Text.Trim()))
            {
                MessageBox.Show("2 Số tài khoản không được trùng");
                return false;
            }
            if (Double.Parse(txtSoTien.Text.Trim()) < 0)
            {
                MessageBox.Show("Số tiền giao dịch tối thiểu > 0");
                return false;
            }
            return true;
        }

        private void txtSoTKC_Leave(object sender, EventArgs e)
        {
            if(!txtSoTKC.Text.Equals(""))
                txtHoTenNC.Text = GDGoiRutDAO.Instance.GetTenKhachCoSoTK(txtSoTKC.Text);
        }

        private void txtSoTKN_Leave(object sender, EventArgs e)
        {
            if (!txtSoTKN.Text.Equals(""))
                txtHoTenNN.Text = GDGoiRutDAO.Instance.GetTenKhachCoSoTK(txtSoTKN.Text);
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            txtSoTKC_Leave(txtHoTenNC.Text, EventArgs.Empty);
            txtSoTKN_Leave(txtHoTenNN.Text, EventArgs.Empty);
            if (!InputHopLe())
                return;
            else chuyenTien();
            taiKhoanBindingSource.Position = taiKhoanBindingSource.Find("SOTK", soTK);
        }

        private void chuyenTien()
        {
            GDChuyenTien giaoDich =
                new GDChuyenTien(txtSoTKC.Text.Trim(), txtSoTKN.Text.Trim(), Double.Parse(txtSoTien.Text.Trim()), TaiKhoanLoginDAO.Instance.MaNV);
            if (ChuyenTienDAO.Instance.ThucHienGDChuyenTien(giaoDich))
            {
                MessageBox.Show("Giao dịch thành công " + giaoDich.SoTKC + " " + giaoDich.SoTKN);
                LoadTaiKhoan();
                resetForm();
            }
            else
            {
                MessageBox.Show("Giao dịch thất bại");
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadTaiKhoan();
            resetForm();
        }

        private void txtSoTKC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void taiKhoanGridControl_Click(object sender, EventArgs e)
        {
            soTK = (string)((DataRowView)taiKhoanBindingSource.Current)["SoTK"];
        }
    }
}
