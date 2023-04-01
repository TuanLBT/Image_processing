namespace XLA_project4
{
    partial class Form_histogram_RGB
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
            this.zrgb = new ZedGraph.ZedGraphControl();
            ((System.ComponentModel.ISupportInitialize)(this.pic_hinhgoc)).BeginInit();
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
            this.label1.Text = "Hinh goc";
            // 
            // zrgb
            // 
            this.zrgb.AutoSize = true;
            this.zrgb.Location = new System.Drawing.Point(519, 28);
            this.zrgb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zrgb.Name = "zrgb";
            this.zrgb.ScrollGrace = 0D;
            this.zrgb.ScrollMaxX = 0D;
            this.zrgb.ScrollMaxY = 0D;
            this.zrgb.ScrollMaxY2 = 0D;
            this.zrgb.ScrollMinX = 0D;
            this.zrgb.ScrollMinY = 0D;
            this.zrgb.ScrollMinY2 = 0D;
            this.zrgb.Size = new System.Drawing.Size(950, 700);
            this.zrgb.TabIndex = 2;
            // 
            // Form_histogram_RGB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1482, 1055);
            this.Controls.Add(this.zrgb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_hinhgoc);
            this.Name = "Form_histogram_RGB";
            this.Text = "Form_histogram_RGB";
            ((System.ComponentModel.ISupportInitialize)(this.pic_hinhgoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_hinhgoc;
        private System.Windows.Forms.Label label1;
        private ZedGraph.ZedGraphControl zrgb;
    }
}