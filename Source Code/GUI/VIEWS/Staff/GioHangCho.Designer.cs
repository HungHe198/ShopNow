namespace ShopNow.Source_Code.GUI.VIEWS.Staff
{
    partial class GioHangCho
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
            tb_Timkiem = new TextBox();
            cmb_Sapxep = new ComboBox();
            dataGridView1 = new DataGridView();
            ptb_Logo = new PictureBox();
            button1 = new Button();
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
            grb_Quanlinhanvien.Controls.Add(tb_Timkiem);
            grb_Quanlinhanvien.Controls.Add(cmb_Sapxep);
            grb_Quanlinhanvien.Controls.Add(dataGridView1);
            grb_Quanlinhanvien.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            grb_Quanlinhanvien.Location = new Point(238, 18);
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
            label1.Size = new Size(250, 25);
            label1.TabIndex = 10;
            label1.Text = "Đơn hàng cần xác nhận";
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
            btn_Them.Text = "Xác nhận";
            btn_Them.UseVisualStyleBackColor = false;
            // 
            // tb_Timkiem
            // 
            tb_Timkiem.BackColor = SystemColors.InactiveBorder;
            tb_Timkiem.Location = new Point(6, 147);
            tb_Timkiem.Name = "tb_Timkiem";
            tb_Timkiem.PlaceholderText = "Nhập để tìm kiếm";
            tb_Timkiem.Size = new Size(356, 25);
            tb_Timkiem.TabIndex = 8;
            // 
            // cmb_Sapxep
            // 
            cmb_Sapxep.FormattingEnabled = true;
            cmb_Sapxep.Location = new Point(396, 147);
            cmb_Sapxep.Name = "cmb_Sapxep";
            cmb_Sapxep.Size = new Size(151, 25);
            cmb_Sapxep.TabIndex = 7;
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
            ptb_Logo.Location = new Point(17, 14);
            ptb_Logo.Name = "ptb_Logo";
            ptb_Logo.Size = new Size(200, 84);
            ptb_Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_Logo.TabIndex = 46;
            ptb_Logo.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(17, 559);
            button1.Name = "button1";
            button1.Size = new Size(205, 45);
            button1.TabIndex = 48;
            button1.Text = "Đơn hàng cần xác nhận";
            button1.UseVisualStyleBackColor = true;
            // 
            // GioHangCho
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1220, 778);
            Controls.Add(grb_Quanlinhanvien);
            Controls.Add(ptb_Logo);
            Controls.Add(button1);
            Name = "GioHangCho";
            Text = "GioHangCho";
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
        private TextBox tb_Timkiem;
        private ComboBox cmb_Sapxep;
        private DataGridView dataGridView1;
        private PictureBox ptb_Logo;
        private Button button1;
    }
}