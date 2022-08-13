using DangTinThueTro.DAO;
using NGANHANG.DTO;
using NGANHANG.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NGANHANG
{
    public partial class FormDangNhap : DevExpress.XtraEditors.XtraForm
    {
        private SqlConnection connectionPublisher = new SqlConnection();
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void LoadComboboxChiNhanh(object sender, EventArgs e)
        {
            try
            {
                DataProvider.Instance.SetConnectionStrDefault();
                GetListPhanManh("SELECT * FROM Get_Subscribes");
                cmb_chiNhanh.SelectedIndex = 1;
                cmb_chiNhanh.SelectedIndex = 0;
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: Có lỗi khi lấy danh sách chi nhánh. " + ex.Message);
            }
            
        }
        private bool KiemTraInputHopLe()
        {
            return !txt_user.Text.Equals("") && !txt_pass.Text.Equals("");
        }
        private void btn_logIn_Click(object sender, EventArgs e)
        {
            if (!KiemTraInputHopLe())
            {
                MessageBox.Show("Tài khoản và mật khẩu không được trống");
                return;
            }
            try
            {
                if (TaiKhoanLoginDAO.Instance.DangNhap(txt_user.Text, txt_pass.Text, cmb_chiNhanh.SelectedValue.ToString()))
                {
                    TaiKhoanLoginDAO.Instance.LoadMaCN();
                    new FormMain(this).Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Thông tin đăng nhập không chính xác");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: Có lỗi khi đăng nhập. " + ex.Message);
            }           
        }

        private void GetListPhanManh(string cmd)
        {
            DataTable dt = DataProvider.Instance.ExecuteQuerry(cmd, null);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dt;
            TaiKhoanLoginDAO.Instance.BindingSourceChiNhanh = bindingSource;
            cmb_chiNhanh.DataSource = bindingSource;
            cmb_chiNhanh.DisplayMember = "TENCN";
            cmb_chiNhanh.ValueMember = "TENSERVER";
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void cmb_chiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cmb_chiNhanh.SelectedValue.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
