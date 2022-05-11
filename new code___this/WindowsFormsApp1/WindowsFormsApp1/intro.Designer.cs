
namespace WindowsFormsApp1
{
    partial class Intro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Intro));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RB_2players = new System.Windows.Forms.RadioButton();
            this.RB_1player = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_next = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GrayText;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Tic-Tac-Toe game";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Leelawadee UI Semilight", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 43);
            this.label3.TabIndex = 3;
            this.label3.Text = "Number of Players";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // RB_2players
            // 
            this.RB_2players.AutoSize = true;
            this.RB_2players.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RB_2players.Font = new System.Drawing.Font("Malgun Gothic Semilight", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_2players.Location = new System.Drawing.Point(28, 35);
            this.RB_2players.Name = "RB_2players";
            this.RB_2players.Size = new System.Drawing.Size(108, 29);
            this.RB_2players.TabIndex = 8;
            this.RB_2players.TabStop = true;
            this.RB_2players.Text = "2 players";
            this.RB_2players.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.RB_2players.UseVisualStyleBackColor = true;
            // 
            // RB_1player
            // 
            this.RB_1player.AutoSize = true;
            this.RB_1player.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RB_1player.Font = new System.Drawing.Font("Malgun Gothic Semilight", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_1player.Location = new System.Drawing.Point(28, 0);
            this.RB_1player.Name = "RB_1player";
            this.RB_1player.Size = new System.Drawing.Size(97, 29);
            this.RB_1player.TabIndex = 7;
            this.RB_1player.TabStop = true;
            this.RB_1player.Text = "1 player";
            this.RB_1player.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.RB_1player.UseVisualStyleBackColor = true;
            this.RB_1player.CheckedChanged += new System.EventHandler(this.RB_1player_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RB_1player);
            this.panel2.Controls.Add(this.RB_2players);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(121, 145);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(164, 69);
            this.panel2.TabIndex = 10;
            // 
            // btn_next
            // 
            this.btn_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_next.Location = new System.Drawing.Point(383, 251);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(57, 26);
            this.btn_next.TabIndex = 11;
            this.btn_next.Text = ">>";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // Intro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(473, 300);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Intro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Intro_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton RB_2players;
        private System.Windows.Forms.RadioButton RB_1player;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_next;
    }
}