using QLPhongTro.ChildForm;
using QLPhongTro.Properties;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace QLPhongTro
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        #region GUI

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void ptbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ptbState_Click(object sender, EventArgs e)
        {
            if(this.WindowState== FormWindowState.Normal)
            {
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea; //maximize không dính taskbar
                this.WindowState = FormWindowState.Maximized;
                ptbState.Image = Properties.Resources.res;
            } else
            {
                this.WindowState = FormWindowState.Normal;
                ptbState.Image = Properties.Resources.maxi;
            }
        }

        private void ptbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //kéo di chuyển form ở top
        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
        }

        //kéo thanh label ở top - bug
        private void label1_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion

        //hàm add form lên groupbox grbContent
        private void AddForm(Form f)
        {
            this.grbContent.Controls.Clear();//xóa các control hiện có trên groupbox
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;//bỏ viền của form
            f.Dock = DockStyle.Fill;
            this.Text = f.Text;
            this.grbContent.Controls.Add(f);
            f.Show();
        }

        //add childforms vào formMain
        private void formMain_Load(object sender, EventArgs e)
        {
            var f = new frmWelcome();
            AddForm(f);
        }

        private void loạiPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmLoaiPhong();
            AddForm(f);
        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmPhong();
            AddForm(f);
        }

        private void dịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmDichVu();
            AddForm(f);
        }

        private void thuêPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmThuePhong();
            AddForm(f);
        }

        #region khóa màn hình
        [DllImport("user32.dll")]
        public static extern void LockWorkStation();
        private void LockScreen()
        {
            LockWorkStation();
        }
        private void khóaMànHìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LockScreen();
        }

        #endregion

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void phiênBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phiên bản 1.0.", "Room Management", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void bảnQuyềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bản quyền thuộc sở hữu của Lê Quốc Ân, Nguyễn Quang Sáng, Nguyễn Văn Thắng.", "Room Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void liênHệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmLienHe();
            AddForm(f);
        }

        private void phòngĐangThuêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmPhongDangThue();
            AddForm(f);
        }

        private void phòngTrốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmPhongTrong();
            AddForm(f);
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmWelcome();
            AddForm(f);
        }

        private void trảPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmTraPhong();
            AddForm(f);
        }
    }
}