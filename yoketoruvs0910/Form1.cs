using System;
using System.Windows.Forms;

namespace yoketoruvs0910
{
    public partial class Form1 : Form
    {
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

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

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
        }
        void initPpoc()
        {
            currentState = nextState;
            nextState= State.None;

            switch (currentState)
            {
                case State.Title:
                titlelabel1.Visible = true;
                    startButton.Visible = true;
                    copyrightLabel.Visible = true;
                    hiLabel.Visible = true;
                    gameOverLabel.Visible = true;
                    clearLabel.Visible = true;
                    break;
            }
        }
    }
}
