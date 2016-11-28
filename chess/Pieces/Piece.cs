using System;

namespace Chess {
    /// <summary>
    /// Piece interface. Defines what a Piece must have.
    /// </summary>
    interface Piece {
        void SetPosition(Position pposPosition);

        void SetSelected(bool pblnSelected);

        void SetMoved(bool pblnMoved);

        bool IsSelected();

        //temp String, should be bool
        String IsWhite();

        bool ValidMove(Piece[,] parrBoard, Position pposMoveTo);

        String PieceType();
    }
}
