using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using TIC_TAC_TOE_FACADE_PATTERN.Exceptions;
using TIC_TAC_TOE_FACADE_PATTERN.Models;
namespace TIC_TAC_TOE_FACADE_PATTERN.Service
{
        public static class GameFacade
        {
            public static Player CurrentPlayer { get; private set; }
            public static Board GameBoard { get; private set; }
            private static Player Player1;
            private static Player Player2;

            public static void InitializeGame(string player1Name, string player2Name)
            {
                Player1 = new Player(player1Name, MarkType.X);
                Player2 = new Player(player2Name, MarkType.O);
                CurrentPlayer = Player1;
                GameBoard = new Board();
            }

            public static void DisplayBoard()
            {
                GameBoard.Display();
            }

            public static void PlayerMove(int position)
            {
                if (!GameBoard.IsPositionAvailable(position))
                    throw new InvalidInputException("Invalid move! Position already taken.");

                GameBoard.UpdateBoard(position, CurrentPlayer.Symbol);
            }

            public static bool CheckWin()
            {
                return ResultAnalyzer.CheckWin(GameBoard, (char)CurrentPlayer.Symbol);
            }

            public static bool IsGameOver(int movesCount)
            {
                return CheckWin() || ResultAnalyzer.CheckDraw(movesCount);
            }

            public static void SwitchPlayer()
            {
                CurrentPlayer = (CurrentPlayer == Player1) ? Player2 : Player1;
            }

            public static string GetCurrentPlayerName()
            {
                return CurrentPlayer.Name;
            }
        }
    }
