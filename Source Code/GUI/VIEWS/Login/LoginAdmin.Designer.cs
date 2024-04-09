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
            pictureBox1 = new PictureBox();
            label3 = new Label();
            txttk1 = new TextBox();
            txtmk1 = new TextBox();
            linkLabel1 = new LinkLabel();
            btn_loginAD = new Button();
            btn_Back = new Button();
            acb = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // acb
            // 
            acb.AutoSize = true;
            acb.Location = new Point(979, 280);
            acb.Name = "acb";
            acb.Size = new Size(71, 20);
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
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(901, 779);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(981, 371);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 9;
            label3.Text = "Mật khẩu";
            // 
            // txttk1
            // 
            txttk1.Location = new Point(978, 317);
            txttk1.Margin = new Padding(3, 4, 3, 4);
            txttk1.Name = "txttk1";
            txttk1.Size = new Size(278, 27);
            txttk1.TabIndex = 10;
            // 
            // txtmk1
            // 
            txtmk1.Location = new Point(978, 397);
            txtmk1.Margin = new Padding(3, 4, 3, 4);
            txtmk1.Name = "txtmk1";
            txtmk1.Size = new Size(278, 27);
            txtmk1.TabIndex = 11;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(1192, 468);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(109, 20);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Quên mật khẩu";
            // 
            // btn_loginAD
            // 
            btn_loginAD.AutoSize = true;
            btn_loginAD.Location = new Point(978, 556);
            btn_loginAD.Margin = new Padding(3, 4, 3, 4);
            btn_loginAD.Name = "btn_loginAD";
            btn_loginAD.Size = new Size(92, 33);
            btn_loginAD.TabIndex = 13;
            btn_loginAD.Text = "Đăng nhập";
            btn_loginAD.UseVisualStyleBackColor = true;
            btn_loginAD.Click += btn_loginAD_Click;
            // 
            // btn_Back
            // 
            btn_Back.AutoSize = true;
            btn_Back.Location = new Point(1153, 556);
            btn_Back.Margin = new Padding(3, 4, 3, 4);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(91, 33);
            btn_Back.TabIndex = 14;
            btn_Back.Text = "Quay lại";
            btn_Back.UseVisualStyleBackColor = true;
            btn_Back.Click += btn_Back_Click;
            // 
            // LoginAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(1395, 775);
            Controls.Add(btn_Back);
            Controls.Add(btn_loginAD);
            Controls.Add(linkLabel1);
            Controls.Add(txtmk1);
            Controls.Add(txttk1);
            Controls.Add(label3);
            Controls.Add(acb);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
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
        private PictureBox pictureBox1;
        private Label acb;
        private Label label3;
        private TextBox txttk1;
        private TextBox txtmk1;
        private LinkLabel linkLabel1;
        private Button btn_loginAD;
        private Button btn_Back;
    }
}