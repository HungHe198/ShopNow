namespace ShopNow.Source_Code.GUI.VIEWS.Admin
{
    partial class Quản_lí_sản_phẩm
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
            dgv_Dulieu = new DataGridView();
            grb_Quanlisanpham = new GroupBox();
            btn_Xoa = new Button();
            label1 = new Label();
            btn_Themsanpham = new Button();
            tb_Timkiem = new TextBox();
            cmb_Sapxep = new ComboBox();
            groupBox2 = new GroupBox();
            btn_Huy = new Button();
            btn_Capnhat = new Button();
            cmb_Trangthai = new ComboBox();
            tb_Gia = new TextBox();
            tb_Tensanpham = new TextBox();
            tb_Masanpham = new TextBox();
            lb_Trangthai = new Label();
            label2 = new Label();
            lb_Tensanpham = new Label();
            lb_Masanpham = new Label();
            btn_IH = new Button();
            btn_Quanlithongke = new Button();
            btn_Quanlicoso = new Button();
            btn_QLGG = new Button();
            btn_QLNH = new Button();
            btn_QLNV = new Button();
            btn_QLSP = new Button();
            ptb_Logo = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Dulieu).BeginInit();
            grb_Quanlisanpham.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_Logo).BeginInit();
            SuspendLayout();
            // 
            // dgv_Dulieu
            // 
            dgv_Dulieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Dulieu.Location = new Point(6, 186);
            dgv_Dulieu.Name = "dgv_Dulieu";
            dgv_Dulieu.RowHeadersWidth = 51;
            dgv_Dulieu.RowTemplate.Height = 29;
            dgv_Dulieu.Size = new Size(628, 566);
            dgv_Dulieu.TabIndex = 0;
            // 
            // grb_Quanlisanpham
            // 
            grb_Quanlisanpham.Controls.Add(btn_Xoa);
            grb_Quanlisanpham.Controls.Add(label1);
            grb_Quanlisanpham.Controls.Add(btn_Themsanpham);
            grb_Quanlisanpham.Controls.Add(tb_Timkiem);
            grb_Quanlisanpham.Controls.Add(cmb_Sapxep);
            grb_Quanlisanpham.Controls.Add(dgv_Dulieu);
            grb_Quanlisanpham.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            grb_Quanlisanpham.Location = new Point(223, 21);
            grb_Quanlisanpham.Name = "grb_Quanlisanpham";
            grb_Quanlisanpham.Size = new Size(678, 760);
            grb_Quanlisanpham.TabIndex = 12;
            grb_Quanlisanpham.TabStop = false;
            // 
            // btn_Xoa
            // 
            btn_Xoa.AutoSize = true;
            btn_Xoa.BackColor = Color.Red;
            btn_Xoa.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btn_Xoa.FlatAppearance.MouseDownBackColor = Color.Black;
            btn_Xoa.FlatAppearance.MouseOverBackColor = Color.Yellow;
            btn_Xoa.FlatStyle = FlatStyle.Flat;
            btn_Xoa.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Xoa.ForeColor = Color.White;
            btn_Xoa.Location = new Point(543, 83);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(77, 38);
            btn_Xoa.TabIndex = 22;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 21);
            label1.Name = "label1";
            label1.Size = new Size(188, 25);
            label1.TabIndex = 11;
            label1.Text = "Quản lí sản phẩm";
            // 
            // btn_Themsanpham
            // 
            btn_Themsanpham.AutoSize = true;
            btn_Themsanpham.BackColor = Color.Coral;
            btn_Themsanpham.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btn_Themsanpham.FlatAppearance.MouseDownBackColor = Color.Black;
            btn_Themsanpham.FlatAppearance.MouseOverBackColor = Color.Yellow;
            btn_Themsanpham.FlatStyle = FlatStyle.Flat;
            btn_Themsanpham.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Themsanpham.ForeColor = Color.White;
            btn_Themsanpham.Location = new Point(453, 83);
            btn_Themsanpham.Name = "btn_Themsanpham";
            btn_Themsanpham.Size = new Size(84, 38);
            btn_Themsanpham.TabIndex = 6;
            btn_Themsanpham.Text = "Thêm";
            btn_Themsanpham.UseVisualStyleBackColor = false;
            btn_Themsanpham.Click += btn_Themsanpham_Click;
            // 
            // tb_Timkiem
            // 
            tb_Timkiem.BackColor = SystemColors.InactiveBorder;
            tb_Timkiem.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Timkiem.Location = new Point(6, 140);
            tb_Timkiem.Name = "tb_Timkiem";
            tb_Timkiem.PlaceholderText = "Nhập sản phẩm cần tìm";
            tb_Timkiem.Size = new Size(415, 30);
            tb_Timkiem.TabIndex = 5;
            // 
            // cmb_Sapxep
            // 
            cmb_Sapxep.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_Sapxep.FormattingEnabled = true;
            cmb_Sapxep.Location = new Point(427, 140);
            cmb_Sapxep.Name = "cmb_Sapxep";
            cmb_Sapxep.Size = new Size(207, 31);
            cmb_Sapxep.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_Huy);
            groupBox2.Controls.Add(btn_Capnhat);
            groupBox2.Controls.Add(cmb_Trangthai);
            groupBox2.Controls.Add(tb_Gia);
            groupBox2.Controls.Add(tb_Tensanpham);
            groupBox2.Controls.Add(tb_Masanpham);
            groupBox2.Controls.Add(lb_Trangthai);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(lb_Tensanpham);
            groupBox2.Controls.Add(lb_Masanpham);
            groupBox2.Location = new Point(907, 21);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(329, 393);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chi tiết sản phẩm";
            // 
            // btn_Huy
            // 
            btn_Huy.Location = new Point(189, 330);
            btn_Huy.Name = "btn_Huy";
            btn_Huy.Size = new Size(100, 43);
            btn_Huy.TabIndex = 11;
            btn_Huy.Text = "Hủy";
            btn_Huy.UseVisualStyleBackColor = true;
            // 
            // btn_Capnhat
            // 
            btn_Capnhat.Location = new Point(19, 330);
            btn_Capnhat.Name = "btn_Capnhat";
            btn_Capnhat.Size = new Size(100, 43);
            btn_Capnhat.TabIndex = 11;
            btn_Capnhat.Text = "Cập nhật";
            btn_Capnhat.UseVisualStyleBackColor = true;
            // 
            // cmb_Trangthai
            // 
            cmb_Trangthai.FormattingEnabled = true;
            cmb_Trangthai.Location = new Point(19, 259);
            cmb_Trangthai.Name = "cmb_Trangthai";
            cmb_Trangthai.Size = new Size(270, 28);
            cmb_Trangthai.TabIndex = 10;
            // 
            // tb_Gia
            // 
            tb_Gia.Location = new Point(19, 189);
            tb_Gia.Name = "tb_Gia";
            tb_Gia.Size = new Size(270, 27);
            tb_Gia.TabIndex = 7;
            // 
            // tb_Tensanpham
            // 
            tb_Tensanpham.Location = new Point(19, 124);
            tb_Tensanpham.Name = "tb_Tensanpham";
            tb_Tensanpham.Size = new Size(270, 27);
            tb_Tensanpham.TabIndex = 8;
            // 
            // tb_Masanpham
            // 
            tb_Masanpham.Location = new Point(19, 60);
            tb_Masanpham.Name = "tb_Masanpham";
            tb_Masanpham.Size = new Size(270, 27);
            tb_Masanpham.TabIndex = 9;
            // 
            // lb_Trangthai
            // 
            lb_Trangthai.AutoSize = true;
            lb_Trangthai.Location = new Point(19, 236);
            lb_Trangthai.Name = "lb_Trangthai";
            lb_Trangthai.Size = new Size(75, 20);
            lb_Trangthai.TabIndex = 3;
            lb_Trangthai.Text = "Trạng thái";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 166);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 4;
            label2.Text = "Giá";
            // 
            // lb_Tensanpham
            // 
            lb_Tensanpham.AutoSize = true;
            lb_Tensanpham.Location = new Point(19, 101);
            lb_Tensanpham.Name = "lb_Tensanpham";
            lb_Tensanpham.Size = new Size(100, 20);
            lb_Tensanpham.TabIndex = 5;
            lb_Tensanpham.Text = "Tên sản phẩm";
            // 
            // lb_Masanpham
            // 
            lb_Masanpham.AutoSize = true;
            lb_Masanpham.Location = new Point(19, 37);
            lb_Masanpham.Name = "lb_Masanpham";
            lb_Masanpham.Size = new Size(98, 20);
            lb_Masanpham.TabIndex = 6;
            lb_Masanpham.Text = "Mã sản phẩm";
            // 
            // btn_IH
            // 
            btn_IH.Location = new Point(12, 513);
            btn_IH.Name = "btn_IH";
            btn_IH.Size = new Size(205, 45);
            btn_IH.TabIndex = 28;
            btn_IH.Text = "Lịch sử hóa đơn";
            btn_IH.UseVisualStyleBackColor = true;
            btn_IH.Click += btn_IH_Click;
            // 
            // btn_Quanlithongke
            // 
            btn_Quanlithongke.Location = new Point(12, 462);
            btn_Quanlithongke.Name = "btn_Quanlithongke";
            btn_Quanlithongke.Size = new Size(205, 45);
            btn_Quanlithongke.TabIndex = 29;
            btn_Quanlithongke.Text = "Quản lí thống kê";
            btn_Quanlithongke.UseVisualStyleBackColor = true;
            btn_Quanlithongke.Click += btn_Quanlithongke_Click;
            // 
            // btn_Quanlicoso
            // 
            btn_Quanlicoso.Location = new Point(12, 411);
            btn_Quanlicoso.Name = "btn_Quanlicoso";
            btn_Quanlicoso.Size = new Size(205, 45);
            btn_Quanlicoso.TabIndex = 30;
            btn_Quanlicoso.Text = "Quản lí cơ sở";
            btn_Quanlicoso.UseVisualStyleBackColor = true;
            btn_Quanlicoso.Click += btn_Quanlicoso_Click;
            // 
            // btn_QLGG
            // 
            btn_QLGG.Location = new Point(12, 360);
            btn_QLGG.Name = "btn_QLGG";
            btn_QLGG.Size = new Size(205, 45);
            btn_QLGG.TabIndex = 31;
            btn_QLGG.Text = "Quản lí giảm giá";
            btn_QLGG.UseVisualStyleBackColor = true;
            btn_QLGG.Click += btn_QLGG_Click;
            // 
            // btn_QLNH
            // 
            btn_QLNH.Location = new Point(12, 309);
            btn_QLNH.Name = "btn_QLNH";
            btn_QLNH.Size = new Size(205, 45);
            btn_QLNH.TabIndex = 32;
            btn_QLNH.Text = "Quản lí nhập hàng";
            btn_QLNH.UseVisualStyleBackColor = true;
            btn_QLNH.Click += btn_QLNH_Click;
            // 
            // btn_QLNV
            // 
            btn_QLNV.Location = new Point(12, 258);
            btn_QLNV.Name = "btn_QLNV";
            btn_QLNV.Size = new Size(205, 45);
            btn_QLNV.TabIndex = 33;
            btn_QLNV.Text = "Quản lí nhân viên";
            btn_QLNV.UseVisualStyleBackColor = true;
            btn_QLNV.Click += btn_QLNV_Click;
            // 
            // btn_QLSP
            // 
            btn_QLSP.Location = new Point(12, 207);
            btn_QLSP.Name = "btn_QLSP";
            btn_QLSP.Size = new Size(205, 45);
            btn_QLSP.TabIndex = 34;
            btn_QLSP.Text = "Quản lí sản phẩm";
            btn_QLSP.UseVisualStyleBackColor = true;
            btn_QLSP.Click += btn_QLSP_Click;
            // 
            // ptb_Logo
            // 
            ptb_Logo.BackColor = Color.MistyRose;
            ptb_Logo.Image = Properties.Resources.Logo;
            ptb_Logo.Location = new Point(12, 21);
            ptb_Logo.Name = "ptb_Logo";
            ptb_Logo.Size = new Size(200, 84);
            ptb_Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_Logo.TabIndex = 35;
            ptb_Logo.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(12, 564);
            button1.Name = "button1";
            button1.Size = new Size(205, 45);
            button1.TabIndex = 40;
            button1.Text = "Đơn hàng cần xác nhận";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Quản_lí_sản_phẩm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 776);
            Controls.Add(button1);
            Controls.Add(ptb_Logo);
            Controls.Add(btn_IH);
            Controls.Add(btn_Quanlithongke);
            Controls.Add(btn_Quanlicoso);
            Controls.Add(btn_QLGG);
            Controls.Add(btn_QLNH);
            Controls.Add(btn_QLNV);
            Controls.Add(btn_QLSP);
            Controls.Add(groupBox2);
            Controls.Add(grb_Quanlisanpham);
            Name = "Quản_lí_sản_phẩm";
            Text = "Quản_lí_sản_phẩm";
            Load += Quản_lí_sản_phẩm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Dulieu).EndInit();
            grb_Quanlisanpham.ResumeLayout(false);
            grb_Quanlisanpham.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_Logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_Dulieu;

        private GroupBox grb_Quanlisanpham;
        private TextBox tb_Timkiem;
        private ComboBox cmb_Sapxep;
        private Button btn_Themsanpham;
        private GroupBox groupBox2;
        private Button btn_Huy;
        private Button btn_Capnhat;
        private ComboBox cmb_Trangthai;
        private TextBox tb_Gia;
        private TextBox tb_Tensanpham;
        private TextBox tb_Masanpham;
        private Label lb_Trangthai;
        private Label label2;
        private Label lb_Tensanpham;
        private Label lb_Masanpham;
        private Label label1;
        private Button btn_Xoa;
        private Button btn_IH;
        private Button btn_Quanlithongke;
        private Button btn_Quanlicoso;
        private Button btn_QLGG;
        private Button btn_QLNH;
        private Button btn_QLNV;
        private Button btn_QLSP;
        private PictureBox ptb_Logo;
        private Button button1;
    }
}