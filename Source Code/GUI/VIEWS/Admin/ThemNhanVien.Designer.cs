namespace ShopNow.Source_Code.GUI.VIEWS.Admin
{
    partial class ThemNhanVien
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(84, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(328, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "UserName";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(84, 92);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(328, 27);
            textBox2.TabIndex = 0;
            textBox2.Text = "Pass";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(84, 149);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(328, 27);
            textBox3.TabIndex = 0;
            textBox3.Text = "Tên nhân viên";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(84, 206);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(328, 27);
            textBox4.TabIndex = 0;
            textBox4.Text = "Email";
            // 
            // button1
            // 
            button1.Location = new Point(84, 277);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Lưu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ThemNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "ThemNhanVien";
            Text = "ThemNhanVien";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
    }
}