using DangTinThueTro.DAO;
using DevExpress.XtraReports.UI;
using NGANHANG.DAO;
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
    public partial class FormQLKhachHang : Form
    {
        private const int CHUCNANG_THEM = 0;
        private const int CHUCNANG_SUA = 1;
        private string tenCN = ""; // LƯU TÊN CHI NHÁNH KHI ĐỔI CHI NHÁNH

        private int chucNangThucThi;
        private string cmnd; // CMND khách hàng của row đang chọn

        private Stack<PhucHoiKhachHang> stackPhucHoi = new Stack<PhucHoiKhachHang>();
        public FormQLKhachHang()
        {
            InitializeComponent();
            ResetTatCaComponent();
            LoadComboboxChiNhanh();
        }

        #region Chức năng

        private void ThemKhachHang()
        {
            KhachHang khachHang = GetKhachHangTuInput();
            if (KhachHangDAO.Instance.ThemKhachHang(khachHang))
            {
                MessageBox.Show("Thêm khách hàng thành công");
                // Reload dữ liệu và giao diện
                this.cmnd = khachHang.Cmnd;
                stackPhucHoi.Push(new PhucHoiKhachHang(khachHang, PhucHoiKhachHang.CHUCNANG_THEM));
                LoadKhachHang();
                ThoatEdit();
            }
            else
            {
                MessageBox.Show("Thêm khách hàng thất bại");
            }
        }
        private void XoaKhachHang()
        {
            if (this.bdsTaiKhoan.Count == 0)
            {
                DialogResult result = MessageBox.Show("Bạn có thực sự muốn xóa khách hàng này?", "Xóa khách hàng", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    KhachHang khachHang = GetKhachHangTuInput();
                    if (KhachHangDAO.Instance.XoaKhachHang(txtCmnd.Text))
                    {
                        MessageBox.Show("Xóa khách hàng thành công");
                        stackPhucHoi.Push(new PhucHoiKhachHang(khachHang, PhucHoiKhachHang.CHUCNANG_XOA));
                        LoadKhachHang();
                        ResetTatCaComponent();
                    }
                    else
                    {
                        MessageBox.Show("Xóa khách hàng thất bại");
                    }
                }
            }
            else
            {
                MessageBox.Show("Không thể xóa khách hàng đã mở tài khoản giao dịch");
            }
        }
        private void CapNhatKhachHang()
        {
            // Tạo đối tượng khách hàng
            KhachHang khachHang = GetKhachHangTuInput();
            // Cập nhật khách hàng
            if (KhachHangDAO.Instance.CapNhatKhachHang(khachHang))
            {
                MessageBox.Show("Cập nhật khách hàng thành công");
                stackPhucHoi.Push(new PhucHoiKhachHang(GetKhachHangTruocCapNhat(), PhucHoiKhachHang.CHUCNANG_SUA));
                LoadKhachHang();
                ThoatEdit();
            }
            else
            {
                MessageBox.Show("Cập nhật khách hàng thất bại");
            }
        }
        private void LoadKhachHang()
        {
            tenCN = comboxChiNhanh.GetItemText(comboxChiNhanh.SelectedItem);
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

        private void ThoatEdit()
        {
            chucNangThucThi = -1;
            ResetTatCaComponent();
            // Thoát thông tin dang edit và focus row đang chọn
            bdsKh.Position = bdsKh.Find("CMND", this.cmnd);
            FillInput();
        }

        private void PhucHoi()
        {
            PhucHoiKhachHang phucHoiKhachHang = stackPhucHoi.Pop();
            if (phucHoiKhachHang != null)
            {
                string Cmnd = phucHoiKhachHang.PhucHoi();
                if (Cmnd != null)
                {
                    MessageBox.Show("Phục hồi thành công");
                    this.cmnd = Cmnd;
                    LoadKhachHang();
                    ThoatEdit();
                }
                else
                {
                    MessageBox.Show("Phục hồi thất bại");
                }
            }
        }

        private void DoiChiNhanh()
        {
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
            LoadKhachHang();
        }
        private KhachHang GetKhachHangTuInput()
        {
            string cmnd = txtCmnd.Text;
            string ho = txtHo.Text;
            string ten = txtTen.Text;
            string diaChi = txtDiaChi.Text;
            string phai = (string)coboxPhai.SelectedItem;
            DateTime date = dtNgayCap.Value;
            string soDT = txtSoDT.Text;
            string maCN = txtMaCN.Text;
            return new KhachHang(cmnd, ho, ten, diaChi, phai, date, soDT, maCN);
        }

        private KhachHang GetKhachHangTruocCapNhat()
        {
            DataRowView current = (DataRowView)bdsKh.Current;
            if (current != null)
            {
                string cmnd = (string)current["CMND"];
                string ho = (string)current["Ho"];
                string ten = (string)current["Ten"];
                string soDT = (string)current["SoDT"];
                string phai = (string)current["Phai"];
                string maCN = (string)current["MaCN"];
                string diaChi = (string)current["DiaChi"];
                DateTime date = (DateTime)current["NgayCap"];
                return new KhachHang(cmnd, ho, ten, diaChi, phai, date, soDT, maCN);
            }
            return null;
        }
        #endregion Chức năng

        #region Giao diện
        // Load dữ lệu
        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.TaiKhoan' table. You can move, or remove it, as needed.
            LoadKhachHang();
            // TODO: This line of code loads data into the 'dS.TaiKhoan' table. You can move, or remove it, as needed.
            this.taiKhoanTableAdapter.Fill(this.dS.TaiKhoan);
        }
        private void ThucThiChucNang()
        {
            // Disable tất cả nút chức năng khác trừ Ghi và Thoát
            ThayDoiButtonEnabled(false);
            btnGhi.Enabled = true;
            btnThoat.Enabled = true;
            // Thực thi
            switch (chucNangThucThi)
            {
                case CHUCNANG_THEM:
                    gcKh.Enabled = false;
                    ThayDoiInputEnabled(true);
                    ThayDoiInputReadOnly(false);
                    ResetGiaTriInput();
                    break;
                case CHUCNANG_SUA:
                    ThayDoiInputEnabled(true);
                    ThayDoiInputReadOnly(false);
                    FillInput();
                    txtCmnd.Enabled = false;
                    break;
            }
        }
        private void ResetTatCaComponent()
        {
            // Enable các input và chuyển về ReadOnly
            ThayDoiInputEnabled(true);
            ThayDoiInputReadOnly(true);
            // Enable Grid control nhân viên
            gcKh.Enabled = true;
            // Tùy nhóm quyền mà mở chức năng:
            if (TaiKhoanLoginDAO.Instance.NhomQuyen.Equals(NhanVien.ROLE_CHINHANH))
            {
                // Enable tất cả nút trừ Ghi và Thoát chức năng
                ThayDoiButtonEnabled(true);
                btnGhi.Enabled = false;
                btnPhucHoi.Enabled = stackPhucHoi.Count > 0 ? true : false;
                btnThoat.Enabled = false;
                btnIn.Enabled = false;
                btn_InTaiKhoan.Enabled = false;
            }
            else if (TaiKhoanLoginDAO.Instance.NhomQuyen.Equals(NhanVien.ROLE_NGANHANG))
            {
                ThayDoiButtonEnabled(false);
                btnTaiLai.Enabled = true;
            }
        }
        private void ResetGiaTriInput()
        {
            txtCmnd.ResetText();
            txtHo.ResetText();
            txtTen.ResetText();
            txtSoDT.ResetText();
            coboxPhai.SelectedItem = "Nam";
            txtMaCN.Text = TaiKhoanLoginDAO.Instance.MaCN;
            txtDiaChi.ResetText();
        }
        private void ThayDoiInputEnabled(bool enabled)
        {
            txtCmnd.Enabled = enabled;
            txtHo.Enabled = enabled;
            txtTen.Enabled = enabled;
            txtSoDT.Enabled = enabled;
            coboxPhai.Enabled = enabled;
            txtDiaChi.Enabled = enabled;
            dtNgayCap.Enabled = enabled;
        }
        private void ThayDoiInputReadOnly(bool readOnly)
        {
            txtCmnd.ReadOnly = readOnly;
            txtHo.ReadOnly = readOnly;
            txtTen.ReadOnly = readOnly;
            txtSoDT.ReadOnly = readOnly;
            coboxPhai.Enabled = !readOnly;
            txtDiaChi.ReadOnly = readOnly;
            dtNgayCap.Enabled = !readOnly;
        }
        private void ThayDoiButtonEnabled(bool enabled)
        {
            btnThem.Enabled = enabled;
            btnDelete.Enabled = enabled;
            btnSua.Enabled = enabled;
            btnGhi.Enabled = enabled;
            btnPhucHoi.Enabled = enabled;
            btnTaiLai.Enabled = enabled;
            btnThoat.Enabled = enabled;
        }
        private bool InputHopLe()
        {
            return
                !txtCmnd.Text.Trim().Equals("") &&
                !txtHo.Text.Trim().Equals("") &&
                !txtTen.Text.Trim().Equals("") &&
                !txtSoDT.Text.Trim().Equals("") &&
                !txtDiaChi.Text.Trim().Equals("");
        }
        private void FillInput()
        {
            DataRowView current = (DataRowView)bdsKh.Current;
            if (current != null)
            {
                txtCmnd.Text = (string)current["CMND"];
                txtHo.Text = (string)current["Ho"];
                txtTen.Text = (string)current["Ten"];
                txtSoDT.Text = (string)current["SoDT"];
                coboxPhai.SelectedItem = (string)current["Phai"];
                txtMaCN.Text = (string)current["MaCN"];
                txtDiaChi.Text = (string)current["DiaChi"];
                DateTime dateTime = (DateTime)current["NgayCap"];
                dtNgayCap.Text = dateTime.ToString();
            }
        }
        private void LoadComboboxChiNhanh()
        {
            comboxChiNhanh.DataSource = TaiKhoanLoginDAO.Instance.BindingSourceChiNhanh;
            comboxChiNhanh.DisplayMember = "TENCN";
            comboxChiNhanh.ValueMember = "TENSERVER";
            if (TaiKhoanLoginDAO.Instance.NhomQuyen.Equals(NhanVien.ROLE_NGANHANG))
            {
                comboxChiNhanh.Enabled = true;
            }
        }
        #endregion Giao diện


        #region Sự kiện
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Lưu vị trí đang focus
            cmnd = txtCmnd.Text;
            // Vào chức năng thêm
            chucNangThucThi = CHUCNANG_THEM;
            ThucThiChucNang();
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            switch (chucNangThucThi)
            {
                case CHUCNANG_THEM:
                    if (InputHopLe())
                        ThemKhachHang();
                    else
                        MessageBox.Show("Các input không được trống");
                    break;
                case CHUCNANG_SUA:
                    if (InputHopLe())
                    {
                        CapNhatKhachHang();
                    }
                    break;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Lưu vị trí đang focus
            cmnd = txtCmnd.Text;
            // Vào chức năng cập nhật
            chucNangThucThi = CHUCNANG_SUA;
            ThucThiChucNang();
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            ThoatEdit();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            FillInput();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            ReportListKhachHang rpt = new ReportListKhachHang();
            rpt.lbTen.Text = TaiKhoanLoginDAO.Instance.HoTen;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }
        private void comboxChiNhanh_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!comboxChiNhanh.SelectedValue.ToString().Equals("System.Data.DataRowView"))
                DoiChiNhanh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bdsKh.Count > 0)
            {
                if (bdsTaiKhoan != null && bdsTaiKhoan.Count > 0)
                {
                    new FormInTk().ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Không có tài khoản nào để in", "", MessageBoxButtons.OK);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            XoaKhachHang();
        }

        private void txtCmnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtHo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtDiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion Sự kiện
    }
}
