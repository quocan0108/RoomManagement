using Sitecore.FakeDb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPhongTro.ChildForm
{
    
    public partial class frmPhongDangThue : Form
    {
        private Database db;
        public frmPhongDangThue()
        {
            InitializeComponent();
        }

        private void frmPhongDangThue_Load(object sender, EventArgs e)
        {
            LoadDsPhongDangThue();
            #region gui
            //đặt lại tên cột
            dgvPhongDangThue.Columns["tenloaiphong"].HeaderText = "Loại phòng";
            dgvPhongDangThue.Columns["tenphong"].HeaderText = "Phòng";
            dgvPhongDangThue.Columns["dongia"].HeaderText = "Đơn giá";
            dgvPhongDangThue.Columns["trangthai"].HeaderText = "Trạng thái";

            //set kích thước cho các cột
            dgvPhongDangThue.Columns["id"].Width = 100;
            dgvPhongDangThue.Columns["tenloaiphong"].Width = 200;
            dgvPhongDangThue.Columns["dongia"].Width = 200;
            dgvPhongDangThue.Columns["trangthai"].Width = 200;

            dgvPhongDangThue.Columns["tenphong"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//tự động co giãn cột tenphong

            //set kiểu tiền cho cột
            dgvPhongDangThue.Columns["dongia"].DefaultCellStyle.Format = "N0";

            //căn chỉnh vị trí của cột
            dgvPhongDangThue.Columns["dongia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;//căn phải cho cột đơn giá
            #endregion
        }

        public void LoadDsPhongDangThue()
        {
            db = new Database();
            var timKiem = txtTimKiem.Text.Trim();
            var lstPra = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@timKiem",
                    value = timKiem
                }
            };

            var dt = db.SelectData("loadDsPhongDangThue", lstPra);
            dgvPhongDangThue.DataSource = dt;
        }
    }
}
