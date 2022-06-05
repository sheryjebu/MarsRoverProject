using System;
namespace MarsRoverProject
{

	public class Rover
	{
		public int x;
		public int y;
		public string direction;
		public string CurrentLocation { get; private set; }
		//public string RoverID { get; private set; }
		public Rover(String currentLocation)//1 2 N
		{
			Int32.TryParse(currentLocation.Split(" ")[0], out x);
			Int32.TryParse(currentLocation.Split(" ")[1], out y);
			direction = currentLocation.Split(" ")[2];
			//RoverID = roverID;
			CurrentLocation = currentLocation;
		}

		public void SpinLeft()
		{
			switch (direction)
			{
				case "N":
					direction = "W";
					break;
				case "E":
					direction = "N";
					break;
				case "W":
					direction = "S";
					break;
				case "S":
					direction = "E";
					break;
				default:
					direction = "Invalid direction";
					break;
			}
		}

		public void SpinRight()
		{
			switch (direction)
			{
				case "N":
					direction = "E";
					break;
				case "E":
					direction = "S";
					break;
				case "W":
					direction = "N";
					break;
				case "S":
					direction = "E";
					break;
				default:
					direction = "Invalid direction";
					break;
			}
		}
		public void MoveForward()
		{
			switch (direction)
			{
				case "N":
					y += 1;
					break;
				case "E":
					x += 1;
					break;
				case "S":
					y -= 1;
					break;
				case "W":
					x -= 1;
					break;
				default:
					direction = "Invalid direction";
					break;
			}
		}
	}
}




