namespace ShopNow.Source_Code.GUI.VIEWS.Home
{
    partial class HomeForCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForCustomer));
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            comboBox3 = new ComboBox();
            button3 = new Button();
            comboBox1 = new ComboBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(538, 33);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "SIgn In";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(638, 33);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "My Cart";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(235, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(234, 27);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(255, 192, 192);
            groupBox2.Controls.Add(button11);
            groupBox2.Controls.Add(button10);
            groupBox2.Controls.Add(button9);
            groupBox2.Controls.Add(button8);
            groupBox2.Controls.Add(button7);
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(comboBox3);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(33, 335);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(699, 508);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Series" });
            comboBox3.Location = new Point(578, 26);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(103, 28);
            comboBox3.TabIndex = 11;
            comboBox3.Text = "Giá";
            // 
            // button3
            // 
            button3.Location = new Point(258, 473);
            button3.Name = "button3";
            button3.Size = new Size(198, 29);
            button3.TabIndex = 9;
            button3.Text = "Show more";
            button3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Series" });
            comboBox1.Location = new Point(447, 26);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(103, 28);
            comboBox1.TabIndex = 3;
            comboBox1.Text = "Series";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(282, 26);
            label2.Name = "label2";
            label2.Size = new Size(120, 31);
            label2.TabIndex = 0;
            label2.Text = "Sản phẩm";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(33, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(699, 261);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button4
            // 
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(33, 12);
            button4.Name = "button4";
            button4.Size = new Size(196, 50);
            button4.TabIndex = 37;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(480, 34);
            button5.Name = "button5";
            button5.Size = new Size(43, 29);
            button5.TabIndex = 38;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(63, 74);
            button6.Name = "button6";
            button6.Size = new Size(147, 177);
            button6.TabIndex = 12;
            button6.Text = "Ảnh sản phẩm ";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(282, 275);
            button7.Name = "button7";
            button7.Size = new Size(147, 177);
            button7.TabIndex = 13;
            button7.Text = "Ảnh sản phẩm ";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(63, 275);
            button8.Name = "button8";
            button8.Size = new Size(147, 177);
            button8.TabIndex = 14;
            button8.Text = "Ảnh sản phẩm ";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(282, 74);
            button9.Name = "button9";
            button9.Size = new Size(147, 177);
            button9.TabIndex = 15;
            button9.Text = "Ảnh sản phẩm ";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(496, 74);
            button10.Name = "button10";
            button10.Size = new Size(147, 177);
            button10.TabIndex = 16;
            button10.Text = "Ảnh sản phẩm ";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new Point(496, 278);
            button11.Name = "button11";
            button11.Size = new Size(147, 177);
            button11.TabIndex = 17;
            button11.Text = "Ảnh sản phẩm ";
            button11.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(765, 1055);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private ComboBox comboBox1;
        private Label label2;
        private ComboBox comboBox3;
        private Button button3;
        private PictureBox pictureBox1;
        private Button button4;
        private Button button5;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
    }
}