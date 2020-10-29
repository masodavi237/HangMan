namespace HangMan
{
    partial class Form1
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbxBlood = new System.Windows.Forms.PictureBox();
            this.lblWins = new System.Windows.Forms.Label();
            this.lblLosses = new System.Windows.Forms.Label();
            this.lblWinsDisp = new System.Windows.Forms.Label();
            this.lblLossesDisp = new System.Windows.Forms.Label();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.btmGuess = new System.Windows.Forms.Button();
            this.lblWord = new System.Windows.Forms.Label();
            this.ofdWords = new System.Windows.Forms.OpenFileDialog();
            this.lblError = new System.Windows.Forms.Label();
            this.lblTest = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lstUsedLetters = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBlood)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Dutch801 XBd BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(13, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(516, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Welcome - Can You Beat the Hang-Man?";
            // 
            // pbxBlood
            // 
            this.pbxBlood.Image = global::HangMan.Properties.Resources.Blood;
            this.pbxBlood.Location = new System.Drawing.Point(19, 39);
            this.pbxBlood.Name = "pbxBlood";
            this.pbxBlood.Size = new System.Drawing.Size(498, 103);
            this.pbxBlood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBlood.TabIndex = 1;
            this.pbxBlood.TabStop = false;
            // 
            // lblWins
            // 
            this.lblWins.AutoSize = true;
            this.lblWins.Font = new System.Drawing.Font("ISOCTEUR", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWins.Location = new System.Drawing.Point(610, 36);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(69, 19);
            this.lblWins.TabIndex = 2;
            this.lblWins.Text = "Wins:";
            // 
            // lblLosses
            // 
            this.lblLosses.AutoSize = true;
            this.lblLosses.Font = new System.Drawing.Font("ISOCTEUR", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLosses.Location = new System.Drawing.Point(586, 61);
            this.lblLosses.Name = "lblLosses";
            this.lblLosses.Size = new System.Drawing.Size(93, 19);
            this.lblLosses.TabIndex = 3;
            this.lblLosses.Text = "Losses:";
            // 
            // lblWinsDisp
            // 
            this.lblWinsDisp.AutoSize = true;
            this.lblWinsDisp.Font = new System.Drawing.Font("ISOCTEUR", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinsDisp.Location = new System.Drawing.Point(697, 36);
            this.lblWinsDisp.Name = "lblWinsDisp";
            this.lblWinsDisp.Size = new System.Drawing.Size(0, 19);
            this.lblWinsDisp.TabIndex = 4;
            // 
            // lblLossesDisp
            // 
            this.lblLossesDisp.AutoSize = true;
            this.lblLossesDisp.Font = new System.Drawing.Font("ISOCTEUR", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLossesDisp.Location = new System.Drawing.Point(697, 61);
            this.lblLossesDisp.Name = "lblLossesDisp";
            this.lblLossesDisp.Size = new System.Drawing.Size(0, 19);
            this.lblLossesDisp.TabIndex = 5;
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(19, 200);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(100, 20);
            this.txtGuess.TabIndex = 6;
            // 
            // btmGuess
            // 
            this.btmGuess.Location = new System.Drawing.Point(146, 200);
            this.btmGuess.Name = "btmGuess";
            this.btmGuess.Size = new System.Drawing.Size(75, 20);
            this.btmGuess.TabIndex = 7;
            this.btmGuess.Text = "Guess";
            this.btmGuess.UseVisualStyleBackColor = true;
            this.btmGuess.Click += new System.EventHandler(this.btmGuess_Click);
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Font = new System.Drawing.Font("ISOCTEUR", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.Location = new System.Drawing.Point(12, 356);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(425, 46);
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
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(590, 433);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 9;
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(554, 274);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(0, 13);
            this.lblTest.TabIndex = 10;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(227, 200);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 20);
            this.btnOpen.TabIndex = 11;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(308, 200);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 20);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "New Word";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lstUsedLetters
            // 
            this.lstUsedLetters.FormattingEnabled = true;
            this.lstUsedLetters.Location = new System.Drawing.Point(590, 149);
            this.lstUsedLetters.Name = "lstUsedLetters";
            this.lstUsedLetters.Size = new System.Drawing.Size(165, 199);
            this.lstUsedLetters.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstUsedLetters);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.lblTest);
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
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lstUsedLetters;
    }
}

