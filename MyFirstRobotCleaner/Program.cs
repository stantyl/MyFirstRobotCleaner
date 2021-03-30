
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstRobotCleaner.IO;
using MyFirstRobotCleaner.Device;


namespace MyFirstRobotCleaner
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                // get Inputs from the console

                ParseConsoleInputs reader = new ParseConsoleInputs();
                RobotStatus status = reader.GetCommands();



                // run the robot
                RobotAlogrythm robot = new RobotAlogrythm();
               string  placesClean = robot.CleaningStart(status).ToString();


                // show result
                Console.WriteLine("Cleaned : " + placesClean);



            }
            catch( Exception e)
            {
                //tmp testing purpose 
              Console.WriteLine(e.InnerException);
            }



                Console.ReadLine();



        }
    }
}
