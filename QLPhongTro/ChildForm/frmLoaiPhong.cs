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
    public partial class frmLoaiPhong : Form
    {
        public frmLoaiPhong()
        {
            InitializeComponent();
        }

        private Database db;
        private int xacNhan = 0;

        private int maLoaiPhong = 0;

/*        private bool KiemTraLoaiPhongTonTai(string tenLoaiPhong)
        {
            var prList = new List<CustomParameter>();
            prList.Add(new CustomParameter
            {
                key = "@tenLoaiPhong",
                value = tenLoaiPhong
            });
            var count = db.ExeCute("kiemTraLoaiPhongTonTai", prList);
            return count > 0;
        }*/

        private void btnThem_Click(object sender, EventArgs e)
        {
            xacNhan = 1;
            txtDonGia.ReadOnly = false;
            txtTenLoaiPhong.ReadOnly = false;

            txtDonGia.Text = null;
            txtTenLoaiPhong.Text = null;

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void LoadDsLoaiPhong()
        {
            var db = new Database();
            dgvDSLoaiPhong.DataSource = db.SelectData("loadDsLoaiPhong");
        }

        private void frmLoaiPhong_Load(object sender, EventArgs e)
        {

            txtDonGia.ReadOnly = true;
            txtTenLoaiPhong.ReadOnly = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnLuu.Enabled = false;

            db = new Database();
            LoadDsLoaiPhong();
                
            dgvDSLoaiPhong.Columns[0].Width = 100;//set bề rộng cho cột id loại phòng
            dgvDSLoaiPhong.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDSLoaiPhong.Columns[0].HeaderText = "Mã loại";

            dgvDSLoaiPhong.Columns[2].Width = 200;
            dgvDSLoaiPhong.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDSLoaiPhong.Columns[2].DefaultCellStyle.Format = "N0";
            dgvDSLoaiPhong.Columns[2].HeaderText = "Đơn giá";

            dgvDSLoaiPhong.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDSLoaiPhong.Columns[1].HeaderText = "Tên loại phòng";



        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
           if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //kiểm tra nhập vào khác kí tự điều khiển và khác chữ số
            {
                e.Handled = true;
            }
        }

        private void dgvDSLoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                maLoaiPhong = int.Parse(dgvDSLoaiPhong.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtTenLoaiPhong.Text = dgvDSLoaiPhong.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDonGia.Text = dgvDSLoaiPhong.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xacNhan = -1;
            txtDonGia.ReadOnly = false;
            txtTenLoaiPhong.ReadOnly = false;

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            xacNhan = 0;
            txtDonGia.ReadOnly = true;
            txtTenLoaiPhong.ReadOnly = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var tenLoaiPhong = txtTenLoaiPhong.Text.Trim();
            var donGia = int.Parse(txtDonGia.Text);
             
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnLuu.Enabled = false;

            //ràng buộc dữ liệu
            /*
                        if (maLoaiPhong == 0)
                        {
                            MessageBox.Show("Vui lòng chọn phòng cần cập nhật", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;//dừng chương trình ngang đây
                        }*/

            if (string.IsNullOrEmpty(tenLoaiPhong))
            {
                MessageBox.Show("Vui lòng nhập tên loại phòng", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;//dừng chương trình ngang đây
            }

            if (donGia < 50000)
            {
                MessageBox.Show("Đơn giá tối thiểu phải là 50.000", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;//dừng chương trình ngang đây
            }

            var prList = new List<CustomParameter>();

            if (xacNhan == 1) //trường hợp thêm mới loại phòng 
            {
                prList.Add(new CustomParameter
                {
                    key = "@tenLoaiPhong",
                    value = tenLoaiPhong
                });
                prList.Add(new CustomParameter
                {
                    key = "@donGia",
                    value = donGia.ToString()
                });

                var rs = db.ExeCute("[themLoaiPhong]", prList);
                if (rs == 1)
                {
                    MessageBox.Show("Thêm loại phòng thành công!", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if(xacNhan == -1)//trường hợp cập nhật loại phòng 
            {
                prList.Add(new CustomParameter()
                {
                    key = "@idLoaiPhong",
                    value = maLoaiPhong.ToString()
                });

                prList.Add(new CustomParameter
                {
                    key = "@tenLoaiPhong",
                    value = tenLoaiPhong
                });
                prList.Add(new CustomParameter
                {
                    key = "@donGia",
                    value = donGia.ToString()
                });

                var rs = db.ExeCute("[capNhatLoaiPhong]", prList);
                if (rs == 1)
                {
                    MessageBox.Show("Cập nhật loại phòng thành công!", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else if (xacNhan == 0) //trường hợp xóa loại phòng 
            {
                if (maLoaiPhong == 0)
                {
                    MessageBox.Show("Vui lòng chọn loại phòng cần xóa", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Bạn có chắc muốn xóa loại phòng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {
                    var lstPara = new List<CustomParameter>()
                {
                    new CustomParameter()
                    {
                        key = "@idLoaiPhong",
                        value = maLoaiPhong.ToString()
                    }
                };
                    var rs = db.ExeCute("xoaLoaiPhong", lstPara);

                    if (rs == 1)
                    {
                        MessageBox.Show("Xóa loại phòng thành công!", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        maLoaiPhong = 0; //reset mã loại phòng(id) về giá trị mặc định
                    }
                }
            }
            LoadDsLoaiPhong();
            txtDonGia.Text = "0";
            txtTenLoaiPhong.Text = null;
            maLoaiPhong = 0;
            txtDonGia.ReadOnly = true;
            txtTenLoaiPhong.ReadOnly = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnLuu.Enabled = false;
        }


    }
}
