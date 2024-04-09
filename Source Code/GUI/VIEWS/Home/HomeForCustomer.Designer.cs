namespace ShopNow.Source_Code.GUI.VIEWS.Home
{
    partial class HomeForCustomer
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
            button2 = new Button();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_Display = new TextBox();
            txt_Name = new TextBox();
            ptb_productImage = new PictureBox();
            dgvMainShow = new DataGridView();
            lbNameShop = new Label();
            btn_Seach = new Button();
            textBox1 = new TextBox();
            ptb_Banner = new PictureBox();
            ptb_Logo = new PictureBox();
            txt_Color = new TextBox();
            txt_Quantity = new TextBox();
            btn_Logout = new Button();
            ((System.ComponentModel.ISupportInitialize)ptb_productImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMainShow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptb_Banner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptb_Logo).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(45, 839);
            button2.Name = "button2";
            button2.Size = new Size(111, 66);
            button2.TabIndex = 30;
            button2.Text = "Xem chi tiết";
            button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 783);
            label5.Name = "label5";
            label5.Size = new Size(144, 20);
            label5.TabIndex = 28;
            label5.Text = "Kích thước màn hình";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 725);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 26;
            label3.Text = "Số lượng còn lại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 656);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 25;
            label2.Text = "Màu sắc";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 603);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 24;
            label1.Text = "Tên sản phẩm";
            // 
            // txt_Display
            // 
            txt_Display.Location = new Point(12, 806);
            txt_Display.Name = "txt_Display";
            txt_Display.ReadOnly = true;
            txt_Display.Size = new Size(203, 27);
            txt_Display.TabIndex = 23;
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(12, 626);
            txt_Name.Name = "txt_Name";
            txt_Name.ReadOnly = true;
            txt_Name.Size = new Size(203, 27);
            txt_Name.TabIndex = 18;
            // 
            // ptb_productImage
            // 
            ptb_productImage.Location = new Point(12, 400);
            ptb_productImage.Name = "ptb_productImage";
            ptb_productImage.Size = new Size(200, 200);
            ptb_productImage.TabIndex = 17;
            ptb_productImage.TabStop = false;
            // 
            // dgvMainShow
            // 
            dgvMainShow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMainShow.Location = new Point(237, 400);
            dgvMainShow.Name = "dgvMainShow";
            dgvMainShow.RowHeadersWidth = 51;
            dgvMainShow.RowTemplate.Height = 29;
            dgvMainShow.Size = new Size(1142, 562);
            dgvMainShow.TabIndex = 16;
            // 
            // lbNameShop
            // 
            lbNameShop.AutoSize = true;
            lbNameShop.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbNameShop.Location = new Point(625, 10);
            lbNameShop.Name = "lbNameShop";
            lbNameShop.Size = new Size(305, 81);
            lbNameShop.TabIndex = 14;
            lbNameShop.Text = "ShopNow";
            // 
            // btn_Seach
            // 
            btn_Seach.Location = new Point(1248, 102);
            btn_Seach.Name = "btn_Seach";
            btn_Seach.Size = new Size(131, 36);
            btn_Seach.TabIndex = 13;
            btn_Seach.Text = "Seach";
            btn_Seach.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(237, 103);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1000, 34);
            textBox1.TabIndex = 12;
            // 
            // ptb_Banner
            // 
            ptb_Banner.Image = Properties.Resources.banner;
            ptb_Banner.Location = new Point(237, 143);
            ptb_Banner.Name = "ptb_Banner";
            ptb_Banner.Size = new Size(1139, 251);
            ptb_Banner.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_Banner.TabIndex = 11;
            ptb_Banner.TabStop = false;
            // 
            // ptb_Logo
            // 
            ptb_Logo.BackColor = Color.MistyRose;
            ptb_Logo.Image = Properties.Resources.Logo;
            ptb_Logo.Location = new Point(18, 31);
            ptb_Logo.Name = "ptb_Logo";
            ptb_Logo.Size = new Size(200, 105);
            ptb_Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_Logo.TabIndex = 10;
            ptb_Logo.TabStop = false;
            // 
            // txt_Color
            // 
            txt_Color.Location = new Point(12, 679);
            txt_Color.Name = "txt_Color";
            txt_Color.ReadOnly = true;
            txt_Color.Size = new Size(203, 27);
            txt_Color.TabIndex = 18;
            // 
            // txt_Quantity
            // 
            txt_Quantity.Location = new Point(12, 748);
            txt_Quantity.Name = "txt_Quantity";
            txt_Quantity.ReadOnly = true;
            txt_Quantity.Size = new Size(203, 27);
            txt_Quantity.TabIndex = 18;
            // 
            // btn_Logout
            // 
            btn_Logout.BackColor = Color.Red;
            btn_Logout.ForeColor = Color.White;
            btn_Logout.Location = new Point(1287, 12);
            btn_Logout.Name = "btn_Logout";
            btn_Logout.Size = new Size(92, 32);
            btn_Logout.TabIndex = 31;
            btn_Logout.Text = "Đăng xuất";
            btn_Logout.UseVisualStyleBackColor = false;
            btn_Logout.Click += btn_Logout_Click;
            // 
            // HomeForCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1422, 1055);
            Controls.Add(btn_Logout);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_Display);
            Controls.Add(ptb_productImage);
            Controls.Add(dgvMainShow);
            Controls.Add(txt_Quantity);
            Controls.Add(txt_Color);
            Controls.Add(txt_Name);
            Controls.Add(lbNameShop);
            Controls.Add(btn_Seach);
            Controls.Add(textBox1);
            Controls.Add(ptb_Banner);
            Controls.Add(ptb_Logo);
            Name = "HomeForCustomer";
            Text = "Form1";
            Load += HomeForCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)ptb_productImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMainShow).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptb_Banner).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptb_Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_Display;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private PictureBox ptb_productImage;
        private DataGridView dgvMainShow;
        private TextBox txt_Name;
        private Label lbNameShop;
        private Button btn_Seach;
        private TextBox textBox1;
        private PictureBox ptb_Banner;
        private PictureBox ptb_Logo;
        private TextBox txt_Color;
        private TextBox txt_Quantity;
        private Button btn_Logout;
    }
}