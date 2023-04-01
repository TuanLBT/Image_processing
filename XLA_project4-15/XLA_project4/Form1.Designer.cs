namespace XLA_project4
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
            this.picbox_nhiphan = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vScrollBar_hinhnhiphan = new System.Windows.Forms.VScrollBar();
            this.label3 = new System.Windows.Forms.Label();
            this.lblnguong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_anhgoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_nhiphan)).BeginInit();
            this.SuspendLayout();
            // 
            // picbox_anhgoc
            // 
            this.picbox_anhgoc.Location = new System.Drawing.Point(32, 72);
            this.picbox_anhgoc.Name = "picbox_anhgoc";
            this.picbox_anhgoc.Size = new System.Drawing.Size(512, 512);
            this.picbox_anhgoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_anhgoc.TabIndex = 0;
            this.picbox_anhgoc.TabStop = false;
            // 
            // picbox_nhiphan
            // 
            this.picbox_nhiphan.Location = new System.Drawing.Point(583, 72);
            this.picbox_nhiphan.Name = "picbox_nhiphan";
            this.picbox_nhiphan.Size = new System.Drawing.Size(512, 512);
            this.picbox_nhiphan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_nhiphan.TabIndex = 1;
            this.picbox_nhiphan.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ảnh gốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(580, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "ảnh nhị phân";
            // 
            // vScrollBar_hinhnhiphan
            // 
            this.vScrollBar_hinhnhiphan.LargeChange = 1;
            this.vScrollBar_hinhnhiphan.Location = new System.Drawing.Point(1122, 93);
            this.vScrollBar_hinhnhiphan.Maximum = 255;
            this.vScrollBar_hinhnhiphan.Name = "vScrollBar_hinhnhiphan";
            this.vScrollBar_hinhnhiphan.Size = new System.Drawing.Size(21, 227);
            this.vScrollBar_hinhnhiphan.TabIndex = 4;
            this.vScrollBar_hinhnhiphan.ValueChanged += new System.EventHandler(this.scoll_valuechange);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1119, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngưỡng";
            // 
            // lblnguong
            // 
            this.lblnguong.AutoSize = true;
            this.lblnguong.Location = new System.Drawing.Point(1125, 333);
            this.lblnguong.Name = "lblnguong";
            this.lblnguong.Size = new System.Drawing.Size(0, 16);
            this.lblnguong.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 651);
            this.Controls.Add(this.lblnguong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vScrollBar_hinhnhiphan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picbox_nhiphan);
            this.Controls.Add(this.picbox_anhgoc);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picbox_anhgoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_nhiphan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbox_anhgoc;
        private System.Windows.Forms.PictureBox picbox_nhiphan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.VScrollBar vScrollBar_hinhnhiphan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblnguong;
    }
}

