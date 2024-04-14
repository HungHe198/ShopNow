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
            Btn_Save = new Button();
            tb_Mota = new TextBox();
            txt_Gia = new TextBox();
            txt_Tensanpham = new TextBox();
            txtChip = new TextBox();
            txt_quantity = new TextBox();
            txt_Masanpham = new TextBox();
            label1 = new Label();
            Chip = new Label();
            label2 = new Label();
            label3 = new Label();
            lb_Tensanpham = new Label();
            lb_Masanpham = new Label();
            grb_Thongtin.SuspendLayout();
            SuspendLayout();
            // 
            // lb_Themsanpham
            // 
            lb_Themsanpham.AutoSize = true;
            lb_Themsanpham.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Themsanpham.Location = new Point(377, 28);
            lb_Themsanpham.Name = "lb_Themsanpham";
            lb_Themsanpham.Size = new Size(240, 41);
            lb_Themsanpham.TabIndex = 0;
            lb_Themsanpham.Text = "Thêm sản phẩm";
            // 
            // grb_Thongtin
            // 
            grb_Thongtin.Controls.Add(Btn_Save);
            grb_Thongtin.Controls.Add(tb_Mota);
            grb_Thongtin.Controls.Add(txt_Gia);
            grb_Thongtin.Controls.Add(txt_Tensanpham);
            grb_Thongtin.Controls.Add(txtChip);
            grb_Thongtin.Controls.Add(txt_quantity);
            grb_Thongtin.Controls.Add(txt_Masanpham);
            grb_Thongtin.Controls.Add(label1);
            grb_Thongtin.Controls.Add(Chip);
            grb_Thongtin.Controls.Add(label2);
            grb_Thongtin.Controls.Add(label3);
            grb_Thongtin.Controls.Add(lb_Tensanpham);
            grb_Thongtin.Controls.Add(lb_Masanpham);
            grb_Thongtin.Location = new Point(64, 87);
            grb_Thongtin.Name = "grb_Thongtin";
            grb_Thongtin.Size = new Size(955, 525);
            grb_Thongtin.TabIndex = 1;
            grb_Thongtin.TabStop = false;
            grb_Thongtin.Text = "Thông tin";
            // 
            // Btn_Save
            // 
            Btn_Save.Location = new Point(295, 445);
            Btn_Save.Name = "Btn_Save";
            Btn_Save.Size = new Size(341, 52);
            Btn_Save.TabIndex = 2;
            Btn_Save.Text = "Lưu";
            Btn_Save.UseVisualStyleBackColor = true;
            Btn_Save.Click += Btn_Save_Click;
            // 
            // tb_Mota
            // 
            tb_Mota.Location = new Point(59, 256);
            tb_Mota.Multiline = true;
            tb_Mota.Name = "tb_Mota";
            tb_Mota.Size = new Size(832, 165);
            tb_Mota.TabIndex = 1;
            // 
            // txt_Gia
            // 
            txt_Gia.Location = new Point(59, 199);
            txt_Gia.Name = "txt_Gia";
            txt_Gia.Size = new Size(361, 27);
            txt_Gia.TabIndex = 1;
            // 
            // txt_Tensanpham
            // 
            txt_Tensanpham.Location = new Point(59, 134);
            txt_Tensanpham.Name = "txt_Tensanpham";
            txt_Tensanpham.Size = new Size(361, 27);
            txt_Tensanpham.TabIndex = 1;
            // 
            // txtChip
            // 
            txtChip.Location = new Point(504, 134);
            txtChip.Name = "txtChip";
            txtChip.Size = new Size(361, 27);
            txtChip.TabIndex = 1;
            // 
            // txt_quantity
            // 
            txt_quantity.Location = new Point(504, 70);
            txt_quantity.Name = "txt_quantity";
            txt_quantity.Size = new Size(361, 27);
            txt_quantity.TabIndex = 1;
            // 
            // txt_Masanpham
            // 
            txt_Masanpham.Location = new Point(59, 70);
            txt_Masanpham.Name = "txt_Masanpham";
            txt_Masanpham.Size = new Size(361, 27);
            txt_Masanpham.TabIndex = 1;
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
            // Chip
            // 
            Chip.AutoSize = true;
            Chip.Location = new Point(504, 111);
            Chip.Name = "Chip";
            Chip.Size = new Size(39, 20);
            Chip.TabIndex = 0;
            Chip.Text = "Chip";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(504, 47);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 0;
            label3.Text = "Số lượng";
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
            // Thêm_sản_phẩm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 624);
            Controls.Add(grb_Thongtin);
            Controls.Add(lb_Themsanpham);
            Name = "Thêm_sản_phẩm";
            Text = "Thêm_sản_phẩm";
            Load += Thêm_sản_phẩm_Load;
            grb_Thongtin.ResumeLayout(false);
            grb_Thongtin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_Themsanpham;
        private GroupBox grb_Thongtin;
        private Label lb_Masanpham;
        private ComboBox cmb_Trangthai;
        private TextBox txt_Gia;
        private TextBox txt_Tensanpham;
        private TextBox txt_Masanpham;
        private Label label1;
        private Label lb_Trangthai;
        private Label label2;
        private Label lb_Tensanpham;
        private TextBox tb_Mota;
        private Button btn_Chonanh;
        private TextBox txtChip;
        private TextBox txt_quantity;
        private Label Chip;
        private Label label3;
        private Button Btn_Save;
    }
}