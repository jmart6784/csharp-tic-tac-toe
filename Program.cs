namespace TicTacToe
{
  class Program
  {
    static void Main(string[] args)
    {
      Player player1 = new Player("Player 1", "X", true, 0);
      Player player2 = new Player("Player 2", "O", false, 0);

      Console.WriteLine($"{player1.name} please enter your name");
      player1.name = Console.ReadLine();

      Console.WriteLine($"{player2.name} please enter your name");
      player2.name = Console.ReadLine();

      Console.WriteLine($"{player1.name} VS {player2.name}");
    }
  }
}