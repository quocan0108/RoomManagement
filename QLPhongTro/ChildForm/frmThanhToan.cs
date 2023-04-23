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
    public partial class frmThanhToan : Form
    {
        private string IDThuePhong;
        private Database db;
        public frmThanhToan(string IDThuePhong)
        {
            this.IDThuePhong = IDThuePhong;
            db = new Database();
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        DataRow dr;
        private void LoadHopDongThuePhong()
        {
            List<CustomParameter> lst = new List<CustomParameter> {
                new CustomParameter
                {
                    key = "@idHopDong",
                    value = IDThuePhong
                }
            };

            dr = db.SelectData("LoadHopDong", lst).Rows[0];
            lblPhong.Text = dr["TenPhong"].ToString();
            lblTienPhong.Text = string.Format("{0:N0} VNĐ", int.Parse(dr["GiaPhong"].ToString()));
            lblTienDien.Text = string.Format("{0:N0} VNĐ", int.Parse(dr["TienDien"].ToString()));
            lblTienNuoc.Text = string.Format("{0:N0} VNĐ", int.Parse(dr["TienNuoc"].ToString()));
            lblTienVeSinh.Text = string.Format("{0:N0} VNĐ", int.Parse(dr["TienVeSinh"].ToString()));
            lblTienMang.Text = string.Format("{0:N0} VNĐ", int.Parse(dr["TienMang"].ToString()));
            lblTongTienThang.Text = string.Format("{0:N0} VNĐ", int.Parse(dr["TongTienCuaThang"].ToString()));
            lblSoDuNo.Text = string.Format("{0:N0} VNĐ", dr["SoNoConThieu"].ToString().Length == 0 ? 0 : int.Parse(dr["SoNoConThieu"].ToString()));
            lblTongTienCanThanhToan.Text = string.Format("{0:N0} VNĐ", dr["TongTienPhaiTra"].ToString().Length == 0 ? int.Parse(dr["TongTienCuaThang"].ToString()) : int.Parse(dr["TongTienPhaiTra"].ToString()));
            lblConLai.Text = string.Format("{0:N0} VNĐ", dr["TongTienPhaiTra"].ToString().Length == 0 ? int.Parse(dr["TongTienCuaThang"].ToString()) : int.Parse(dr["TongTienPhaiTra"].ToString()));
        }

        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            LoadHopDongThuePhong();
        }

        private void txtThanhToan_KeyUp(object sender, KeyEventArgs e)
        {
            var ctt = lblTongTienCanThanhToan.Text;
            var soNo = int.Parse(ctt.Split(' ')[0].Replace(",", ""));

            lblConLai.Text = string.Format("{0:N0} VNĐ", soNo - int.Parse(txtThanhToan.Text.Trim().Length == 0 ? "0" : txtThanhToan.Text));
        }

        private void txtThanhToan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThanhToanGiaHan_Click(object sender, EventArgs e)
        {
            if (txtThanhToan.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập số tiền cần thanh toán!");
                return;
            }

            List<CustomParameter> lst = new List<CustomParameter>
            {
                new CustomParameter
                {
                    key = "@Id",
                    value = IDThuePhong
                },
                 new CustomParameter
                 {
                     key = "@SoTien",
                     value = txtThanhToan.Text
                 }
            };

            var kq = db.ExeCute("[ThanhToanGiaHan]", lst);
            if (kq >= 1)
            {
                MessageBox.Show("Thanh toán thành công!", "SUCCESSFULLY!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Thanh toán thất bại!", "SUCCESSFULLY!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
