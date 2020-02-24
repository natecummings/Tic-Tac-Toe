using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// The turn variable keeps track of whose turn it is. 0 is player 1 and 1 is player 2
        /// </summary>
        int turn = 0;

        /// <summary>
        /// Determines if the game has started and the board is "clickable"
        /// </summary>
        bool startGame;

        /// <summary>
        /// Instantiate the GameRules class
        /// </summary>
        GameRules gameRules;

        /// <summary>
        /// Create the board String array and set all of the spaces to a blank " "
        /// </summary>
        string[,] board = new string[,] { { " ", " ", " " }, { " ", " ", " " }, { " ", " ", " " } };

        /// <summary>
        /// Keeps track of all of the player 1 wins
        /// </summary>
        int player1Wins;

        /// <summary>
        /// Keeps track of all of the player 2 wins
        /// </summary>
        int player2Wins;

        /// <summary>
        /// Keeps track of the ties
        /// </summary>
        int ties;

        /// <summary>
        /// Initializes all of the components and sets everything to a blank slate
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            gameRules = new GameRules();
            startGame = false;
            player1Wins = 0;
            player2Wins = 0;
            ties = 0;

            // Make sure the board is reseet
            clearBoard();
        }

        /// <summary>
        /// Clears the board and sets all the colors back to clear
        /// </summary>
        private void clearBoard()
        {
            // Clear the board of Xs and Os
            topLeftLabel.Text = " ";
            topMidLabel.Text = " ";
            topRightLabel.Text = " ";
            midLeftLabel.Text = " ";
            midMidLabel.Text = " ";
            midRightLabel.Text = " ";
            bottomLeftLabel.Text = " ";
            bottomMidLabel.Text = " ";
            bottomRightLabel.Text = " ";

            // Set the background colors to clear
            topLeftLabel.BackColor = SystemColors.Control;
            topMidLabel.BackColor = SystemColors.Control;
            topRightLabel.BackColor = SystemColors.Control;
            midLeftLabel.BackColor = SystemColors.Control;
            midMidLabel.BackColor = SystemColors.Control;
            midRightLabel.BackColor = SystemColors.Control;
            bottomLeftLabel.BackColor = SystemColors.Control;
            bottomMidLabel.BackColor = SystemColors.Control;
            bottomRightLabel.BackColor = SystemColors.Control;

            // Clear the array back to " "
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = " ";
                }
            }
        }

        /// <summary>
        /// When the start button is clicked, display whose turn it is and clear the board of the previous game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startButton_Click(object sender, EventArgs e)
        {
            // If a game isn't in progress, clear the board and display the turn
            if (!startGame)
            {
                // Start the game
                startGame = true;

                // Clear the board
                clearBoard();

                // Display whose turn it is
                if (turn == 0)
                    statusLabel.Text = "Player 1's Turn";
                if (turn == 1)
                    statusLabel.Text = "Player 2's Turn";
            }
            
        }

        /// <summary>
        /// Determines where the user clicked on the board and displays the appropriate symbol
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Area_Clicked(object sender, EventArgs e)
        {
            Label myLabel = (Label)sender;
            // If the space clicked on is blank and there is an active game
            if (myLabel.Text == " " && startGame)
            {
                // For player 1
                if (turn == 0)
                {
                    // Display X
                    myLabel.Text = "X";
                    // Change the turn to player 2
                    turn++;
                    // Display the turn
                    statusLabel.Text = "Player 2's Turn";
                }
                // For player 2
                else
                {
                    // Display O
                    myLabel.Text = "O";
                    // Change the turn to player 1
                    turn--;
                    // Display the turn
                    statusLabel.Text = "Player 1's Turn";
                }
                // Fill the board array with the current variables
                loadBoard();
                // Check if it was a winning move
                hasWon();
            }
        }

        /// <summary>
        /// Updates the board array with the current variables on the board
        /// </summary>
        private void loadBoard()
        {
            // Update the left column
            board[0, 0] = topLeftLabel.Text;
            board[0, 1] = midLeftLabel.Text;
            board[0, 2] = bottomLeftLabel.Text;

            // Update the middle column
            board[1, 0] = topMidLabel.Text;
            board[1, 1] = midMidLabel.Text;
            board[1, 2] = bottomMidLabel.Text;

            // Update the right column
            board[2, 0] = topRightLabel.Text;
            board[2, 1] = midRightLabel.Text;
            board[2, 2] = bottomRightLabel.Text;
        }


        /// <summary>
        /// Check to see if there was a winning move and display who the winner is
        /// </summary>
        private void hasWon()
        {
            // Set the gameRules board to the current board
            gameRules.saBoard = board;
            // If there is a winning move, display who won
            if (gameRules.IsWinningMove())
            {
                // If player 2 won
                if (turn == 0)
                {
                    // Display winner
                    statusLabel.Text = "Player 2 Wins!";
                    // Increment the amount of wins for player 2
                    player2Wins++;
                    // Display the amount of wins
                    playerTwoWins.Text = player2Wins.ToString();
                }
                // If player 1 won
                else
                {
                    // Display the winner
                    statusLabel.Text = "Player 1 Wins!";
                    // Increment the amount of wins for player 1
                    player1Wins++;
                    // Display the amount of wins
                    playerOneWins.Text = player1Wins.ToString();
                }
                // Call the method to change the background color of the winning move
                displayWinningMove();
                // Set it so the board is no longer clickable
                startGame = false;
            }
            // If there is a tie, display the tie
            else if(gameRules.isTie())
            {
                // Display the tie
                statusLabel.Text = "It's a Tie!";
                // Increment the number of ties
                ties++;
                // Display the amount of ties
                numTies.Text = ties.ToString();
                // Set it so the board is no longer clickable
                startGame = false;
            }
        }

        /// <summary>
        /// Changes the background color of the winning move
        /// </summary>
        private void displayWinningMove()
        {
            // If Row 1 was the winning move, display that row
            if (gameRules.eWinningMove == GameRules.WinningMove.Row1)
            {
                // Change the background color for the winning move
                topLeftLabel.BackColor = SystemColors.ActiveCaption;
                topMidLabel.BackColor = SystemColors.ActiveCaption;
                topRightLabel.BackColor = SystemColors.ActiveCaption;
            }
            // If Row 2 was the winning move, display that row
            else if (gameRules.eWinningMove == GameRules.WinningMove.Row2)
            {
                // Change the background color for the winning move
                midLeftLabel.BackColor = SystemColors.ActiveCaption;
                midMidLabel.BackColor = SystemColors.ActiveCaption;
                midRightLabel.BackColor = SystemColors.ActiveCaption;
            }
            // If Row 3 was the winning move, display that row
            else if (gameRules.eWinningMove == GameRules.WinningMove.Row3)
            {
                // Change the background color for the winning move
                bottomLeftLabel.BackColor = SystemColors.ActiveCaption;
                bottomMidLabel.BackColor = SystemColors.ActiveCaption;
                bottomRightLabel.BackColor = SystemColors.ActiveCaption;
            }
            // If column 1 was the winning move, display that column
            else if (gameRules.eWinningMove == GameRules.WinningMove.Col1)
            {
                // Change the background color for the winning move
                topLeftLabel.BackColor = SystemColors.ActiveCaption;
                midLeftLabel.BackColor = SystemColors.ActiveCaption;
                bottomLeftLabel.BackColor = SystemColors.ActiveCaption;
            }
            // If column 2 was the winning move, display that column
            else if (gameRules.eWinningMove == GameRules.WinningMove.Col2)
            {
                // Change the background color for the winning move
                topMidLabel.BackColor = SystemColors.ActiveCaption;
                midMidLabel.BackColor = SystemColors.ActiveCaption;
                bottomMidLabel.BackColor = SystemColors.ActiveCaption;
            }
            // If column 3 was the winning move, display that column
            else if (gameRules.eWinningMove == GameRules.WinningMove.Col3)
            {
                // Change the background color for the winning move
                topRightLabel.BackColor = SystemColors.ActiveCaption;
                midRightLabel.BackColor = SystemColors.ActiveCaption;
                bottomRightLabel.BackColor = SystemColors.ActiveCaption;
            }
            // If diagonal 1 was the winning move, display that diagonal
            else if (gameRules.eWinningMove == GameRules.WinningMove.Diag1)
            {
                // Change the background color for the winning move
                topLeftLabel.BackColor = SystemColors.ActiveCaption;
                midMidLabel.BackColor = SystemColors.ActiveCaption;
                bottomRightLabel.BackColor = SystemColors.ActiveCaption;
            }
            // If diagonal 2 was the winning move, display that diagonal
            else if (gameRules.eWinningMove == GameRules.WinningMove.Diag2)
            {
                // Change the background color for the winning move
                topRightLabel.BackColor = SystemColors.ActiveCaption;
                midMidLabel.BackColor = SystemColors.ActiveCaption;
                bottomLeftLabel.BackColor = SystemColors.ActiveCaption;
            }
        }
    }
}
