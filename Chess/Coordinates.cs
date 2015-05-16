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

        public int Rank
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

        public File File { get; set; }
    }
}
