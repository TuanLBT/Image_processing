using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace XLA_project4
{
    public partial class SEGMENTATION_IN_RGB : Form
    {
        Bitmap hinhgoc;
        int x1, x2, y1, y2;
        double[] a = new double[3];
        private void button_SEG_Click(object sender, EventArgs e)
        {
            hinhgoc = new Bitmap(@"D:\picture\file_xla\lena_color.jpg");
            //Bitmap smooth_img = colorimagesmoothing5x5(hinhgoc);
            int x1 = int.Parse(textBox_X1.Text);
            int x2 = int.Parse(textBox_X2.Text);
            int y2 = int.Parse(textBox_Y2.Text);
            int y1 = int.Parse(textBox_Y1.Text);
            int nguong = int.Parse(textBox_nguong.Text);
            a = vectormautrungbinh(hinhgoc, x1, x2, y1, y2);
            Bitmap seg_img = Segmentation(hinhgoc, nguong, a);
            pic_seg.Image = seg_img;
        }

        public SEGMENTATION_IN_RGB()
        {
            InitializeComponent();
            hinhgoc = new Bitmap(@"D:\picture\file_xla\lena_color.jpg");
            pic_goc.Image = hinhgoc;
        }
        public double[] vectormautrungbinh(Bitmap hinhgoc, int x1, int x2, int y1, int y2)
        {
            //mảng chứa giá trị trung bình gồm 3 hàng, 256 cột
            double[] a = new double[3];
            a[0] = 0; a[1] = 0; a[2] = 0;
            for (int i = x1; i < x2; i++)
                for (int j = y1; j < y2; j++)
                {
                    Color pixel = hinhgoc.GetPixel(i, j);
                    // cộng dồn giá trị pixel vào array từng phần tử (cột)
                    a[0] += pixel.R;
                    a[1] += pixel.G;
                    a[2] += pixel.B;
                }
            double size = Math.Abs(x2 - x1) * Math.Abs(y2 - y1);
            //chia rồi đưa giá trị đã chia vào từng phần tử của mảng a
            a[0] /= size;
            a[1] /= size;
            a[2] /= size;
            return a;
        }

        public Bitmap Segmentation(Bitmap hinhgoc, int nguong, double[] a)
        {
            Bitmap Seg_img = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            for (int i = 0; i < hinhgoc.Width; i++)
            {
                for (int j = 0; j < hinhgoc.Height; j++)
                {
                    Color pixel = hinhgoc.GetPixel(i, j);
                    double zR = pixel.R;
                    double zG = pixel.G;
                    double zB = pixel.B;
                    double D = Math.Sqrt(Math.Pow((double)(zR - a[0]), 2.0) + Math.Pow((double)(zG - a[1]), 2.0) + Math.Pow((double)(zB - a[2]), 2.0));
                    if (D <= nguong)
                    {
                        Seg_img.SetPixel(i, j, Color.FromArgb(255, 255, 255));
                    }
                    else
                    {
                        Seg_img.SetPixel(i, j, Color.FromArgb((int)zR, (int)zG, (int)zB));
                    }    
                }
            }
            return Seg_img;
        }
    }
}

