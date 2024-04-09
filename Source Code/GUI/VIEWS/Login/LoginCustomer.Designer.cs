namespace ShopNow.Source_Code.GUI.VIEWS.Login
{
    partial class LoginCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginCustomer));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btn_Back = new Button();
            btn_Login = new Button();
            linkLabel1 = new LinkLabel();
            txt_PassWord = new TextBox();
            txt_UserName = new TextBox();
            label3 = new Label();
            acb = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // acb
            // 
            acb.AutoSize = true;
            acb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            acb.Location = new Point(1005, 252);
            acb.Name = "acb";
            acb.Size = new Size(94, 28);
            acb.TabIndex = 16;
            acb.Text = "Tài khoản";
            // 
            // label1
            // 
            label1.Font = new Font("Stencil", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuText;
            label1.Location = new Point(965, 181);
            label1.Name = "label1";
            label1.Size = new Size(341, 67);
            label1.TabIndex = 15;
            label1.Text = "LOGIN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(-1, 2);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(830, 1058);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // btn_Back
            // 
            btn_Back.AutoSize = true;
            btn_Back.BackColor = Color.FromArgb(255, 255, 128);
            btn_Back.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Back.Location = new Point(1181, 494);
            btn_Back.Margin = new Padding(3, 4, 3, 4);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(93, 38);
            btn_Back.TabIndex = 22;
            btn_Back.Text = "Quay lại";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // btn_Login
            // 
            btn_Login.AutoSize = true;
            btn_Login.BackColor = Color.FromArgb(255, 255, 128);
            btn_Login.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Login.Location = new Point(1006, 494);
            btn_Login.Margin = new Padding(3, 4, 3, 4);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(118, 38);
            btn_Login.TabIndex = 21;
            btn_Login.Text = "Đăng nhập";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.FromArgb(255, 255, 128);
            linkLabel1.Location = new Point(1138, 420);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(145, 28);
            linkLabel1.TabIndex = 20;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Quên mật khẩu";
            // 
            // txt_PassWord
            // 
            txt_PassWord.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_PassWord.Location = new Point(1005, 364);
            txt_PassWord.Margin = new Padding(3, 4, 3, 4);
            txt_PassWord.Name = "txt_PassWord";
            txt_PassWord.Size = new Size(278, 34);
            txt_PassWord.TabIndex = 19;
            // 
            // txt_UserName
            // 
            txt_UserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_UserName.Location = new Point(1005, 284);
            txt_UserName.Margin = new Padding(3, 4, 3, 4);
            txt_UserName.Name = "txt_UserName";
            txt_UserName.Size = new Size(278, 34);
            txt_UserName.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(1005, 332);
            label3.Name = "label3";
            label3.Size = new Size(94, 28);
            label3.TabIndex = 17;
            label3.Text = "Mật khẩu";
            // 
            // LoginCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(1395, 1055);
            Controls.Add(btn_Back);
            Controls.Add(btn_Login);
            Controls.Add(linkLabel1);
            Controls.Add(txt_PassWord);
            Controls.Add(txt_UserName);
            Controls.Add(label3);
            Controls.Add(acb);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginCustomer";
            Text = "loginkhach";
            Load += LoginCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private PictureBox pictureBox1;
        private Button btn_Back;
        private Button btn_Login;
        private LinkLabel linkLabel1;
        private TextBox txt_PassWord;
        private TextBox txt_UserName;
        private Label label3;
    }
}