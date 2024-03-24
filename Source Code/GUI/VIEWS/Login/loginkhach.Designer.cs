namespace ShopNow.Source_Code.GUI.VIEWS.Login
{
    partial class loginkhach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginkhach));
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            txtmk2 = new TextBox();
            txttk2 = new TextBox();
            label3 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            acb = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(934, 401);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 21;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(1031, 347);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(89, 15);
            linkLabel1.TabIndex = 20;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Quên mật khẩu";
            // 
            // txtmk2
            // 
            txtmk2.Location = new Point(844, 294);
            txtmk2.Name = "txtmk2";
            txtmk2.Size = new Size(244, 23);
            txtmk2.TabIndex = 19;
            // 
            // txttk2
            // 
            txttk2.Location = new Point(844, 234);
            txttk2.Name = "txttk2";
            txttk2.Size = new Size(244, 23);
            txttk2.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(846, 274);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 17;
            label3.Text = "Mật khẩu";
            // 
            // acb
            // 
            acb.AutoSize = true;
            acb.Location = new Point(845, 206);
            acb.Name = "acb";
            acb.Size = new Size(57, 15);
            acb.TabIndex = 16;
            acb.Text = "Tài khoản";
            // 
            // label1
            // 
            label1.Font = new Font("Stencil", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuText;
            label1.Location = new Point(844, 136);
            label1.Name = "label1";
            label1.Size = new Size(298, 50);
            label1.TabIndex = 15;
            label1.Text = "LOGIN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(-1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(782, 578);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // loginkhach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(1221, 581);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Controls.Add(txtmk2);
            Controls.Add(txttk2);
            Controls.Add(label3);
            Controls.Add(acb);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "loginkhach";
            Text = "loginkhach";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private LinkLabel linkLabel1;
        private TextBox txtmk2;
        private TextBox txttk2;
        private Label label3;
        private Label label1;
        private PictureBox pictureBox1;
    }
}