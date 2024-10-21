using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tic_Tac_ToeFacadeDesignPattern.Types;

namespace Tic_Tac_ToeFacadeDesignPattern.Model
{
 internal class ResultAnalyzer
    {
       public ResultAnalyzer() { }

        private bool CheckRow(Board board, int startIndex)
        {
            if (board.GetMarkType(startIndex) == board.GetMarkType(startIndex + 1) &&
                board.GetMarkType(startIndex + 1) == board.GetMarkType(startIndex + 2) &&
                board.GetMarkType(startIndex) != MarkType.EMPTY)
            {
                Console.WriteLine($"{board.GetMarkType(startIndex)} Wins");
                return true;
            }
            return false;
        }

        private bool CheckColumn(Board board, int startIndex)
        {
            if (board.GetMarkType(startIndex) == board.GetMarkType(startIndex + 3) &&
                board.GetMarkType(startIndex + 3) == board.GetMarkType(startIndex + 6) &&
                board.GetMarkType(startIndex) != MarkType.EMPTY)
            {
                Console.WriteLine($"{board.GetMarkType(startIndex)} Wins");
                return true;
            }
            return false;
        }

        private bool CheckDiagonal(Board board, int startIndex, int step)
        {
            if (board.GetMarkType(startIndex) == board.GetMarkType(startIndex + step) &&
                board.GetMarkType(startIndex + step) == board.GetMarkType(startIndex + 2 * step) &&
                board.GetMarkType(startIndex) != MarkType.EMPTY)
            {
                Console.WriteLine($"{board.GetMarkType(startIndex)} Wins");
                return true;
            }
            return false;
        }
        public bool CheckFirstRow(Board board)
        {
            return CheckRow(board, 0);
        }

        public bool CheckSecondRow(Board board)
        {
            return CheckRow(board, 3);
        }

        public bool CheckThirdRow(Board board)
        {
            return CheckRow(board, 6);
        }

        public bool CheckFirstColumn(Board board)
        {
            return CheckColumn(board, 0);
        }

        public bool CheckSecondColumn(Board board)
        {
            return CheckColumn(board, 1);
        }

        public bool CheckThirdColumn(Board board)
        {
            return CheckColumn(board, 2);
        }

        public bool CheckRightDiagonal(Board board)
        {
            return CheckDiagonal(board, 0, 4);
        }

        public bool CheckLeftDiagonal(Board board)
        {
            return CheckDiagonal(board, 2, 2);
        }

        public bool Analyze(Board board)
        {
            return CheckFirstRow(board) || CheckSecondRow(board) || CheckThirdRow(board) ||
                   CheckFirstColumn(board) || CheckSecondColumn(board) || CheckThirdColumn(board) ||
                   CheckRightDiagonal(board) || CheckLeftDiagonal(board);
        }
    }
}
