using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class GameWindow_out_Ai : Form
    {
        string player1 = Info2players.name_player1;
        string player2 = Info2players.name_player2;
        int Turn_Count = 0;
        bool isWinner = false;
        public GameWindow_out_Ai()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            MessageBox.Show(player1 + " is 'O' , and " + player2 + " is 'X'.");
            win.Text = (player1 + "'s turn");
            label2.Text = player1;
            label4.Text = player2;
            Turn_Count = 0;
            isWinner = false;
        }
        private void button_mousehover(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.BackColor = Color.LightGray;
        }
        private void button_mouseleave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.BackColor = Color.White;
        }
        private void button_click(object sender, EventArgs e)
        {
            bool GameOver = isWinner;
            if (!GameOver)
            {
                Button b = (Button)sender;
                if (Turn_Count % 2 == 0)
                {
                    win.Text = (player2 + "'s turn");
                    b.Text = "O";
                    Winner();
                    Enabel();
                    Turn_Count++;
                }
                else
                {
                    win.Text = (player1 + "'s turn");
                    b.Text = "X";
                    Winner();
                    Enabel();
                    Turn_Count++;
                }
            }
        }
        private void Winner()
        {
            isWinner = false;

            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (A1.Text != ""))
                isWinner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (B1.Text != ""))
                isWinner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (C1.Text != ""))
                isWinner = true;


            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (A1.Text != ""))
                isWinner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (A2.Text != ""))
                isWinner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (A3.Text != ""))
                isWinner = true;


            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (A1.Text != ""))
                isWinner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (A3.Text != ""))
                isWinner = true;


            if (isWinner)
            {
                Disable_Button();
                string winner = "";
                if (Turn_Count % 2 == 0)
                {
                    winner = player1;
                    Turn_Count++;
                    x_wins.Text = (Int32.Parse(x_wins.Text) + 1).ToString();
                }
                else
                {
                    winner = player2;
                    Turn_Count++;
                    o_wins.Text = (Int32.Parse(o_wins.Text) + 1).ToString();
                }
                win.Text =  winner + " Wins!";
                MessageBox.Show(winner + "Wins!");
            }
            else
            {
                if (Turn_Count >= 9)
                {
                    draws.Text = (Int32.Parse(draws.Text) + 1).ToString();
                    Disable_Button();
                    win.Text = "Draw!";
                    MessageBox.Show("It Is Draws!");
                }
            }
        }
        private void Disable_Button()
        {
            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    if ((b.Text.Length <= 1))
                    {
                        b.Enabled = false;
                    }
                }
                catch { }
            }
        }
        private void Enabel()
        {
            foreach (Control c in Controls)
            {
                if ((c.Text == "X" || c.Text == "O"))
                {
                    c.Enabled = false;
                }
            }
        }
        private void Newgame_btn_Click(object sender, EventArgs e)
        {
            isWinner = false;
            win.Text = (player1 + "'s turn");
            label2.Text = player1;
            label4.Text = player2;
            Turn_Count = 0;
            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    if (b.Text.Length <= 1)
                    {
                        b.Text = "";
                    }
                }
                catch { }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Intro intro = new Intro();
            this.Hide();
            intro.ShowDialog();
        }



        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void label4_Click(object sender, EventArgs e)
        {
        }


 

    }
}
