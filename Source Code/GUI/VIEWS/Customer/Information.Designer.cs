namespace ShopNow.Source_Code.GUI.VIEWS.Customer
{
    partial class Information
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
            txt_Name = new TextBox();
            label1 = new Label();
            txt_Password = new TextBox();
            label2 = new Label();
            txt_PhoneNumber = new TextBox();
            label3 = new Label();
            txt_Address = new TextBox();
            label4 = new Label();
            txt_Email = new TextBox();
            label5 = new Label();
            btn_Save = new Button();
            pictureBox1 = new PictureBox();
            grb_infomation = new GroupBox();
            Thoát = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grb_infomation.SuspendLayout();
            SuspendLayout();
            // 
            // txt_Name
            // 
            txt_Name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Name.Location = new Point(28, 49);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(366, 34);
            txt_Name.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(28, 18);
            label1.Name = "label1";
            label1.Size = new Size(108, 28);
            label1.TabIndex = 1;
            label1.Text = "User Name";
            // 
            // txt_Password
            // 
            txt_Password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Password.Location = new Point(28, 119);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(366, 34);
            txt_Password.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(28, 88);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // txt_PhoneNumber
            // 
            txt_PhoneNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_PhoneNumber.Location = new Point(28, 189);
            txt_PhoneNumber.Name = "txt_PhoneNumber";
            txt_PhoneNumber.Size = new Size(366, 34);
            txt_PhoneNumber.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(28, 158);
            label3.Name = "label3";
            label3.Size = new Size(128, 28);
            label3.TabIndex = 1;
            label3.Text = "Số điện thoại";
            // 
            // txt_Address
            // 
            txt_Address.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Address.Location = new Point(28, 264);
            txt_Address.Name = "txt_Address";
            txt_Address.Size = new Size(366, 34);
            txt_Address.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(28, 233);
            label4.Name = "label4";
            label4.Size = new Size(71, 28);
            label4.TabIndex = 1;
            label4.Text = "Địa chỉ";
            // 
            // txt_Email
            // 
            txt_Email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Email.Location = new Point(28, 339);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(366, 34);
            txt_Email.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(28, 308);
            label5.Name = "label5";
            label5.Size = new Size(59, 28);
            label5.TabIndex = 1;
            label5.Text = "Email";
            // 
            // btn_Save
            // 
            btn_Save.BackColor = Color.Red;
            btn_Save.Enabled = false;
            btn_Save.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Save.ForeColor = Color.White;
            btn_Save.Location = new Point(461, 426);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(143, 53);
            btn_Save.TabIndex = 3;
            btn_Save.Text = "Lưu";
            btn_Save.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Customer;
            pictureBox1.Location = new Point(478, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(259, 249);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // grb_infomation
            // 
            grb_infomation.BackColor = Color.FromArgb(255, 255, 192);
            grb_infomation.Controls.Add(pictureBox1);
            grb_infomation.Controls.Add(label5);
            grb_infomation.Controls.Add(label4);
            grb_infomation.Controls.Add(label3);
            grb_infomation.Controls.Add(label2);
            grb_infomation.Controls.Add(label1);
            grb_infomation.Controls.Add(txt_Email);
            grb_infomation.Controls.Add(txt_Address);
            grb_infomation.Controls.Add(txt_PhoneNumber);
            grb_infomation.Controls.Add(txt_Password);
            grb_infomation.Controls.Add(txt_Name);
            grb_infomation.Location = new Point(25, 21);
            grb_infomation.Name = "grb_infomation";
            grb_infomation.Size = new Size(755, 398);
            grb_infomation.TabIndex = 5;
            grb_infomation.TabStop = false;
            // 
            // Thoát
            // 
            Thoát.BackColor = Color.Red;
            Thoát.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Thoát.ForeColor = SystemColors.Window;
            Thoát.Location = new Point(191, 425);
            Thoát.Name = "Thoát";
            Thoát.Size = new Size(143, 53);
            Thoát.TabIndex = 3;
            Thoát.Text = "Thoát";
            Thoát.UseVisualStyleBackColor = false;
            Thoát.Click += Thoát_Click;
            // 
            // Information
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 491);
            Controls.Add(grb_infomation);
            Controls.Add(Thoát);
            Controls.Add(btn_Save);
            Name = "Information";
            Text = "Information";
            Load += Information_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grb_infomation.ResumeLayout(false);
            grb_infomation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txt_Name;
        private Label label1;
        private TextBox txt_Password;
        private Label label2;
        private TextBox txt_PhoneNumber;
        private Label label3;
        private TextBox txt_Address;
        private Label label4;
        private TextBox txt_Email;
        private Label label5;
        private Button btn_Save;
        private PictureBox pictureBox1;
        private GroupBox grb_infomation;
        private Button Thoát;
    }
}