
namespace NGANHANG.GUI
{
    partial class FormQLKhachHang
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
            System.Windows.Forms.Label mACNLabel;
            System.Windows.Forms.Label sODTLabel;
            System.Windows.Forms.Label pHAILabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label lbHoTen;
            System.Windows.Forms.Label lbCmnd;
            System.Windows.Forms.Label label3;
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnGhi = new System.Windows.Forms.ToolStripButton();
            this.btnPhucHoi = new System.Windows.Forms.ToolStripButton();
            this.btnTaiLai = new System.Windows.Forms.ToolStripButton();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.panelChiNhanh = new System.Windows.Forms.Panel();
            this.btn_InTaiKhoan = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.comboxChiNhanh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dS = new NGANHANG.DTO.DS();
            this.bdsKh = new System.Windows.Forms.BindingSource(this.components);
            this.khachHangTableAdapter = new NGANHANG.DTO.DSTableAdapters.KhachHangTableAdapter();
            this.tableAdapterManager = new NGANHANG.DTO.DSTableAdapters.TableAdapterManager();
            this.gcKh = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYCAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelFormInput = new System.Windows.Forms.Panel();
            this.txtMaCN = new DevExpress.XtraEditors.TextEdit();
            this.dtNgayCap = new System.Windows.Forms.DateTimePicker();
            this.txtSoDT = new DevExpress.XtraEditors.TextEdit();
            this.coboxPhai = new System.Windows.Forms.ComboBox();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtHo = new DevExpress.XtraEditors.TextEdit();
            this.txtCmnd = new DevExpress.XtraEditors.TextEdit();
            this.bdsTaiKhoan = new System.Windows.Forms.BindingSource(this.components);
            this.taiKhoanTableAdapter = new NGANHANG.DTO.DSTableAdapters.TaiKhoanTableAdapter();
            this.taiKhoanGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYMOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            mACNLabel = new System.Windows.Forms.Label();
            sODTLabel = new System.Windows.Forms.Label();
            pHAILabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            lbHoTen = new System.Windows.Forms.Label();
            lbCmnd = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.toolStripMenu.SuspendLayout();
            this.panelChiNhanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panelFormInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCmnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mACNLabel.Location = new System.Drawing.Point(609, 79);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(99, 28);
            mACNLabel.TabIndex = 12;
            mACNLabel.Text = "Ngày cấp:";
            // 
            // sODTLabel
            // 
            sODTLabel.AutoSize = true;
            sODTLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sODTLabel.Location = new System.Drawing.Point(29, 82);
            sODTLabel.Name = "sODTLabel";
            sODTLabel.Size = new System.Drawing.Size(68, 28);
            sODTLabel.TabIndex = 10;
            sODTLabel.Text = "Số ĐT:";
            // 
            // pHAILabel
            // 
            pHAILabel.AutoSize = true;
            pHAILabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pHAILabel.Location = new System.Drawing.Point(368, 80);
            pHAILabel.Name = "pHAILabel";
            pHAILabel.Size = new System.Drawing.Size(91, 28);
            pHAILabel.TabIndex = 8;
            pHAILabel.Text = "Giới tính:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dIACHILabel.Location = new System.Drawing.Point(29, 136);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(75, 28);
            dIACHILabel.TabIndex = 6;
            dIACHILabel.Text = "Địa chỉ:";
            // 
            // lbHoTen
            // 
            lbHoTen.AutoSize = true;
            lbHoTen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbHoTen.Location = new System.Drawing.Point(368, 28);
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
            lbCmnd.Size = new System.Drawing.Size(75, 28);
            lbCmnd.TabIndex = 0;
            lbCmnd.Text = "CMND:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(613, 137);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(76, 28);
            label3.TabIndex = 18;
            label3.Text = "Mã CN:";
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnDelete,
            this.btnSua,
            this.btnGhi,
            this.btnPhucHoi,
            this.btnTaiLai,
            this.btnThoat});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(1552, 51);
            this.toolStripMenu.TabIndex = 1;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // btnThem
            // 
            this.btnThem.Image = global::NGANHANG.Properties.Resources.plus_blue_24px;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(8);
            this.btnThem.Size = new System.Drawing.Size(100, 48);
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::NGANHANG.Properties.Resources.trash_24px;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(8);
            this.btnDelete.Size = new System.Drawing.Size(86, 48);
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::NGANHANG.Properties.Resources.edit_blue_24px1;
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(8);
            this.btnSua.Size = new System.Drawing.Size(144, 48);
            this.btnSua.Text = "Hiệu chỉnh";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnGhi
            // 
            this.btnGhi.Enabled = false;
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
            // btnThoat
            // 
            this.btnThoat.Image = global::NGANHANG.Properties.Resources.logout;
            this.btnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Padding = new System.Windows.Forms.Padding(8);
            this.btnThoat.Size = new System.Drawing.Size(197, 48);
            this.btnThoat.Text = "Thoát chức năng";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // panelChiNhanh
            // 
            this.panelChiNhanh.Controls.Add(this.btn_InTaiKhoan);
            this.panelChiNhanh.Controls.Add(this.btnIn);
            this.panelChiNhanh.Controls.Add(this.comboxChiNhanh);
            this.panelChiNhanh.Controls.Add(this.label2);
            this.panelChiNhanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChiNhanh.Location = new System.Drawing.Point(0, 51);
            this.panelChiNhanh.Name = "panelChiNhanh";
            this.panelChiNhanh.Size = new System.Drawing.Size(1552, 45);
            this.panelChiNhanh.TabIndex = 5;
            // 
            // btn_InTaiKhoan
            // 
            this.btn_InTaiKhoan.Location = new System.Drawing.Point(692, 4);
            this.btn_InTaiKhoan.Name = "btn_InTaiKhoan";
            this.btn_InTaiKhoan.Size = new System.Drawing.Size(258, 37);
            this.btn_InTaiKhoan.TabIndex = 5;
            this.btn_InTaiKhoan.Text = "In thông tin tài khoản";
            this.btn_InTaiKhoan.UseVisualStyleBackColor = true;
            this.btn_InTaiKhoan.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(399, 3);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(277, 37);
            this.btnIn.TabIndex = 3;
            this.btnIn.Text = "In danh sách khách hàng";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // comboxChiNhanh
            // 
            this.comboxChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxChiNhanh.Enabled = false;
            this.comboxChiNhanh.FormattingEnabled = true;
            this.comboxChiNhanh.Location = new System.Drawing.Point(120, 5);
            this.comboxChiNhanh.Name = "comboxChiNhanh";
            this.comboxChiNhanh.Size = new System.Drawing.Size(273, 36);
            this.comboxChiNhanh.TabIndex = 0;
            this.comboxChiNhanh.SelectedValueChanged += new System.EventHandler(this.comboxChiNhanh_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(111, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chi nhánh:";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsKh
            // 
            this.bdsKh.DataMember = "KhachHang";
            this.bdsKh.DataSource = this.dS;
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
            // gcKh
            // 
            this.gcKh.DataSource = this.bdsKh;
            this.gcKh.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcKh.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6);
            this.gcKh.Location = new System.Drawing.Point(0, 96);
            this.gcKh.MainView = this.gridView1;
            this.gcKh.Margin = new System.Windows.Forms.Padding(6);
            this.gcKh.Name = "gcKh";
            this.gcKh.Size = new System.Drawing.Size(1552, 600);
            this.gcKh.TabIndex = 6;
            this.gcKh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCMND,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colPHAI,
            this.colNGAYCAP,
            this.colSODT,
            this.colMACN});
            this.gridView1.DetailHeight = 392;
            this.gridView1.GridControl = this.gcKh;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colCMND
            // 
            this.colCMND.FieldName = "CMND";
            this.colCMND.MinWidth = 25;
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 0;
            this.colCMND.Width = 94;
            // 
            // colHO
            // 
            this.colHO.Caption = "Họ";
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 25;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 94;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "Tên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 25;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 94;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "Địa chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 25;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            this.colDIACHI.Width = 94;
            // 
            // colPHAI
            // 
            this.colPHAI.Caption = "Phái";
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.MinWidth = 25;
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 4;
            this.colPHAI.Width = 94;
            // 
            // colNGAYCAP
            // 
            this.colNGAYCAP.Caption = "Ngày cấp";
            this.colNGAYCAP.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.colNGAYCAP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colNGAYCAP.FieldName = "NGAYCAP";
            this.colNGAYCAP.MinWidth = 25;
            this.colNGAYCAP.Name = "colNGAYCAP";
            this.colNGAYCAP.Visible = true;
            this.colNGAYCAP.VisibleIndex = 5;
            this.colNGAYCAP.Width = 94;
            // 
            // colSODT
            // 
            this.colSODT.Caption = "Số điện thoại";
            this.colSODT.FieldName = "SODT";
            this.colSODT.MinWidth = 25;
            this.colSODT.Name = "colSODT";
            this.colSODT.Visible = true;
            this.colSODT.VisibleIndex = 6;
            this.colSODT.Width = 94;
            // 
            // colMACN
            // 
            this.colMACN.Caption = "Mã chi nhánh";
            this.colMACN.FieldName = "MACN";
            this.colMACN.MinWidth = 25;
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 7;
            this.colMACN.Width = 94;
            // 
            // panelFormInput
            // 
            this.panelFormInput.Controls.Add(label3);
            this.panelFormInput.Controls.Add(this.txtMaCN);
            this.panelFormInput.Controls.Add(this.dtNgayCap);
            this.panelFormInput.Controls.Add(mACNLabel);
            this.panelFormInput.Controls.Add(sODTLabel);
            this.panelFormInput.Controls.Add(this.txtSoDT);
            this.panelFormInput.Controls.Add(pHAILabel);
            this.panelFormInput.Controls.Add(this.coboxPhai);
            this.panelFormInput.Controls.Add(dIACHILabel);
            this.panelFormInput.Controls.Add(this.txtDiaChi);
            this.panelFormInput.Controls.Add(this.txtTen);
            this.panelFormInput.Controls.Add(lbHoTen);
            this.panelFormInput.Controls.Add(this.txtHo);
            this.panelFormInput.Controls.Add(lbCmnd);
            this.panelFormInput.Controls.Add(this.txtCmnd);
            this.panelFormInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFormInput.Location = new System.Drawing.Point(0, 696);
            this.panelFormInput.Name = "panelFormInput";
            this.panelFormInput.Size = new System.Drawing.Size(873, 359);
            this.panelFormInput.TabIndex = 7;
            // 
            // txtMaCN
            // 
            this.txtMaCN.Enabled = false;
            this.txtMaCN.Location = new System.Drawing.Point(714, 133);
            this.txtMaCN.Name = "txtMaCN";
            this.txtMaCN.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCN.Properties.Appearance.Options.UseFont = true;
            this.txtMaCN.Size = new System.Drawing.Size(148, 34);
            this.txtMaCN.TabIndex = 17;
            // 
            // dtNgayCap
            // 
            this.dtNgayCap.CustomFormat = "dd/MM/yyyy";
            this.dtNgayCap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayCap.Location = new System.Drawing.Point(714, 82);
            this.dtNgayCap.Name = "dtNgayCap";
            this.dtNgayCap.Size = new System.Drawing.Size(148, 34);
            this.dtNgayCap.TabIndex = 6;
            // 
            // txtSoDT
            // 
            this.txtSoDT.Location = new System.Drawing.Point(107, 76);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDT.Properties.Appearance.Options.UseFont = true;
            this.txtSoDT.Properties.MaxLength = 15;
            this.txtSoDT.Size = new System.Drawing.Size(219, 34);
            this.txtSoDT.TabIndex = 4;
            this.txtSoDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCmnd_KeyPress);
            // 
            // coboxPhai
            // 
            this.coboxPhai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coboxPhai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coboxPhai.FormattingEnabled = true;
            this.coboxPhai.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.coboxPhai.Location = new System.Drawing.Point(470, 75);
            this.coboxPhai.Name = "coboxPhai";
            this.coboxPhai.Size = new System.Drawing.Size(133, 36);
            this.coboxPhai.TabIndex = 5;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(107, 132);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Properties.Appearance.Options.UseFont = true;
            this.txtDiaChi.Properties.MaxLength = 100;
            this.txtDiaChi.Size = new System.Drawing.Size(496, 34);
            this.txtDiaChi.TabIndex = 7;
            this.txtDiaChi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiaChi_KeyPress);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(715, 25);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtTen.Name = "txtTen";
            this.txtTen.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Properties.Appearance.Options.UseFont = true;
            this.txtTen.Properties.MaxLength = 10;
            this.txtTen.Size = new System.Drawing.Size(147, 34);
            this.txtTen.TabIndex = 3;
            this.txtTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTen_KeyPress);
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(470, 25);
            this.txtHo.Name = "txtHo";
            this.txtHo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHo.Properties.Appearance.Options.UseFont = true;
            this.txtHo.Properties.MaxLength = 50;
            this.txtHo.Size = new System.Drawing.Size(238, 34);
            this.txtHo.TabIndex = 2;
            this.txtHo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHo_KeyPress);
            // 
            // txtCmnd
            // 
            this.txtCmnd.Location = new System.Drawing.Point(107, 25);
            this.txtCmnd.Name = "txtCmnd";
            this.txtCmnd.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCmnd.Properties.Appearance.Options.UseFont = true;
            this.txtCmnd.Properties.MaxLength = 10;
            this.txtCmnd.Size = new System.Drawing.Size(219, 34);
            this.txtCmnd.TabIndex = 1;
            this.txtCmnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCmnd_KeyPress);
            // 
            // bdsTaiKhoan
            // 
            this.bdsTaiKhoan.DataMember = "FK_TaiKhoan_KhachHang";
            this.bdsTaiKhoan.DataSource = this.bdsKh;
            // 
            // taiKhoanTableAdapter
            // 
            this.taiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // taiKhoanGridControl
            // 
            this.taiKhoanGridControl.DataSource = this.bdsTaiKhoan;
            this.taiKhoanGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taiKhoanGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6);
            this.taiKhoanGridControl.Location = new System.Drawing.Point(873, 696);
            this.taiKhoanGridControl.MainView = this.gridView2;
            this.taiKhoanGridControl.Margin = new System.Windows.Forms.Padding(6);
            this.taiKhoanGridControl.Name = "taiKhoanGridControl";
            this.taiKhoanGridControl.Size = new System.Drawing.Size(679, 359);
            this.taiKhoanGridControl.TabIndex = 7;
            this.taiKhoanGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSOTK,
            this.colCMND1,
            this.colSODU,
            this.colMACN1,
            this.colNGAYMOTK});
            this.gridView2.GridControl = this.taiKhoanGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsBehavior.Editable = false;
            // 
            // colSOTK
            // 
            this.colSOTK.Caption = "Số TK";
            this.colSOTK.FieldName = "SOTK";
            this.colSOTK.MinWidth = 25;
            this.colSOTK.Name = "colSOTK";
            this.colSOTK.OptionsColumn.AllowEdit = false;
            this.colSOTK.Visible = true;
            this.colSOTK.VisibleIndex = 0;
            this.colSOTK.Width = 94;
            // 
            // colCMND1
            // 
            this.colCMND1.FieldName = "CMND";
            this.colCMND1.MinWidth = 25;
            this.colCMND1.Name = "colCMND1";
            this.colCMND1.OptionsColumn.AllowEdit = false;
            this.colCMND1.Visible = true;
            this.colCMND1.VisibleIndex = 1;
            this.colCMND1.Width = 94;
            // 
            // colSODU
            // 
            this.colSODU.Caption = "Số dư";
            this.colSODU.DisplayFormat.FormatString = "n0";
            this.colSODU.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSODU.FieldName = "SODU";
            this.colSODU.MinWidth = 25;
            this.colSODU.Name = "colSODU";
            this.colSODU.Visible = true;
            this.colSODU.VisibleIndex = 2;
            this.colSODU.Width = 94;
            // 
            // colMACN1
            // 
            this.colMACN1.Caption = "Chi nhánh";
            this.colMACN1.FieldName = "MACN";
            this.colMACN1.MinWidth = 25;
            this.colMACN1.Name = "colMACN1";
            this.colMACN1.Visible = true;
            this.colMACN1.VisibleIndex = 3;
            this.colMACN1.Width = 94;
            // 
            // colNGAYMOTK
            // 
            this.colNGAYMOTK.Caption = "Ngày mở TK";
            this.colNGAYMOTK.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.colNGAYMOTK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAYMOTK.FieldName = "NGAYMOTK";
            this.colNGAYMOTK.MinWidth = 25;
            this.colNGAYMOTK.Name = "colNGAYMOTK";
            this.colNGAYMOTK.Visible = true;
            this.colNGAYMOTK.VisibleIndex = 4;
            this.colNGAYMOTK.Width = 94;
            // 
            // FormQLKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1552, 1055);
            this.Controls.Add(this.taiKhoanGridControl);
            this.Controls.Add(this.panelFormInput);
            this.Controls.Add(this.gcKh);
            this.Controls.Add(this.panelChiNhanh);
            this.Controls.Add(this.toolStripMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormQLKhachHang";
            this.Text = "FormKhachHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormKhachHang_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.panelChiNhanh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panelFormInput.ResumeLayout(false);
            this.panelFormInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCmnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnGhi;
        private System.Windows.Forms.ToolStripButton btnPhucHoi;
        private System.Windows.Forms.ToolStripButton btnTaiLai;
        private System.Windows.Forms.Panel panelChiNhanh;
        private System.Windows.Forms.ComboBox comboxChiNhanh;
        private System.Windows.Forms.Label label2;
        private DTO.DS dS;
        private System.Windows.Forms.BindingSource bdsKh;
        private DTO.DSTableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private DTO.DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcKh;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYCAP;
        private DevExpress.XtraGrid.Columns.GridColumn colSODT;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private System.Windows.Forms.Panel panelFormInput;
        private System.Windows.Forms.DateTimePicker dtNgayCap;
        private DevExpress.XtraEditors.TextEdit txtSoDT;
        private System.Windows.Forms.ComboBox coboxPhai;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.TextEdit txtHo;
        private DevExpress.XtraEditors.TextEdit txtCmnd;
        private DevExpress.XtraEditors.TextEdit txtMaCN;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.BindingSource bdsTaiKhoan;
        private DTO.DSTableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private DevExpress.XtraGrid.GridControl taiKhoanGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND1;
        private DevExpress.XtraGrid.Columns.GridColumn colSODU;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN1;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYMOTK;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.Button btn_InTaiKhoan;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private System.Windows.Forms.ToolStripButton btnThoat;
    }
}