
namespace NGANHANG.GUI
{
    partial class FormGDChuyenTien
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
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.btnGhi = new System.Windows.Forms.ToolStripButton();
            this.btnTaiLai = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSoTien = new DevExpress.XtraEditors.TextEdit();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtSoTKN = new System.Windows.Forms.TextBox();
            this.txtHoTenNN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSoTKC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerNgayGD = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoTenNC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSet = new NGANHANG.DTO.DS();
            this.taiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taiKhoanTableAdapter = new NGANHANG.DTO.DSTableAdapters.TaiKhoanTableAdapter();
            this.tableAdapterManager = new NGANHANG.DTO.DSTableAdapters.TableAdapterManager();
            this.taiKhoanGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridViewTaiKhoan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYMOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStripMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGhi,
            this.btnTaiLai});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(1555, 51);
            this.toolStripMenu.TabIndex = 3;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // btnGhi
            // 
            this.btnGhi.Image = global::NGANHANG.Properties.Resources.diskette_blue_24px;
            this.btnGhi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(66, 48);
            this.btnGhi.Text = "Ghi";
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSoTien);
            this.panel1.Controls.Add(this.txtMaNV);
            this.panel1.Controls.Add(this.txtSoTKN);
            this.panel1.Controls.Add(this.txtHoTenNN);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtSoTKC);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dateTimePickerNgayGD);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtHoTenNC);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.panel1.Location = new System.Drawing.Point(0, 816);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1555, 286);
            this.panel1.TabIndex = 7;
            // 
            // txtSoTien
            // 
            this.txtSoTien.EnterMoveNextControl = true;
            this.txtSoTien.Location = new System.Drawing.Point(747, 136);
            this.txtSoTien.MaximumSize = new System.Drawing.Size(250, 34);
            this.txtSoTien.MinimumSize = new System.Drawing.Size(250, 34);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTien.Properties.Appearance.Options.UseFont = true;
            this.txtSoTien.Properties.Mask.EditMask = "n0";
            this.txtSoTien.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSoTien.Size = new System.Drawing.Size(250, 34);
            this.txtSoTien.TabIndex = 6;
            this.txtSoTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoTKC_KeyPress);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMaNV.Location = new System.Drawing.Point(235, 196);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(250, 34);
            this.txtMaNV.TabIndex = 7;
            // 
            // txtSoTKN
            // 
            this.txtSoTKN.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSoTKN.Location = new System.Drawing.Point(235, 84);
            this.txtSoTKN.MaxLength = 9;
            this.txtSoTKN.Name = "txtSoTKN";
            this.txtSoTKN.Size = new System.Drawing.Size(250, 34);
            this.txtSoTKN.TabIndex = 3;
            this.txtSoTKN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoTKC_KeyPress);
            this.txtSoTKN.Leave += new System.EventHandler(this.txtSoTKN_Leave);
            // 
            // txtHoTenNN
            // 
            this.txtHoTenNN.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtHoTenNN.Location = new System.Drawing.Point(747, 84);
            this.txtHoTenNN.Name = "txtHoTenNN";
            this.txtHoTenNN.ReadOnly = true;
            this.txtHoTenNN.Size = new System.Drawing.Size(250, 34);
            this.txtHoTenNN.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.Location = new System.Drawing.Point(542, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 28);
            this.label8.TabIndex = 42;
            this.label8.Text = "Họ tên người nhận:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label9.Location = new System.Drawing.Point(30, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 28);
            this.label9.TabIndex = 41;
            this.label9.Text = "Số tài khoản nhận:";
            // 
            // txtSoTKC
            // 
            this.txtSoTKC.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSoTKC.Location = new System.Drawing.Point(235, 33);
            this.txtSoTKC.MaxLength = 9;
            this.txtSoTKC.Name = "txtSoTKC";
            this.txtSoTKC.Size = new System.Drawing.Size(250, 34);
            this.txtSoTKC.TabIndex = 1;
            this.txtSoTKC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoTKC_KeyPress);
            this.txtSoTKC.Leave += new System.EventHandler(this.txtSoTKC_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(35, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 28);
            this.label6.TabIndex = 35;
            this.label6.Text = "Mã nhân viên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(542, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 28);
            this.label5.TabIndex = 34;
            this.label5.Text = "Số tiền (VNĐ):";
            // 
            // dateTimePickerNgayGD
            // 
            this.dateTimePickerNgayGD.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerNgayGD.Enabled = false;
            this.dateTimePickerNgayGD.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dateTimePickerNgayGD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgayGD.Location = new System.Drawing.Point(235, 139);
            this.dateTimePickerNgayGD.Name = "dateTimePickerNgayGD";
            this.dateTimePickerNgayGD.Size = new System.Drawing.Size(250, 34);
            this.dateTimePickerNgayGD.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(35, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 28);
            this.label3.TabIndex = 33;
            this.label3.Text = "Ngày giao dịch:";
            // 
            // txtHoTenNC
            // 
            this.txtHoTenNC.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtHoTenNC.Location = new System.Drawing.Point(747, 30);
            this.txtHoTenNC.Name = "txtHoTenNC";
            this.txtHoTenNC.ReadOnly = true;
            this.txtHoTenNC.Size = new System.Drawing.Size(250, 34);
            this.txtHoTenNC.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(542, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 28);
            this.label2.TabIndex = 31;
            this.label2.Text = "Họ tên người chuyển:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 28);
            this.label1.TabIndex = 29;
            this.label1.Text = "Số tài khoản chuyển:";
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DS";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taiKhoanBindingSource
            // 
            this.taiKhoanBindingSource.DataMember = "TaiKhoan";
            this.taiKhoanBindingSource.DataSource = this.dataSet;
            // 
            // taiKhoanTableAdapter
            // 
            this.taiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = this.taiKhoanTableAdapter;
            this.tableAdapterManager.UpdateOrder = NGANHANG.DTO.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // taiKhoanGridControl
            // 
            this.taiKhoanGridControl.DataSource = this.taiKhoanBindingSource;
            this.taiKhoanGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taiKhoanGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.taiKhoanGridControl.Location = new System.Drawing.Point(0, 51);
            this.taiKhoanGridControl.MainView = this.gridViewTaiKhoan;
            this.taiKhoanGridControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.taiKhoanGridControl.Name = "taiKhoanGridControl";
            this.taiKhoanGridControl.Size = new System.Drawing.Size(1555, 1051);
            this.taiKhoanGridControl.TabIndex = 8;
            this.taiKhoanGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTaiKhoan});
            this.taiKhoanGridControl.Click += new System.EventHandler(this.taiKhoanGridControl_Click);
            // 
            // gridViewTaiKhoan
            // 
            this.gridViewTaiKhoan.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewTaiKhoan.Appearance.Row.Options.UseFont = true;
            this.gridViewTaiKhoan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSOTK,
            this.colCMND,
            this.colSODU,
            this.colMACN,
            this.colNGAYMOTK});
            this.gridViewTaiKhoan.DetailHeight = 546;
            this.gridViewTaiKhoan.GridControl = this.taiKhoanGridControl;
            this.gridViewTaiKhoan.Name = "gridViewTaiKhoan";
            this.gridViewTaiKhoan.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewTaiKhoan.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewTaiKhoan.OptionsBehavior.Editable = false;
            // 
            // colSOTK
            // 
            this.colSOTK.Caption = "Số tài khoản";
            this.colSOTK.FieldName = "SOTK";
            this.colSOTK.MinWidth = 39;
            this.colSOTK.Name = "colSOTK";
            this.colSOTK.Visible = true;
            this.colSOTK.VisibleIndex = 0;
            this.colSOTK.Width = 146;
            // 
            // colCMND
            // 
            this.colCMND.Caption = "Số CMND/CCCD";
            this.colCMND.FieldName = "CMND";
            this.colCMND.MinWidth = 39;
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 1;
            this.colCMND.Width = 146;
            // 
            // colSODU
            // 
            this.colSODU.Caption = "Số dư";
            this.colSODU.DisplayFormat.FormatString = "n0";
            this.colSODU.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSODU.FieldName = "SODU";
            this.colSODU.MinWidth = 39;
            this.colSODU.Name = "colSODU";
            this.colSODU.Visible = true;
            this.colSODU.VisibleIndex = 2;
            this.colSODU.Width = 146;
            // 
            // colMACN
            // 
            this.colMACN.Caption = "Mã chi nhánh";
            this.colMACN.FieldName = "MACN";
            this.colMACN.MinWidth = 39;
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 3;
            this.colMACN.Width = 146;
            // 
            // colNGAYMOTK
            // 
            this.colNGAYMOTK.Caption = "Ngày mở tài khoản";
            this.colNGAYMOTK.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.colNGAYMOTK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAYMOTK.FieldName = "NGAYMOTK";
            this.colNGAYMOTK.MinWidth = 39;
            this.colNGAYMOTK.Name = "colNGAYMOTK";
            this.colNGAYMOTK.Visible = true;
            this.colNGAYMOTK.VisibleIndex = 4;
            this.colNGAYMOTK.Width = 146;
            // 
            // FormGDChuyenTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1555, 1102);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.taiKhoanGridControl);
            this.Controls.Add(this.toolStripMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGDChuyenTien";
            this.Text = "FormChuyenTien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormChuyenTien_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton btnGhi;
        private System.Windows.Forms.ToolStripButton btnTaiLai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtSoTKN;
        private System.Windows.Forms.TextBox txtHoTenNN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSoTKC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayGD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoTenNC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DTO.DS dataSet;
        private System.Windows.Forms.BindingSource taiKhoanBindingSource;
        private DTO.DSTableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private DTO.DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl taiKhoanGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTaiKhoan;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colSODU;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYMOTK;
        private DevExpress.XtraEditors.TextEdit txtSoTien;
    }
}