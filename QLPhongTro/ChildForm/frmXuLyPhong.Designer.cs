namespace QLPhongTro.ChildForm
{
    partial class frmXuLyPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXuLyPhong));
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.ptbExit2 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ptbMinimize = new System.Windows.Forms.PictureBox();
            this.iconApp = new System.Windows.Forms.PictureBox();
            this.ptbState = new System.Windows.Forms.PictureBox();
            this.ptbExit = new System.Windows.Forms.PictureBox();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.grbContent = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.ckbHoatDong = new System.Windows.Forms.CheckBox();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExit)).BeginInit();
            this.grbContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 35);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(10, 346);
            this.pnlLeft.TabIndex = 1;
            // 
            // pnlRight
            // 
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(715, 35);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(10, 346);
            this.pnlRight.TabIndex = 2;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.ptbExit2);
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Controls.Add(this.ptbMinimize);
            this.pnlTop.Controls.Add(this.iconApp);
            this.pnlTop.Controls.Add(this.ptbState);
            this.pnlTop.Controls.Add(this.ptbExit);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(725, 35);
            this.pnlTop.TabIndex = 3;
            // 
            // ptbExit2
            // 
            this.ptbExit2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbExit2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbExit2.Image = ((System.Drawing.Image)(resources.GetObject("ptbExit2.Image")));
            this.ptbExit2.Location = new System.Drawing.Point(689, 4);
            this.ptbExit2.Name = "ptbExit2";
            this.ptbExit2.Size = new System.Drawing.Size(27, 27);
            this.ptbExit2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbExit2.TabIndex = 4;
            this.ptbExit2.TabStop = false;
            this.ptbExit2.Click += new System.EventHandler(this.ptbExit2_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(36, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(102, 22);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Xử lý phòng";
            // 
            // ptbMinimize
            // 
            this.ptbMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbMinimize.Image = global::QLPhongTro.Properties.Resources.minimazar;
            this.ptbMinimize.Location = new System.Drawing.Point(1434, 6);
            this.ptbMinimize.Name = "ptbMinimize";
            this.ptbMinimize.Size = new System.Drawing.Size(22, 22);
            this.ptbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMinimize.TabIndex = 0;
            this.ptbMinimize.TabStop = false;
            // 
            // iconApp
            // 
            this.iconApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconApp.Image = ((System.Drawing.Image)(resources.GetObject("iconApp.Image")));
            this.iconApp.Location = new System.Drawing.Point(12, 8);
            this.iconApp.Name = "iconApp";
            this.iconApp.Size = new System.Drawing.Size(22, 22);
            this.iconApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconApp.TabIndex = 0;
            this.iconApp.TabStop = false;
            // 
            // ptbState
            // 
            this.ptbState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbState.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbState.Image = global::QLPhongTro.Properties.Resources.maxi;
            this.ptbState.Location = new System.Drawing.Point(1462, 6);
            this.ptbState.Name = "ptbState";
            this.ptbState.Size = new System.Drawing.Size(22, 22);
            this.ptbState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbState.TabIndex = 0;
            this.ptbState.TabStop = false;
            // 
            // ptbExit
            // 
            this.ptbExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbExit.Image = ((System.Drawing.Image)(resources.GetObject("ptbExit.Image")));
            this.ptbExit.Location = new System.Drawing.Point(1490, 3);
            this.ptbExit.Name = "ptbExit";
            this.ptbExit.Size = new System.Drawing.Size(27, 27);
            this.ptbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbExit.TabIndex = 0;
            this.ptbExit.TabStop = false;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 381);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(725, 10);
            this.pnlBottom.TabIndex = 4;
            // 
            // grbContent
            // 
            this.grbContent.AutoSize = true;
            this.grbContent.Controls.Add(this.btnHuy);
            this.grbContent.Controls.Add(this.btnXacNhan);
            this.grbContent.Controls.Add(this.ckbHoatDong);
            this.grbContent.Controls.Add(this.txtTenPhong);
            this.grbContent.Controls.Add(this.label3);
            this.grbContent.Controls.Add(this.label2);
            this.grbContent.Controls.Add(this.label1);
            this.grbContent.Controls.Add(this.cbbLoaiPhong);
            this.grbContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbContent.Location = new System.Drawing.Point(10, 35);
            this.grbContent.Name = "grbContent";
            this.grbContent.Size = new System.Drawing.Size(705, 346);
            this.grbContent.TabIndex = 5;
            this.grbContent.TabStop = false;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.SlateGray;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(362, 258);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(155, 34);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.SlateGray;
            this.btnXacNhan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(185, 258);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(155, 34);
            this.btnXacNhan.TabIndex = 10;
            this.btnXacNhan.Text = "Xác nhận ";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // ckbHoatDong
            // 
            this.ckbHoatDong.AutoSize = true;
            this.ckbHoatDong.Checked = true;
            this.ckbHoatDong.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbHoatDong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbHoatDong.ForeColor = System.Drawing.Color.White;
            this.ckbHoatDong.Location = new System.Drawing.Point(239, 177);
            this.ckbHoatDong.Name = "ckbHoatDong";
            this.ckbHoatDong.Size = new System.Drawing.Size(129, 29);
            this.ckbHoatDong.TabIndex = 9;
            this.ckbHoatDong.Text = "Hoạt động";
            this.ckbHoatDong.UseVisualStyleBackColor = true;
            this.ckbHoatDong.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(239, 131);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(338, 31);
            this.txtTenPhong.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(119, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Trạng thái";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(119, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(119, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Loại phòng";
            // 
            // cbbLoaiPhong
            // 
            this.cbbLoaiPhong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbbLoaiPhong.FormattingEnabled = true;
            this.cbbLoaiPhong.Location = new System.Drawing.Point(240, 83);
            this.cbbLoaiPhong.Name = "cbbLoaiPhong";
            this.cbbLoaiPhong.Size = new System.Drawing.Size(337, 33);
            this.cbbLoaiPhong.TabIndex = 6;
            // 
            // frmXuLyPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(725, 391);
            this.Controls.Add(this.grbContent);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmXuLyPhong";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmXuLyPhong";
            this.Load += new System.EventHandler(this.frmXuLyPhong_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExit)).EndInit();
            this.grbContent.ResumeLayout(false);
            this.grbContent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnlLeft;
        private Panel pnlRight;
        private Panel pnlTop;
        private Label lblTitle;
        private PictureBox ptbMinimize;
        private PictureBox iconApp;
        private PictureBox ptbState;
        private PictureBox ptbExit;
        private Panel pnlBottom;
        private GroupBox grbContent;
        private PictureBox ptbExit2;
        private CheckBox ckbHoatDong;
        private TextBox txtTenPhong;
        private Label label1;
        private ComboBox cbbLoaiPhong;
        private Button btnHuy;
        private Button btnXacNhan;
        private Label label3;
        private Label label2;
    }
}