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
    public partial class frmPhongTrong : Form
    {
        private Database db;
        public frmPhongTrong()
        {
            InitializeComponent();
        }

        private void frmPhongTrong_Load(object sender, EventArgs e)
        {
            LoadDsPhongTrong();
            #region gui
            //đặt lại tên cột
            dgvPhongTrong.Columns["tenloaiphong"].HeaderText = "Loại phòng";
            dgvPhongTrong.Columns["tenphong"].HeaderText = "Phòng";
            dgvPhongTrong.Columns["dongia"].HeaderText = "Đơn giá";
            dgvPhongTrong.Columns["trangthai"].HeaderText = "Trạng thái";

            //set kích thước cho các cột
            dgvPhongTrong.Columns["id"].Width = 100;
            dgvPhongTrong.Columns["tenloaiphong"].Width = 200;
            dgvPhongTrong.Columns["dongia"].Width = 200;
            dgvPhongTrong.Columns["trangthai"].Width = 200;

            dgvPhongTrong.Columns["tenphong"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//tự động co giãn cột tenphong

            //set kiểu tiền cho cột
            dgvPhongTrong.Columns["dongia"].DefaultCellStyle.Format = "N0";

            //căn chỉnh vị trí của cột
            dgvPhongTrong.Columns["dongia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;//căn phải cho cột đơn giá
            #endregion
        }

        public void LoadDsPhongTrong()
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

            var dt = db.SelectData("loadDsPhongTrong", lstPra);
            dgvPhongTrong.DataSource = dt;
        }
    }
}
