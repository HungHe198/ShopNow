namespace ShopNow.Source_Code.GUI.Doanhthu
{
    partial class ProductDetail
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
            lbNameShop = new Label();
            btn_Seach = new Button();
            textBox1 = new TextBox();
            ptb_Logo = new PictureBox();
            lb_Name = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            lb_describe = new Label();
            label5 = new Label();
            label7 = new Label();
            label1 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox6 = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)ptb_Logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lbNameShop
            // 
            lbNameShop.AutoSize = true;
            lbNameShop.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbNameShop.Location = new Point(609, -7);
            lbNameShop.Name = "lbNameShop";
            lbNameShop.Size = new Size(305, 81);
            lbNameShop.TabIndex = 11;
            lbNameShop.Text = "ShopNow";
            // 
            // btn_Seach
            // 
            btn_Seach.Location = new Point(1232, 75);
            btn_Seach.Name = "btn_Seach";
            btn_Seach.Size = new Size(131, 36);
            btn_Seach.TabIndex = 10;
            btn_Seach.Text = "Seach";
            btn_Seach.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(221, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1000, 34);
            textBox1.TabIndex = 9;
            // 
            // ptb_Logo
            // 
            ptb_Logo.BackColor = Color.Yellow;
            ptb_Logo.Location = new Point(12, 5);
            ptb_Logo.Name = "ptb_Logo";
            ptb_Logo.Size = new Size(200, 106);
            ptb_Logo.TabIndex = 8;
            ptb_Logo.TabStop = false;
            // 
            // lb_Name
            // 
            lb_Name.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Name.Location = new Point(221, 149);
            lb_Name.Name = "lb_Name";
            lb_Name.Size = new Size(1149, 41);
            lb_Name.TabIndex = 12;
            lb_Name.Text = "(No Name)";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.MediumAquamarine;
            pictureBox1.Image = Properties.Resources.Iphone11Pro;
            pictureBox1.Location = new Point(221, 193);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(475, 549);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 255, 128);
            groupBox1.Controls.Add(lb_describe);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox8);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(754, 190);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(616, 552);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm";
            // 
            // lb_describe
            // 
            lb_describe.Location = new Point(37, 427);
            lb_describe.Name = "lb_describe";
            lb_describe.Size = new Size(545, 98);
            lb_describe.TabIndex = 2;
            lb_describe.Text = "Chi tiết mô tả";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(330, 210);
            label5.Name = "label5";
            label5.Size = new Size(51, 28);
            label5.TabIndex = 1;
            label5.Text = "Ram";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(330, 302);
            label7.Name = "label7";
            label7.Size = new Size(154, 28);
            label7.TabIndex = 1;
            label7.Text = "Số lượng còn lại";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(35, 388);
            label1.Name = "label1";
            label1.Size = new Size(64, 28);
            label1.TabIndex = 1;
            label1.Text = "Mô tả";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(37, 302);
            label6.Name = "label6";
            label6.Size = new Size(191, 28);
            label6.TabIndex = 1;
            label6.Text = "Kích thước màn hình";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(37, 210);
            label4.Name = "label4";
            label4.Size = new Size(185, 28);
            label4.TabIndex = 1;
            label4.Text = "Dung lượng bộ nhớ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(35, 125);
            label3.Name = "label3";
            label3.Size = new Size(52, 28);
            label3.TabIndex = 1;
            label3.Text = "Chip";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(39, 37);
            label2.Name = "label2";
            label2.Size = new Size(83, 28);
            label2.TabIndex = 1;
            label2.Text = "Màu sắc";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(330, 244);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(252, 34);
            textBox6.TabIndex = 0;
            // 
            // textBox8
            // 
            textBox8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox8.Location = new Point(330, 336);
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(252, 34);
            textBox8.TabIndex = 0;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.Location = new Point(37, 336);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(252, 34);
            textBox7.TabIndex = 0;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(37, 244);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(252, 34);
            textBox5.TabIndex = 0;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(35, 156);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(547, 34);
            textBox4.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(37, 71);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(545, 34);
            textBox3.TabIndex = 0;
            // 
            // ProductDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(1395, 775);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(lb_Name);
            Controls.Add(lbNameShop);
            Controls.Add(btn_Seach);
            Controls.Add(textBox1);
            Controls.Add(ptb_Logo);
            Name = "ProductDetail";
            Text = " ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ptb_Logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNameShop;
        private Button btn_Seach;
        private TextBox textBox1;
        private PictureBox ptb_Logo;
        private Label lb_Name;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label5;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox6;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label lb_describe;
        private Label label1;
    }
}