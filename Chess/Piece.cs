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

        #region Constructors
        public Piece()
        {
            IsWhite = true;
            IsOnBoard = true;
            Coordinates Coordinates = new Coordinates();
            PieceType P = PieceType.Pawn;
        }
        #endregion

        #region public methods

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

        public enum PieceType
        {
            Pawn = 1,
            Rook = 2,
            Knight = 3,
            Bishop = 4,
            Queen = 5,
            King = 6
        }
		
		public enum PieceColor
		{
			White = 1, 
			Black = 2
		}
		
		bool IsPinned { get; set;}
		
        #endregion
		
		#region Public methods
		public bool MoveTo(Coordinates Coordinates, Board board)
		{
			bool hasHoved = false;
			
			If(IsPinned = false  && IsOnBoard == true)
			{
				
			}
			
			return (hasMoved);
		}
		#endregion

    }
}
