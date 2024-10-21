using Tic_Tac_ToeFacadeDesignPattern.Model;
using Tic_Tac_ToeFacadeDesignPattern.Types;

namespace Tic_Tac_ToeFacadeDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            Player player1 = new Player(MarkType.X);
            Player player2 = new Player(MarkType.O);
            ResultAnalyzer resultAnalyzer = new ResultAnalyzer();
            PlayGame game = new PlayGame();

            game.DisplayBoard(board);
            game.StartGame(board, player1,player2, resultAnalyzer);

        }

    }
}
