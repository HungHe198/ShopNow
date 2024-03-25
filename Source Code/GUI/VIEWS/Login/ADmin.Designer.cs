namespace ShopNow.Source_Code.GUI.VIEWS.Login
{
    partial class ADmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADmin));
            Label acb;
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            txttk1 = new TextBox();
            txtmk1 = new TextBox();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            acb = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Stencil", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuText;
            label1.Location = new Point(856, 140);
            label1.Name = "label1";
            label1.Size = new Size(298, 50);
            label1.TabIndex = 7;
            label1.Text = "LOGIN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(788, 584);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // acb
            // 
            acb.AutoSize = true;
            acb.Location = new Point(857, 210);
            acb.Name = "acb";
            acb.Size = new Size(57, 15);
            acb.TabIndex = 8;
            acb.Text = "Tài khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(858, 278);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 9;
            label3.Text = "Mật khẩu";
            // 
            // txttk1
            // 
            txttk1.Location = new Point(856, 238);
            txttk1.Name = "txttk1";
            txttk1.Size = new Size(244, 23);
            txttk1.TabIndex = 10;
            // 
            // txtmk1
            // 
            txtmk1.Location = new Point(856, 298);
            txtmk1.Name = "txtmk1";
            txtmk1.Size = new Size(244, 23);
            txtmk1.TabIndex = 11;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(1043, 351);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(89, 15);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Quên mật khẩu";
            // 
            // button1
            // 
            button1.Location = new Point(946, 405);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = true;
            // 
            // ADmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(1221, 581);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Controls.Add(txtmk1);
            Controls.Add(txttk1);
            Controls.Add(label3);
            Controls.Add(acb);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "ADmin";
            Text = "ADmin";
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
        private Button button1;
    }
}