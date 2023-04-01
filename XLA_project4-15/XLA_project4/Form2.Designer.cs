namespace XLA_project4
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.pic_hinhgoc = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_luminance = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.zgray = new ZedGraph.ZedGraphControl();
            ((System.ComponentModel.ISupportInitialize)(this.pic_hinhgoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_luminance)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_hinhgoc
            // 
            this.pic_hinhgoc.Location = new System.Drawing.Point(12, 28);
            this.pic_hinhgoc.Name = "pic_hinhgoc";
            this.pic_hinhgoc.Size = new System.Drawing.Size(500, 381);
            this.pic_hinhgoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_hinhgoc.TabIndex = 0;
            this.pic_hinhgoc.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hình gốc";
            // 
            // pic_luminance
            // 
            this.pic_luminance.Location = new System.Drawing.Point(15, 424);
            this.pic_luminance.Name = "pic_luminance";
            this.pic_luminance.Size = new System.Drawing.Size(500, 381);
            this.pic_luminance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_luminance.TabIndex = 2;
            this.pic_luminance.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "mức xám luminance";
            // 
            // zgray
            // 
            this.zgray.Location = new System.Drawing.Point(522, 13);
            this.zgray.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zgray.Name = "zgray";
            this.zgray.ScrollGrace = 0D;
            this.zgray.ScrollMaxX = 0D;
            this.zgray.ScrollMaxY = 0D;
            this.zgray.ScrollMaxY2 = 0D;
            this.zgray.ScrollMinX = 0D;
            this.zgray.ScrollMinY = 0D;
            this.zgray.ScrollMinY2 = 0D;
            this.zgray.Size = new System.Drawing.Size(1034, 623);
            this.zgray.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.zgray);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pic_luminance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_hinhgoc);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pic_hinhgoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_luminance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_hinhgoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_luminance;
        private System.Windows.Forms.Label label2;
        private ZedGraph.ZedGraphControl zgray;
    }
}