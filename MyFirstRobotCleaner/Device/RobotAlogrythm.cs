using MyFirstRobotCleaner.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstRobotCleaner.Device
{

    public class RobotAlogrythm 
    {
        private Coordinate currentPosition;


        private Dictionary<Coordinate, bool> cleanOffices;

        public Coordinate CurrentPosition
        {
            get
            {

                return currentPosition;
            }

            private set
            {
                currentPosition = value;
                CleanPosition();
            }
        }


        public RobotAlogrythm()
        {
            cleanOffices = new Dictionary<Coordinate, bool>();
        }


        //commands count 2
        //direction E , step 2

        public int CleaningStart(RobotStatus state)
        {

            // step 1 ask the robot to go to initial positioon
            // start cordinate 10 ,22
            GoTo(state.StartingCoordinate);

            // once the robot is the initial position
            // go to the direction sets 

            //command = 2
            foreach (var command in state.Commands)
            {
                this.Move(command.Direction, command.Steps);
            }

            // 
            return cleanOffices.Count;
        }



        public void GoTo(Coordinate position)
        {
            CurrentPosition = position;
        }

        private void CleanPosition()
        {
            cleanOffices[currentPosition] = true;
        }


        //e , 2
        public void Move(Direction dir, int steps)
        {
            Coordinate directionStep = CardinalDirection.GetDirectionStep(dir);

            //step =2
            for (int i = 0; i < steps; i++)
            {

                //cuurent.x = 10; step 11;
                //tesrt y = 22 ; y 0;
                // 

                CurrentPosition = new Coordinate(currentPosition.X + directionStep.X, currentPosition.Y + directionStep.Y);
            }
        }

  
    }


}
