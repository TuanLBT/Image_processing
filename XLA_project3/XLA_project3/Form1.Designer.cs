namespace XLA_project3
{
    partial class Form1
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
            this.picbox_anhgoc = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picbox_average = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picbox_lightness = new System.Windows.Forms.PictureBox();
            this.picbox_luminance = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_anhgoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_average)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_lightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_luminance)).BeginInit();
            this.SuspendLayout();
            // 
            // picbox_anhgoc
            // 
            this.picbox_anhgoc.Location = new System.Drawing.Point(28, 18);
            this.picbox_anhgoc.Name = "picbox_anhgoc";
            this.picbox_anhgoc.Size = new System.Drawing.Size(512, 512);
            this.picbox_anhgoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_anhgoc.TabIndex = 0;
            this.picbox_anhgoc.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ảnh gốc";
            // 
            // picbox_average
            // 
            this.picbox_average.Location = new System.Drawing.Point(619, 18);
            this.picbox_average.Name = "picbox_average";
            this.picbox_average.Size = new System.Drawing.Size(512, 512);
            this.picbox_average.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_average.TabIndex = 2;
            this.picbox_average.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(616, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "average";
            // 
            // picbox_lightness
            // 
            this.picbox_lightness.Location = new System.Drawing.Point(28, 550);
            this.picbox_lightness.Name = "picbox_lightness";
            this.picbox_lightness.Size = new System.Drawing.Size(512, 512);
            this.picbox_lightness.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_lightness.TabIndex = 4;
            this.picbox_lightness.TabStop = false;
            // 
            // picbox_luminance
            // 
            this.picbox_luminance.Location = new System.Drawing.Point(619, 550);
            this.picbox_luminance.Name = "picbox_luminance";
            this.picbox_luminance.Size = new System.Drawing.Size(512, 512);
            this.picbox_luminance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_luminance.TabIndex = 5;
            this.picbox_luminance.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 531);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "lightness";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(614, 531);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Luminance";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 1055);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picbox_luminance);
            this.Controls.Add(this.picbox_lightness);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picbox_average);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picbox_anhgoc);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picbox_anhgoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_average)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_lightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_luminance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbox_anhgoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picbox_average;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picbox_lightness;
        private System.Windows.Forms.PictureBox picbox_luminance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

