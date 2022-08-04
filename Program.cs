﻿namespace TicTacToe
{
  class Program
  {
    static void Main(string[] args)
    {
      Player player1 = new Player("Player 1", "X", true, 0);
      Player player2 = new Player("Player 2", "O", false, 0);

      player1.promptName();
      player2.promptName();

      string[,] board = new string[3, 3] {
        {"1", "2", "3"},
        {"4", "5", "6"},
        {"7", "8", "9"}
      };

      Console.WriteLine($"{player1.name} VS {player2.name}");
    }
  }
}