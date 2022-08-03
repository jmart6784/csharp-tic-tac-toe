using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
  class Player
  {
    public string name;
    public string piece;
    public bool turn;
    public int score;

    public Player(string aName, string aPiece, bool aTurn, int aScore)
    {
      name = aName;
      piece = aPiece;
      turn = aTurn;
    }
  }
}