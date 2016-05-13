using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HurryDriver
{
    class EmerCar : PCCar
    {
        public EmerCar(int x1, int y1, int speed1, int type1, int num1) : base(x1, y1, speed1, type1, num1)
        {
            x = x1;
            speed = speed1;
            y = y1;
            num = num1; 
            switch (type1)
            {
                case 0:
                    {
                        car = Properties.Resources.emergence;
                        width = 48;
                        height = 106;
                        break;
                    }
                case 1:
                    {
                        car = Properties.Resources.firekeepers;
                        width = 63;
                        height = 145;
                        break;
                    }
                case 2:
                    {
                        car = Properties.Resources.police;
                        width = 44;
                        height = 190;
                        break;
                    }
            }
        }
    }

}