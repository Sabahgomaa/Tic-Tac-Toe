
namespace WindowsFormsApp1
{
    partial class Info2players
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info2players));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT1 = new System.Windows.Forms.TextBox();
            this.TXT2 = new System.Windows.Forms.TextBox();
            this.BTN_START = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "name player 1 :";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "name player 2 :";
            // 
            // TXT1
            // 
            this.TXT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT1.Location = new System.Drawing.Point(186, 53);
            this.TXT1.Multiline = true;
            this.TXT1.Name = "TXT1";
            this.TXT1.Size = new System.Drawing.Size(243, 23);
            this.TXT1.TabIndex = 2;
            this.TXT1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT1.TextChanged += new System.EventHandler(this.TXT1_TextChanged);
            this.TXT1.Validating += new System.ComponentModel.CancelEventHandler(this.TXT1_Validating);
            // 
            // TXT2
            // 
            this.TXT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT2.Location = new System.Drawing.Point(186, 121);
            this.TXT2.Multiline = true;
            this.TXT2.Name = "TXT2";
            this.TXT2.Size = new System.Drawing.Size(243, 23);
            this.TXT2.TabIndex = 3;
            this.TXT2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT2.TextChanged += new System.EventHandler(this.TXT2_TextChanged);
            this.TXT2.Validating += new System.ComponentModel.CancelEventHandler(this.TXT2_Validating);
            // 
            // BTN_START
            // 
            this.BTN_START.BackColor = System.Drawing.SystemColors.GrayText;
            this.BTN_START.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_START.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_START.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_START.ForeColor = System.Drawing.Color.Black;
            this.BTN_START.Location = new System.Drawing.Point(169, 194);
            this.BTN_START.Name = "BTN_START";
            this.BTN_START.Size = new System.Drawing.Size(105, 42);
            this.BTN_START.TabIndex = 4;
            this.BTN_START.Text = "Start Game";
            this.BTN_START.UseVisualStyleBackColor = false;
            this.BTN_START.Click += new System.EventHandler(this.BTN_START_Click);
            // 
            // btn_back
            // 
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_back.Location = new System.Drawing.Point(25, 266);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(50, 22);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "<<";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.button1_Click);
            // 
            // Info2players
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(473, 300);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.BTN_START);
            this.Controls.Add(this.TXT2);
            this.Controls.Add(this.TXT1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Info2players";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Info2players_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT1;
        private System.Windows.Forms.TextBox TXT2;
        private System.Windows.Forms.Button BTN_START;
        private System.Windows.Forms.Button btn_back;
    }
}