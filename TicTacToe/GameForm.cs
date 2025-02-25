using System.Media;
using System.Reflection;

namespace TicTacToe
{
    public partial class GameForm : Form
    {
        private GameLogic game;
        private List<Button> buttons = new List<Button>();
        private int highlightIndex = 0;
        public GameForm()
        {
            InitializeComponent();
            game=new GameLogic();
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
        }

        private void panelScor_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int halfHeight = turn_panel.Height / 2;

            g.FillRectangle(Brushes.LightBlue, 0, 0, turn_panel.Width, halfHeight);

            g.FillRectangle(Brushes.White, 0, halfHeight, turn_panel.Width, halfHeight);

            g.DrawLine(Pens.Black, 0, halfHeight, turn_panel.Width, halfHeight);
        }

        private void ChoosenSymbole_CheckedChanged(object sender, EventArgs e)
        {
            if (X.Checked)
            {
                game.SetPlayers("X", "O");
            }
            else if (O.Checked)
            {
                game.SetPlayers("O", "X");
            }

            ply1Chos.Text = game.Player1Symbol;
            ply2Chos.Text = game.Player2Symbol;
            choosing.Visible = false;

            buttons.ForEach(btn => btn.Enabled=true);

            turn.Text = game.CurrentPlayer;
        }

        private void Retry()
        {
            X.Checked = false;
            O.Checked = false;

            highlightIndex=0;
            game.ResetBoard(buttons);
            winningTime.Stop();

            ply1Chos.Text = "";
            ply2Chos.Text = "";
            turn.Text = "";
            summary.Text = "";

            choosing.Visible = true;
            reset.Enabled = true;
            Rply.Visible = false;
        }

        private void Rply_Click(object sender, EventArgs e)
        {
            Retry();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to reset the game?",
                                      "Reset Game",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Retry();
                ply1_scor.Text="0";
                ply2_scor.Text="0";
                drw_scor.Text="0";
            }
        }
        private void winningTime_Tick(object sender, EventArgs e)
        {
            if (highlightIndex < game.WinningButtons.Count)
            {
                game.WinningButtons[highlightIndex].BackColor = Color.LightGreen;
                highlightIndex++;
            }
            else
            {
                winningTime.Stop();
                MessageBox.Show($"\U0001F973 Congrats! \"{game.Winner}\" wins! \U0001F973\n\n\U0001F622 Sorry \"{game.Loser}\", you lost!", "Game Over!");
                summary.Text = game.Winner + ": winner \U0001F60F\n\n  \n\n" + game.Loser + ": Loser \U0001F612";

                if (game.CurrentPlayer == game.Player1Symbol)
                {
                    ply1Chos.Text="\U0001F60F";
                    ply2Chos.Text="\U0001F612";
                    ply1_scor.Text = game.Player1Score.ToString();
                }
                else
                {
                    ply2Chos.Text="\U0001F60F";
                    ply1Chos.Text="\U0001F612";
                    ply2_scor.Text = game.Player2Score.ToString();
                }

                Rply.Visible = true;
                reset.Enabled=true;
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Text = game.CurrentPlayer;
            btn.Enabled = false;
            turn.Text = (game.CurrentPlayer==game.Player1Symbol) ? game.Player2Symbol : game.Player1Symbol;

            if (game.CheckWinner(buttons))
            {
                reset.Enabled=false;
                winningTime.Interval = 250;
                winningTime.Start();
                turn.Text = "";
                buttons.ForEach(button => button.Enabled=false);
                return;
            }
            if (game.IsDraw(buttons))
            {
                game.DrawsScore++;
                drw_scor.Text = game.DrawsScore.ToString();
                MessageBox.Show("\U0001F91D It's a Draw!", "Game Over!");
                Rply.Visible = true;
            }

            game.SwitchTurn();
        }
    }
}