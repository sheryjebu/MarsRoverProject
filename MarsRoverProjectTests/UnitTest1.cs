using MarsRoverProject;
namespace MarsRoverProjectTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
      
    }

    [Test]
    public void RoverToSpinLeftFrom12N()
    {
        //arrange
        Rover rover = new Rover("1 2 N");
        //act
        rover.SpinLeft();
        //assert
        Assert.AreEqual("W",rover.direction);
    }

    [Test]
    public void RoverToSpinRightFrom12N()
    {
        //arrange
        Rover rover = new Rover("1 2 N");
        //act
        rover.SpinRight();
        //assert
        Assert.AreEqual("E", rover.direction);
    }

    [Test]
    public void RoverToMoveForwardOneStepFrom12N()
    {
        //arrange
        Rover rover = new Rover("1 2 S");
        //act
        rover.MoveForward();
        //assert
        Assert.AreEqual(1, rover.y);
    }

    [Test]
    public void CommandRoverToMoveAndGetFinalCoordiantes()
    {
        //arrange
        MissionControl missionControl = new MissionControl( "(5,5)"); 
        //act
        missionControl.MoveTo("LMLMLMLMM");
        //assert
        Assert.AreEqual("1 3 N", missionControl.x + " " + missionControl.y + " " + missionControl.direction);
    }
}