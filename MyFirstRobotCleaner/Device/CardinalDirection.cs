using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstRobotCleaner.Device
{


    public class CardinalDirection
    {

        public static Coordinate GetDirectionStep(Enum.Direction direction)
        {
            return mapDirectionCoordinate[direction];
        }

        private static Dictionary<Enum.Direction, Coordinate> mapDirectionCoordinate = new Dictionary<Enum.Direction, Coordinate>
        {
            //map with the cardinal with cooridnate
            {Enum.Direction.E, new Coordinate(1, 0)},
            {Enum.Direction.W, new Coordinate(-1, 0)},

            {Enum.Direction.N, new Coordinate(0, 1)},
            {Enum.Direction.S, new Coordinate(0, -1)}
        
        };




        private static Dictionary<String, Enum.Direction> mapDirectionName = new Dictionary<String, Enum.Direction>
        {
            //do the mapping from console
            {"N", Enum.Direction.N},
            {"S", Enum.Direction.S},
            {"E", Enum.Direction.E},
            {"W", Enum.Direction.W},
            //include lower case 
            {"n", Enum.Direction.N},
            {"s", Enum.Direction.S},
            {"e", Enum.Direction.E},
            {"w", Enum.Direction.W}
        };




        public static Enum.Direction GetDirection(string p)
        {
            return mapDirectionName[p];
        }
    }
}
