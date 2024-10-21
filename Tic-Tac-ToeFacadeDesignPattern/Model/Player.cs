using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tic_Tac_ToeFacadeDesignPattern.Types;

namespace Tic_Tac_ToeFacadeDesignPattern.Model
{
    internal class Player
    {
        private MarkType mark;

        public Player(MarkType type)
        {
            mark = type;
        }

        public void PlayGame(Board board)
        {
            Console.WriteLine("Enter your position (0-8):");
            int position = Convert.ToInt32(Console.ReadLine());
            board.SetCellMark(position, mark);
        }
    }
}

