namespace ShopNow.Source_Code.GUI.Thongke
{
    partial class HomeForAdmin
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
            ptb_Logo = new PictureBox();
            ptb_Banner = new PictureBox();
            textBox1 = new TextBox();
            btn_Seach = new Button();
            lbNameShop = new Label();
            groupBox1 = new GroupBox();
            btn_management = new Button();
            btn_information = new Button();
            ptb_admin = new PictureBox();
            dgvMainShow = new DataGridView();
            ptb_productImage = new PictureBox();
            txt_Name = new TextBox();
            txt_Color = new TextBox();
            txt_Quantity = new TextBox();
            txt_Ram = new TextBox();
            txt_Display = new TextBox();
            txt_SoucreImage = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)ptb_Logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptb_Banner).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_admin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMainShow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptb_productImage).BeginInit();
            SuspendLayout();
            // 
            // ptb_Logo
            // 
            ptb_Logo.Location = new Point(25, 30);
            ptb_Logo.Name = "ptb_Logo";
            ptb_Logo.Size = new Size(215, 106);
            ptb_Logo.TabIndex = 0;
            ptb_Logo.TabStop = false;
            // 
            // ptb_Banner
            // 
            ptb_Banner.Location = new Point(244, 142);
            ptb_Banner.Name = "ptb_Banner";
            ptb_Banner.Size = new Size(1139, 247);
            ptb_Banner.TabIndex = 0;
            ptb_Banner.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(244, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1000, 34);
            textBox1.TabIndex = 1;
            // 
            // btn_Seach
            // 
            btn_Seach.Location = new Point(1255, 101);
            btn_Seach.Name = "btn_Seach";
            btn_Seach.Size = new Size(131, 36);
            btn_Seach.TabIndex = 2;
            btn_Seach.Text = "Seach";
            btn_Seach.UseVisualStyleBackColor = true;
            // 
            // lbNameShop
            // 
            lbNameShop.AutoSize = true;
            lbNameShop.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbNameShop.Location = new Point(632, 9);
            lbNameShop.Name = "lbNameShop";
            lbNameShop.Size = new Size(305, 81);
            lbNameShop.TabIndex = 3;
            lbNameShop.Text = "ShopNow";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_management);
            groupBox1.Controls.Add(btn_information);
            groupBox1.Controls.Add(ptb_admin);
            groupBox1.Location = new Point(22, 140);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(215, 250);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản lí hệ thống";
            // 
            // btn_management
            // 
            btn_management.Location = new Point(22, 171);
            btn_management.Name = "btn_management";
            btn_management.Size = new Size(170, 54);
            btn_management.TabIndex = 1;
            btn_management.Text = "Hệ thống quản lí";
            btn_management.UseVisualStyleBackColor = true;
            // 
            // btn_information
            // 
            btn_information.Location = new Point(22, 111);
            btn_information.Name = "btn_information";
            btn_information.Size = new Size(170, 54);
            btn_information.TabIndex = 1;
            btn_information.Text = "Thông tin cá nhân";
            btn_information.UseVisualStyleBackColor = true;
            // 
            // ptb_admin
            // 
            ptb_admin.Location = new Point(54, 26);
            ptb_admin.Name = "ptb_admin";
            ptb_admin.Size = new Size(105, 79);
            ptb_admin.TabIndex = 0;
            ptb_admin.TabStop = false;
            // 
            // dgvMainShow
            // 
            dgvMainShow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMainShow.Location = new Point(244, 414);
            dgvMainShow.Name = "dgvMainShow";
            dgvMainShow.RowHeadersWidth = 51;
            dgvMainShow.RowTemplate.Height = 29;
            dgvMainShow.Size = new Size(1142, 629);
            dgvMainShow.TabIndex = 5;
            // 
            // ptb_productImage
            // 
            ptb_productImage.Location = new Point(25, 414);
            ptb_productImage.Name = "ptb_productImage";
            ptb_productImage.Size = new Size(200, 200);
            ptb_productImage.TabIndex = 6;
            ptb_productImage.TabStop = false;
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(22, 643);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(203, 27);
            txt_Name.TabIndex = 7;
            txt_Name.TextChanged += textBox2_TextChanged;
            // 
            // txt_Color
            // 
            txt_Color.Location = new Point(22, 698);
            txt_Color.Name = "txt_Color";
            txt_Color.Size = new Size(203, 27);
            txt_Color.TabIndex = 7;
            txt_Color.TextChanged += textBox2_TextChanged;
            // 
            // txt_Quantity
            // 
            txt_Quantity.Location = new Point(22, 753);
            txt_Quantity.Name = "txt_Quantity";
            txt_Quantity.ReadOnly = true;
            txt_Quantity.Size = new Size(203, 27);
            txt_Quantity.TabIndex = 7;
            txt_Quantity.TextChanged += textBox2_TextChanged;
            // 
            // txt_Ram
            // 
            txt_Ram.Location = new Point(22, 810);
            txt_Ram.Name = "txt_Ram";
            txt_Ram.Size = new Size(203, 27);
            txt_Ram.TabIndex = 7;
            txt_Ram.TextChanged += textBox2_TextChanged;
            // 
            // txt_Display
            // 
            txt_Display.Location = new Point(22, 873);
            txt_Display.Name = "txt_Display";
            txt_Display.Size = new Size(203, 27);
            txt_Display.TabIndex = 7;
            txt_Display.TextChanged += textBox2_TextChanged;
            // 
            // txt_SoucreImage
            // 
            txt_SoucreImage.Location = new Point(22, 933);
            txt_SoucreImage.Name = "txt_SoucreImage";
            txt_SoucreImage.Size = new Size(203, 27);
            txt_SoucreImage.TabIndex = 7;
            txt_SoucreImage.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 620);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 8;
            label1.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 673);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 8;
            label2.Text = "Màu sắc";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 728);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 8;
            label3.Text = "Số lượng còn lại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 783);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 8;
            label4.Text = "Ram";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 850);
            label5.Name = "label5";
            label5.Size = new Size(144, 20);
            label5.TabIndex = 8;
            label5.Text = "Kích thước màn hình";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 910);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 8;
            label6.Text = "Source ảnh";
            // 
            // button2
            // 
            button2.Location = new Point(22, 983);
            button2.Name = "button2";
            button2.Size = new Size(108, 60);
            button2.TabIndex = 9;
            button2.Text = "Xem chi tiết";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(136, 983);
            button1.Name = "button1";
            button1.Size = new Size(89, 60);
            button1.TabIndex = 9;
            button1.Text = "Lưu";
            button1.UseVisualStyleBackColor = true;
            // 
            // HomeForAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(1395, 1055);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_SoucreImage);
            Controls.Add(txt_Display);
            Controls.Add(txt_Ram);
            Controls.Add(txt_Quantity);
            Controls.Add(txt_Color);
            Controls.Add(txt_Name);
            Controls.Add(ptb_productImage);
            Controls.Add(dgvMainShow);
            Controls.Add(groupBox1);
            Controls.Add(lbNameShop);
            Controls.Add(btn_Seach);
            Controls.Add(textBox1);
            Controls.Add(ptb_Banner);
            Controls.Add(ptb_Logo);
            Name = "HomeForAdmin";
            Text = "Form1";
            Load += HomeForAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)ptb_Logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptb_Banner).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptb_admin).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMainShow).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptb_productImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ptb_Logo;
        private PictureBox ptb_Banner;
        private TextBox textBox1;
        private Button btn_Seach;
        private Label lbNameShop;
        private GroupBox groupBox1;
        private Button btn_management;
        private Button btn_information;
        private PictureBox ptb_admin;
        private DataGridView dgvMainShow;
        private PictureBox ptb_productImage;
        private TextBox txt_Name;
        private TextBox txt_Color;
        private TextBox txt_Quantity;
        private TextBox txt_Ram;
        private TextBox txt_Display;
        private TextBox txt_SoucreImage;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button2;
        private Button button1;
    }
}