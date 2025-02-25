using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace TicTacToe
{
    internal class GameLogic
    {
        public string Player1Symbol { get; private set; } = "";
        public string Player2Symbol { get; private set; } = "";
        public string CurrentPlayer { get; private set; } = "";
        public string Winner { get; private set; } = "";
        public string Loser { get; private set; } = "";

        public int Player1Score { get; private set; } = 0;
        public int Player2Score { get; private set; } = 0;
        public int DrawsScore { get; set; } = 0;

        public List<Button> WinningButtons { get; private set; } = new List<Button>();

        private int[,] winPatterns = new int[,]
        {
            {0, 1, 2}, {3, 4, 5}, {6, 7, 8}, // Rows
            {0, 3, 6}, {1, 4, 7}, {2, 5, 8}, // Columns
            {0, 4, 8}, {2, 4, 6}            // Diagonals
        };

        public void SetPlayers(string player1, string player2)
        {
            Player1Symbol = player1;
            Player2Symbol = player2;
            CurrentPlayer = Player1Symbol;
        }

        public void SwitchTurn()
        {
            CurrentPlayer = (CurrentPlayer == Player1Symbol) ? Player2Symbol : Player1Symbol;
        }

        public bool CheckWinner(List<Button> buttons)
        {
            for (int i = 0; i < winPatterns.GetLength(0); i++)
            {
                int a = winPatterns[i, 0], b = winPatterns[i, 1], c = winPatterns[i, 2];

                if (buttons[a].Text != "" && buttons[a].Text == buttons[b].Text && buttons[a].Text == buttons[c].Text)
                {
                    WinningButtons.Add(buttons[a]);
                    WinningButtons.Add(buttons[b]);
                    WinningButtons.Add(buttons[c]);

                    if (CurrentPlayer==Player1Symbol)
                    {
                        Player1Score++;

                        Winner = "Player 1";
                        Loser = "Player 2";
                    }
                    else
                    {
                        Player2Score++;

                        Winner = "Player 2";
                        Loser = "Player 1";
                    }

                    return true;
                }
            }
            return false;
        }

        public bool IsDraw(List<Button> buttons)
        {
            return buttons.All(btn => btn.Text != "");
        }

        public void ResetBoard(List<Button> buttons)
        {
            WinningButtons.Clear();
            buttons.ForEach(btn =>
            {
                btn.Text = "";
                btn.BackColor = Color.FromArgb(50, 192, 192);
                btn.Enabled = false;
            });

            Winner = "";
            Loser = "";
        }

        public void ResetGame()
        {
            Player1Score = 0;
            Player2Score = 0;
            DrawsScore = 0;

            Winner = "";
            Loser = "";
        }
    }
}
