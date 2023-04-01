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
    public partial class Form1 : Form
    {
        Bitmap hinhgoc;
        public Form1()
        {
            InitializeComponent();
            hinhgoc = new Bitmap(@"D:\picture\file_xla\lena_color.jpg");
            picbox_anhgoc.Image = hinhgoc;
            picbox_nhiphan.Image = rgbsangnhiphan(hinhgoc, 100);
        }
        public Bitmap rgbsangnhiphan(Bitmap hinhgoc, byte nguong)
        {
            Bitmap hinhnhiphan = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            for (int x = 0; x<hinhgoc.Width; x++)
                for (int y= 0; y<hinhgoc.Height;y++)
                {
                    Color pixel = hinhgoc.GetPixel(x, y);
                    byte R =  pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;
                    //tinh gia tri muc xam tai diem (x,y)
                    byte nhiphan = (byte)(0.2126 * R + 0.7152 * G + 0.0722 * B);

                    //phan loai diem anh
                    if (nhiphan < nguong)
                        nhiphan = 0;
                    else
                        nhiphan = 255;
                    hinhnhiphan.SetPixel(x,y, Color.FromArgb(nhiphan,nhiphan,nhiphan));
                }
            return hinhnhiphan;
        }

        private void scoll_valuechange(object sender, EventArgs e)
        {
            //lay gia tri tu scoll (gia tri tu cuon la int, nen phai ep kieu)
            byte nguong = (byte)vScrollBar_hinhnhiphan.Value;
            //hien thi gia tri cua scoll len 
            lblnguong.Text = nguong.ToString();
            picbox_nhiphan.Image = rgbsangnhiphan(hinhgoc, nguong);
        }
    }
}
