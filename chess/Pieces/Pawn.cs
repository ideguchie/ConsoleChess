using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess {
    /// <summary>
    /// Pawn Object.
    /// </summary>
    class Pawn : Piece {
        private Position position;
        private bool isWhite;
        private bool hasMoved;
        private bool isSelected;
        private string strEnPassant;

        //Constructor
        public Pawn(bool pblnIsWhite, Position pposPosition) {
            this.position = new Position(pposPosition.getX(), pposPosition.getY());
            this.isWhite = pblnIsWhite;
            this.hasMoved = false;
            this.isSelected = false;
            this.strEnPassant = "";
        }

        //Returns true if piece is white.
        public string IsWhite() {
            if (isWhite) {
                return "W";
            }
            return "B";

            //return isWhite;
        }

        //Gets the value of isSelected.
        public bool IsSelected() {
            return isSelected;
        }

        //Returns the type of piece in the form of a String.
        public string PieceType() {
            return "P";
            //return "Pawn";
        }

        public string GetEnPassant() {
            return strEnPassant;
        }

        //Sets the piece to selected or not.
        public void SetSelected(bool pblnSelected) {
            isSelected = pblnSelected;
        }

        //Sets the position of the piece to reference in ValidMove()
        public void SetPosition(Position pposPosition) {
            position = pposPosition;
        }

        public void SetMoved(bool pblnMoved) {
            hasMoved = pblnMoved;
        }

        public void SetEnPassant(string pstrEnPassant) {
            strEnPassant = pstrEnPassant;
        }

        /// <summary>
        /// Two different decision trees determinant on color of piece, because pawns only move in one direction.
        /// </summary>
        /// <param name="parrBoard">Current state of board.</param>
        /// <param name="pposMoveTo">Proposed move.</param>
        /// <returns>Returns true if the move is valid.</returns>
        public bool ValidMove(Piece[,] parrBoard, Position pposMoveTo) {
            if (isWhite) {
                if (strEnPassant == "left" || ((pposMoveTo.getX() == (position.getX() - 1) &&
                    pposMoveTo.getY() == position.getY() - 1) &&
                    parrBoard[pposMoveTo.getX(), pposMoveTo.getY()] != null &&
                    IsEnemy(parrBoard, pposMoveTo))) {

                    return true;
                } else if (strEnPassant == "right" || ((pposMoveTo.getX() == (position.getX() + 1) &&
                      pposMoveTo.getY() == position.getY() - 1) &&
                      parrBoard[pposMoveTo.getX(), pposMoveTo.getY()] != null &&
                      IsEnemy(parrBoard, pposMoveTo))) {

                    return true;
                }

                if (CheckSpace(parrBoard, pposMoveTo)) {
                    return true;
                }
            } else {
                if (strEnPassant == "left" || ((pposMoveTo.getX() == (position.getX() - 1) &&
                    pposMoveTo.getY() == position.getY() + 1) &&
                    parrBoard[pposMoveTo.getX(), pposMoveTo.getY()] != null &&
                    IsEnemy(parrBoard, pposMoveTo))) {

                    return true;
                } else if (strEnPassant == "right" || ((pposMoveTo.getX() == (position.getX() + 1) &&
                      pposMoveTo.getY() == position.getY() + 1) &&
                      parrBoard[pposMoveTo.getX(), pposMoveTo.getY()] != null &&
                      IsEnemy(parrBoard, pposMoveTo))) {

                    return true;
                }

                if (CheckSpace(parrBoard, pposMoveTo)) {
                    return true;
                }
            }
            return false;
        }

        //Checks if the space in front of the pawn is empty. Returns true if the space is empty.
        private bool CheckSpace(Piece[,] parrBoard, Position pposPosition) {
            if (isWhite) {
                if (pposPosition.getX() == position.getX() &&
                    pposPosition.getY() < position.getY() &&
                    Math.Abs(pposPosition.getY() - position.getY()) < 2 &&
                    parrBoard[position.getX(), position.getY() - 1] == null) {

                    return true;

                } else if (pposPosition.getX() == position.getX() &&
                    pposPosition.getY() < position.getY() &&
                    !hasMoved &&
                    Math.Abs(pposPosition.getY() - position.getY()) < 3 &&
                    parrBoard[position.getX(), position.getY() - 1] == null &&
                    parrBoard[position.getX(), position.getY() - 2] == null) {

                    return true;

                }
            } else {
                if (pposPosition.getX() == position.getX() &&
                    pposPosition.getY() > position.getY() &&
                    Math.Abs(pposPosition.getY() - position.getY()) < 2 &&
                    parrBoard[position.getX(), position.getY() + 1] == null) {

                    return true;

                } else if (pposPosition.getX() == position.getX() &&
                      pposPosition.getY() > position.getY() &&
                      !hasMoved &&
                      Math.Abs(pposPosition.getY() - position.getY()) < 3 &&
                      parrBoard[position.getX(), position.getY() + 1] == null &&
                      parrBoard[position.getX(), position.getY() + 2] == null) {

                    return true;

                }
            }

            return false;
        }

        //Determines if board space contains an enemy piece.
        private bool IsEnemy(Piece[,] parrBoard, Position pposPosition) {
            if (parrBoard[pposPosition.getX(), pposPosition.getY()].IsWhite() == "W" && isWhite) {
                return false;
            } else if (parrBoard[pposPosition.getX(), pposPosition.getY()].IsWhite() == "B" && !isWhite) {
                return false;
            }
            return true;
        }
    }
}
