using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    /// <summary>
    /// Piece interface. Defines what a Piece must have.
    /// </summary>
    interface Piece
    {
        void SetPosition(Position pposPosition);

        void SetSelected(bool pblnSelected);

        bool IsSelected();

        //temp String, should be bool
        String IsWhite();

        bool ValidMove(Piece[,] parrBoard, Position pposPosition);

        String PieceType();
    }
}
