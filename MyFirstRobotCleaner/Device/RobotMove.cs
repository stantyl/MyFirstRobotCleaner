using MyFirstRobotCleaner.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstRobotCleaner.Device
{
    public class RobotMove
    {
      private Direction direction;

        public Direction Direction
        {
            get { 
                
                return direction; 
            
            }
        }


        private int steps;
        public RobotMove(Direction direction, int steps)
        {
            this.direction = direction;
            this.steps = steps;
        }

        public int Steps
        {
            get {

                return  steps;
            
            }
        }


    }
}
