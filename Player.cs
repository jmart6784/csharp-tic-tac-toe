using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
  class Player
  {
    public string? name;
    public string piece;
    public int score;

    public Player(string aName, string aPiece, int aScore)
    {
      name = aName;
      piece = aPiece;
      score = aScore;
    }

    public void promptName()
    {
      Console.Write($"{name} please enter your name ");
      var input = Console.ReadLine();
      string trimmed = String.Concat(input.Where(c => !Char.IsWhiteSpace(c)));

      if (input == "" || input == null || trimmed == "")
      {
        promptName();
      }
      else
      {
        name = input;
      }
    }
  }
}