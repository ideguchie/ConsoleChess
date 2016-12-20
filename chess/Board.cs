using System;

namespace Chess {
    /// <summary>
    /// Board Object.
    /// </summary>
    class Board {
        private Piece[,] arrBoard;
        private Piece[] arrWhites;
        private Piece[] arrBlacks;
        private bool blnWhiteTurn;
        private bool blnCheckmate;

        //Constructor
        public Board() {
            arrBoard = new Piece[8, 8];
            arrWhites = new Piece[16];
            arrBlacks = new Piece[16];
            blnWhiteTurn = true;
            blnCheckmate = false;

            SetBoard();
        }

        #region Text Based Functions
        //Prints the state of the board.
        public void PrintBoard(Position pposSelected) {
            for (int y = 0; y < 8; y++) {
                String s1 = "";
                String s2 = "";
                String s3 = "";
                String s4 = "";
                String s5 = "";
                String s6 = "";
                String s7 = "";
                String s8 = "";
                if (pposSelected != null) {
                    if (arrBoard[pposSelected.getX(), pposSelected.getY()].ValidMove(arrBoard, new Position(0, y))) {
                        s1 = " X";
                        if (arrBoard[0, y] != null) {
                            s1 += arrBoard[0, y].IsWhite() + arrBoard[0, y].PieceType();
                        } else {
                            s1 += "  ";
                        }
                    } else if (arrBoard[0, y] != null) {
                        s1 = " " + arrBoard[0, y].IsWhite() + arrBoard[0, y].PieceType() + " ";
                    }

                    if (arrBoard[pposSelected.getX(), pposSelected.getY()].ValidMove(arrBoard, new Position(1, y))) {
                        s2 = " X";
                        if (arrBoard[1, y] != null) {
                            s2 += arrBoard[1, y].IsWhite() + arrBoard[1, y].PieceType();
                        } else {
                            s2 += "  ";
                        }
                    } else if (arrBoard[1, y] != null) {
                        s2 = " " + arrBoard[1, y].IsWhite() + arrBoard[1, y].PieceType() + " ";
                    }

                    if (arrBoard[pposSelected.getX(), pposSelected.getY()].ValidMove(arrBoard, new Position(2, y))) {
                        s3 = " X";
                        if (arrBoard[2, y] != null) {
                            s3 += arrBoard[2, y].IsWhite() + arrBoard[2, y].PieceType();
                        } else {
                            s3 += "  ";
                        }
                    } else if (arrBoard[2, y] != null) {
                        s3 = " " + arrBoard[2, y].IsWhite() + arrBoard[2, y].PieceType() + " ";
                    }

                    if (arrBoard[pposSelected.getX(), pposSelected.getY()].ValidMove(arrBoard, new Position(3, y))) {
                        s4 = " X";
                        if (arrBoard[3, y] != null) {
                            s4 += arrBoard[3, y].IsWhite() + arrBoard[3, y].PieceType();
                        } else {
                            s4 += "  ";
                        }
                    } else if (arrBoard[3, y] != null) {
                        s4 = " " + arrBoard[3, y].IsWhite() + arrBoard[3, y].PieceType() + " ";
                    }

                    if (arrBoard[pposSelected.getX(), pposSelected.getY()].ValidMove(arrBoard, new Position(4, y))) {
                        s5 = " X";
                        if (arrBoard[4, y] != null) {
                            s5 += arrBoard[4, y].IsWhite() + arrBoard[4, y].PieceType();
                        } else {
                            s5 += "  ";
                        }
                    } else if (arrBoard[4, y] != null) {
                        s5 = " " + arrBoard[4, y].IsWhite() + arrBoard[4, y].PieceType() + " ";
                    }

                    if (arrBoard[pposSelected.getX(), pposSelected.getY()].ValidMove(arrBoard, new Position(5, y))) {
                        s6 = " X";
                        if (arrBoard[5, y] != null) {
                            s6 += arrBoard[5, y].IsWhite() + arrBoard[5, y].PieceType();
                        } else {
                            s6 += "  ";
                        }
                    } else if (arrBoard[5, y] != null) {
                        s6 = " " + arrBoard[5, y].IsWhite() + arrBoard[5, y].PieceType() + " ";
                    }

                    if (arrBoard[pposSelected.getX(), pposSelected.getY()].ValidMove(arrBoard, new Position(6, y))) {
                        s7 = " X";
                        if (arrBoard[6, y] != null) {
                            s7 += arrBoard[6, y].IsWhite() + arrBoard[6, y].PieceType();
                        } else {
                            s7 += "  ";
                        }
                    } else if (arrBoard[6, y] != null) {
                        s7 = " " + arrBoard[6, y].IsWhite() + arrBoard[6, y].PieceType() + " ";
                    }

                    if (arrBoard[pposSelected.getX(), pposSelected.getY()].ValidMove(arrBoard, new Position(7, y))) {
                        s8 = " X";
                        if (arrBoard[7, y] != null) {
                            s8 += arrBoard[7, y].IsWhite() + arrBoard[7, y].PieceType();
                        } else {
                            s8 += "  ";
                        }
                    } else if (arrBoard[7, y] != null) {
                        s8 = " " + arrBoard[7, y].IsWhite() + arrBoard[7, y].PieceType() + " ";
                    }
                } else {
                    if (arrBoard[0, y] != null) {
                        s1 = " " + arrBoard[0, y].IsWhite() + arrBoard[0, y].PieceType() + " ";
                    }
                    if (arrBoard[1, y] != null) {
                        s2 = " " + arrBoard[1, y].IsWhite() + arrBoard[1, y].PieceType() + " ";
                    }
                    if (arrBoard[2, y] != null) {
                        s3 = " " + arrBoard[2, y].IsWhite() + arrBoard[2, y].PieceType() + " ";
                    }
                    if (arrBoard[3, y] != null) {
                        s4 = " " + arrBoard[3, y].IsWhite() + arrBoard[3, y].PieceType() + " ";
                    }
                    if (arrBoard[4, y] != null) {
                        s5 = " " + arrBoard[4, y].IsWhite() + arrBoard[4, y].PieceType() + " ";
                    }
                    if (arrBoard[5, y] != null) {
                        s6 = " " + arrBoard[5, y].IsWhite() + arrBoard[5, y].PieceType() + " ";
                    }
                    if (arrBoard[6, y] != null) {
                        s7 = " " + arrBoard[6, y].IsWhite() + arrBoard[6, y].PieceType() + " ";
                    }
                    if (arrBoard[7, y] != null) {
                        s8 = " " + arrBoard[7, y].IsWhite() + arrBoard[7, y].PieceType() + " ";
                    }
                }
                PrintRow(s1, s2, s3, s4, s5, s6, s7, s8, y);
            }
            Console.ReadLine();
        }

        private void PrintRow(String o, String tw, String th, String fu, String fi, String sx, String sv, String e, int row) {
            if (o == "" && arrBoard[0, row] == null) {
                o = "    ";
            }
            if (tw == "" && arrBoard[1, row] == null) {
                tw = "    ";
            }
            if (th == "" && arrBoard[2, row] == null) {
                th = "    ";
            }
            if (fu == "" && arrBoard[3, row] == null) {
                fu = "    ";
            }
            if (fi == "" && arrBoard[4, row] == null) {
                fi = "    ";
            }
            if (sx == "" && arrBoard[5, row] == null) {
                sx = "    ";
            }
            if (sv == "" && arrBoard[6, row] == null) {
                sv = "    ";
            }
            if (e == "" && arrBoard[7, row] == null) {
                e = "    ";
            }
            Console.WriteLine("______ ______ ______ ______ ______ ______ ______ ______");
            Console.WriteLine("|    | |    | |    | |    | |    | |    | |    | |    |");
            Console.WriteLine("|" + o + "| " + "|" + tw + "| " + "|" + th + "| " + "|" + fu + "| " + "|" + fi + "| " + "|" + sx + "| " + "|" + sv + "| " + "|" + e + "|");
            Console.WriteLine("|____| |____| |____| |____| |____| |____| |____| |____|");
        }
        #endregion

        public bool GetCheckmate() {
            return blnCheckmate;
        }

        public bool GetWhiteTurn() {
            return blnWhiteTurn;
        }

        public Piece SelectPiece(Position pposPosition) {
            if (arrBoard[pposPosition.getX(), pposPosition.getY()] != null &&
                arrBoard[pposPosition.getX(), pposPosition.getY()].IsWhite() == "W" == blnWhiteTurn) {
                arrBoard[pposPosition.getX(), pposPosition.getY()].SetSelected(true);
                return arrBoard[pposPosition.getX(), pposPosition.getY()];
            }

            return null;
        }

        //Moves a given piece from one space to another if the move is valid. Returns true if a move was made.
        public bool SetPiece(Position pposPosition, Position pposMoveTo) {
            if ((arrBoard[pposPosition.getX(), pposPosition.getY()].IsWhite() == "W" && blnWhiteTurn) ||
                (arrBoard[pposPosition.getX(), pposPosition.getY()].IsWhite() != "W" && !blnWhiteTurn)) {

                if ((arrBoard[pposPosition.getX(), pposPosition.getY()].PieceType() != "K" &&
            arrBoard[pposPosition.getX(), pposPosition.getY()].ValidMove(arrBoard, pposMoveTo)) ||
            (arrBoard[pposPosition.getX(), pposPosition.getY()].PieceType() == "K" &&
            ((King)arrBoard[pposPosition.getX(), pposPosition.getY()]).ValidMove(arrBoard, pposMoveTo, true))) {

                    if (arrBoard[pposMoveTo.getX(), pposMoveTo.getY()] != null) {
                        arrBoard[pposMoveTo.getX(), pposMoveTo.getY()] = null;
                        //arrBoard[pposMoveTo.getX(), pposMoveTo.getY()].SetPosition(new Position(-1, -1));
                    }

                    arrBoard[pposPosition.getX(), pposPosition.getY()].SetPosition(pposMoveTo);
                    arrBoard[pposMoveTo.getX(), pposMoveTo.getY()] = arrBoard[pposPosition.getX(), pposPosition.getY()];
                    arrBoard[pposPosition.getX(), pposPosition.getY()] = null;
                    arrBoard[pposMoveTo.getX(), pposMoveTo.getY()].SetMoved(true);

                    if (arrBoard[pposMoveTo.getX(), pposMoveTo.getY()] != null &&
                        arrBoard[pposMoveTo.getX(), pposMoveTo.getY()].PieceType() == "P") {
                        CheckPromotion(pposMoveTo, arrBoard[pposMoveTo.getX(), pposMoveTo.getY()].IsWhite() == "W");
                        EnPassant(pposPosition, pposMoveTo);
                    } else {
                        InvalidateEnPassant();
                    }

                    //Assess checkmate
                    if (IsCheck(arrBoard)) {
                        if (IsCheckMate()) {
                            blnCheckmate = true;
                            if (blnWhiteTurn) {
                                for (int k = 0; k < 15; k++) {
                                    if (BlockCheck(arrBlacks[k])) {
                                        blnCheckmate = false;
                                        break;
                                    }
                                }
                            } else {
                                for (int k = 0; k < 15; k++) {
                                    if (BlockCheck(arrWhites[k])) {
                                        blnCheckmate = false;
                                        break;
                                    }
                                }
                            }
                        }
                        //Just for text based.
                        if (blnCheckmate) {
                            Console.WriteLine("\n\n\nCHECKMATE");
                        } else {
                            Console.WriteLine("\n\n\nCHECK");
                        }
                        //Just for text based.
                    }

                    blnWhiteTurn = !blnWhiteTurn;
                    return true;

                }

            }
            return false;
        }

        private bool BlockCheck(Piece ppcePiece) {
            for (int i = 0; i < 8; i++) {
                for (int j = 0; j < 8; j++) {
                    Piece[,] objCheckBoard = (Piece[,])arrBoard.Clone();
                    if (ppcePiece != null &&
                        ppcePiece.GetPosition().getX() != -1 &&
                        ppcePiece.ValidMove(objCheckBoard, new Position(j, i))) {
                        Position position = ppcePiece.GetPosition();
                        objCheckBoard[j, i] = objCheckBoard[position.getX(), position.getY()];
                        objCheckBoard[position.getX(), position.getY()] = null;
                        if (!IsCheck(objCheckBoard)) {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private bool IsCheckMate() {
            if (blnWhiteTurn) {
                for (int i = 0; i < 8; i++) {
                    for (int j = 0; j < 8; j++) {
                        if (arrBlacks[15].ValidMove(arrBoard, new Position(j, i))) {
                            return false;
                        }
                    }
                }
            } else {
                for (int i = 0; i < 8; i++) {
                    for (int j = 0; j < 8; j++) {
                        if (arrWhites[15].ValidMove(arrBoard, new Position(j, i))) {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private bool IsCheck(Piece[,] parrBoard) {
            if (blnWhiteTurn) {
                Position position = arrBlacks[15].GetPosition();
                Piece[,] parrEnemies = (Piece[,])parrBoard.Clone();
                parrEnemies[position.getX(), position.getY()] = null;
                for (int i = 0; i < 8; i++) {
                    for (int j = 0; j < 8; j++) {
                        if (parrBoard[j, i] != null &&
                            IsEnemy(parrBoard, new Position(j, i), !blnWhiteTurn)) {
                            if (parrBoard[j, i].PieceType() == "P") {
                                if((position.getX() == (j + 1) || position.getX() == (j - 1)) && position.getY() == (i - 1)) {
                                    return true;
                                }
                            }
                            if (parrBoard[j, i].ValidMove(parrEnemies, position)) {
                                return true;
                            }
                        }
                    }
                }
            } else {
                Position position = arrWhites[15].GetPosition();
                Piece[,] parrEnemies = (Piece[,])parrBoard.Clone();
                parrEnemies[position.getX(), position.getY()] = null;
                for (int i = 0; i < 8; i++) {
                    for (int j = 0; j < 8; j++) {
                        if (parrBoard[j, i] != null &&
                            IsEnemy(parrBoard, new Position(j, i), !blnWhiteTurn)) {
                            if (parrBoard[j, i].PieceType() == "P") {
                                if ((position.getX() == (j + 1) || position.getX() == (j - 1)) && position.getY() == (i + 1)) {
                                    return true;
                                }
                            }
                            if (parrBoard[j, i].ValidMove(parrEnemies, position)) {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        //Determines if board space contains an enemy piece.
        private bool IsEnemy(Piece[,] parrBoard, Position pposPosition, bool pblnIsWhite) {
            if (parrBoard[pposPosition.getX(), pposPosition.getY()].IsWhite() == "W" && pblnIsWhite) {
                return false;
            } else if (parrBoard[pposPosition.getX(), pposPosition.getY()].IsWhite() == "B" && !pblnIsWhite) {
                return false;
            }
            return true;
        }

        private void InvalidateEnPassant() {
            //if it was just whites move, invalidate white en passant
            if (blnWhiteTurn) {
                for (int y = 0; y < 8; y++) {
                    for (int x = 0; x < 8; x++) {
                        if (arrBoard[x, y] != null &&
                            arrBoard[x, y].PieceType() == "P" &&
                            arrBoard[x, y].IsWhite() != "W") {
                            Pawn castPawn = (Pawn)arrBoard[x, y];
                            castPawn.SetEnPassant("");
                            castPawn.SetMoveTwo(false);
                        }
                    }
                }
            } else {
                for (int y = 0; y < 8; y++) {
                    for (int x = 0; x < 8; x++) {
                        if (arrBoard[x, y] != null &&
                            arrBoard[x, y].PieceType() == "P" &&
                            arrBoard[x, y].IsWhite() == "W") {
                            Pawn castPawn = (Pawn)arrBoard[x, y];
                            castPawn.SetEnPassant("");
                            castPawn.SetMoveTwo(false);
                        }
                    }
                }
            }
        }

        //Sets a piece on the board. (Used for promotion)
        private void CheckPromotion(Position pposPosition, bool pblnIsWhite) {
            if (pposPosition.getY() == 0 || pposPosition.getY() == 7) {
                string strPieceType = "";
                ChoosePiece(ref strPieceType);
                //can probably be one switch since the color is set by boolean
                if (pblnIsWhite) {
                    arrBoard[pposPosition.getX(), pposPosition.getY()] = null;
                    switch (strPieceType) {
                        case "Rook":
                            arrBoard[pposPosition.getX(), pposPosition.getY()] = new Rook(pblnIsWhite, pposPosition);
                            break;
                        case "Knight":
                            arrBoard[pposPosition.getX(), pposPosition.getY()] = new Knight(pblnIsWhite, pposPosition);
                            break;
                        case "Bishop":
                            arrBoard[pposPosition.getX(), pposPosition.getY()] = new Bishop(pblnIsWhite, pposPosition);
                            break;
                        default:
                            arrBoard[pposPosition.getX(), pposPosition.getY()] = new Queen(pblnIsWhite, pposPosition);
                            break;
                    }
                } else {
                    arrBoard[pposPosition.getX(), pposPosition.getY()] = null;
                    switch (strPieceType) {
                        case "Rook":
                            arrBoard[pposPosition.getX(), pposPosition.getY()] = new Rook(pblnIsWhite, pposPosition);
                            break;
                        case "Knight":
                            arrBoard[pposPosition.getX(), pposPosition.getY()] = new Knight(pblnIsWhite, pposPosition);
                            break;
                        case "Bishop":
                            arrBoard[pposPosition.getX(), pposPosition.getY()] = new Bishop(pblnIsWhite, pposPosition);
                            break;
                        default:
                            arrBoard[pposPosition.getX(), pposPosition.getY()] = new Queen(pblnIsWhite, pposPosition);
                            break;
                    }
                }
            }
        }

        //Invalidates Pawn indicators, checks for valid En Passant
        private void EnPassant(Position pposPosition, Position pposMoveTo) {
            if (pposPosition.getX() - 1 >= 0 &&
                arrBoard[pposPosition.getX() - 1, pposPosition.getY()] != null) {
                Pawn castPawn = (Pawn)arrBoard[pposMoveTo.getX(), pposMoveTo.getY()];
                if (castPawn.GetEnPassant() == "left") {
                    arrBoard[pposPosition.getX() - 1, pposPosition.getY()] = null;
                }
            }
            if ((pposPosition.getX() + 1) < 8 &&
                        arrBoard[pposPosition.getX() + 1, pposPosition.getY()] != null) {
                Pawn castPawn = (Pawn)arrBoard[pposMoveTo.getX(), pposMoveTo.getY()];
                if (castPawn.GetEnPassant() == "right") {
                    arrBoard[pposPosition.getX() + 1, pposPosition.getY()] = null;
                }
            }

            InvalidateEnPassant();

            if (Math.Abs(pposPosition.getY() - pposMoveTo.getY()) == 2 &&
                pposPosition.getX() == pposMoveTo.getX()) {
                Pawn castPawn = (Pawn)arrBoard[pposMoveTo.getX(), pposMoveTo.getY()];
                castPawn.SetMoveTwo(true);
            }
        }

        //Opens modal window for choosing promotion piece
        private void ChoosePiece(ref string pstrPieceType) {
            bool valid = false;
            Console.WriteLine("Choose a piece: Q, B, K, R.");
            while (!valid) {
                if (Console.ReadLine() == "k") {
                    valid = true;
                    pstrPieceType = "Knight";
                } else if (Console.ReadLine() == "r") {
                    valid = true;
                    pstrPieceType = "Rook";
                } else if (Console.ReadLine() == "q") {
                    valid = true;
                    pstrPieceType = "Queen";
                } else if (Console.ReadLine() == "b") {
                    valid = true;
                    pstrPieceType = "Bishop";
                }
            }
        }

        //Sets the initial state of the board.
        private void SetBoard() {

            //inital white piece positions
            Position posWhitePawn1 = new Position(0, 6);
            Position posWhitePawn2 = new Position(1, 6);
            Position posWhitePawn3 = new Position(2, 6);
            Position posWhitePawn4 = new Position(3, 6);
            Position posWhitePawn5 = new Position(4, 6);
            Position posWhitePawn6 = new Position(5, 6);
            Position posWhitePawn7 = new Position(6, 6);
            Position posWhitePawn8 = new Position(7, 6);
            Position posWhiteQKnight = new Position(1, 7);
            Position posWhiteKKnight = new Position(6, 7);
            Position posWhiteKBishop = new Position(5, 7);
            Position posWhiteQBishop = new Position(2, 7);
            Position posWhiteKRook = new Position(7, 7);
            Position posWhiteQRook = new Position(0, 7);
            Position posWhiteQueen = new Position(3, 7);
            Position posWhiteKing = new Position(4, 7);

            //inital black piece positionssitions
            Position posBlackPawn1 = new Position(0, 1);
            Position posBlackPawn2 = new Position(1, 1);
            Position posBlackPawn3 = new Position(2, 1);
            Position posBlackPawn4 = new Position(3, 1);
            Position posBlackPawn5 = new Position(4, 1);
            Position posBlackPawn6 = new Position(5, 1);
            Position posBlackPawn7 = new Position(6, 1);
            Position posBlackPawn8 = new Position(7, 1);
            Position posBlackQKnight = new Position(6, 0);
            Position posBlackKKnight = new Position(1, 0);
            Position posBlackQBishop = new Position(5, 0);
            Position posBlackKBishop = new Position(2, 0);
            Position posBlackQRook = new Position(7, 0);
            Position posBlackKRook = new Position(0, 0);
            Position posBlackQueen = new Position(3, 0);
            Position posBlackKing = new Position(4, 0);

            //white pieces
            Pawn pwnWhite1 = new Pawn(true, posWhitePawn1);
            Pawn pwnWhite2 = new Pawn(true, posWhitePawn2);
            Pawn pwnWhite3 = new Pawn(true, posWhitePawn3);
            Pawn pwnWhite4 = new Pawn(true, posWhitePawn4);
            Pawn pwnWhite5 = new Pawn(true, posWhitePawn5);
            Pawn pwnWhite6 = new Pawn(true, posWhitePawn6);
            Pawn pwnWhite7 = new Pawn(true, posWhitePawn7);
            Pawn pwnWhite8 = new Pawn(true, posWhitePawn8);
            Knight kntWhiteQKnight = new Knight(true, posWhiteQKnight);
            Knight kntWhiteKKnight = new Knight(true, posWhiteKKnight);
            Bishop bisWhiteQBishop = new Bishop(true, posWhiteQBishop);
            Bishop bisWhiteKBishop = new Bishop(true, posWhiteKBishop);
            Rook rokWhiteQRook = new Rook(true, posWhiteQRook);
            Rook rokWhiteKRook = new Rook(true, posWhiteKRook);
            Queen queWhiteQueen = new Queen(true, posWhiteQueen);
            King kngWhiteKing = new King(true, posWhiteKing);

            //black pieces
            Pawn pwnBlack1 = new Chess.Pawn(false, posBlackPawn1);
            Pawn pwnBlack2 = new Chess.Pawn(false, posBlackPawn2);
            Pawn pwnBlack3 = new Chess.Pawn(false, posBlackPawn3);
            Pawn pwnBlack4 = new Chess.Pawn(false, posBlackPawn4);
            Pawn pwnBlack5 = new Chess.Pawn(false, posBlackPawn5);
            Pawn pwnBlack6 = new Chess.Pawn(false, posBlackPawn6);
            Pawn pwnBlack7 = new Chess.Pawn(false, posBlackPawn7);
            Pawn pwnBlack8 = new Chess.Pawn(false, posBlackPawn8);
            Knight kntBlackQKnight = new Knight(false, posBlackQKnight);
            Knight kntBlackKKnight = new Knight(false, posBlackKKnight);
            Bishop bisBlackQBishop = new Bishop(false, posBlackQBishop);
            Bishop bisBlackKBishop = new Bishop(false, posBlackKBishop);
            Rook rokBlackQRook = new Rook(false, posBlackQRook);
            Rook rokBlackKRook = new Rook(false, posBlackKRook);
            Queen queBlackQueen = new Queen(false, posBlackQueen);
            King kngBlackKing = new King(false, posBlackKing);

            //Add white pieces to array
            arrWhites[0] = pwnWhite1;
            arrWhites[1] = pwnWhite2;
            arrWhites[2] = pwnWhite3;
            arrWhites[3] = pwnWhite4;
            arrWhites[4] = pwnWhite5;
            arrWhites[5] = pwnWhite6;
            arrWhites[6] = pwnWhite7;
            arrWhites[7] = pwnWhite8;
            arrWhites[8] = kntWhiteKKnight;
            arrWhites[9] = kntWhiteQKnight;
            arrWhites[10] = bisWhiteKBishop;
            arrWhites[11] = bisWhiteQBishop;
            arrWhites[12] = rokWhiteKRook;
            arrWhites[13] = rokWhiteQRook;
            arrWhites[14] = queWhiteQueen;
            arrWhites[15] = kngWhiteKing;

            //Add black pieces to array
            arrBlacks[0] = pwnBlack1;
            arrBlacks[1] = pwnBlack2;
            arrBlacks[2] = pwnBlack3;
            arrBlacks[3] = pwnBlack4;
            arrBlacks[4] = pwnBlack5;
            arrBlacks[5] = pwnBlack6;
            arrBlacks[6] = pwnBlack7;
            arrBlacks[7] = pwnBlack8;
            arrBlacks[8] = kntBlackKKnight;
            arrBlacks[9] = kntBlackQKnight;
            arrBlacks[10] = bisBlackKBishop;
            arrBlacks[11] = bisBlackQBishop;
            arrBlacks[12] = rokBlackKRook;
            arrBlacks[13] = rokBlackQRook;
            arrBlacks[14] = queBlackQueen;
            arrBlacks[15] = kngBlackKing;

            //set white pieces on board
            arrBoard[posWhitePawn1.getX(), posWhitePawn1.getY()] = pwnWhite1;
            arrBoard[posWhitePawn2.getX(), posWhitePawn2.getY()] = pwnWhite2;
            arrBoard[posWhitePawn3.getX(), posWhitePawn3.getY()] = pwnWhite3;
            arrBoard[posWhitePawn4.getX(), posWhitePawn4.getY()] = pwnWhite4;
            arrBoard[posWhitePawn5.getX(), posWhitePawn5.getY()] = pwnWhite5;
            arrBoard[posWhitePawn6.getX(), posWhitePawn6.getY()] = pwnWhite6;
            arrBoard[posWhitePawn7.getX(), posWhitePawn7.getY()] = pwnWhite7;
            arrBoard[posWhitePawn8.getX(), posWhitePawn8.getY()] = pwnWhite8;
            arrBoard[posWhiteQKnight.getX(), posWhiteQKnight.getY()] = kntWhiteQKnight;
            arrBoard[posWhiteKKnight.getX(), posWhiteKKnight.getY()] = kntWhiteKKnight;
            arrBoard[posWhiteQBishop.getX(), posWhiteQBishop.getY()] = bisWhiteQBishop;
            arrBoard[posWhiteKBishop.getX(), posWhiteKBishop.getY()] = bisWhiteKBishop;
            arrBoard[posWhiteQRook.getX(), posWhiteQRook.getY()] = rokWhiteQRook;
            arrBoard[posWhiteKRook.getX(), posWhiteKRook.getY()] = rokWhiteKRook;
            arrBoard[posWhiteQueen.getX(), posWhiteQueen.getY()] = queWhiteQueen;
            arrBoard[posWhiteKing.getX(), posWhiteKing.getY()] = kngWhiteKing;

            ////set black pieces on board
            arrBoard[posBlackPawn1.getX(), posBlackPawn1.getY()] = pwnBlack1;
            arrBoard[posBlackPawn2.getX(), posBlackPawn2.getY()] = pwnBlack2;
            arrBoard[posBlackPawn3.getX(), posBlackPawn3.getY()] = pwnBlack3;
            arrBoard[posBlackPawn4.getX(), posBlackPawn4.getY()] = pwnBlack4;
            arrBoard[posBlackPawn5.getX(), posBlackPawn5.getY()] = pwnBlack5;
            arrBoard[posBlackPawn6.getX(), posBlackPawn6.getY()] = pwnBlack6;
            arrBoard[posBlackPawn7.getX(), posBlackPawn7.getY()] = pwnBlack7;
            arrBoard[posBlackPawn8.getX(), posBlackPawn8.getY()] = pwnBlack8;
            arrBoard[posBlackQKnight.getX(), posBlackQKnight.getY()] = kntBlackQKnight;
            arrBoard[posBlackKKnight.getX(), posBlackKKnight.getY()] = kntBlackKKnight;
            arrBoard[posBlackQBishop.getX(), posBlackQBishop.getY()] = bisBlackQBishop;
            arrBoard[posBlackKBishop.getX(), posBlackKBishop.getY()] = bisBlackKBishop;
            arrBoard[posBlackQRook.getX(), posBlackQRook.getY()] = rokBlackQRook;
            arrBoard[posBlackKRook.getX(), posBlackKRook.getY()] = rokBlackKRook;
            arrBoard[posBlackQueen.getX(), posBlackQueen.getY()] = queBlackQueen;
            arrBoard[posBlackKing.getX(), posBlackKing.getY()] = kngBlackKing;


        }
    }
}
