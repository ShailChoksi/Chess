using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess;

namespace Chess
{
    public class Coordinate
    {
        public Coordinate()
        {
            Rank = int.MinValue;
            File File = File.A;
        }

        public int Rank
        {
            get;
            set;
        }

        public File File { get; set; }

        public SquareColor SquareColor
        {
            get
            {
                int fileValue = (int)File + 1;
                int fileRankTotal = fileValue + Rank;

                if (fileRankTotal % 2 == 0)
                {
                    return SquareColor.Black;
                }
                else
                {
                    return SquareColor.White;
                }
            }
        }
    }
}
