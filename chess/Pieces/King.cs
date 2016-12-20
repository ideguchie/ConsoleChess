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

        public Position GetPosition() {
            return posPosition;
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

        //Standard piece valid move check used when printing board in console.
        public bool ValidMove(Piece[,] parrBoard, Position pposMoveTo) {
            Piece[,] objEnemyBoard = (Piece[,])parrBoard.Clone();
            objEnemyBoard[posPosition.getX(), posPosition.getY()] = null;
            if (CheckSpace(parrBoard, pposMoveTo, new Position(posPosition.getX(), posPosition.getY()), objEnemyBoard, 0, -1) ||
                CheckSpace(parrBoard, pposMoveTo, new Position(posPosition.getX(), posPosition.getY()), objEnemyBoard, 1, 0) ||
                CheckSpace(parrBoard, pposMoveTo, new Position(posPosition.getX(), posPosition.getY()), objEnemyBoard, 0, 1) ||
                CheckSpace(parrBoard, pposMoveTo, new Position(posPosition.getX(), posPosition.getY()), objEnemyBoard, -1, 0) ||
                CheckSpace(parrBoard, pposMoveTo, new Position(posPosition.getX(), posPosition.getY()), objEnemyBoard, -1, -1) ||
                CheckSpace(parrBoard, pposMoveTo, new Position(posPosition.getX(), posPosition.getY()), objEnemyBoard, 1, -1) ||
                CheckSpace(parrBoard, pposMoveTo, new Position(posPosition.getX(), posPosition.getY()), objEnemyBoard, -1, 1) ||
                CheckSpace(parrBoard, pposMoveTo, new Position(posPosition.getX(), posPosition.getY()), objEnemyBoard, 1, 1) ||
                CheckCastle(parrBoard, pposMoveTo, objEnemyBoard)) {
                return true;
            }
            return false;
        }

        //Secondary valid move check to support castle move                            
        public bool ValidMove(Piece[,] parrBoard, Position pposMoveTo, bool pblnMove) {
            Piece[,] objEnemyBoard = (Piece[,])parrBoard.Clone();
            objEnemyBoard[posPosition.getX(), posPosition.getY()] = null;
            if (CheckSpace(parrBoard, pposMoveTo, new Position(posPosition.getX(), posPosition.getY()), objEnemyBoard, 0, -1) ||
                CheckSpace(parrBoard, pposMoveTo, new Position(posPosition.getX(), posPosition.getY()), objEnemyBoard, 1, 0) ||
                CheckSpace(parrBoard, pposMoveTo, new Position(posPosition.getX(), posPosition.getY()), objEnemyBoard, 0, 1) ||
                CheckSpace(parrBoard, pposMoveTo, new Position(posPosition.getX(), posPosition.getY()), objEnemyBoard, -1, 0) ||
                CheckSpace(parrBoard, pposMoveTo, new Position(posPosition.getX(), posPosition.getY()), objEnemyBoard, -1, -1) ||
                CheckSpace(parrBoard, pposMoveTo, new Position(posPosition.getX(), posPosition.getY()), objEnemyBoard, 1, -1) ||
                CheckSpace(parrBoard, pposMoveTo, new Position(posPosition.getX(), posPosition.getY()), objEnemyBoard, -1, 1) ||
                CheckSpace(parrBoard, pposMoveTo, new Position(posPosition.getX(), posPosition.getY()), objEnemyBoard, 1, 1) ||
                CheckCastle(parrBoard, pposMoveTo, objEnemyBoard, true)) {
                return true;
            }
            return false;
        }

        //Checks if castle is a valid move.
        private bool CheckCastle(Piece[,] parrBoard, Position pposMoveTo, Piece[,] parrEnemies, bool pblnMove = false) {
            if (blnHasMoved) {
                return false;
            }

            if (!blnHasMoved &&
                posPosition.getX() - 2 == pposMoveTo.getX() &&
                posPosition.getY() == pposMoveTo.getY() &&
                (CheckRook(parrBoard, pposMoveTo, new Position(posPosition.getX(), posPosition.getY()), parrEnemies, -1, pblnMove))) {
                for (int i = 0; i < 8; i++) {
                    for (int j = 0; j < 8; j++) {
                        if (parrBoard[j, i] != null &&
                            IsEnemy(parrBoard, new Position(j, i))) {
                            if (parrBoard[j, i].ValidMove(parrEnemies, new Position(posPosition.getX() - 1, posPosition.getY())) ||
                                parrBoard[j, i].ValidMove(parrEnemies, new Position(posPosition.getX() - 2, posPosition.getY()))) {
                                return false;
                            }
                        }
                    }
                }
                return true;
            }
            if (!blnHasMoved &&
                posPosition.getX() + 2 == pposMoveTo.getX() &&
                posPosition.getY() == pposMoveTo.getY() &&
                CheckRook(parrBoard, pposMoveTo, new Position(posPosition.getX(), posPosition.getY()), parrEnemies, 1, pblnMove)) {
                for (int i = 0; i < 8; i++) {
                    for (int j = 0; j < 8; j++) {
                        if (parrBoard[j, i] != null &&
                            IsEnemy(parrBoard, new Position(j, i))) {
                            if (parrBoard[j, i].ValidMove(parrEnemies, new Position(posPosition.getX() + 1, posPosition.getY())) ||
                                parrBoard[j, i].ValidMove(parrEnemies, new Position(posPosition.getX() + 2, posPosition.getY()))) {
                                return false;
                            }
                        }
                    }
                }
                return true;
            }
            return false;
        }

        //Checks if there is a clear path to a rook to castle
        private bool CheckRook(Piece[,] parrBoard, Position pposMoveTo, Position pposPosition, Piece[,] parrEnemies, int x, bool pblnMove = false) {
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
                            parrBoard[7, pposPosition.getY()].SetPosition(new Position(5, pposPosition.getY()));
                            parrBoard[5, pposPosition.getY()] = parrBoard[7, pposPosition.getY()];
                            parrBoard[7, pposPosition.getY()] = null;
                        }
                        return true;
                    } else if (x == -1) {
                        if (pblnMove) {
                            parrBoard[0, pposPosition.getY()].SetMoved(true);
                            parrBoard[0, pposPosition.getY()].SetPosition(new Position(3, pposPosition.getY()));
                            parrBoard[3, pposPosition.getY()] = parrBoard[0, pposPosition.getY()];
                            parrBoard[0, pposPosition.getY()] = null;
                        }
                        return true;
                    }
                }
            } else if (parrBoard[pposPosition.getX(), pposPosition.getY()] != null) {
                return false;
            }
            return CheckRook(parrBoard, pposMoveTo, pposPosition, parrEnemies, x, pblnMove);
        }

        private bool CheckSpace(Piece[,] parrBoard, Position pposMoveTo, Position pposPosition, Piece[,] parrEnemies, int x, int y) {
            pposPosition.setX(pposPosition.getX() + x);
            pposPosition.setY(pposPosition.getY() + y);
            if (pposPosition.getX() < 0 ||
                pposPosition.getY() < 0 ||
                pposPosition.getX() > 7 ||
                pposPosition.getY() > 7) {
                return false;
            }

            for (int i = 0; i < 8; i++) {
                for (int j = 0; j < 8; j++) {
                    if (parrBoard[j, i] != null &&
                        IsEnemy(parrBoard, new Position(j, i))) {
                        if (parrBoard[j, i].ValidMove(parrEnemies, pposPosition)) {
                            return false;
                        }
                    }
                }
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
