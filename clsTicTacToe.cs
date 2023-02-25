using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    /// <summary>
    /// Class for the TicTacToe business logic
    /// </summary>
    public class clsTicTacToe
    {
        // Class variables
        private string[,] gameBoard;
        private int player1Wins;
        private int player2Wins;
        private int playerTies;
        private WinningMove winningMove;
        private PlayerTurn playerTurn;

        private enum WinningMove
        {
            Row0,
            Row1,
            Row2,
            Col0,
            Col1,
            Col2,
            Diag0,
            Diag1
        }

        private enum PlayerTurn
        {
            NotStarted,
            Player1,
            Player2
        }

        // constructor
        clsTicTacToe() {
            gameBoard = new string[3,3];
            player1Wins= 0;
            player2Wins= 0;
            playerTies= 0;
            playerTurn = PlayerTurn.NotStarted;
        }

        // properties
        public int p1Wins { 
            get
            {
                return player1Wins;
            }
            set
            {
                player1Wins = value;
            }
                
        }
        public int p2Wins
        {
            get
            {
                return player2Wins;
            }
            set
            {
                player2Wins = value;
            }

        }
        public int pTies
        {
            get
            {
                return playerTies;
            }
            set
            {
                playerTies = value;
            }

        }
        public string[,] GameBoard { 
            get
            {
                return gameBoard;
            }
            set
            {
                gameBoard = value;
            }
        }

        /// <summary>
        /// Method to check if the game has been started by clicking the start button
        /// </summary>
        /// <returns></returns>
        public bool HasGameStarted()
        {
            if (playerTurn == PlayerTurn.NotStarted)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// Method start the game by changing the status from NotStarted to Player1
        /// </summary>
        public void GameStart()
        {
            playerTurn = PlayerTurn.Player1;
        }
        /// <summary>
        /// Method will end the game by changing the status to NotStarted
        /// </summary>
        public void GameStop()
        {
            playerTurn = PlayerTurn.NotStarted;
        }
        /// <summary>
        ///  Method to check if the block the player's has clicked is empty
        /// </summary>
        /// <returns></returns>
        public bool BlockIsEmpty(Label lbl)
        {
            if (lbl.ToString() != "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// Method to return an X or O depending on which player's turn
        /// </summary>
        public string BlockSet()
        {
            if (playerTurn == PlayerTurn.Player1)
            {
                return "O";
            }
            else
            {
                return "X";
            }
        }
        /// <summary>
        /// Method to set the value in the array equal to its respective block that has been set.
        /// </summary>
        private void BoardSet()
        {

        }
        /// <summary>
        /// Method to change the turn to the next player
        /// </summary>
        private void PlayerChange()
        {
            if (playerTurn == PlayerTurn.Player1) { 
                playerTurn = PlayerTurn.Player2;
            }
            else
            {
                playerTurn= PlayerTurn.Player1;
            }
        }
        /// <summary>
        /// Method to check if there is a winning move for the player
        /// </summary>
        /// <returns></returns>
        private bool IsWinningMove()
        {

        }
        /// <summary>
        /// Method to check all rows if there is a winning move
        /// </summary>
        /// <returns></returns>
        private bool IsHor()
        {
            winningMove = WinningMove.Row0;
            winningMove = WinningMove.Row1;
            winningMove = WinningMove.Row2;
        }
        /// <summary>
        /// Method to check all columns if there is a winning move
        /// </summary>
        /// <returns></returns>
        private bool IsVert()
        {
            winningMove = WinningMove.Col0;
            winningMove = WinningMove.Col1;
            winningMove = WinningMove.Col2;
        }
        /// <summary>
        /// Method to check if there are any diagonal blocks for a winning move
        /// </summary>
        /// <returns></returns>
        private bool IsDiag()
        {
            winningMove = WinningMove.Diag0;
            winningMove = WinningMove.Diag1;
        }
        /// <summary>
        /// Method that highlights the respective blocks of a winning move
        /// </summary>
        private void HighlightWinningMove()
        {
            
        }
        /// <summary>
        /// Method determines if the game is a tie
        /// </summary>
        /// <returns></returns>
        private bool IsTie()
        {

        }
        /// <summary>
        /// Method that updates the game stats for either player wins or ties
        /// </summary>
        private void UpdateStats()
        {

        }
    }
}
