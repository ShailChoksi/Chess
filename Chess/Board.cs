using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Board
    {
		#region Constructor
		public Board()
		{
			Pieces = new List<Piece>();
		}
		#endregion
		
		#region Fields
		public List<Piece> Pieces {
			get; 
			set;
		}
		
		public List<Coordinates> Coordinates
		{
			get; 
			set;
		}
		#endregion
		
		#region Public Methods
		public Initialize(){
			//Initialize all pawns
			for(int j = 0; j < 2; j++)
			{
				int rank = j == 0 ? 2 : 7;
				
				foreach(File file in Enum.GetValues(typeof(File)))
				{
					Piece pawn = new Piece();
					pawn.Coordinates.File = file;
					pawn.Coordinates.Rank = rank;
					pawn.IsWhite = rank == 2 ? true: false;
					
					Pieces.Add(pawn);
				}
			}
			
			Piece rook = new Piece();
			rook.Coordinates.File = File.A;
			rook.Coordinates.Rank = 1;
			rook.IsWhite = true;
			Pieces.Add(rook);
			
			rook = new Piece();
			rook.Coordinates.File = File.H;
			rook.Coordinates.Rank = 1;
			rook.IsWhite = true;
			Pieces.Add(rook);
			
			rook = new Piece();
			rook.Coordinates.File = File.A;
			rook.Coordinates.Rank = 8;
			rook.IsWhite = false;
			Pieces.Add(rook);
			
			rook = new Piece();
			rook.Coordinates.File = File.H;
			rook.Coordinates.Rank = 8;
			rook.IsWhite = false;
			Pieces.Add(rook);
			
			
		}
		#endregion
    }
}
