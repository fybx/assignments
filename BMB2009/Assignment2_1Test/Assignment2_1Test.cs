using NUnit.Framework;
using static Assignment2_1.Assignment2_1;
namespace Assignment2_1Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    // ReSharper disable once IdentifierTypo
    public void TestDispCrown()
    {
        Assert.AreEqual("1  1  1" +
                        "1221221", DispCrown(2));
        Assert.AreEqual("1    1    1" +
                        "12  212  21" +
                        "12332123321", DispCrown(3));
        Assert.AreEqual("1      1      1" +
                        "12    212    21" +
                        "123  32123  321" +
                        "123443212344321", DispCrown(4));
    }
}