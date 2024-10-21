using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tic_Tac_ToeFacadeDesignPattern.Types;

namespace Tic_Tac_ToeFacadeDesignPattern.Model
{
    internal class PlayGame
        {
        public void DisplayBoard(Board board)
        {
            for (int i = 0; i < 9; i++)
            {
                if (board.GetMarkType(i) == MarkType.EMPTY)
                {
                    Console.Write("| ");
                }
                else
                {
                    Console.Write($"{board.GetMarkType(i)} | ");
                }
                if (i == 2 || i == 5 || i == 8)
                {
                    Console.WriteLine();
                    if (i != 8)
                    {
                        Console.WriteLine("________");
                    }
                }
            }
        }
            

        public void StartGame(Board board, Player player1, Player player2, ResultAnalyzer resultAnalyzer)
        {
            for (int turn = 0; turn < 10; turn++)
            {
                if (turn % 2 == 0)
                {
                    player1.PlayGame(board);
                }
                else
                {
                    player2.PlayGame(board);
                }

                DisplayBoard(board);

                if (resultAnalyzer.Analyze(board))
                {
                    return; 
                }
            }

            Console.WriteLine("Game Over! It's a draw.");
        }
    }
}
            

