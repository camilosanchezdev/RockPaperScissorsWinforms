using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            screenPc.Image = rps;
            screenPlayer.Image = rps;
        }
        //Images
        Image rock = Image.FromFile("C:\\Users\\camil\\source\\repos\\RockPaperScissors\\RockPaperScissors\\Resources\\rock.png");
        Image paper = Image.FromFile("C:\\Users\\camil\\source\\repos\\RockPaperScissors\\RockPaperScissors\\Resources\\paper.png");
        Image scissors = Image.FromFile("C:\\Users\\camil\\source\\repos\\RockPaperScissors\\RockPaperScissors\\Resources\\scissors.png");
        Image rps = Image.FromFile("C:\\Users\\camil\\source\\repos\\RockPaperScissors\\RockPaperScissors\\Resources\\rps.png");

        Random rnd = new Random();
        int pcChoiceVariable = 0;
        public void PcChoice()
        {
            pcChoiceVariable = rnd.Next(1, 4);
            switch (pcChoiceVariable)
            {
                case 1:
                    screenPc.Image = rock;
                    break;
                case 2:
                    screenPc.Image = paper;
                    break;
                case 3:
                    screenPc.Image = scissors;
                    break;
            }
        }
        int playerWins = 0;
        int pcWins = 0;
        int game = 0;
        bool winner;
        int playerGames = 0;
        int pcGames = 0;
        
        public void SistemaJuego()
        {
            if (screenPlayer.Image == rock && screenPc.Image == scissors)
            {
                playerWins++;
                game++;
                winner = true;
                label13.Text = "";
            }
            if (screenPlayer.Image == paper && screenPc.Image == rock)
            {
                playerWins++;
                game++;
                winner = true;
                label13.Text = "";
            }
            if (screenPlayer.Image == scissors && screenPc.Image == paper)
            {
                playerWins++;
                game++;
                winner = true;
                label13.Text = "";
            }
            if (screenPc.Image == rock && screenPlayer.Image == scissors)
            {
                pcWins++;
                game++;
                winner = false;
                label13.Text = "";
            }
            if (screenPc.Image == paper && screenPlayer.Image == rock)
            {
                pcWins++;
                game++;
                winner = false;
                label13.Text = "";
            }
            if (screenPc.Image == scissors && screenPlayer.Image == paper)
            {
                pcWins++;
                game++;
                winner = false;
                label13.Text = "";
            }
            if (screenPc.Image == screenPlayer.Image)
            {
                label13.Text = "Tie!";
            }
        }
        public void Resultados()
        {
            if (game == 1)
            {
                if (winner)
                {
                    round1Result.Text = "Player";
                }
                else
                    round1Result.Text = "PC";
            }
            if (game == 2)
            {
                if (winner)
                {
                    round2Result.Text = "Player";
                }
                else
                    round2Result.Text = "PC";
                // 2 of 3
                if (pcWins == 2)
                {
                    rockButton.Enabled = false;
                    paperButton.Enabled = false;
                    scissorsButton.Enabled = false;
                    label13.Text = "PC Wins";
                    playAgainButton.Enabled = true;
                }
                if (playerWins == 2)
                {
                    rockButton.Enabled = false;
                    paperButton.Enabled = false;
                    scissorsButton.Enabled = false;
                    label13.Text = "Player Wins";
                    playAgainButton.Enabled = true;
                }
            }
            if (game == 3)
            {
                if (winner)
                {
                    round3Result.Text = "Player";
                }
                else
                {
                    round3Result.Text = "PC";
                }
                if (playerWins > pcWins)
                {
                    label13.Text = "Player Wins";
                }
                if (pcWins > playerWins)
                {
                    label13.Text = "PC Wins";
                }
                rockButton.Enabled = false;
                paperButton.Enabled = false;
                scissorsButton.Enabled = false;
                playAgainButton.Enabled = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            screenPlayer.Image = rock;
            PcChoice();
            SistemaJuego();
            Resultados();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            screenPlayer.Image = paper;
            PcChoice();
            SistemaJuego();
            Resultados();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            screenPlayer.Image = scissors;
            PcChoice();
            SistemaJuego();
            Resultados();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            rockButton.Enabled = true;
            paperButton.Enabled = true;
            scissorsButton.Enabled = true;
            round1Result.Text = "...";
            round2Result.Text = "...";
            round3Result.Text = "...";
            if (playerWins > pcWins)
            {
                playerGames++;
                playerScore.Text = playerGames.ToString();
            }
            if (pcWins > playerWins)
            {
                pcGames++;
                pcScore.Text = pcGames.ToString();
            }
            pcWins = 0;
            playerWins = 0;
            game = 0;
            screenPc.Image = rps;
            screenPlayer.Image = rps;
            label13.Text = "";
            playAgainButton.Enabled = false;
        }
    }
}
