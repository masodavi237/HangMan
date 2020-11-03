namespace HangMan
{
    partial class HangMan
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HangMan));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblWins = new System.Windows.Forms.Label();
            this.lblLosses = new System.Windows.Forms.Label();
            this.lblWinsDisp = new System.Windows.Forms.Label();
            this.lblLossesDisp = new System.Windows.Forms.Label();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.btmGuess = new System.Windows.Forms.Button();
            this.lblWord = new System.Windows.Forms.Label();
            this.ofdWords = new System.Windows.Forms.OpenFileDialog();
            this.lblError = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lstUsedLetters = new System.Windows.Forms.ListBox();
            this.imlHangDisplay = new System.Windows.Forms.ImageList(this.components);
            this.pbxHangDisplay = new System.Windows.Forms.PictureBox();
            this.pbxBlood = new System.Windows.Forms.PictureBox();
            this.rdbEasy = new System.Windows.Forms.RadioButton();
            this.rdbNormal = new System.Windows.Forms.RadioButton();
            this.rdbHard = new System.Windows.Forms.RadioButton();
            this.lblEndGame = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHangDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBlood)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(21, 22);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1163, 69);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Welcome - Can You Beat the Hang-Man?";
            // 
            // lblWins
            // 
            this.lblWins.AutoSize = true;
            this.lblWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWins.Location = new System.Drawing.Point(1315, 15);
            this.lblWins.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(185, 69);
            this.lblWins.TabIndex = 2;
            this.lblWins.Text = "Wins:";
            // 
            // lblLosses
            // 
            this.lblLosses.AutoSize = true;
            this.lblLosses.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLosses.Location = new System.Drawing.Point(1315, 75);
            this.lblLosses.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblLosses.Name = "lblLosses";
            this.lblLosses.Size = new System.Drawing.Size(243, 69);
            this.lblLosses.TabIndex = 3;
            this.lblLosses.Text = "Losses:";
            this.lblLosses.Click += new System.EventHandler(this.lblLosses_Click);
            // 
            // lblWinsDisp
            // 
            this.lblWinsDisp.AutoSize = true;
            this.lblWinsDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinsDisp.Location = new System.Drawing.Point(1606, 15);
            this.lblWinsDisp.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblWinsDisp.Name = "lblWinsDisp";
            this.lblWinsDisp.Size = new System.Drawing.Size(0, 69);
            this.lblWinsDisp.TabIndex = 4;
            // 
            // lblLossesDisp
            // 
            this.lblLossesDisp.AutoSize = true;
            this.lblLossesDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLossesDisp.Location = new System.Drawing.Point(1606, 75);
            this.lblLossesDisp.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblLossesDisp.Name = "lblLossesDisp";
            this.lblLossesDisp.Size = new System.Drawing.Size(0, 69);
            this.lblLossesDisp.TabIndex = 5;
            // 
            // txtGuess
            // 
            this.txtGuess.BackColor = System.Drawing.Color.PowderBlue;
            this.txtGuess.Location = new System.Drawing.Point(31, 338);
            this.txtGuess.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(164, 28);
            this.txtGuess.TabIndex = 6;
            // 
            // btmGuess
            // 
            this.btmGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmGuess.Location = new System.Drawing.Point(244, 338);
            this.btmGuess.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btmGuess.Name = "btmGuess";
            this.btmGuess.Size = new System.Drawing.Size(125, 34);
            this.btmGuess.TabIndex = 7;
            this.btmGuess.Text = "Guess";
            this.btmGuess.UseVisualStyleBackColor = true;
            this.btmGuess.Click += new System.EventHandler(this.btmGuess_Click);
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.Location = new System.Drawing.Point(13, 687);
            this.lblWord.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(553, 91);
            this.lblWord.TabIndex = 8;
            this.lblWord.Text = "_ _ _ _ _ _ _ _";
            // 
            // ofdWords
            // 
            this.ofdWords.FileName = "openFileDialog1";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(28, 372);
            this.lblError.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 25);
            this.lblError.TabIndex = 9;
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(379, 338);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(125, 34);
            this.btnOpen.TabIndex = 11;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(514, 338);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 34);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "New Word";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lstUsedLetters
            // 
            this.lstUsedLetters.BackColor = System.Drawing.Color.PowderBlue;
            this.lstUsedLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstUsedLetters.ForeColor = System.Drawing.Color.OrangeRed;
            this.lstUsedLetters.FormattingEnabled = true;
            this.lstUsedLetters.ItemHeight = 69;
            this.lstUsedLetters.Location = new System.Drawing.Point(1632, 153);
            this.lstUsedLetters.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lstUsedLetters.Name = "lstUsedLetters";
            this.lstUsedLetters.Size = new System.Drawing.Size(145, 625);
            this.lstUsedLetters.TabIndex = 14;
            this.lstUsedLetters.SelectedIndexChanged += new System.EventHandler(this.lstUsedLetters_SelectedIndexChanged);
            // 
            // imlHangDisplay
            // 
            this.imlHangDisplay.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlHangDisplay.ImageStream")));
            this.imlHangDisplay.TransparentColor = System.Drawing.Color.Transparent;
            this.imlHangDisplay.Images.SetKeyName(0, "0.jpg");
            this.imlHangDisplay.Images.SetKeyName(1, "1.jpg");
            this.imlHangDisplay.Images.SetKeyName(2, "2.jpg");
            this.imlHangDisplay.Images.SetKeyName(3, "3.jpg");
            this.imlHangDisplay.Images.SetKeyName(4, "4.jpg");
            this.imlHangDisplay.Images.SetKeyName(5, "5.jpg");
            this.imlHangDisplay.Images.SetKeyName(6, "6.jpg");
            this.imlHangDisplay.Images.SetKeyName(7, "7.jpg");
            this.imlHangDisplay.Images.SetKeyName(8, "8.jpg");
            this.imlHangDisplay.Images.SetKeyName(9, "9.jpg");
            this.imlHangDisplay.Images.SetKeyName(10, "10.jpg");
            // 
            // pbxHangDisplay
            // 
            this.pbxHangDisplay.Location = new System.Drawing.Point(1202, 153);
            this.pbxHangDisplay.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pbxHangDisplay.Name = "pbxHangDisplay";
            this.pbxHangDisplay.Size = new System.Drawing.Size(420, 625);
            this.pbxHangDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxHangDisplay.TabIndex = 15;
            this.pbxHangDisplay.TabStop = false;
            // 
            // pbxBlood
            // 
            this.pbxBlood.Image = global::HangMan.Properties.Resources.Blood_removebg_preview;
            this.pbxBlood.Location = new System.Drawing.Point(36, 65);
            this.pbxBlood.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pbxBlood.Name = "pbxBlood";
            this.pbxBlood.Size = new System.Drawing.Size(924, 143);
            this.pbxBlood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBlood.TabIndex = 1;
            this.pbxBlood.TabStop = false;
            // 
            // rdbEasy
            // 
            this.rdbEasy.AutoSize = true;
            this.rdbEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEasy.Location = new System.Drawing.Point(649, 341);
            this.rdbEasy.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.rdbEasy.Name = "rdbEasy";
            this.rdbEasy.Size = new System.Drawing.Size(77, 29);
            this.rdbEasy.TabIndex = 16;
            this.rdbEasy.TabStop = true;
            this.rdbEasy.Text = "Easy";
            this.rdbEasy.UseVisualStyleBackColor = true;
            this.rdbEasy.CheckedChanged += new System.EventHandler(this.rdbEasy_CheckedChanged);
            // 
            // rdbNormal
            // 
            this.rdbNormal.AutoSize = true;
            this.rdbNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNormal.Location = new System.Drawing.Point(736, 343);
            this.rdbNormal.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.rdbNormal.Name = "rdbNormal";
            this.rdbNormal.Size = new System.Drawing.Size(95, 29);
            this.rdbNormal.TabIndex = 17;
            this.rdbNormal.TabStop = true;
            this.rdbNormal.Text = "Normal";
            this.rdbNormal.UseVisualStyleBackColor = true;
            this.rdbNormal.CheckedChanged += new System.EventHandler(this.rdbNormal_CheckedChanged);
            // 
            // rdbHard
            // 
            this.rdbHard.AutoSize = true;
            this.rdbHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbHard.Location = new System.Drawing.Point(841, 343);
            this.rdbHard.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.rdbHard.Name = "rdbHard";
            this.rdbHard.Size = new System.Drawing.Size(75, 29);
            this.rdbHard.TabIndex = 18;
            this.rdbHard.TabStop = true;
            this.rdbHard.Text = "Hard";
            this.rdbHard.UseVisualStyleBackColor = true;
            this.rdbHard.CheckedChanged += new System.EventHandler(this.rdbHard_CheckedChanged);
            // 
            // lblEndGame
            // 
            this.lblEndGame.AutoSize = true;
            this.lblEndGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndGame.Location = new System.Drawing.Point(17, 596);
            this.lblEndGame.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEndGame.Name = "lblEndGame";
            this.lblEndGame.Size = new System.Drawing.Size(0, 91);
            this.lblEndGame.TabIndex = 19;
            // 
            // HangMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1790, 793);
            this.Controls.Add(this.lblEndGame);
            this.Controls.Add(this.rdbHard);
            this.Controls.Add(this.rdbNormal);
            this.Controls.Add(this.rdbEasy);
            this.Controls.Add(this.pbxHangDisplay);
            this.Controls.Add(this.lstUsedLetters);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.btmGuess);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.lblLossesDisp);
            this.Controls.Add(this.lblWinsDisp);
            this.Controls.Add(this.lblLosses);
            this.Controls.Add(this.lblWins);
            this.Controls.Add(this.pbxBlood);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "HangMan";
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxHangDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBlood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbxBlood;
        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.Label lblLosses;
        private System.Windows.Forms.Label lblWinsDisp;
        private System.Windows.Forms.Label lblLossesDisp;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Button btmGuess;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.OpenFileDialog ofdWords;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lstUsedLetters;
        private System.Windows.Forms.PictureBox pbxHangDisplay;
        private System.Windows.Forms.ImageList imlHangDisplay;
        private System.Windows.Forms.RadioButton rdbEasy;
        private System.Windows.Forms.RadioButton rdbNormal;
        private System.Windows.Forms.RadioButton rdbHard;
        private System.Windows.Forms.Label lblEndGame;
    }
}

