using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Pawn : Piece
    {
        public Pawn()
        {
            Coordinates = new Square();
        }

        public bool IsOnHomeSquare
        {
            get
            {
                if(this.PieceColor == PieceColor.Black && this.Coordinates.Rank == 7)
                {
                    return (true);
                }
                else if(this.PieceColor == PieceColor.White && this.Coordinates.Rank == 2)
                {
                    return (true);
                }
                else
                {
                    return (false);
                }
            }
        }

    }
}
