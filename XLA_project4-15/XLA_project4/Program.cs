using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XLA_project4
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Application.Run(new Form2());
            //Application.Run(new Form_histogram_RGB());
            //Application.Run(new RGB_to_CMYK()); //bai 6
            //Application.Run(new RGB_to_HSI()); //bai 7
            //Application.Run(new RGB_to_HSV()); //bai 8
            //Application.Run(new RGB_to_XYZ()); //bai9
            //Application.Run(new RGB_to_YCrCb()); //bai10
            //Application.Run(new RGB_Smooth()); //bai11
            //Application.Run(new SEGMENTATION_IN_RGB()); 
            Application.Run(new Edge_Detection_Grayscale());
            //Application.Run(new Edge_Detection_RGB());
        }
    }
}
