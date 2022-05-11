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
    public partial class Info1player : Form
    {
        public static string name_player;
        public static int level;
        public Info1player()
        {
            InitializeComponent();
        }

        private void TXT1_TextChanged(object sender, EventArgs e)
        {
            name_player = TXT1.Text;
        }


        private void BTN_START_Click(object sender, EventArgs e)
        {
            GameWindow_Ai gameWindow_Ai = new GameWindow_Ai();
            this.Hide();
            gameWindow_Ai.Show();
        }

        private void Info1player_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Intro intro = new Intro();
            this.Hide();
            intro.ShowDialog();
        }
    }
}
