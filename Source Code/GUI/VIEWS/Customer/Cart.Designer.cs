namespace ShopNow.Source_Code.GUI.VIEWS.Customer
{
    partial class Cart
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
            grb_Quanlinhanvien = new GroupBox();
            dgvMainCart = new DataGridView();
            label1 = new Label();
            btn_Xoa = new Button();
            groupBox1 = new GroupBox();
            button2 = new Button();
            btn_Save = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txt_totalPrice = new TextBox();
            txt_Quantity = new TextBox();
            txt_Price = new TextBox();
            pictureBox1 = new PictureBox();
            txt_Name = new TextBox();
            ptb_logo = new PictureBox();
            grb_Quanlinhanvien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMainCart).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptb_logo).BeginInit();
            SuspendLayout();
            // 
            // grb_Quanlinhanvien
            // 
            grb_Quanlinhanvien.Controls.Add(dgvMainCart);
            grb_Quanlinhanvien.Controls.Add(label1);
            grb_Quanlinhanvien.Controls.Add(btn_Xoa);
            grb_Quanlinhanvien.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            grb_Quanlinhanvien.Location = new Point(279, 12);
            grb_Quanlinhanvien.Name = "grb_Quanlinhanvien";
            grb_Quanlinhanvien.Size = new Size(1104, 973);
            grb_Quanlinhanvien.TabIndex = 28;
            grb_Quanlinhanvien.TabStop = false;
            // 
            // dgvMainCart
            // 
            dgvMainCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMainCart.Location = new Point(6, 131);
            dgvMainCart.Name = "dgvMainCart";
            dgvMainCart.RowHeadersWidth = 51;
            dgvMainCart.RowTemplate.Height = 29;
            dgvMainCart.Size = new Size(1092, 836);
            dgvMainCart.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 15);
            label1.Name = "label1";
            label1.Size = new Size(103, 25);
            label1.TabIndex = 10;
            label1.Text = "Giỏ hàng";
            // 
            // btn_Xoa
            // 
            btn_Xoa.AutoSize = true;
            btn_Xoa.BackColor = Color.Red;
            btn_Xoa.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btn_Xoa.FlatAppearance.MouseDownBackColor = Color.Black;
            btn_Xoa.FlatAppearance.MouseOverBackColor = Color.Yellow;
            btn_Xoa.FlatStyle = FlatStyle.Flat;
            btn_Xoa.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Xoa.ForeColor = Color.White;
            btn_Xoa.Location = new Point(976, 79);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(122, 31);
            btn_Xoa.TabIndex = 9;
            btn_Xoa.Text = "Xóa sản phẩm";
            btn_Xoa.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(btn_Save);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_totalPrice);
            groupBox1.Controls.Add(txt_Quantity);
            groupBox1.Controls.Add(txt_Price);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(txt_Name);
            groupBox1.Location = new Point(14, 127);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(259, 578);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(23, 504);
            button2.Name = "button2";
            button2.Size = new Size(85, 60);
            button2.TabIndex = 43;
            button2.Text = "Chi tiết sản phẩm";
            button2.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            btn_Save.BackColor = Color.Red;
            btn_Save.ForeColor = Color.White;
            btn_Save.Location = new Point(154, 504);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(79, 60);
            btn_Save.TabIndex = 42;
            btn_Save.Text = "Lưu";
            btn_Save.UseVisualStyleBackColor = false;
            btn_Save.Click += btn_Save_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 430);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 41;
            label5.Text = "Thành tiền";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 377);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 40;
            label4.Text = "Số lượng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 324);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 39;
            label3.Text = "Đơn giá";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 264);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 39;
            label2.Text = "Tên sản phẩm";
            // 
            // txt_totalPrice
            // 
            txt_totalPrice.Location = new Point(23, 453);
            txt_totalPrice.Name = "txt_totalPrice";
            txt_totalPrice.ReadOnly = true;
            txt_totalPrice.Size = new Size(222, 27);
            txt_totalPrice.TabIndex = 36;
            // 
            // txt_Quantity
            // 
            txt_Quantity.Location = new Point(23, 400);
            txt_Quantity.Name = "txt_Quantity";
            txt_Quantity.Size = new Size(222, 27);
            txt_Quantity.TabIndex = 37;
            txt_Quantity.TextChanged += txt_Quantity_TextChanged;
            // 
            // txt_Price
            // 
            txt_Price.Location = new Point(23, 347);
            txt_Price.Name = "txt_Price";
            txt_Price.ReadOnly = true;
            txt_Price.Size = new Size(222, 27);
            txt_Price.TabIndex = 38;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDark;
            pictureBox1.Location = new Point(11, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 189);
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(23, 287);
            txt_Name.Name = "txt_Name";
            txt_Name.ReadOnly = true;
            txt_Name.Size = new Size(222, 27);
            txt_Name.TabIndex = 33;
            // 
            // ptb_logo
            // 
            ptb_logo.BackColor = SystemColors.ControlDark;
            ptb_logo.Location = new Point(42, 12);
            ptb_logo.Name = "ptb_logo";
            ptb_logo.Size = new Size(205, 109);
            ptb_logo.TabIndex = 36;
            ptb_logo.TabStop = false;
            ptb_logo.Click += ptb_logo_Click;
            // 
            // Cart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1395, 1055);
            Controls.Add(ptb_logo);
            Controls.Add(groupBox1);
            Controls.Add(grb_Quanlinhanvien);
            Name = "Cart";
            Text = "Cart";
            Load += Cart_Load;
            grb_Quanlinhanvien.ResumeLayout(false);
            grb_Quanlinhanvien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMainCart).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptb_logo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox grb_Quanlinhanvien;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txt_totalPrice;
        private TextBox txt_Quantity;
        private TextBox txt_Price;
        private PictureBox pictureBox1;
        private TextBox txt_Name;
        private Button button2;
        private Button btn_Save;
        private Label label5;
        private Label label4;
        private Label label3;
        private PictureBox ptb_logo;
        private DataGridView dgvMainCart;
        private Button btn_Xoa;
    }
}