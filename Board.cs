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
    public string[] legalMoves;

    public Board()
    {
      board = new string[,] {
        {" ", " ", " "},
        {" ", " ", " "},
        {" ", " ", " "}
      };
      legalMoves = new string[] {
        "1a", "1b", "1c", "a1", "b1", "c1",
        "2a", "2b", "2c", "a2", "b2", "c2",
        "3a", "3b", "3c", "a3", "b3", "c3",
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

    public bool Place(string move, string piece)
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

      if (board[row - 1, column] == " ")
      {
        board[row - 1, column] = piece;
        return true;
      }
      else
      {
        return false;
      }
    }

    public void TakeTurn(Player player)
    {
      Console.Write($"{player.name} Please take your turn. ");
      var move = Console.ReadLine();

      if (legalMoves.Contains(move))
      {
        if (Place(move, player.piece))
        {
          PrintBoard();
        }
        else
        {
          Console.WriteLine("That spot is TAKEN!");
          TakeTurn(player);
        };
      }
      else
      {
        Console.WriteLine("Invalid move please choose a valid row (1, 2, 3) and a valid column (A, B, C)");
        TakeTurn(player);
      }
    }
  }
}