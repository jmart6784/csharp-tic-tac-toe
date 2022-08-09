namespace TicTacToe
{
  class Program
  {
    static void Main(string[] args)
    {
      // 🇽 🅾️ ❌
      Player player1 = new Player("Player 1", "🇽", true, 0);
      Player player2 = new Player("Player 2", "🅾️", false, 0);
      Board board = new Board(3);

      // player1.promptName();
      // player2.promptName();

      Console.WriteLine($"{player1.name} VS {player2.name}");
      board.PrintBoard();
      board.TakeTurn(player1);
      board.TakeTurn(player2);
    }
  }
}