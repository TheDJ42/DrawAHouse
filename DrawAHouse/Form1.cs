using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawAHouse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen bluePen = new Pen(Color.CornflowerBlue, 4.0f);

            // Draw the roof

            e.Graphics.DrawLine(bluePen, 40, 391, 400, 9);

            e.Graphics.DrawLine(bluePen, 400, 9, 760, 391);

            // Draw the walls

            e.Graphics.DrawLine(bluePen, 80, 348, 80, 800);

            e.Graphics.DrawLine(bluePen, 80, 800, 720, 800);

            e.Graphics.DrawLine(bluePen, 720, 800, 720, 348);

            bluePen.Dispose();

            // Draw windows

            Pen yellowPen = new Pen(Color.PaleGoldenrod, 4.0f);

            e.Graphics.DrawRectangle(yellowPen, 200, 371, 120, 154);

            e.Graphics.DrawRectangle(yellowPen, 480, 371, 120, 154);

            e.Graphics.DrawLine(yellowPen, 260, 371, 260, 525);

            e.Graphics.DrawLine(yellowPen, 200, 448, 320, 448);

            e.Graphics.DrawLine(yellowPen, 540, 371, 540, 525);

            e.Graphics.DrawLine(yellowPen, 480, 448, 600, 448);

            yellowPen.Dispose();

            // Draw door

            Pen greenPen = new Pen(Color.LightGreen, 4.0f);

            e.Graphics.DrawLine(greenPen, 340, 800, 340, 600);

            e.Graphics.DrawLine(greenPen, 340, 600, 460, 600);

            e.Graphics.DrawLine(greenPen, 460, 600, 460, 800);

            e.Graphics.DrawEllipse(greenPen, 428, 680, 18, 18);

            greenPen.Dispose();
        }
    }
}
