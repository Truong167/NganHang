
namespace NGANHANG.GUI
{
    partial class FormMoTaiKhoanGD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label mACNLabel;
            System.Windows.Forms.Label sODTLabel;
            System.Windows.Forms.Label lbHoTen;
            System.Windows.Forms.Label lbCmnd;
            System.Windows.Forms.Label label1;
            this.gridViewKhachHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYCAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcKh = new DevExpress.XtraGrid.GridControl();
            this.bdsKh = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new NGANHANG.DTO.DS();
            this.panelFormInput = new System.Windows.Forms.Panel();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.txtMaCN = new DevExpress.XtraEditors.TextEdit();
            this.dateEditNgayMoTK = new System.Windows.Forms.DateTimePicker();
            this.txtSoTK = new DevExpress.XtraEditors.TextEdit();
            this.txtHoTenKH = new DevExpress.XtraEditors.TextEdit();
            this.txtCmndKH = new DevExpress.XtraEditors.TextEdit();
            this.bdsTaiKhoan = new System.Windows.Forms.BindingSource(this.components);
            this.fKTaiKhoanKhachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taiKhoanTableAdapter = new NGANHANG.DTO.DSTableAdapters.TaiKhoanTableAdapter();
            this.taiKhoanGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridViewTaiKhoan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYMOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.btnGhi = new System.Windows.Forms.ToolStripButton();
            this.btnPhucHoi = new System.Windows.Forms.ToolStripButton();
            this.btnTaiLai = new System.Windows.Forms.ToolStripButton();
            this.khachHangTableAdapter = new NGANHANG.DTO.DSTableAdapters.KhachHangTableAdapter();
            this.tableAdapterManager = new NGANHANG.DTO.DSTableAdapters.TableAdapterManager();
            label3 = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            sODTLabel = new System.Windows.Forms.Label();
            lbHoTen = new System.Windows.Forms.Label();
            lbCmnd = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            this.panelFormInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTenKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCmndKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTaiKhoanKhachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTaiKhoan)).BeginInit();
            this.toolStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(429, 135);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(76, 28);
            label3.TabIndex = 18;
            label3.Text = "Mã CN:";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mACNLabel.Location = new System.Drawing.Point(429, 79);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(124, 28);
            mACNLabel.TabIndex = 12;
            mACNLabel.Text = "Ngày mở TK:";
            // 
            // sODTLabel
            // 
            sODTLabel.AutoSize = true;
            sODTLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sODTLabel.Location = new System.Drawing.Point(29, 82);
            sODTLabel.Name = "sODTLabel";
            sODTLabel.Size = new System.Drawing.Size(125, 28);
            sODTLabel.TabIndex = 10;
            sODTLabel.Text = "Số tài khoản:";
            // 
            // lbHoTen
            // 
            lbHoTen.AutoSize = true;
            lbHoTen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbHoTen.Location = new System.Drawing.Point(428, 28);
            lbHoTen.Name = "lbHoTen";
            lbHoTen.Size = new System.Drawing.Size(100, 28);
            lbHoTen.TabIndex = 2;
            lbHoTen.Text = "Họ và tên:";
            // 
            // lbCmnd
            // 
            lbCmnd.AutoSize = true;
            lbCmnd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbCmnd.Location = new System.Drawing.Point(28, 28);
            lbCmnd.Name = "lbCmnd";
            lbCmnd.Size = new System.Drawing.Size(131, 28);
            lbCmnd.TabIndex = 0;
            lbCmnd.Text = "CMND khách:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(28, 138);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(126, 28);
            label1.TabIndex = 20;
            label1.Text = "Số dư (VNĐ):";
            // 
            // gridViewKhachHang
            // 
            this.gridViewKhachHang.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewKhachHang.Appearance.Row.Options.UseFont = true;
            this.gridViewKhachHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCMND,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colPHAI,
            this.colNGAYCAP,
            this.colSODT,
            this.colMACN});
            this.gridViewKhachHang.DetailHeight = 490;
            this.gridViewKhachHang.GridControl = this.gcKh;
            this.gridViewKhachHang.Name = "gridViewKhachHang";
            this.gridViewKhachHang.OptionsBehavior.Editable = false;
            this.gridViewKhachHang.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewKhachHang_FocusedRowChanged);
            // 
            // colCMND
            // 
            this.colCMND.FieldName = "CMND";
            this.colCMND.MinWidth = 31;
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 0;
            this.colCMND.Width = 117;
            // 
            // colHO
            // 
            this.colHO.Caption = "Họ";
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 31;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 117;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "Tên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 31;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 117;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "Địa chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 31;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            this.colDIACHI.Width = 117;
            // 
            // colPHAI
            // 
            this.colPHAI.Caption = "Phái";
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.MinWidth = 31;
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 4;
            this.colPHAI.Width = 117;
            // 
            // colNGAYCAP
            // 
            this.colNGAYCAP.Caption = "Ngày cấp";
            this.colNGAYCAP.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.colNGAYCAP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colNGAYCAP.FieldName = "NGAYCAP";
            this.colNGAYCAP.MinWidth = 31;
            this.colNGAYCAP.Name = "colNGAYCAP";
            this.colNGAYCAP.Visible = true;
            this.colNGAYCAP.VisibleIndex = 5;
            this.colNGAYCAP.Width = 117;
            // 
            // colSODT
            // 
            this.colSODT.Caption = "Số điện thoại";
            this.colSODT.FieldName = "SODT";
            this.colSODT.MinWidth = 31;
            this.colSODT.Name = "colSODT";
            this.colSODT.Visible = true;
            this.colSODT.VisibleIndex = 6;
            this.colSODT.Width = 117;
            // 
            // colMACN
            // 
            this.colMACN.Caption = "Mã chi nhánh";
            this.colMACN.FieldName = "MACN";
            this.colMACN.MinWidth = 31;
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 7;
            this.colMACN.Width = 117;
            // 
            // gcKh
            // 
            this.gcKh.DataSource = this.bdsKh;
            this.gcKh.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcKh.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(10);
            this.gcKh.Location = new System.Drawing.Point(0, 51);
            this.gcKh.MainView = this.gridViewKhachHang;
            this.gcKh.Margin = new System.Windows.Forms.Padding(10);
            this.gcKh.Name = "gcKh";
            this.gcKh.Size = new System.Drawing.Size(1552, 600);
            this.gcKh.TabIndex = 10;
            this.gcKh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewKhachHang});
            // 
            // bdsKh
            // 
            this.bdsKh.DataMember = "KhachHang";
            this.bdsKh.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelFormInput
            // 
            this.panelFormInput.Controls.Add(label1);
            this.panelFormInput.Controls.Add(this.textEdit1);
            this.panelFormInput.Controls.Add(label3);
            this.panelFormInput.Controls.Add(this.txtMaCN);
            this.panelFormInput.Controls.Add(this.dateEditNgayMoTK);
            this.panelFormInput.Controls.Add(mACNLabel);
            this.panelFormInput.Controls.Add(sODTLabel);
            this.panelFormInput.Controls.Add(this.txtSoTK);
            this.panelFormInput.Controls.Add(lbHoTen);
            this.panelFormInput.Controls.Add(this.txtHoTenKH);
            this.panelFormInput.Controls.Add(lbCmnd);
            this.panelFormInput.Controls.Add(this.txtCmndKH);
            this.panelFormInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFormInput.Location = new System.Drawing.Point(0, 651);
            this.panelFormInput.Name = "panelFormInput";
            this.panelFormInput.Size = new System.Drawing.Size(873, 404);
            this.panelFormInput.TabIndex = 11;
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = "0";
            this.textEdit1.Enabled = false;
            this.textEdit1.Location = new System.Drawing.Point(165, 135);
            this.textEdit1.Margin = new System.Windows.Forms.Padding(4);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Size = new System.Drawing.Size(219, 34);
            this.textEdit1.TabIndex = 19;
            this.textEdit1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCmndKH_KeyPress);
            // 
            // txtMaCN
            // 
            this.txtMaCN.Enabled = false;
            this.txtMaCN.Location = new System.Drawing.Point(559, 132);
            this.txtMaCN.Name = "txtMaCN";
            this.txtMaCN.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCN.Properties.Appearance.Options.UseFont = true;
            this.txtMaCN.Size = new System.Drawing.Size(238, 34);
            this.txtMaCN.TabIndex = 17;
            // 
            // dateEditNgayMoTK
            // 
            this.dateEditNgayMoTK.CustomFormat = "dd/MM/yyyy";
            this.dateEditNgayMoTK.Enabled = false;
            this.dateEditNgayMoTK.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateEditNgayMoTK.Location = new System.Drawing.Point(559, 77);
            this.dateEditNgayMoTK.Name = "dateEditNgayMoTK";
            this.dateEditNgayMoTK.Size = new System.Drawing.Size(238, 34);
            this.dateEditNgayMoTK.TabIndex = 6;
            // 
            // txtSoTK
            // 
            this.txtSoTK.Location = new System.Drawing.Point(165, 79);
            this.txtSoTK.Name = "txtSoTK";
            this.txtSoTK.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTK.Properties.Appearance.Options.UseFont = true;
            this.txtSoTK.Properties.MaxLength = 9;
            this.txtSoTK.Size = new System.Drawing.Size(219, 34);
            this.txtSoTK.TabIndex = 4;
            this.txtSoTK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCmndKH_KeyPress);
            // 
            // txtHoTenKH
            // 
            this.txtHoTenKH.Location = new System.Drawing.Point(559, 25);
            this.txtHoTenKH.Name = "txtHoTenKH";
            this.txtHoTenKH.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTenKH.Properties.Appearance.Options.UseFont = true;
            this.txtHoTenKH.Properties.ReadOnly = true;
            this.txtHoTenKH.Size = new System.Drawing.Size(238, 34);
            this.txtHoTenKH.TabIndex = 2;
            // 
            // txtCmndKH
            // 
            this.txtCmndKH.Location = new System.Drawing.Point(165, 25);
            this.txtCmndKH.Name = "txtCmndKH";
            this.txtCmndKH.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCmndKH.Properties.Appearance.Options.UseFont = true;
            this.txtCmndKH.Properties.MaxLength = 10;
            this.txtCmndKH.Size = new System.Drawing.Size(219, 34);
            this.txtCmndKH.TabIndex = 1;
            this.txtCmndKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCmndKH_KeyPress);
            this.txtCmndKH.Leave += new System.EventHandler(this.txtCmndKH_Leave);
            // 
            // bdsTaiKhoan
            // 
            this.bdsTaiKhoan.DataSource = this.fKTaiKhoanKhachHangBindingSource;
            // 
            // fKTaiKhoanKhachHangBindingSource
            // 
            this.fKTaiKhoanKhachHangBindingSource.DataMember = "FK_TaiKhoan_KhachHang";
            this.fKTaiKhoanKhachHangBindingSource.DataSource = this.bdsKh;
            // 
            // taiKhoanTableAdapter
            // 
            this.taiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // taiKhoanGridControl
            // 
            this.taiKhoanGridControl.DataSource = this.bdsTaiKhoan;
            this.taiKhoanGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taiKhoanGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(10);
            this.taiKhoanGridControl.Location = new System.Drawing.Point(873, 651);
            this.taiKhoanGridControl.MainView = this.gridViewTaiKhoan;
            this.taiKhoanGridControl.Margin = new System.Windows.Forms.Padding(10);
            this.taiKhoanGridControl.Name = "taiKhoanGridControl";
            this.taiKhoanGridControl.Size = new System.Drawing.Size(679, 404);
            this.taiKhoanGridControl.TabIndex = 12;
            this.taiKhoanGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTaiKhoan});
            // 
            // gridViewTaiKhoan
            // 
            this.gridViewTaiKhoan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSOTK,
            this.colCMND1,
            this.colSODU,
            this.colMACN1,
            this.colNGAYMOTK});
            this.gridViewTaiKhoan.DetailHeight = 437;
            this.gridViewTaiKhoan.GridControl = this.taiKhoanGridControl;
            this.gridViewTaiKhoan.Name = "gridViewTaiKhoan";
            this.gridViewTaiKhoan.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewTaiKhoan.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewTaiKhoan.OptionsBehavior.Editable = false;
            // 
            // colSOTK
            // 
            this.colSOTK.Caption = "Số TK";
            this.colSOTK.FieldName = "SOTK";
            this.colSOTK.MinWidth = 31;
            this.colSOTK.Name = "colSOTK";
            this.colSOTK.OptionsColumn.AllowEdit = false;
            this.colSOTK.Visible = true;
            this.colSOTK.VisibleIndex = 0;
            this.colSOTK.Width = 117;
            // 
            // colCMND1
            // 
            this.colCMND1.FieldName = "CMND";
            this.colCMND1.MinWidth = 31;
            this.colCMND1.Name = "colCMND1";
            this.colCMND1.OptionsColumn.AllowEdit = false;
            this.colCMND1.Visible = true;
            this.colCMND1.VisibleIndex = 1;
            this.colCMND1.Width = 117;
            // 
            // colSODU
            // 
            this.colSODU.Caption = "Số dư";
            this.colSODU.DisplayFormat.FormatString = "n0";
            this.colSODU.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSODU.FieldName = "SODU";
            this.colSODU.MinWidth = 31;
            this.colSODU.Name = "colSODU";
            this.colSODU.Visible = true;
            this.colSODU.VisibleIndex = 2;
            this.colSODU.Width = 117;
            // 
            // colMACN1
            // 
            this.colMACN1.Caption = "Chi nhánh";
            this.colMACN1.FieldName = "MACN";
            this.colMACN1.MinWidth = 31;
            this.colMACN1.Name = "colMACN1";
            this.colMACN1.Visible = true;
            this.colMACN1.VisibleIndex = 3;
            this.colMACN1.Width = 117;
            // 
            // colNGAYMOTK
            // 
            this.colNGAYMOTK.Caption = "Ngày mở TK";
            this.colNGAYMOTK.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.colNGAYMOTK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAYMOTK.FieldName = "NGAYMOTK";
            this.colNGAYMOTK.MinWidth = 31;
            this.colNGAYMOTK.Name = "colNGAYMOTK";
            this.colNGAYMOTK.Visible = true;
            this.colNGAYMOTK.VisibleIndex = 4;
            this.colNGAYMOTK.Width = 117;
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGhi,
            this.btnPhucHoi,
            this.btnTaiLai});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(1552, 51);
            this.toolStripMenu.TabIndex = 8;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // btnGhi
            // 
            this.btnGhi.Image = global::NGANHANG.Properties.Resources.diskette_blue_24px;
            this.btnGhi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Padding = new System.Windows.Forms.Padding(8);
            this.btnGhi.Size = new System.Drawing.Size(82, 48);
            this.btnGhi.Text = "Ghi";
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Enabled = false;
            this.btnPhucHoi.Image = global::NGANHANG.Properties.Resources.recovery1;
            this.btnPhucHoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.Padding = new System.Windows.Forms.Padding(8);
            this.btnPhucHoi.Size = new System.Drawing.Size(127, 48);
            this.btnPhucHoi.Text = "Phục hồi";
            this.btnPhucHoi.Click += new System.EventHandler(this.btnPhucHoi_Click);
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Image = global::NGANHANG.Properties.Resources.reload;
            this.btnTaiLai.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Padding = new System.Windows.Forms.Padding(8);
            this.btnTaiLai.Size = new System.Drawing.Size(102, 48);
            this.btnTaiLai.Text = "Tải lại";
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // khachHangTableAdapter
            // 
            this.khachHangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = this.khachHangTableAdapter;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NGANHANG.DTO.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FormMoTaiKhoanGD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1552, 1055);
            this.Controls.Add(this.taiKhoanGridControl);
            this.Controls.Add(this.panelFormInput);
            this.Controls.Add(this.gcKh);
            this.Controls.Add(this.toolStripMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMoTaiKhoanGD";
            this.Text = "FormMoTaiKhoanGD";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            this.panelFormInput.ResumeLayout(false);
            this.panelFormInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTenKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCmndKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTaiKhoanKhachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTaiKhoan)).EndInit();
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridViewKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYCAP;
        private DevExpress.XtraGrid.Columns.GridColumn colSODT;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.GridControl gcKh;
        private System.Windows.Forms.BindingSource bdsKh;
        private DTO.DS dS;
        private System.Windows.Forms.Panel panelFormInput;
        private DevExpress.XtraEditors.TextEdit txtMaCN;
        private System.Windows.Forms.DateTimePicker dateEditNgayMoTK;
        private DevExpress.XtraEditors.TextEdit txtSoTK;
        private DevExpress.XtraEditors.TextEdit txtHoTenKH;
        private DevExpress.XtraEditors.TextEdit txtCmndKH;
        private System.Windows.Forms.BindingSource bdsTaiKhoan;
        private DTO.DSTableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private DevExpress.XtraGrid.GridControl taiKhoanGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTaiKhoan;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND1;
        private DevExpress.XtraGrid.Columns.GridColumn colSODU;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN1;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYMOTK;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton btnGhi;
        private System.Windows.Forms.ToolStripButton btnPhucHoi;
        private System.Windows.Forms.ToolStripButton btnTaiLai;
        private DTO.DSTableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private DTO.DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private System.Windows.Forms.BindingSource fKTaiKhoanKhachHangBindingSource;
    }
}