using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess {
    class Knight : Piece {

        private Position posPosition;
        private bool blnIsWhite;
        private bool blnIsSelected;
        private bool blnHasMoved;

        public Knight(bool pblnIsWhite, Position pposPosition) {
            this.posPosition = pposPosition;
            this.blnIsWhite = pblnIsWhite;
            this.blnIsSelected = false;
            this.blnHasMoved = false;
        }

        public bool IsSelected() {
            return blnIsSelected;
        }

        public string IsWhite() {
            if (blnIsWhite) {
                return "W";
            } else {
                return "B";
            }
            //return blnIsWhite;
        }

        public string PieceType() {
            return "N";
            //return "Knight";
        }

        public void SetMoved(bool pblnMoved) {
            blnHasMoved = pblnMoved;
        }

        public void SetPosition(Position pposPosition) {
            posPosition = pposPosition;
        }

        public void SetSelected(bool pblnSelected) {
            blnIsSelected = pblnSelected;
        }

        public bool ValidMove(Piece[,] parrBoard, Position pposMoveTo) {
            if ((posPosition.getX() - 1) >= 0 && (posPosition.getY() - 2) >= 0) {
                if (pposMoveTo.getX() == (posPosition.getX() - 1) &&
                    pposMoveTo.getY() == (posPosition.getY() - 2) &&
                    (parrBoard[pposMoveTo.getX(), pposMoveTo.getY()] == null ||
                    IsEnemy(parrBoard, pposMoveTo))) {
                    return true;
                }
            }
            if ((posPosition.getX() + 1) < 8 && (posPosition.getY() - 2) >= 0) {
                if (pposMoveTo.getX() == (posPosition.getX() + 1) &&
                    pposMoveTo.getY() == (posPosition.getY() - 2) &&
                    (parrBoard[pposMoveTo.getX(), pposMoveTo.getY()] == null ||
                    IsEnemy(parrBoard, pposMoveTo))) {
                    return true;
                }
            }
            if ((posPosition.getX() + 2) < 8 && (posPosition.getY() - 1) >= 0) {
                if (pposMoveTo.getX() == (posPosition.getX() + 2) &&
                    pposMoveTo.getY() == (posPosition.getY() - 1) &&
                    (parrBoard[pposMoveTo.getX(), pposMoveTo.getY()] == null ||
                    IsEnemy(parrBoard, pposMoveTo))) {
                    return true;
                }
            }
            if ((posPosition.getX() + 2) < 8 && (posPosition.getY() + 1) >= 0) {
                if (pposMoveTo.getX() == (posPosition.getX() + 2) &&
                    pposMoveTo.getY() == (posPosition.getY() + 1) &&
                    (parrBoard[pposMoveTo.getX(), pposMoveTo.getY()] == null ||
                    IsEnemy(parrBoard, pposMoveTo))) {
                    return true;
                }
            }
            if ((posPosition.getX() + 1) < 8 && (posPosition.getY() + 2) >= 0) {
                if (pposMoveTo.getX() == (posPosition.getX() + 1) &&
                    pposMoveTo.getY() == (posPosition.getY() + 2) &&
                    (parrBoard[pposMoveTo.getX(), pposMoveTo.getY()] == null ||
                    IsEnemy(parrBoard, pposMoveTo))) {
                    return true;
                }
            }
            if ((posPosition.getX() - 1) < 8 && (posPosition.getY() + 2) >= 0) {
                if (pposMoveTo.getX() == (posPosition.getX() - 1) &&
                    pposMoveTo.getY() == (posPosition.getY() + 2) &&
                    (parrBoard[pposMoveTo.getX(), pposMoveTo.getY()] == null ||
                    IsEnemy(parrBoard, pposMoveTo))) {
                    return true;
                }
            }
            if ((posPosition.getX() - 2) < 8 && (posPosition.getY() + 1) >= 0) {
                if (pposMoveTo.getX() == (posPosition.getX() - 2) &&
                    pposMoveTo.getY() == (posPosition.getY() + 1) &&
                    (parrBoard[pposMoveTo.getX(), pposMoveTo.getY()] == null ||
                    IsEnemy(parrBoard, pposMoveTo))) {
                    return true;
                }
            }
            if ((posPosition.getX() - 2) < 8 && (posPosition.getY() - 1) >= 0) {
                if (pposMoveTo.getX() == (posPosition.getX() - 2) &&
                    pposMoveTo.getY() == (posPosition.getY() - 1) &&
                    (parrBoard[pposMoveTo.getX(), pposMoveTo.getY()] == null ||
                    IsEnemy(parrBoard, pposMoveTo))) {
                    return true;
                }
            }
            return false;
        }

        //Determines if board space contains an enemy piece.
        private bool IsEnemy(Piece[,] parrBoard, Position pposPosition) {
            if (parrBoard[pposPosition.getX(), pposPosition.getY()].IsWhite() == "W" && blnIsWhite) {
                return false;
            } else if (parrBoard[pposPosition.getX(), pposPosition.getY()].IsWhite() == "B" && !blnIsWhite) {
                return false;
            }
            return true;
        }
    }
}
