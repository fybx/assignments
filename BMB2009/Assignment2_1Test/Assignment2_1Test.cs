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
        Assert.AreEqual("1  1  1\n1221221", _DispCrown(2));
        Assert.AreEqual("1    1    1\n12  212  21\n12332123321", _DispCrown(3));
        Assert.AreEqual("1      1      1\n12    212    21\n123  32123  321\n123443212344321", _DispCrown(4));
    }
}