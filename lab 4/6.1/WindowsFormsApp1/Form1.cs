using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Http.Headers;
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
            Pen pen = new Pen(Color.Blue);
            SolidBrush sld = new SolidBrush(Color.Blue);

            Point Trpoint1 = new Point(100, 100); // ТРИКУТНИК
            Point Trpoint2 = new Point(10, 120);
            Point Trpoint3 = new Point(150, 150);

            Point[] triangle =
            {
                Trpoint1,
                Trpoint2,
                Trpoint3
            };
            graph.FillPolygon(sld, triangle);

            graph.DrawLine(pen, 140, 280, 150, 300); // РОМБ
            graph.DrawLine(pen, 150, 300, 140, 320);
            graph.DrawLine(pen, 140, 320, 130, 300);
            graph.DrawLine(pen, 130, 300, 140, 280);
            
            graph.DrawArc(pen, 300, 100, 90, 120, 60, 60); // СЕКТОР ЕЛІПСА
            graph.DrawLine(pen, 317,207, 343, 150);
            graph.DrawLine(pen, 343, 150, 372, 207);

            graph.DrawLine(pen, 400, 40, 500, 40); // ПРЯМОКУТНИК
            graph.DrawLine(pen, 400, 100, 500, 100);
            graph.DrawLine(pen, 400, 40, 400, 100);
            graph.DrawLine(pen, 500, 40, 500, 100);

            pictureBox1.Image = bmp;
        }
    }
}
