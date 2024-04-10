namespace ShopNow.Source_Code.GUI.VIEWS.Customer
{
    partial class DeliveryInformation
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
            btn_Confirm = new Button();
            btn_Back = new Button();
            txt_Name = new TextBox();
            txt_PhoneNumber = new TextBox();
            txt_Address = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            grb_infomation = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grb_infomation.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Confirm
            // 
            btn_Confirm.BackColor = Color.Red;
            btn_Confirm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Confirm.ForeColor = Color.White;
            btn_Confirm.Location = new Point(458, 429);
            btn_Confirm.Name = "btn_Confirm";
            btn_Confirm.Size = new Size(143, 53);
            btn_Confirm.TabIndex = 6;
            btn_Confirm.Text = "Lưu";
            btn_Confirm.UseVisualStyleBackColor = false;
            btn_Confirm.Click += btn_Confirm_Click;
            // 
            // btn_Back
            // 
            btn_Back.BackColor = Color.Red;
            btn_Back.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Back.ForeColor = SystemColors.Window;
            btn_Back.Location = new Point(189, 429);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(143, 53);
            btn_Back.TabIndex = 7;
            btn_Back.Text = "Thoát";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // txt_Name
            // 
            txt_Name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Name.Location = new Point(28, 49);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(366, 34);
            txt_Name.TabIndex = 0;
            // 
            // txt_PhoneNumber
            // 
            txt_PhoneNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_PhoneNumber.Location = new Point(28, 150);
            txt_PhoneNumber.Name = "txt_PhoneNumber";
            txt_PhoneNumber.Size = new Size(366, 34);
            txt_PhoneNumber.TabIndex = 0;
            // 
            // txt_Address
            // 
            txt_Address.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Address.Location = new Point(28, 255);
            txt_Address.Name = "txt_Address";
            txt_Address.Size = new Size(366, 34);
            txt_Address.TabIndex = 0;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(28, 119);
            label3.Name = "label3";
            label3.Size = new Size(128, 28);
            label3.TabIndex = 1;
            label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(28, 224);
            label4.Name = "label4";
            label4.Size = new Size(71, 28);
            label4.TabIndex = 1;
            label4.Text = "Địa chỉ";
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
            grb_infomation.Controls.Add(label4);
            grb_infomation.Controls.Add(label3);
            grb_infomation.Controls.Add(label1);
            grb_infomation.Controls.Add(txt_Address);
            grb_infomation.Controls.Add(txt_PhoneNumber);
            grb_infomation.Controls.Add(txt_Name);
            grb_infomation.Location = new Point(12, 12);
            grb_infomation.Name = "grb_infomation";
            grb_infomation.Size = new Size(755, 398);
            grb_infomation.TabIndex = 8;
            grb_infomation.TabStop = false;
            // 
            // DeliveryInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 494);
            Controls.Add(btn_Confirm);
            Controls.Add(grb_infomation);
            Controls.Add(btn_Back);
            Name = "DeliveryInformation";
            Text = "DeliveryInformation";
            Load += DeliveryInformation_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grb_infomation.ResumeLayout(false);
            grb_infomation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Confirm;
        private Button btn_Back;
        private TextBox txt_Name;
        private TextBox txt_PhoneNumber;
        private TextBox txt_Address;
        private Label label1;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private GroupBox grb_infomation;
    }
}