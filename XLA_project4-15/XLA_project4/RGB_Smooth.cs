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
    public partial class RGB_Smooth : Form
    {
        Bitmap hinhgoc;
        public RGB_Smooth()
        {
            InitializeComponent();
            hinhgoc = new Bitmap(@"D:\picture\file_xla\lena_color.jpg");
            pic_goc.Image = hinhgoc;

            
        }
        public Bitmap colorimagesmoothing3x3(Bitmap hinhgoc)
        {
            Bitmap smth_img = new Bitmap(hinhgoc.Width, hinhgoc.Height);

            //quét hết ảnh chừa viền ra (1 ô)
            for (int x = 1; x < hinhgoc.Width - 1; x++)
                for (int y = 1; y < hinhgoc.Height - 1; y++)
                {
                    //biến chứa giá trị cộng dồn của các điểm ảnh
                    int Rs = 0, Gs = 0, Bs = 0;

                    //quét các điểm hàng xóm quanh điểm trung tâm (từ trung tâm ( ra đến viền, nhưng loại bỏ viền)
                    for (int i = x-1; i <= x+1; i++)
                        for (int j = y-1; j <= y+1; j++)
                        {
                            Color pixel = hinhgoc.GetPixel(i, j);
                            // do công thức tính toán chỉ trả về giá trị là số thực nên không sử dụng byte được
                            byte r = pixel.R;
                            byte g = pixel.G;
                            byte b = pixel.B;

                            //cộng dồn tất cả điểm ảnh đó cho mỗi kênh RGb tương ứng
                            Rs = Rs + r;
                            Gs = Gs + g;
                            Bs = Bs + b;
                        }
                    //tính trung bình cộng cho mỗi kênh theo công thức 6.6-2 giáo trình
                    byte K = 3*3;
                    Rs = (int)(Rs / K);
                    Gs = (int)(Gs / K);
                    Bs = (int)(Bs / K);

                    //set điểm ảnh đã smoothing vào bitmap cần show lên
                    smth_img.SetPixel(x, y, Color.FromArgb(Rs, Gs, Bs));
                }
            

            return smth_img;
        }
        public Bitmap colorimagesmoothing5x5(Bitmap hinhgoc)
        {
            Bitmap smth_img = new Bitmap(hinhgoc.Width, hinhgoc.Height);

            //quét hết ảnh chừa viền ra (1 ô)
            
            for (int x = 2; x < hinhgoc.Width - 2; x++)
                for (int y = 2; y < hinhgoc.Height - 2; y++)
                {
                    
                    //biến chứa giá trị cộng dồn của các điểm ảnh
                    int Rs = 0, Gs = 0, Bs = 0;

                    //quét các điểm trên mặt nạ
                    for (int i = x - 2; i <= x + 2; i++)
                        for (int j = y - 2; j <= y + 2; j++)
                        {
                            Color pixel = hinhgoc.GetPixel(i, j);
                            // do công thức tính toán chỉ trả về giá trị là số thực nên không sử dụng byte được
                            byte r = pixel.R;
                            byte g = pixel.G;
                            byte b = pixel.B;

                            //cộng dồn tất cả điểm ảnh đó cho mỗi kênh RGb tương ứng
                            Rs = Rs + r;
                            Gs = Gs + g;
                            Bs = Bs + b;
                        }
                    //tính trung bình cộng cho mỗi kênh theo công thức 6.6-2 giáo trình
                    byte K = 5*5;
                    Rs = (int)(Rs / K);
                    Gs = (int)(Gs / K);
                    Bs = (int)(Bs / K);

                    //set điểm ảnh đã smoothing vào bitmap cần show lên
                    smth_img.SetPixel(x, y, Color.FromArgb(Rs, Gs, Bs));
                }


            return smth_img;
        }

        public Bitmap colorimagesmoothing7x7(Bitmap hinhgoc)
        {
            Bitmap smth_img = new Bitmap(hinhgoc.Width, hinhgoc.Height);

            //quét hết ảnh chừa viền ra (1 ô)
            for (int x = 3; x < hinhgoc.Width - 3; x++)
                for (int y = 3; y < hinhgoc.Height - 3; y++)
                {
                    //biến chứa giá trị cộng dồn của các điểm ảnh
                    int Rs = 0, Gs = 0, Bs = 0;

                    //quét các điểm trên mặt nạ
                    for (int i = x - 3; i <= x + 3; i++)
                        for (int j = y - 3; j <= y + 3; j++)
                        {
                            Color pixel = hinhgoc.GetPixel(i, j);
                            // do công thức tính toán chỉ trả về giá trị là số thực nên không sử dụng byte được
                            byte r = pixel.R;
                            byte g = pixel.G;
                            byte b = pixel.B;

                            //cộng dồn tất cả điểm ảnh đó cho mỗi kênh RGb tương ứng
                            Rs = Rs + r;
                            Gs = Gs + g;
                            Bs = Bs + b;
                        }
                    //tính trung bình cộng cho mỗi kênh theo công thức 6.6-2 giáo trình
                    byte K = 7 * 7;
                    Rs = (int)(Rs / K);
                    Gs = (int)(Gs / K);
                    Bs = (int)(Bs / K);

                    //set điểm ảnh đã smoothing vào bitmap cần show lên
                    smth_img.SetPixel(x, y, Color.FromArgb(Rs, Gs, Bs));
                }


            return smth_img;
        }

        public Bitmap colorimagesmoothing9x9(Bitmap hinhgoc)
        {
            Bitmap smth_img = new Bitmap(hinhgoc.Width, hinhgoc.Height);

            //quét hết ảnh chừa viền ra (1 ô)
            for (int x = 4; x < hinhgoc.Width - 4; x++)
                for (int y = 4; y < hinhgoc.Height - 4; y++)
                {
                    //biến chứa giá trị cộng dồn của các điểm ảnh
                    int Rs = 0, Gs = 0, Bs = 0;

                    //quét các điểm trên mặt nạ
                    for (int i = x - 4; i <= x + 4; i++)
                        for (int j = y - 4; j <= y + 4; j++)
                        {
                            Color pixel = hinhgoc.GetPixel(i, j);
                            // do công thức tính toán chỉ trả về giá trị là số thực nên không sử dụng byte được
                            byte r = pixel.R;
                            byte g = pixel.G;
                            byte b = pixel.B;

                            //cộng dồn tất cả điểm ảnh đó cho mỗi kênh RGb tương ứng
                            Rs = Rs + r;
                            Gs = Gs + g;
                            Bs = Bs + b;
                        }
                    //tính trung bình cộng cho mỗi kênh theo công thức 6.6-2 giáo trình
                    byte K = 9 * 9;
                    Rs = (int)(Rs / K);
                    Gs = (int)(Gs / K);
                    Bs = (int)(Bs / K);

                    //set điểm ảnh đã smoothing vào bitmap cần show lên
                    smth_img.SetPixel(x, y, Color.FromArgb(Rs, Gs, Bs));
                }


            return smth_img;
        }

        private void button_3x3_Click(object sender, EventArgs e)
        {
            hinhgoc = new Bitmap(@"D:\picture\file_xla\lena_color.jpg");
            Bitmap smooth_img = colorimagesmoothing3x3(hinhgoc);
            pic_smooth.Image = smooth_img;
        }

        private void button_5x5_Click(object sender, EventArgs e)
        {
            hinhgoc = new Bitmap(@"D:\picture\file_xla\lena_color.jpg");
            Bitmap smooth_img = colorimagesmoothing5x5(hinhgoc);
            pic_smooth.Image = smooth_img;
        }

        private void button_7x7_Click(object sender, EventArgs e)
        {
            hinhgoc = new Bitmap(@"D:\picture\file_xla\lena_color.jpg");
            Bitmap smooth_img = colorimagesmoothing7x7(hinhgoc);
            pic_smooth.Image = smooth_img;
        }

        private void button_9x9_Click(object sender, EventArgs e)
        {
            hinhgoc = new Bitmap(@"D:\picture\file_xla\lena_color.jpg");
            Bitmap smooth_img = colorimagesmoothing9x9(hinhgoc);
            pic_smooth.Image = smooth_img;
        }
    }
}
