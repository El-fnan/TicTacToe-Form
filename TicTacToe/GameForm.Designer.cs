namespace TicTacToe
{
    partial class GameForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            ply_1 = new Label();
            ply_2 = new Label();
            X = new RadioButton();
            O = new RadioButton();
            choosing = new Panel();
            label1 = new Label();
            ply1Chos = new Label();
            ply2Chos = new Label();
            turn = new Label();
            Rply = new Button();
            summary = new Label();
            turn_panel = new Panel();
            label5 = new Label();
            player1_panel = new Panel();
            ply1_scor = new Label();
            label8 = new Label();
            player2_panel = new Panel();
            ply2_scor = new Label();
            label9 = new Label();
            draws_panel = new Panel();
            label10 = new Label();
            drw_scor = new Label();
            reset = new Button();
            developer = new Label();
            winningTime = new System.Windows.Forms.Timer(components);
            choosing.SuspendLayout();
            turn_panel.SuspendLayout();
            player1_panel.SuspendLayout();
            player2_panel.SuspendLayout();
            draws_panel.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(50, 192, 192);
            button1.CausesValidation = false;
            button1.Cursor = Cursors.Help;
            button1.Enabled = false;
            button1.Font = new Font("Segoe UI Black", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(183, 34);
            button1.Name = "button1";
            button1.Size = new Size(160, 95);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.FromArgb(50, 192, 192);
            button2.Cursor = Cursors.Help;
            button2.Enabled = false;
            button2.Font = new Font("Segoe UI Black", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(342, 34);
            button2.Name = "button2";
            button2.Size = new Size(160, 95);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
            button2.Click += Button_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = Color.FromArgb(50, 192, 192);
            button3.Cursor = Cursors.Help;
            button3.Enabled = false;
            button3.Font = new Font("Segoe UI Black", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(502, 34);
            button3.Name = "button3";
            button3.Size = new Size(160, 95);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = false;
            button3.Click += Button_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.BackColor = Color.FromArgb(50, 192, 192);
            button4.Cursor = Cursors.Help;
            button4.Enabled = false;
            button4.Font = new Font("Segoe UI Black", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(183, 129);
            button4.Name = "button4";
            button4.Size = new Size(160, 95);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = false;
            button4.Click += Button_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.BackColor = Color.FromArgb(50, 192, 192);
            button5.Cursor = Cursors.Help;
            button5.Enabled = false;
            button5.Font = new Font("Segoe UI Black", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(342, 129);
            button5.Name = "button5";
            button5.Size = new Size(160, 95);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = false;
            button5.Click += Button_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.None;
            button6.BackColor = Color.FromArgb(50, 192, 192);
            button6.Cursor = Cursors.Help;
            button6.Enabled = false;
            button6.Font = new Font("Segoe UI Black", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(502, 129);
            button6.Name = "button6";
            button6.Size = new Size(160, 95);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = false;
            button6.Click += Button_Click;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.None;
            button7.BackColor = Color.FromArgb(50, 192, 192);
            button7.Cursor = Cursors.Help;
            button7.Enabled = false;
            button7.Font = new Font("Segoe UI Black", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(183, 224);
            button7.Name = "button7";
            button7.Size = new Size(160, 95);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = false;
            button7.Click += Button_Click;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.None;
            button8.BackColor = Color.FromArgb(50, 192, 192);
            button8.Cursor = Cursors.Help;
            button8.Enabled = false;
            button8.Font = new Font("Segoe UI Black", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(342, 224);
            button8.Name = "button8";
            button8.Size = new Size(160, 95);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = false;
            button8.Click += Button_Click;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.None;
            button9.BackColor = Color.FromArgb(50, 192, 192);
            button9.Cursor = Cursors.Help;
            button9.Enabled = false;
            button9.Font = new Font("Segoe UI Black", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(502, 224);
            button9.Name = "button9";
            button9.Size = new Size(160, 95);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = false;
            button9.Click += Button_Click;
            // 
            // ply_1
            // 
            ply_1.Anchor = AnchorStyles.None;
            ply_1.AutoSize = true;
            ply_1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            ply_1.Location = new Point(205, 335);
            ply_1.Name = "ply_1";
            ply_1.Size = new Size(99, 31);
            ply_1.TabIndex = 9;
            ply_1.Text = "Player 1";
            // 
            // ply_2
            // 
            ply_2.Anchor = AnchorStyles.None;
            ply_2.AutoSize = true;
            ply_2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            ply_2.Location = new Point(538, 335);
            ply_2.Name = "ply_2";
            ply_2.Size = new Size(99, 31);
            ply_2.TabIndex = 10;
            ply_2.Text = "Player 2";
            // 
            // X
            // 
            X.AutoSize = true;
            X.Cursor = Cursors.Hand;
            X.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            X.ForeColor = Color.Red;
            X.Location = new Point(4, 24);
            X.Name = "X";
            X.Size = new Size(50, 35);
            X.TabIndex = 11;
            X.Text = "X";
            X.UseVisualStyleBackColor = true;
            X.Click += ChoosenSymbole_CheckedChanged;
            // 
            // O
            // 
            O.AutoSize = true;
            O.Cursor = Cursors.Hand;
            O.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            O.ForeColor = Color.Blue;
            O.Location = new Point(96, 25);
            O.Name = "O";
            O.Size = new Size(52, 35);
            O.TabIndex = 12;
            O.Text = "O";
            O.UseVisualStyleBackColor = true;
            O.Click += ChoosenSymbole_CheckedChanged;
            // 
            // choosing
            // 
            choosing.Anchor = AnchorStyles.None;
            choosing.Controls.Add(label1);
            choosing.Controls.Add(O);
            choosing.Controls.Add(X);
            choosing.Location = new Point(345, 338);
            choosing.Name = "choosing";
            choosing.Size = new Size(152, 63);
            choosing.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(39, 3);
            label1.Name = "label1";
            label1.Size = new Size(74, 25);
            label1.TabIndex = 13;
            label1.Text = "Choose";
            // 
            // ply1Chos
            // 
            ply1Chos.Anchor = AnchorStyles.None;
            ply1Chos.AutoSize = true;
            ply1Chos.BackColor = Color.FromArgb(200, 255, 255);
            ply1Chos.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            ply1Chos.ForeColor = Color.Red;
            ply1Chos.Location = new Point(237, 370);
            ply1Chos.Name = "ply1Chos";
            ply1Chos.Size = new Size(0, 31);
            ply1Chos.TabIndex = 16;
            // 
            // ply2Chos
            // 
            ply2Chos.Anchor = AnchorStyles.None;
            ply2Chos.AutoSize = true;
            ply2Chos.BackColor = Color.FromArgb(200, 255, 255);
            ply2Chos.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            ply2Chos.ForeColor = Color.Blue;
            ply2Chos.Location = new Point(568, 370);
            ply2Chos.Name = "ply2Chos";
            ply2Chos.Size = new Size(0, 31);
            ply2Chos.TabIndex = 17;
            // 
            // turn
            // 
            turn.AutoSize = true;
            turn.BackColor = Color.White;
            turn.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            turn.ForeColor = Color.Red;
            turn.Location = new Point(90, 48);
            turn.Name = "turn";
            turn.Size = new Size(0, 29);
            turn.TabIndex = 18;
            // 
            // Rply
            // 
            Rply.Anchor = AnchorStyles.None;
            Rply.BackColor = Color.Gold;
            Rply.Cursor = Cursors.Hand;
            Rply.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Rply.ForeColor = Color.FromArgb(255, 255, 192);
            Rply.Location = new Point(324, 405);
            Rply.Name = "Rply";
            Rply.Size = new Size(198, 32);
            Rply.TabIndex = 21;
            Rply.Text = "PLAY AGAIN!";
            Rply.UseVisualStyleBackColor = false;
            Rply.Visible = false;
            Rply.Click += Rply_Click;
            // 
            // summary
            // 
            summary.Anchor = AnchorStyles.None;
            summary.AutoSize = true;
            summary.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            summary.ForeColor = Color.DarkGreen;
            summary.Location = new Point(29, 139);
            summary.Name = "summary";
            summary.Size = new Size(0, 20);
            summary.TabIndex = 24;
            // 
            // turn_panel
            // 
            turn_panel.Anchor = AnchorStyles.None;
            turn_panel.Controls.Add(label5);
            turn_panel.Controls.Add(turn);
            turn_panel.Location = new Point(715, 34);
            turn_panel.Name = "turn_panel";
            turn_panel.Size = new Size(220, 86);
            turn_panel.TabIndex = 25;
            turn_panel.Paint += panelScor_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LightBlue;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(77, 3);
            label5.Name = "label5";
            label5.Size = new Size(62, 31);
            label5.TabIndex = 26;
            label5.Text = "Turn";
            // 
            // player1_panel
            // 
            player1_panel.Anchor = AnchorStyles.None;
            player1_panel.Controls.Add(ply1_scor);
            player1_panel.Controls.Add(label8);
            player1_panel.Location = new Point(715, 129);
            player1_panel.Name = "player1_panel";
            player1_panel.Size = new Size(103, 91);
            player1_panel.TabIndex = 26;
            player1_panel.Paint += panelScor_Paint;
            // 
            // ply1_scor
            // 
            ply1_scor.AutoSize = true;
            ply1_scor.BackColor = Color.White;
            ply1_scor.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            ply1_scor.ForeColor = Color.Red;
            ply1_scor.Location = new Point(40, 58);
            ply1_scor.Name = "ply1_scor";
            ply1_scor.Size = new Size(19, 20);
            ply1_scor.TabIndex = 29;
            ply1_scor.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.LightBlue;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(1, 0);
            label8.Name = "label8";
            label8.Size = new Size(99, 31);
            label8.TabIndex = 26;
            label8.Text = "Player 1";
            // 
            // player2_panel
            // 
            player2_panel.Anchor = AnchorStyles.None;
            player2_panel.Controls.Add(ply2_scor);
            player2_panel.Controls.Add(label9);
            player2_panel.Location = new Point(832, 129);
            player2_panel.Name = "player2_panel";
            player2_panel.Size = new Size(103, 91);
            player2_panel.TabIndex = 27;
            player2_panel.Paint += panelScor_Paint;
            // 
            // ply2_scor
            // 
            ply2_scor.AutoSize = true;
            ply2_scor.BackColor = Color.White;
            ply2_scor.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            ply2_scor.ForeColor = Color.Red;
            ply2_scor.Location = new Point(39, 58);
            ply2_scor.Name = "ply2_scor";
            ply2_scor.Size = new Size(19, 20);
            ply2_scor.TabIndex = 30;
            ply2_scor.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.LightBlue;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(1, 0);
            label9.Name = "label9";
            label9.Size = new Size(99, 31);
            label9.TabIndex = 26;
            label9.Text = "Player 2";
            // 
            // draws_panel
            // 
            draws_panel.Anchor = AnchorStyles.None;
            draws_panel.Controls.Add(label10);
            draws_panel.Controls.Add(drw_scor);
            draws_panel.Location = new Point(715, 229);
            draws_panel.Name = "draws_panel";
            draws_panel.Size = new Size(220, 86);
            draws_panel.TabIndex = 28;
            draws_panel.Paint += panelScor_Paint;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.LightBlue;
            label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(68, 3);
            label10.Name = "label10";
            label10.Size = new Size(80, 31);
            label10.TabIndex = 26;
            label10.Text = "Draws";
            // 
            // drw_scor
            // 
            drw_scor.AutoSize = true;
            drw_scor.BackColor = Color.White;
            drw_scor.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            drw_scor.ForeColor = Color.Red;
            drw_scor.Location = new Point(98, 51);
            drw_scor.Name = "drw_scor";
            drw_scor.Size = new Size(19, 20);
            drw_scor.TabIndex = 18;
            drw_scor.Text = "0";
            // 
            // reset
            // 
            reset.Anchor = AnchorStyles.None;
            reset.BackColor = Color.FromArgb(250, 200, 192);
            reset.Cursor = Cursors.Hand;
            reset.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            reset.ForeColor = Color.Firebrick;
            reset.Location = new Point(715, 341);
            reset.Name = "reset";
            reset.Size = new Size(219, 36);
            reset.TabIndex = 29;
            reset.Text = "Reset Game!";
            reset.UseVisualStyleBackColor = false;
            reset.Click += reset_Click;
            // 
            // developer
            // 
            developer.Anchor = AnchorStyles.None;
            developer.AutoSize = true;
            developer.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            developer.Location = new Point(17, 413);
            developer.Name = "developer";
            developer.Size = new Size(199, 56);
            developer.TabIndex = 30;
            developer.Text = "By Amr Mohammed\r\n\r\n";
            // 
            // winningTime
            // 
            winningTime.Interval = 1000;
            winningTime.Tick += winningTime_Tick;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(200, 255, 255);
            ClientSize = new Size(974, 449);
            Controls.Add(button6);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(developer);
            Controls.Add(button3);
            Controls.Add(reset);
            Controls.Add(button7);
            Controls.Add(draws_panel);
            Controls.Add(button2);
            Controls.Add(player2_panel);
            Controls.Add(button5);
            Controls.Add(player1_panel);
            Controls.Add(button4);
            Controls.Add(turn_panel);
            Controls.Add(button1);
            Controls.Add(summary);
            Controls.Add(Rply);
            Controls.Add(ply2Chos);
            Controls.Add(ply1Chos);
            Controls.Add(choosing);
            Controls.Add(ply_2);
            Controls.Add(ply_1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GameForm";
            Text = "TicTacToe";
            choosing.ResumeLayout(false);
            choosing.PerformLayout();
            turn_panel.ResumeLayout(false);
            turn_panel.PerformLayout();
            player1_panel.ResumeLayout(false);
            player1_panel.PerformLayout();
            player2_panel.ResumeLayout(false);
            player2_panel.PerformLayout();
            draws_panel.ResumeLayout(false);
            draws_panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label ply_1;
        private Label ply_2;
        private RadioButton X;
        private RadioButton O;
        private Panel choosing;
        private Label label1;
        private Label ply1Chos;
        private Label ply2Chos;
        private Label turn;
        private Button Rply;
        private Label summary;
        private Panel turn_panel;
        private Label label5;
        private Panel player1_panel;
        private Label label8;
        private Panel player2_panel;
        private Label label9;
        private Panel draws_panel;
        private Label label10;
        private Label drw_scor;
        private Label ply1_scor;
        private Label ply2_scor;
        private Button reset;
        private Label developer;
        private System.Windows.Forms.Timer winningTime;
    }
}