namespace ShopNow.Source_Code.GUI.VIEWS.Home
{
    partial class HomeForStaff
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
            btn_Logout = new Button();
            button1 = new Button();
            button2 = new Button();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_SoucreImage = new TextBox();
            txt_Quantity = new TextBox();
            txt_Color = new TextBox();
            txt_Name = new TextBox();
            dgvMainShow = new DataGridView();
            btn_management = new Button();
            btn_information = new Button();
            ptb_admin = new PictureBox();
            ptb_productImage = new PictureBox();
            groupBox1 = new GroupBox();
            lbNameShop = new Label();
            btn_Seach = new Button();
            txt_Seach = new TextBox();
            ptb_Banner = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ptb_Logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMainShow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptb_admin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptb_productImage).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_Banner).BeginInit();
            SuspendLayout();
            // 
            // ptb_Logo
            // 
            ptb_Logo.BackColor = Color.MistyRose;
            ptb_Logo.Image = Properties.Resources.Logo;
            ptb_Logo.Location = new Point(29, 61);
            ptb_Logo.Name = "ptb_Logo";
            ptb_Logo.Size = new Size(200, 84);
            ptb_Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_Logo.TabIndex = 52;
            ptb_Logo.TabStop = false;
            // 
            // btn_Logout
            // 
            btn_Logout.BackColor = Color.Red;
            btn_Logout.ForeColor = Color.White;
            btn_Logout.Location = new Point(1301, 67);
            btn_Logout.Name = "btn_Logout";
            btn_Logout.Size = new Size(92, 32);
            btn_Logout.TabIndex = 51;
            btn_Logout.Text = "Đăng xuất";
            btn_Logout.UseVisualStyleBackColor = false;
            btn_Logout.Click += btn_Logout_Click;
            // 
            // button1
            // 
            button1.Location = new Point(153, 922);
            button1.Name = "button1";
            button1.Size = new Size(68, 60);
            button1.TabIndex = 50;
            button1.Text = "Lưu";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(42, 922);
            button2.Name = "button2";
            button2.Size = new Size(106, 60);
            button2.TabIndex = 49;
            button2.Text = "Xem chi tiết";
            button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 843);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 48;
            label6.Text = "Source ảnh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 777);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 47;
            label3.Text = "Số lượng còn lại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 722);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 46;
            label2.Text = "Màu sắc";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 669);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 45;
            label1.Text = "Tên sản phẩm";
            // 
            // txt_SoucreImage
            // 
            txt_SoucreImage.Location = new Point(29, 866);
            txt_SoucreImage.Name = "txt_SoucreImage";
            txt_SoucreImage.Size = new Size(203, 27);
            txt_SoucreImage.TabIndex = 44;
            // 
            // txt_Quantity
            // 
            txt_Quantity.Location = new Point(29, 802);
            txt_Quantity.Name = "txt_Quantity";
            txt_Quantity.ReadOnly = true;
            txt_Quantity.Size = new Size(203, 27);
            txt_Quantity.TabIndex = 43;
            // 
            // txt_Color
            // 
            txt_Color.Location = new Point(29, 747);
            txt_Color.Name = "txt_Color";
            txt_Color.Size = new Size(203, 27);
            txt_Color.TabIndex = 42;
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(29, 692);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(203, 27);
            txt_Name.TabIndex = 41;
            // 
            // dgvMainShow
            // 
            dgvMainShow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMainShow.Location = new Point(251, 451);
            dgvMainShow.Name = "dgvMainShow";
            dgvMainShow.RowHeadersWidth = 51;
            dgvMainShow.RowTemplate.Height = 29;
            dgvMainShow.Size = new Size(1142, 558);
            dgvMainShow.TabIndex = 39;
            // 
            // btn_management
            // 
            btn_management.Location = new Point(22, 171);
            btn_management.Name = "btn_management";
            btn_management.Size = new Size(170, 54);
            btn_management.TabIndex = 1;
            btn_management.Text = "Hệ thống quản lí";
            btn_management.UseVisualStyleBackColor = true;
            btn_management.Click += btn_management_Click;
            // 
            // btn_information
            // 
            btn_information.Location = new Point(22, 111);
            btn_information.Name = "btn_information";
            btn_information.Size = new Size(170, 54);
            btn_information.TabIndex = 1;
            btn_information.Text = "Thông tin cá nhân";
            btn_information.UseVisualStyleBackColor = true;
            btn_information.Click += btn_information_Click;
            // 
            // ptb_admin
            // 
            ptb_admin.Image = Properties.Resources.Admin;
            ptb_admin.Location = new Point(72, 26);
            ptb_admin.Name = "ptb_admin";
            ptb_admin.Size = new Size(76, 79);
            ptb_admin.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_admin.TabIndex = 0;
            ptb_admin.TabStop = false;
            // 
            // ptb_productImage
            // 
            ptb_productImage.BackColor = Color.MistyRose;
            ptb_productImage.Location = new Point(32, 463);
            ptb_productImage.Name = "ptb_productImage";
            ptb_productImage.Size = new Size(200, 200);
            ptb_productImage.TabIndex = 40;
            ptb_productImage.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_management);
            groupBox1.Controls.Add(btn_information);
            groupBox1.Controls.Add(ptb_admin);
            groupBox1.Location = new Point(29, 189);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(215, 250);
            groupBox1.TabIndex = 38;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản lí hệ thống";
            // 
            // lbNameShop
            // 
            lbNameShop.AutoSize = true;
            lbNameShop.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbNameShop.Location = new Point(639, 46);
            lbNameShop.Name = "lbNameShop";
            lbNameShop.Size = new Size(305, 81);
            lbNameShop.TabIndex = 37;
            lbNameShop.Text = "ShopNow";
            // 
            // btn_Seach
            // 
            btn_Seach.Location = new Point(1262, 137);
            btn_Seach.Name = "btn_Seach";
            btn_Seach.Size = new Size(131, 36);
            btn_Seach.TabIndex = 36;
            btn_Seach.Text = "Seach";
            btn_Seach.UseVisualStyleBackColor = true;
            // 
            // txt_Seach
            // 
            txt_Seach.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Seach.Location = new Point(251, 139);
            txt_Seach.Name = "txt_Seach";
            txt_Seach.Size = new Size(1000, 34);
            txt_Seach.TabIndex = 35;
            txt_Seach.TextChanged += txt_Seach_TextChanged;
            // 
            // ptb_Banner
            // 
            ptb_Banner.BackColor = Color.WhiteSmoke;
            ptb_Banner.Image = Properties.Resources.banner;
            ptb_Banner.Location = new Point(251, 179);
            ptb_Banner.Name = "ptb_Banner";
            ptb_Banner.Size = new Size(1139, 266);
            ptb_Banner.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_Banner.TabIndex = 34;
            ptb_Banner.TabStop = false;
            // 
            // HomeForStaff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 1055);
            Controls.Add(ptb_Logo);
            Controls.Add(btn_Logout);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_SoucreImage);
            Controls.Add(txt_Quantity);
            Controls.Add(txt_Color);
            Controls.Add(txt_Name);
            Controls.Add(dgvMainShow);
            Controls.Add(ptb_productImage);
            Controls.Add(groupBox1);
            Controls.Add(lbNameShop);
            Controls.Add(btn_Seach);
            Controls.Add(txt_Seach);
            Controls.Add(ptb_Banner);
            Name = "HomeForStaff";
            Text = "HomeForStaff";
            Load += HomeForStaff_Load;
            ((System.ComponentModel.ISupportInitialize)ptb_Logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMainShow).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptb_admin).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptb_productImage).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptb_Banner).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ptb_Logo;
        private Button btn_Logout;
        private Button button1;
        private Button button2;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_SoucreImage;
        private TextBox txt_Quantity;
        private TextBox txt_Color;
        private TextBox txt_Name;
        private DataGridView dgvMainShow;
        private Button btn_management;
        private Button btn_information;
        private PictureBox ptb_admin;
        private PictureBox ptb_productImage;
        private GroupBox groupBox1;
        private Label lbNameShop;
        private Button btn_Seach;
        private TextBox txt_Seach;
        private PictureBox ptb_Banner;
    }
}