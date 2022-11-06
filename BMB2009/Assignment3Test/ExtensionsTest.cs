using Assignment3;
using NUnit.Framework;

namespace Assignment3Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestOku()
    {
        Assert.AreEqual("on bir", 11.Oku());
        Assert.AreEqual("bin", 1000.Oku());
        Assert.AreEqual("bin on", 1010.Oku());
        Assert.AreEqual("bin on bir", 1011.Oku());
        Assert.AreEqual("bin yüz", 1100.Oku());
        Assert.AreEqual("bin yüz on bir", 1111.Oku());
        Assert.AreEqual("iki bin on bir", 2011.Oku());
        Assert.AreEqual("on bin", 10000.Oku());
        Assert.AreEqual("yüz bin", 100000.Oku());
        Assert.AreEqual("yüz bir bin", 101000.Oku());
        Assert.AreEqual("yüz bin yüz", 100100.Oku());
        Assert.AreEqual("yüz bin on bir", 100011.Oku());
        Assert.AreEqual("bir milyon yüz bin", 1100000.Oku());
        Assert.AreEqual("yüz milyon yüz bin", 100100000.Oku());
        Assert.AreEqual("yüz bir milyon yüz bin", 101100000.Oku());
        Assert.AreEqual("bir milyar yüz bir milyon yüz bin", 1101100000.Oku());
        Assert.AreEqual("iki milyar yüz kırk yedi milyon dört yüz seksen üç bin altı yüz kırk yedi", 2147483647.Oku());
    }
}