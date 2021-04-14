using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace pr11v6
{
    class ellips
    {
        const int rad = 50; 
        private Graphics graphics;
        private int _rad;
        private int _rad1;
        Rectangle[] rec = new Rectangle[3];
        public int X { get; set; }
        public int Y { get; set; }
      
        public int Radius
        {
            get
            {
                return _rad;
            }
            set
            {
                _rad = value >= 200 ? 200 : value;
                _rad = value <= 5 ? 5 : value;
            }

        }
        public int Radius1
        {
            get
            {
                return _rad1;
            }
            set
            {
                _rad1 = value >= 200 ? 200 : value;
                _rad1 = value <= 5 ? 5 : value;
            }

        }



        public ellips(Graphics graphics, int X, int Y)
        {
            this.graphics = graphics;
            this.X = X;
            this.Y = Y;
          
        }
        public ellips(Graphics graphics, int X, int Y, int radius, int radius1)
        {
            this.graphics = graphics;
            this.X = X;
            this.Y = Y;
            Radius = radius;
            Radius1 = radius1;


            
        }
        public void Draw(Pen pen)
        {
            
            rec[0] = new Rectangle(X - Radius, Y - Radius, 2 * Radius, 2 * Radius);
            rec[1] = new Rectangle(X - Radius, Y - Radius, 2 * Radius, 2 * Radius);
            rec[2] = new Rectangle(X - Radius1, Y - Radius1, 2 * Radius1, 2 * Radius1);
            graphics.DrawRectangle(pen, rec[0]);
            graphics.DrawEllipse(pen, rec[1]);
            graphics.DrawRectangle(pen, rec[2]);



        }
        public void Show()
        {
            Draw(Pens.Black);
        }
        public void Hide()
        {
            Draw(Pens.White);

        }
        public void Move(int dX, int dY)
        {
            Hide();
            X = X + dX;
            Y = Y + dY;
     
            Show();

        }
        public void Colapse(int dR)
        {
            Hide();
            Radius -= dR;
            Radius1 -= (dR / 2)+1;
            Show();

        }
        public void Expand(int dR)
        {
            Hide();
            Radius += dR;
            Radius1 += (dR / 2)+1;
            Show();
        }
        public void Expand()
        {
            Hide();
            Radius++;
            Show();
        }
        public void Colapse()
        {
            Hide();
            Radius--;
            Show();
        }
     


    }
}

