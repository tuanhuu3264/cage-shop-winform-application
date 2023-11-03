namespace HRMAPP
{
    partial class FRMDanhMucKhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMDanhMucKhachHang));
            panel1 = new Panel();
            button1 = new Button();
            date_ngayTao = new DateTimePicker();
            masked_dienThoaiKhachHang = new MaskedTextBox();
            txt_diaChiKhachHang = new TextBox();
            txt_tenKhachHang = new TextBox();
            txt_maKhachHang = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btn_boQua = new Button();
            btn_timKiemKhachHang = new Button();
            btn_hienThiDS = new Button();
            btn_dong = new Button();
            btn_luuKhachHang = new Button();
            btn_suaKhachHang = new Button();
            btn_xoaKhachHang = new Button();
            btn_themKhachHang = new Button();
            dgv_khachHang = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_khachHang).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(date_ngayTao);
            panel1.Controls.Add(masked_dienThoaiKhachHang);
            panel1.Controls.Add(txt_diaChiKhachHang);
            panel1.Controls.Add(txt_tenKhachHang);
            panel1.Controls.Add(txt_maKhachHang);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1125, 205);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(355, 12);
            button1.Name = "button1";
            button1.Size = new Size(58, 55);
            button1.TabIndex = 27;
            button1.UseVisualStyleBackColor = true;
            // 
            // date_ngayTao
            // 
            date_ngayTao.Format = DateTimePickerFormat.Short;
            date_ngayTao.Location = new Point(918, 143);
            date_ngayTao.Name = "date_ngayTao";
            date_ngayTao.Size = new Size(126, 27);
            date_ngayTao.TabIndex = 19;
            // 
            // masked_dienThoaiKhachHang
            // 
            masked_dienThoaiKhachHang.Location = new Point(629, 143);
            masked_dienThoaiKhachHang.Mask = "(999) 000-0000";
            masked_dienThoaiKhachHang.Name = "masked_dienThoaiKhachHang";
            masked_dienThoaiKhachHang.Size = new Size(268, 27);
            masked_dienThoaiKhachHang.TabIndex = 18;
            // 
            // txt_diaChiKhachHang
            // 
            txt_diaChiKhachHang.Location = new Point(629, 90);
            txt_diaChiKhachHang.Name = "txt_diaChiKhachHang";
            txt_diaChiKhachHang.Size = new Size(268, 27);
            txt_diaChiKhachHang.TabIndex = 17;
            // 
            // txt_tenKhachHang
            // 
            txt_tenKhachHang.Location = new Point(214, 143);
            txt_tenKhachHang.Name = "txt_tenKhachHang";
            txt_tenKhachHang.Size = new Size(268, 27);
            txt_tenKhachHang.TabIndex = 16;
            // 
            // txt_maKhachHang
            // 
            txt_maKhachHang.Location = new Point(214, 90);
            txt_maKhachHang.Name = "txt_maKhachHang";
            txt_maKhachHang.Size = new Size(268, 27);
            txt_maKhachHang.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(918, 90);
            label6.Name = "label6";
            label6.Size = new Size(97, 25);
            label6.TabIndex = 7;
            label6.Text = "Ngày tạo :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(515, 145);
            label5.Name = "label5";
            label5.Size = new Size(108, 25);
            label5.TabIndex = 6;
            label5.Text = "Điện thoại :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(544, 89);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 5;
            label4.Text = "Địa chỉ :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(55, 142);
            label3.Name = "label3";
            label3.Size = new Size(153, 25);
            label3.TabIndex = 4;
            label3.Text = "Tên khách hàng :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(57, 89);
            label2.Name = "label2";
            label2.Size = new Size(151, 25);
            label2.TabIndex = 3;
            label2.Text = "Mã khách hàng :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(419, 21);
            label1.Name = "label1";
            label1.Size = new Size(411, 41);
            label1.TabIndex = 2;
            label1.Text = "DANH MỤC KHÁCH HÀNG";
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_boQua);
            panel2.Controls.Add(btn_timKiemKhachHang);
            panel2.Controls.Add(btn_hienThiDS);
            panel2.Controls.Add(btn_dong);
            panel2.Controls.Add(btn_luuKhachHang);
            panel2.Controls.Add(btn_suaKhachHang);
            panel2.Controls.Add(btn_xoaKhachHang);
            panel2.Controls.Add(btn_themKhachHang);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 625);
            panel2.Name = "panel2";
            panel2.Size = new Size(1125, 178);
            panel2.TabIndex = 1;
            // 
            // btn_boQua
            // 
            btn_boQua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_boQua.Image = (Image)resources.GetObject("btn_boQua.Image");
            btn_boQua.Location = new Point(55, 102);
            btn_boQua.Name = "btn_boQua";
            btn_boQua.Size = new Size(190, 61);
            btn_boQua.TabIndex = 14;
            btn_boQua.Text = "&Bỏ qua";
            btn_boQua.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_boQua.UseVisualStyleBackColor = true;
            btn_boQua.Click += btn_boQua_Click;
            // 
            // btn_timKiemKhachHang
            // 
            btn_timKiemKhachHang.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_timKiemKhachHang.Image = (Image)resources.GetObject("btn_timKiemKhachHang.Image");
            btn_timKiemKhachHang.Location = new Point(308, 102);
            btn_timKiemKhachHang.Name = "btn_timKiemKhachHang";
            btn_timKiemKhachHang.Size = new Size(190, 61);
            btn_timKiemKhachHang.TabIndex = 13;
            btn_timKiemKhachHang.Text = "&Tìm Kiếm khách hàng";
            btn_timKiemKhachHang.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_timKiemKhachHang.UseVisualStyleBackColor = true;
            btn_timKiemKhachHang.Click += btn_timKiemKhachHang_Click;
            // 
            // btn_hienThiDS
            // 
            btn_hienThiDS.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_hienThiDS.Image = (Image)resources.GetObject("btn_hienThiDS.Image");
            btn_hienThiDS.Location = new Point(589, 102);
            btn_hienThiDS.Name = "btn_hienThiDS";
            btn_hienThiDS.Size = new Size(190, 61);
            btn_hienThiDS.TabIndex = 12;
            btn_hienThiDS.Text = "&Hiển thị DS";
            btn_hienThiDS.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_hienThiDS.UseVisualStyleBackColor = true;
            btn_hienThiDS.Click += btn_hienThiDS_Click;
            // 
            // btn_dong
            // 
            btn_dong.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_dong.Image = (Image)resources.GetObject("btn_dong.Image");
            btn_dong.Location = new Point(847, 102);
            btn_dong.Name = "btn_dong";
            btn_dong.Size = new Size(190, 61);
            btn_dong.TabIndex = 11;
            btn_dong.Text = "&Đóng";
            btn_dong.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_dong.UseVisualStyleBackColor = true;
            btn_dong.Click += btn_dong_Click;
            // 
            // btn_luuKhachHang
            // 
            btn_luuKhachHang.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_luuKhachHang.Image = (Image)resources.GetObject("btn_luuKhachHang.Image");
            btn_luuKhachHang.Location = new Point(847, 26);
            btn_luuKhachHang.Name = "btn_luuKhachHang";
            btn_luuKhachHang.Size = new Size(190, 61);
            btn_luuKhachHang.TabIndex = 10;
            btn_luuKhachHang.Text = "&Lưu ";
            btn_luuKhachHang.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_luuKhachHang.UseVisualStyleBackColor = true;
            btn_luuKhachHang.Click += btn_luuKhachHang_Click;
            // 
            // btn_suaKhachHang
            // 
            btn_suaKhachHang.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_suaKhachHang.Image = (Image)resources.GetObject("btn_suaKhachHang.Image");
            btn_suaKhachHang.Location = new Point(589, 26);
            btn_suaKhachHang.Name = "btn_suaKhachHang";
            btn_suaKhachHang.Size = new Size(190, 61);
            btn_suaKhachHang.TabIndex = 9;
            btn_suaKhachHang.Text = "&Cập nhật khách hàng";
            btn_suaKhachHang.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_suaKhachHang.UseVisualStyleBackColor = true;
            btn_suaKhachHang.Click += btn_suaKhachHang_Click;
            // 
            // btn_xoaKhachHang
            // 
            btn_xoaKhachHang.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_xoaKhachHang.Image = (Image)resources.GetObject("btn_xoaKhachHang.Image");
            btn_xoaKhachHang.Location = new Point(308, 26);
            btn_xoaKhachHang.Name = "btn_xoaKhachHang";
            btn_xoaKhachHang.Size = new Size(190, 61);
            btn_xoaKhachHang.TabIndex = 8;
            btn_xoaKhachHang.Text = "&Xóa khách hàng";
            btn_xoaKhachHang.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_xoaKhachHang.UseVisualStyleBackColor = true;
            btn_xoaKhachHang.Click += btn_xoaKhachHang_Click;
            // 
            // btn_themKhachHang
            // 
            btn_themKhachHang.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_themKhachHang.Image = (Image)resources.GetObject("btn_themKhachHang.Image");
            btn_themKhachHang.Location = new Point(55, 26);
            btn_themKhachHang.Name = "btn_themKhachHang";
            btn_themKhachHang.Size = new Size(190, 61);
            btn_themKhachHang.TabIndex = 1;
            btn_themKhachHang.Text = "&Thêm khách hàng";
            btn_themKhachHang.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_themKhachHang.UseVisualStyleBackColor = true;
            btn_themKhachHang.Click += btn_themKhachHang_Click;
            // 
            // dgv_khachHang
            // 
            dgv_khachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_khachHang.Dock = DockStyle.Fill;
            dgv_khachHang.Location = new Point(0, 205);
            dgv_khachHang.Name = "dgv_khachHang";
            dgv_khachHang.RowHeadersWidth = 51;
            dgv_khachHang.RowTemplate.Height = 29;
            dgv_khachHang.Size = new Size(1125, 420);
            dgv_khachHang.TabIndex = 2;
            dgv_khachHang.CellContentClick += dgv_khachHang_CellContentClick;
            // 
            // FRMDanhMucKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 803);
            Controls.Add(dgv_khachHang);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FRMDanhMucKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FRMDanhMucKhachHang";
            Load += FRMDanhMucKhachHang_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_khachHang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private MaskedTextBox masked_dienThoaiKhachHang;
        private TextBox txt_diaChiKhachHang;
        private TextBox txt_tenKhachHang;
        private TextBox txt_maKhachHang;
        private DateTimePicker date_ngayTao;
        private Panel panel2;
        private DataGridView dgv_khachHang;
        private Button btn_themKhachHang;
        private Button btn_timKiemKhachHang;
        private Button btn_hienThiDS;
        private Button btn_dong;
        private Button btn_luuKhachHang;
        private Button btn_suaKhachHang;
        private Button btn_xoaKhachHang;
        private Button btn_boQua;
        private Button button1;
    }
}