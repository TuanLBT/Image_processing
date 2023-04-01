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
    public partial class Form_histogram_RGB : Form
    {
        public Form_histogram_RGB()
        {
            InitializeComponent();
            //load hình từ file
            Bitmap hinhgoc = new Bitmap(@"D:\picture\file_xla\bird_small.jpg");
            pic_hinhgoc.Image = hinhgoc;

            //Võ ngọc anh tuấn 20146543
            //tinh histogram
            double[,] histogram = tinh_histogram(hinhgoc);
            //chuyen doi du lieu
            List<PointPairList> point = chuyendoihistogram(histogram);

            //ve bieu do va hien thi
            zrgb.GraphPane = bieudohistogram(point);
            zrgb.Refresh();

        }
        public double[,] tinh_histogram(Bitmap bmp) //số dấu phẩy tưng ứng số chiều +1
        {
            //dùng mảng 2 chiều để chứa thông tin histogram cho các kênh R, G,B [số kênh màu, giá trị màu]
            double[,] histogram = new double[3,256];

            for (int x = 0; x < bmp.Width; x++)
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color color = bmp.GetPixel(x, y);
                    byte r = color.R; 
                    byte g = color.G;
                    byte b = color.B;
                    //mỗi lần tính sẽ nhập thêm 1 giá trị RGB vào mảng theo thứ tự 
                    histogram[0, r]++;
                    histogram[1, g]++;
                    histogram[2, b]++;
                }
            return histogram;
        }
        List<PointPairList> chuyendoihistogram(double[,] histogram)
        {
            //PointPairList la kieu du lieu de ve zedgraph
            List<PointPairList> point = new List<PointPairList>();
            PointPairList redpoint = new PointPairList(); //chuyen doi histogram kenh r
            PointPairList greenpoint = new PointPairList();
            PointPairList bluepoint = new PointPairList();

            for (int i = 0; i < 256; i++)
            {
                //i tuong ung  truc nam ngang, tu 0-255;
                //histogram[i] tuong ung truc dung, la so pixel cung muc xam
                redpoint.Add(i, histogram[0,i]);
                greenpoint.Add(i, histogram[1, i]);
                bluepoint.Add(i, histogram[2, i]);
            }
            point.Add(redpoint);
            point.Add(greenpoint);
            point.Add(bluepoint);
            return point;
        }
        public GraphPane bieudohistogram(List<PointPairList> histogram)
        {
            //gragplane là đối tượng trong biểu đồ zedgraph
            GraphPane gp = new GraphPane();

            gp.Title.Text = @"Biểu đồ histogram";
            gp.Rect = new Rectangle(0, 0, 700, 500);

            //thiet lap truc ngang
            gp.XAxis.Title.Text = @"gia tri mau tai cac diem anh";
            gp.XAxis.Scale.Min = 0;
            gp.XAxis.Scale.Max = 255; //min max của trục
            gp.XAxis.Scale.MajorStep = 5; //mỗi đơn vị cách 5 bước
            gp.XAxis.Scale.MinorStep = 1; //mỗi phần tử trong 1 đơn vị cách nhau 1 bước

            //truc dung
            gp.YAxis.Title.Text = @"số điểm ảnh có cùng giá trị màu";
            gp.YAxis.Scale.Min = 0;
            gp.YAxis.Scale.Max = 150000; //min max của trục
            gp.YAxis.Scale.MajorStep = 5; //mỗi đơn vị cách 5 bước
            gp.YAxis.Scale.MinorStep = 1; //mỗi phần tử trong 1 đơn vị cách nhau 1 bước

            gp.AddBar("Histogram's red", histogram[0], Color.Red);
            gp.AddBar("Histogram's green", histogram[1], Color.Green);
            gp.AddBar("Histogram's blue", histogram[2], Color.Blue);
            return gp;
        }
    }
}
