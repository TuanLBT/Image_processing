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
    public partial class Edge_Detection_RGB : Form
    {
        Bitmap hinhgoc;
        public Edge_Detection_RGB()
        {
            InitializeComponent();
            hinhgoc = new Bitmap(@"D:\picture\file_xla\lena_color.jpg");
            pictureBox_goc.Image = hinhgoc;
        }
        public Bitmap Edge_detection_RGB(Bitmap hinhgoc, int nguong)
        {
            double[,] Sobel_x = { { -1, -2, -1 }, { 0, 0, 0 }, { 1, 2, 1 } };
            double[,] Sobel_y = { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };

            //tạo biến bitmap chứa kết quả sau khi hoàn thành
            Bitmap edge_detection_RGB = new Bitmap(hinhgoc.Width, hinhgoc.Height);

            //mặt nạ 3x3 quét trên hình 
            for (int x = 1; x < hinhgoc.Width - 1; x++)
                for (int y = 1; y < hinhgoc.Height - 1; y++)
                {
                    Color pixel_xy = hinhgoc.GetPixel(x, y);
                    //lấy các điểm và tách thành các kênh màu
                    double R_xy = pixel_xy.R;
                    double G_xy = pixel_xy.G;
                    double B_xy = pixel_xy.B;

                    //x y của kênh R
                    double R_kq_x = 0;
                    double R_kq_y = 0;

                    //x y của kênh G
                    double G_kq_x = 0;
                    double G_kq_y = 0;

                    //x y của kênh B
                    double B_kq_x = 0;
                    double B_kq_y = 0;
                    

                    for (int i = x - 1; i <= x + 1; i++)
                        for (int j = y - 1; j <= y + 1; j++)
                        {
                            Color pixel = hinhgoc.GetPixel(i, j);
                            R_kq_x += Sobel_x[i - x + 1, j - y + 1] * pixel.R; //cộng dồn ra gx (R)
                            R_kq_y += Sobel_y[i - x + 1, j - y + 1] * pixel.R; //cộng dồn ra gy (R)

                            G_kq_x += Sobel_x[i - x + 1, j - y + 1] * pixel.G; //cộng dồn ra gx (G)
                            G_kq_y += Sobel_y[i - x + 1, j - y + 1] * pixel.G; //cộng dồn ra gy (G)

                            B_kq_x += Sobel_x[i - x + 1, j - y + 1] * pixel.B; //cộng dồn ra gx (B)
                            B_kq_y += Sobel_y[i - x + 1, j - y + 1] * pixel.B; //cộng dồn ra gy (B)

                            //áp dụng công thức 6.7-5 và 6.7-6
                            double Gxx = (double)(Math.Pow(R_kq_x,2) + Math.Pow(G_kq_x, 2) + Math.Pow(B_kq_x, 2));
                            double Gyy = (double)(Math.Pow(R_kq_y, 2) + Math.Pow(G_kq_y, 2) + Math.Pow(B_kq_y, 2));
                            double Gxy = (double)(R_kq_x * R_kq_y + G_kq_x * G_kq_y + B_kq_x * B_kq_y);

                            // theo công thức 6.7-8  tính giá trị theta
                            double theta = (double)( (Math.Atan2(2 * Gxy,Gxx - Gyy))/2 );

                            //theo công thức 6.7-9 tính F(xy)
                            double Fo = (double)(Math.Sqrt(((Gxx + Gyy) + (Gxx - Gyy) * Math.Cos(2 * theta) + 2 * Gxy * Math.Sin(2 * theta)) / 2));

                            //giới hạn
                            double Fo_lim = Math.Max(0, Math.Min(255, Fo));

                            //Tiến hành add các điểm lại
                            if (Fo_lim >= nguong)
                            {
                                edge_detection_RGB.SetPixel(x, y, Color.FromArgb((int)Fo_lim, (int)Fo_lim, (int)Fo_lim));
                            }
                            else
                            {
                                edge_detection_RGB.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                                //edge_detection_RGB.SetPixel(x, y, Color.FromArgb((int)Fo, (int)Fo, (int)Fo));

                            }


                        }
                }

            return edge_detection_RGB;
        }

        private void hScrollBar_nguong_Scroll(object sender, ScrollEventArgs e)
        {
            //lay gia tri tu scoll (gia tri tu cuon la int, nen phai ep kieu)
            int nguong = (int)hScrollBar_nguong.Value;
            //hien thi gia tri cua scoll len 
            lb_value.Text = nguong.ToString();
            //picbox_nhiphan.Image = rgbsangnhiphan(hinhgoc, nguong);
        }

        private void button_Edge_run_Click(object sender, EventArgs e)
        {
            hinhgoc = new Bitmap(@"D:\picture\file_xla\lena_color.jpg");
            int nguong = (int)hScrollBar_nguong.Value;
            pictureBox_edge.Image = Edge_detection_RGB(hinhgoc, nguong);
        }
    }
    
}
