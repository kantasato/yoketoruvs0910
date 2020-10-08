using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace yoketoruvs0910
{
    public partial class Form1 : Form
    {
       
        const bool isDebug = true;

        int itemCount;
        int timeCount;
        int score;
        int hiscore=0;
        const int PlayrMax = 1;
        const int EnemyMax = 10;
        const int ItemMax = 10;
        const int ChrMax = PlayrMax+EnemyMax+ItemMax;
        Label[] chrs = new Label[ChrMax];
        const int PlayerIndex = 0;
        const int EnemyIndex = PlayerIndex+ PlayrMax;
        const int Itemindex = EnemyIndex + EnemyMax;

        const string PlayerText = "(・ω・)";
        const string EnemyText = "◆";
        const string ItemText = "★";


        static Random rand = new Random();

        enum State
        {
            None=-1,
            Title,
            Game,
            Gameover,
            Clear,
        }
        State currentState = State.None;
        State nextState = State.Title;


        const int SpeedMax = 5;
        int[] vx = new int[ChrMax];
        int[] vy = new int[ChrMax];

        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);

        public Form1()
        {
            InitializeComponent();

           

            

            for (int i=0;i<ChrMax;i++)
            {
                chrs[i] = new Label();
                chrs[i] . AutoSize = true;
                if(i==PlayerIndex)
                {
                    chrs[i].Text = PlayerText;
                }
                else if(i<Itemindex)
                {
                    chrs[i].Text = EnemyText;
                }
                else
                {
                    chrs[i].Text = ItemText;   
                }
                chrs[i].Font = templabel.Font;
                Controls.Add(chrs[i]);
            }
           

        }
        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            
        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (nextState != State.None)
            {
                initPpoc();
            }

            if (currentState == State.None)
            {
                nextState = State.Title;
            }
            if (currentState == State.Game)
            {
                UpdateGame();
            }
        }
        void UpdateGame()
        {
            Point mp = PointToClient(MousePosition);

            chrs[PlayerIndex].Left = mp.X - chrs[PlayerIndex].Width;
            chrs[PlayerIndex].Top = mp.Y - chrs[PlayerIndex].Height;

            leftLabel.Text = "★;" + itemCount;
            timeLabel.Text = "time:" + timeCount;
            timeCount = timeCount - 1;
            if (itemCount <=0)
            {
                nextState = State.Clear;
                score = timeCount;
            }
            if (timeCount<0)
            {
                nextState = State.Gameover;
            }

            for (int i = EnemyIndex; i < ChrMax; i++)
            {
                chrs[i].Left += vx[i];
                chrs[i].Top += vy[i];

                if (isDebug)
                {
                    if (GetAsyncKeyState((int)Keys.O) < 0)
                    {
                        nextState = State.Gameover;
                    }
                    else if (GetAsyncKeyState((int)Keys.C) < 0)
                    {
                        nextState = State.Clear;
                    }
                }

                if (chrs[i].Left < 0)
                {
                    vx[i] = Math.Abs(vx[i]);
                }
                if (chrs[i].Top < 0)
                {
                    vy[i] = Math.Abs(vy[i]);
                }
                if (chrs[i].Right > ClientSize.Width)
                {
                    vx[i] = -Math.Abs(vx[i]);
                }
                if (chrs[i].Bottom > ClientSize.Height)
                {
                    vy[i] = -Math.Abs(vy[i]);
                }


                //当たり判定
                if ((mp.X >= chrs[i].Left)
            && (mp.X < chrs[i].Right)
            && (mp.Y >= chrs[i].Top)
            && (mp.Y < chrs[i].Bottom)
            )
                {
                    //敵か？
                    if (i < Itemindex)
                    {
                        nextState = State.Gameover;
                    }
                    else if (chrs[i].Visible == true)
                    {
                        //アイテム
                        chrs[i].Visible = false;
                        itemCount = itemCount - 1;
                        

                    }
                }
            }

        }

        void initPpoc()
        {
            currentState = nextState;
            nextState= State.None;

            switch (currentState)
            {
                case State.Title:
                    titlelabel.Visible = true;
                    startbutton.Visible = true;
                    copyrightLabel.Visible = true;
                    hiLabel.Visible = true;
                    gameOverLabel.Visible = false;
                    titlebutton.Visible = false;
                    clearLabel.Visible = false;
                    scorelabel.Visible = false;
                    hiLabel.Text = "HighScore " + hiscore;
                    break;

                case State.Game:
                    titlelabel.Visible = false;
                    startbutton.Visible = false;
                    copyrightLabel.Visible = false;
                    hiLabel.Visible = false;



                    for (int i=EnemyIndex;i<ChrMax;i++)
                    {
                        chrs[i].Visible = true;
                        chrs[i].Left = rand.Next(ClientSize.Width - chrs[i].Width);
                        chrs[i].Top = rand.Next(ClientSize.Height - chrs[i].Height);
                       vx[i]=rand.Next(-SpeedMax,SpeedMax+1);
                      vy[i] = rand.Next(-SpeedMax, SpeedMax+1);
                    }
                    itemCount = ItemMax;
                    timeCount = 100;
                    
                    break;

                case State.Gameover:
                    gameOverLabel.Visible = true;
                    titlebutton.Visible = true;
                    break;

                case State.Clear:
                    hiLabel.Visible = true;
                    titlebutton.Visible = true;
                    clearLabel.Visible = true;
                    scorelabel.Visible = true;
                    scorelabel.Text = "Score " + score;
                    if(score>hiscore)
                    {
                        hiscore = score;
                    }
                    hiLabel.Text = "HighScore " + hiscore;
                    break;
            }
        }

        private void titlebutton_Click(object sender, EventArgs e)
        {
            nextState = State.Title;
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            nextState = State.Game;
        }
    }
}
