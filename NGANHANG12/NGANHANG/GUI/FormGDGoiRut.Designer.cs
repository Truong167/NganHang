
namespace NGANHANG.GUI
{
    partial class FormGDGoiRut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGDGoiRut));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.btnGoiTien = new System.Windows.Forms.ToolStripButton();
            this.btnRutTien = new System.Windows.Forms.ToolStripButton();
            this.btnGhi = new System.Windows.Forms.ToolStripButton();
            this.btnTaiLai = new System.Windows.Forms.ToolStripButton();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.dataSet = new NGANHANG.DTO.DS();
            this.taiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taiKhoanTableAdapter = new NGANHANG.DTO.DSTableAdapters.TaiKhoanTableAdapter();
            this.tableAdapterManager = new NGANHANG.DTO.DSTableAdapters.TableAdapterManager();
            this.taiKhoanGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridViewTaiKhoanGD = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYMOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoTK = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSoTien = new DevExpress.XtraEditors.TextEdit();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLoaiGD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerNgayGD = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoTenKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTaiKhoanGD)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTien.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGoiTien,
            this.btnRutTien,
            this.btnGhi,
            this.btnTaiLai,
            this.btnThoat});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(1552, 51);
            this.toolStripMenu.TabIndex = 2;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // btnGoiTien
            // 
            this.btnGoiTien.Image = global::NGANHANG.Properties.Resources.save_money_2_blue_24px;
            this.btnGoiTien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGoiTien.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGoiTien.Name = "btnGoiTien";
            this.btnGoiTien.Padding = new System.Windows.Forms.Padding(8);
            this.btnGoiTien.Size = new System.Drawing.Size(121, 48);
            this.btnGoiTien.Text = "Gởi tiền";
            this.btnGoiTien.Click += new System.EventHandler(this.btnGoiTien_Click);
            // 
            // btnRutTien
            // 
            this.btnRutTien.Image = ((System.Drawing.Image)(resources.GetObject("btnRutTien.Image")));
            this.btnRutTien.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRutTien.Name = "btnRutTien";
            this.btnRutTien.Padding = new System.Windows.Forms.Padding(8);
            this.btnRutTien.Size = new System.Drawing.Size(120, 48);
            this.btnRutTien.Text = "Rút tiền";
            this.btnRutTien.Click += new System.EventHandler(this.btnRutTien_Click);
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
            // btnThoat
            // 
            this.btnThoat.Image = global::NGANHANG.Properties.Resources.logout;
            this.btnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(181, 48);
            this.btnThoat.Text = "Thoát chức năng";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
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
            this.taiKhoanGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.taiKhoanGridControl.Location = new System.Drawing.Point(0, 51);
            this.taiKhoanGridControl.MainView = this.gridViewTaiKhoanGD;
            this.taiKhoanGridControl.Name = "taiKhoanGridControl";
            this.taiKhoanGridControl.Size = new System.Drawing.Size(1552, 600);
            this.taiKhoanGridControl.TabIndex = 3;
            this.taiKhoanGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTaiKhoanGD});
            // 
            // gridViewTaiKhoanGD
            // 
            this.gridViewTaiKhoanGD.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewTaiKhoanGD.Appearance.Row.Options.UseFont = true;
            this.gridViewTaiKhoanGD.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSOTK,
            this.colCMND,
            this.colSODU,
            this.colMACN,
            this.colNGAYMOTK});
            this.gridViewTaiKhoanGD.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridViewTaiKhoanGD.GridControl = this.taiKhoanGridControl;
            this.gridViewTaiKhoanGD.Name = "gridViewTaiKhoanGD";
            this.gridViewTaiKhoanGD.OptionsBehavior.Editable = false;
            this.gridViewTaiKhoanGD.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewTaiKhoanGD.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewTaiKhoanGD_FocusedRowChanged);
            // 
            // colSOTK
            // 
            this.colSOTK.Caption = "Số tài khoản";
            this.colSOTK.FieldName = "SOTK";
            this.colSOTK.MinWidth = 25;
            this.colSOTK.Name = "colSOTK";
            this.colSOTK.Visible = true;
            this.colSOTK.VisibleIndex = 0;
            this.colSOTK.Width = 94;
            // 
            // colCMND
            // 
            this.colCMND.Caption = "Số CMND/CCCD";
            this.colCMND.FieldName = "CMND";
            this.colCMND.MinWidth = 25;
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 1;
            this.colCMND.Width = 94;
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
            // colMACN
            // 
            this.colMACN.Caption = "Mã chi nhánh";
            this.colMACN.FieldName = "MACN";
            this.colMACN.MinWidth = 25;
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 3;
            this.colMACN.Width = 94;
            // 
            // colNGAYMOTK
            // 
            this.colNGAYMOTK.Caption = "Ngày mở tài khoản";
            this.colNGAYMOTK.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.colNGAYMOTK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAYMOTK.FieldName = "NGAYMOTK";
            this.colNGAYMOTK.MinWidth = 25;
            this.colNGAYMOTK.Name = "colNGAYMOTK";
            this.colNGAYMOTK.Visible = true;
            this.colNGAYMOTK.VisibleIndex = 4;
            this.colNGAYMOTK.Width = 94;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Số tài khoản:";
            // 
            // txtSoTK
            // 
            this.txtSoTK.Location = new System.Drawing.Point(166, 29);
            this.txtSoTK.MaxLength = 9;
            this.txtSoTK.Name = "txtSoTK";
            this.txtSoTK.Size = new System.Drawing.Size(250, 34);
            this.txtSoTK.TabIndex = 1;
            this.txtSoTK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoTK_KeyPress);
            this.txtSoTK.Leave += new System.EventHandler(this.txtSoTK_Leave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSoTien);
            this.panel1.Controls.Add(this.txtCMND);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtMaNV);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtLoaiGD);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dateTimePickerNgayGD);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtHoTenKH);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSoTK);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 651);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1552, 404);
            this.panel1.TabIndex = 6;
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(674, 140);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTien.Properties.Appearance.Options.UseFont = true;
            this.txtSoTien.Properties.Mask.EditMask = "n0";
            this.txtSoTien.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSoTien.Size = new System.Drawing.Size(250, 34);
            this.txtSoTien.TabIndex = 17;
            this.txtSoTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoTK_KeyPress);
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(166, 84);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.ReadOnly = true;
            this.txtCMND.Size = new System.Drawing.Size(250, 34);
            this.txtCMND.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 28);
            this.label7.TabIndex = 16;
            this.label7.Text = "CMND/CCCD:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(166, 199);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(250, 34);
            this.txtMaNV.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 28);
            this.label6.TabIndex = 14;
            this.label6.Text = "Mã nhân viên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(488, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 28);
            this.label5.TabIndex = 12;
            this.label5.Text = "Số tiền (VNĐ):";
            // 
            // txtLoaiGD
            // 
            this.txtLoaiGD.Location = new System.Drawing.Point(166, 140);
            this.txtLoaiGD.Name = "txtLoaiGD";
            this.txtLoaiGD.ReadOnly = true;
            this.txtLoaiGD.Size = new System.Drawing.Size(250, 34);
            this.txtLoaiGD.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "Loại giao dịch:";
            // 
            // dateTimePickerNgayGD
            // 
            this.dateTimePickerNgayGD.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerNgayGD.Enabled = false;
            this.dateTimePickerNgayGD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgayGD.Location = new System.Drawing.Point(674, 27);
            this.dateTimePickerNgayGD.Name = "dateTimePickerNgayGD";
            this.dateTimePickerNgayGD.Size = new System.Drawing.Size(250, 34);
            this.dateTimePickerNgayGD.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(488, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ngày giao dịch:";
            // 
            // txtHoTenKH
            // 
            this.txtHoTenKH.Location = new System.Drawing.Point(674, 81);
            this.txtHoTenKH.Name = "txtHoTenKH";
            this.txtHoTenKH.ReadOnly = true;
            this.txtHoTenKH.Size = new System.Drawing.Size(250, 34);
            this.txtHoTenKH.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(488, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Họ tên khách hàng:";
            // 
            // FormGDGoiRut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1552, 1055);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.taiKhoanGridControl);
            this.Controls.Add(this.toolStripMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormGDGoiRut";
            this.Text = "FormGDGoiRut";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormGDGoiRut_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTaiKhoanGD)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTien.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton btnGoiTien;
        private System.Windows.Forms.ToolStripButton btnRutTien;
        private System.Windows.Forms.ToolStripButton btnTaiLai;
        private DTO.DS dataSet;
        private System.Windows.Forms.BindingSource taiKhoanBindingSource;
        private DTO.DSTableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private DTO.DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl taiKhoanGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTaiKhoanGD;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colSODU;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYMOTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoTK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLoaiGD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayGD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoTenKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton btnGhi;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit txtSoTien;
    }
}