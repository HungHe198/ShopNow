﻿namespace ShopNow.Source_Code.GUI.VIEWS.Login
{
    partial class ChoiceLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoiceLogin));
            label1 = new Label();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            btn_Customer = new Button();
            btn_admin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Stencil", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuText;
            label1.Location = new Point(1016, 185);
            label1.Name = "label1";
            label1.Size = new Size(341, 67);
            label1.TabIndex = 15;
            label1.Text = "LOGIN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Stencil", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.MenuText;
            label5.Location = new Point(978, 187);
            label5.Name = "label5";
            label5.Size = new Size(341, 67);
            label5.TabIndex = 23;
            label5.Text = "LOGIN";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(901, 779);
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // btn_Customer
            // 
            btn_Customer.Location = new Point(1001, 460);
            btn_Customer.Name = "btn_Customer";
            btn_Customer.Size = new Size(337, 76);
            btn_Customer.TabIndex = 24;
            btn_Customer.Text = "Khách hàng";
            btn_Customer.UseVisualStyleBackColor = true;
            btn_Customer.Click += btn_Customer_Click;
            // 
            // btn_admin
            // 
            btn_admin.Location = new Point(1001, 316);
            btn_admin.Name = "btn_admin";
            btn_admin.Size = new Size(337, 76);
            btn_admin.TabIndex = 24;
            btn_admin.Text = "Quản trị viên";
            btn_admin.UseVisualStyleBackColor = true;
            btn_admin.Click += btn_admin_Click;
            // 
            // ChoiceLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(1395, 775);
            Controls.Add(btn_admin);
            Controls.Add(btn_Customer);
            Controls.Add(label5);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Name = "ChoiceLogin";
            Text = "ChoiceLogin";
            Load += ChoiceLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label label5;
        private PictureBox pictureBox2;
        private Button btn_Customer;
        private Button btn_admin;
    }
}