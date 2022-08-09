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
      board.PrintBoard();
      Console.WriteLine($"{player1.name} VS {player2.name} \n");

      while (board.rounds != board.currentRound)
      {
        if (board.rounds == board.currentRound)
        {
          break;
        }
        Console.WriteLine($"{player1.name}: {player1.score} {player2.name}: {player2.score} Round {board.currentRound} of {board.rounds} \n");

        board.TakeTurn(player1);

        if (board.rounds == board.currentRound)
        {
          break;
        }
        Console.WriteLine($"{player1.name}: {player1.score} {player2.name}: {player2.score} Round {board.currentRound} of {board.rounds} \n");

        board.TakeTurn(player2);
      }
    }
  }
}