namespace TicTacToe
{
  class Program
  {
    static void Main(string[] args)
    {
      // 🇽 🅾️ ❌
      Player player1 = new Player("Player 1", "X", true, 0);
      Player player2 = new Player("Player 2", "O", false, 0);
      Board board = new Board();

      // player1.promptName();
      // player2.promptName();

      Console.WriteLine($"{player1.name} VS {player2.name}");
      board.PrintBoard();
      TakeTurn(player1, board);
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
        board.Place(move, player.piece);
        board.PrintBoard();
      }
      else
      {
        TakeTurn(player, board);
      }
    }
  }
}