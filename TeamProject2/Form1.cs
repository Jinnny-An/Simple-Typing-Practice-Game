using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamProject2
{
    public partial class Form1 : Form
    {
        public static Random random = new Random();
        private Soldier[] soldiers = new Soldier[5]; // 5마리 soldier의 객체를 저장하기 위한 배열
        private GoodBoy goodBoy;
        private Boss boss;
        private PictureBox[] GLife = new PictureBox[5];
        private PictureBox[] BLife = new PictureBox[3];

        int j = 1;
        int bossAttactTime = 0;
        int count = 0;

        public Form1()
        {
            InitializeComponent();

            goodBoy = new GoodBoy();
            boss = new Boss();

            soldiers[0] = new Soldier() { StartingPosition = 558, RacetrackLength = 400, MyPictureBox = Soldier1, Randomizer = random, Life = 1 };
            soldiers[1] = new Soldier() { StartingPosition = 457, RacetrackLength = 300, MyPictureBox = Soldier2, Randomizer = random, Life = 1 };
            soldiers[2] = new Soldier() { StartingPosition = 363, RacetrackLength = 200, MyPictureBox = Soldier3, Randomizer = random, Life = 1 };
            soldiers[3] = new Soldier() { StartingPosition = 457, RacetrackLength = 300, MyPictureBox = Soldier4, Randomizer = random, Life = 1 };
            soldiers[4] = new Soldier() { StartingPosition = 558, RacetrackLength = 400, MyPictureBox = Soldier5, Randomizer = random, Life = 1 };
            goodBoy.Life = 5;
            boss.Life = 4;

            GLife[0] = GLife1;
            GLife[1] = GLife2;
            GLife[2] = GLife3;
            GLife[3] = GLife4;
            GLife[4] = GLife5;

            BLife[0] = BLife1;
            BLife[1] = BLife2;
            BLife[2] = BLife3;
        }

        public void EndGameReset()
        {
            for (int i = 0; i < 5; i++)
            {
                GLife[i].Visible = true;
                soldiers[i].TakeStartingPoint();
            }

            BLife1.Visible = true;
            BLife2.Visible = true;
            BLife3.Visible = true;

            goodBoy.Life = 5;
            boss.Life = 4;

        }


        private void GoodBoyHeart()
        {
            if (goodBoy.Life == 5)
            {
                for (int i = 0; i < 5; i++)
                {
                    GLife[i].Visible = true;
                }

            }
            else if (goodBoy.Life == 4)
            {
                for (int i = 0; i < goodBoy.Life; i++)
                {
                    GLife[i].Visible = true;
                }
                GLife5.Visible = false;

            }
            else if (goodBoy.Life == 3)
            {
                for (int i = 0; i < goodBoy.Life; i++)
                {
                    GLife[i].Visible = true;
                }
                GLife4.Visible = false;
                GLife5.Visible = false;
            }
            else if (goodBoy.Life == 2)
            {
                for (int i = 4; i >= goodBoy.Life; i--)
                {
                    GLife[i].Visible = false;
                }
                GLife1.Visible = true;
                GLife2.Visible = true;
            }
            else if (goodBoy.Life == 1)
            {
                for (int i = 1; i <= 4; i++)
                {
                    GLife[i].Visible = false;
                }
                GLife1.Visible = true;
            }
            else
            {
                listBox1.Items.Clear();
                MessageBox.Show("Good Boy Loose Game Over!");
                timer1.Stop();
                EndGameReset();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (listBox1.Items.Contains(e.KeyCode))
            {
                if (count >= 0 && count < 4)
                {
                    soldiers[count].CountLife(1);
                    label1.Text = goodBoy.WhoAttack();

                    count++;
                    for (int i = 0; i < 4; i++)
                    {
                        if (soldiers[i].Life == 0)
                        {
                            soldiers[i].MyPictureBox.Visible = false;
                        }
                    }

                    if (count == 3)
                    {
                        BossPicture.Visible = true;

                        for (int i = 0; i < 3; i++)
                        {
                            BLife[i].Visible = true;

                        }
                    }
                }
                else
                {
                    goodBoy.CountLife(soldiers[4].AttackSoldier());
                    soldiers[4].MyPictureBox.Visible = false;

                    label3.Text = soldiers[4].WhoAttack();
                    label1.Text = goodBoy.WhoAttack();
                    GoodBoyHeart();
                    count = 0;
                }

                listBox1.Items.Remove(e.KeyCode);
                listBox1.Refresh();

                if (BossPicture.Visible)
                {
                    boss.CountLife(1);
                    label1.Text = goodBoy.WhoAttack();
                    label2.Text = "";

                    if (boss.Life == 3)
                    {
                        BLife1.Visible = true;
                        BLife2.Visible = true;
                        BLife3.Visible = true;
                    }
                    else if (boss.Life == 2)
                    {
                        BLife1.Visible = false;
                        BLife2.Visible = true;
                        BLife3.Visible = true;
                    }
                    else if (boss.Life == 1)
                    {
                        BLife1.Visible = false;
                        BLife2.Visible = false;
                        BLife3.Visible = true;
                    }
                    else
                    {
                        listBox1.Items.Clear();
                        timer1.Stop();
                        MessageBox.Show("Boss Lose Game Over!");
                        EndGameReset();
                    }
                }

            }
            else
            {
                pictureBox1.Visible = true;
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            listBox1.Items.Add((Keys)random.Next(65, 90));
            
            bool[] soldiersTF = new bool[5] { false, false, false, false, false };
            while ((soldiersTF[0] == false) && (soldiersTF[1] == false) && (soldiersTF[2] == false) && (soldiersTF[3] == false) && (soldiersTF[4] == false))
            {
                for (int i = 0; i < 5; i++) 
                {
                    soldiersTF[i] = soldiers[i].Run();
                }
            }

            if (BossPicture.Visible)
            {
                bossAttactTime++;

                if (bossAttactTime%10==0)
                {
                    goodBoy.CountLife(boss.Aggression());
                    label1.Text = boss.WhoAttack();
                    GoodBoyHeart();
                }
                else
                {
                    GoodBoyHeart();
                }
            }

           else
            {
                GoodBoyHeart();
            }

            if (j == 60)
            {
                listBox2.Items.Clear();
                listBox2.Items.Add(1);
                timer1.Stop();
            }
            else
            {
                listBox2.Items.Remove(j - 1);
                listBox2.Items.Add(j);

                j++;
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
                timer2_Tick(sender, e);
                timer2.Interval = 18000;
                timer2.Start();
            
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (BossPicture.Visible == true)
            {
                goodBoy.AddLife(1);
                GoodBoyHeart();
            }
            }
    }
}
