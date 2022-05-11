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
    public partial class GameWindow_Ai : Form
    {
		string Name_Player = Info1player.name_player;
		bool turn = true;  // true = X turn; false = O turn;
		int turn_count = 0;
		bool gameOver = false;
		internal string Name_Pc = "Computer";
		//A1.ForeColor = Color.Red; 
		
        public GameWindow_Ai()
        {
            InitializeComponent();
        }

        private void btn_click(object sender, EventArgs e)
        {
			turn_count++;
			Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
                win.Text = (Name_Pc + "'s turn");
            }
            else
            {
                b.Text = "O";
                win.Text = (Name_Player + "'s turn");
            }
            turn = !turn;
            b.Enabled = false;

            if (checkForWinner())
                gameOver = true;
			if (!gameOver && !turn )
				computerMakeMove();

		}



        private void buttom_mousehover(object sender, EventArgs e)
        {
			Button b = (Button)sender;
			b.BackColor = Color.LightGray;
		}
        private void buttom_mouseleave(object sender, EventArgs e)
        {
			Button b = (Button)sender;
			b.BackColor = Color.White;
		}
		private void computerMakeMove()
		{
			win.Text = "Computer is thinking...";
			Button move = null;
			// Get winning square if available
			move = aiGetWin();
			// If no move available try to block player winning move.
			if (move == null)
				move = aiBlockWin();
			// If no move choosen perform opening logic or get random available square.
			if (move == null)
				move = aiPerformLogic();
			// If move is available perform a click on selected square
			if (move != null)
				move.PerformClick();
		}
		private Button aiPerformLogic()
		{
			// Take center if free
			if (B2.Text == "")
				return B2;

			Random rnd = new Random();
			int wildcard = rnd.Next(3); //0,1,2

			// Things become more interesting when they are random :D
			// Meant as an opening move.
			switch (wildcard)
			{
				case 0:
					if (A1.Text == "")
						return A1;
					break;
				case 1:
					if (A3.Text == "")
						return A3;
					break;
				case 2:
					if (C1.Text == "")
						return C1;
					break;
				case 3:
					if (C3.Text == "")
						return C3;
					break;
			}
			if (A2.Text == "")
				return A2;
			else if (B1.Text == "")
				return B1;
			else if (B2.Text == "")
				return B2;
			else if (B3.Text == "")
				return B3;
			else if (C2.Text == "")
				return C2;
            else
            {
				win.Text = "Error 100";
				return null;
            }

		} 
		private Button aiGetWin()
		{
			// Cock block opponent
			// Horizontal Row A
			if ((A1.Text == "") && (A2.Text == "O") && (A3.Text == "O"))
				return A1;
			else if ((A1.Text == "O") && (A2.Text == "") && (A3.Text == "O"))
				return A2;
			else if ((A1.Text == "O") && (A2.Text == "O") && (A3.Text == ""))
				return A3;

			// Horizontal Row B
			else if ((B1.Text == "") && (B2.Text == "O") && (B3.Text == "O"))
				return B1;
			else if ((B1.Text == "O") && (B2.Text == "") && (B3.Text == "O"))
				return B2;
			else if ((B1.Text == "O") && (B2.Text == "O") && (B3.Text == ""))
				return B3;

			// Horizontal Row C
			else if ((C1.Text == "") && (C2.Text == "O") && (C3.Text == "O"))
				return C1;
			else if ((C1.Text == "O") && (C2.Text == "") && (C3.Text == "O"))
				return C2;
			else if ((C1.Text == "O") && (C2.Text == "O") && (C3.Text == ""))
				return C3;

			// Vertical Row 1
			else if ((A1.Text == "") && (B1.Text == "O") && (C1.Text == "O"))
				return A1;
			else if ((A1.Text == "O") && (B1.Text == "") && (C1.Text == "O"))
				return B1;
			else if ((A1.Text == "O") && (B1.Text == "O") && (C1.Text == ""))
				return C1;

			// Vertical Row 2
			else if ((A2.Text == "") && (B2.Text == "O") && (C2.Text == "O"))
				return A2;
			else if ((A2.Text == "O") && (B2.Text == "") && (C2.Text == "O"))
				return B2;
			else if ((A2.Text == "O") && (B2.Text == "O") && (C2.Text == ""))
				return C2;

			// Vertical Row 3
			else if ((A3.Text == "") && (B3.Text == "O") && (C3.Text == "O"))
				return A3;
			else if ((A3.Text == "O") && (B3.Text == "") && (C3.Text == "O"))
				return B3;
			else if ((A3.Text == "O") && (B3.Text == "O") && (C3.Text == ""))
				return C3;

			// Diagonal 1
			else if ((A1.Text == "") && (B2.Text == "O") && (C3.Text == "O"))
				return A1;
			else if ((A1.Text == "O") && (B2.Text == "") && (C3.Text == "O"))
				return B2;
			else if ((A1.Text == "O") && (B2.Text == "O") && (C3.Text == ""))
				return C3;

			// Diagonal 2
			else if ((C1.Text == "") && (B2.Text == "O") && (A3.Text == "O"))
				return C1;
			else if ((C1.Text == "O") && (B2.Text == "") && (A3.Text == "O"))
				return B2;
			else if ((C1.Text == "O") && (B2.Text == "O") && (A3.Text == ""))
				return A3;

			// End
			else
				return null;
		}
		private Button aiBlockWin()
		{
			// Cock block opponent
			// Horizontal Row A
			if ((A1.Text == "") && (A2.Text == "X") && (A3.Text == "X"))
				return A1;
			else if ((A1.Text == "X") && (A2.Text == "") && (A3.Text == "X"))
				return A2;
			else if ((A1.Text == "X") && (A2.Text == "X") && (A3.Text == ""))
				return A3;

			// Horizontal Row B
			else if ((B1.Text == "") && (B2.Text == "X") && (B3.Text == "X"))
				return B1;
			else if ((B1.Text == "X") && (B2.Text == "") && (B3.Text == "X"))
				return B2;
			else if ((B1.Text == "X") && (B2.Text == "X") && (B3.Text == ""))
				return B3;

			// Horizontal Row C
			else if ((C1.Text == "") && (C2.Text == "X") && (C3.Text == "X"))
				return C1;
			else if ((C1.Text == "X") && (C2.Text == "") && (C3.Text == "X"))
				return C2;
			else if ((C1.Text == "X") && (C2.Text == "X") && (C3.Text == ""))
				return C3;

			// Vertical Row 1
			else if ((A1.Text == "") && (B1.Text == "X") && (C1.Text == "X"))
				return A1;
			else if ((A1.Text == "X") && (B1.Text == "") && (C1.Text == "X"))
				return B1;
			else if ((A1.Text == "X") && (B1.Text == "X") && (C1.Text == ""))
				return C1;

			// Vertical Row 2
			else if ((A2.Text == "") && (B2.Text == "X") && (C2.Text == "X"))
				return A2;
			else if ((A2.Text == "X") && (B2.Text == "") && (C2.Text == "X"))
				return B2;
			else if ((A2.Text == "X") && (B2.Text == "X") && (C2.Text == ""))
				return C2;

			// Vertical Row 3
			else if ((A3.Text == "") && (B3.Text == "X") && (C3.Text == "X"))
				return A3;
			else if ((A3.Text == "X") && (B3.Text == "") && (C3.Text == "X"))
				return B3;
			else if ((A3.Text == "X") && (B3.Text == "X") && (C3.Text == ""))
				return C3;

			// Diagonal 1
			else if ((A1.Text == "") && (B2.Text == "X") && (C3.Text == "X"))
				return A1;
			else if ((A1.Text == "X") && (B2.Text == "") && (C3.Text == "X"))
				return B2;
			else if ((A1.Text == "X") && (B2.Text == "X") && (C3.Text == ""))
				return C3;

			// Diagonal 2
			else if ((C1.Text == "") && (B2.Text == "X") && (A3.Text == "X"))
				return C1;
			else if ((C1.Text == "X") && (B2.Text == "") && (A3.Text == "X"))
				return B2;
			else if ((C1.Text == "X") && (B2.Text == "X") && (A3.Text == ""))
				return A3;

			// End
			else
				return null;
		}
		private bool checkForWinner()
		{
			bool there_is_a_winner = false;


			// Horizontal checks
			if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
            {
				there_is_a_winner = true;
            }
			
			else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
				there_is_a_winner = true;
			else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
				there_is_a_winner = true;

			// Vertical checks
			else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
				there_is_a_winner = true;
			else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
				there_is_a_winner = true;
			else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
				there_is_a_winner = true;

			// Diagonal checks
			else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled))
				there_is_a_winner = true;
			else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
				there_is_a_winner = true;

			if (there_is_a_winner)
			{
				disableButtons();

				String winner = "";
				if (turn)
				{
					winner = Name_Pc;
					o_wins.Text = (Int32.Parse(o_wins.Text) + 1).ToString();
				}
				else
				{
					winner = Name_Player;
					x_wins.Text = (Int32.Parse(x_wins.Text) + 1).ToString();
				}
				win.Text = (winner + "  Wins!");
				MessageBox.Show(winner + "Wins!");
			}
			else
			{
				if (turn_count >= 9)
				{
					draws.Text = (Int32.Parse(draws.Text) + 1).ToString();
					disableButtons();
					win.Text = ("It's a draw!");
					MessageBox.Show("It's a draw!");
					return true;
				}
			}
			if (there_is_a_winner)
				return true;
			else
				return false;
		}// End checkForWinner
		private void disableButtons()
		{
			foreach (Control c in Controls)
			{
				try
				{
					Button b = (Button)c;
					if ((b.Text.Length <= 1))
						b.Enabled = false;
				}// end try
				catch { }
			}// end foreach
		}



        private void Newgame_btn_Click(object sender, EventArgs e)
        {
			label2.Text = Name_Player;
			turn = true;
			turn_count = 0;
			gameOver = false;
			win.Text = (Name_Player + "'s turn");
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
        private void GameWindow_Ai_Load(object sender, EventArgs e)
        {
			win.Text = (Name_Player + "'s turn");
			label2.Text = Name_Player;
			turn_count = 0;
			turn = true;
			gameOver = false;
			MessageBox.Show(Name_Player + " is 'O' , and " + Name_Pc + " is 'X'");
		}
        private void btn_back_Click(object sender, EventArgs e)
        {
			Intro intro = new Intro();
			this.Hide();
			intro.ShowDialog();
		}




		private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Enter(object sender, EventArgs e)
        {
			Button b = (Button)sender;
			if (turn)
				b.Text = "X";
			else
				b.Text = "O";
		}

    }
}
