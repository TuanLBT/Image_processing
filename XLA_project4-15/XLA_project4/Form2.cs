using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace XLA_project4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            //load hình từ file
            Bitmap hinhgoc = new Bitmap(@"D:\picture\file_xla\bird_small.jpg");
            pic_hinhgoc.Image = hinhgoc;

            //Võ ngọc anh tuấn 20146543
            //tính hình theo phương pháp luminance và hiển thị lên picbox
            Bitmap hinhmucxam = chuyenhinhsangmucxam_Luminance(hinhgoc);
            pic_luminance.Image = hinhmucxam;

            
            //tinh histogram
            double[] histogram = tinh_histogram(hinhmucxam);
            //chuyen doi du lieu
            PointPairList point = chuyendoihistogram(histogram);

            //ve bieu do va hien thi
            zgray.GraphPane = bieudohistogram(point);
            zgray.Refresh();
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
        public double[] tinh_histogram(Bitmap hinhmucxam)
        {
            //tạo mảng gồm 256 phần tử chứa giá trị số đếm của pixel của mỗi có cùng mức xám trong ảnh
            double[] histogram = new double[256];    

            for (int x = 0;x<hinhmucxam.Width;x++)
                for (int y =0;y<hinhmucxam.Height;y++)
                {
                    Color color = hinhmucxam.GetPixel(x, y);
                    byte gray = color.R; // do hình mức xám kênh nào cũng như nhau nên lấy đại 1 kênh

                    //mỗi lần tính sẽ nhập thêm 1 giá trị gray vào mảng theo thứ tự 
                    histogram[gray]++;
                }
            return histogram;
        }

        PointPairList chuyendoihistogram(double[] histogram) 
        {
            //PointPairList la kieu du lieu de ve zedgraph
            PointPairList point = new PointPairList();

            for (int i =0; i <histogram.Length;i++)
            {
                //i tuong ung  truc nam ngang, tu 0-255;
                //histogram[i] tuong ung truc dung, la so pixel cung muc xam
                point.Add(i, histogram[i]); 
            }
            return point;
        }

        public GraphPane bieudohistogram(PointPairList histogram)
        {
            //gragplane là đối tượng trong biểu đồ zedgraph
            GraphPane gp =  new GraphPane();

            gp.Title.Text = @"Biểu đồ histogram";
            gp.Rect = new Rectangle(0, 0, 900, 500);

            //thiet lap truc ngang
            gp.XAxis.Title.Text = @"gia tri muc xam tai cac diem anh";
            gp.XAxis.Scale.Min = 0; 
            gp.XAxis.Scale.Max = 255; //min max của trục
            gp.XAxis.Scale.MajorStep = 5; //mỗi đơn vị cách 5 bước
            gp.XAxis.Scale.MinorStep = 1; //mỗi phần tử trong 1 đơn vị cách nhau 1 bước

            //truc dung
            gp.YAxis.Title.Text = @"số điểm ảnh có trong từng mức xám";
            gp.YAxis.Scale.Min = 0;
            gp.YAxis.Scale.Max = 15000; //min max của trục
            gp.YAxis.Scale.MajorStep = 5; //mỗi đơn vị cách 5 bước
            gp.YAxis.Scale.MinorStep = 1; //mỗi phần tử trong 1 đơn vị cách nhau 1 bước

            gp.AddBar("Histogram", histogram, Color.AliceBlue);
            return gp;
        }

     }

}
