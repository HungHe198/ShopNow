namespace ShopNow.Source_Code.GUI.VIEWS.Admin
{
    partial class Thêm_sản_phẩm
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
            lb_Themsanpham = new Label();
            grb_Thongtin = new GroupBox();
            cmb_Trangthai = new ComboBox();
            tb_Gia = new TextBox();
            tb_Tensanpham = new TextBox();
            tb_Masanpham = new TextBox();
            label1 = new Label();
            lb_Trangthai = new Label();
            label2 = new Label();
            lb_Tensanpham = new Label();
            lb_Masanpham = new Label();
            tb_Mota = new TextBox();
            ptb_Themsanpham = new PictureBox();
            btn_Chonanh = new Button();
            grb_Thongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_Themsanpham).BeginInit();
            SuspendLayout();
            // 
            // lb_Themsanpham
            // 
            lb_Themsanpham.AutoSize = true;
            lb_Themsanpham.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lb_Themsanpham.Location = new Point(377, 28);
            lb_Themsanpham.Name = "lb_Themsanpham";
            lb_Themsanpham.Size = new Size(243, 41);
            lb_Themsanpham.TabIndex = 0;
            lb_Themsanpham.Text = "Thêm sản phẩm";
            // 
            // grb_Thongtin
            // 
            grb_Thongtin.Controls.Add(btn_Chonanh);
            grb_Thongtin.Controls.Add(ptb_Themsanpham);
            grb_Thongtin.Controls.Add(cmb_Trangthai);
            grb_Thongtin.Controls.Add(tb_Mota);
            grb_Thongtin.Controls.Add(tb_Gia);
            grb_Thongtin.Controls.Add(tb_Tensanpham);
            grb_Thongtin.Controls.Add(tb_Masanpham);
            grb_Thongtin.Controls.Add(label1);
            grb_Thongtin.Controls.Add(lb_Trangthai);
            grb_Thongtin.Controls.Add(label2);
            grb_Thongtin.Controls.Add(lb_Tensanpham);
            grb_Thongtin.Controls.Add(lb_Masanpham);
            grb_Thongtin.Location = new Point(64, 87);
            grb_Thongtin.Name = "grb_Thongtin";
            grb_Thongtin.Size = new Size(955, 525);
            grb_Thongtin.TabIndex = 1;
            grb_Thongtin.TabStop = false;
            grb_Thongtin.Text = "Thông tin";
            // 
            // cmb_Trangthai
            // 
            cmb_Trangthai.FormattingEnabled = true;
            cmb_Trangthai.Location = new Point(59, 269);
            cmb_Trangthai.Name = "cmb_Trangthai";
            cmb_Trangthai.Size = new Size(270, 28);
            cmb_Trangthai.TabIndex = 2;
            // 
            // tb_Gia
            // 
            tb_Gia.Location = new Point(59, 199);
            tb_Gia.Name = "tb_Gia";
            tb_Gia.Size = new Size(270, 27);
            tb_Gia.TabIndex = 1;
            // 
            // tb_Tensanpham
            // 
            tb_Tensanpham.Location = new Point(59, 134);
            tb_Tensanpham.Name = "tb_Tensanpham";
            tb_Tensanpham.Size = new Size(270, 27);
            tb_Tensanpham.TabIndex = 1;
            // 
            // tb_Masanpham
            // 
            tb_Masanpham.Location = new Point(59, 70);
            tb_Masanpham.Name = "tb_Masanpham";
            tb_Masanpham.Size = new Size(270, 27);
            tb_Masanpham.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 319);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 0;
            label1.Text = "Mô tả";
            // 
            // lb_Trangthai
            // 
            lb_Trangthai.AutoSize = true;
            lb_Trangthai.Location = new Point(59, 246);
            lb_Trangthai.Name = "lb_Trangthai";
            lb_Trangthai.Size = new Size(75, 20);
            lb_Trangthai.TabIndex = 0;
            lb_Trangthai.Text = "Trạng thái";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 176);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 0;
            label2.Text = "Giá";
            // 
            // lb_Tensanpham
            // 
            lb_Tensanpham.AutoSize = true;
            lb_Tensanpham.Location = new Point(59, 111);
            lb_Tensanpham.Name = "lb_Tensanpham";
            lb_Tensanpham.Size = new Size(100, 20);
            lb_Tensanpham.TabIndex = 0;
            lb_Tensanpham.Text = "Tên sản phẩm";
            // 
            // lb_Masanpham
            // 
            lb_Masanpham.AutoSize = true;
            lb_Masanpham.Location = new Point(59, 47);
            lb_Masanpham.Name = "lb_Masanpham";
            lb_Masanpham.Size = new Size(98, 20);
            lb_Masanpham.TabIndex = 0;
            lb_Masanpham.Text = "Mã sản phẩm";
            // 
            // tb_Mota
            // 
            tb_Mota.Location = new Point(59, 342);
            tb_Mota.Multiline = true;
            tb_Mota.Name = "tb_Mota";
            tb_Mota.Size = new Size(832, 165);
            tb_Mota.TabIndex = 1;
            // 
            // ptb_Themsanpham
            // 
            ptb_Themsanpham.BackColor = SystemColors.ActiveCaption;
            ptb_Themsanpham.Location = new Point(578, 70);
            ptb_Themsanpham.Name = "ptb_Themsanpham";
            ptb_Themsanpham.Size = new Size(278, 196);
            ptb_Themsanpham.TabIndex = 3;
            ptb_Themsanpham.TabStop = false;
            // 
            // btn_Chonanh
            // 
            btn_Chonanh.Location = new Point(673, 287);
            btn_Chonanh.Name = "btn_Chonanh";
            btn_Chonanh.Size = new Size(94, 29);
            btn_Chonanh.TabIndex = 4;
            btn_Chonanh.Text = "Chọn ảnh";
            btn_Chonanh.UseVisualStyleBackColor = true;
            // 
            // Thêm_sản_phẩm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 624);
            Controls.Add(grb_Thongtin);
            Controls.Add(lb_Themsanpham);
            Name = "Thêm_sản_phẩm";
            Text = "Thêm_sản_phẩm";
            grb_Thongtin.ResumeLayout(false);
            grb_Thongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_Themsanpham).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_Themsanpham;
        private GroupBox grb_Thongtin;
        private Label lb_Masanpham;
        private ComboBox cmb_Trangthai;
        private TextBox tb_Gia;
        private TextBox tb_Tensanpham;
        private TextBox tb_Masanpham;
        private Label label1;
        private Label lb_Trangthai;
        private Label label2;
        private Label lb_Tensanpham;
        private TextBox tb_Mota;
        private Button btn_Chonanh;
        private PictureBox ptb_Themsanpham;
    }
}