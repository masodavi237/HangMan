using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangMan
{
    public partial class HangMan : Form
    {
        Random Generator = new Random();
        List<string> words = new List<string>();
        string hiddenWord;
        string guess;
        string copyHiddenWord;
        int wins;
        int losses;
        int incorrect;
        int randomForIndex;
        int indexLength;
        int indexOfList;
        int correctGuessed;
        bool contains;
        bool sameLetter;
        bool wordChosen;
        bool diffSet;
        bool easy;
        bool normal;
        bool hard;
        char check;
        List<Image> hangmans;



         
        

        public HangMan()
        {
            InitializeComponent();
            
        }

        private void btmGuess_Click(object sender, EventArgs e)
        {
            if (wordChosen && diffSet)
            {
                guess = (txtGuess.Text).ToUpper();
                contains = hiddenWord.Contains(guess);
                indexOfList = lstUsedLetters.FindString(guess);
                

                if (guess.Length == 1)
                {
                    if (indexOfList == -1)
                    {
                        if (contains)
                        {
                            for (int i = 0; i < hiddenWord.Length; i++)
                            {
                                check = hiddenWord[i];
                                sameLetter = guess.Contains(check);
                                if (sameLetter)
                                {

                                    
                                    if (indexOfList == -1)
                                    {
                                        
                                        lstUsedLetters.Items.Add(guess);
                                        indexOfList = lstUsedLetters.FindString(guess);
                                        
                                    }
                                    hiddenWord = hiddenWord.Remove(i, 1);
                                    hiddenWord = hiddenWord.Insert(i, "0");
                                    lblWord.Text = lblWord.Text.Remove((i * 2), 1);
                                    lblWord.Text = lblWord.Text.Insert((i * 2), guess);
                                    
                                    correctGuessed += 1;

                                    if (correctGuessed == hiddenWord.Length)
                                    {
                                        wins += 1;
                                        lblWinsDisp.Text = wins + "";
                                        wordChosen = false;
                                        lblEndGame.Text = "YOU WIN";
                                    }
                                }
                            }
                        }

                        else
                        {
                            incorrect = incorrect + 1;
                            lstUsedLetters.Items.Add(guess);
                            pbxHangDisplay.Image = hangmans[incorrect];

                            if (incorrect >= 10)
                            {
                                losses += 1;
                                lblLossesDisp.Text = losses + "";
                                wordChosen = false;
                                lblEndGame.Text = "YOU LOSE" + ($" The word was {copyHiddenWord}");
                                
                                

                            }
                        }
                    }
                    
                }
                
            }
            else
            {
                lblError.Text = "Please click 'New Word' and set difficulty";
            }

           

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            words.Clear();
            if (ofdWords.ShowDialog() == DialogResult.OK)
            {
                foreach (string line in File.ReadLines(ofdWords.FileName, Encoding.UTF8))
                {
                    words.Add(line.ToUpper());
                    lblError.Text = "";

                }

            }
            else
            {
                lblError.Text = "Please open a word bank file";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            correctGuessed = 0;
            indexLength = words.Count;
            randomForIndex = Generator.Next(0, indexLength);
            lstUsedLetters.Items.Clear();
            lblEndGame.Text = "";
            lblError.Text = "";

            if (easy)
            {
                incorrect = 0;
                pbxHangDisplay.Image = hangmans[incorrect];
            }
            else if (normal)
            {
                incorrect = 2;
                pbxHangDisplay.Image = hangmans[incorrect];
            }
            else if (hard)
            {
                incorrect = 5;
                pbxHangDisplay.Image = hangmans[incorrect];
            }
           

            
            if (indexLength != 0 && diffSet)
            {
                hiddenWord = words[randomForIndex];
                copyHiddenWord = hiddenWord;
                lblWord.Text = "";

                for (int i = 0; i < hiddenWord.Length; i ++)
                {
                    lblWord.Text = String.Concat(lblWord.Text, "_ ");
                    /*lblError.Text = hiddenWord;*/
                }

                wordChosen = true;
                
                
            }
            else if (!diffSet)
            {
                lblError.Text = "Please select a difficulty";
            }
            
            else
            {
                lblError.Text = "File does not exist or does not contain sufficent data";
            }
            
            
            

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hangmans = new List<Image>();
            hangmans.Add(global::HangMan.Properties.Resources._0);
            hangmans.Add(global::HangMan.Properties.Resources._1);
            hangmans.Add(global::HangMan.Properties.Resources._2);
            hangmans.Add(global::HangMan.Properties.Resources._3);
            hangmans.Add(global::HangMan.Properties.Resources._4);
            hangmans.Add(global::HangMan.Properties.Resources._5);
            hangmans.Add(global::HangMan.Properties.Resources._6);
            hangmans.Add(global::HangMan.Properties.Resources._7);
            hangmans.Add(global::HangMan.Properties.Resources._8);
            hangmans.Add(global::HangMan.Properties.Resources._9);
            hangmans.Add(global::HangMan.Properties.Resources._10);

            incorrect = 0;
            pbxHangDisplay.Image = global::HangMan.Properties.Resources._0;

        }

        private void rdbEasy_CheckedChanged(object sender, EventArgs e)
        {
            diffSet = true;
            easy = true;
            normal = false;
            hard = false;
        }

        private void rdbNormal_CheckedChanged(object sender, EventArgs e)
        {
            diffSet = true;
            normal = true;
            easy = false;
            hard = false;
        }

        private void rdbHard_CheckedChanged(object sender, EventArgs e)
        {
            diffSet = true;
            hard = true;
            easy = false;
            normal = false;
        }

        private void lstUsedLetters_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblLosses_Click(object sender, EventArgs e)
        {

        }
    }
}

