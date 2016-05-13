using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HurryDriver
{
    class CivilCar:PCCar
    {
        public CivilCar(int x1, int y1, int speed1, int type1, int num1) : base(x1, y1, speed1, type1, num1)
        {
            x = x1;
            speed = speed1;
            y = y1;
            num = num1; 
            switch (type1)
            {
                case 1:
                    {
                        car = Properties.Resources.EvoVIII;
                        width = 37;
                        height = 93;
                        break;
                    }
                case 2:
                    {
                        car = Properties.Resources.n370z;
                        width = 41;
                        height = 84;
                        break;
                    }
                case 0:
                    {
                        car = new Bitmap(Properties.Resources.kalina, 40, 80);
                        width = 40;
                        height = 80;
                        break;
                    }
            }
        }
    }
}
