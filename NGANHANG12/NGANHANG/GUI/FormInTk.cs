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
    public partial class FormInTk : Form
    {
        public FormInTk()
        {
            InitializeComponent();
            loadCmb();
        }

        private void loadCmb()
        {
            var items = new BindingList<KeyValuePair<string, string>>();

            items.Add(new KeyValuePair<string, string>("ALL", "All"));

            string cmd = "SELECT * FROM V_CHI_NHANH";
            DataTable dt = DataProvider.Instance.ExecuteQuerry(cmd, null);
            foreach(DataRow dr in dt.Rows)
            {
                string macn = (string)dr["MACN"];
                string tenCn = (string)dr["TENCN"];
                items.Add(new KeyValuePair<string, string>(macn, tenCn));
            }

            cb_chiNhanh.DataSource = items;
            cb_chiNhanh.ValueMember = "Key";
            cb_chiNhanh.DisplayMember = "Value";
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            string cn = cb_chiNhanh.SelectedValue.ToString();
            DateTime from = dtFrom.Value;
            DateTime to = dtTo.Value;

            if(from > to || from > DateTime.Now)
            {
                MessageBox.Show("Ngày đầu không được lớn hơn ngày cuối hoặc ngày hiện tại", "", MessageBoxButtons.OK);
                return;
            } else if (to > DateTime.Now)
            {
                MessageBox.Show("Ngày cuối không được lớn hơn ngày hiện tại", "", MessageBoxButtons.OK);
                return;
            }

            ReportListTaiKhoan rpt = new ReportListTaiKhoan(cn, from, to);
            if (cb_chiNhanh.GetItemText(cb_chiNhanh.SelectedItem).Equals("All"))
            {
                rpt.lb_tieuDe.Text = "Danh sách các tài khoản được mở tại ngân hàng";
            }
            else
            {
                rpt.lb_tieuDe.Text = "Danh sách tài khoản được mở tại " + cb_chiNhanh.GetItemText(cb_chiNhanh.SelectedItem);
            }
            rpt.lb_sub.Text = "Từ ngày: " + dtFrom.Text + "  Đến ngày: " + dtTo.Text;
            rpt.lbTen.Text = TaiKhoanLoginDAO.Instance.HoTen;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cb_chiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
