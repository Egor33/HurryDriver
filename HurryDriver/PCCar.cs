using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HurryDriver
{
    class PCCar:Car
    {
        protected int type, num;
        Random rand = new Random();

        public delegate void MethodContainer(int num);
        public event MethodContainer needresp;

        public PCCar(int x1, int y1, int speed1, int type1, int num1):base(x1) 
        {
            x = x1;
            y = y1;
            speed = speed1;
            type = type1;
            num = num1; //номер машины на дороге
        }

        void resp()
        {
            if (y>800) y = rand.Next(150); 
        }


        public void move()
        {
            y -= speed;
            if (y > 1200) needresp(num);
            if (easilY >= 0)
            {
                pixdistance = easilY + 800;
                easilY = -800;
                y += pixdistance;
            }
        }

        public void RoadReturn(int pixd)
        {
            y += pixd;
        }
    }
}
