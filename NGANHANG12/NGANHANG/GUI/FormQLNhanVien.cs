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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NGANHANG.GUI
{
    public partial class FormQLNhanVien : Form
    {
        private const int CHUCNANG_THEM = 0;
        private const int CHUCNANG_SUA = 1;

        private int chucNangThucThi;
        private string maNV; // Mã nhân viên của row đang chọn

        private Stack<PhucHoiNhanVien> stackPhucHoi = new Stack<PhucHoiNhanVien>();
        public FormQLNhanVien()
        {
            InitializeComponent();
            ResetTatCaComponent();
            LoadComboboxChiNhanh();
        }
        #region Chức năng
        private void ThemNhanVien()
        {
            // Tạo đối tượng nhân viên
            NhanVien nhanVien = GetNhanVienTuInput();
            // Thêm nhân viên
            if (NhanVienDAO.Instance.ThemNhanVien(nhanVien))
            {
                MessageBox.Show("Thêm nhân viên thành công");
                // Reload dữ liệu và giao diện
                this.maNV = nhanVien.MaNV;
                stackPhucHoi.Push(new PhucHoiNhanVien(nhanVien, PhucHoiNhanVien.CHUCNANG_THEM));
                LoadNhanVien();
                ThoatEdit();
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại");
            }
        }
        private void CapNhatNhanVien()
        {
            // Tạo đối tượng nhân viên
            NhanVien nhanVien = GetNhanVienTuInput();
            // Cập nhật nhân viên
            if (NhanVienDAO.Instance.CapNhatNhanVien(nhanVien))
            {
                MessageBox.Show("Cập nhật nhân viên thành công");
                stackPhucHoi.Push(new PhucHoiNhanVien(GetNhanVienTruocCapNhat(), PhucHoiNhanVien.CHUCNANG_SUA));
                LoadNhanVien();
                ThoatEdit();
            }
            else
            {
                MessageBox.Show("Cập nhật nhân viên thất bại");
            }
        }
        private void XoaNhanVien()
        {
            NhanVien nhanVien = GetNhanVienTuInput();
            if (maNV.Trim().Equals(TaiKhoanLoginDAO.Instance.MaNV.Trim())){
                MessageBox.Show("Bạn không thể xóa thông tin của mình");
            }
            else
            {
                int ketQua = NhanVienDAO.Instance.XoaNhanVien(maNV);
                if (ketQua == NhanVienDAO.XOA_MEM)
                {
                    MessageBox.Show("Xóa nhân viên thành công");
                    this.maNV = nhanVien.MaNV;
                    LoadNhanVien();
                    ThoatEdit();
                    stackPhucHoi.Push(new PhucHoiNhanVien(GetNhanVienTruocCapNhat(), PhucHoiNhanVien.CHUCNANG_SUA));
                }
                else if(ketQua == NhanVienDAO.XOA_CUNG)
                {
                    MessageBox.Show("Xóa nhân viên thành công");
                    LoadNhanVien();
                    ThoatEdit();
                    stackPhucHoi.Push(new PhucHoiNhanVien(nhanVien, PhucHoiNhanVien.CHUCNANG_XOA));
                }
                else
                {
                    MessageBox.Show("Xóa nhân viên thất bại");
                }
            }
        }
        private void LoadNhanVien()
        {
            this.dataSet.EnforceConstraints = false;
            this.tableAdapterNhanVien.Connection.ConnectionString = DataProvider.Instance.GetConnectionStr();
            this.tableAdapterNhanVien.Fill(this.dataSet.NhanVien);
        }
        private void ThoatEdit()
        {
            chucNangThucThi = -1;
            ResetTatCaComponent();
            // Thoát thông tin dang edit và focus row đang chọn
            bindingSourceNhanVien.Position = bindingSourceNhanVien.Find("MaNV", maNV);
            FillInput();
        }
        private void PhucHoi()
        {
            PhucHoiNhanVien phucHoiNhanVien = stackPhucHoi.Pop();
            if(phucHoiNhanVien != null)
            {
                string maNV = phucHoiNhanVien.PhucHoi();
                MessageBox.Show(maNV);
                if (maNV != null)
                {
                    MessageBox.Show("Phục hồi thành công");
                    this.maNV = maNV;
                    LoadNhanVien();
                    ThoatEdit();
                }
                else
                {
                    MessageBox.Show("Phục hồi thất bại");
                }
            }
            else
            {
                MessageBox.Show("Không còn thao tác để phục hồi");
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
            LoadNhanVien();
        }
        private NhanVien GetNhanVienTuInput()
        {
            string maNV = txtMaNV.Text;
            string ho = txtHo.Text;
            string ten = txtTen.Text;
            string diaChi = txtDiaChi.Text;
            string phai = (string)coboxPhai.SelectedItem;
            string soDT = txtSoDT.Text;
            string maCN = txtMaCN.Text;
            int trangThaiXoa = chboxDaXoa.Checked ? 1 : 0;
            return new NhanVien(maNV, ho, ten, diaChi, phai, soDT, maCN, trangThaiXoa);
        }
        private NhanVien GetNhanVienTruocCapNhat()
        {
            DataRowView current = (DataRowView)bindingSourceNhanVien.Current;
            if (current != null)
            {
                string maNV = (string)current["MaNV"];
                string ho = (string)current["Ho"];
                string ten = (string)current["Ten"];
                string soDT = (string)current["SoDT"];
                string phai = (string)current["Phai"];
                string maCN = (string)current["MaCN"];
                string diaChi = (string)current["DiaChi"];
                int trangThaiXoa = (int)current["TrangThaiXoa"];
                return new NhanVien(maNV, ho, ten, diaChi, phai, soDT, maCN, trangThaiXoa);
            }
            return null;
        }
        #endregion Chức năng

        #region Giao diện
        // Load dữ liệu
        private void MyFormNhanVien_Load(object sender, EventArgs e)
        {
            // Tải danh sách nhân viên từ database
            LoadNhanVien();
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
                    gridControlNhanVien.Enabled = false;
                    ThayDoiInputEnabled(true);
                    ThayDoiInputReadOnly(false);
                    ResetGiaTriInput();
                    chboxDaXoa.Checked = false;
                    chboxDaXoa.Enabled = false;
                    break;
                case CHUCNANG_SUA:
                    ThayDoiInputEnabled(true);
                    ThayDoiInputReadOnly(false);
                    FillInput();
                    txtMaNV.Enabled = false;
                    break;
            }
        }
        private void ResetTatCaComponent()
        {
            // Enable các input và chuyển về ReadOnly
            ThayDoiInputEnabled(true);
            ThayDoiInputReadOnly(true);
            // Enable Grid control nhân viên
            gridControlNhanVien.Enabled = true;
            // Tùy nhóm quyền mà mở chức năng:
            if (TaiKhoanLoginDAO.Instance.NhomQuyen.Equals(NhanVien.ROLE_CHINHANH))
            {
                // Enable tất cả nút trừ Ghi và Thoát chức năng
                ThayDoiButtonEnabled(true);
                btnGhi.Enabled = false;
                btnThoat.Enabled = false;
                btnPhucHoi.Enabled = stackPhucHoi.Count > 0 ? true : false;
            }
            else if(TaiKhoanLoginDAO.Instance.NhomQuyen.Equals(NhanVien.ROLE_NGANHANG))
            {
                ThayDoiButtonEnabled(false);
                btnTaiLai.Enabled = true;
            }
        }
        private void ResetGiaTriInput()
        {
            txtMaNV.ResetText();
            txtHo.ResetText();
            txtTen.ResetText();
            txtSoDT.ResetText();
            coboxPhai.SelectedItem = "Nam";
            txtMaCN.Text = TaiKhoanLoginDAO.Instance.MaCN;
            txtDiaChi.ResetText();
            chboxDaXoa.Checked = false;
        }
        private void ThayDoiInputEnabled(bool enabled)
        {
            txtMaNV.Enabled = enabled;
            txtHo.Enabled = enabled;
            txtTen.Enabled = enabled;
            txtSoDT.Enabled = enabled;
            coboxPhai.Enabled = enabled;
            txtDiaChi.Enabled = enabled;
            chboxDaXoa.Enabled = enabled;
        }
        private void ThayDoiInputReadOnly(bool readOnly)
        {
            txtMaNV.ReadOnly = readOnly;
            txtHo.ReadOnly = readOnly;
            txtTen.ReadOnly = readOnly;
            txtSoDT.ReadOnly = readOnly;
            coboxPhai.Enabled = !readOnly;
            txtDiaChi.ReadOnly = readOnly;
            chboxDaXoa.Enabled = !readOnly;
        }
        private void ThayDoiButtonEnabled(bool enabled)
        {
            btnThem.Enabled = enabled;
            btnSua.Enabled = enabled;
            btnChuyenCN.Enabled = enabled;
            btnGhi.Enabled = enabled;
            btnPhucHoi.Enabled = enabled;
            btnTaiLai.Enabled = enabled;
            btnThoat.Enabled = enabled;
        }
        private bool InputHopLe()
        {
            return
                !txtMaNV.Text.Trim().Equals("") &&
                !txtHo.Text.Trim().Equals("") &&
                !txtTen.Text.Trim().Equals("") &&
                !txtSoDT.Text.Trim().Equals("") &&
                !txtDiaChi.Text.Trim().Equals("");
        }
        private void FillInput()
        {
            DataRowView current = (DataRowView)bindingSourceNhanVien.Current;
            if (current != null)
            {
                // Nếu đang trong chức năng sửa, chỉ cho sửa input nhân viên chưa bị xóa
                if (chucNangThucThi.Equals(CHUCNANG_SUA)) 
                {
                    if ((int)current["TrangThaiXoa"] == 1)
                    {
                        ThayDoiInputReadOnly(true);
                        chboxDaXoa.Enabled = true;
                    }
                    else
                    {
                        ThayDoiInputReadOnly(false);
                    }
                }
                txtMaNV.Text = (string)current["MaNV"];
                txtHo.Text = (string)current["Ho"];
                txtTen.Text = (string)current["Ten"];
                txtSoDT.Text = (string)current["SoDT"];
                coboxPhai.SelectedItem = (string)current["Phai"];
                txtMaCN.Text = (string)current["MaCN"];
                txtDiaChi.Text = (string)current["DiaChi"];
                chboxDaXoa.Checked = (int)current["TrangThaiXoa"] == 1 ? true : false;
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
        private void btnGhi_Click(object sender, EventArgs e)
        {
            switch (chucNangThucThi)
            {
                case CHUCNANG_THEM:
                    if (InputHopLe())
                        ThemNhanVien();
                    else
                        MessageBox.Show("Các input không được trống");
                    break;
                case CHUCNANG_SUA:
                    if (chboxDaXoa.Checked)
                    {
                        XoaNhanVien();
                        break;
                    }
                    if (InputHopLe())
                    {
                        CapNhatNhanVien();
                    }
                    else
                    {
                        MessageBox.Show("Các input không được trống");
                    }
                    break;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Lưu vị trí đang focus
            maNV = txtMaNV.Text;
            // Vào chức năng thêm
            chucNangThucThi = CHUCNANG_THEM;
            ThucThiChucNang();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            // Lưu vị trí đang focus
            maNV = txtMaNV.Text;
            // Vào chức năng cập nhật
            chucNangThucThi = CHUCNANG_SUA;
            ThucThiChucNang();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            ThoatEdit();
        }
        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadNhanVien();
        }
        private void gridViewNhanVien_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            FillInput();
        }
        private void btnPhucHoi_Click(object sender, EventArgs e)
        {
            PhucHoi();
        }
        private void comboxChiNhanh_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!comboxChiNhanh.SelectedValue.ToString().Equals("System.Data.DataRowView"))
                DoiChiNhanh();
        }
        private void txtMaNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
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
        private void txtSoDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
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
        private void btnChuyenCN_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = GetNhanVienTuInput();
            if (!nhanVien.MaNV.Trim().Equals(TaiKhoanLoginDAO.Instance.TaiKhoan.Trim()))
            {
                FormChuyenCN form = new FormChuyenCN(nhanVien);
                form.ShowDialog();
                if (form.IsUpdated)
                {
                    LoadNhanVien();
                }
            }
            else
                MessageBox.Show("Bạn không thể chuyển chi nhánh bản thân");
        }
        #endregion Sự kiện
    }
}
