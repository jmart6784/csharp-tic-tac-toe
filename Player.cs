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
      Console.WriteLine($"{name} please enter your name");
      name = Console.ReadLine();
    }
  }
}