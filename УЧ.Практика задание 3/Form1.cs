using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace УЧ.Практика_задание_3
{
    public partial class Form1 : Form
    {
        int i = 0;
        int x = 0;
        int y = 0;
        int j = 0;
        Pen redPen = new Pen(Color.Red, 2);
        Pen bluePen = new Pen(Color.Blue, 2);
        Pen greenPen = new Pen(Color.Green, 2);
        Pen purplePen = new Pen(Color.Purple, 2);
        Pen blackPen = new Pen(Color.Black, 2);
        SolidBrush br = new SolidBrush(Color.Aqua);
        Point starpoint;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();


        }

        private void многоугольникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Point[] tt = { new Point(30, 100), new Point(100, 100), new Point(150, 150), new Point(100, 200), new Point(30, 200), new Point(5, 150) };
            g.DrawPolygon(purplePen, tt);
            g.Dispose();
        }

        private void прямоугольникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            for (int i = 20; i < 4 * 20; i = i + 20)
            {
                g.DrawRectangle(redPen, i, i * 2, i * 3, i * 4);
            }


            g.Dispose();
        }

        private void кругToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            for (int i = 20; i < 4 * 20; i = i + 20)
            {
                g.DrawEllipse(bluePen, i, i * 2, i * 3, i * 4);
            }


            g.Dispose();
        }

        private void линияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.DrawLine(redPen, 200, 100, 240, 340);
            g.Dispose();
        }

        private void треугольникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Point[] tt = { new Point(50, 100), new Point(50, 200), new Point(150, 150) };
            g.DrawPolygon(greenPen, tt);
            g.Dispose();
        }

        private void прямоугольникToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.FillRectangle(Brushes.HotPink, 100, 100, 500, 500);
            g.FillRectangle(br, 200, 200, 500, 500);
            g.Dispose();
        }

        private void очисткаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);
            g.Dispose();
        }

        private void трапецияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Point[] tt = { new Point(30, 100), new Point(100, 100), new Point(150, 200), new Point(5, 200) };
            g.DrawPolygon(greenPen, tt);
            g.Dispose();
        }

        private void кругToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.FillEllipse(Brushes.Aqua, 150, 150, 50, 50);
            g.Dispose();
        }

        private void треугольникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Point[] tt = { new Point(150, 100), new Point(150, 200), new Point(250, 150) };
            g.FillPolygon(Brushes.Crimson, tt);
            g.Dispose();
        }

        private void шестиугольникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Point[] tt = { new Point(30, 100), new Point(100, 100), new Point(150, 150), new Point(100, 200), new Point(30, 200), new Point(5, 150) };
            g.FillPolygon(Brushes.Tan, tt);
            g.Dispose();
        }

        private void трапецияToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Point[] tt = { new Point(30, 100), new Point(100, 100), new Point(150, 200), new Point(5, 200) };
            g.FillPolygon(Brushes.PeachPuff, tt);
            g.Dispose();
        }

        private void снеговикИЁлкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Point[] tt = { new Point(340, 50), new Point(380, 50), new Point(405, 100), new Point(315, 100) };
            g.FillPolygon(Brushes.DarkGray, tt);
            g.FillEllipse(Brushes.Snow, 320, 101, 80, 80);
            g.FillEllipse(Brushes.Snow, 300, 181, 120, 120);
            g.FillEllipse(Brushes.Snow, 280, 301, 160, 160);
            Point[] mor = { new Point(360, 141), new Point(380, 145), new Point(360, 150) };
            g.FillEllipse(Brushes.Black, 340, 130, 10, 10);
            g.FillEllipse(Brushes.Black, 380, 130, 10, 10);
            g.FillPolygon(Brushes.Orange, mor);
            Point[] elka = { new Point(610, 70), new Point(560, 130), new Point(660, 130) };
            g.FillPolygon(Brushes.DarkGreen, elka);
            Point[] elka1 = { new Point(610, 130), new Point(540, 210), new Point(680, 210) };
            g.FillPolygon(Brushes.DarkGreen, elka1);
            Point[] elka2 = { new Point(610, 210), new Point(520, 300), new Point(700, 300) };
            g.FillPolygon(Brushes.DarkGreen, elka2);
            g.FillRectangle(Brushes.Brown, 590, 300, 40, 60);
            g.Dispose();
        }

        private void летящийКругToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.DrawEllipse(bluePen, x, y, 10, 10);
            // Thread.Sleep(20);
            //g.Clear(Color.LightGray);           
            if (x > 790)
            {
                i = 1;
            }
            if (y > 435)
            {
                j = 1;
            }
            if (x < 6)
            {
                i = 0;
            }
            if (y < 20)
            {
                j = 0;
            }
            if (i == 1)
            {
                x--;
            }
            else x++;
            if (j == 1)
            {
                y--;
            }
            else y++;
            Thread.Sleep(10);
            g.Clear(Color.LightGray);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();

        }



        private void функцияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double x0, y0, x1, y1, x2, y2;
            Graphics g = this.CreateGraphics();
            x0 = this.Width / 2;
            y0 = this.Height / 2;
            Point[] osx = { new Point(0, this.Height / 2), new Point(this.Width, this.Height / 2) };
            g.DrawLines(blackPen, osx);
            Point[] osy = { new Point(this.Width / 2, 0), new Point(this.Width / 2, this.Height) };
            g.DrawLines(blackPen, osy);
            x1 = -40;
            y1 = x1 * x1 * x1;
            for (int x = -40; x < 40; x += 1)
            {
                int i3 = x;
                int i4 = (i3 * i3 * i3) / 50;
                g.DrawLine(redPen, (float)(x1 + x0), (float)(y1 + y0), (float)(i3 + x0), (float)(i4 + y0));
                x1 = i3;
                y1 = i4;
            }
            x2 = -40;
            y2 = x2 * x2;
            for (int x = -40; x < 40; x += 1)
            {
                int i3 = x;
                int i4 = (i3 * i3) / 5;
                g.DrawLine(bluePen, (float)(x2 + x0), (float)(-y2 + y0), (float)(i3 + x0), (float)(-i4 + y0));
                x2 = i3;
                y2 = i4;
            }
            x2 = -40 * 50;
            y2 = Math.Sin(x2) * 200;
            for (int x = -40; x < 40; x += 1)
            {
                int i3 = x * 50;
                double i4 = Math.Sin(i3) * 200;
                g.DrawLine(purplePen, (float)(x2 + x0), (float)(y2 + y0), (float)(i3 + x0), (float)(i4 + y0));
                x2 = i3;
                y2 = i4;
            }
            x2 = -40 * 50;
            y2 = Math.Cos(x2) * 200;
            for (int x = -40; x < 40; x += 1)
            {
                int i3 = x * 50;
                double i4 = Math.Cos(i3) * 200;
                g.DrawLine(greenPen, (float)(x2 + x0), (float)(y2 + y0), (float)(i3 + x0), (float)(i4 + y0));
                x2 = i3;
                y2 = i4;
            }

        }

        private void мышкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            starpoint = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            if (e.Button == MouseButtons.Left)
            {
                g.DrawLine(blackPen, starpoint, e.Location);
                starpoint = e.Location;
            }
        }
        private void дождьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Random rnd=new Random();
            g.Clear(Color.DeepSkyBlue);
            for (int i = 0; i < 25; i++)
            {
                int x = rnd.Next(0, this.Width);
                int y = rnd.Next(0, this.Height);
                int width = rnd.Next(5, 15);
                int height = rnd.Next(10, 30);
                g.FillEllipse(Brushes.LightCyan, x, y,width,height);
                Thread.Sleep(1);
            }
        }
        private void MyDraw1(Graphics g, int N,int kx,int ky, int x, int y)
        {
            if (N == 0)
                return;
            else
            {
                // Отрисовка прямоугольника
                g.DrawRectangle(bluePen,kx,ky, x, y);
                // Увеличение x и y на 50
                x += 50;
                y += 50;
                kx -= 25;
                ky -= 25;
                N--;
                // Рекурсивный вызов с новыми параметрами
                MyDraw1(g, N,kx,ky ,x, y);
            }
        }
        private void задание1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            int kx = this.Width/2;
            int ky = this.Height/2;
            MyDraw1(g, 7, kx, ky, 50, 50);
        }

        private void задание2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            int kx = this.Width / 2;
            int ky = this.Height / 2;
            MyDraw2(g, 7, kx, ky, 50, 50);
        }
        private void MyDraw2(Graphics g, int N, int kx, int ky, int x, int y)
        {
            if (N == 0)
                return;
            else
            {
                g.DrawEllipse(redPen, kx, ky, x, y);
                x += 50;
                y += 50;
                kx -= 25;
                ky -= 25;
                N--;
                MyDraw2(g, N, kx, ky, x, y);
            }
        }

        private void задание3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            MyDraw3(g, 7, 10, 10, 30, 30);
        }
        private void MyDraw3(Graphics g,int N,int kx, int ky, int x, int y)
        {
            if (N == 0)
            {
                return;
            }
            else
            {
                g.DrawEllipse(greenPen, kx, ky, x, y);
                kx += 50;
                ky += 50;
                N--;
                MyDraw3(g, N, kx, ky, x, y);
            }
        }

        private void задание4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            /*Point tt1 = new Point(this.Width / 2, 30);
            Point tt2 = new Point(this.Width-20,this.Height-50);
            Point tt3 = new Point(0,this.Height-50);
            Point[] tt = {tt1, tt2,tt3};*/
            int ax = this.Width / 2;
            int ay = 30;
            int bx = this.Width - 20;
            int by = this.Height - 50;
            int cx = 0;
            int cy = this.Height - 50;
            int n = 10;
            //g.DrawPolygon(blackPen, tt);
            MyDraw11(g,ax,ay,bx,by,cx,cy,n);
            g.Dispose();
        }
        private void MyDraw11(Graphics g, int ax, int ay, int bx, int by, int cx, int cy,int n)
        {
            if (n == 0)
            {
                return;
            }
            else
            {
                n--;
                Point tt1 = new Point(ax, ay);
                Point tt2 = new Point(bx, by);
                Point tt3 = new Point(cx, cy);
                Point[] tt = { tt1, tt2, tt3 };
                g.DrawPolygon(blackPen, tt);
                MyDraw11(g, ax, ay, bx, by, cx, cy,n);
                MyDraw11(g, ax, ay, bx/2, by/2, cx+ax/2, cy/2,n);
                MyDraw11(g, ax, ay, bx/2, by/2, cx+ax/2, cy/2,n);
                MyDraw11(g, ax, ay, bx, by, cx, cy,n);
            }
        }
    }
}
