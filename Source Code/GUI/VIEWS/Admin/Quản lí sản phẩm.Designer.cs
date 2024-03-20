namespace ShopNow.Source_Code.GUI.VIEWS.Admin
{
    partial class Quản_lí_sản_phẩm
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            btn_QLKH = new Button();
            btn_QLBH = new Button();
            btn_QLNV = new Button();
            btn_QLSP = new Button();
            ptb_Quanlisanpham = new PictureBox();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_Quanlisanpham).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btn_QLKH);
            groupBox1.Controls.Add(btn_QLBH);
            groupBox1.Controls.Add(btn_QLNV);
            groupBox1.Controls.Add(btn_QLSP);
            groupBox1.Controls.Add(ptb_Quanlisanpham);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(292, 754);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năng";
            // 
            // button2
            // 
            button2.Location = new Point(6, 476);
            button2.Name = "button2";
            button2.Size = new Size(280, 45);
            button2.TabIndex = 1;
            button2.Text = "...";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(6, 425);
            button1.Name = "button1";
            button1.Size = new Size(280, 45);
            button1.TabIndex = 1;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = true;
            // 
            // btn_QLKH
            // 
            btn_QLKH.Location = new Point(6, 374);
            btn_QLKH.Name = "btn_QLKH";
            btn_QLKH.Size = new Size(280, 45);
            btn_QLKH.TabIndex = 1;
            btn_QLKH.Text = "Quản lí khách hàng";
            btn_QLKH.UseVisualStyleBackColor = true;
            // 
            // btn_QLBH
            // 
            btn_QLBH.Location = new Point(6, 323);
            btn_QLBH.Name = "btn_QLBH";
            btn_QLBH.Size = new Size(280, 45);
            btn_QLBH.TabIndex = 1;
            btn_QLBH.Text = "Quản lí bán hàng";
            btn_QLBH.UseVisualStyleBackColor = true;
            // 
            // btn_QLNV
            // 
            btn_QLNV.Location = new Point(6, 272);
            btn_QLNV.Name = "btn_QLNV";
            btn_QLNV.Size = new Size(280, 45);
            btn_QLNV.TabIndex = 1;
            btn_QLNV.Text = "Quản lí nhân viên";
            btn_QLNV.UseVisualStyleBackColor = true;
            // 
            // btn_QLSP
            // 
            btn_QLSP.Location = new Point(6, 221);
            btn_QLSP.Name = "btn_QLSP";
            btn_QLSP.Size = new Size(280, 45);
            btn_QLSP.TabIndex = 1;
            btn_QLSP.Text = "Quản lí sản phẩm";
            btn_QLSP.UseVisualStyleBackColor = true;
            // 
            // ptb_Quanlisanpham
            // 
            ptb_Quanlisanpham.BackColor = SystemColors.ActiveCaption;
            ptb_Quanlisanpham.Location = new Point(6, 26);
            ptb_Quanlisanpham.Name = "ptb_Quanlisanpham";
            ptb_Quanlisanpham.Size = new Size(280, 170);
            ptb_Quanlisanpham.TabIndex = 0;
            ptb_Quanlisanpham.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(310, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(916, 521);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hiển thị";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(9, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(901, 413);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(9, 23);
            label1.Name = "label1";
            label1.Size = new Size(200, 31);
            label1.TabIndex = 1;
            label1.Text = "Quản lí sản phẩm";
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(310, 539);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(916, 227);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hình ảnh";
            // 
            // Quản_lí_sản_phẩm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 778);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Quản_lí_sản_phẩm";
            Text = "Quản_lí_sản_phẩm";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptb_Quanlisanpham).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox1;
        private Button btn_QLKH;
        private Button btn_QLBH;
        private Button btn_QLNV;
        private Button btn_QLSP;
        private PictureBox ptb_Quanlisanpham;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private Button button2;
        private Button button1;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private Label label1;
    }
}