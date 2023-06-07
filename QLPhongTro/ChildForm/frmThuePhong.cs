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
    public partial class frmThuePhong : Form
    {
        private Database db;
        public frmThuePhong()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new frmThue().ShowDialog();
            LoadDSThuePhong();
        }

        private void frmThuePhong_Load(object sender, EventArgs e)
        {
            db = new Database();
            LoadDSThuePhong();           

        }

        private void LoadDSThuePhong()
        {
            List<CustomParameter> lst = new List<CustomParameter>
            {
                new CustomParameter
                {
                    key = "@tuKhoa",
                    value = txtTuKhoa.Text
                }
            };
            dgvThuePhong.AutoGenerateColumns = false;
            var rs = db.SelectData("[LoadDSHopDong]", lst);
            dgvThuePhong.DataSource = db.SelectData("[LoadDSHopDong]", lst);

           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadDSThuePhong();
        }

        private void dgvThuePhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvThuePhong.Columns["btnThanhToan"].Index)
                {
                    var IDHopDong = int.Parse(dgvThuePhong.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                    var CSD_Cu = int.Parse(dgvThuePhong.Rows[e.RowIndex].Cells["CSD_Cu"].Value.ToString());
                    var CSN_Cu = int.Parse(dgvThuePhong.Rows[e.RowIndex].Cells["CSN_Cu"].Value.ToString());
                 
                    new frmChotDienNuoc(IDHopDong,CSD_Cu,CSN_Cu).ShowDialog();
                    LoadDSThuePhong();
                }                

            }
        }
    }
}
