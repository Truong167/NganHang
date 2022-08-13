
namespace NGANHANG.GUI
{
    partial class FormQLLogin
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
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.btnGhi = new System.Windows.Forms.ToolStripButton();
            this.btnPhucHoi = new System.Windows.Forms.ToolStripButton();
            this.btnTaiLai = new System.Windows.Forms.ToolStripButton();
            this.panelChiNhanh = new System.Windows.Forms.Panel();
            this.comboxChiNhanh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelFormInput = new System.Windows.Forms.Panel();
            this.txtMatKhauXacNhan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridViewNhanVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControlNhanVien = new DevExpress.XtraGrid.GridControl();
            this.toolStripMenu.SuspendLayout();
            this.panelChiNhanh.SuspendLayout();
            this.panelFormInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNhanVien)).BeginInit();
            this.SuspendLayout();
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
            this.toolStripMenu.TabIndex = 1;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // btnGhi
            // 
            this.btnGhi.Image = global::NGANHANG.Properties.Resources.diskette_blue_24px;
            this.btnGhi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGhi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Padding = new System.Windows.Forms.Padding(8);
            this.btnGhi.Size = new System.Drawing.Size(82, 48);
            this.btnGhi.Text = "Ghi";
            this.btnGhi.Click += new System.EventHandler(this.btnThem_Click);
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
            // panelChiNhanh
            // 
            this.panelChiNhanh.Controls.Add(this.comboxChiNhanh);
            this.panelChiNhanh.Controls.Add(this.label2);
            this.panelChiNhanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChiNhanh.Location = new System.Drawing.Point(0, 51);
            this.panelChiNhanh.Name = "panelChiNhanh";
            this.panelChiNhanh.Size = new System.Drawing.Size(1552, 45);
            this.panelChiNhanh.TabIndex = 5;
            // 
            // comboxChiNhanh
            // 
            this.comboxChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxChiNhanh.Enabled = false;
            this.comboxChiNhanh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboxChiNhanh.FormattingEnabled = true;
            this.comboxChiNhanh.Location = new System.Drawing.Point(130, 3);
            this.comboxChiNhanh.Name = "comboxChiNhanh";
            this.comboxChiNhanh.Size = new System.Drawing.Size(273, 36);
            this.comboxChiNhanh.TabIndex = 0;
            this.comboxChiNhanh.SelectedValueChanged += new System.EventHandler(this.comboxChiNhanh_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(121, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chi nhánh:";
            // 
            // panelFormInput
            // 
            this.panelFormInput.Controls.Add(this.txtMatKhauXacNhan);
            this.panelFormInput.Controls.Add(this.label4);
            this.panelFormInput.Controls.Add(this.txtMatKhau);
            this.panelFormInput.Controls.Add(this.label3);
            this.panelFormInput.Controls.Add(this.txtTaiKhoan);
            this.panelFormInput.Controls.Add(this.label1);
            this.panelFormInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormInput.Location = new System.Drawing.Point(0, 696);
            this.panelFormInput.Name = "panelFormInput";
            this.panelFormInput.Size = new System.Drawing.Size(1552, 359);
            this.panelFormInput.TabIndex = 7;
            // 
            // txtMatKhauXacNhan
            // 
            this.txtMatKhauXacNhan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauXacNhan.Location = new System.Drawing.Point(213, 113);
            this.txtMatKhauXacNhan.MaxLength = 20;
            this.txtMatKhauXacNhan.Name = "txtMatKhauXacNhan";
            this.txtMatKhauXacNhan.Size = new System.Drawing.Size(346, 34);
            this.txtMatKhauXacNhan.TabIndex = 5;
            this.txtMatKhauXacNhan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatKhau_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Xác nhận mật khẩu:";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(213, 66);
            this.txtMatKhau.MaxLength = 20;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(346, 34);
            this.txtMatKhau.TabIndex = 3;
            this.txtMatKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatKhau_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu:";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.Location = new System.Drawing.Point(213, 21);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.ReadOnly = true;
            this.txtTaiKhoan.Size = new System.Drawing.Size(346, 34);
            this.txtTaiKhoan.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản:";
            // 
            // gridViewNhanVien
            // 
            this.gridViewNhanVien.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewNhanVien.Appearance.Row.Options.UseFont = true;
            this.gridViewNhanVien.DetailHeight = 546;
            this.gridViewNhanVien.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridViewNhanVien.GridControl = this.gridControlNhanVien;
            this.gridViewNhanVien.Name = "gridViewNhanVien";
            this.gridViewNhanVien.OptionsBehavior.Editable = false;
            this.gridViewNhanVien.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewNhanVien.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewNhanVien_FocusedRowChanged);
            // 
            // gridControlNhanVien
            // 
            this.gridControlNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControlNhanVien.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.gridControlNhanVien.Location = new System.Drawing.Point(0, 96);
            this.gridControlNhanVien.MainView = this.gridViewNhanVien;
            this.gridControlNhanVien.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.gridControlNhanVien.Name = "gridControlNhanVien";
            this.gridControlNhanVien.Size = new System.Drawing.Size(1552, 600);
            this.gridControlNhanVien.TabIndex = 6;
            this.gridControlNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewNhanVien});
            // 
            // FormQLLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1552, 1055);
            this.Controls.Add(this.panelFormInput);
            this.Controls.Add(this.gridControlNhanVien);
            this.Controls.Add(this.panelChiNhanh);
            this.Controls.Add(this.toolStripMenu);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormQLLogin";
            this.Text = "FormQLTaiKhoan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.panelChiNhanh.ResumeLayout(false);
            this.panelFormInput.ResumeLayout(false);
            this.panelFormInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton btnGhi;
        private System.Windows.Forms.ToolStripButton btnPhucHoi;
        private System.Windows.Forms.ToolStripButton btnTaiLai;
        private System.Windows.Forms.Panel panelChiNhanh;
        private System.Windows.Forms.ComboBox comboxChiNhanh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelFormInput;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewNhanVien;
        private DevExpress.XtraGrid.GridControl gridControlNhanVien;
        private System.Windows.Forms.TextBox txtMatKhauXacNhan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label label1;
    }
}