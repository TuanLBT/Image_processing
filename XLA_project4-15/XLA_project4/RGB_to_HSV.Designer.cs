namespace XLA_project4
{
    partial class RGB_to_HSV
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
            this.pic_hue = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pic_sat = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pic_value = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pic_HSV = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_goc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_hue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_sat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_HSV)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_goc
            // 
            this.pic_goc.Location = new System.Drawing.Point(29, 56);
            this.pic_goc.Name = "pic_goc";
            this.pic_goc.Size = new System.Drawing.Size(256, 256);
            this.pic_goc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_goc.TabIndex = 0;
            this.pic_goc.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hình gốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hue";
            // 
            // pic_hue
            // 
            this.pic_hue.Location = new System.Drawing.Point(29, 403);
            this.pic_hue.Name = "pic_hue";
            this.pic_hue.Size = new System.Drawing.Size(256, 256);
            this.pic_hue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_hue.TabIndex = 2;
            this.pic_hue.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(311, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "saturation";
            // 
            // pic_sat
            // 
            this.pic_sat.Location = new System.Drawing.Point(314, 403);
            this.pic_sat.Name = "pic_sat";
            this.pic_sat.Size = new System.Drawing.Size(256, 256);
            this.pic_sat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_sat.TabIndex = 4;
            this.pic_sat.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(599, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "value";
            // 
            // pic_value
            // 
            this.pic_value.Location = new System.Drawing.Point(602, 403);
            this.pic_value.Name = "pic_value";
            this.pic_value.Size = new System.Drawing.Size(256, 256);
            this.pic_value.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_value.TabIndex = 6;
            this.pic_value.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(882, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "HSV";
            // 
            // pic_HSV
            // 
            this.pic_HSV.Location = new System.Drawing.Point(885, 403);
            this.pic_HSV.Name = "pic_HSV";
            this.pic_HSV.Size = new System.Drawing.Size(256, 256);
            this.pic_HSV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_HSV.TabIndex = 8;
            this.pic_HSV.TabStop = false;
            // 
            // RGB_to_HSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 1055);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pic_HSV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pic_value);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pic_sat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pic_hue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_goc);
            this.Name = "RGB_to_HSV";
            this.Text = "RGB_to_HSV";
            ((System.ComponentModel.ISupportInitialize)(this.pic_goc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_hue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_sat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_HSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_goc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pic_hue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pic_sat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pic_value;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pic_HSV;
    }
}