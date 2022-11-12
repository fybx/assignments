using NUnit.Framework;
using static Assignment2_2.Assignment2_2;

namespace Assignment2_2Test;

public class Tests
{
    private int[,] borders = { { 0, 86 }, { 0, 16 } };
    private int[,] collided0 = { { 1, 5 }, { 1, 4 }, { 1, 3 }, { 1, 2 }, { 1, 1 } };
    private int[,] collided1 = { { 1, 5 }, { 1, 4 }, { 1, 3 }, { 84, 15 }, { 85, 15 } };
    private int[,] collided2 = { { 40, 10 }, { 41, 10 }, { 42, 10 }, { 43, 10 }, { 43, 15 } };
    private int[,] collided3 = { { 40, 11 }, { 41, 10 }, { 42, 10 }, { 43, 10 }, { 43, 11 } };
    
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestCheckCollision()
    {
        Assert.AreEqual(true, CheckCollision(collided0));
        Assert.AreEqual(true, CheckCollision(collided1));
        Assert.AreEqual(true, CheckCollision(collided2));
        Assert.AreEqual(true, CheckCollision(collided3));
    }

    public void TestCalculateSnakeBody()
    {
        Assert.Pass();
    }
}