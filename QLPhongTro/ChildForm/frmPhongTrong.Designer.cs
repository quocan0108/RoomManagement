namespace QLPhongTro.ChildForm
{
    partial class frmPhongTrong
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
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPhongTrong = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongTrong)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.SlateGray;
            this.btnTim.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Location = new System.Drawing.Point(528, 67);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(111, 33);
            this.btnTim.TabIndex = 21;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTimKiem.Location = new System.Drawing.Point(296, 70);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(214, 29);
            this.txtTimKiem.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(399, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Phòng còn trống";
            // 
            // dgvPhongTrong
            // 
            this.dgvPhongTrong.AllowUserToAddRows = false;
            this.dgvPhongTrong.AllowUserToDeleteRows = false;
            this.dgvPhongTrong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhongTrong.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhongTrong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongTrong.GridColor = System.Drawing.Color.Gray;
            this.dgvPhongTrong.Location = new System.Drawing.Point(1, 122);
            this.dgvPhongTrong.MultiSelect = false;
            this.dgvPhongTrong.Name = "dgvPhongTrong";
            this.dgvPhongTrong.ReadOnly = true;
            this.dgvPhongTrong.RowHeadersWidth = 62;
            this.dgvPhongTrong.RowTemplate.Height = 33;
            this.dgvPhongTrong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhongTrong.Size = new System.Drawing.Size(977, 340);
            this.dgvPhongTrong.TabIndex = 18;
            // 
            // frmPhongTrong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(979, 463);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPhongTrong);
            this.Name = "frmPhongTrong";
            this.Text = "frmPhongTrong";
            this.Load += new System.EventHandler(this.frmPhongTrong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongTrong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnTim;
        private TextBox txtTimKiem;
        private Label label2;
        private DataGridView dgvPhongTrong;
    }
}