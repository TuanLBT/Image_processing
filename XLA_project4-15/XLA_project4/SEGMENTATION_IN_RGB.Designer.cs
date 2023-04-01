namespace XLA_project4
{
    partial class SEGMENTATION_IN_RGB
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
            this.pic_goc = new System.Windows.Forms.PictureBox();
            this.pic_seg = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_X1 = new System.Windows.Forms.TextBox();
            this.textBox_Y1 = new System.Windows.Forms.TextBox();
            this.textBox_X2 = new System.Windows.Forms.TextBox();
            this.textBox_Y2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_nguong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button_SEG = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_goc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_seg)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_goc
            // 
            this.pic_goc.Location = new System.Drawing.Point(12, 277);
            this.pic_goc.Name = "pic_goc";
            this.pic_goc.Size = new System.Drawing.Size(512, 512);
            this.pic_goc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_goc.TabIndex = 0;
            this.pic_goc.TabStop = false;
            // 
            // pic_seg
            // 
            this.pic_seg.Location = new System.Drawing.Point(624, 277);
            this.pic_seg.Name = "pic_seg";
            this.pic_seg.Size = new System.Drawing.Size(512, 512);
            this.pic_seg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_seg.TabIndex = 1;
            this.pic_seg.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hình gốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(633, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hình được phân đoạn ảnh";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_Y2);
            this.groupBox1.Controls.Add(this.textBox_X2);
            this.groupBox1.Controls.Add(this.textBox_Y1);
            this.groupBox1.Controls.Add(this.textBox_X1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(125, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 195);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CHỌN VÙNG ẢNH ĐỂ PHÂN ĐOẠN";
            // 
            // textBox_X1
            // 
            this.textBox_X1.Location = new System.Drawing.Point(70, 46);
            this.textBox_X1.Name = "textBox_X1";
            this.textBox_X1.Size = new System.Drawing.Size(100, 34);
            this.textBox_X1.TabIndex = 0;
            // 
            // textBox_Y1
            // 
            this.textBox_Y1.Location = new System.Drawing.Point(70, 118);
            this.textBox_Y1.Name = "textBox_Y1";
            this.textBox_Y1.Size = new System.Drawing.Size(100, 34);
            this.textBox_Y1.TabIndex = 1;
            // 
            // textBox_X2
            // 
            this.textBox_X2.Location = new System.Drawing.Point(258, 46);
            this.textBox_X2.Name = "textBox_X2";
            this.textBox_X2.Size = new System.Drawing.Size(100, 34);
            this.textBox_X2.TabIndex = 2;
            // 
            // textBox_Y2
            // 
            this.textBox_Y2.Location = new System.Drawing.Point(258, 118);
            this.textBox_Y2.Name = "textBox_Y2";
            this.textBox_Y2.Size = new System.Drawing.Size(100, 34);
            this.textBox_Y2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "X1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Y1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "X2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(209, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 29);
            this.label6.TabIndex = 7;
            this.label6.Text = "Y2";
            // 
            // textBox_nguong
            // 
            this.textBox_nguong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nguong.Location = new System.Drawing.Point(639, 58);
            this.textBox_nguong.Name = "textBox_nguong";
            this.textBox_nguong.Size = new System.Drawing.Size(129, 34);
            this.textBox_nguong.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(618, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 32);
            this.label8.TabIndex = 10;
            this.label8.Text = "Chọn Ngưỡng";
            // 
            // button_SEG
            // 
            this.button_SEG.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_SEG.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SEG.ForeColor = System.Drawing.Color.Red;
            this.button_SEG.Location = new System.Drawing.Point(871, 45);
            this.button_SEG.Name = "button_SEG";
            this.button_SEG.Size = new System.Drawing.Size(204, 61);
            this.button_SEG.TabIndex = 11;
            this.button_SEG.Text = "PHÂN ĐOẠN";
            this.button_SEG.UseVisualStyleBackColor = false;
            this.button_SEG.Click += new System.EventHandler(this.button_SEG_Click);
            // 
            // SEGMENTATION_IN_RGB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 1055);
            this.Controls.Add(this.button_SEG);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_nguong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_seg);
            this.Controls.Add(this.pic_goc);
            this.Name = "SEGMENTATION_IN_RGB";
            this.Text = "SEGMENTATION_IN_RGB";
            ((System.ComponentModel.ISupportInitialize)(this.pic_goc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_seg)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_goc;
        private System.Windows.Forms.PictureBox pic_seg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Y2;
        private System.Windows.Forms.TextBox textBox_X2;
        private System.Windows.Forms.TextBox textBox_Y1;
        private System.Windows.Forms.TextBox textBox_X1;
        private System.Windows.Forms.TextBox textBox_nguong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_SEG;
    }
}