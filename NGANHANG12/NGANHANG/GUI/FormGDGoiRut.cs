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
    public partial class FormGDGoiRut : Form
    {
        private const int CHUCNANG_GOITIEN = 0;
        private const int CHUCNANG_RUTTIEN = 1;

        private string soTK = "";

        private int chucNangThucThi;
        public FormGDGoiRut()
        {
            InitializeComponent();
            ResetTatCaComponent();
        }
        #region Chức năng
        private void GoiTien()
        {
            GDGoiRut giaoDich = new GDGoiRut(txtSoTK.Text, GDGoiRut.GD_GOITIEN, Double.Parse(txtSoTien.Text), txtMaNV.Text);
            if (InputHopLe())
            {
                if (GDGoiRutDAO.Instance.ThucHienGDGoiRut(giaoDich))
                {
                    MessageBox.Show("Giao dịch thành công" + soTK);
                    LoadTaiKhoan();
                    taiKhoanBindingSource.Position = taiKhoanBindingSource.Find("SOTK", soTK);
                    ResetTatCaComponent();
                }
                else
                {
                    MessageBox.Show("Giao dịch thất bại");
                }
            }
        }
        private void RutTien()
        {
            GDGoiRut giaoDich = new GDGoiRut(txtSoTK.Text, GDGoiRut.GD_RUTTIEN, Double.Parse(txtSoTien.Text), txtMaNV.Text);
            if (InputHopLe())
            {
                if (GDGoiRutDAO.Instance.ThucHienGDGoiRut(giaoDich))
                {
                    MessageBox.Show("Giao dịch thành công" + soTK);
                    LoadTaiKhoan();
                    taiKhoanBindingSource.Position = taiKhoanBindingSource.Find("SOTK", soTK);
                    ResetTatCaComponent();
                }
                else
                {
                    MessageBox.Show("Giao dịch thất bại");
                }
            }
        }
        private bool InputHopLe()
        {
            if (txtSoTien.Text.Trim().Equals("")){
                MessageBox.Show("Số tiền giao dịch không được trống");
                return false;
            }
            if(Double.Parse(txtSoTien.Text.Trim()) < GDGoiRut.SOTIEN_MIN)
            {
                MessageBox.Show("Số tiền giao dịch tối thiểu là " + GDGoiRut.SOTIEN_MIN + "VNĐ");
                return false;
            }
            return true;
        }
        #endregion Chức năng
        #region Giao diện
        private void FormGDGoiRut_Load(object sender, EventArgs e)
        {
            this.dataSet.EnforceConstraints = false;
            this.taiKhoanTableAdapter.Connection.ConnectionString = DataProvider.Instance.GetConnectionStr();
            LoadTaiKhoan();
        }
        private void LoadTaiKhoan()
        {
            this.taiKhoanTableAdapter.Fill(this.dataSet.TaiKhoan);
        }
        private void ResetTatCaComponent()
        {
            btnGoiTien.Enabled = true;
            btnRutTien.Enabled = true;
            btnGhi.Enabled = false;
            btnThoat.Enabled = false;

            txtSoTK.ReadOnly = true;
            txtSoTien.ReadOnly = true;

            txtLoaiGD.ResetText();
            txtSoTien.ResetText();
            txtMaNV.ResetText();
        }
        private void ThucThiChucNang()
        {
            // Enable nút và input cần thiết
            btnGoiTien.Enabled = false;
            btnRutTien.Enabled = false;

            btnGhi.Enabled = true;
            btnThoat.Enabled = true;
            
            txtSoTK.ReadOnly = false;
            txtSoTien.ReadOnly = false;
            txtLoaiGD.Text = (chucNangThucThi == CHUCNANG_GOITIEN) ? "Gởi tiền" : "Rút tiền";
            txtMaNV.Text = TaiKhoanLoginDAO.Instance.MaNV;
        }
        private void FillInput()
        {
            DataRowView current = (DataRowView)taiKhoanBindingSource.Current;
            if (current != null)
            {
                txtSoTK.Text = ((string)current["SOTK"]).Trim();
                txtCMND.Text = ((string)current["CMND"]).Trim();
                txtHoTenKH.Text = GDGoiRutDAO.Instance.GetTenKhachCoSoTK(txtSoTK.Text);
            }
        }
        #endregion Giao diện
        #region Sự kiện
        private void btnGoiTien_Click(object sender, EventArgs e)
        {
            chucNangThucThi = CHUCNANG_GOITIEN;
            ThucThiChucNang();
        }
        private void btnRutTien_Click(object sender, EventArgs e)
        {
            chucNangThucThi = CHUCNANG_RUTTIEN;
            ThucThiChucNang();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            ResetTatCaComponent();
        }

        private void gridViewTaiKhoanGD_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            FillInput();
        }

        private void txtSoTK_Leave(object sender, EventArgs e)
        {
            if (!GDGoiRutDAO.Instance.GetTenKhachCoSoTK(txtSoTK.Text).Equals(""))
            {
                taiKhoanBindingSource.Position = taiKhoanBindingSource.Find("SOTK", txtSoTK.Text.Trim());
            }
            else
            {
                FillInput();
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadTaiKhoan();
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            soTK = (string)((DataRowView)taiKhoanBindingSource.Current)["SoTK"];
            switch (chucNangThucThi)
            {
                case CHUCNANG_GOITIEN:
                    GoiTien();
                    break;
                case CHUCNANG_RUTTIEN:
                    RutTien();
                    break;
            }
        }
        private void txtSoTK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion Sự kiện
    }
}
