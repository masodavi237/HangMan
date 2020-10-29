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
    public partial class Form1 : Form
    {
        Random Generator = new Random();
        List<string> words = new List<string>();
        string hiddenWord;
        string guess;
        int incorrect;
        int randomForIndex;
        int indexLength;
        int indexOfLetter;
        bool contains;
        bool sameLetter;
        char check;



         
        

        public Form1()
        {
            InitializeComponent();
        }

        private void btmGuess_Click(object sender, EventArgs e)
        {
            guess = (txtGuess.Text).ToUpper();
            contains = hiddenWord.Contains(guess);
            
            if (guess.Length == 1)
            {
                if (contains)
                {
                    lblError.Text = "Does contain";
                    for (int i = 0; i < hiddenWord.Length; i++)
                    {
                        check = hiddenWord[i];
                        sameLetter = guess.Contains(check);
                        if (sameLetter)
                        {
                            
                            indexOfLetter = i;
                            hiddenWord = hiddenWord.Remove(i, 1);
                            hiddenWord = hiddenWord.Insert(i - 1, "0");
                            lblWord.Text = lblWord.Text.Remove((i * 2) + 1, 1);
                            lblWord.Text =  lblWord.Text.Insert((i * 2) - 1, guess);
                            lblError.Text = hiddenWord;

                        }
                    }

                }

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
            
            indexLength = words.Count;
            randomForIndex = Generator.Next(0, indexLength + 1);
            
            if (indexLength != 0)
            {
                hiddenWord = words[randomForIndex];
                lblWord.Text = "";

                for (int i = 0; i < hiddenWord.Length; i ++)
                {
                    lblWord.Text = String.Concat(lblWord.Text, "_ ");
                    lblError.Text = hiddenWord;
                }

                
                
            }
            
            else
            {
                lblError.Text = "File does not exist or does not contain sufficent data";
            }
            
            
            

            
        }
    }
}

