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
        private bool _isWhite = true;
        private bool _isOnBoard = true;
        PieceType _pieceType;
        Coordinates _Coordinates;
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
        public Piece Piece
        {
         
        }
        #endregion

        #region public methods

        public bool isWhite
        {
            get { return _isWhite; }
            set { _isWhite = value; }
        }

        public bool isOnBoard
        {
            get { return _isOnBoard; }
            set { _isOnBoard = value; }
        }

        public PieceType pieceType
        {
            get { return _pieceType; }
            set { _pieceType = value; }
        }

        public Coordinates Coordinates
        {
            get { return _Coordinates; }
            set { _Coordinates = value; }
        }
        #endregion

    }
}
