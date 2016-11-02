using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    /// <summary>
    /// A game of Chess.
    /// Authors: Elliot Ideguchi
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Board objBoard = new Board();
            objBoard.PrintBoard(null);
            objBoard.SetPiece(new Position(3, 6), new Position(3, 4));
            objBoard.PrintBoard(new Position(3, 4));
            objBoard.SetPiece(new Position(3, 4), new Position(3, 2));
            objBoard.PrintBoard(new Position(3, 2));
            //new Position(0,1)
        }
    }
}
