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
    public int rounds;
    public int currentRound;
    public string[] legalMoves;

    public Board()
    {
      currentRound = 0;
      rounds = 3;
      board = new string[,] {
        {"7", "8", "9"},
        {"4", "5", "6"},
        {"1", "2", "3"}
      };
      legalMoves = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
    }

    public void PrintBoard()
    {
      string border = "----------";
      Console.WriteLine($"{board[0, 0]} | {board[0, 1]} | {board[0, 2]}");
      Console.WriteLine(border);
      Console.WriteLine($"{board[1, 0]} | {board[1, 1]} | {board[1, 2]}");
      Console.WriteLine(border);
      Console.WriteLine($"{board[2, 0]} | {board[2, 1]} | {board[2, 2]} \n");
    }

    public bool Place(string move, string piece)
    {
      bool valid = true;

      if (move == "7")
      {
        board[0, 0] = piece;
      }
      else if (move == "8")
      {
        board[0, 1] = piece;
      }
      else if (move == "9")
      {
        board[0, 2] = piece;
      }
      else if (move == "4")
      {
        board[1, 0] = piece;
      }
      else if (move == "5")
      {
        board[1, 1] = piece;
      }
      else if (move == "6")
      {
        board[1, 2] = piece;
      }
      else if (move == "1")
      {
        board[2, 0] = piece;
      }
      else if (move == "2")
      {
        board[2, 1] = piece;
      }
      else if (move == "3")
      {
        board[2, 2] = piece;
      }
      else
      {
        valid = false;
      }

      return valid;
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
          if (GameOver())
          {
            player.score += 1;
          }
        }
        else
        {
          Console.WriteLine("That spot is TAKEN!");
          TakeTurn(player);
        };
      }
      else
      {
        Console.WriteLine("Invalid move please choose a valid space: (1, 2, 3, 4, 5, 6, 7, 8)");
        TakeTurn(player);
      }
    }

    public bool GameOver()
    {
      // If it is a draw end round, no player scores
      if (Draw())
      {
        return true;
      }
      string[,] b = board;
      bool end = false;
      // Game ending moves

      // Horizontal wins
      if (b[0, 0] == b[0, 1] && b[0, 1] == b[0, 2])
      {
        end = true;
      }
      else if (b[1, 0] == b[1, 1] && b[1, 1] == b[1, 2])
      {
        end = true;
      }
      else if (b[2, 0] == b[2, 1] && b[2, 1] == b[2, 2])
      {
        end = true;
      }
      // Vertical wins
      else if (b[0, 0] == b[1, 0] && b[1, 0] == b[2, 0])
      {
        end = true;
      }
      else if (b[0, 1] == b[1, 1] && b[1, 1] == b[2, 1])
      {
        end = true;
      }
      else if (b[0, 2] == b[1, 2] && b[1, 2] == b[2, 2])
      {
        end = true;
      }
      // Diagonal wins
      else if (b[0, 0] == b[1, 1] && b[1, 1] == b[2, 2])
      {
        end = true;
      }
      else if (b[0, 2] == b[1, 1] && b[1, 1] == b[2, 0])
      {
        end = true;
      }

      if (end)
      {
        currentRound++;

        board = new string[,] {
          {"7", "8", "9"},
          {"4", "5", "6"},
          {"1", "2", "3"}
        };
        if (rounds != currentRound)
        {
          Console.WriteLine($"Next Round! \n");
          PrintBoard();
        }
        return end;
      }
      return end;
    }

    public bool Draw()
    {
      int count = 0;

      for (int i = 0; i < board.GetLength(0); i++)
      {
        for (int j = 0; j < board.GetLength(1); j++)
        {
          if (legalMoves.Contains(board[i, j]))
          {
            count++;
          }
        }
      }

      if (count == 0)
      {
        board = new string[,] {
          {"7", "8", "9"},
          {"4", "5", "6"},
          {"1", "2", "3"}
        };
        PrintBoard();
        Console.WriteLine("Draw!\n");
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}