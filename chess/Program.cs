using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess {
    /// <summary>
    /// A game of Chess.
    /// Authors: Elliot Ideguchi
    /// </summary>
    class Program {
        static void Main(string[] args) {
            Board objBoard = new Board();
            objBoard.PrintBoard(null);
            bool moved = objBoard.SetPiece(new Position(4, 6), new Position(4, 4));
            if (moved) {
                objBoard.PrintBoard(new Chess.Position(4, 4));
            }

            moved = objBoard.SetPiece(new Position(4, 1), new Position(4, 3));
            if (moved) {
                objBoard.PrintBoard(new Chess.Position(4, 3));
            }

            moved = objBoard.SetPiece(new Position(2, 6), new Position(2, 4));
            if (moved) {
                objBoard.PrintBoard(new Chess.Position(2, 4));
            }

            moved = objBoard.SetPiece(new Position(6, 0), new Position(5, 2));
            if (moved) {
                objBoard.PrintBoard(new Chess.Position(5, 2));
            }

            moved = objBoard.SetPiece(new Position(2, 4), new Position(2, 3));
            if (moved) {
                objBoard.PrintBoard(new Chess.Position(2, 3));
            }

            moved = objBoard.SetPiece(new Position(1, 1), new Position(1, 3));
            if (moved) {
                objBoard.PrintBoard(new Chess.Position(1, 3));
            }

            objBoard.PrintBoard(new Position(2, 3));

            moved = objBoard.SetPiece(new Chess.Position(2, 3), new Position(2, 2));
            if (moved) {
                objBoard.PrintBoard(new Position(2, 2));
            }

            moved = objBoard.SetPiece(new Position(1, 3), new Position(1, 4));
            if (moved) {
                objBoard.PrintBoard(new Position(1, 4));
            }

            moved = objBoard.SetPiece(new Position(2, 2), new Position(3, 1));
            if (moved) {
                objBoard.PrintBoard(new Position(3, 1));
            }

            moved = objBoard.SetPiece(new Position(1, 4), new Position(1, 5));
            if (moved) {
                objBoard.PrintBoard(new Position(1, 5));
            }

            moved = objBoard.SetPiece(new Position(3, 1), new Position(3, 0));
            if (moved) {
                objBoard.PrintBoard(new Position(3, 0));
            }

            moved = objBoard.SetPiece(new Position(1, 5), new Position(0, 6));
            if (moved) {
                objBoard.PrintBoard(new Position(0, 6));
            }

            moved = objBoard.SetPiece(new Position(3, 0), new Position(2, 2));
            if (moved) {
                objBoard.PrintBoard(new Position(2, 2));
            }

            moved = objBoard.SetPiece(new Position(0, 6), new Position(0, 7));
            if (moved) {
                objBoard.PrintBoard(new Position(0, 7));
            }

            moved = objBoard.SetPiece(new Position(2, 2), new Position(3, 0));
            if (moved) {
                objBoard.PrintBoard(new Position(3, 0));
            }

            //turn test. two white moves in a row
            moved = objBoard.SetPiece(new Position(3, 0), new Position(2, 2));
            if (moved) {
                objBoard.PrintBoard(new Position(2, 2));
            }
        }
    }
}
