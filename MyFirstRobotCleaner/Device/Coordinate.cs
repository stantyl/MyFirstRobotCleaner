 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstRobotCleaner.Device
{

    public class Coordinate

    {
        public override int GetHashCode()
        {
            return pair.GetHashCode();
        }   

   

        private Tuple<int, int> pair;


        // create a pair of cordinate via Tuple class for pairing
        public Coordinate(int x, int y)
        {
            pair = new Tuple<int, int>(x, y);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Coordinate coord = (Coordinate)obj;

            return this.pair.Equals(coord.pair);
        }

        public int Y
        {
            get
            {

                return pair.Item2;
            }
        }

        public int X
        {
            get
            {
                return pair.Item1;
            }
        }

    }

}
