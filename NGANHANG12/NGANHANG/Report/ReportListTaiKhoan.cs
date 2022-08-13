using DangTinThueTro.DAO;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace NGANHANG.Report
{
    public partial class ReportListTaiKhoan : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportListTaiKhoan()
        {
            InitializeComponent();
        }

        public ReportListTaiKhoan(string Cn, DateTime from, DateTime to)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = DataProvider.connectionStr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = Cn;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = from;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = to;
            this.sqlDataSource1.Fill();
        }

    }
}
