namespace XLA_project4
{
    partial class Edge_Detection_RGB
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
            this.pictureBox_goc = new System.Windows.Forms.PictureBox();
            this.pictureBox_edge = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Edge_run = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.hScrollBar_nguong = new System.Windows.Forms.HScrollBar();
            this.lb_value = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_goc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_edge)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_goc
            // 
            this.pictureBox_goc.Location = new System.Drawing.Point(21, 49);
            this.pictureBox_goc.Name = "pictureBox_goc";
            this.pictureBox_goc.Size = new System.Drawing.Size(512, 512);
            this.pictureBox_goc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_goc.TabIndex = 0;
            this.pictureBox_goc.TabStop = false;
            // 
            // pictureBox_edge
            // 
            this.pictureBox_edge.Location = new System.Drawing.Point(594, 49);
            this.pictureBox_edge.Name = "pictureBox_edge";
            this.pictureBox_edge.Size = new System.Drawing.Size(512, 512);
            this.pictureBox_edge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_edge.TabIndex = 1;
            this.pictureBox_edge.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(599, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Edge after detection";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hình gốc";
            // 
            // button_Edge_run
            // 
            this.button_Edge_run.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_Edge_run.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Edge_run.ForeColor = System.Drawing.Color.Fuchsia;
            this.button_Edge_run.Location = new System.Drawing.Point(605, 567);
            this.button_Edge_run.Name = "button_Edge_run";
            this.button_Edge_run.Size = new System.Drawing.Size(330, 111);
            this.button_Edge_run.TabIndex = 10;
            this.button_Edge_run.Text = "Nhận dạng Biên";
            this.button_Edge_run.UseVisualStyleBackColor = false;
            this.button_Edge_run.Click += new System.EventHandler(this.button_Edge_run_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(388, 588);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ngưỡng";
            // 
            // hScrollBar_nguong
            // 
            this.hScrollBar_nguong.Location = new System.Drawing.Point(46, 588);
            this.hScrollBar_nguong.Maximum = 255;
            this.hScrollBar_nguong.Name = "hScrollBar_nguong";
            this.hScrollBar_nguong.Size = new System.Drawing.Size(319, 21);
            this.hScrollBar_nguong.TabIndex = 8;
            this.hScrollBar_nguong.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar_nguong_Scroll);
            // 
            // lb_value
            // 
            this.lb_value.AutoSize = true;
            this.lb_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_value.ForeColor = System.Drawing.Color.Red;
            this.lb_value.Location = new System.Drawing.Point(117, 626);
            this.lb_value.Name = "lb_value";
            this.lb_value.Size = new System.Drawing.Size(0, 32);
            this.lb_value.TabIndex = 11;
            // 
            // Edge_Detection_RGB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 1055);
            this.Controls.Add(this.lb_value);
            this.Controls.Add(this.button_Edge_run);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hScrollBar_nguong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_edge);
            this.Controls.Add(this.pictureBox_goc);
            this.Name = "Edge_Detection_RGB";
            this.Text = "Edge_Detection_RGB";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_goc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_edge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_goc;
        private System.Windows.Forms.PictureBox pictureBox_edge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Edge_run;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.HScrollBar hScrollBar_nguong;
        private System.Windows.Forms.Label lb_value;
    }
}