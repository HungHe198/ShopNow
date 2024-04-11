namespace ShopNow.Source_Code.GUI.VIEWS.Admin
{
    partial class AddFacility
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
            lb_Masanpham = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            txt_Username = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            tb_Gia = new TextBox();
            button1 = new Button();
            grb_Thongtin = new GroupBox();
            grb_Thongtin.SuspendLayout();
            SuspendLayout();
            // 
            // lb_Themsanpham
            // 
            lb_Themsanpham.AutoSize = true;
            lb_Themsanpham.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Themsanpham.Location = new Point(324, 20);
            lb_Themsanpham.Name = "lb_Themsanpham";
            lb_Themsanpham.Size = new Size(178, 41);
            lb_Themsanpham.TabIndex = 4;
            lb_Themsanpham.Text = "Thêm cơ sở";
            // 
            // lb_Masanpham
            // 
            lb_Masanpham.AutoSize = true;
            lb_Masanpham.Location = new Point(50, 33);
            lb_Masanpham.Name = "lb_Masanpham";
            lb_Masanpham.Size = new Size(71, 20);
            lb_Masanpham.TabIndex = 0;
            lb_Masanpham.Text = "Tên cơ sở";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(424, 33);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 0;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 97);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 0;
            label2.Text = "Số điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(424, 97);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 0;
            label4.Text = "Địa chỉ";
            // 
            // txt_Username
            // 
            txt_Username.Location = new Point(50, 56);
            txt_Username.Name = "txt_Username";
            txt_Username.Size = new Size(361, 27);
            txt_Username.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(424, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(361, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(424, 120);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(361, 27);
            textBox2.TabIndex = 1;
            // 
            // tb_Gia
            // 
            tb_Gia.Location = new Point(50, 120);
            tb_Gia.Name = "tb_Gia";
            tb_Gia.Size = new Size(361, 27);
            tb_Gia.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(285, 213);
            button1.Name = "button1";
            button1.Size = new Size(216, 55);
            button1.TabIndex = 2;
            button1.Text = "Lưu";
            button1.UseVisualStyleBackColor = true;
            // 
            // grb_Thongtin
            // 
            grb_Thongtin.Controls.Add(button1);
            grb_Thongtin.Controls.Add(tb_Gia);
            grb_Thongtin.Controls.Add(textBox2);
            grb_Thongtin.Controls.Add(textBox1);
            grb_Thongtin.Controls.Add(txt_Username);
            grb_Thongtin.Controls.Add(label4);
            grb_Thongtin.Controls.Add(label2);
            grb_Thongtin.Controls.Add(label3);
            grb_Thongtin.Controls.Add(lb_Masanpham);
            grb_Thongtin.Location = new Point(23, 64);
            grb_Thongtin.Name = "grb_Thongtin";
            grb_Thongtin.Size = new Size(806, 313);
            grb_Thongtin.TabIndex = 5;
            grb_Thongtin.TabStop = false;
            grb_Thongtin.Text = "Thêm cơ sở";
            // 
            // AddFacility
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 410);
            Controls.Add(lb_Themsanpham);
            Controls.Add(grb_Thongtin);
            Name = "AddFacility";
            Text = "AddFacility";
            grb_Thongtin.ResumeLayout(false);
            grb_Thongtin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lb_Themsanpham;
        private Label lb_Masanpham;
        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox txt_Username;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox tb_Gia;
        private Button button1;
        private GroupBox grb_Thongtin;
    }
}