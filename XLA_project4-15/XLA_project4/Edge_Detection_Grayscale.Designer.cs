namespace XLA_project4
{
    partial class Edge_Detection_Grayscale
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
            this.pictureBox_hinhgoc = new System.Windows.Forms.PictureBox();
            this.pictureBox_edge = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hScrollBar_nguong = new System.Windows.Forms.HScrollBar();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_value_nguong = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_hinhgoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_edge)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_hinhgoc
            // 
            this.pictureBox_hinhgoc.Location = new System.Drawing.Point(28, 40);
            this.pictureBox_hinhgoc.Name = "pictureBox_hinhgoc";
            this.pictureBox_hinhgoc.Size = new System.Drawing.Size(512, 512);
            this.pictureBox_hinhgoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_hinhgoc.TabIndex = 0;
            this.pictureBox_hinhgoc.TabStop = false;
            // 
            // pictureBox_edge
            // 
            this.pictureBox_edge.Location = new System.Drawing.Point(625, 40);
            this.pictureBox_edge.Name = "pictureBox_edge";
            this.pictureBox_edge.Size = new System.Drawing.Size(512, 512);
            this.pictureBox_edge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_edge.TabIndex = 1;
            this.pictureBox_edge.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(35, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hình gốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(619, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Edge after detection";
            // 
            // hScrollBar_nguong
            // 
            this.hScrollBar_nguong.Location = new System.Drawing.Point(41, 585);
            this.hScrollBar_nguong.Maximum = 255;
            this.hScrollBar_nguong.Name = "hScrollBar_nguong";
            this.hScrollBar_nguong.Size = new System.Drawing.Size(319, 21);
            this.hScrollBar_nguong.TabIndex = 4;
            this.hScrollBar_nguong.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar_nguong_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(383, 585);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngưỡng";
            // 
            // lb_value_nguong
            // 
            this.lb_value_nguong.AutoSize = true;
            this.lb_value_nguong.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_value_nguong.ForeColor = System.Drawing.Color.Red;
            this.lb_value_nguong.Location = new System.Drawing.Point(116, 618);
            this.lb_value_nguong.Name = "lb_value_nguong";
            this.lb_value_nguong.Size = new System.Drawing.Size(0, 32);
            this.lb_value_nguong.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Fuchsia;
            this.button1.Location = new System.Drawing.Point(625, 568);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(330, 111);
            this.button1.TabIndex = 7;
            this.button1.Text = "Nhận dạng Biên";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Edge_Detection_Grayscale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 1055);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_value_nguong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hScrollBar_nguong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_edge);
            this.Controls.Add(this.pictureBox_hinhgoc);
            this.Name = "Edge_Detection_Grayscale";
            this.Text = "Edge_Detection_grayscale";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_hinhgoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_edge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_hinhgoc;
        private System.Windows.Forms.PictureBox pictureBox_edge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.HScrollBar hScrollBar_nguong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_value_nguong;
        private System.Windows.Forms.Button button1;
    }
}