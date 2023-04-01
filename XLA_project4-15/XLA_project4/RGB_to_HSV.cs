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
    public partial class RGB_to_HSV : Form
    {
        public RGB_to_HSV()
        {
            InitializeComponent();
            //trích xuất ảnh và hiện lên picbox
            Bitmap hinhgoc = new Bitmap(@"D:\picture\file_xla\lena_color.jpg");
            pic_goc.Image = hinhgoc;

            List<Bitmap> HSV = chuyendoirgbsang_hsv(hinhgoc);
            pic_hue.Image = HSV[0];
            pic_sat.Image = HSV[1];
            pic_value.Image = HSV[2];
            pic_HSV.Image = HSV[3];
        }
        public List<Bitmap> chuyendoirgbsang_hsv(Bitmap hinhgoc)
        {
            List<Bitmap> HSV = new List<Bitmap>();

            Bitmap hue = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap saturation = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap value = new Bitmap(hinhgoc.Width, hinhgoc.Height);

            //Hình HSI kết hợp cả 3 cái hình trên
            Bitmap hsv_image = new Bitmap(hinhgoc.Width, hinhgoc.Height);

            for (int x = 0; x < hinhgoc.Width; x++)
                for (int y = 0; y < hinhgoc.Height; y++)
                {
                    Color pixel = hinhgoc.GetPixel(x, y);
                    // do công thức tính toán chỉ trả về giá trị là số thực nên không sử dụng byte được
                    double r = pixel.R;
                    double g = pixel.G;
                    double b = pixel.B;
                    //cong thuc 6.2-2 trong giao trinh
                    double t1 = (2 * r - g - b) / 2;
                    double t2 = Math.Sqrt(((r - g) * (r - g)) + (r - b) * (g - b));
                    double theta = Math.Acos(t1 / t2); //c# se tra ket qua la radian

                    //cong thuc 6.2-2 trong giao trinh (tinh hue)
                    double h = 0;
                    if (b <= g)
                        h = theta;
                    else
                        h = 2 * Math.PI - theta;
                    h = h * 180 / Math.PI;

                    //tinh saturation (cong thuc 6.2-3)
                    double s = 1 - 3 * Math.Min(r, Math.Min(g, b)) / (r + g + b);
                    //theo công thức thì giá trị tính ra của s chỉ nằm trong khoảng (0,1), 
                    //phải chuyển đổi khoảng (0-1) sang khoảng (0-255)
                    s = s * ((255 - 0) / (1 - 0));

                    //tinh value 
                    double v = Math.Max(r, Math.Max(b, g));

                    //dua gia trị tính ra vào các bitmap
                    //luu y la phai dua vào bitmap dưới dạng byte
                    hue.SetPixel(x, y, Color.FromArgb((byte)h, (byte)h, (byte)h));
                    saturation.SetPixel(x, y, Color.FromArgb((byte)s, (byte)s, (byte)s));
                    value.SetPixel(x, y, Color.FromArgb((byte)v, (byte)v, (byte)v));
                    hsv_image.SetPixel(x, y, Color.FromArgb((byte)h, (byte)s, (byte)v));
                }
            HSV.Add(hue);
            HSV.Add(saturation);
            HSV.Add(value);
            HSV.Add(hsv_image);

            return HSV;
        }
    }
}
