using NGANHANG.DTO;
namespace NGANHANG.GUI
{
    partial class FormQLNhanVien
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
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label pHAILabel;
            System.Windows.Forms.Label sODTLabel;
            System.Windows.Forms.Label mACNLabel;
            System.Windows.Forms.Label label1;
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnChuyenCN = new System.Windows.Forms.ToolStripButton();
            this.btnGhi = new System.Windows.Forms.ToolStripButton();
            this.btnPhucHoi = new System.Windows.Forms.ToolStripButton();
            this.btnTaiLai = new System.Windows.Forms.ToolStripButton();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.dataSet = new NGANHANG.DTO.DS();
            this.bindingSourceNhanVien = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterNhanVien = new NGANHANG.DTO.DSTableAdapters.NhanVienTableAdapter();
            this.tableAdapterManager = new NGANHANG.DTO.DSTableAdapters.TableAdapterManager();
            this.gridControlNhanVien = new DevExpress.XtraGrid.GridControl();
            this.gridViewNhanVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThaiXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelFormInput = new System.Windows.Forms.Panel();
            this.chboxDaXoa = new System.Windows.Forms.CheckBox();
            this.txtMaCN = new DevExpress.XtraEditors.TextEdit();
            this.txtSoDT = new DevExpress.XtraEditors.TextEdit();
            this.coboxPhai = new System.Windows.Forms.ComboBox();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtHo = new DevExpress.XtraEditors.TextEdit();
            this.txtMaNV = new DevExpress.XtraEditors.TextEdit();
            this.panelChiNhanh = new System.Windows.Forms.Panel();
            this.comboxChiNhanh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            pHAILabel = new System.Windows.Forms.Label();
            sODTLabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.toolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNhanVien)).BeginInit();
            this.panelFormInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).BeginInit();
            this.panelChiNhanh.SuspendLayout();
            this.SuspendLayout();
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mANVLabel.Location = new System.Drawing.Point(28, 28);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(76, 28);
            mANVLabel.TabIndex = 0;
            mANVLabel.Text = "Mã NV:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOLabel.Location = new System.Drawing.Point(368, 28);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(100, 28);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "Họ và tên:";
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
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mACNLabel.Location = new System.Drawing.Point(609, 79);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(76, 28);
            mACNLabel.TabIndex = 12;
            mACNLabel.Text = "Mã CN:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(609, 134);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(165, 28);
            label1.TabIndex = 16;
            label1.Text = "Trạng thái đã xóa:";
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnSua,
            this.btnChuyenCN,
            this.btnGhi,
            this.btnPhucHoi,
            this.btnTaiLai,
            this.btnThoat});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(1552, 51);
            this.toolStripMenu.TabIndex = 0;
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
            // btnChuyenCN
            // 
            this.btnChuyenCN.Image = global::NGANHANG.Properties.Resources.chuyen_cn_blue_24px;
            this.btnChuyenCN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnChuyenCN.Name = "btnChuyenCN";
            this.btnChuyenCN.Size = new System.Drawing.Size(190, 48);
            this.btnChuyenCN.Text = "Chuyển chi nhánh";
            this.btnChuyenCN.Click += new System.EventHandler(this.btnChuyenCN_Click);
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
            // dataSet
            // 
            this.dataSet.DataSetName = "DS";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSourceNhanVien
            // 
            this.bindingSourceNhanVien.DataMember = "NhanVien";
            this.bindingSourceNhanVien.DataSource = this.dataSet;
            // 
            // tableAdapterNhanVien
            // 
            this.tableAdapterNhanVien.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = this.tableAdapterNhanVien;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NGANHANG.DTO.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gridControlNhanVien
            // 
            this.gridControlNhanVien.DataSource = this.bindingSourceNhanVien;
            this.gridControlNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControlNhanVien.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(8);
            this.gridControlNhanVien.Location = new System.Drawing.Point(0, 96);
            this.gridControlNhanVien.MainView = this.gridViewNhanVien;
            this.gridControlNhanVien.Margin = new System.Windows.Forms.Padding(8);
            this.gridControlNhanVien.Name = "gridControlNhanVien";
            this.gridControlNhanVien.Size = new System.Drawing.Size(1552, 600);
            this.gridControlNhanVien.TabIndex = 2;
            this.gridControlNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewNhanVien});
            // 
            // gridViewNhanVien
            // 
            this.gridViewNhanVien.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewNhanVien.Appearance.Row.Options.UseFont = true;
            this.gridViewNhanVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colPHAI,
            this.colSoDT,
            this.colMACN,
            this.colTrangThaiXoa});
            this.gridViewNhanVien.DetailHeight = 392;
            this.gridViewNhanVien.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gridViewNhanVien.GridControl = this.gridControlNhanVien;
            this.gridViewNhanVien.Name = "gridViewNhanVien";
            this.gridViewNhanVien.OptionsBehavior.Editable = false;
            this.gridViewNhanVien.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewNhanVien.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewNhanVien_FocusedRowChanged);
            // 
            // colMANV
            // 
            this.colMANV.Caption = "Mã NV";
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 23;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            this.colMANV.Width = 142;
            // 
            // colHO
            // 
            this.colHO.Caption = "Họ";
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 23;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 142;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "Tên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 23;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 142;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "Địa chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 23;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            this.colDIACHI.Width = 188;
            // 
            // colPHAI
            // 
            this.colPHAI.Caption = "Phái";
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.MinWidth = 23;
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 5;
            this.colPHAI.Width = 104;
            // 
            // colSoDT
            // 
            this.colSoDT.Caption = "Số ĐT";
            this.colSoDT.FieldName = "SODT";
            this.colSoDT.MinWidth = 23;
            this.colSoDT.Name = "colSoDT";
            this.colSoDT.Visible = true;
            this.colSoDT.VisibleIndex = 4;
            this.colSoDT.Width = 86;
            // 
            // colMACN
            // 
            this.colMACN.Caption = "Mã chi nhánh";
            this.colMACN.FieldName = "MACN";
            this.colMACN.MinWidth = 23;
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 6;
            this.colMACN.Width = 115;
            // 
            // colTrangThaiXoa
            // 
            this.colTrangThaiXoa.FieldName = "TrangThaiXoa";
            this.colTrangThaiXoa.MinWidth = 23;
            this.colTrangThaiXoa.Name = "colTrangThaiXoa";
            this.colTrangThaiXoa.Visible = true;
            this.colTrangThaiXoa.VisibleIndex = 7;
            this.colTrangThaiXoa.Width = 111;
            // 
            // panelFormInput
            // 
            this.panelFormInput.Controls.Add(label1);
            this.panelFormInput.Controls.Add(this.chboxDaXoa);
            this.panelFormInput.Controls.Add(mACNLabel);
            this.panelFormInput.Controls.Add(this.txtMaCN);
            this.panelFormInput.Controls.Add(sODTLabel);
            this.panelFormInput.Controls.Add(this.txtSoDT);
            this.panelFormInput.Controls.Add(pHAILabel);
            this.panelFormInput.Controls.Add(this.coboxPhai);
            this.panelFormInput.Controls.Add(dIACHILabel);
            this.panelFormInput.Controls.Add(this.txtDiaChi);
            this.panelFormInput.Controls.Add(this.txtTen);
            this.panelFormInput.Controls.Add(hOLabel);
            this.panelFormInput.Controls.Add(this.txtHo);
            this.panelFormInput.Controls.Add(mANVLabel);
            this.panelFormInput.Controls.Add(this.txtMaNV);
            this.panelFormInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormInput.Location = new System.Drawing.Point(0, 696);
            this.panelFormInput.Name = "panelFormInput";
            this.panelFormInput.Size = new System.Drawing.Size(1552, 359);
            this.panelFormInput.TabIndex = 3;
            // 
            // chboxDaXoa
            // 
            this.chboxDaXoa.AutoSize = true;
            this.chboxDaXoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chboxDaXoa.Location = new System.Drawing.Point(808, 141);
            this.chboxDaXoa.Name = "chboxDaXoa";
            this.chboxDaXoa.Size = new System.Drawing.Size(18, 17);
            this.chboxDaXoa.TabIndex = 8;
            this.chboxDaXoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chboxDaXoa.UseVisualStyleBackColor = true;
            // 
            // txtMaCN
            // 
            this.txtMaCN.Enabled = false;
            this.txtMaCN.Location = new System.Drawing.Point(691, 75);
            this.txtMaCN.Name = "txtMaCN";
            this.txtMaCN.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCN.Properties.Appearance.Options.UseFont = true;
            this.txtMaCN.Size = new System.Drawing.Size(148, 34);
            this.txtMaCN.TabIndex = 6;
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
            this.txtSoDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoDT_KeyPress);
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
            this.txtTen.Location = new System.Drawing.Point(691, 25);
            this.txtTen.Name = "txtTen";
            this.txtTen.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Properties.Appearance.Options.UseFont = true;
            this.txtTen.Properties.MaxLength = 10;
            this.txtTen.Size = new System.Drawing.Size(148, 34);
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
            this.txtHo.Size = new System.Drawing.Size(215, 34);
            this.txtHo.TabIndex = 2;
            this.txtHo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHo_KeyPress);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(107, 25);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Properties.Appearance.Options.UseFont = true;
            this.txtMaNV.Properties.MaxLength = 10;
            this.txtMaNV.Size = new System.Drawing.Size(219, 34);
            this.txtMaNV.TabIndex = 1;
            this.txtMaNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaNV_KeyPress);
            // 
            // panelChiNhanh
            // 
            this.panelChiNhanh.Controls.Add(this.comboxChiNhanh);
            this.panelChiNhanh.Controls.Add(this.label2);
            this.panelChiNhanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChiNhanh.Location = new System.Drawing.Point(0, 51);
            this.panelChiNhanh.Name = "panelChiNhanh";
            this.panelChiNhanh.Size = new System.Drawing.Size(1552, 45);
            this.panelChiNhanh.TabIndex = 4;
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
            // FormQLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1552, 1055);
            this.Controls.Add(this.panelFormInput);
            this.Controls.Add(this.gridControlNhanVien);
            this.Controls.Add(this.panelChiNhanh);
            this.Controls.Add(this.toolStripMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "FormQLNhanVien";
            this.Text = "MyFormNhanVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MyFormNhanVien_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNhanVien)).EndInit();
            this.panelFormInput.ResumeLayout(false);
            this.panelFormInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).EndInit();
            this.panelChiNhanh.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripButton btnThoat;
        private DTO.DS dataSet;
        private System.Windows.Forms.BindingSource bindingSourceNhanVien;
        private DTO.DSTableAdapters.NhanVienTableAdapter tableAdapterNhanVien;
        private DTO.DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gridControlNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThaiXoa;
        private DevExpress.XtraGrid.Columns.GridColumn colSoDT;
        private System.Windows.Forms.Panel panelFormInput;
        private System.Windows.Forms.CheckBox chboxDaXoa;
        private DevExpress.XtraEditors.TextEdit txtMaCN;
        private DevExpress.XtraEditors.TextEdit txtSoDT;
        private System.Windows.Forms.ComboBox coboxPhai;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtHo;
        private DevExpress.XtraEditors.TextEdit txtMaNV;
        private System.Windows.Forms.Panel panelChiNhanh;
        private System.Windows.Forms.ComboBox comboxChiNhanh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton btnChuyenCN;
    }
}