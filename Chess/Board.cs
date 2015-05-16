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
            Coordinates = new List<Coordinates>();
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
		public void Initialize(){
			//Initialize all pawns
			
			
		}
		#endregion
    }
}
