using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XLA_project3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //load hình từ file
            Bitmap hinhgoc = new Bitmap(@"D:\picture\file_xla\lena_color.jpg");
            //Võ ngọc anh tuấn 20146543
            //hiển thị hình lên picturebox
            picbox_anhgoc.Image = hinhgoc;
            //tính hình theo phương pháp average và hiển thị lên picbox
            picbox_average.Image = chuyenhinhsangmucxam_average(hinhgoc);
            //tính hình theo phương pháp lightness và hiển thị lên picbox
            picbox_lightness.Image = chuyenhinhsangmucxam_lightness(hinhgoc);
            //tính hình theo phương pháp lightness và hiển thị lên picbox
            picbox_luminance.Image = chuyenhinhsangmucxam_Luminance(hinhgoc);
        }
        public Bitmap chuyenhinhsangmucxam_average(Bitmap hinhgoc)
        { //Võ ngọc anh tuấn 20146543
            Bitmap hinhmucxam = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            for (int x =0; x < hinhgoc.Width; x++)
                for (int y =0;y< hinhgoc.Height; y++)
            {       //lấy từng điểm ảnh tại từng tọa độ x, y (mỗi điểm ảnh này chứa cả 3 kênh ) chứa trong bit pixel
                    Color pixel = hinhgoc.GetPixel(x, y);
                    //lấy ra từng bit theo từng kênh trữ vào r,g,b
                    byte r = pixel.R;
                    byte g = pixel.G;
                    byte b = pixel.B;
                    //tính điểm ảnh xám cho từng tọa độ x,y theo phương pháp average
                    byte xam = (byte)((r+g+b)/3);
                    //nạp giá trị điểm ảnh và màu của bit vô bitmap hinhmucxam
                    hinhmucxam.SetPixel(x,y,Color.FromArgb(xam,xam,xam));
            }
            return hinhmucxam;
        }

        public Bitmap chuyenhinhsangmucxam_lightness(Bitmap hinhgoc)
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

                    //lấy max, min của 3 bit r,g,b
                    byte max = Math.Max(Math.Max(r,g),b);
                    byte min = Math.Min(Math.Min(r,g),b); 
                    
                    //lấy trung bình max min ra mức xám
                    byte gray = (byte)((max+min)/2);
                    hinhmucxam.SetPixel(x,y, Color.FromArgb(gray,gray,gray));
                }    
            return hinhmucxam;
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
    }

}
