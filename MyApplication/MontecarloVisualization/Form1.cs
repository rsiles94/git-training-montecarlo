using MontecarloAlgorithms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MontecarloVisualization
{
    public partial class Form1 : Form
    {
        MonteCarloPI montecarlo;

        public Form1()
        {
            montecarlo = new MonteCarloPI();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            montecarlo.GeneratePoint();

            this.Text = $"PI : {montecarlo.GetPI()} ({montecarlo.Points.Count})";

            this.picCanvas.Invalidate();
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            DrawAll(e.Graphics);
        }

        private void DrawAll(Graphics graphics)
        {
            int w = this.picCanvas.Width;
            int h = this.picCanvas.Height;

            graphics.DrawEllipse(Pens.Blue, 0, 0, w, h);

            for (int i = 0; i < montecarlo.Points.Count; i++)
            {
                var cPoint = montecarlo.Points[i];

                double drawX = w / 2.0 + cPoint.X * w;
                double drawY = h / 2.0 + cPoint.Y * h;

                Pen targetPen;

                if (cPoint.insideCircle)
                {
                    targetPen = Pens.Red;
                }
                else
                {
                    targetPen = Pens.Green;
                }

                graphics.DrawEllipse(targetPen, (float)drawX - 2, (float)drawY - 2, 4, 4);
            }
        }

        private void picCanvas_Click(object sender, EventArgs e)
        {

        }
    }
}
