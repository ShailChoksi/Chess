using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Piece
    {
        #region Fields
        #endregion

        enum PieceType
        { 
            Pawn = 1,
            Rook = 2,
            Knight = 3, 
            Bishop = 4,
            Queen = 5,
            King = 6
        }
        #region Constructors
        public Piece()
        {
         
        }
        #endregion

        #region public methods

        public bool IsWhite
        {
            get;
            set;
        }

        public bool IsOnBoard
        {
            get;
            set;
        }


        public Coordinates coords
        {
            get;
            set;
        }
        #endregion

    }
}
