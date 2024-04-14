namespace ShopNow.Source_Code.GUI.VIEWS.Staff
{
    partial class QuanLiKhachHang
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
            btn_Xoa = new Button();
            btn_Them = new Button();
            dataGridView1 = new DataGridView();
            ptb_Logo = new PictureBox();
            btn_reload = new Button();
            btn_QLKH = new Button();
            grb_Quanlinhanvien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptb_Logo).BeginInit();
            SuspendLayout();
            // 
            // grb_Quanlinhanvien
            // 
            grb_Quanlinhanvien.Controls.Add(label1);
            grb_Quanlinhanvien.Controls.Add(btn_Xoa);
            grb_Quanlinhanvien.Controls.Add(btn_Them);
            grb_Quanlinhanvien.Controls.Add(dataGridView1);
            grb_Quanlinhanvien.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            grb_Quanlinhanvien.Location = new Point(233, 11);
            grb_Quanlinhanvien.Name = "grb_Quanlinhanvien";
            grb_Quanlinhanvien.Size = new Size(966, 747);
            grb_Quanlinhanvien.TabIndex = 47;
            grb_Quanlinhanvien.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 21);
            label1.Name = "label1";
            label1.Size = new Size(208, 25);
            label1.TabIndex = 10;
            label1.Text = "Quản lí khách hàng";
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
            btn_Xoa.Location = new Point(883, 134);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(77, 38);
            btn_Xoa.TabIndex = 9;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = false;
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
            btn_Them.Location = new Point(774, 134);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(88, 38);
            btn_Them.TabIndex = 9;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = false;
            btn_Them.Click += btn_Them_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 184);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(954, 557);
            dataGridView1.TabIndex = 0;
            // 
            // ptb_Logo
            // 
            ptb_Logo.BackColor = Color.MistyRose;
            ptb_Logo.Image = Properties.Resources.Logo;
            ptb_Logo.Location = new Point(12, 7);
            ptb_Logo.Name = "ptb_Logo";
            ptb_Logo.Size = new Size(200, 84);
            ptb_Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_Logo.TabIndex = 46;
            ptb_Logo.TabStop = false;
            // 
            // btn_reload
            // 
            btn_reload.Location = new Point(12, 195);
            btn_reload.Name = "btn_reload";
            btn_reload.Size = new Size(205, 45);
            btn_reload.TabIndex = 48;
            btn_reload.Text = "Đơn hàng cần xác nhận";
            btn_reload.UseVisualStyleBackColor = true;
            btn_reload.Click += btn_reload_Click;
            // 
            // btn_QLKH
            // 
            btn_QLKH.Location = new Point(12, 272);
            btn_QLKH.Name = "btn_QLKH";
            btn_QLKH.Size = new Size(205, 45);
            btn_QLKH.TabIndex = 50;
            btn_QLKH.Text = "Quản lí khách hàng";
            btn_QLKH.UseVisualStyleBackColor = true;
            btn_QLKH.Click += btn_QLKH_Click_1;
            // 
            // QuanLiKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1220, 778);
            Controls.Add(btn_QLKH);
            Controls.Add(grb_Quanlinhanvien);
            Controls.Add(ptb_Logo);
            Controls.Add(btn_reload);
            Name = "QuanLiKhachHang";
            Text = "QuanLiKhachHang";
            Load += QuanLiKhachHang_Load;
            grb_Quanlinhanvien.ResumeLayout(false);
            grb_Quanlinhanvien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptb_Logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grb_Quanlinhanvien;
        private Label label1;
        private Button btn_Xoa;
        private Button btn_Them;
        private DataGridView dataGridView1;
        private PictureBox ptb_Logo;
        private Button btn_reload;
        private Button btn_QLKH;
    }
}