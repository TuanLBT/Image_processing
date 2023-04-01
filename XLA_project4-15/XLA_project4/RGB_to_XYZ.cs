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
    public partial class RGB_to_XYZ : Form
    {
        public RGB_to_XYZ()
        {
            InitializeComponent();
            Bitmap hinhgoc = new Bitmap(@"D:\picture\file_xla\lena_color.jpg");
            pic_goc.Image = hinhgoc;

            List<Bitmap> XYZ = chuyendoirgbsang_xyz(hinhgoc);
            pic_x.Image = XYZ[0];
            pic_y.Image = XYZ[1];
            pic_z.Image = XYZ[2];
            pic_xyz.Image = XYZ[3];

        }
        public List<Bitmap> chuyendoirgbsang_xyz(Bitmap hinhgoc)
        {
            List<Bitmap> HSI = new List<Bitmap>();

            Bitmap kenh_x = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap kenh_y = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap kenh_z = new Bitmap(hinhgoc.Width, hinhgoc.Height);

            //Hình HSI kết hợp cả 3 cái hình trên
            Bitmap xyz_img = new Bitmap(hinhgoc.Width, hinhgoc.Height);

            for (int x = 0; x < hinhgoc.Width; x++)
                for (int y = 0; y < hinhgoc.Height; y++)
                {
                    Color pixel = hinhgoc.GetPixel(x, y);
                    // do công thức tính toán chỉ trả về giá trị là số thực nên không sử dụng byte được
                    double r = pixel.R;
                    double g = pixel.G;
                    double b = pixel.B;
                    //cong thuc chuyen xyz
                    double Red = 0.4124564 * r + 0.3575761 * g  + 0.1804375 * b;
                    double Green = 0.2126729 * r + 0.7151522 * g + 0.0721750 * b;
                    double Blue = 0.0193339 *r  +0.1191920 * g + 0.9503041 * b;

                    //dua gia trị tính ra vào các bitmap
                    //luu y la phai dua vào bitmap dưới dạng byte
                    kenh_x.SetPixel(x, y, Color.FromArgb((byte)Red, (byte)Red, (byte)Red));
                    kenh_y.SetPixel(x, y, Color.FromArgb((byte)Green, (byte)Green, (byte)Green));
                    kenh_z.SetPixel(x, y, Color.FromArgb((byte)Blue, (byte)Blue, (byte)Blue));
                    xyz_img.SetPixel(x, y, Color.FromArgb((byte)Red, (byte)Green, (byte)Blue));
                }
            HSI.Add(kenh_x);
            HSI.Add(kenh_y);
            HSI.Add(kenh_z);
            HSI.Add(xyz_img);

            return HSI;
        }
    }
}