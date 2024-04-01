namespace ShopNow.Source_Code.GUI.VIEWS.Admin
{
    partial class Quản_lí_nhân_viên
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
            btn_Themnhanvien = new Button();
            label1 = new Label();
            button2 = new Button();
            btn_Sua = new Button();
            dataGridView1 = new DataGridView();
            cmb_Sapxep = new ComboBox();
            tb_Timkiem = new TextBox();
            btn_Quanlithongke = new Button();
            btn_Quanlicoso = new Button();
            btn_QLGG = new Button();
            btn_QLNH = new Button();
            btn_QLNV = new Button();
            btn_QLSP = new Button();
            ptb_Quanlisanpham = new PictureBox();
            button1 = new Button();
            grb_Quanlinhanvien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptb_Quanlisanpham).BeginInit();
            SuspendLayout();
            // 
            // grb_Quanlinhanvien
            // 
            grb_Quanlinhanvien.Controls.Add(btn_Themnhanvien);
            grb_Quanlinhanvien.Controls.Add(label1);
            grb_Quanlinhanvien.Controls.Add(button2);
            grb_Quanlinhanvien.Controls.Add(btn_Sua);
            grb_Quanlinhanvien.Controls.Add(dataGridView1);
            grb_Quanlinhanvien.Controls.Add(cmb_Sapxep);
            grb_Quanlinhanvien.Controls.Add(tb_Timkiem);
            grb_Quanlinhanvien.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            grb_Quanlinhanvien.Location = new Point(223, 4);
            grb_Quanlinhanvien.Name = "grb_Quanlinhanvien";
            grb_Quanlinhanvien.Size = new Size(966, 747);
            grb_Quanlinhanvien.TabIndex = 4;
            grb_Quanlinhanvien.TabStop = false;
            // 
            // btn_Themnhanvien
            // 
            btn_Themnhanvien.AutoSize = true;
            btn_Themnhanvien.BackColor = Color.Coral;
            btn_Themnhanvien.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btn_Themnhanvien.FlatAppearance.MouseDownBackColor = Color.Black;
            btn_Themnhanvien.FlatAppearance.MouseOverBackColor = Color.Yellow;
            btn_Themnhanvien.FlatStyle = FlatStyle.Flat;
            btn_Themnhanvien.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Themnhanvien.ForeColor = Color.White;
            btn_Themnhanvien.Location = new Point(665, 136);
            btn_Themnhanvien.Name = "btn_Themnhanvien";
            btn_Themnhanvien.Size = new Size(70, 35);
            btn_Themnhanvien.TabIndex = 17;
            btn_Themnhanvien.Text = "Thêm";
            btn_Themnhanvien.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(201, 26);
            label1.TabIndex = 16;
            label1.Text = "Quản lí nhân viên";
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = Color.Red;
            button2.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            button2.FlatAppearance.MouseDownBackColor = Color.Black;
            button2.FlatAppearance.MouseOverBackColor = Color.Yellow;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(890, 136);
            button2.Name = "button2";
            button2.Size = new Size(70, 35);
            button2.TabIndex = 14;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = false;
            // 
            // btn_Sua
            // 
            btn_Sua.AutoSize = true;
            btn_Sua.BackColor = Color.SandyBrown;
            btn_Sua.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btn_Sua.FlatAppearance.MouseDownBackColor = Color.Black;
            btn_Sua.FlatAppearance.MouseOverBackColor = Color.Yellow;
            btn_Sua.FlatStyle = FlatStyle.Flat;
            btn_Sua.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Sua.ForeColor = Color.White;
            btn_Sua.Location = new Point(779, 136);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(70, 35);
            btn_Sua.TabIndex = 14;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = false;
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
            // cmb_Sapxep
            // 
            cmb_Sapxep.FormattingEnabled = true;
            cmb_Sapxep.Location = new Point(382, 136);
            cmb_Sapxep.Name = "cmb_Sapxep";
            cmb_Sapxep.Size = new Size(151, 28);
            cmb_Sapxep.TabIndex = 12;
            // 
            // tb_Timkiem
            // 
            tb_Timkiem.BackColor = SystemColors.InactiveBorder;
            tb_Timkiem.Location = new Point(6, 136);
            tb_Timkiem.Name = "tb_Timkiem";
            tb_Timkiem.PlaceholderText = "Nhập sản phẩm cần tìm";
            tb_Timkiem.Size = new Size(356, 27);
            tb_Timkiem.TabIndex = 13;
            // 
            // btn_Quanlithongke
            // 
            btn_Quanlithongke.Location = new Point(12, 462);
            btn_Quanlithongke.Name = "btn_Quanlithongke";
            btn_Quanlithongke.Size = new Size(205, 45);
            btn_Quanlithongke.TabIndex = 6;
            btn_Quanlithongke.Text = "Quản lí thống kê";
            btn_Quanlithongke.UseVisualStyleBackColor = true;
            // 
            // btn_Quanlicoso
            // 
            btn_Quanlicoso.Location = new Point(12, 411);
            btn_Quanlicoso.Name = "btn_Quanlicoso";
            btn_Quanlicoso.Size = new Size(205, 45);
            btn_Quanlicoso.TabIndex = 7;
            btn_Quanlicoso.Text = "Quản lí cơ sở";
            btn_Quanlicoso.UseVisualStyleBackColor = true;
            // 
            // btn_QLGG
            // 
            btn_QLGG.Location = new Point(12, 360);
            btn_QLGG.Name = "btn_QLGG";
            btn_QLGG.Size = new Size(205, 45);
            btn_QLGG.TabIndex = 8;
            btn_QLGG.Text = "Quản lí giảm giá";
            btn_QLGG.UseVisualStyleBackColor = true;
            // 
            // btn_QLNH
            // 
            btn_QLNH.Location = new Point(12, 309);
            btn_QLNH.Name = "btn_QLNH";
            btn_QLNH.Size = new Size(205, 45);
            btn_QLNH.TabIndex = 9;
            btn_QLNH.Text = "Quản lí nhập hàng";
            btn_QLNH.UseVisualStyleBackColor = true;
            // 
            // btn_QLNV
            // 
            btn_QLNV.Location = new Point(12, 258);
            btn_QLNV.Name = "btn_QLNV";
            btn_QLNV.Size = new Size(205, 45);
            btn_QLNV.TabIndex = 10;
            btn_QLNV.Text = "Quản lí nhân viên";
            btn_QLNV.UseVisualStyleBackColor = true;
            // 
            // btn_QLSP
            // 
            btn_QLSP.Location = new Point(12, 207);
            btn_QLSP.Name = "btn_QLSP";
            btn_QLSP.Size = new Size(205, 45);
            btn_QLSP.TabIndex = 11;
            btn_QLSP.Text = "Quản lí sản phẩm";
            btn_QLSP.UseVisualStyleBackColor = true;
            // 
            // ptb_Quanlisanpham
            // 
            ptb_Quanlisanpham.BackColor = SystemColors.ActiveCaption;
            ptb_Quanlisanpham.Location = new Point(12, 12);
            ptb_Quanlisanpham.Name = "ptb_Quanlisanpham";
            ptb_Quanlisanpham.Size = new Size(205, 170);
            ptb_Quanlisanpham.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_Quanlisanpham.TabIndex = 5;
            ptb_Quanlisanpham.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(12, 513);
            button1.Name = "button1";
            button1.Size = new Size(205, 45);
            button1.TabIndex = 6;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = true;
            // 
            // Quản_lí_nhân_viên
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1220, 778);
            Controls.Add(button1);
            Controls.Add(btn_Quanlithongke);
            Controls.Add(btn_Quanlicoso);
            Controls.Add(btn_QLGG);
            Controls.Add(btn_QLNH);
            Controls.Add(btn_QLNV);
            Controls.Add(btn_QLSP);
            Controls.Add(ptb_Quanlisanpham);
            Controls.Add(grb_Quanlinhanvien);
            Name = "Quản_lí_nhân_viên";
            Text = "Quản_lí_nhân_viên";
            grb_Quanlinhanvien.ResumeLayout(false);
            grb_Quanlinhanvien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptb_Quanlisanpham).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grb_Quanlinhanvien;
        private DataGridView dataGridView1;
        private Button btn_Quanlithongke;
        private Button btn_Quanlicoso;
        private Button btn_QLGG;
        private Button btn_QLNH;
        private Button btn_QLNV;
        private Button btn_QLSP;
        private PictureBox ptb_Quanlisanpham;
        private Button button1;
        private Label label1;
        private Button btn_Sua;
        private ComboBox cmb_Sapxep;
        private TextBox tb_Timkiem;
        private Button btn_Themnhanvien;
        private Button button2;
    }
}