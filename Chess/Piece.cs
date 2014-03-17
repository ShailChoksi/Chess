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
        public enum Type 
        {
            Pawn = 1,
            Rook = 2,
            Knight = 3,
            Bishop = 4,
            Queen = 5,
            King = 6
        }
        

        #endregion

        #region Constructors
        public Piece()
        {
            IsWhite = true;
            IsOnBoard = true;
            Coordinates Coordinates = new Coordinates();
            Type Type = Piece.Type.Pawn;
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


        public Coordinates Coordinates
        {
            get;
            set;
        }
        #endregion

    }
}
