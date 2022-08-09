namespace TicTacToe
{
  class Program
  {
    static void Main(string[] args)
    {
      // 🇽 🅾️ ❌
      Player player1 = new Player("Player 1", "🇽", true, 0);
      Player player2 = new Player("Player 2", "🅾️", false, 0);
      Board board = new Board();

      // player1.promptName();
      // player2.promptName();

      Console.WriteLine($"{player1.name} VS {player2.name}");
      board.PrintBoard();
      TakeTurn(player1, board);
      TakeTurn(player2, board);
    }

    static void TakeTurn(Player player, Board board)
    {
      string[] legalMoves = {
        "1a", "1b", "1c", "a1", "b1", "c1",
        "2a", "2b", "2c", "a2", "b2", "c2",
        "3a", "3b", "3c", "a3", "b3", "c3",
      };

      Console.Write($"{player.name} Please take your turn. ");
      var move = Console.ReadLine();

      if (legalMoves.Contains(move))
      {
        if (board.Place(move, player.piece))
        {
          board.PrintBoard();
        }
        else
        {
          Console.WriteLine("That spot is TAKEN!");
          TakeTurn(player, board);
        };
      }
      else
      {
        Console.WriteLine("Invalid move please choose a valid row (1, 2, 3) and a valid column (A, B, C)");
        TakeTurn(player, board);
      }
    }
  }
}