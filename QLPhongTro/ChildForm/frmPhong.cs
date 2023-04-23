using Npgsql.Internal.TypeHandlers.LTreeHandlers;
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
    public partial class frmPhong : Form
    {
        private Database db;
       
        private int rowIndex = -1; //biến lưu chỉ số phòng của phòng được chọn 
        public frmPhong()
        {
            InitializeComponent();
        }

        


        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            new frmXuLyPhong(null).ShowDialog(); //truyền tham số null vào để xác định trường hợp thêm mới phòng
            LoadDsPhong();
        }

        private void frmPhong_Load(object sender, EventArgs e)
        {
            LoadDsPhong();

            #region gui
            //đặt lại tên cột
            dgvPhong.Columns["tenloaiphong"].HeaderText = "Loại phòng";
            dgvPhong.Columns["tenphong"].HeaderText = "Phòng";
            dgvPhong.Columns["dongia"].HeaderText = "Đơn giá";
            dgvPhong.Columns["trangthai"].HeaderText = "Trạng thái";

            //set kích thước cho các cột
            dgvPhong.Columns["id"].Width = 100;
            dgvPhong.Columns["tenloaiphong"].Width = 200;
            dgvPhong.Columns["dongia"].Width = 200;
            dgvPhong.Columns["trangthai"].Width = 200;

            dgvPhong.Columns["tenphong"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//tự động co giãn cột tenphong

            //set kiểu tiền cho cột
            dgvPhong.Columns["dongia"].DefaultCellStyle.Format = "N0";

            //căn chỉnh vị trí của cột
            dgvPhong.Columns["dongia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;//căn phải cho cột đơn giá
            #endregion



        }

        public void LoadDsPhong()
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

            var dt = db.SelectData("loadDsPhong", lstPra);
            dgvPhong.DataSource = dt;
        }

        private void dgvPhong_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //lấy id phòng được chọn 
            var idPhong = dgvPhong.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            new frmXuLyPhong(idPhong).ShowDialog();//truyền idPhong được chọn qua frmXuLyPhong để xác định trường hợp cập nhật phòng
            LoadDsPhong();
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //lấy id phòng cần xóa trong sự kiện cell click của dgvPhong
            rowIndex = e.RowIndex;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //kiểm tra xem idPhong có phải <0 ?

            if (rowIndex<0)//nếu < 0: chưa có phòng nào được chọn để xóa
            {
                MessageBox.Show("Vui lòng chọn phòng cần xóa", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;//nếu gặp trường hợp chưa có phòng nào được chọn để xóa thì sẽ dừng chương trình
            }
            //nếu không null
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa phòng " + dgvPhong.Rows[rowIndex].Cells["tenphong"].Value + " hay không?", "Xác nhận xóa phòng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                //truyền giá trị id phòng cần xóa từ proc
                var lstPara = new List<CustomParameter>()
                {
                    new CustomParameter()
                    {
                        key = "@idPhong",
                        value = dgvPhong.Rows[rowIndex].Cells["ID"].Value.ToString()
                    }
                };
                var kq = db.ExeCute("deletePhong", lstPara);

                //hiển thị thông báo trong trường hợp xóa thành công
                if(kq == 1)
                {
                    MessageBox.Show("Xóa phòng thành công!", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDsPhong();
                }
                else
                {
                    MessageBox.Show("Xóa phòng không thành công thành công!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

        }
    }
}
