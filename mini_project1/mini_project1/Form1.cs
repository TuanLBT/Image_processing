using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mini_project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //create variable contains link of image
            string filehinh = @"D:\picture\file_xla\lena_color.jpg";

            // create variable contains bitmap of image
            Bitmap hinhgoc = new Bitmap(filehinh);

            //show image in picbox
            picBox_hinhgoc.Image = hinhgoc;

            //declare 3 bitmap for 3 color red, green and blue 
            Bitmap red = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap green = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap blue = new Bitmap(hinhgoc.Width, hinhgoc.Height);

            //image is a 2 dimension matrix, use 2 for loop to read all pixels of image
            for (int x = 0; x < hinhgoc.Width; x++)
                for (int y = 0; y < hinhgoc.Height; y++)
                {
                    //read pixels at (x,y) image position
                    Color pixel = hinhgoc.GetPixel(x, y);

                    //each pixel has R, G, B and A (Alpha ttransparency)
                    byte R = pixel.R; //red value
                    byte G = pixel.G;
                    byte B = pixel.B;
                    byte A = pixel.A; //transparency value

                    //set the pixel's value to each bit of bitmap 
                    //which mean set color for each image (Red, green and blue)
                    red.SetPixel(x, y, Color.FromArgb(A, R, 0, 0));
                    green.SetPixel(x, y, Color.FromArgb(A, 0, G, 0));
                    blue.SetPixel(x, y, Color.FromArgb(A, 0, 0, B));

                    //show 3 image (red, blue and green)
                    picBox_red.Image = red;
                    picBox_green.Image = green;
                    picBox_blue.Image = blue;
                }

        }
    }
}
