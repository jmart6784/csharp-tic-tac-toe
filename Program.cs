namespace TicTacToe
{
  class Program
  {
    static void Main(string[] args)
    {
      Player player1 = new Player("Player 1", "🇽", 0);
      Player player2 = new Player("Player 2", "🅾️", 0);
      Board board = new Board();

      // player1.promptName();
      // player2.promptName();
      board.PrintBoard();
      Console.WriteLine($"{player1.name} VS {player2.name} \n");

      // Loop until game rounds are over
      while (board.rounds != board.currentRound)
      {
        if (board.rounds == board.currentRound)
        {
          break;
        }
        Scores(player1, player2, board);
        board.TakeTurn(player1);

        if (board.rounds == board.currentRound)
        {
          break;
        }
        Scores(player1, player2, board);
        board.TakeTurn(player2);
      }
      // Game result
      string scores = $"({player1.name}: {player1.score} {player2.name}: {player2.score})";

      if (player1.score == player2.score)
      {
        Console.WriteLine($"It's a tie! {scores}");
        return;
      }
      Player winner = player1.score > player2.score ? player1 : player2;
      Console.WriteLine($"{winner.name} has won! {scores}");
    }

    static void Scores(Player player1, Player player2, Board board)
    {
      Console.WriteLine($"{player1.name}: {player1.score} {player2.name}: {player2.score} Round {board.currentRound + 1} of {board.rounds} \n");
    }
  }
}