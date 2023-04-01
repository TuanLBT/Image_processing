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
    public partial class RGB_sharpen : Form
    {
        public RGB_sharpen()
        {
            InitializeComponent();
            Bitmap hinhgoc = new Bitmap(@"D:\picture\file_xla\lena_color.jpg");
            pic_goc.Image = hinhgoc;
        }
        public Bitmap rgb_sharpen(Bitmap hinhgoc)
        {
            for (int x = 1; x < hinhgoc.Width - 1; x++)
                for (int y = 1; y < hinhgoc.Height - 1; y++)
                {

                }
            return hinhgoc;
        }
    }
}
