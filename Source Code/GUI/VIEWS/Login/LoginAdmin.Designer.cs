namespace ShopNow.Source_Code.GUI.VIEWS.Login
{
    partial class LoginAdmin
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
            Label acb;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginAdmin));
            label1 = new Label();
            label3 = new Label();
            txt_UserName = new TextBox();
            txt_Password = new TextBox();
            linkLabel1 = new LinkLabel();
            btn_loginAD = new Button();
            btn_Back = new Button();
            pictureBox1 = new PictureBox();
            acb = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // acb
            // 
            acb.AutoSize = true;
            acb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            acb.Location = new Point(1013, 276);
            acb.Name = "acb";
            acb.Size = new Size(94, 28);
            acb.TabIndex = 8;
            acb.Text = "Tài khoản";
            // 
            // label1
            // 
            label1.Font = new Font("Stencil", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuText;
            label1.Location = new Point(978, 187);
            label1.Name = "label1";
            label1.Size = new Size(341, 67);
            label1.TabIndex = 7;
            label1.Text = "LOGIN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(1013, 356);
            label3.Name = "label3";
            label3.Size = new Size(94, 28);
            label3.TabIndex = 9;
            label3.Text = "Mật khẩu";
            // 
            // txt_UserName
            // 
            txt_UserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_UserName.Location = new Point(1013, 308);
            txt_UserName.Margin = new Padding(3, 4, 3, 4);
            txt_UserName.Name = "txt_UserName";
            txt_UserName.Size = new Size(278, 34);
            txt_UserName.TabIndex = 10;
            // 
            // txt_Password
            // 
            txt_Password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Password.Location = new Point(1013, 388);
            txt_Password.Margin = new Padding(3, 4, 3, 4);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(278, 34);
            txt_Password.TabIndex = 11;
            txt_Password.Enter += txt_Password_Enter;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.FromArgb(255, 255, 128);
            linkLabel1.Location = new Point(1146, 444);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(145, 28);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Quên mật khẩu";
            linkLabel1.Enter += linkLabel1_Enter;
            // 
            // btn_loginAD
            // 
            btn_loginAD.AutoSize = true;
            btn_loginAD.BackColor = Color.FromArgb(255, 255, 128);
            btn_loginAD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_loginAD.Location = new Point(1014, 518);
            btn_loginAD.Margin = new Padding(3, 4, 3, 4);
            btn_loginAD.Name = "btn_loginAD";
            btn_loginAD.Size = new Size(118, 38);
            btn_loginAD.TabIndex = 13;
            btn_loginAD.Text = "Đăng nhập";
            btn_loginAD.UseVisualStyleBackColor = false;
            btn_loginAD.Click += btn_loginAD_Click;
            // 
            // btn_Back
            // 
            btn_Back.AutoSize = true;
            btn_Back.BackColor = Color.FromArgb(255, 255, 128);
            btn_Back.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Back.Location = new Point(1189, 518);
            btn_Back.Margin = new Padding(3, 4, 3, 4);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(93, 38);
            btn_Back.TabIndex = 14;
            btn_Back.Text = "Quay lại";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(830, 1058);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // LoginAdmin
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginAdmin";
            Text = "ADmin";
            Load += LoginAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label acb;
        private Label label3;
        private TextBox txt_UserName;
        private TextBox txt_Password;
        private LinkLabel linkLabel1;
        private Button btn_loginAD;
        private Button btn_Back;
        private PictureBox pictureBox1;
    }
}