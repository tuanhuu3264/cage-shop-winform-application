using BusinessObject.Models;
using HRMDAO;
using HRMService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMAPP
{
    public partial class FRMDanhMucChatLieu : Form
    {
        private ITypeProductServices typeProductService;
        public FRMDanhMucChatLieu()
        {
            InitializeComponent();
            typeProductService = new TypeProductServices();
        }

        private void FRMDanhMucChatLieu_Load(object sender, EventArgs e)
        {
            txt_maChatLieu.Enabled = false;
            btn_luuChatLieu.Enabled = false;
            btn_suaChatLieu.Enabled = false;
            btn_xoaChatLieu.Enabled = false;
            btn_boQua.Enabled = false;
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            BindingSource source = new BindingSource();
            source.DataSource = typeProductService.listTypeProduct();
            dgv_chatLieu.DataSource = null;
            dgv_chatLieu.DataSource = source;
            dgv_chatLieu.Columns[0].HeaderText = "Mã chất liệu";
            dgv_chatLieu.Columns[1].HeaderText = "Tên chất liệu";
            dgv_chatLieu.Columns[0].Width = 100;
            dgv_chatLieu.Columns[1].Width = 300;
            dgv_chatLieu.AllowUserToAddRows = false;
            dgv_chatLieu.EditMode = DataGridViewEditMode.EditProgrammatically;

        }
        private void ResetValue()
        {
            txt_maChatLieu.Text = "";
            txt_tenChatLieu.Text = "";
        }
        private void btn_themChatLieu_Click(object sender, EventArgs e)
        {
            btn_suaChatLieu.Enabled = false;
            btn_themChatLieu.Enabled = false;
            btn_xoaChatLieu.Enabled = false;
            btn_boQua.Enabled = true;
            btn_luuChatLieu.Enabled = true;
            ResetValue();
            txt_maChatLieu.Enabled = true;
            txt_maChatLieu.Focus();
        }
        private void btn_suaChatLieu_Click(object sender, EventArgs e)
        {
            if (dgv_chatLieu.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_maChatLieu.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_tenChatLieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            TypeProduct tp = new TypeProduct();
            tp.Id = txt_maChatLieu.Text;
            tp.Name = txt_tenChatLieu.Text;
            typeProductService.updateTypeProduct(tp);
            LoadDataGridView();
            ResetValue();
            btn_boQua.Enabled = false;
            btn_suaChatLieu.Enabled = false;
            btn_xoaChatLieu.Enabled = false;
        }

        private void btn_luuChatLieu_Click(object sender, EventArgs e)
        {
            if (txt_maChatLieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần phải nhập mã chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_maChatLieu.Focus();
                return;
            }
            if (txt_tenChatLieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần phải nhập tên chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tenChatLieu.Focus();
                return;
            }
            if (typeProductService.listTypeProduct().Where(t => t.Id == txt_maChatLieu.Text).FirstOrDefault() != null)
            {
                MessageBox.Show("Mã chất liệu này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_maChatLieu.Focus();
                return;
            }
            TypeProduct tp = new TypeProduct();
            tp.Id = txt_maChatLieu.Text;
            tp.Name = txt_tenChatLieu.Text;
            typeProductService.insertTypeProduct(tp);
            LoadDataGridView();
            ResetValue();
            btn_themChatLieu.Enabled = true;
            btn_suaChatLieu.Enabled = false;
            btn_xoaChatLieu.Enabled = false;
            btn_boQua.Enabled = false;
            btn_luuChatLieu.Enabled = false;
            txt_maChatLieu.Enabled = false;
        }

        private void btn_boQua_Click(object sender, EventArgs e)
        {
            ResetValue();
            btn_boQua.Enabled = false;
            btn_themChatLieu.Enabled = true;
            btn_suaChatLieu.Enabled = false;
            btn_xoaChatLieu.Enabled = false;
            btn_luuChatLieu.Enabled = false;
            txt_maChatLieu.Enabled = false;
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đóng hệ thống?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgv_chatLieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btn_themChatLieu.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_maChatLieu.Focus();
                return;
            }
            int index = e.RowIndex;
            if (index >= 0)
            {
                txt_maChatLieu.Text = dgv_chatLieu.Rows[index].Cells[0].Value.ToString();
                txt_tenChatLieu.Text = dgv_chatLieu.Rows[index].Cells[1].Value.ToString();
            }
            btn_suaChatLieu.Enabled = true;
            btn_xoaChatLieu.Enabled = true;
            btn_boQua.Enabled = true;
        }

        private void btn_xoaHangHoa_Click(object sender, EventArgs e)
        {
            if (txt_maChatLieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần phải nhập mã chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_maChatLieu.Focus();
                return;
            }
            try
            {
                typeProductService.deleteTypeProduct(txt_maChatLieu.Text);
                LoadDataGridView();
                ResetValue();
                btn_themChatLieu.Enabled = true;
                btn_suaChatLieu.Enabled = false;
                btn_xoaChatLieu.Enabled = false;
                btn_boQua.Enabled = false;
                btn_luuChatLieu.Enabled = false;
                txt_maChatLieu.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể xóa chất liệu mã " + txt_maChatLieu.Text + " này được", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
