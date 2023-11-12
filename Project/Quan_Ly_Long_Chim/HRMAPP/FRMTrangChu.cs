using BirdManageShop;
using BusinessObject.Models;

namespace HRMAPP
{
    public partial class FRMTrangChu : Form
    {
        staff account;
        public FRMTrangChu(staff account)
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.account = account;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            this.Show();
        }

        private void chấtLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (account.Role.ToLower().Equals("staff"))
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FRMDanhMucChatLieu frmChatLieu = new FRMDanhMucChatLieu();
            frmChatLieu.MdiParent = this;
            frmChatLieu.Show();
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (account.Role.ToLower().Equals("staff"))
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FRMDanhMucHangHoa frmHangHoa = new FRMDanhMucHangHoa();
            frmHangHoa.MdiParent = this;
            frmHangHoa.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (account.Role.ToLower().Equals("staff"))
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FRMDanhMucNhanVien frmNhanVien = new FRMDanhMucNhanVien();
            frmNhanVien.MdiParent = this;
            frmNhanVien.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMDanhMucKhachHang frmKhachHang = new FRMDanhMucKhachHang();
            frmKhachHang.MdiParent = this;
            frmKhachHang.Show();
        }

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMHoaDonBanHang frmHoaDon = new FRMHoaDonBanHang();
            frmHoaDon.MdiParent = this;
            frmHoaDon.Show();
        }

        private void tìmKiếmHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMDanhMucTimKiemHoaDon frmTimKiemHoaDon = new FRMDanhMucTimKiemHoaDon();
            frmTimKiemHoaDon.MdiParent = this;
            frmTimKiemHoaDon.Show();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (account.Role.ToLower().Equals("staff"))
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FRMThongKe fRMThongKe = new FRMThongKe();
            fRMThongKe.MdiParent = this;
            fRMThongKe.Show();
        }
    }
}