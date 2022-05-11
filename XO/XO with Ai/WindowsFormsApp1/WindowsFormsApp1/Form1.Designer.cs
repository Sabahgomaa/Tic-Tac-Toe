
namespace WindowsFormsApp1
{
    partial class GameWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Newgame_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.x_wins = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.o_wins = new System.Windows.Forms.Label();
            this.draws = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.win = new System.Windows.Forms.Label();
            this.A1 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Newgame_btn
            // 
            this.Newgame_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Newgame_btn.ForeColor = System.Drawing.Color.Black;
            this.Newgame_btn.Location = new System.Drawing.Point(294, 216);
            this.Newgame_btn.Name = "Newgame_btn";
            this.Newgame_btn.Size = new System.Drawing.Size(140, 43);
            this.Newgame_btn.TabIndex = 0;
            this.Newgame_btn.Text = "New Game";
            this.Newgame_btn.UseVisualStyleBackColor = true;
            this.Newgame_btn.Click += new System.EventHandler(this.Newgame_btn_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(296, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 179);
            this.label1.TabIndex = 1;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(310, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Player";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // x_wins
            // 
            this.x_wins.BackColor = System.Drawing.Color.White;
            this.x_wins.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x_wins.Location = new System.Drawing.Point(389, 31);
            this.x_wins.Name = "x_wins";
            this.x_wins.Size = new System.Drawing.Size(22, 24);
            this.x_wins.TabIndex = 3;
            this.x_wins.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(310, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "PC";
            // 
            // o_wins
            // 
            this.o_wins.AutoSize = true;
            this.o_wins.BackColor = System.Drawing.Color.White;
            this.o_wins.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.o_wins.Location = new System.Drawing.Point(389, 69);
            this.o_wins.Name = "o_wins";
            this.o_wins.Size = new System.Drawing.Size(17, 17);
            this.o_wins.TabIndex = 5;
            this.o_wins.Text = "0";
            // 
            // draws
            // 
            this.draws.AutoSize = true;
            this.draws.BackColor = System.Drawing.Color.White;
            this.draws.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.draws.Location = new System.Drawing.Point(394, 110);
            this.draws.Name = "draws";
            this.draws.Size = new System.Drawing.Size(17, 17);
            this.draws.TabIndex = 6;
            this.draws.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(310, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Draws";
            // 
            // win
            // 
            this.win.AutoSize = true;
            this.win.BackColor = System.Drawing.Color.White;
            this.win.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.win.Location = new System.Drawing.Point(310, 153);
            this.win.Name = "win";
            this.win.Size = new System.Drawing.Size(94, 17);
            this.win.TabIndex = 8;
            this.win.Text = "Placeholder";
            this.win.Click += new System.EventHandler(this.label8_Click);
            // 
            // A1
            // 
            this.A1.BackColor = System.Drawing.Color.White;
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1.Location = new System.Drawing.Point(25, 45);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(62, 59);
            this.A1.TabIndex = 9;
            this.A1.UseVisualStyleBackColor = false;
            this.A1.Click += new System.EventHandler(this.btn_click);
            // 
            // C3
            // 
            this.C3.BackColor = System.Drawing.Color.White;
            this.C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C3.Location = new System.Drawing.Point(161, 176);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(62, 59);
            this.C3.TabIndex = 10;
            this.C3.UseVisualStyleBackColor = false;
            this.C3.Click += new System.EventHandler(this.btn_click);
            // 
            // B3
            // 
            this.B3.BackColor = System.Drawing.Color.White;
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3.Location = new System.Drawing.Point(161, 111);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(62, 59);
            this.B3.TabIndex = 11;
            this.B3.UseVisualStyleBackColor = false;
            this.B3.Click += new System.EventHandler(this.btn_click);
            // 
            // C2
            // 
            this.C2.BackColor = System.Drawing.Color.White;
            this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C2.Location = new System.Drawing.Point(93, 176);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(62, 59);
            this.C2.TabIndex = 12;
            this.C2.UseVisualStyleBackColor = false;
            this.C2.Click += new System.EventHandler(this.btn_click);
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.Color.White;
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.Location = new System.Drawing.Point(93, 111);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(62, 59);
            this.B2.TabIndex = 13;
            this.B2.UseVisualStyleBackColor = false;
            this.B2.Click += new System.EventHandler(this.btn_click);
            // 
            // C1
            // 
            this.C1.BackColor = System.Drawing.Color.White;
            this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1.Location = new System.Drawing.Point(25, 176);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(62, 59);
            this.C1.TabIndex = 14;
            this.C1.UseVisualStyleBackColor = false;
            this.C1.Click += new System.EventHandler(this.btn_click);
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.Color.White;
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.Location = new System.Drawing.Point(25, 111);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(62, 59);
            this.B1.TabIndex = 15;
            this.B1.UseVisualStyleBackColor = false;
            this.B1.Click += new System.EventHandler(this.btn_click);
            // 
            // A3
            // 
            this.A3.BackColor = System.Drawing.Color.White;
            this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A3.Location = new System.Drawing.Point(161, 45);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(62, 59);
            this.A3.TabIndex = 16;
            this.A3.UseVisualStyleBackColor = false;
            this.A3.Click += new System.EventHandler(this.btn_click);
            // 
            // A2
            // 
            this.A2.BackColor = System.Drawing.Color.White;
            this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2.Location = new System.Drawing.Point(93, 46);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(62, 59);
            this.A2.TabIndex = 17;
            this.A2.UseVisualStyleBackColor = false;
            this.A2.Click += new System.EventHandler(this.btn_click);
            // 
            // GameWindow
            // 
            this.AcceptButton = this.A3;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(469, 296);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.win);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.draws);
            this.Controls.Add(this.o_wins);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.x_wins);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Newgame_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "GameWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.Enter += new System.EventHandler(this.Form1_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Newgame_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label x_wins;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label o_wins;
        private System.Windows.Forms.Label draws;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label win;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button A2;
    }
}

