namespace HRMAPP
{
    partial class FRMDanhMucChatLieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMDanhMucChatLieu));
            panel1 = new Panel();
            button1 = new Button();
            txt_tenChatLieu = new TextBox();
            txt_maChatLieu = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btn_xoaChatLieu = new Button();
            btn_dong = new Button();
            btn_boQua = new Button();
            btn_luuChatLieu = new Button();
            btn_suaChatLieu = new Button();
            btn_themChatLieu = new Button();
            dgv_chatLieu = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_chatLieu).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txt_tenChatLieu);
            panel1.Controls.Add(txt_maChatLieu);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1125, 219);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(367, 12);
            button1.Name = "button1";
            button1.Size = new Size(58, 55);
            button1.TabIndex = 27;
            button1.UseVisualStyleBackColor = true;
            // 
            // txt_tenChatLieu
            // 
            txt_tenChatLieu.Location = new Point(213, 161);
            txt_tenChatLieu.Margin = new Padding(3, 4, 3, 4);
            txt_tenChatLieu.Name = "txt_tenChatLieu";
            txt_tenChatLieu.Size = new Size(385, 27);
            txt_tenChatLieu.TabIndex = 4;
            // 
            // txt_maChatLieu
            // 
            txt_maChatLieu.Location = new Point(213, 95);
            txt_maChatLieu.Margin = new Padding(3, 4, 3, 4);
            txt_maChatLieu.Name = "txt_maChatLieu";
            txt_maChatLieu.Size = new Size(385, 27);
            txt_maChatLieu.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(63, 161);
            label3.Name = "label3";
            label3.Size = new Size(127, 25);
            label3.TabIndex = 2;
            label3.Text = "Tên chất liệu :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(65, 97);
            label2.Name = "label2";
            label2.Size = new Size(125, 25);
            label2.TabIndex = 1;
            label2.Text = "Mã chất liệu :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(431, 26);
            label1.Name = "label1";
            label1.Size = new Size(357, 41);
            label1.TabIndex = 0;
            label1.Text = "DANH MỤC CHẤT LIỆU";
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_xoaChatLieu);
            panel2.Controls.Add(btn_dong);
            panel2.Controls.Add(btn_boQua);
            panel2.Controls.Add(btn_luuChatLieu);
            panel2.Controls.Add(btn_suaChatLieu);
            panel2.Controls.Add(btn_themChatLieu);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 654);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1125, 149);
            panel2.TabIndex = 1;
            // 
            // btn_xoaChatLieu
            // 
            btn_xoaChatLieu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_xoaChatLieu.Image = (Image)resources.GetObject("btn_xoaChatLieu.Image");
            btn_xoaChatLieu.Location = new Point(228, 40);
            btn_xoaChatLieu.Name = "btn_xoaChatLieu";
            btn_xoaChatLieu.Size = new Size(165, 69);
            btn_xoaChatLieu.TabIndex = 46;
            btn_xoaChatLieu.Text = "&Xóa chất liệu";
            btn_xoaChatLieu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_xoaChatLieu.UseVisualStyleBackColor = true;
            btn_xoaChatLieu.Click += btn_xoaHangHoa_Click;
            // 
            // btn_dong
            // 
            btn_dong.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_dong.Image = (Image)resources.GetObject("btn_dong.Image");
            btn_dong.Location = new Point(912, 40);
            btn_dong.Margin = new Padding(3, 4, 3, 4);
            btn_dong.Name = "btn_dong";
            btn_dong.Size = new Size(165, 69);
            btn_dong.TabIndex = 45;
            btn_dong.Text = "&Đóng";
            btn_dong.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_dong.UseVisualStyleBackColor = true;
            btn_dong.Click += btn_dong_Click;
            // 
            // btn_boQua
            // 
            btn_boQua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_boQua.Image = (Image)resources.GetObject("btn_boQua.Image");
            btn_boQua.Location = new Point(741, 40);
            btn_boQua.Margin = new Padding(3, 4, 3, 4);
            btn_boQua.Name = "btn_boQua";
            btn_boQua.Size = new Size(165, 69);
            btn_boQua.TabIndex = 44;
            btn_boQua.Text = "&Bỏ qua";
            btn_boQua.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_boQua.UseVisualStyleBackColor = true;
            btn_boQua.Click += btn_boQua_Click;
            // 
            // btn_luuChatLieu
            // 
            btn_luuChatLieu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_luuChatLieu.Image = (Image)resources.GetObject("btn_luuChatLieu.Image");
            btn_luuChatLieu.Location = new Point(570, 40);
            btn_luuChatLieu.Margin = new Padding(3, 4, 3, 4);
            btn_luuChatLieu.Name = "btn_luuChatLieu";
            btn_luuChatLieu.Size = new Size(165, 69);
            btn_luuChatLieu.TabIndex = 43;
            btn_luuChatLieu.Text = "&Lưu";
            btn_luuChatLieu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_luuChatLieu.UseVisualStyleBackColor = true;
            btn_luuChatLieu.Click += btn_luuChatLieu_Click;
            // 
            // btn_suaChatLieu
            // 
            btn_suaChatLieu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_suaChatLieu.Image = (Image)resources.GetObject("btn_suaChatLieu.Image");
            btn_suaChatLieu.Location = new Point(399, 40);
            btn_suaChatLieu.Margin = new Padding(3, 4, 3, 4);
            btn_suaChatLieu.Name = "btn_suaChatLieu";
            btn_suaChatLieu.Size = new Size(165, 69);
            btn_suaChatLieu.TabIndex = 42;
            btn_suaChatLieu.Text = "&Cập nhật chất liệu";
            btn_suaChatLieu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_suaChatLieu.UseVisualStyleBackColor = true;
            btn_suaChatLieu.Click += btn_suaChatLieu_Click;
            // 
            // btn_themChatLieu
            // 
            btn_themChatLieu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_themChatLieu.Image = (Image)resources.GetObject("btn_themChatLieu.Image");
            btn_themChatLieu.Location = new Point(57, 40);
            btn_themChatLieu.Margin = new Padding(3, 4, 3, 4);
            btn_themChatLieu.Name = "btn_themChatLieu";
            btn_themChatLieu.Size = new Size(165, 69);
            btn_themChatLieu.TabIndex = 40;
            btn_themChatLieu.Text = "&Thêm chất liệu";
            btn_themChatLieu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_themChatLieu.UseVisualStyleBackColor = true;
            btn_themChatLieu.Click += btn_themChatLieu_Click;
            // 
            // dgv_chatLieu
            // 
            dgv_chatLieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_chatLieu.Dock = DockStyle.Fill;
            dgv_chatLieu.Location = new Point(0, 219);
            dgv_chatLieu.Margin = new Padding(3, 4, 3, 4);
            dgv_chatLieu.Name = "dgv_chatLieu";
            dgv_chatLieu.RowHeadersWidth = 51;
            dgv_chatLieu.RowTemplate.Height = 25;
            dgv_chatLieu.Size = new Size(1125, 435);
            dgv_chatLieu.TabIndex = 2;
            dgv_chatLieu.CellContentClick += dgv_chatLieu_CellContentClick;
            // 
            // FRMDanhMucChatLieu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 803);
            Controls.Add(dgv_chatLieu);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FRMDanhMucChatLieu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FRMDanhMucChatLieu";
            Load += FRMDanhMucChatLieu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_chatLieu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txt_tenChatLieu;
        private TextBox txt_maChatLieu;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private DataGridView dgv_chatLieu;
        private Button btn_dong;
        private Button btn_boQua;
        private Button btn_luuChatLieu;
        private Button btn_suaChatLieu;
        private Button btn_themChatLieu;
        private Button btn_xoaChatLieu;
        private Button button1;
    }
}