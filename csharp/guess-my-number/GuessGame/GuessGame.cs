using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessGame
{
    public partial class GuessMyNumber : Form
    {
        Random random = new Random();

        int computerNumber;
        int attempts;
        int totalScore = 0;
        int gamesCount = 0;
        public GuessMyNumber()
        {
            InitializeComponent();
            StartNewGame();

        }
        private void StartNewGame()
        {
            computerNumber = random.Next(1, 101);
            attempts = 0;

            lblMessage.Text = "I have chosen a number between 1 and 100.";
            lblAttempts.Text = "Attempts: 0";
            lblPerformance.Text = "Performance: -";

            txtGuess.Text = "";
            txtGuess.Focus();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            int userGuess;

            if (!int.TryParse(txtGuess.Text, out userGuess))
            {
                MessageBox.Show("Please enter a valid number!", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGuess.Clear();
                txtGuess.Focus();
                return;
            }
            if (userGuess < 1 || userGuess > 100)
            {
                MessageBox.Show("Please enter a number between 1 and 100.", "Out of Range",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGuess.Clear();
                txtGuess.Focus();
                return;
            }

            attempts++;
            //lblAttempts.Text = "Attempts: " + attempts.ToString();
            lblAttempts.Text = string.Format("Attempts: {0}", attempts);

            if (userGuess == computerNumber)
            {
                lblMessage.Text = "Correct! You guessed the number!";
                lblMessage.ForeColor = Color.Green;

                int score = AnalyzePerformance(attempts);
                totalScore += score;
                gamesCount++;
                string winMessage = string.Format("That's correct!\nYou guessed it in {0} attempts.\n\nDo you want to play again?", attempts);

                DialogResult result = MessageBox.Show(
                    winMessage,
                    "You Win!",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information
                );
                if (result == DialogResult.Yes)
                {
                    StartNewGame();
                }
                else
                {
                    ShowComparison();
                    this.Close();
                }
            }
            else if (userGuess < computerNumber)
            {
                lblMessage.Text = "My number is LARGER.";
                lblMessage.ForeColor = Color.Red;
            }
            else
            {
                lblMessage.Text = "My number is LOWER.";
                lblMessage.ForeColor = Color.Orange;
            }

            txtGuess.Clear();
            txtGuess.Focus();
        }


        private int AnalyzePerformance(int attempts)
        {
            if (attempts <= 3)
            {
                lblPerformance.Text = "Performance: Level 4 (Perfect)";
                return 4;
            }
            else if (attempts <= 5)
            {
                lblPerformance.Text = "Performance: Level 3 (Very Good)";
                return 3;
            }
            else if (attempts <= 7)
            {
                lblPerformance.Text = "Performance: Level 2 (Good)";
                return 2;
            }
            else
            {
                lblPerformance.Text = "Performance: Level 1 (Poor)";
                return 1;
            }
        }
        private void ShowComparison()
        {
            if (gamesCount == 0) return;

            int globalScore = random.Next(1, 5);
            int average = totalScore / gamesCount;

            string summary = string.Format("Your Average Score: {0}\nGlobal Performance Level: {1}\n\n", average, globalScore);

            if (average >= globalScore)
                summary += "Good for you!! You were better than the global score!!!";
            else
                summary += "You were worse than the global score.";

            MessageBox.Show(summary, "Game Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            StartNewGame();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ShowComparison();
            Application.Exit();
        }

    }
}


