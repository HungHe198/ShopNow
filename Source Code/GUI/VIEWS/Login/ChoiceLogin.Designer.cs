namespace ShopNow.Source_Code.GUI.VIEWS.Login
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnqtv = new Button();
            btnkhang = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnqtv
            // 
            btnqtv.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnqtv.Location = new Point(1040, 259);
            btnqtv.Margin = new Padding(3, 4, 3, 4);
            btnqtv.Name = "btnqtv";
            btnqtv.Size = new Size(205, 101);
            btnqtv.TabIndex = 0;
            btnqtv.Text = "Quản trị viên";
            btnqtv.UseVisualStyleBackColor = true;
            btnqtv.Click += btnqtv_Click;
            // 
            // btnkhang
            // 
            btnkhang.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnkhang.Location = new Point(1040, 433);
            btnkhang.Margin = new Padding(3, 4, 3, 4);
            btnkhang.Name = "btnkhang";
            btnkhang.Size = new Size(201, 105);
            btnkhang.TabIndex = 1;
            btnkhang.Text = "Khách hàng";
            btnkhang.UseVisualStyleBackColor = true;
            btnkhang.Click += btnkhang_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(901, 779);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Stencil", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuText;
            label1.Location = new Point(975, 117);
            label1.Name = "label1";
            label1.Size = new Size(343, 67);
            label1.TabIndex = 3;
            label1.Text = "LOGIN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(1395, 775);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnkhang);
            Controls.Add(btnqtv);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnqtv;
        private Button btnkhang;
        private PictureBox pictureBox1;
        private Label label1;
    }
}