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
    public partial class FormChuyenCN : Form
    {
        private NhanVien nhanVien;
        private bool isUpdated = false;
        public FormChuyenCN(NhanVien nhanVien)
        {
            InitializeComponent();
            this.nhanVien = nhanVien;
            LoadUI();
        }
        private void LoadUI()
        {
            txtMaNVCu.Text = nhanVien.MaNV;
            comboxChiNhanh.DataSource = TaiKhoanLoginDAO.Instance.BindingSourceChiNhanh.DataSource;
            comboxChiNhanh.DisplayMember = "TENCN";
            comboxChiNhanh.ValueMember = "TENSERVER";
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (InputHopLe())
            {
                //if (NhanVienDAO.Instance.ChuyenChiNhanh(txtMaNVMoi.Text.Trim(), nhanVien, comboxChiNhanh.SelectedValue.ToString()))
                //{
                //    MessageBox.Show("Chuyển chi nhánh nhân viên thành công");
                //    this.isUpdated = true;
                //    this.Close();
                //}
                //else
                //    MessageBox.Show("Chuyển chi nhánh nhân viên thất bại. Hãy thử mã nhân viên khác");

                if (NhanVienDAO.Instance.ChuyenCNNhanVien(txtMaNVMoi.Text.Trim(), nhanVien))
                {
                    MessageBox.Show("Chuyển chi nhánh nhân viên thành công");
                    this.isUpdated = true;
                    this.Close();
                }
                else
                    MessageBox.Show("Chuyển chi nhánh nhân viên thất bại. Hãy thử mã nhân viên khác");
            }
        }
        private bool InputHopLe()
        {
            if(txtMaNVMoi.Text.Trim().Equals("") || txtMaNVMoi.Text.Trim().Equals(nhanVien.MaNV.Trim()))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên mới không trùng với mã cũ");
                return false;
            }
            if (comboxChiNhanh.SelectedValue.ToString().Equals(TaiKhoanLoginDAO.Instance.Server))
            {
                MessageBox.Show("Vui lòng chọn chi nhánh khác chi nhánh hiện tại");
                return false;
            }
            return true;
        }
        public bool IsUpdated { get => isUpdated; }
    }
}
