using BirdManageShop;

namespace HRMAPP
{
    public partial class FRMTrangChu : Form
    {
        public FRMTrangChu()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            this.Show();
        }

        private void chấtLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FRMDanhMucChatLieu frmChatLieu = new FRMDanhMucChatLieu();
            frmChatLieu.MdiParent = this;
            frmChatLieu.Show();
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMDanhMucHangHoa frmHangHoa = new FRMDanhMucHangHoa();
            frmHangHoa.MdiParent = this;
            frmHangHoa.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
            FRMThongKe fRMThongKe = new FRMThongKe();
            fRMThongKe.MdiParent = this;
            fRMThongKe.Show();
        }
    }
}