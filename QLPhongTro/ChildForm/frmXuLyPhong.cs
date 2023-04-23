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
    public partial class frmXuLyPhong : Form
    {
        private string idPhong; 
        private Database db;
        public frmXuLyPhong(string idPhong) 
        {
            this.idPhong = idPhong;
            InitializeComponent();
        }

        private void frmXuLyPhong_Load(object sender, EventArgs e)
        {
            db = new Database();
            LoadLoaiPhong(); 
            if (string.IsNullOrEmpty(idPhong))//nếu idphong được truyền qua là null = trường hợp thêm mới
            {
                lblTitle.Text = "Thêm phòng mới";
            }
            else//nếu idphong khác null = trường hợp cập nhật
            {
                lblTitle.Text = "Cập nhật thông tin phòng";

                //phòng được xác định qua id nên cần truyền tham số là giá trị của id phòng
                var lstPara = new List<CustomParameter>()
                {
                    new CustomParameter()
                    {
                        key = "@idPhong",
                        value = idPhong
                    }
                };
                var phong = db.SelectData("[selectPhong]", lstPara).Rows[0];//sử dụng hàm selectdata trong class database để lấy dữ liệu phòng
                //kết quả trả về là 1 datatable chỉ gồm 1 hàng chính là hàng có chỉ số hằng bằng 0
                //set các dữ liệu lấy được cho các component trên frmXuLyPhong
                cbbLoaiPhong.SelectedValue = phong["IDLoaiPhong"].ToString();//set idloaiphong cho ccbLoaiPhong
                txtTenPhong.Text = phong["TenPhong"].ToString();//set giá trị tên phòng cho txtTenPhong
                if (phong["trangthai"].ToString() == "1") //set trạng thái hoạt động cho ckbHoatDong
                {
                    ckbHoatDong.Checked = true;
                }
                else
                {
                    ckbHoatDong.Checked = false;
                }
            }
        }
        
        private void LoadLoaiPhong()
        {
            
            var dt = db.SelectData("loadDsLoaiPhong");
            cbbLoaiPhong.DataSource= dt;
            cbbLoaiPhong.DisplayMember = "TenLoaiPhong";
            cbbLoaiPhong.ValueMember= "ID";
        }
         
        private void ptbExit2_Click(object sender, EventArgs e)
        {
            this.Dispose(); //đóng form 
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            //ràng buộc dữ liệu
            if(cbbLoaiPhong.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn loại phòng", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var idLoaiPhong = cbbLoaiPhong.SelectedValue.ToString();
            var tenPhong = txtTenPhong.Text.Trim();
            var trangThai = ckbHoatDong.Checked?1:0; 

            if (string.IsNullOrEmpty(tenPhong))
            {
                MessageBox.Show("Vui lòng nhập tên phòng", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenPhong.Select();
                return;  
            }
            if (string.IsNullOrEmpty(tenPhong)) //trường hợp thêm mới phòng khôn có idphong <=> null    
            {
                var lstPra = new List<CustomParameter>()
                {
                    new CustomParameter()
                    {
                        key = "@idLoaiPhong",
                        value = idLoaiPhong
                    },
                    new CustomParameter()
                    {
                        key = "@tenPhong",
                        value = tenPhong

                    },
                    new CustomParameter()
                    {
                        key = "@trangThai",
                        value = trangThai.ToString()
                    }
                };

                var rs = db.ExeCute("[themMoiPhong]", lstPra);
                if(rs == 1)
                {
                    MessageBox.Show("Thêm mới phòng thành công!", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //reset lại các giá trị của component sau khi thêm thành công
                    txtTenPhong.Text = null;
                    cbbLoaiPhong.SelectedIndex = 0;
                }
            }
            else //trường hợp cập nhật phòng đã tồn tại <=> idPhong có giá trị # null 
            {
                //xử lý trường hợp cập nhật khi click vào btnXacNhan
                var lstPara = new List<CustomParameter>()
                {
                    new CustomParameter()
                    {
                        key = "@idPhong",
                        value = idPhong
                    },
                    new CustomParameter()
                    {
                        key = "@tenPhong",
                        value = txtTenPhong.Text
                    },
                    new CustomParameter()
                    {
                        key = "@idLoaiPhong",
                        value = cbbLoaiPhong.SelectedValue.ToString()
                    },
                    new CustomParameter()
                    {
                        key = "@trangThai",
                        value = trangThai.ToString()
                    }
                };
                var kq = db.ExeCute("updatePhong", lstPara);
                if(kq == 1)
                {
                    MessageBox.Show("Cập nhật thông tin phòng thành công", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);//hiện thông báo thành công         
                    this.Dispose();//đóng frmXuLyPhong
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin phòng không thành công", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Information);//hiện thông báo không thành công
                    this.Dispose();
                }
                
            }
        }
    }
}
