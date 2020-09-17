using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace yoketoruvs0910
{
    public partial class Form1 : Form
    {
        const bool isDebug = true;

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

        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);

        public Form1()
        {
            InitializeComponent();

            for(int i=0;i<ChrMax;i++)
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
            nextState = State.Game;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
if(nextState !=State.None)
            {
                initPpoc();
            }

            if(isDebug)
            {
                if (GetAsyncKeyState((int)Keys.O)<0)
                {
                    nextState = State.Gameover;
                }
               else if (GetAsyncKeyState((int)Keys.C) < 0)
                {
                    nextState = State.Clear;
                }
            }

            if(currentState==State.None)
            {
                UpdateGame();
            }

        }
        void UpdateGame()
        {
            //Point mp = PointToClient(MousePosition);
        }

        void initPpoc()
        {
            currentState = nextState;
            nextState= State.None;

            switch (currentState)
            {
                case State.Title:
                    titlelabel.Visible = true;
                    startButton.Visible = true;
                    copyrightLabel.Visible = true;
                    hiLabel.Visible = true;
                    gameOverLabel.Visible = false;
                    titlebutton.Visible = false;
                    clearLabel.Visible = false;
                    break;

                case State.Game:
                    titlelabel.Visible = false;
                    startButton.Visible = false;
                    copyrightLabel.Visible = false;
                    hiLabel.Visible = false;

                    for(int i=EnemyIndex;i<ChrMax;i++)
                    {
                        chrs[i].Left = rand.Next(ClientSize.Width - chrs[i].Width);
                        chrs[i].Top = rand.Next(ClientSize.Height - chrs[i].Height);
                    }

                    break;

                case State.Gameover:
                    gameOverLabel.Visible = true;
                    titlebutton.Visible = true;
                    break;

                case State.Clear:
                    hiLabel.Visible = true;
                    titlebutton.Visible = true;
                    clearLabel.Visible = true;
                    break;
            }
        }

        private void titlebutton_Click(object sender, EventArgs e)
        {
            nextState = State.Title;
        }
    }
}
