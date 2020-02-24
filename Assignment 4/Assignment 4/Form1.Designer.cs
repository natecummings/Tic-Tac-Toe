namespace Assignment_4
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
            this.topLeftLabel = new System.Windows.Forms.Label();
            this.topMidLabel = new System.Windows.Forms.Label();
            this.topRightLabel = new System.Windows.Forms.Label();
            this.midLeftLabel = new System.Windows.Forms.Label();
            this.midMidLabel = new System.Windows.Forms.Label();
            this.midRightLabel = new System.Windows.Forms.Label();
            this.bottomLeftLabel = new System.Windows.Forms.Label();
            this.bottomMidLabel = new System.Windows.Forms.Label();
            this.bottomRightLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.statisticsBox = new System.Windows.Forms.GroupBox();
            this.numTies = new System.Windows.Forms.Label();
            this.playerTwoWins = new System.Windows.Forms.Label();
            this.playerOneWins = new System.Windows.Forms.Label();
            this.tieLabel = new System.Windows.Forms.Label();
            this.player2Label = new System.Windows.Forms.Label();
            this.player1Label = new System.Windows.Forms.Label();
            this.gameStatusBox = new System.Windows.Forms.GroupBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statisticsBox.SuspendLayout();
            this.gameStatusBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // topLeftLabel
            // 
            this.topLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLeftLabel.Location = new System.Drawing.Point(12, 9);
            this.topLeftLabel.Name = "topLeftLabel";
            this.topLeftLabel.Size = new System.Drawing.Size(115, 115);
            this.topLeftLabel.TabIndex = 0;
            this.topLeftLabel.Text = "X";
            this.topLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.topLeftLabel.Click += new System.EventHandler(this.Area_Clicked);
            // 
            // topMidLabel
            // 
            this.topMidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topMidLabel.Location = new System.Drawing.Point(133, 9);
            this.topMidLabel.Name = "topMidLabel";
            this.topMidLabel.Size = new System.Drawing.Size(115, 115);
            this.topMidLabel.TabIndex = 1;
            this.topMidLabel.Text = "X";
            this.topMidLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.topMidLabel.Click += new System.EventHandler(this.Area_Clicked);
            // 
            // topRightLabel
            // 
            this.topRightLabel.BackColor = System.Drawing.SystemColors.Control;
            this.topRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topRightLabel.Location = new System.Drawing.Point(249, 9);
            this.topRightLabel.Name = "topRightLabel";
            this.topRightLabel.Size = new System.Drawing.Size(115, 115);
            this.topRightLabel.TabIndex = 2;
            this.topRightLabel.Text = "X";
            this.topRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.topRightLabel.Click += new System.EventHandler(this.Area_Clicked);
            // 
            // midLeftLabel
            // 
            this.midLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midLeftLabel.Location = new System.Drawing.Point(12, 124);
            this.midLeftLabel.Name = "midLeftLabel";
            this.midLeftLabel.Size = new System.Drawing.Size(115, 115);
            this.midLeftLabel.TabIndex = 3;
            this.midLeftLabel.Text = "X";
            this.midLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.midLeftLabel.Click += new System.EventHandler(this.Area_Clicked);
            // 
            // midMidLabel
            // 
            this.midMidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midMidLabel.Location = new System.Drawing.Point(133, 124);
            this.midMidLabel.Name = "midMidLabel";
            this.midMidLabel.Size = new System.Drawing.Size(115, 115);
            this.midMidLabel.TabIndex = 4;
            this.midMidLabel.Text = "X";
            this.midMidLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.midMidLabel.Click += new System.EventHandler(this.Area_Clicked);
            // 
            // midRightLabel
            // 
            this.midRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midRightLabel.Location = new System.Drawing.Point(249, 124);
            this.midRightLabel.Name = "midRightLabel";
            this.midRightLabel.Size = new System.Drawing.Size(115, 115);
            this.midRightLabel.TabIndex = 5;
            this.midRightLabel.Text = "X";
            this.midRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.midRightLabel.Click += new System.EventHandler(this.Area_Clicked);
            // 
            // bottomLeftLabel
            // 
            this.bottomLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottomLeftLabel.Location = new System.Drawing.Point(12, 239);
            this.bottomLeftLabel.Name = "bottomLeftLabel";
            this.bottomLeftLabel.Size = new System.Drawing.Size(115, 115);
            this.bottomLeftLabel.TabIndex = 6;
            this.bottomLeftLabel.Text = "X";
            this.bottomLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bottomLeftLabel.Click += new System.EventHandler(this.Area_Clicked);
            // 
            // bottomMidLabel
            // 
            this.bottomMidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottomMidLabel.Location = new System.Drawing.Point(133, 239);
            this.bottomMidLabel.Name = "bottomMidLabel";
            this.bottomMidLabel.Size = new System.Drawing.Size(115, 115);
            this.bottomMidLabel.TabIndex = 7;
            this.bottomMidLabel.Text = "X";
            this.bottomMidLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bottomMidLabel.Click += new System.EventHandler(this.Area_Clicked);
            // 
            // bottomRightLabel
            // 
            this.bottomRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottomRightLabel.Location = new System.Drawing.Point(249, 239);
            this.bottomRightLabel.Name = "bottomRightLabel";
            this.bottomRightLabel.Size = new System.Drawing.Size(115, 115);
            this.bottomRightLabel.TabIndex = 8;
            this.bottomRightLabel.Text = "X";
            this.bottomRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bottomRightLabel.Click += new System.EventHandler(this.Area_Clicked);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(116, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 345);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(235, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 345);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(9, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(345, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(9, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(345, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "label4";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(437, 34);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 13;
            this.startButton.Text = "Start Game";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // statisticsBox
            // 
            this.statisticsBox.Controls.Add(this.numTies);
            this.statisticsBox.Controls.Add(this.playerTwoWins);
            this.statisticsBox.Controls.Add(this.playerOneWins);
            this.statisticsBox.Controls.Add(this.tieLabel);
            this.statisticsBox.Controls.Add(this.player2Label);
            this.statisticsBox.Controls.Add(this.player1Label);
            this.statisticsBox.Location = new System.Drawing.Point(404, 116);
            this.statisticsBox.Name = "statisticsBox";
            this.statisticsBox.Size = new System.Drawing.Size(200, 100);
            this.statisticsBox.TabIndex = 14;
            this.statisticsBox.TabStop = false;
            this.statisticsBox.Text = "Statistics";
            // 
            // numTies
            // 
            this.numTies.AutoSize = true;
            this.numTies.Location = new System.Drawing.Point(94, 74);
            this.numTies.Name = "numTies";
            this.numTies.Size = new System.Drawing.Size(13, 13);
            this.numTies.TabIndex = 5;
            this.numTies.Text = "0";
            // 
            // playerTwoWins
            // 
            this.playerTwoWins.AutoSize = true;
            this.playerTwoWins.Location = new System.Drawing.Point(94, 48);
            this.playerTwoWins.Name = "playerTwoWins";
            this.playerTwoWins.Size = new System.Drawing.Size(13, 13);
            this.playerTwoWins.TabIndex = 4;
            this.playerTwoWins.Text = "0";
            // 
            // playerOneWins
            // 
            this.playerOneWins.AutoSize = true;
            this.playerOneWins.Location = new System.Drawing.Point(94, 20);
            this.playerOneWins.Name = "playerOneWins";
            this.playerOneWins.Size = new System.Drawing.Size(13, 13);
            this.playerOneWins.TabIndex = 3;
            this.playerOneWins.Text = "0";
            // 
            // tieLabel
            // 
            this.tieLabel.AutoSize = true;
            this.tieLabel.Location = new System.Drawing.Point(55, 74);
            this.tieLabel.Name = "tieLabel";
            this.tieLabel.Size = new System.Drawing.Size(30, 13);
            this.tieLabel.TabIndex = 2;
            this.tieLabel.Text = "Ties:";
            // 
            // player2Label
            // 
            this.player2Label.AutoSize = true;
            this.player2Label.Location = new System.Drawing.Point(10, 48);
            this.player2Label.Name = "player2Label";
            this.player2Label.Size = new System.Drawing.Size(78, 13);
            this.player2Label.TabIndex = 1;
            this.player2Label.Text = "Player 2 Wins: ";
            // 
            // player1Label
            // 
            this.player1Label.AutoSize = true;
            this.player1Label.Location = new System.Drawing.Point(10, 20);
            this.player1Label.Name = "player1Label";
            this.player1Label.Size = new System.Drawing.Size(78, 13);
            this.player1Label.TabIndex = 0;
            this.player1Label.Text = "Player 1 Wins: ";
            // 
            // gameStatusBox
            // 
            this.gameStatusBox.Controls.Add(this.statusLabel);
            this.gameStatusBox.Location = new System.Drawing.Point(13, 385);
            this.gameStatusBox.Name = "gameStatusBox";
            this.gameStatusBox.Size = new System.Drawing.Size(226, 73);
            this.gameStatusBox.TabIndex = 15;
            this.gameStatusBox.TabStop = false;
            this.gameStatusBox.Text = "Game Status";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(44, 30);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(115, 20);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Text = "Pending Game";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 488);
            this.Controls.Add(this.gameStatusBox);
            this.Controls.Add(this.statisticsBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bottomRightLabel);
            this.Controls.Add(this.bottomMidLabel);
            this.Controls.Add(this.bottomLeftLabel);
            this.Controls.Add(this.midRightLabel);
            this.Controls.Add(this.midMidLabel);
            this.Controls.Add(this.midLeftLabel);
            this.Controls.Add(this.topRightLabel);
            this.Controls.Add(this.topMidLabel);
            this.Controls.Add(this.topLeftLabel);
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.statisticsBox.ResumeLayout(false);
            this.statisticsBox.PerformLayout();
            this.gameStatusBox.ResumeLayout(false);
            this.gameStatusBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label topLeftLabel;
        private System.Windows.Forms.Label topMidLabel;
        private System.Windows.Forms.Label topRightLabel;
        private System.Windows.Forms.Label midLeftLabel;
        private System.Windows.Forms.Label midMidLabel;
        private System.Windows.Forms.Label midRightLabel;
        private System.Windows.Forms.Label bottomLeftLabel;
        private System.Windows.Forms.Label bottomMidLabel;
        private System.Windows.Forms.Label bottomRightLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.GroupBox statisticsBox;
        private System.Windows.Forms.Label player1Label;
        private System.Windows.Forms.Label player2Label;
        private System.Windows.Forms.Label tieLabel;
        private System.Windows.Forms.Label playerOneWins;
        private System.Windows.Forms.Label playerTwoWins;
        private System.Windows.Forms.Label numTies;
        private System.Windows.Forms.GroupBox gameStatusBox;
        private System.Windows.Forms.Label statusLabel;
    }
}

