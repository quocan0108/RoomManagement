using Sitecore.FakeDb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPhongTro.ChildForm
{
    public partial class frmDichVu : Form
    {
        private Database db;
        public frmDichVu()
        {
            db = new Database();
            InitializeComponent();
        }

        private void frmDichVu_Load(object sender, EventArgs e)
        {
            LoadDSDV();

            dgvDV.Columns[1].HeaderText = "Tên dịch vụ";
            dgvDV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void LoadDSDV()
        {
            
            var timKiem = txtTimKiem.Text.Trim();
            var lstPra = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@timKiem",
                    value = timKiem
                }
            };

            var dt = db.SelectData("LoadDSDV", lstPra);
            dgvDV.DataSource = dt;
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            LoadDSDV();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if(txtTenDichVu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên dịch vụ", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var lstPara = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@tenDV",
                    value = txtTenDichVu.Text
                   
                }
            };
            if(db.ExeCute("ThemDV", lstPara) == 1)
            {
                MessageBox.Show("Thêm mới dịch vụ thành công!");
                LoadDSDV();
                txtTenDichVu.Text = null;
            }
        }


        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(id < 0)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cập nhật!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtTenDichVu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên dịch vụ", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var lstPara = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@id",
                    value = id.ToString()

                },
                new CustomParameter()
                {
                    key = "@tenDV",
                    value = txtTenDichVu.Text

                }
            };
            if (db.ExeCute("CapNhatDV", lstPara) == 1)
            {
                MessageBox.Show("Cập nhật dịch vụ thành công!", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDSDV();
                txtTenDichVu.Text = null;
                id = -1;
            }

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (id < 0)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ muốn xóa!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(MessageBox.Show("Bạn có chắc chắn xóa dịch vụ này không?", "Xác nhận!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var lstPara = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@id",
                    value = id.ToString()

                }
            };
                if (db.ExeCute("XoaDV", lstPara) == 1)
                {
                    MessageBox.Show("Xóa dịch vụ thành công!", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDSDV();
                    txtTenDichVu.Text = null;
                    id = -1;
                }
            }
        }

        int id = -1;
        private void dgvDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                id = int.Parse(dgvDV.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtTenDichVu.Text = dgvDV.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }
    }
}
