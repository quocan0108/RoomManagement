namespace QLPhongTro.ChildForm
{
    partial class frmThuePhong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvThuePhong = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatCoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienVeSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienMang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaDien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSD_Cu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaNuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSN_Cu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuePhong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý khách thuê phòng";
            // 
            // dgvThuePhong
            // 
            this.dgvThuePhong.AllowUserToAddRows = false;
            this.dgvThuePhong.AllowUserToDeleteRows = false;
            this.dgvThuePhong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThuePhong.BackgroundColor = System.Drawing.Color.White;
            this.dgvThuePhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuePhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnThanhToan,
            this.TenPhong,
            this.GiaPhong,
            this.DatCoc,
            this.NgayBatDau,
            this.NgayKetThuc,
            this.TienVeSinh,
            this.TienMang,
            this.DonGiaDien,
            this.CSD_Cu,
            this.DonGiaNuoc,
            this.CSN_Cu,
            this.no,
            this.ID});
            this.dgvThuePhong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvThuePhong.Location = new System.Drawing.Point(-61, 219);
            this.dgvThuePhong.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dgvThuePhong.MultiSelect = false;
            this.dgvThuePhong.Name = "dgvThuePhong";
            this.dgvThuePhong.ReadOnly = true;
            this.dgvThuePhong.RowHeadersWidth = 62;
            this.dgvThuePhong.Size = new System.Drawing.Size(1985, 501);
            this.dgvThuePhong.TabIndex = 2;
            this.dgvThuePhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThuePhong_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(570, 148);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 44);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Thuê mới";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTuKhoa.Location = new System.Drawing.Point(124, 152);
            this.txtTuKhoa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(297, 26);
            this.txtTuKhoa.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tìm kiếm";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(436, 148);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(124, 44);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Frozen = true;
            this.btnThanhToan.HeaderText = "";
            this.btnThanhToan.MinimumWidth = 8;
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.ReadOnly = true;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseColumnTextForButtonValue = true;
            this.btnThanhToan.Width = 150;
            // 
            // TenPhong
            // 
            this.TenPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TenPhong.DataPropertyName = "TenPhong";
            this.TenPhong.HeaderText = "Tên phòng";
            this.TenPhong.MinimumWidth = 8;
            this.TenPhong.Name = "TenPhong";
            this.TenPhong.ReadOnly = true;
            this.TenPhong.Width = 300;
            // 
            // GiaPhong
            // 
            this.GiaPhong.DataPropertyName = "GiaPhong";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.GiaPhong.DefaultCellStyle = dataGridViewCellStyle1;
            this.GiaPhong.HeaderText = "Giá phòng";
            this.GiaPhong.MinimumWidth = 8;
            this.GiaPhong.Name = "GiaPhong";
            this.GiaPhong.ReadOnly = true;
            this.GiaPhong.Width = 150;
            // 
            // DatCoc
            // 
            this.DatCoc.DataPropertyName = "DatCoc";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.DatCoc.DefaultCellStyle = dataGridViewCellStyle2;
            this.DatCoc.HeaderText = "Đặt cọc";
            this.DatCoc.MinimumWidth = 8;
            this.DatCoc.Name = "DatCoc";
            this.DatCoc.ReadOnly = true;
            this.DatCoc.Width = 150;
            // 
            // NgayBatDau
            // 
            this.NgayBatDau.DataPropertyName = "NgayBatDau";
            this.NgayBatDau.HeaderText = "Ngày thuê";
            this.NgayBatDau.MinimumWidth = 8;
            this.NgayBatDau.Name = "NgayBatDau";
            this.NgayBatDau.ReadOnly = true;
            this.NgayBatDau.Width = 150;
            // 
            // NgayKetThuc
            // 
            this.NgayKetThuc.DataPropertyName = "NgayKetThuc";
            this.NgayKetThuc.HeaderText = "Ngày trả";
            this.NgayKetThuc.MinimumWidth = 8;
            this.NgayKetThuc.Name = "NgayKetThuc";
            this.NgayKetThuc.ReadOnly = true;
            this.NgayKetThuc.Width = 150;
            // 
            // TienVeSinh
            // 
            this.TienVeSinh.DataPropertyName = "TienVeSinh";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = "0";
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.TienVeSinh.DefaultCellStyle = dataGridViewCellStyle3;
            this.TienVeSinh.HeaderText = "Tiền vệ sinh";
            this.TienVeSinh.MinimumWidth = 8;
            this.TienVeSinh.Name = "TienVeSinh";
            this.TienVeSinh.ReadOnly = true;
            this.TienVeSinh.Width = 150;
            // 
            // TienMang
            // 
            this.TienMang.DataPropertyName = "TienMang";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = "0";
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.TienMang.DefaultCellStyle = dataGridViewCellStyle4;
            this.TienMang.HeaderText = "Tiền mạng";
            this.TienMang.MinimumWidth = 8;
            this.TienMang.Name = "TienMang";
            this.TienMang.ReadOnly = true;
            this.TienMang.Width = 150;
            // 
            // DonGiaDien
            // 
            this.DonGiaDien.DataPropertyName = "DonGiaDien";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = "0";
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.DonGiaDien.DefaultCellStyle = dataGridViewCellStyle5;
            this.DonGiaDien.HeaderText = "Đơn giá điện";
            this.DonGiaDien.MinimumWidth = 8;
            this.DonGiaDien.Name = "DonGiaDien";
            this.DonGiaDien.ReadOnly = true;
            this.DonGiaDien.Width = 150;
            // 
            // CSD_Cu
            // 
            this.CSD_Cu.DataPropertyName = "CSD_Cu";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = "0";
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.CSD_Cu.DefaultCellStyle = dataGridViewCellStyle6;
            this.CSD_Cu.HeaderText = "CSĐ cũ";
            this.CSD_Cu.MinimumWidth = 8;
            this.CSD_Cu.Name = "CSD_Cu";
            this.CSD_Cu.ReadOnly = true;
            this.CSD_Cu.Width = 150;
            // 
            // DonGiaNuoc
            // 
            this.DonGiaNuoc.DataPropertyName = "DonGiaNuoc";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.NullValue = "0";
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.DonGiaNuoc.DefaultCellStyle = dataGridViewCellStyle7;
            this.DonGiaNuoc.HeaderText = "Đơn giá nước";
            this.DonGiaNuoc.MinimumWidth = 8;
            this.DonGiaNuoc.Name = "DonGiaNuoc";
            this.DonGiaNuoc.ReadOnly = true;
            this.DonGiaNuoc.Width = 150;
            // 
            // CSN_Cu
            // 
            this.CSN_Cu.DataPropertyName = "CSN_Cu";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N0";
            dataGridViewCellStyle8.NullValue = "0";
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.CSN_Cu.DefaultCellStyle = dataGridViewCellStyle8;
            this.CSN_Cu.HeaderText = "Số nước cũ";
            this.CSN_Cu.MinimumWidth = 8;
            this.CSN_Cu.Name = "CSN_Cu";
            this.CSN_Cu.ReadOnly = true;
            this.CSN_Cu.Width = 150;
            // 
            // no
            // 
            this.no.DataPropertyName = "no";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle9.Format = "N0";
            dataGridViewCellStyle9.NullValue = "0";
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.no.DefaultCellStyle = dataGridViewCellStyle9;
            this.no.HeaderText = "Dư nợ";
            this.no.MinimumWidth = 8;
            this.no.Name = "no";
            this.no.ReadOnly = true;
            this.no.Width = 150;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 150;
            // 
            // frmThuePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1924, 721);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvThuePhong);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmThuePhong";
            this.Text = "frmThuePhong";
            this.Load += new System.EventHandler(this.frmThuePhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuePhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvThuePhong;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private DataGridViewButtonColumn btnThanhToan;
        private DataGridViewTextBoxColumn TenPhong;
        private DataGridViewTextBoxColumn GiaPhong;
        private DataGridViewTextBoxColumn DatCoc;
        private DataGridViewTextBoxColumn NgayBatDau;
        private DataGridViewTextBoxColumn NgayKetThuc;
        private DataGridViewTextBoxColumn TienVeSinh;
        private DataGridViewTextBoxColumn TienMang;
        private DataGridViewTextBoxColumn DonGiaDien;
        private DataGridViewTextBoxColumn CSD_Cu;
        private DataGridViewTextBoxColumn DonGiaNuoc;
        private DataGridViewTextBoxColumn CSN_Cu;
        private DataGridViewTextBoxColumn no;
        private DataGridViewTextBoxColumn ID;
    }
}