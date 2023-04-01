namespace XLA_project4
{
    partial class RGB_Smooth
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_smooth = new System.Windows.Forms.PictureBox();
            this.button_3x3 = new System.Windows.Forms.Button();
            this.button_5x5 = new System.Windows.Forms.Button();
            this.button_7x7 = new System.Windows.Forms.Button();
            this.button_9x9 = new System.Windows.Forms.Button();
            this.label_mau = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_goc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_smooth)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_goc
            // 
            this.pic_goc.Location = new System.Drawing.Point(8, 28);
            this.pic_goc.Name = "pic_goc";
            this.pic_goc.Size = new System.Drawing.Size(512, 512);
            this.pic_goc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_goc.TabIndex = 0;
            this.pic_goc.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, -7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ảnh gốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(542, -7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Smoothed\r\n";
            // 
            // pic_smooth
            // 
            this.pic_smooth.Location = new System.Drawing.Point(548, 28);
            this.pic_smooth.Name = "pic_smooth";
            this.pic_smooth.Size = new System.Drawing.Size(512, 512);
            this.pic_smooth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_smooth.TabIndex = 2;
            this.pic_smooth.TabStop = false;
            // 
            // button_3x3
            // 
            this.button_3x3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_3x3.Location = new System.Drawing.Point(12, 584);
            this.button_3x3.Name = "button_3x3";
            this.button_3x3.Size = new System.Drawing.Size(218, 100);
            this.button_3x3.TabIndex = 4;
            this.button_3x3.Text = "mask 3x3";
            this.button_3x3.UseVisualStyleBackColor = true;
            this.button_3x3.Click += new System.EventHandler(this.button_3x3_Click);
            // 
            // button_5x5
            // 
            this.button_5x5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_5x5.Location = new System.Drawing.Point(274, 584);
            this.button_5x5.Name = "button_5x5";
            this.button_5x5.Size = new System.Drawing.Size(218, 100);
            this.button_5x5.TabIndex = 5;
            this.button_5x5.Text = "mask 5x5";
            this.button_5x5.UseVisualStyleBackColor = true;
            this.button_5x5.Click += new System.EventHandler(this.button_5x5_Click);
            // 
            // button_7x7
            // 
            this.button_7x7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_7x7.Location = new System.Drawing.Point(548, 584);
            this.button_7x7.Name = "button_7x7";
            this.button_7x7.Size = new System.Drawing.Size(218, 100);
            this.button_7x7.TabIndex = 6;
            this.button_7x7.Text = "mask 7x7";
            this.button_7x7.UseVisualStyleBackColor = true;
            this.button_7x7.Click += new System.EventHandler(this.button_7x7_Click);
            // 
            // button_9x9
            // 
            this.button_9x9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_9x9.Location = new System.Drawing.Point(808, 584);
            this.button_9x9.Name = "button_9x9";
            this.button_9x9.Size = new System.Drawing.Size(218, 100);
            this.button_9x9.TabIndex = 7;
            this.button_9x9.Text = "mask 9x9";
            this.button_9x9.UseVisualStyleBackColor = true;
            this.button_9x9.Click += new System.EventHandler(this.button_9x9_Click);
            // 
            // label_mau
            // 
            this.label_mau.AutoSize = true;
            this.label_mau.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mau.Location = new System.Drawing.Point(1066, 39);
            this.label_mau.Name = "label_mau";
            this.label_mau.Size = new System.Drawing.Size(0, 29);
            this.label_mau.TabIndex = 8;
            // 
            // RGB_Smooth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.label_mau);
            this.Controls.Add(this.button_9x9);
            this.Controls.Add(this.button_7x7);
            this.Controls.Add(this.button_5x5);
            this.Controls.Add(this.button_3x3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pic_smooth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_goc);
            this.Name = "RGB_Smooth";
            this.Text = "RGB_Smooth";
            ((System.ComponentModel.ISupportInitialize)(this.pic_goc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_smooth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_goc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pic_smooth;
        private System.Windows.Forms.Button button_3x3;
        private System.Windows.Forms.Button button_5x5;
        private System.Windows.Forms.Button button_7x7;
        private System.Windows.Forms.Button button_9x9;
        private System.Windows.Forms.Label label_mau;
    }
}