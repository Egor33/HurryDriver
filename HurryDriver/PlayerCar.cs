using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HurryDriver
{
    class PlayerCar:Car
    {
        public PlayerCar(int x1) : base(x1)
        {
            x = x1;
            car = new Bitmap(Properties.Resources.R32, 44, 100);
            y = 1110;
            eversion = 5;
            speed = 1;
            maxspeed = 7;
            acceleration = 1;
            width = 44;
            height = 100;
        }

        public delegate void MethodContainer(int pixd);

        public event MethodContainer RoadLeft;
        

        public void move()
        {
            y -= speed;
            easilY += speed;
            if (easilY >= 0)
            {
                pixdistance = easilY + 800;
                RoadLeft(pixdistance);
                easilY = -800;
                y += pixdistance;
            }

        }
    }
}
