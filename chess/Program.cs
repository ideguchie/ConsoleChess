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
            bool moved = false;

            #region King Test
            
            #endregion

            #region Queen Test
            //moved = objBoard.SetPiece(new Position(4, 6), new Position(4, 4));
            //if (moved) {
            //    objBoard.PrintBoard(new Position(4, 4));
            //}

            //moved = objBoard.SetPiece(new Position(4, 1), new Position(4, 3));
            //if (moved) {
            //    objBoard.PrintBoard(new Position(4, 3));
            //}

            //moved = objBoard.SetPiece(new Position(3, 7), new Position(6, 4));
            //if (moved) {
            //    objBoard.PrintBoard(new Position(6, 4));
            //}

            //moved = objBoard.SetPiece(new Position(7, 1), new Position(7, 2));
            //if (moved) {
            //    objBoard.PrintBoard(new Position(7, 2));
            //}

            //moved = objBoard.SetPiece(new Position(6, 4), new Position(3, 1));
            //if (moved) {
            //    objBoard.PrintBoard(new Position(3, 1));
            //}

            //moved = objBoard.SetPiece(new Position(3, 0), new Position(3, 1));
            //if (moved) {
            //    objBoard.PrintBoard(new Position(3, 1));
            //}
            #endregion

            #region Rook Test
            //moved = objBoard.SetPiece(new Position(7, 6), new Position(7, 4));
            //if (moved) {
            //    objBoard.PrintBoard(new Position(7, 4));
            //}

            //moved = objBoard.SetPiece(new Position(3, 1), new Position(3, 3));
            //if (moved) {
            //    objBoard.PrintBoard(new Position(3, 3));
            //}

            //moved = objBoard.SetPiece(new Position(7, 7), new Position(7, 5));
            //if (moved) {
            //    objBoard.PrintBoard(new Position(7, 5));
            //}

            //moved = objBoard.SetPiece(new Position(2, 1), new Position(2, 3));
            //if (moved) {
            //    objBoard.PrintBoard(new Position(2, 3));
            //}

            //moved = objBoard.SetPiece(new Position(7, 5), new Position(3, 5));
            //if (moved) {
            //    objBoard.PrintBoard(new Position(3, 5));
            //}

            //moved = objBoard.SetPiece(new Position(4, 1), new Position(4, 3));
            //if (moved) {
            //    objBoard.PrintBoard(new Position(4, 3));
            //}

            //moved = objBoard.SetPiece(new Position(3, 5), new Position(3, 3));
            //if (moved) {
            //    objBoard.PrintBoard(new Position(3, 3));
            //}

            //moved = objBoard.SetPiece(new Position(6, 0), new Position(5, 2));
            //if (moved) {
            //    objBoard.PrintBoard(new Position(5, 2));
            //}

            //moved = objBoard.SetPiece(new Position(3, 3), new Position(3, 0));
            //if (moved) {
            //    objBoard.PrintBoard(new Position(3, 0));
            //}

            //moved = objBoard.SetPiece(new Position(5, 2), new Position(3, 3));
            //if (moved) {
            //    objBoard.PrintBoard(new Position(3, 3));
            //}

            //moved = objBoard.SetPiece(new Position(3, 0), new Position(2, 0));
            //if (moved) {
            //    objBoard.PrintBoard(new Position(2, 0));
            //}

            //moved = objBoard.SetPiece(new Position(0, 0), new Position(2, 0));
            //if (moved) {
            //    objBoard.PrintBoard(new Position(2, 0));
            //}
            #endregion

            #region Bishop Test
            //moved = objBoard.SetPiece(new Position(4, 6), new Position(4, 4));
            //if (moved) {
            //    objBoard.PrintBoard(new Position(4, 4));
            //}

            //moved = objBoard.SetPiece(new Position(4, 1), new Position(4, 3));
            //if (moved) {
            //    objBoard.PrintBoard(new Position(4, 3));
            //}

            //moved = objBoard.SetPiece(new Position(5, 7), new Position(2, 4));
            //if (moved) {
            //    objBoard.PrintBoard(new Position(2, 4));
            //}

            //moved = objBoard.SetPiece(new Position(3, 1), new Position(3, 2));
            //if (moved) {
            //    objBoard.PrintBoard(new Position(3, 2));
            //}

            //moved = objBoard.SetPiece(new Position(2, 0), new Position(4, 2));
            //if(moved) {
            //    objBoard.PrintBoard(new Position(4, 2));
            //}

            //moved = objBoard.SetPiece(new Position(2, 4), new Position(4, 2));
            //if (moved) {
            //    objBoard.PrintBoard(new Position(4, 2));
            //}

            //moved = objBoard.SetPiece(new Position(5, 1), new Position(4, 2));
            //if(moved) {
            //    objBoard.PrintBoard(new Position(4, 2));
            //}
            #endregion

            #region En Passant Test
            //moved = objBoard.SetPiece(new Position(1, 7), new Position(2, 5));
            //if (moved) {
            //    objBoard.PrintBoard(new Chess.Position(2, 5));
            //}

            //moved = objBoard.SetPiece(new Position(0, 1), new Position(0, 3));
            //if (moved) {
            //    objBoard.PrintBoard(new Position(0, 3));
            //}

            //moved = objBoard.SetPiece(new Position(2, 5), new Position(4, 4));
            //if (moved) {
            //    objBoard.PrintBoard(new Position(4, 4));
            //}

            //moved = objBoard.SetPiece(new Position(0, 3), new Position(0, 4));
            //if (moved) {
            //    objBoard.PrintBoard(new Position(0, 4));
            //}

            //moved = objBoard.SetPiece(new Position(1, 6), new Position(1, 4));
            //if (moved) {
            //    objBoard.PrintBoard(new Position(1, 4));
            //}

            //objBoard.PrintBoard(new Position(0, 4));

            //moved = objBoard.SetPiece(new Position(0, 4), new Position(1, 5));
            //if (moved) {
            //    objBoard.PrintBoard(new Position(1, 5));
            //}

            //moved = objBoard.SetPiece(new Position(0, 6), new Position(1, 5));
            //if (moved) {
            //    objBoard.PrintBoard(new Position(1, 5));
            //}

            //moved = objBoard.SetPiece(new Position(5, 1), new Position(5, 3));
            //if (moved) {
            //    objBoard.PrintBoard(new Position(5, 3));
            //}

            //moved = objBoard.SetPiece(new Position(4, 4), new Position(2, 5));
            //if (moved) {
            //    objBoard.PrintBoard(new Position(2, 5));
            //}

            //moved = objBoard.SetPiece(new Position(5, 3), new Position(5, 4));
            //if (moved) {
            //    objBoard.PrintBoard(new Position(5, 4));
            //}

            //moved = objBoard.SetPiece(new Position(2, 5), new Position(1, 7));
            //if (moved) {
            //    objBoard.PrintBoard(new Position(1, 7));
            //}

            //moved = objBoard.SetPiece(new Position(3, 1), new Position(3, 3));
            //if (moved) {
            //    objBoard.PrintBoard(new Position(3, 3));
            //}

            //moved = objBoard.SetPiece(new Position(1, 7), new Position(0, 5));
            //if (moved) {
            //    objBoard.PrintBoard(new Position(0, 5));
            //}

            //moved = objBoard.SetPiece(new Position(3, 3), new Position(3, 4));
            //if (moved) {
            //    objBoard.PrintBoard(new Position(3, 4));
            //}

            //moved = objBoard.SetPiece(new Position(4, 6), new Position(4, 4));
            //if (moved) {
            //    objBoard.PrintBoard(new Position(4, 4));
            //}

            //objBoard.PrintBoard(new Position(3, 4));
            //objBoard.PrintBoard(new Position(5, 4));

            //moved = objBoard.SetPiece(new Position(1, 1), new Position(1, 3));
            //if (moved) {
            //    objBoard.PrintBoard(new Position(1, 3));
            //}

            //objBoard.PrintBoard(new Position(3, 4));
            //objBoard.PrintBoard(new Position(5, 4));

            //moved = objBoard.SetPiece(new Position(0, 5), new Position(1, 3));
            //if (moved) {
            //    objBoard.PrintBoard(new Position(1, 3));
            //}

            //objBoard.PrintBoard(new Position(3, 4));
            //objBoard.PrintBoard(new Position(5, 4));

            //moved = objBoard.SetPiece(new Position(6, 0), new Position(5, 2));
            //if (moved) {
            //    objBoard.PrintBoard(new Position(5, 2));
            //}

            //objBoard.PrintBoard(new Position(3, 4));
            //objBoard.PrintBoard(new Position(5, 4));

            //moved = objBoard.SetPiece(new Position(7, 6), new Position(7, 4));
            //if (moved) {
            //    objBoard.PrintBoard(new Position(7, 4));
            //}

            //objBoard.PrintBoard(new Position(3, 4));
            //objBoard.PrintBoard(new Position(5, 4));

            //moved = objBoard.SetPiece(new Position(5, 2), new Position(3, 1));
            //if (moved) {
            //    objBoard.PrintBoard(new Position(3, 1));
            //}

            //objBoard.PrintBoard(new Position(3, 4));
            //objBoard.PrintBoard(new Position(5, 4));

            //moved = objBoard.SetPiece(new Position(7, 4), new Position(7, 3));
            //if (moved) {
            //    objBoard.PrintBoard(new Position(7, 3));
            //}

            //objBoard.PrintBoard(new Position(3, 4));
            //objBoard.PrintBoard(new Position(5, 4));

            //moved = objBoard.SetPiece(new Position(6, 1), new Position(6, 3));
            //if (moved) {
            //    objBoard.PrintBoard(new Position(6, 3));
            //}

            //objBoard.PrintBoard(new Position(3, 4));
            //objBoard.PrintBoard(new Position(5, 4));
            //objBoard.PrintBoard(new Position(7, 3));

            //moved = objBoard.SetPiece(new Position(1, 3), new Position(0, 1));
            //if (moved) {
            //    objBoard.PrintBoard(new Position(0, 1));
            //}

            //moved = objBoard.SetPiece(new Position(3, 1), new Position(1, 0));
            //if (moved) {
            //    objBoard.PrintBoard(new Position(1, 0));
            //}

            //objBoard.PrintBoard(new Position(7, 3));
            #endregion
        }
    }
}
