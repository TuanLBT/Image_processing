namespace XLA_project4
{
    partial class RGB_sharpen
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
            this.pic_sharp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_goc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_sharp)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_goc
            // 
            this.pic_goc.Location = new System.Drawing.Point(18, 83);
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
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hình gốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(612, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đã full HD";
            // 
            // pic_sharp
            // 
            this.pic_sharp.Location = new System.Drawing.Point(618, 83);
            this.pic_sharp.Name = "pic_sharp";
            this.pic_sharp.Size = new System.Drawing.Size(512, 512);
            this.pic_sharp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_sharp.TabIndex = 2;
            this.pic_sharp.TabStop = false;
            // 
            // RGB_sharpen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 1055);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pic_sharp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_goc);
            this.Name = "RGB_sharpen";
            this.Text = "RGB_sharpen";
            ((System.ComponentModel.ISupportInitialize)(this.pic_goc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_sharp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_goc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pic_sharp;
    }
}