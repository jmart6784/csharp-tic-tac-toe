using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
  class Board
  {
    public string[,] board;

    public Board()
    {
      board = new string[,] {
        {"1", "2", "3"},
        {"4", "5", "6"},
        {"7", "8", "9"}
      };
    }

    public void PrintBoard()
    {
      string border = "----------";
      Console.WriteLine($"{board[0, 0]} | {board[0, 1]} | {board[0, 2]}");
      Console.WriteLine(border);
      Console.WriteLine($"{board[1, 0]} | {board[1, 1]} | {board[1, 2]}");
      Console.WriteLine(border);
      Console.WriteLine($"{board[2, 0]} | {board[2, 1]} | {board[2, 2]}");
    }
  }
}