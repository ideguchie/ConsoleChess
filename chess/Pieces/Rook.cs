namespace Chess {
    class Rook : Piece {

        private Position posPosition;
        private bool blnIsWhite;
        private bool blnIsSelected;
        private bool blnHasMoved;

        public Rook(bool pblnIsWhite, Position pposPosition) {
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
            return "R";
            //return "Rook";
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

        public bool ValidMove(Piece[,] parrBoard, Position pposMoveTo) {
            if (CheckSpace(parrBoard, pposMoveTo, new Position(posPosition.getX(), posPosition.getY()), 0, -1)) {
                return true;
            }
            if (CheckSpace(parrBoard, pposMoveTo, new Position(posPosition.getX(), posPosition.getY()), 1, 0)) {
                return true;
            }
            if (CheckSpace(parrBoard, pposMoveTo, new Position(posPosition.getX(), posPosition.getY()), 0, 1)) {
                return true;
            }
            if (CheckSpace(parrBoard, pposMoveTo, new Position(posPosition.getX(), posPosition.getY()), -1, 0)) {
                return true;
            }
            return false;
        }

        //Recursively checks if the spaces traveling in a direction are valid and also the desired position to move to.
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

            return CheckSpace(parrBoard, pposMoveTo, pposPosition, x, y);
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
