﻿namespace ShopNow.Source_Code.GUI.VIEWS.Admin
{
    partial class Quản_lí_khách_hàng
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
            grb_Quanlinhanvien = new GroupBox();
            label1 = new Label();
            btn_Sua = new Button();
            btn_Xoa = new Button();
            btn_Them = new Button();
            tb_Timkiem = new TextBox();
            cmb_Sapxep = new ComboBox();
            dataGridView1 = new DataGridView();
            btn_IH = new Button();
            btn_Quanlithongke = new Button();
            btn_Quanlicoso = new Button();
            btn_QLGG = new Button();
            btn_QLNH = new Button();
            btn_QLNV = new Button();
            btn_QLSP = new Button();
            ptb_Logo = new PictureBox();
            button1 = new Button();
            btn_QuanLiKhachHang = new Button();
            grb_Quanlinhanvien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptb_Logo).BeginInit();
            SuspendLayout();
            // 
            // grb_Quanlinhanvien
            // 
            grb_Quanlinhanvien.Controls.Add(label1);
            grb_Quanlinhanvien.Controls.Add(btn_Sua);
            grb_Quanlinhanvien.Controls.Add(btn_Xoa);
            grb_Quanlinhanvien.Controls.Add(btn_Them);
            grb_Quanlinhanvien.Controls.Add(tb_Timkiem);
            grb_Quanlinhanvien.Controls.Add(cmb_Sapxep);
            grb_Quanlinhanvien.Controls.Add(dataGridView1);
            grb_Quanlinhanvien.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            grb_Quanlinhanvien.Location = new Point(204, 12);
            grb_Quanlinhanvien.Margin = new Padding(3, 2, 3, 2);
            grb_Quanlinhanvien.Name = "grb_Quanlinhanvien";
            grb_Quanlinhanvien.Padding = new Padding(3, 2, 3, 2);
            grb_Quanlinhanvien.Size = new Size(845, 560);
            grb_Quanlinhanvien.TabIndex = 12;
            grb_Quanlinhanvien.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(5, 16);
            label1.Name = "label1";
            label1.Size = new Size(170, 22);
            label1.TabIndex = 10;
            label1.Text = "Quản lí khách hàng";
            // 
            // btn_Sua
            // 
            btn_Sua.AutoSize = true;
            btn_Sua.BackColor = Color.Tan;
            btn_Sua.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btn_Sua.FlatAppearance.MouseDownBackColor = Color.Black;
            btn_Sua.FlatAppearance.MouseOverBackColor = Color.Yellow;
            btn_Sua.FlatStyle = FlatStyle.Flat;
            btn_Sua.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Sua.ForeColor = Color.White;
            btn_Sua.Location = new Point(676, 100);
            btn_Sua.Margin = new Padding(3, 2, 3, 2);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(67, 31);
            btn_Sua.TabIndex = 9;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = false;
            btn_Sua.Click += btn_Sua_Click;
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
            btn_Xoa.Location = new Point(773, 100);
            btn_Xoa.Margin = new Padding(3, 2, 3, 2);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(67, 31);
            btn_Xoa.TabIndex = 9;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = false;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // btn_Them
            // 
            btn_Them.AutoSize = true;
            btn_Them.BackColor = Color.Coral;
            btn_Them.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btn_Them.FlatAppearance.MouseDownBackColor = Color.Black;
            btn_Them.FlatAppearance.MouseOverBackColor = Color.Yellow;
            btn_Them.FlatStyle = FlatStyle.Flat;
            btn_Them.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Them.ForeColor = Color.White;
            btn_Them.Location = new Point(578, 100);
            btn_Them.Margin = new Padding(3, 2, 3, 2);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(67, 31);
            btn_Them.TabIndex = 9;
            btn_Them.Text = "Thêm ";
            btn_Them.UseVisualStyleBackColor = false;
            btn_Them.Click += btn_Them_Click;
            // 
            // tb_Timkiem
            // 
            tb_Timkiem.BackColor = SystemColors.InactiveBorder;
            tb_Timkiem.Location = new Point(5, 110);
            tb_Timkiem.Margin = new Padding(3, 2, 3, 2);
            tb_Timkiem.Name = "tb_Timkiem";
            tb_Timkiem.PlaceholderText = "Nhập để tìm kiếm";
            tb_Timkiem.Size = new Size(312, 21);
            tb_Timkiem.TabIndex = 8;
            tb_Timkiem.TextChanged += tb_Timkiem_TextChanged;
            // 
            // cmb_Sapxep
            // 
            cmb_Sapxep.FormattingEnabled = true;
            cmb_Sapxep.Location = new Point(346, 110);
            cmb_Sapxep.Margin = new Padding(3, 2, 3, 2);
            cmb_Sapxep.Name = "cmb_Sapxep";
            cmb_Sapxep.Size = new Size(133, 23);
            cmb_Sapxep.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(5, 138);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(835, 418);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btn_IH
            // 
            btn_IH.Location = new Point(10, 380);
            btn_IH.Margin = new Padding(3, 2, 3, 2);
            btn_IH.Name = "btn_IH";
            btn_IH.Size = new Size(179, 34);
            btn_IH.TabIndex = 41;
            btn_IH.Text = "Lịch sử hóa đơn";
            btn_IH.UseVisualStyleBackColor = true;
            btn_IH.Click += btn_IH_Click;
            // 
            // btn_Quanlithongke
            // 
            btn_Quanlithongke.Location = new Point(10, 341);
            btn_Quanlithongke.Margin = new Padding(3, 2, 3, 2);
            btn_Quanlithongke.Name = "btn_Quanlithongke";
            btn_Quanlithongke.Size = new Size(179, 34);
            btn_Quanlithongke.TabIndex = 42;
            btn_Quanlithongke.Text = "Quản lí thống kê";
            btn_Quanlithongke.UseVisualStyleBackColor = true;
            btn_Quanlithongke.Click += btn_Quanlithongke_Click;
            // 
            // btn_Quanlicoso
            // 
            btn_Quanlicoso.Location = new Point(10, 303);
            btn_Quanlicoso.Margin = new Padding(3, 2, 3, 2);
            btn_Quanlicoso.Name = "btn_Quanlicoso";
            btn_Quanlicoso.Size = new Size(179, 34);
            btn_Quanlicoso.TabIndex = 43;
            btn_Quanlicoso.Text = "Quản lí cơ sở";
            btn_Quanlicoso.UseVisualStyleBackColor = true;
            btn_Quanlicoso.Click += btn_Quanlicoso_Click;
            // 
            // btn_QLGG
            // 
            btn_QLGG.Location = new Point(10, 456);
            btn_QLGG.Margin = new Padding(3, 2, 3, 2);
            btn_QLGG.Name = "btn_QLGG";
            btn_QLGG.Size = new Size(179, 34);
            btn_QLGG.TabIndex = 44;
            btn_QLGG.Text = "Quản lí giảm giá";
            btn_QLGG.UseVisualStyleBackColor = true;
            btn_QLGG.Click += btn_QLGG_Click;
            // 
            // btn_QLNH
            // 
            btn_QLNH.Location = new Point(10, 226);
            btn_QLNH.Margin = new Padding(3, 2, 3, 2);
            btn_QLNH.Name = "btn_QLNH";
            btn_QLNH.Size = new Size(179, 34);
            btn_QLNH.TabIndex = 45;
            btn_QLNH.Text = "Quản lí nhập hàng";
            btn_QLNH.UseVisualStyleBackColor = true;
            btn_QLNH.Click += btn_QLNH_Click;
            // 
            // btn_QLNV
            // 
            btn_QLNV.Location = new Point(10, 188);
            btn_QLNV.Margin = new Padding(3, 2, 3, 2);
            btn_QLNV.Name = "btn_QLNV";
            btn_QLNV.Size = new Size(179, 34);
            btn_QLNV.TabIndex = 46;
            btn_QLNV.Text = "Quản lí nhân viên";
            btn_QLNV.UseVisualStyleBackColor = true;
            btn_QLNV.Click += btn_QLNV_Click;
            // 
            // btn_QLSP
            // 
            btn_QLSP.Location = new Point(10, 150);
            btn_QLSP.Margin = new Padding(3, 2, 3, 2);
            btn_QLSP.Name = "btn_QLSP";
            btn_QLSP.Size = new Size(179, 34);
            btn_QLSP.TabIndex = 47;
            btn_QLSP.Text = "Quản lí sản phẩm";
            btn_QLSP.UseVisualStyleBackColor = true;
            btn_QLSP.Click += btn_QLSP_Click;
            // 
            // ptb_Logo
            // 
            ptb_Logo.BackColor = Color.MistyRose;
            ptb_Logo.Image = Properties.Resources.Logo;
            ptb_Logo.Location = new Point(10, 9);
            ptb_Logo.Margin = new Padding(3, 2, 3, 2);
            ptb_Logo.Name = "ptb_Logo";
            ptb_Logo.Size = new Size(175, 63);
            ptb_Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_Logo.TabIndex = 48;
            ptb_Logo.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(10, 418);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(179, 34);
            button1.TabIndex = 49;
            button1.Text = "Đơn hàng cần xác nhận";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_QuanLiKhachHang
            // 
            btn_QuanLiKhachHang.Location = new Point(10, 265);
            btn_QuanLiKhachHang.Margin = new Padding(3, 2, 3, 2);
            btn_QuanLiKhachHang.Name = "btn_QuanLiKhachHang";
            btn_QuanLiKhachHang.Size = new Size(179, 34);
            btn_QuanLiKhachHang.TabIndex = 44;
            btn_QuanLiKhachHang.Text = "Quản lí giảm giá";
            btn_QuanLiKhachHang.UseVisualStyleBackColor = true;
            btn_QuanLiKhachHang.Click += btn_QLGG_Click;
            // 
            // Quản_lí_khách_hàng
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 584);
            Controls.Add(button1);
            Controls.Add(ptb_Logo);
            Controls.Add(btn_IH);
            Controls.Add(btn_Quanlithongke);
            Controls.Add(btn_Quanlicoso);
            Controls.Add(btn_QuanLiKhachHang);
            Controls.Add(btn_QLGG);
            Controls.Add(btn_QLNH);
            Controls.Add(btn_QLNV);
            Controls.Add(btn_QLSP);
            Controls.Add(grb_Quanlinhanvien);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Quản_lí_khách_hàng";
            Text = "Quản_lí_khách_hàng";
            Load += Quản_lí_khách_hàng_Load;
            grb_Quanlinhanvien.ResumeLayout(false);
            grb_Quanlinhanvien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptb_Logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grb_Quanlinhanvien;
        private Label label1;
        private Button btn_Sua;
        private Button btn_Xoa;
        private Button btn_Them;
        private TextBox tb_Timkiem;
        private ComboBox cmb_Sapxep;
        private DataGridView dataGridView1;
        private Button btn_IH;
        private Button btn_Quanlithongke;
        private Button btn_Quanlicoso;
        private Button btn_QLGG;
        private Button btn_QLNH;
        private Button btn_QLNV;
        private Button btn_QLSP;
        private PictureBox ptb_Logo;
        private Button button1;
        private Button btn_QuanLiKhachHang;
    }
}