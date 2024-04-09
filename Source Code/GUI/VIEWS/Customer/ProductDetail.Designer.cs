namespace ShopNow.Source_Code.GUI.Doanhthu
{
    partial class ProductDetail
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
            lbNameShop = new Label();
            lb_Name = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            ptb_Product = new PictureBox();
            groupBox1 = new GroupBox();
            lb_describe = new Label();
            label5 = new Label();
            label7 = new Label();
            label1 = new Label();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            txt_Ram = new TextBox();
            txt_Quantity = new TextBox();
            txt_Display = new TextBox();
            txt_Memory = new TextBox();
            txt_Color = new TextBox();
            ptb_Logo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ptb_Product).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_Logo).BeginInit();
            SuspendLayout();
            // 
            // lbNameShop
            // 
            lbNameShop.AutoSize = true;
            lbNameShop.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbNameShop.Location = new Point(609, -7);
            lbNameShop.Name = "lbNameShop";
            lbNameShop.Size = new Size(305, 81);
            lbNameShop.TabIndex = 11;
            lbNameShop.Text = "ShopNow";
            // 
            // lb_Name
            // 
            lb_Name.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Name.Location = new Point(221, 149);
            lb_Name.Name = "lb_Name";
            lb_Name.Size = new Size(1149, 41);
            lb_Name.TabIndex = 12;
            lb_Name.Text = "(No Name)";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // ptb_Product
            // 
            ptb_Product.BackColor = Color.MediumAquamarine;
            ptb_Product.Image = Properties.Resources.Logo;
            ptb_Product.Location = new Point(221, 193);
            ptb_Product.Name = "ptb_Product";
            ptb_Product.Size = new Size(475, 549);
            ptb_Product.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_Product.TabIndex = 13;
            ptb_Product.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 255, 128);
            groupBox1.Controls.Add(lb_describe);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_Ram);
            groupBox1.Controls.Add(txt_Quantity);
            groupBox1.Controls.Add(txt_Display);
            groupBox1.Controls.Add(txt_Memory);
            groupBox1.Controls.Add(txt_Color);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(754, 190);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(616, 552);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm";
            // 
            // lb_describe
            // 
            lb_describe.Location = new Point(62, 332);
            lb_describe.Name = "lb_describe";
            lb_describe.Size = new Size(520, 195);
            lb_describe.TabIndex = 2;
            lb_describe.Text = "Chi tiết mô tả";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(330, 126);
            label5.Name = "label5";
            label5.Size = new Size(51, 28);
            label5.TabIndex = 1;
            label5.Text = "Ram";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(330, 218);
            label7.Name = "label7";
            label7.Size = new Size(154, 28);
            label7.TabIndex = 1;
            label7.Text = "Số lượng còn lại";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(35, 304);
            label1.Name = "label1";
            label1.Size = new Size(64, 28);
            label1.TabIndex = 1;
            label1.Text = "Mô tả";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(37, 218);
            label6.Name = "label6";
            label6.Size = new Size(191, 28);
            label6.TabIndex = 1;
            label6.Text = "Kích thước màn hình";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(37, 126);
            label4.Name = "label4";
            label4.Size = new Size(185, 28);
            label4.TabIndex = 1;
            label4.Text = "Dung lượng bộ nhớ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(39, 37);
            label2.Name = "label2";
            label2.Size = new Size(83, 28);
            label2.TabIndex = 1;
            label2.Text = "Màu sắc";
            // 
            // txt_Ram
            // 
            txt_Ram.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Ram.Location = new Point(330, 160);
            txt_Ram.Name = "txt_Ram";
            txt_Ram.ReadOnly = true;
            txt_Ram.Size = new Size(252, 34);
            txt_Ram.TabIndex = 0;
            // 
            // txt_Quantity
            // 
            txt_Quantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Quantity.Location = new Point(330, 252);
            txt_Quantity.Name = "txt_Quantity";
            txt_Quantity.ReadOnly = true;
            txt_Quantity.Size = new Size(252, 34);
            txt_Quantity.TabIndex = 0;
            // 
            // txt_Display
            // 
            txt_Display.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Display.Location = new Point(37, 252);
            txt_Display.Name = "txt_Display";
            txt_Display.ReadOnly = true;
            txt_Display.Size = new Size(252, 34);
            txt_Display.TabIndex = 0;
            // 
            // txt_Memory
            // 
            txt_Memory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Memory.Location = new Point(39, 160);
            txt_Memory.Name = "txt_Memory";
            txt_Memory.ReadOnly = true;
            txt_Memory.Size = new Size(252, 34);
            txt_Memory.TabIndex = 0;
            // 
            // txt_Color
            // 
            txt_Color.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Color.Location = new Point(37, 71);
            txt_Color.Name = "txt_Color";
            txt_Color.ReadOnly = true;
            txt_Color.Size = new Size(545, 34);
            txt_Color.TabIndex = 0;
            // 
            // ptb_Logo
            // 
            ptb_Logo.BackColor = Color.MistyRose;
            ptb_Logo.Image = Properties.Resources.Logo;
            ptb_Logo.Location = new Point(12, 12);
            ptb_Logo.Name = "ptb_Logo";
            ptb_Logo.Size = new Size(200, 84);
            ptb_Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_Logo.TabIndex = 11;
            ptb_Logo.TabStop = false;
            // 
            // ProductDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(1395, 775);
            Controls.Add(ptb_Logo);
            Controls.Add(groupBox1);
            Controls.Add(ptb_Product);
            Controls.Add(lb_Name);
            Controls.Add(lbNameShop);
            Name = "ProductDetail";
            Text = " ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ptb_Product).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNameShop;
        private Label lb_Name;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private PictureBox ptb_Product;
        private GroupBox groupBox1;
        private Label label5;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label2;
        private TextBox txt_Ram;
        private TextBox txt_Quantity;
        private TextBox txt_Display;
        private TextBox txt_Memory;
        private TextBox txt_Color;
        private Label lb_describe;
        private Label label1;
        private PictureBox ptb_Logo;
    }
}