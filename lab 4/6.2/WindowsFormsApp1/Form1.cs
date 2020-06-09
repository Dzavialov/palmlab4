using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graph = Graphics.FromImage(bmp);

            SolidBrush GreenBrush = new SolidBrush(Color.Green);
            SolidBrush BrownBrush = new SolidBrush(Color.Brown);
            SolidBrush BlueBrush = new SolidBrush(Color.Blue);
            SolidBrush YellowBrush = new SolidBrush(Color.Yellow);

            Point point1 = new Point(300, 30);//ПЕРШИЙ ТРИКУТНИК
            Point point2 = new Point(260, 70);
            Point point3 = new Point(340, 70);

            Point[] pts = { 
                point1,
                point2,
                point3
            };

            graph.FillPolygon(GreenBrush, pts);


            Point point12 = new Point(300, 50);//ДРУГИЙ ТРИКУТНИК
            Point point22 = new Point(240, 120);
            Point point32 = new Point(360, 120);

            Point[] pts2 = {
                point12,
                point22,
                point32
            };

            graph.FillPolygon(GreenBrush, pts2);


            Point point123 = new Point(300, 80);//ТРЕТІЙ ТРИКУТНИК
            Point point223 = new Point(220, 170);
            Point point323 = new Point(380, 170);

            Point[] pts3 = {
                point123,
                point223,
                point323
            };

            graph.FillPolygon(GreenBrush, pts3);

            Point crn1 = new Point(280, 170);
            Point crn3 = new Point(280, 200);
            Point crn2 = new Point(310, 170);
            Point crn4 = new Point(310, 200);



            Point[] crn = { 
                crn1,
                crn2,
                crn4,
                crn3
                
            };

            graph.FillPolygon(BrownBrush, crn);

            graph.FillEllipse(YellowBrush, 300, 80, 10, 10);
            graph.FillEllipse(BlueBrush, 260, 150, 10, 10);
            graph.FillEllipse(YellowBrush, 310, 140, 10, 10);
            graph.FillEllipse(BlueBrush, 300, 120, 10, 10);
            graph.FillEllipse(YellowBrush, 270, 120, 10, 10);

            pictureBox1.Image = bmp;
        }
    }
}
