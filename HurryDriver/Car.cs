using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HurryDriver
{
   public class Car
    {
        public int x, y, easilY = -800, speed, pixdistance, maxspeed, acceleration, eversion, width, height;
        public Bitmap car;

        public Car (int x1)
        {
            x = x1;
        }

        public void turn(int where)
        {
            x = x + eversion * where;
        }



        public void braking()
        {
            if (speed >= 1)
                speed -= acceleration;
        }

        public void accelerate()
        {
            if (speed<=maxspeed)
            speed += acceleration;
        }

        public void draw(Graphics g)
        {
            g.DrawImage(car, x, y);
        }
    }
}
