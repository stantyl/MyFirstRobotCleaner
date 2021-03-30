using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstRobotCleaner.Device
{

        public class RobotStatus
        {
         private Coordinate startingCoordinate ;

        public Coordinate StartingCoordinate { 
            
            get { return startingCoordinate;  
            } 
        }


        private List<RobotMove> commands;

        public List<RobotMove> Commands 
                {
            
                    get { 
                        return commands; 
                        } 
        
                }


        public RobotStatus(Coordinate startingCoordinate, List<RobotMove> commands)
            {
                this.startingCoordinate = startingCoordinate;
                this.commands = commands;
            }
       
    }
}
