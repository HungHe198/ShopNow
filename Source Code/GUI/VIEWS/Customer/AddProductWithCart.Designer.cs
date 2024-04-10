namespace ShopNow.Source_Code.GUI.VIEWS.Customer
{
    partial class AddProductWithCart
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
            txt_Quantity = new TextBox();
            label1 = new Label();
            btn_confirm = new Button();
            SuspendLayout();
            // 
            // txt_Quantity
            // 
            txt_Quantity.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Quantity.Location = new Point(549, 84);
            txt_Quantity.Name = "txt_Quantity";
            txt_Quantity.Size = new Size(253, 51);
            txt_Quantity.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(416, 97);
            label1.Name = "label1";
            label1.Size = new Size(127, 32);
            label1.TabIndex = 1;
            label1.Text = "Số lượng";
            // 
            // btn_confirm
            // 
            btn_confirm.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_confirm.Location = new Point(819, 84);
            btn_confirm.Name = "btn_confirm";
            btn_confirm.Size = new Size(184, 49);
            btn_confirm.TabIndex = 2;
            btn_confirm.Text = "Xác nhận";
            btn_confirm.UseVisualStyleBackColor = true;
            btn_confirm.Click += btn_confirm_Click;
            // 
            // AddProductWithCart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Logo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1113, 334);
            Controls.Add(btn_confirm);
            Controls.Add(label1);
            Controls.Add(txt_Quantity);
            DoubleBuffered = true;
            Name = "AddProductWithCart";
            Text = "AddProductWithCart";
            Load += AddProductWithCart_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Quantity;
        private Label label1;
        private Button btn_confirm;
    }
}