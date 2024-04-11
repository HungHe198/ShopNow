namespace ShopNow.Source_Code.GUI.VIEWS.Login
{
    partial class LoginStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginStaff));
            Label acb;
            pictureBox1 = new PictureBox();
            btn_Back = new Button();
            btn_loginAD = new Button();
            linkLabel1 = new LinkLabel();
            txt_Password = new TextBox();
            txt_UserName = new TextBox();
            label3 = new Label();
            label1 = new Label();
            acb = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(-2, -2);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(830, 1058);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // btn_Back
            // 
            btn_Back.AutoSize = true;
            btn_Back.BackColor = Color.FromArgb(255, 255, 128);
            btn_Back.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Back.Location = new Point(1227, 516);
            btn_Back.Margin = new Padding(3, 4, 3, 4);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(93, 38);
            btn_Back.TabIndex = 23;
            btn_Back.Text = "Quay lại";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // btn_loginAD
            // 
            btn_loginAD.AutoSize = true;
            btn_loginAD.BackColor = Color.FromArgb(255, 255, 128);
            btn_loginAD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_loginAD.Location = new Point(1052, 516);
            btn_loginAD.Margin = new Padding(3, 4, 3, 4);
            btn_loginAD.Name = "btn_loginAD";
            btn_loginAD.Size = new Size(118, 38);
            btn_loginAD.TabIndex = 22;
            btn_loginAD.Text = "Đăng nhập";
            btn_loginAD.UseVisualStyleBackColor = false;
            btn_loginAD.Click += btn_loginAD_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.FromArgb(255, 255, 128);
            linkLabel1.Location = new Point(1184, 442);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(145, 28);
            linkLabel1.TabIndex = 21;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Quên mật khẩu";
            // 
            // txt_Password
            // 
            txt_Password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Password.Location = new Point(1051, 386);
            txt_Password.Margin = new Padding(3, 4, 3, 4);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(278, 34);
            txt_Password.TabIndex = 20;
            // 
            // txt_UserName
            // 
            txt_UserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_UserName.Location = new Point(1051, 306);
            txt_UserName.Margin = new Padding(3, 4, 3, 4);
            txt_UserName.Name = "txt_UserName";
            txt_UserName.Size = new Size(278, 34);
            txt_UserName.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(1051, 354);
            label3.Name = "label3";
            label3.Size = new Size(94, 28);
            label3.TabIndex = 18;
            label3.Text = "Mật khẩu";
            // 
            // acb
            // 
            acb.AutoSize = true;
            acb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            acb.Location = new Point(1051, 274);
            acb.Name = "acb";
            acb.Size = new Size(94, 28);
            acb.TabIndex = 17;
            acb.Text = "Tài khoản";
            // 
            // label1
            // 
            label1.Font = new Font("Stencil", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuText;
            label1.Location = new Point(1016, 185);
            label1.Name = "label1";
            label1.Size = new Size(341, 67);
            label1.TabIndex = 16;
            label1.Text = "Nhân viên";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginStaff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(1395, 1055);
            Controls.Add(pictureBox1);
            Controls.Add(btn_Back);
            Controls.Add(btn_loginAD);
            Controls.Add(linkLabel1);
            Controls.Add(txt_Password);
            Controls.Add(txt_UserName);
            Controls.Add(label3);
            Controls.Add(acb);
            Controls.Add(label1);
            Name = "LoginStaff";
            Text = "LoginStaff";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btn_Back;
        private Button btn_loginAD;
        private LinkLabel linkLabel1;
        private TextBox txt_Password;
        private TextBox txt_UserName;
        private Label label3;
        private Label label1;
    }
}