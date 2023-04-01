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
    public partial class Edge_Detection_Grayscale : Form
    {
        Bitmap hinhgoc;
        public Edge_Detection_Grayscale()
        {
            InitializeComponent();
            hinhgoc = new Bitmap(@"D:\picture\file_xla\lena_color.jpg");
            pictureBox_hinhgoc.Image = hinhgoc;
        }

        public Bitmap edge_detection(Bitmap hinhmucxam, int nguong)
        {
            float[,] Sobel_x = { { -1, -2, -1 }, { 0, 0, 0 }, { 1, 2, 1 } };
            float[,] Sobel_y = { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };

            //tạo biến bitmap chứa kết quả sau khi hoàn thành
            Bitmap edge_detection = new Bitmap(hinhmucxam.Width, hinhmucxam.Height);

            //mặt nạ 3x3 quét trên hình mức xám
            for (int x = 1; x < hinhmucxam.Width - 1; x++)
                for (int y = 1; y < hinhmucxam.Height - 1; y++)
                {
                    Color pixel_xy = hinhmucxam.GetPixel(x, y);
                    //float R_xy = pixel_xy.R; // vì hình mức xám giá trị R, B, G đều như nhau, lấy 1 cái

                    float R_kq_x = 0;
                    float R_kq_y = 0;

                    float Mxy = 0;

                    for (int i = x - 1; i <= x + 1; i++)
                        for (int j = y - 1; j <= y + 1; j++) //hết 2 vòng for sẽ nhân xong 1 ma trận
                        {
                            Color pixel = hinhmucxam.GetPixel(i, j);
                            R_kq_x += Sobel_x[i - x + 1, j - y + 1] * pixel.R; //cộng dồn ra gx
                            R_kq_y += Sobel_y[i - x + 1, j - y + 1] * pixel.R; //cộng dồn ra gy 
                        }
                    //độ lớn của vector  f (gradian) tại điểm, đồng thời giới hạn giá trị pixel
                    // M(x,y) = |gx| + |gy| 
                    Mxy = Math.Max(0, Math.Min(255, Math.Abs(R_kq_x) + Math.Abs(R_kq_y)));
                    //Tiến hành add các điểm lại
                    if (Mxy > nguong)
                    {
                        edge_detection.SetPixel(x, y, Color.FromArgb((int)Mxy, (int)Mxy, (int)Mxy));
                    }
                    else
                    {
                        edge_detection.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    }
                }

            return edge_detection;
        }
        public Bitmap chuyenhinhsangmucxam_Luminance(Bitmap hinhgoc)
        {//Võ ngọc anh tuấn 20146543
            Bitmap hinhmucxam = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            for (int x = 0; x < hinhgoc.Width; x++)
                for (int y = 0; y < hinhgoc.Height; y++)
                {
                    //lấy từng điểm ảnh tại từng tọa độ x, y (mỗi điểm ảnh này chứa cả 3 kênh )
                    Color pixel = hinhgoc.GetPixel(x, y);
                    //lấy ra từng bit theo từng kênh trữ vào r,g,b
                    byte r = pixel.R;
                    byte g = pixel.G;
                    byte b = pixel.B;

                    byte gray = (byte)(r * 0.2126 + g * 0.7152 + b * 0.0722);
                    hinhmucxam.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
            return hinhmucxam;
        }

        private void hScrollBar_nguong_Scroll(object sender, ScrollEventArgs e)
        {
            //lay gia tri tu scoll (gia tri tu cuon la int, nen phai ep kieu)
            int nguong = (int)hScrollBar_nguong.Value;
            //hien thi gia tri cua scoll len 
            lb_value_nguong.Text = nguong.ToString();
            //picbox_nhiphan.Image = rgbsangnhiphan(hinhgoc, nguong);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hinhgoc = new Bitmap(@"D:\picture\file_xla\lena_color.jpg");
            Bitmap hinhxam = chuyenhinhsangmucxam_Luminance(hinhgoc);
            int nguong = (int)hScrollBar_nguong.Value;
            pictureBox_edge.Image = edge_detection(hinhxam, nguong);

        }
    }
}
