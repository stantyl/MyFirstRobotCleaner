
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstRobotCleaner.Device;

namespace MyFirstRobotCleaner.IO
{
    public class ParseConsoleInputs
    {

        public RobotStatus GetCommands()
        {

            
            int amountOfCommands = this.GetAmountOfCommands();


           
            Coordinate startingCoordinate = this.GetStartingCoordinate();




            // get Moves ex : E 2 , N 1 
            // like in exemple if amount is 2  than we need to have 2 commands  and E 2 , N 1 

            List<RobotMove> lstmoves = new List<RobotMove>();

            while (lstmoves.Count < amountOfCommands)
            {
                lstmoves.Add(this.GetMoves());
            }
  
            RobotStatus state = new RobotStatus(startingCoordinate, lstmoves);

            return state;
        }






        //Step1
        public int GetAmountOfCommands()
        {
            return int.Parse(Console.ReadLine());
        }

        //step 2 ex : 10 22
        public Coordinate GetStartingCoordinate()
        {
            
            string line = Console.ReadLine();

            string[] coordinates = line.Split(' ');

            int x = int.Parse(coordinates[0]);

            int y = int.Parse(coordinates[1]);

         // return 10 22
            return new Coordinate(x, y);
        }


        
        // parse Moves from the command line
        public RobotMove GetMoves()
        {
            string line = Console.ReadLine();

            string[] tmp = line.Split(' ');

            return new RobotMove(CardinalDirection.GetDirection(tmp[0]), int.Parse(tmp[1]));
        }

       



   
    }
}
