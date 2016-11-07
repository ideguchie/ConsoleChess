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
            objBoard.SetPiece(new Position(3, 6), new Position(3, 4));
            objBoard.PrintBoard(new Position(3, 4));

            ////if the move was valid and a piece was moved, print the board.
            //bool newbool = objBoard.SetPiece(new Position(3, 4), new Position(3, 2));
            //if (newbool) {
            //    objBoard.PrintBoard(new Position(3, 2));
            //}

            //newbool = objBoard.SetPiece(new Position(3, 4), new Position(3, 3));
            //if (newbool) {
            //    objBoard.PrintBoard(new Position(3, 3));
            //}

            //newbool = objBoard.SetPiece(new Position(3, 3), new Position(3, 2));
            //if (newbool) {
            //    objBoard.PrintBoard(new Position(3, 2));
            //}


            bool newbool = objBoard.SetPiece(new Position(4, 1), new Position(4, 3));
            if (newbool) {
                objBoard.PrintBoard(new Position(4, 3));
            }

            newbool = objBoard.SetPiece(new Position(4, 3), new Position(4, 4));
            if (newbool) {
                objBoard.PrintBoard(new Position(4, 4));
            }

            newbool = objBoard.SetPiece(new Position(4, 4), new Position(4, 5));
            if (newbool) {
                objBoard.PrintBoard(new Position(4, 5));
            }


            newbool = objBoard.SetPiece(new Position(7, 1), new Position(7, 3));
            if (newbool) {
                objBoard.PrintBoard(new Position(7, 3));
            }

            newbool = objBoard.SetPiece(new Position(7, 3), new Position(7, 4));
            if (newbool) {
                objBoard.PrintBoard(new Position(7, 4));
            }

            newbool = objBoard.SetPiece(new Position(0, 6), new Position(0, 4));
            if (newbool) {
                objBoard.PrintBoard(new Position(0, 4));
            }

            newbool = objBoard.SetPiece(new Position(0, 4), new Position(0, 3));
            if (newbool) {
                objBoard.PrintBoard(new Position(0, 3));
            }

            newbool = objBoard.SetPiece(new Position(1, 1), new Position(1, 3));
            if (newbool) {
                objBoard.PrintBoard(new Position(1, 3));
            }

            //en passant test
            objBoard.PrintBoard(new Position(0, 3));

            newbool = objBoard.SetPiece(new Position(1, 7), new Position(2, 5));
            if (newbool) {
                objBoard.PrintBoard(new Position(2, 5));
            }

            newbool = objBoard.SetPiece(new Position(2, 5), new Position(1, 3));
            if (newbool) {
                objBoard.PrintBoard(new Position(1, 3));
            }

            newbool = objBoard.SetPiece(new Position(1, 3), new Position(2, 1));
            if (newbool) {
                objBoard.PrintBoard(new Position(2, 1));
            }

            newbool = objBoard.SetPiece(new Position(1, 6), new Position(1, 4));
            if(newbool) {
                objBoard.PrintBoard(new Position(1, 4));
            }

            newbool = objBoard.SetPiece(new Position(1, 4), new Position(1, 3));
            if (newbool) {
                objBoard.PrintBoard(new Position(1, 3));
            }

            newbool = objBoard.SetPiece(new Position(1, 3), new Position(1, 2));
            if (newbool) {
                objBoard.PrintBoard(new Position(1, 2));
            }

            newbool = objBoard.SetPiece(new Position(1, 2), new Position(1, 1));
            if (newbool) {
                objBoard.PrintBoard(new Position(1, 1));
            }

            newbool = objBoard.SetPiece(new Position(1, 1), new Position(1, 0));
            if (newbool) {
                objBoard.PrintBoard(new Position(1, 0));
            }
        }
    }
}
