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
            tb_Gia = new TextBox();
            txt_CustomerName = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            txt_Username = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            lb_Tensanpham = new Label();
            lb_Masanpham = new Label();
            grb_Thongtin = new GroupBox();
            lb_Themsanpham = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            grb_Thongtin.SuspendLayout();
            SuspendLayout();
            // 
            // tb_Mota
            // 
            tb_Mota.Location = new Point(48, 268);
            tb_Mota.Multiline = true;
            tb_Mota.Name = "tb_Mota";
            tb_Mota.Size = new Size(832, 165);
            tb_Mota.TabIndex = 1;
            // 
            // tb_Gia
            // 
            tb_Gia.Location = new Point(59, 199);
            tb_Gia.Name = "tb_Gia";
            tb_Gia.Size = new Size(361, 27);
            tb_Gia.TabIndex = 1;
            // 
            // txt_CustomerName
            // 
            txt_CustomerName.Location = new Point(59, 134);
            txt_CustomerName.Name = "txt_CustomerName";
            txt_CustomerName.Size = new Size(361, 27);
            txt_CustomerName.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(504, 134);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(361, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(504, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(361, 27);
            textBox1.TabIndex = 1;
            // 
            // txt_Username
            // 
            txt_Username.Location = new Point(59, 70);
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(504, 47);
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
            grb_Thongtin.Controls.Add(button1);
            grb_Thongtin.Controls.Add(tb_Mota);
            grb_Thongtin.Controls.Add(tb_Gia);
            grb_Thongtin.Controls.Add(txt_CustomerName);
            grb_Thongtin.Controls.Add(textBox3);
            grb_Thongtin.Controls.Add(textBox2);
            grb_Thongtin.Controls.Add(textBox1);
            grb_Thongtin.Controls.Add(txt_Username);
            grb_Thongtin.Controls.Add(label5);
            grb_Thongtin.Controls.Add(label1);
            grb_Thongtin.Controls.Add(label4);
            grb_Thongtin.Controls.Add(label2);
            grb_Thongtin.Controls.Add(label3);
            grb_Thongtin.Controls.Add(lb_Tensanpham);
            grb_Thongtin.Controls.Add(lb_Masanpham);
            grb_Thongtin.Location = new Point(55, 79);
            grb_Thongtin.Name = "grb_Thongtin";
            grb_Thongtin.Size = new Size(955, 525);
            grb_Thongtin.TabIndex = 3;
            grb_Thongtin.TabStop = false;
            grb_Thongtin.Text = "Thông tin";
            // 
            // lb_Themsanpham
            // 
            lb_Themsanpham.AutoSize = true;
            lb_Themsanpham.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Themsanpham.Location = new Point(368, 20);
            lb_Themsanpham.Name = "lb_Themsanpham";
            lb_Themsanpham.Size = new Size(272, 41);
            lb_Themsanpham.TabIndex = 2;
            lb_Themsanpham.Text = "Thêm người dùng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(504, 176);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 0;
            label5.Text = "Source ảnh";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(504, 199);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(361, 27);
            textBox3.TabIndex = 1;
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
            // button1
            // 
            button1.Location = new Point(184, 447);
            button1.Name = "button1";
            button1.Size = new Size(485, 55);
            button1.TabIndex = 2;
            button1.Text = "Lưu";
            button1.UseVisualStyleBackColor = true;
            // 
            // AddCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 624);
            Controls.Add(grb_Thongtin);
            Controls.Add(lb_Themsanpham);
            Name = "AddCustomer";
            Text = "AddCustomer";
            grb_Thongtin.ResumeLayout(false);
            grb_Thongtin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_Mota;
        private TextBox tb_Gia;
        private TextBox txt_CustomerName;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox txt_Username;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label lb_Tensanpham;
        private Label lb_Masanpham;
        private GroupBox grb_Thongtin;
        private TextBox textBox3;
        private Label label5;
        private Label lb_Themsanpham;
        private Label label2;
        private Button button1;
    }
}