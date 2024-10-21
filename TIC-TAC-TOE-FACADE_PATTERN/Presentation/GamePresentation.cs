using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using TIC_TAC_TOE_FACADE_PATTERN.Exceptions;
using TIC_TAC_TOE_FACADE_PATTERN.Models;
using TIC_TAC_TOE_FACADE_PATTERN.Service;

namespace TIC_TAC_TOE_FACADE_PATTERN.Presentation
{
    public class GamePresentation
    {
        public static void StartGame()
        {
            Console.WriteLine("Enter Player 1 Name: ");
            string player1Name = Console.ReadLine();

            Console.WriteLine("Enter Player 2 Name: ");
            string player2Name = Console.ReadLine();

            GameFacade.InitializeGame(player1Name, player2Name);

            int movesCount = 0;

            while (true)
            {
                Console.Clear();
                DisplayBoard();

                try
                {
                    int position = GetPlayerMove(GameFacade.CurrentPlayer);
                    GameFacade.PlayerMove(position);
                }
                catch (InvalidInputException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                    continue;
                }

                movesCount++;

                if (GameFacade.IsGameOver(movesCount))
                {
                    //Console.Clear();
                    DisplayBoard();

                    if (GameFacade.CheckWin())
                    {
                        Console.WriteLine($"{GameFacade.GetCurrentPlayerName()} Wins!");
                    }
                    else
                    {
                        Console.WriteLine("It's a Draw!");
                    }
                    break;
                }

                GameFacade.SwitchPlayer();
            }
        }

        public static void DisplayBoard()
        {
            GameFacade.DisplayBoard();
        }

        public static int GetPlayerMove(Player currentPlayer)
        {
            int choice;
            bool validInput;
            do
            {
                Console.WriteLine($"{currentPlayer.Name} ({currentPlayer.Symbol}), enter your move (1-9): ");
                validInput = int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 9;

                if (!validInput)
                    Console.WriteLine("Invalid move! Please try again.");
            } while (!validInput);

            return choice;
        }
    }
}