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
    public partial class FormMoTaiKhoanGD : Form
    {
        private Stack<PhucHoiTaiKhoanGD> stackPhucHoi = new Stack<PhucHoiTaiKhoanGD>();
        public FormMoTaiKhoanGD()
        {
            InitializeComponent();
            txtMaCN.Text = TaiKhoanLoginDAO.Instance.MaCN;
            LoadKhachHang();
            LoadTaiKhoan();
            ResetTatCaComponent();
        }

        #region Chức năng
        private void LoadKhachHang()
        {
            this.dS.EnforceConstraints = false;
            this.khachHangTableAdapter.Connection.ConnectionString = DataProvider.Instance.GetConnectionStr();
            this.khachHangTableAdapter.Fill(this.dS.KhachHang);
        }

        private void LoadTaiKhoan()
        {
            this.dS.EnforceConstraints = false;
            this.taiKhoanTableAdapter.Connection.ConnectionString = DataProvider.Instance.GetConnectionStr();
            this.taiKhoanTableAdapter.Fill(this.dS.TaiKhoan);
        }
        private void MoTaiKhoanGD()
        {
            if (InputHopLe())
            {
                TaiKhoanGD taiKhoanGD = this.GetTaiKhoanTuInput();
                if (TaiKhoanGDDAO.Instance.ThemTaiKhoanKH(taiKhoanGD))
                {
                    MessageBox.Show("Mở tài khoản giao dịch thành công");
                    stackPhucHoi.Push(new PhucHoiTaiKhoanGD(taiKhoanGD, PhucHoiTaiKhoanGD.CHUCNANG_MOTK));
                    LoadTaiKhoan();
                    ResetTatCaComponent();
                }
                else
                    MessageBox.Show("Mở tài khoản giao dịch thất bại");
            }
        }

        private void PhucHoi()
        {
            PhucHoiTaiKhoanGD phucHoiTaiKhoanGD = stackPhucHoi.Pop();
            if (phucHoiTaiKhoanGD != null)
            {
                string soTK = phucHoiTaiKhoanGD.PhucHoi();
                if (soTK != null)
                {
                    MessageBox.Show("Phục hồi thành công");
                    LoadTaiKhoan();
                    ResetTatCaComponent();
                }
                else
                {
                    MessageBox.Show("Phục hồi thất bại");
                }
            }
        }

        private TaiKhoanGD GetTaiKhoanTuInput()
        {
            string soTK = txtSoTK.Text;
            string cmnd = txtCmndKH.Text;
            double soDu = 0;
            string maCN = txtMaCN.Text;
            DateTime ngayMoTK = dateEditNgayMoTK.Value;
            return new TaiKhoanGD(soTK, cmnd, soDu, maCN, ngayMoTK);
        }
        #endregion Chức năng


        #region Giao diện

        private void ResetTatCaComponent()
        {
            txtSoTK.ResetText();
            btnPhucHoi.Enabled = stackPhucHoi.Count > 0 ? true : false;
        }

        private bool InputHopLe()
        {
            return !txtCmndKH.Text.Trim().Equals("") && !txtSoTK.Text.Trim().Equals("");
        }
        private void FillInput()
        {
            DataRowView current = (DataRowView)bdsKh.Current;
            if (current != null)
            {
                txtCmndKH.Text = ((string)current["CMND"]).Trim();
                txtHoTenKH.Text = (string)current["Ho"] + " " + (string)current["Ten"];
            }
        }
        #endregion Giao diện


        #region Sự kiện

        private void btnGhi_Click(object sender, EventArgs e)
        {
            MoTaiKhoanGD();
        }

        private void btnPhucHoi_Click(object sender, EventArgs e)
        {
            PhucHoi();
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadKhachHang();
            LoadTaiKhoan();
        }
        private void gridViewKhachHang_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            FillInput();
        }
        private void txtCmndKH_Leave(object sender, EventArgs e)
        {
            string cmndKH = this.txtCmndKH.Text.Trim();
            if (cmndKH.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng cung cấp CMND khách hàng");
                return;
            }
            if (bdsKh.Find("CMND", cmndKH) >= 0)
            {
                bdsKh.Position = bdsKh.Find("CMND", cmndKH);
            }
            if (!TaiKhoanGDDAO.Instance.TimKhachHang(cmndKH).Equals(""))
            {
                txtHoTenKH.Text = TaiKhoanGDDAO.Instance.TimKhachHang(cmndKH);
            }
            else
            {
                FillInput();
                MessageBox.Show("Không tìm thấy khách hàng này, vui lòng kiểm tra lại CMND");
            }
        }

        private void txtCmndKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion Sự kiện
    }
}
