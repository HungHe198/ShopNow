namespace ShopNow.Source_Code.GUI.VIEWS.Admin
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
            tb_Mota = new TextBox();
            txt_sdt = new TextBox();
            txt_CustomerName = new TextBox();
            txt_diachi = new TextBox();
            txt_email = new TextBox();
            txt_Username = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            lb_Tensanpham = new Label();
            lb_Masanpham = new Label();
            grb_Thongtin = new GroupBox();
            label5 = new Label();
            txt_password = new TextBox();
            btn_luu = new Button();
            label2 = new Label();
            lb_Themsanpham = new Label();
            grb_Thongtin.SuspendLayout();
            SuspendLayout();
            // 
            // tb_Mota
            // 
            tb_Mota.Location = new Point(42, 201);
            tb_Mota.Margin = new Padding(3, 2, 3, 2);
            tb_Mota.Multiline = true;
            tb_Mota.Name = "tb_Mota";
            tb_Mota.Size = new Size(728, 125);
            tb_Mota.TabIndex = 1;
            // 
            // txt_sdt
            // 
            txt_sdt.Location = new Point(52, 149);
            txt_sdt.Margin = new Padding(3, 2, 3, 2);
            txt_sdt.Name = "txt_sdt";
            txt_sdt.Size = new Size(316, 23);
            txt_sdt.TabIndex = 1;
            // 
            // txt_CustomerName
            // 
            txt_CustomerName.Location = new Point(52, 100);
            txt_CustomerName.Margin = new Padding(3, 2, 3, 2);
            txt_CustomerName.Name = "txt_CustomerName";
            txt_CustomerName.Size = new Size(316, 23);
            txt_CustomerName.TabIndex = 1;
            // 
            // txt_diachi
            // 
            txt_diachi.Location = new Point(441, 100);
            txt_diachi.Margin = new Padding(3, 2, 3, 2);
            txt_diachi.Name = "txt_diachi";
            txt_diachi.Size = new Size(316, 23);
            txt_diachi.TabIndex = 1;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(441, 149);
            txt_email.Margin = new Padding(3, 2, 3, 2);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(316, 23);
            txt_email.TabIndex = 1;
            // 
            // txt_Username
            // 
            txt_Username.Location = new Point(52, 52);
            txt_Username.Margin = new Padding(3, 2, 3, 2);
            txt_Username.Name = "txt_Username";
            txt_Username.Size = new Size(316, 23);
            txt_Username.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 239);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "Mô tả";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(441, 83);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 0;
            label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(441, 132);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 0;
            label3.Text = "Email";
            // 
            // lb_Tensanpham
            // 
            lb_Tensanpham.AutoSize = true;
            lb_Tensanpham.Location = new Point(52, 83);
            lb_Tensanpham.Name = "lb_Tensanpham";
            lb_Tensanpham.Size = new Size(90, 15);
            lb_Tensanpham.TabIndex = 0;
            lb_Tensanpham.Text = "Tên khách hàng";
            // 
            // lb_Masanpham
            // 
            lb_Masanpham.AutoSize = true;
            lb_Masanpham.Location = new Point(52, 35);
            lb_Masanpham.Name = "lb_Masanpham";
            lb_Masanpham.Size = new Size(62, 15);
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
            grb_Thongtin.Location = new Point(48, 59);
            grb_Thongtin.Margin = new Padding(3, 2, 3, 2);
            grb_Thongtin.Name = "grb_Thongtin";
            grb_Thongtin.Padding = new Padding(3, 2, 3, 2);
            grb_Thongtin.Size = new Size(836, 394);
            grb_Thongtin.TabIndex = 3;
            grb_Thongtin.TabStop = false;
            grb_Thongtin.Text = "Thông tin";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(438, 33);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 4;
            label5.Text = "Password";
            // 
            // txt_password
            // 
            txt_password.Location = new Point(438, 51);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(319, 23);
            txt_password.TabIndex = 3;
            // 
            // btn_luu
            // 
            btn_luu.Location = new Point(161, 335);
            btn_luu.Margin = new Padding(3, 2, 3, 2);
            btn_luu.Name = "btn_luu";
            btn_luu.Size = new Size(424, 41);
            btn_luu.TabIndex = 2;
            btn_luu.Text = "Lưu";
            btn_luu.UseVisualStyleBackColor = true;
            btn_luu.Click += btn_luu_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 132);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 0;
            label2.Text = "Số điện thoại";
            // 
            // lb_Themsanpham
            // 
            lb_Themsanpham.AutoSize = true;
            lb_Themsanpham.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Themsanpham.Location = new Point(322, 15);
            lb_Themsanpham.Name = "lb_Themsanpham";
            lb_Themsanpham.Size = new Size(219, 32);
            lb_Themsanpham.TabIndex = 2;
            lb_Themsanpham.Text = "Thêm người dùng";
            // 
            // AddCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 468);
            Controls.Add(grb_Thongtin);
            Controls.Add(lb_Themsanpham);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddCustomer";
            Text = "AddCustomer";
            grb_Thongtin.ResumeLayout(false);
            grb_Thongtin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_Mota;
        private TextBox txt_sdt;
        private TextBox txt_CustomerName;
        private TextBox txt_diachi;
        private TextBox txt_email;
        private TextBox txt_Username;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label lb_Tensanpham;
        private Label lb_Masanpham;
        private GroupBox grb_Thongtin;
        private Label lb_Themsanpham;
        private Label label2;
        private Button btn_luu;
        private Label label5;
        private TextBox txt_password;
    }
}