using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Coordinates
    {
        public Coordinates()
        {
            Rank = int.MinValue;
            File File = File.A;
        }

        int Rank
        {
            get { return Rank; }
            set {
                if (value < 1 || value > 8)
                {
                    Exception ex = new IndexOutOfRangeException();
                    throw ex;
                }
                Rank = value;
            }
        }
        enum File
        {
            A = 0, 
            B = 1,
            C = 2,
            D = 3,
            E = 4,
            F = 5,
            G = 6, 
            H = 7
        }
    }
}
