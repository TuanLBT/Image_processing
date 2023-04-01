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
    public partial class RGB_to_YCrCb : Form
    {
        public RGB_to_YCrCb()
        {
            InitializeComponent();
            Bitmap hinhgoc = new Bitmap(@"D:\picture\file_xla\lena_color.jpg");
            pic_goc.Image = hinhgoc;

            List<Bitmap> ycrcb = chuyendoirgbsang_ycrcb(hinhgoc);
            pic_y.Image = ycrcb[0];
            pic_Cr.Image = ycrcb[1];
            pic_cb.Image = ycrcb[2];
            pic_ycrcb.Image = ycrcb[3];

        }
        public List<Bitmap> chuyendoirgbsang_ycrcb(Bitmap hinhgoc)
        {
            List<Bitmap> ycrcb = new List<Bitmap>();

            Bitmap kenh_y = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap kenh_cr = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap kenh_cb = new Bitmap(hinhgoc.Width, hinhgoc.Height);

            //Hình HSI kết hợp cả 3 cái hình trên
            Bitmap ycrcb_img = new Bitmap(hinhgoc.Width, hinhgoc.Height);

            for (int x = 0; x < hinhgoc.Width; x++)
                for (int y = 0; y < hinhgoc.Height; y++)
                {
                    Color pixel = hinhgoc.GetPixel(x, y);
                    // do công thức tính toán chỉ trả về giá trị là số thực nên không sử dụng byte được
                    double r = pixel.R;
                    double g = pixel.G;
                    double b = pixel.B;
                    //cong thuc chuyen xyz
                    double Y_value = 16 + (65.738 / 256) * r + (129.057 / 256) * g + (25.064 / 256) * b;
                    double Cr_value = 128 - (37.945 / 256) * r - (74.494 / 256) * g + (112.439 / 256) * b;
                    double Cb_value = 128 + (112.439 / 256) * r - (94.154 / 256) * g - (18.258 / 256) * b;

                    //dua gia trị tính ra vào các bitmap
                    //luu y la phai dua vào bitmap dưới dạng byte
                    kenh_y.SetPixel(x, y, Color.FromArgb((byte)Y_value, (byte)Y_value, (byte)Y_value));
                    kenh_cr.SetPixel(x, y, Color.FromArgb((byte)Cr_value, (byte)Cr_value, (byte)Cr_value));
                    kenh_cb.SetPixel(x, y, Color.FromArgb((byte)Cb_value, (byte)Cb_value, (byte)Cb_value));
                    ycrcb_img.SetPixel(x, y, Color.FromArgb((byte)Y_value, (byte)Cr_value, (byte)Cb_value));
                }
            ycrcb.Add(kenh_y);
            ycrcb.Add(kenh_cr);
            ycrcb.Add(kenh_cb);
            ycrcb.Add(ycrcb_img);

            return ycrcb;
        }
    }
}