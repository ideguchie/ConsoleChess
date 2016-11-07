using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess {
    /// <summary>
    /// Board Object.
    /// </summary>
    class Board {
        private Piece[,] arrBoard;
        private bool blnWhiteTurn;

        //Constructor
        public Board() {
            arrBoard = new Piece[8, 8];
            blnWhiteTurn = true;

            SetBoard();
        }

        #region "Text Based Functions"
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

        //public Piece SelectPiece(Position pposPosition)
        //{
        //    if(arrBoard[pposPosition.getX(), pposPosition.getY()] != null)
        //    {
        //        arrBoard[pposPosition.getX(), pposPosition.getY()].SetSelected(true);
        //        PrintBoard();
        //        //return arrBoard[pintPosition.getX(), pintPosition.getY()];
        //    }

        //    return null;
        //}

        //Moves a given piece from one space to another if the move is valid. Returns true if a move was made.
        public bool SetPiece(Position pposPosition, Position pposMoveTo) {
            if (arrBoard[pposPosition.getX(), pposPosition.getY()].ValidMove(arrBoard, pposMoveTo)) {
                arrBoard[pposMoveTo.getX(), pposMoveTo.getY()] = null;
                arrBoard[pposPosition.getX(), pposPosition.getY()].SetPosition(pposMoveTo);
                arrBoard[pposMoveTo.getX(), pposMoveTo.getY()] = arrBoard[pposPosition.getX(), pposPosition.getY()];
                arrBoard[pposPosition.getX(), pposPosition.getY()] = null;
                arrBoard[pposMoveTo.getX(), pposMoveTo.getY()].SetMoved(true);
                CheckPromotion(pposMoveTo, arrBoard[pposMoveTo.getX(), pposMoveTo.getY()].IsWhite() == "W");
                EnPassant(pposPosition, pposMoveTo);
                blnWhiteTurn = !blnWhiteTurn;
                return true;
            }
            return false;
        }

        //Sets a piece on the board. (Used for promotion)
        private void CheckPromotion(Position pposPosition, bool pblnIsWhite) {
            if (pposPosition.getY() == 0 || pposPosition.getY() == 7) {
                if (arrBoard[pposPosition.getX(), pposPosition.getY()].PieceType() == "P") {
                    string strPieceType = "";
                    ChoosePiece(ref strPieceType);
                    if (pblnIsWhite) {
                        arrBoard[pposPosition.getX(), pposPosition.getY()] = null;
                        switch (strPieceType) {
                            //    case "Rook":
                            //        arrBoard[pposPosition.getX(), pposPosition.getY()] = new Rook();
                            //        break;
                            case "Knight":
                                arrBoard[pposPosition.getX(), pposPosition.getY()] = new Knight(pblnIsWhite, pposPosition);
                                break;
                                //    case "Bishop":
                                //        arrBoard[pposPosition.getX(), pposPosition.getY()] = new Bishop();
                                //        break;
                                //    default:
                                //        arrBoard[pposPosition.getX(), pposPosition.getY()] = new Queen();
                                //        break;
                        }
                    } else {
                        arrBoard[pposPosition.getX(), pposPosition.getY()] = null;
                        switch (strPieceType) {
                            //    case "Rook":
                            //        arrBoard[pposPosition.getX(), pposPosition.getY()] = new Rook();
                            //        break;
                            case "Knight":
                                arrBoard[pposPosition.getX(), pposPosition.getY()] = new Knight(pblnIsWhite, pposPosition);
                                break;
                                //    case "Bishop":
                                //        arrBoard[pposPosition.getX(), pposPosition.getY()] = new Bishop();
                                //        break;
                                //    default:
                                //        arrBoard[pposPosition.getX(), pposPosition.getY()] = new Queen();
                                //        break;
                        }
                    }
                }
            }
        }

        //Invalidates old En Passant, checks for new En Passant
        private void EnPassant(Position pposPosition, Position pposMoveTo) {
            //if it was just whites move, invalidate white en passant
            if (blnWhiteTurn) {
                for (int y = 0; y < 8; y++) {
                    for (int x = 0; x < 8; x++) {
                        if (arrBoard[x, y] != null && arrBoard[x, y].PieceType() == "P" && arrBoard[x, y].IsWhite() == "W") {
                            CPawn(arrBoard[x, y], arrBoard[x, y].IsWhite() == "W", new Position(x, y)).SetEnPassant("");
                        }
                    }
                }
            } else {
                for (int y = 0; y < 8; y++) {
                    for (int x = 0; x < 8; x++) {
                        if (arrBoard[x, y] != null && arrBoard[x, y].PieceType() == "P" && arrBoard[x, y].IsWhite() != "W") {
                            CPawn(arrBoard[x, y], arrBoard[x, y].IsWhite() == "W", new Position(x, y)).SetEnPassant("");
                        }
                    }
                }
            }
            //check last move for en passant
            if (arrBoard[pposMoveTo.getX(), pposMoveTo.getY()].PieceType() == "P") {
                if (arrBoard[pposMoveTo.getX(), pposMoveTo.getY()].IsWhite() == "W") {
                    if ((pposPosition.getY() - pposMoveTo.getY()) == 2) {
                        if (pposMoveTo.getX() - 1 >= 0 && arrBoard[pposMoveTo.getX() - 1, pposMoveTo.getY()] != null) {
                            CPawn(arrBoard[pposMoveTo.getX() - 1, pposMoveTo.getY()],
                                arrBoard[pposMoveTo.getX() - 1, pposMoveTo.getY()].IsWhite() == "W",
                                new Position(pposMoveTo.getX() - 1, pposMoveTo.getY())).SetEnPassant("left");
                        }
                        if (pposMoveTo.getX() + 1 < 8 && arrBoard[pposMoveTo.getX() + 1, pposMoveTo.getY()] != null) {
                            CPawn(arrBoard[pposMoveTo.getX() + 1, pposMoveTo.getY()],
                                arrBoard[pposMoveTo.getX() + 1, pposMoveTo.getY()].IsWhite() == "W",
                                new Position(pposMoveTo.getX() + 1, pposMoveTo.getY())).SetEnPassant("right");
                        }
                    }
                } else {
                    if ((pposMoveTo.getY() - pposPosition.getY()) == 2) {
                        if (pposMoveTo.getX() - 1 >= 0 && arrBoard[pposMoveTo.getX() - 1, pposMoveTo.getY()] != null) {
                            CPawn(arrBoard[pposMoveTo.getX() - 1, pposMoveTo.getY()],
                                arrBoard[pposMoveTo.getX() - 1, pposMoveTo.getY()].IsWhite() == "W",
                                new Position(pposMoveTo.getX() - 1, pposMoveTo.getY())).SetEnPassant("left");
                        }
                        if (pposMoveTo.getX() + 1 < 8 && arrBoard[pposMoveTo.getX() + 1, pposMoveTo.getY()] != null) {
                            CPawn(arrBoard[pposMoveTo.getX() + 1, pposMoveTo.getY()],
                                arrBoard[pposMoveTo.getX() + 1, pposMoveTo.getY()].IsWhite() == "W",
                                new Position(pposMoveTo.getX() + 1, pposMoveTo.getY())).SetEnPassant("right");
                        }
                    }
                }
            }
        }

        //Opens modal window for choosing promotion piece
        private void ChoosePiece(ref string pstrPieceType) {
            bool valid = false;
            while (!valid) {
                if(Console.ReadLine() == "k") {
                    valid = true;
                    pstrPieceType = "Knight";
                }
            }
            //return "fail";
        }

        //Cast Piece to Pawn
        private Pawn CPawn(Piece ppcePiece, bool pblnIsWhite, Position pposPosition) {
            Pawn castPawn = new Pawn(pblnIsWhite, pposPosition);
            return castPawn;
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

            //set black pieces on board
            arrBoard[posBlackPawn1.getX(), posBlackPawn1.getY()] = pwnBlack1;
            arrBoard[posBlackPawn2.getX(), posBlackPawn2.getY()] = pwnBlack2;
            arrBoard[posBlackPawn3.getX(), posBlackPawn3.getY()] = pwnBlack3;
            arrBoard[posBlackPawn4.getX(), posBlackPawn4.getY()] = pwnBlack4;
            arrBoard[posBlackPawn5.getX(), posBlackPawn5.getY()] = pwnBlack5;
            arrBoard[posBlackPawn6.getX(), posBlackPawn6.getY()] = pwnBlack6;
            arrBoard[posBlackPawn7.getX(), posBlackPawn7.getY()] = pwnBlack7;
            arrBoard[posBlackPawn8.getX(), posBlackPawn8.getY()] = pwnBlack8;
            arrBoard[posBlackQKnight.getX(), posBlackQKnight.getY()] = kntBlackQKnight;
        }
    }
}
