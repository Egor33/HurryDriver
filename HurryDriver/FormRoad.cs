using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HurryDriver
{
    public partial class FormRoad : Form
    {
        Graphics graphic, graphic1;
        Bitmap bmp, bmp1, bmp2;

        PlayerCar GTR = new PlayerCar(250);
        PCCar[] cars = new PCCar[10];

        Font drawFont = new Font("Showcard Gothic", 24);
        SolidBrush drawBrush = new SolidBrush(Color.Black);
        StringFormat sf = new StringFormat();

        TimeSpan TSP = new TimeSpan(0, 0, 20);
        TimeSpan sec = new TimeSpan(0, 0, 1);
        TimeSpan nul = new TimeSpan(0, 0, 0);
        TimeSpanConverter q = new TimeSpanConverter();
        TimeSpan TSP1 = new TimeSpan(0, 3, 0);

        Random rand = new Random();

        int turn=0, score = 0, recovery_mode;
        public bool gameOver = false, timemode;

        private void FormRoad_Load(object sender, EventArgs e)
        {
            DrawTimer.Enabled = true;
            scoreTimer.Enabled = true;
            
        }

        private void FormRoad_Deactivate(object sender, EventArgs e)
        {
            DrawTimer.Enabled = false;
            scoreTimer.Enabled = false; 
            Cursor.Show();
        }

        public FormRoad(bool tm)
        {
            timemode = tm; 
            InitializeComponent();

            initAgain(timemode);
              
        }

        void initAgain(bool timemode)
        {
            graphic = this.CreateGraphics();

            bmp = new Bitmap(Properties.Resources.asphalt);
            bmp1 = new Bitmap(bmp);
            bmp2 = new Bitmap(bmp);

            graphic1 = Graphics.FromImage(bmp1);
            rand = new Random(DateTime.Now.Millisecond);

            sf.Alignment = StringAlignment.Center;



            if (timemode)
            {
                timeTimer.Enabled = true;
            }

            for (int i = 0; i < 10; i++)
            {
               putPCCar(i);
               GTR.RoadLeft += cars[i].RoadReturn;
               cars[i].needresp += respcar; 
            }

        }

        void respcar(int i)
        {
            cars[i].y = rand.Next(150); 
        } 

        void putPCCar(int i)
        {
            int j;
            if (i < 4) j = i;
            else j = i % 4;
            switch (rand.Next(2))
            {
                case 0:
                    cars[i] = new EmerCar(129 + 91 * rand.Next(4), rand.Next(10)*50 + 100, rand.Next(6) + 1, rand.Next(3), i);
                    break;
                case 1:
                    cars[i] = new CivilCar(130 + 95 * rand.Next(4), rand.Next(10)*50 + 100, rand.Next(4) + 1, rand.Next(3),  i);
                    break;
            }
        }


        private void FormRoad_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (!gameOver)
            {
                if (e.KeyCode == Keys.Escape)
                {
                    gameover(timemode);
                }

                if ((e.KeyCode == Keys.Left) && (GTR.x > 120))
                {
                    turn = -1;
                    TSP.Add(sec);
                }

                if ((e.KeyCode == Keys.Right) && (GTR.x < 435))
                {
                    turn = 1;
                }

                if ((e.KeyCode == Keys.Up)&&(recovery_mode==0))
                {
                    GTR.accelerate();
                }

                if (e.KeyCode == Keys.Down)
                {
                    GTR.braking();
                }
            }
        }

        private void timeTimer_Tick(object sender, EventArgs e)
        {
            TSP = TSP.Add(-sec);
        }

        private void menuB_Click(object sender, EventArgs e)
        {
            this.Close();
            DrawTimer.Enabled = false;
            Cursor.Show();
        }



        private void againB_Click(object sender, EventArgs e)
        {
            Cursor.Hide();
            initAgain(timemode);
            if (timemode)
            {
                timeTimer.Enabled = true;
                TSP = new TimeSpan(0, 3, 0);
            }
            gameOver = false;
            score = 0;
            this.Controls.Clear();

        }

        private void FormRoad_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Left) && (GTR.x > 120))
            {
                turn = 0;
            }

            if ((e.KeyCode == Keys.Right) && (GTR.x < 435))
            {
                turn = 0;
            }
        }

        private void scoreTimer_Tick(object sender, EventArgs e)
        {
            if (GTR.speed>=2) score += (GTR.speed-2)*3;
            if (TSP == nul) gameover(true);

        }



        private void DrawTimer_Tick(object sender, EventArgs e)
        {
            GTR.move();
            if (turn != 0) GTR.turn(turn); 
            graphic1.DrawImage(bmp, 0, 0);
            if ((GTR.x > 440) || (GTR.x < 120)) turn = 0;
            for (int i = 0; i < 10; i++)
            {
                cars[i].move();
                cars[i].draw(graphic1);
            }
            if (recovery_mode%2!=1) GTR.draw(graphic1);

            graphic1.DrawString(score.ToString(), drawFont, drawBrush, 20, GTR.y-290);

            if (timeTimer.Enabled)
                graphic1.DrawString((TSP.Minutes.ToString()+":"+TSP.Seconds.ToString("D2")), drawFont, drawBrush, 500, GTR.y - 290);
            if (gameOver)
            {
                graphic1.DrawString("GAME OVER", drawFont, drawBrush, this.Size.Width / 2, GTR.y - 200, sf);
                graphic1.DrawString("Your score:"+score.ToString(), drawFont, drawBrush, this.Size.Width / 2, GTR.y - 150, sf);
            }
            
                graphic.DrawImage(bmp1, 0, GTR.easilY);


            for (int i = 0; i < 10; i++)
                if ((cars[i].x - GTR.x < GTR.width) && (GTR.x - cars[i].x < 60) && (GTR.y - cars[i].y < 90) && (cars[i].y - GTR.y < GTR.height)&&(recovery_mode == 0))
                    switch (timemode)
                    {
                        case false:
                            gameover(false);
                            break;
                        case true:
                            respawn();
                            break; 
                    }

            // сейчас будет говнокод, но как по другому я не придумал. Запилить событием машины нельзя, т.к. неизвестны координаты гтра. 

        }

        private void gameover(bool timemode)
        {
            GTR.speed = 0;
            gameOver = true; 
            Cursor.Show();
            timeTimer.Enabled = false;
            this.Controls.Add(this.againB);
            this.Controls.Add(this.menuB);
            menuB.Show();
            againB.Show();
        }

        private void respawn()
        {
            GTR.speed = 1;
            GTR.x = 300;
            recovery_mode = 1;
            recoveryTimer.Enabled = true; 



        }

        private void recoveryTimer_Tick(object sender, EventArgs e)
        {
            recovery_mode++;
            if (recovery_mode >= 6)
            {
                recovery_mode = 0;
                recoveryTimer.Enabled = false;
            }
        }

    }
}
