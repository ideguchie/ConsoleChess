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
        private bool blnMoveTwo;

        //Constructor
        public Pawn(bool pblnIsWhite, Position pposPosition) {
            this.position = new Position(pposPosition.getX(), pposPosition.getY());
            this.isWhite = pblnIsWhite;
            this.hasMoved = false;
            this.isSelected = false;
            this.strEnPassant = "";
            this.blnMoveTwo = false;
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

        public bool GetMoveTwo() {
            return blnMoveTwo;
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

        public void SetMoveTwo(bool pblnMoveTwo) {
            blnMoveTwo = pblnMoveTwo;
        }

        /// <summary>
        /// Two different decision trees determinant on color of piece, because pawns only move in one direction.
        /// </summary>
        /// <param name="parrBoard">Current state of board.</param>
        /// <param name="pposMoveTo">Proposed move.</param>
        /// <returns>Returns true if the move is valid.</returns>
        public bool ValidMove(Piece[,] parrBoard, Position pposMoveTo) {
            if (isWhite) {
                //if (pposMoveTo.getX() == (position.getX() - 1) &&
                //      pposMoveTo.getY() == position.getY() &&
                //      parrBoard[position.getX() - 1, position.getY()] != null &&
                //      IsEnemy(parrBoard, pposMoveTo)) {
                //    strEnPassant = "left";
                //    //return true;
                //} else if (pposMoveTo.getX() == (position.getX() + 1) &&
                //      pposMoveTo.getY() == position.getY() &&
                //      parrBoard[position.getX() + 1, position.getY()] != null &&
                //      IsEnemy(parrBoard, pposMoveTo)) {
                //    strEnPassant = "right";
                //    //return true;
                //}
                CheckEnPassant(parrBoard, pposMoveTo);

                if ((pposMoveTo.getX() == (position.getX() - 1) &&
                    pposMoveTo.getY() == position.getY() - 1) &&
                    ((parrBoard[pposMoveTo.getX(), pposMoveTo.getY()] != null &&
                    IsEnemy(parrBoard, pposMoveTo)) ||
                    strEnPassant == "left")) {

                    return true;
                } else if ((pposMoveTo.getX() == (position.getX() + 1) &&
                      pposMoveTo.getY() == position.getY() - 1) &&
                      ((parrBoard[pposMoveTo.getX(), pposMoveTo.getY()] != null &&
                      IsEnemy(parrBoard, pposMoveTo)) ||
                      strEnPassant == "right")) {

                    return true;
                }

                if (CheckSpace(parrBoard, pposMoveTo)) {
                    return true;
                }
            } else {
                //if (pposMoveTo.getX() == (position.getX() - 1) &&
                //       pposMoveTo.getY() == position.getY() &&
                //       parrBoard[position.getX() - 1, position.getY()] != null &&
                //       IsEnemy(parrBoard, pposMoveTo)) {
                //    blnEnPassant = true;
                //    //return true;
                //} else if (pposMoveTo.getX() == (position.getX() + 1) &&
                //      pposMoveTo.getY() == position.getY() &&
                //      parrBoard[position.getX() + 1, position.getY()] != null &&
                //      IsEnemy(parrBoard, pposMoveTo)) {
                //    blnEnPassant = true;
                //    //return true;
                //}
                CheckEnPassant(parrBoard, pposMoveTo);

                if ((pposMoveTo.getX() == (position.getX() - 1) &&
                    pposMoveTo.getY() == position.getY() + 1) &&
                    ((parrBoard[pposMoveTo.getX(), pposMoveTo.getY()] != null &&
                    IsEnemy(parrBoard, pposMoveTo)) ||
                    strEnPassant == "left")) {

                    return true;
                } else if ((pposMoveTo.getX() == (position.getX() + 1) &&
                      pposMoveTo.getY() == position.getY() + 1) &&
                      ((parrBoard[pposMoveTo.getX(), pposMoveTo.getY()] != null &&
                      IsEnemy(parrBoard, pposMoveTo)) ||
                      strEnPassant == "right")) {

                    return true;
                }

                if (CheckSpace(parrBoard, pposMoveTo)) {
                    return true;
                }
            }
            return false;
        }

        //Checks if en passant is a valid move to the left or right
        private void CheckEnPassant(Piece[,] parrBoard, Position pposMoveTo) {
            Pawn castPawnLeft = new Pawn(isWhite, position);
            Pawn castPawnRight = new Pawn(isWhite, position);
            if (position.getX() - 1 >= 0 && 
                parrBoard[position.getX() - 1, position.getY()] != null &&
                parrBoard[position.getX() - 1, position.getY()].PieceType() == "P") {
                castPawnLeft = new Pawn(parrBoard[position.getX() - 1, position.getY()].IsWhite() == "W", new Position(position.getX() - 1, position.getY()));
            } else if ((position.getX() + 1) < 8 && 
                parrBoard[position.getX() + 1, position.getY()] != null &&
                parrBoard[position.getX() + 1, position.getY()].PieceType() == "P") {
                castPawnRight = new Pawn(parrBoard[position.getX() + 1, position.getY()].IsWhite() == "W", new Position(position.getX() + 1, position.getY()));
            } else {
                return;
            }

            if (pposMoveTo.getX() == (position.getX() - 1) &&
                      pposMoveTo.getY() == position.getY() &&
                      parrBoard[position.getX() - 1, position.getY()] != null &&
                      castPawnLeft.blnMoveTwo &&
                      IsEnemy(parrBoard, pposMoveTo)) {
                strEnPassant = "left";

            } else if (pposMoveTo.getX() == (position.getX() + 1) &&
                  pposMoveTo.getY() == position.getY() &&
                  parrBoard[position.getX() + 1, position.getY()] != null &&
                  castPawnRight.blnMoveTwo &&
                  IsEnemy(parrBoard, pposMoveTo)) {
                strEnPassant = "right";

            }
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
                    //blnMoveTwo = true;
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
                    //blnMoveTwo = true;
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
