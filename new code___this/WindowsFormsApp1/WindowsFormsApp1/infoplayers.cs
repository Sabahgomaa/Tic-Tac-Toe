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
    public partial class Info2players : Form  
    {
       public static string name_player1;
       public static string name_player2;

        public Info2players()
        {
            InitializeComponent();
        }

        private void TXT1_TextChanged(object sender, EventArgs e)
        {
             name_player1 = TXT1.Text;
        }

        private void TXT2_TextChanged(object sender, EventArgs e)
        {
             name_player2 = TXT2.Text;
        }

        private void BTN_START_Click(object sender, EventArgs e)
        {
            GameWindow_out_Ai gameWindow_Out_Ai = new GameWindow_out_Ai();
            this.Hide();
            gameWindow_Out_Ai.Show();
        }

        private void Infoplayers_Load(object sender, EventArgs e)
        {
        }

        private void Info2players_Load(object sender, EventArgs e)
        {
        }

        private void TXT1_Validating(object sender, CancelEventArgs e)
        {
        }

        private void TXT2_Validating(object sender, CancelEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Intro intro = new Intro();
            this.Hide();
            intro.ShowDialog();
        }
    }
}
