using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XLA_project4
{
    public partial class RGB_to_CMYK : Form
    {
        public RGB_to_CMYK()
        {
            InitializeComponent();
            //trích xuất ảnh và hiện lên picbox
            Bitmap hinhgoc = new Bitmap(@"D:\picture\file_xla\lena_color.jpg");
            pic_goc.Image = hinhgoc;

            List<Bitmap> CMYK = chuyendoirgbsang_cmyk(hinhgoc);
            pic_cyan.Image = CMYK[0];
            pic_magenta.Image = CMYK[1];
            pic_yellow.Image = CMYK[2];
            pic_kblack.Image = CMYK[3];


        }
        public List<Bitmap> chuyendoirgbsang_cmyk(Bitmap hinhgoc)
        {
            List<Bitmap> CMYK = new List<Bitmap>();

            Bitmap cyan = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap magenta = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap yellow = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap black = new Bitmap(hinhgoc.Width, hinhgoc.Height);

            for (int x = 0; x<hinhgoc.Width; x++)
                for(int y =0; y<hinhgoc.Height;y++)
            {
                    Color pixel = hinhgoc.GetPixel(x, y);
                    byte r = pixel.R;
                    byte g = pixel.G;
                    byte b = pixel.B;
                    byte k = Math.Min(r, Math.Min(g, b));

                    //Color.FromArgb(r,g,b) là hàm cấu trúc màu 8 bit gồm 3 phần tử là red, green và blue
                    //cyan = green + blue; magenta = r +b; yellow = red + green; 
                    cyan.SetPixel(x,y, Color.FromArgb(0,g,b));
                    magenta.SetPixel(x, y, Color.FromArgb(r, 0, b));
                    yellow.SetPixel(x, y, Color.FromArgb(r, g, 0));
                    black.SetPixel(x, y, Color.FromArgb(k, k, k));

                }
            CMYK.Add(cyan);
            CMYK.Add(magenta);
            CMYK.Add(yellow); 
            CMYK.Add(black);

            return CMYK;
        }
    }
}
