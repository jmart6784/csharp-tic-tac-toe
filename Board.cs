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
        {" ", " ", " "},
        {" ", " ", " "},
        {" ", " ", " "}
      };
    }

    public void PrintBoard()
    {
      string border = "  ----------";
      Console.WriteLine($"1 {board[0, 0]} | {board[0, 1]} | {board[0, 2]}");
      Console.WriteLine(border);
      Console.WriteLine($"2 {board[1, 0]} | {board[1, 1]} | {board[1, 2]}");
      Console.WriteLine(border);
      Console.WriteLine($"3 {board[2, 0]} | {board[2, 1]} | {board[2, 2]}");
      Console.WriteLine("  A   B   C");
    }

    public void Place(string move, string piece)
    {
      string[] moveAry = { move.Substring(0, 1), move.Substring(1, 1) };
      Array.Sort(moveAry);
      int row = Int32.Parse(moveAry[0]);
      string c = moveAry[1];
      int column = 0;

      if (c == "a")
      {
        column = 0;
      }
      else if (c == "b")
      {
        column = 1;
      }
      else if (c == "c")
      {
        column = 2;
      }

      board[row - 1, column] = piece;
    }
  }
}