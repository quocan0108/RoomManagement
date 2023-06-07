namespace QLPhongTro.ChildForm
{
    partial class frmPhongDangThue
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
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPhongDangThue = new System.Windows.Forms.DataGridView();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongDangThue)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(399, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Phòng đang thuê";
            // 
            // dgvPhongDangThue
            // 
            this.dgvPhongDangThue.AllowUserToAddRows = false;
            this.dgvPhongDangThue.AllowUserToDeleteRows = false;
            this.dgvPhongDangThue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhongDangThue.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhongDangThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongDangThue.GridColor = System.Drawing.Color.Gray;
            this.dgvPhongDangThue.Location = new System.Drawing.Point(1, 121);
            this.dgvPhongDangThue.MultiSelect = false;
            this.dgvPhongDangThue.Name = "dgvPhongDangThue";
            this.dgvPhongDangThue.ReadOnly = true;
            this.dgvPhongDangThue.RowHeadersWidth = 62;
            this.dgvPhongDangThue.RowTemplate.Height = 33;
            this.dgvPhongDangThue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhongDangThue.Size = new System.Drawing.Size(977, 340);
            this.dgvPhongDangThue.TabIndex = 14;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTimKiem.Location = new System.Drawing.Point(296, 70);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(214, 29);
            this.txtTimKiem.TabIndex = 16;
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.SlateGray;
            this.btnTim.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Location = new System.Drawing.Point(528, 67);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(111, 33);
            this.btnTim.TabIndex = 17;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            // 
            // frmPhongDangThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(979, 463);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPhongDangThue);
            this.Name = "frmPhongDangThue";
            this.Text = "frmPhongDangThue";
            this.Load += new System.EventHandler(this.frmPhongDangThue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongDangThue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private DataGridView dgvPhongDangThue;
        private TextBox txtTimKiem;
        private Button btnTim;
    }
}