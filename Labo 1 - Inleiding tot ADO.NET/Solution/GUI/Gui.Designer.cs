namespace GUI
{
    partial class Gui
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
            this.CbPlayer = new System.Windows.Forms.ComboBox();
            this.CbGame = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LbPlayer = new System.Windows.Forms.ListBox();
            this.lbGame = new System.Windows.Forms.ListBox();
            this.lblLbPlayer = new System.Windows.Forms.Label();
            this.lblLbGame = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CbPlayer
            // 
            this.CbPlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbPlayer.FormattingEnabled = true;
            this.CbPlayer.Location = new System.Drawing.Point(12, 29);
            this.CbPlayer.Name = "CbPlayer";
            this.CbPlayer.Size = new System.Drawing.Size(267, 24);
            this.CbPlayer.TabIndex = 0;
            this.CbPlayer.SelectedIndexChanged += new System.EventHandler(this.CbPlayer_SelectedIndexChanged);
            // 
            // CbGame
            // 
            this.CbGame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbGame.FormattingEnabled = true;
            this.CbGame.Location = new System.Drawing.Point(321, 29);
            this.CbGame.Name = "CbGame";
            this.CbGame.Size = new System.Drawing.Size(267, 24);
            this.CbGame.TabIndex = 1;
            this.CbGame.SelectedIndexChanged += new System.EventHandler(this.CbGame_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Player";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Game";
            // 
            // LbPlayer
            // 
            this.LbPlayer.FormattingEnabled = true;
            this.LbPlayer.ItemHeight = 16;
            this.LbPlayer.Location = new System.Drawing.Point(12, 81);
            this.LbPlayer.Name = "LbPlayer";
            this.LbPlayer.Size = new System.Drawing.Size(267, 276);
            this.LbPlayer.TabIndex = 4;
            // 
            // lbGame
            // 
            this.lbGame.FormattingEnabled = true;
            this.lbGame.ItemHeight = 16;
            this.lbGame.Location = new System.Drawing.Point(321, 81);
            this.lbGame.Name = "lbGame";
            this.lbGame.Size = new System.Drawing.Size(267, 276);
            this.lbGame.TabIndex = 5;
            // 
            // lblLbPlayer
            // 
            this.lblLbPlayer.AutoSize = true;
            this.lblLbPlayer.Location = new System.Drawing.Point(12, 61);
            this.lblLbPlayer.Name = "lblLbPlayer";
            this.lblLbPlayer.Size = new System.Drawing.Size(0, 17);
            this.lblLbPlayer.TabIndex = 6;
            // 
            // lblLbGame
            // 
            this.lblLbGame.AutoSize = true;
            this.lblLbGame.Location = new System.Drawing.Point(318, 61);
            this.lblLbGame.Name = "lblLbGame";
            this.lblLbGame.Size = new System.Drawing.Size(0, 17);
            this.lblLbGame.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 378);
            this.Controls.Add(this.lblLbGame);
            this.Controls.Add(this.lblLbPlayer);
            this.Controls.Add(this.lbGame);
            this.Controls.Add(this.LbPlayer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbGame);
            this.Controls.Add(this.CbPlayer);
            this.Name = "Form1";
            this.Text = "C#DB: Labo 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbPlayer;
        private System.Windows.Forms.ComboBox CbGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox LbPlayer;
        private System.Windows.Forms.ListBox lbGame;
        private System.Windows.Forms.Label lblLbPlayer;
        private System.Windows.Forms.Label lblLbGame;
    }
}

