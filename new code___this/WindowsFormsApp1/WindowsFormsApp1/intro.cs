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
    public partial class Intro : Form
    {
        public Intro()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Intro_Load(object sender, EventArgs e)
        {

        }


        private void RB_1player_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (RB_1player.Checked)
            {
                Info1player info1player = new Info1player();
                this.Hide();
                info1player.ShowDialog();
            }
            else if (RB_2players.Checked)
            {
                Info2players infoplayers = new Info2players();
                this.Hide();
                infoplayers.ShowDialog();
            }
            else
            {
                MessageBox.Show("please , Choose the number of players");
            }

        }
    }
}
