using System;
namespace MarsRoverProject
{
    public class MissionControl : Rover
    {
         public string AreaOfCoverage { get; private set; }
        public MissionControl(string areaOfCoverage) : base(currentLocation: "1 2 N")
        {
            AreaOfCoverage = areaOfCoverage;
        }

        public void MoveTo (string commandToRover)//LMLMLMLMM
        {
            char[] commands = commandToRover.ToCharArray();
            for (int i =0; i < commands.Length; i++)
            {
                switch (commands[i])
                {
                    case 'L':
                        SpinLeft();
                        break;
                    case 'R':
                        SpinRight();
                        break;
                    case 'M':
                        MoveForward();
                        break;
                    default:
                        Console.WriteLine("Invalid Command");
                        break;

                }
            }
        }



    }
}

