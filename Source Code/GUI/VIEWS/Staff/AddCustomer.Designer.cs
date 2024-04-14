namespace ShopNow.Source_Code.GUI.VIEWS.Staff
{
    partial class AddCustomer
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
            label5 = new Label();
            txt_password = new TextBox();
            btn_luu = new Button();
            tb_Mota = new TextBox();
            txt_sdt = new TextBox();
            txt_CustomerName = new TextBox();
            txt_diachi = new TextBox();
            txt_email = new TextBox();
            txt_Username = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            lb_Tensanpham = new Label();
            lb_Masanpham = new Label();
            grb_Thongtin = new GroupBox();
            grb_Thongtin.SuspendLayout();
            SuspendLayout();
            // 
            // lb_Themsanpham
            // 
            lb_Themsanpham.AutoSize = true;
            lb_Themsanpham.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Themsanpham.Location = new Point(368, 20);
            lb_Themsanpham.Name = "lb_Themsanpham";
            lb_Themsanpham.Size = new Size(272, 41);
            lb_Themsanpham.TabIndex = 4;
            lb_Themsanpham.Text = "Thêm người dùng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(501, 44);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 4;
            label5.Text = "Password";
            // 
            // txt_password
            // 
            txt_password.Location = new Point(501, 68);
            txt_password.Margin = new Padding(3, 4, 3, 4);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(364, 27);
            txt_password.TabIndex = 3;
            // 
            // btn_luu
            // 
            btn_luu.Location = new Point(184, 447);
            btn_luu.Name = "btn_luu";
            btn_luu.Size = new Size(485, 55);
            btn_luu.TabIndex = 2;
            btn_luu.Text = "Lưu";
            btn_luu.UseVisualStyleBackColor = true;
            btn_luu.Click += btn_luu_Click;
            // 
            // tb_Mota
            // 
            tb_Mota.Location = new Point(48, 268);
            tb_Mota.Multiline = true;
            tb_Mota.Name = "tb_Mota";
            tb_Mota.Size = new Size(831, 165);
            tb_Mota.TabIndex = 1;
            // 
            // txt_sdt
            // 
            txt_sdt.Location = new Point(59, 199);
            txt_sdt.Name = "txt_sdt";
            txt_sdt.Size = new Size(361, 27);
            txt_sdt.TabIndex = 1;
            // 
            // txt_CustomerName
            // 
            txt_CustomerName.Location = new Point(59, 133);
            txt_CustomerName.Name = "txt_CustomerName";
            txt_CustomerName.Size = new Size(361, 27);
            txt_CustomerName.TabIndex = 1;
            // 
            // txt_diachi
            // 
            txt_diachi.Location = new Point(504, 133);
            txt_diachi.Name = "txt_diachi";
            txt_diachi.Size = new Size(361, 27);
            txt_diachi.TabIndex = 1;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(504, 199);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(361, 27);
            txt_email.TabIndex = 1;
            // 
            // txt_Username
            // 
            txt_Username.Location = new Point(59, 69);
            txt_Username.Name = "txt_Username";
            txt_Username.Size = new Size(361, 27);
            txt_Username.TabIndex = 1;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(504, 111);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 0;
            label4.Text = "Địa chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 176);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 0;
            label2.Text = "Số điện thoại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(504, 176);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 0;
            label3.Text = "Email";
            // 
            // lb_Tensanpham
            // 
            lb_Tensanpham.AutoSize = true;
            lb_Tensanpham.Location = new Point(59, 111);
            lb_Tensanpham.Name = "lb_Tensanpham";
            lb_Tensanpham.Size = new Size(111, 20);
            lb_Tensanpham.TabIndex = 0;
            lb_Tensanpham.Text = "Tên khách hàng";
            // 
            // lb_Masanpham
            // 
            lb_Masanpham.AutoSize = true;
            lb_Masanpham.Location = new Point(59, 47);
            lb_Masanpham.Name = "lb_Masanpham";
            lb_Masanpham.Size = new Size(78, 20);
            lb_Masanpham.TabIndex = 0;
            lb_Masanpham.Text = "UserName";
            // 
            // grb_Thongtin
            // 
            grb_Thongtin.Controls.Add(label5);
            grb_Thongtin.Controls.Add(txt_password);
            grb_Thongtin.Controls.Add(btn_luu);
            grb_Thongtin.Controls.Add(tb_Mota);
            grb_Thongtin.Controls.Add(txt_sdt);
            grb_Thongtin.Controls.Add(txt_CustomerName);
            grb_Thongtin.Controls.Add(txt_diachi);
            grb_Thongtin.Controls.Add(txt_email);
            grb_Thongtin.Controls.Add(txt_Username);
            grb_Thongtin.Controls.Add(label1);
            grb_Thongtin.Controls.Add(label4);
            grb_Thongtin.Controls.Add(label2);
            grb_Thongtin.Controls.Add(label3);
            grb_Thongtin.Controls.Add(lb_Tensanpham);
            grb_Thongtin.Controls.Add(lb_Masanpham);
            grb_Thongtin.Location = new Point(55, 79);
            grb_Thongtin.Name = "grb_Thongtin";
            grb_Thongtin.Size = new Size(955, 525);
            grb_Thongtin.TabIndex = 5;
            grb_Thongtin.TabStop = false;
            grb_Thongtin.Text = "Thông tin";
            // 
            // AddCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 624);
            Controls.Add(lb_Themsanpham);
            Controls.Add(grb_Thongtin);
            Name = "AddCustomer";
            Text = "AddCustomer";
            grb_Thongtin.ResumeLayout(false);
            grb_Thongtin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_Themsanpham;
        private Label label5;
        private TextBox txt_password;
        private Button btn_luu;
        private TextBox tb_Mota;
        private TextBox txt_sdt;
        private TextBox txt_CustomerName;
        private TextBox txt_diachi;
        private TextBox txt_email;
        private TextBox txt_Username;
        private Label label1;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label lb_Tensanpham;
        private Label lb_Masanpham;
        private GroupBox grb_Thongtin;
    }
}