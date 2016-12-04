namespace Chess {
    class King : Piece {

        private Position posPosition;
        private bool blnIsWhite;
        private bool blnIsSelected;
        private bool blnHasMoved;

        public King(bool pblnIsWhite, Position pposPosition) {
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
            return "K";
            //return "King";
        }

        public void SetMoved(bool pblnMoved) {
            this.blnHasMoved = pblnMoved;
        }

        public void SetPosition(Position pposPosition) {
            this.posPosition = pposPosition;
        }

        public void SetSelected(bool pblnSelected) {
            this.blnIsSelected = pblnSelected;
        }

        //Standard piece valid move check
        public bool ValidMove(Piece[,] parrBoard, Position pposMoveTo) {
            if (CheckSpace(parrBoard, pposMoveTo, new Position(posPosition.getX(), posPosition.getY()), 0, -1) ||
                CheckSpace(parrBoard, pposMoveTo, new Position(posPosition.getX(), posPosition.getY()), 1, 0) ||
                CheckSpace(parrBoard, pposMoveTo, new Position(posPosition.getX(), posPosition.getY()), 0, 1) ||
                CheckSpace(parrBoard, pposMoveTo, new Position(posPosition.getX(), posPosition.getY()), -1, 0) ||
                CheckSpace(parrBoard, pposMoveTo, new Position(posPosition.getX(), posPosition.getY()), -1, -1) ||
                CheckSpace(parrBoard, pposMoveTo, new Position(posPosition.getX(), posPosition.getY()), 1, -1) ||
                CheckSpace(parrBoard, pposMoveTo, new Position(posPosition.getX(), posPosition.getY()), -1, 1) ||
                CheckSpace(parrBoard, pposMoveTo, new Position(posPosition.getX(), posPosition.getY()), 1, 1) ||
                CheckCastle(parrBoard, pposMoveTo)) {
                return true;
            }
            return false;
        }

        //Secondary valid move check to support castle move
        public bool ValidMove(Piece[,] parrBoard, Position pposMoveTo, bool pblnMove) {
            //combine all with OR and return true once
            if (CheckSpace(parrBoard, pposMoveTo, new Position(posPosition.getX(), posPosition.getY()), 0, -1) ||
                CheckSpace(parrBoard, pposMoveTo, new Position(posPosition.getX(), posPosition.getY()), 1, 0) ||
                CheckSpace(parrBoard, pposMoveTo, new Position(posPosition.getX(), posPosition.getY()), 0, 1) ||
                CheckSpace(parrBoard, pposMoveTo, new Position(posPosition.getX(), posPosition.getY()), -1, 0) ||
                CheckSpace(parrBoard, pposMoveTo, new Position(posPosition.getX(), posPosition.getY()), -1, -1) ||
                CheckSpace(parrBoard, pposMoveTo, new Position(posPosition.getX(), posPosition.getY()), 1, -1) ||
                CheckSpace(parrBoard, pposMoveTo, new Position(posPosition.getX(), posPosition.getY()), -1, 1) ||
                CheckSpace(parrBoard, pposMoveTo, new Position(posPosition.getX(), posPosition.getY()), 1, 1) || 
                CheckCastle(parrBoard, pposMoveTo, true)) {
                return true;
            }
            return false;
        }

        //Checks if castle is a valid move.
        private bool CheckCastle(Piece[,] parrBoard, Position pposMoveTo, bool pblnMove = false) {
            if (blnHasMoved) {
                return false;
            }

            if (!blnHasMoved &&
                posPosition.getX() - 2 == pposMoveTo.getX() &&
                posPosition.getY() == pposMoveTo.getY() &&
                (CheckRook(parrBoard, pposMoveTo, new Position(posPosition.getX(), posPosition.getY()), -1, pblnMove))) {
                return true;
            }
            if (!blnHasMoved &&
                posPosition.getX() + 2 == pposMoveTo.getX() &&
                posPosition.getY() == pposMoveTo.getY() &&
                CheckRook(parrBoard, pposMoveTo, new Position(posPosition.getX(), posPosition.getY()), 1, pblnMove)) {
                return true;
            }
            return false;
        }

        //Checks if there is a clear path to a rook to castle
        private bool CheckRook(Piece[,] parrBoard, Position pposMoveTo, Position pposPosition, int x, bool pblnMove = false) {
            pposPosition.setX(pposPosition.getX() + x);
            if (pposPosition.getX() < 0 ||
                pposPosition.getX() > 7) {
                return false;
            }

            if (parrBoard[pposPosition.getX(), pposPosition.getY()] != null &&
                parrBoard[pposPosition.getX(), pposPosition.getY()].PieceType() == "R") {
                Rook castle = (Rook)parrBoard[pposPosition.getX(), pposPosition.getY()];
                if (!castle.HasMoved()) {
                    if (x == 1) {
                        if (pblnMove) {
                            parrBoard[7, pposPosition.getY()].SetMoved(true);
                            parrBoard[5, pposPosition.getY()] = parrBoard[7, pposPosition.getY()];
                            parrBoard[7, pposPosition.getY()] = null;
                        }
                        return true;
                    } else if (x == -1) {
                        if (pblnMove) {
                            parrBoard[0, pposPosition.getY()].SetMoved(true);
                            parrBoard[3, pposPosition.getY()] = parrBoard[0, pposPosition.getY()];
                            parrBoard[0, pposPosition.getY()] = null;
                        }
                        return true;
                    }
                }
            } else if (parrBoard[pposPosition.getX(), pposPosition.getY()] != null) {
                return false;
            }
            return CheckRook(parrBoard, pposMoveTo, pposPosition, x, pblnMove);
        }

        private bool CheckSpace(Piece[,] parrBoard, Position pposMoveTo, Position pposPosition, int x, int y) {
            pposPosition.setX(pposPosition.getX() + x);
            pposPosition.setY(pposPosition.getY() + y);
            if (pposPosition.getX() < 0 ||
                pposPosition.getY() < 0 ||
                pposPosition.getX() > 7 ||
                pposPosition.getY() > 7) {
                return false;
            }

            if (parrBoard[pposPosition.getX(), pposPosition.getY()] != null &&
                pposMoveTo.getX() == pposPosition.getX() &&
                pposMoveTo.getY() == pposPosition.getY() &&
                IsEnemy(parrBoard, pposPosition)) {
                return true;
            } else if (parrBoard[pposPosition.getX(), pposPosition.getY()] != null) {
                return false;
            }

            if (pposPosition.getX() == pposMoveTo.getX() &&
                pposPosition.getY() == pposMoveTo.getY()) {
                return true;
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
