using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gRAPHeDITORtRY6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Graphics formGraphics;
        bool isDown = false;
        int initialX;
        int initialY;


        private void Form1_MouseDown_1(object sender, MouseEventArgs e)
        {
            isDown = true;
            initialX = e.X;
            initialY = e.Y;
            Cursor.Current = Cursors.SizeNWSE;
        }

        private void Form1_MouseMove_1(object sender, MouseEventArgs e)
        {
            
            if (isDown == true)
            {
                //this.Refresh(); - это чтобы рисовался один, зато корректно 
 
                int width = e.X - initialX, height = e.Y - initialY;

                Rectangle myRectangle = new Rectangle(Math.Min(e.X, initialX),
                                               Math.Min(e.Y, initialY),
                                               Math.Abs(e.X - initialX),
                                               Math.Abs(e.Y - initialY));

                formGraphics = CreateGraphics();
                formGraphics.DrawRectangle(Pens.Black, myRectangle);
                formGraphics.FillRectangle(Brushes.MediumAquamarine, myRectangle);
            }
        }

        private void Form1_MouseUp_1(object sender, MouseEventArgs e)
        {
            isDown = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();

            g.Clear(Color.White);
        }
    }
}
