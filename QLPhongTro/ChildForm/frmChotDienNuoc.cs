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
    public partial class frmChotDienNuoc : Form
    {
        public frmChotDienNuoc(int idHopDong, int CSD_Cu, int CSN_Cu)
        {
            InitializeComponent();
            this.idHopDong = idHopDong;
            this.CSD_Cu = CSD_Cu;
            this.CSN_Cu = CSN_Cu;
        }
        private int idHopDong, CSD_Cu, CSN_Cu;


        private void frmChotDienNuoc_Load(object sender, EventArgs e)
        {
            txtCSD_Cu.Text = string.Format("{0:N0}", CSD_Cu);
            txtCSN_Cu.Text = string.Format("{0:N0}", CSN_Cu);
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            var CSD_Moi = txtCSD_Moi.Text.Trim().Length == 0 ? 0 : int.Parse(txtCSD_Moi.Text);
            var CSN_Moi = txtCSN_Moi.Text.Trim().Length == 0 ? 0 : int.Parse(txtCSN_Moi.Text);

            //ràng buộc dữ liệu chỉ số điện và nước
            if (CSN_Moi < CSN_Cu)
            {
                MessageBox.Show("Chỉ số nước mới không thể bé hơn chỉ số cũ!", "Ràng buộc dữ liệu!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCSN_Moi.Select();
                return;
            }

            if (CSD_Moi < CSD_Cu)
            {
                MessageBox.Show("Chỉ số điện mới không thể bé hơn chỉ số cũ!", "Ràng buộc dữ liệu!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCSD_Moi.Select();
                return;
            }

            var ls = new List<CustomParameter>
            {
                new CustomParameter
                {
                    key = "@Id",
                    value = idHopDong.ToString()
                },
                 new CustomParameter
                {
                    key = "@CSD_Moi",
                    value = CSD_Moi.ToString()
                },
                  new CustomParameter
                {
                    key = "@CSN_Moi",
                    value = CSN_Moi.ToString()
                }
            };

            var db = new Database();
            if (
                db.ExeCute("ChotDienNuoc", ls) == 1
                && MessageBox.Show("Chốt điện nước thành công. Bạn có muốn thanh toán cho hợp đồng này không?", "Xác nhận thanh toán!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes
              )
            {
                this.Dispose();
                new frmThanhToan(idHopDong.ToString()).ShowDialog();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
