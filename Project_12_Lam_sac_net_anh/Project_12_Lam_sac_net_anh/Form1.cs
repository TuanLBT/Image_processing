using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_12_Lam_sac_net_anh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Load ảnh và hiện ra picturebox
            Bitmap hinhgoc = new Bitmap(@"D:\picture\file_xla\lena_color.jpg");
            pictureBox_HinhGoc.Image = hinhgoc;
            pictureBox_HinhSacNet.Image = Sharpening(hinhgoc);
        }

        public Bitmap Sharpening(Bitmap hinhgoc)
        {
            //Xài cho c = 1
            float[,] matran = { { 0, -1, 0 }, { -1, 4, -1 }, { 0, -1, 0 } };
            //float[,] matran = { { -1, -1, -1 }, { -1, 8, -1 }, { -1, -1, -1 } };

            //Xài cho c = -1SSSss
            //float[,] matran = { { 0, 1, 0 }, { 1, -4, 1 }, { 0, 1, 0 } };
            //float[,] matran = { { 1, 1, 1 }, { 1, -8, 1 }, { 1, 1, 1 } };

            //Tạo một biến chứa kết quả
            Bitmap ketqua = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            for (int x = 1; x < hinhgoc.Width -1; x++)
                for (int y = 1; y < hinhgoc.Height -1; y++)
                {
                    Color pixel_xy = hinhgoc.GetPixel(x, y);
                    float R_xy = pixel_xy.R;
                    float G_xy = pixel_xy.G;
                    float B_xy = pixel_xy.B;

                    float R_kq = 0;
                    float G_kq = 0;
                    float B_kq = 0;

                    for (int i = x-1; i <= x+1; i++)
                        for (int j = y-1; j <= y+1; j++)
                        {
                            Color pixel = hinhgoc.GetPixel(i, j);

                            
                            R_kq += matran[i - x + 1, j - y + 1] * pixel.R;
                            G_kq += matran[i - x + 1, j - y + 1] * pixel.G;
                            B_kq += matran[i - x + 1, j - y + 1] * pixel.B;
                        }
                    //Đặt điều kiện để không bị sai hình, và dấu phụ thuộc ma trận
                    R_kq = Math.Max(0, Math.Min(255, R_xy + R_kq));
                    G_kq = Math.Max(0, Math.Min(255, G_xy + G_kq));
                    B_kq = Math.Max(0, Math.Min(255, B_xy + B_kq));

                    //Tiến hành add các điểm lại, dấu cộng hay trừ phụ thuộc ma trận
                    ketqua.SetPixel(x, y, Color.FromArgb((byte)(R_kq), (byte) (G_kq), (byte) (B_kq)));
                }
            return ketqua;
        }
    }
}
