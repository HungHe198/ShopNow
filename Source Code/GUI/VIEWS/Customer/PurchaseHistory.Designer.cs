namespace ShopNow.Source_Code.GUI.VIEWS.Customer
{
    partial class PurchaseHistory
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
            btn_Seach = new Button();
            textBox1 = new TextBox();
            ptb_Logo = new PictureBox();
            dataGridView1 = new DataGridView();
            btn_ViewDetails = new Button();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_TotalPrice = new TextBox();
            ptb_productImage = new PictureBox();
            txt_Quantity = new TextBox();
            txt_Color = new TextBox();
            txt_Name = new TextBox();
            ((System.ComponentModel.ISupportInitialize)ptb_Logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptb_productImage).BeginInit();
            SuspendLayout();
            // 
            // lbNameShop
            // 
            lbNameShop.AutoSize = true;
            lbNameShop.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbNameShop.Location = new Point(619, -4);
            lbNameShop.Name = "lbNameShop";
            lbNameShop.Size = new Size(305, 81);
            lbNameShop.TabIndex = 7;
            lbNameShop.Text = "ShopNow";
            // 
            // btn_Seach
            // 
            btn_Seach.Location = new Point(1242, 78);
            btn_Seach.Name = "btn_Seach";
            btn_Seach.Size = new Size(131, 36);
            btn_Seach.TabIndex = 6;
            btn_Seach.Text = "Seach";
            btn_Seach.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(231, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1000, 34);
            textBox1.TabIndex = 5;
            // 
            // ptb_Logo
            // 
            ptb_Logo.BackColor = Color.Yellow;
            ptb_Logo.Location = new Point(10, 8);
            ptb_Logo.Name = "ptb_Logo";
            ptb_Logo.Size = new Size(200, 106);
            ptb_Logo.TabIndex = 4;
            ptb_Logo.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(231, 138);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1142, 625);
            dataGridView1.TabIndex = 8;
            // 
            // btn_ViewDetails
            // 
            btn_ViewDetails.Location = new Point(43, 588);
            btn_ViewDetails.Name = "btn_ViewDetails";
            btn_ViewDetails.Size = new Size(111, 66);
            btn_ViewDetails.TabIndex = 40;
            btn_ViewDetails.Text = "Xem chi tiết";
            btn_ViewDetails.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 521);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 39;
            label5.Text = "Đơn giá";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 463);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 38;
            label3.Text = "Số lượng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 394);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 37;
            label2.Text = "Màu sắc";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 341);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 36;
            label1.Text = "Tên sản phẩm";
            // 
            // txt_TotalPrice
            // 
            txt_TotalPrice.Location = new Point(10, 544);
            txt_TotalPrice.Name = "txt_TotalPrice";
            txt_TotalPrice.ReadOnly = true;
            txt_TotalPrice.Size = new Size(203, 27);
            txt_TotalPrice.TabIndex = 35;
            // 
            // ptb_productImage
            // 
            ptb_productImage.BackColor = Color.Lime;
            ptb_productImage.Location = new Point(10, 138);
            ptb_productImage.Name = "ptb_productImage";
            ptb_productImage.Size = new Size(200, 200);
            ptb_productImage.TabIndex = 31;
            ptb_productImage.TabStop = false;
            // 
            // txt_Quantity
            // 
            txt_Quantity.Location = new Point(10, 486);
            txt_Quantity.Name = "txt_Quantity";
            txt_Quantity.ReadOnly = true;
            txt_Quantity.Size = new Size(203, 27);
            txt_Quantity.TabIndex = 32;
            // 
            // txt_Color
            // 
            txt_Color.Location = new Point(10, 417);
            txt_Color.Name = "txt_Color";
            txt_Color.ReadOnly = true;
            txt_Color.Size = new Size(203, 27);
            txt_Color.TabIndex = 33;
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(10, 364);
            txt_Name.Name = "txt_Name";
            txt_Name.ReadOnly = true;
            txt_Name.Size = new Size(203, 27);
            txt_Name.TabIndex = 34;
            // 
            // PurchaseHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1395, 775);
            Controls.Add(btn_ViewDetails);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_TotalPrice);
            Controls.Add(ptb_productImage);
            Controls.Add(txt_Quantity);
            Controls.Add(txt_Color);
            Controls.Add(txt_Name);
            Controls.Add(dataGridView1);
            Controls.Add(lbNameShop);
            Controls.Add(btn_Seach);
            Controls.Add(textBox1);
            Controls.Add(ptb_Logo);
            Name = "PurchaseHistory";
            Text = "PurchaseHistory";
            Load += PurchaseHistory_Load;
            ((System.ComponentModel.ISupportInitialize)ptb_Logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptb_productImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNameShop;
        private Button btn_Seach;
        private TextBox textBox1;
        private PictureBox ptb_Logo;
        private DataGridView dataGridView1;
        private Button btn_ViewDetails;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_TotalPrice;
        private PictureBox ptb_productImage;
        private TextBox txt_Quantity;
        private TextBox txt_Color;
        private TextBox txt_Name;
    }
}