using DangTinThueTro.DAO;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace NGANHANG.Report
{
    public partial class ReportListKhachHang : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportListKhachHang()
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = DataProvider.Instance.GetConnectionStr();
            this.sqlDataSource1.Fill();
        }

    }
}
