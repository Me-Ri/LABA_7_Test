using LABA2;
using NUnit.Framework.Interfaces;
namespace Tests;

public class Tests
{
    private Taylor obj;
    [SetUp]
    public void Setup()
    {
        obj = new Taylor();
    }

    [TestCase(0.2583, -0.1)]//firstEquation
    [TestCase(0.0876, -0.2)]
    [TestCase(-1, 0)]
    [TestCase(-2, -0.3)]

    [TestCase(0.255342, 0.5)]//secondEquation
    [TestCase(-1, 50)]
    [TestCase(-2.18504, 4)]
    public void Equation(double res, double x)
    {
        Assert.AreEqual(res, obj.fX(x), 0.0001);
    }

    [TestCase(-1, -3)]
    [TestCase(0.0876, -0.2)]
    [TestCase(-1, 0)]
    [TestCase(-2, -0.3)]
    public void firstEquation(double res, double x)
    {
        Assert.AreEqual(res, obj.firstEquation(x), 0.0001);
    }

    [TestCase(0.255342, 0.5)]
    [TestCase(-1, 50)]
    [TestCase(-1, -4)]
    [TestCase(-2.18504, 4)]
    public void secondEquation(double res, double x)
    {
        Assert.AreEqual(res, obj.secondEquation(x), 0.0001);
    }


    [TestCase(0.995004, 0.1)]
    [TestCase(0.995004, -0.1)]
    [TestCase(-0.653644, 4)]
    [TestCase(-0.653644, -4)]
    [TestCase(-1, -5)]
    [TestCase(-1, 100)]
    public void Cos(double res, double x)
    {
        Assert.AreEqual(res, obj.Cos(x), 0.0001);
    }

    [TestCase(0.0998334, 0.1)]
    [TestCase(-0.0998334, -0.1)]
    [TestCase(-0.756802, 4)]
    [TestCase(0.756802, -4)]
    [TestCase(-1, -6)]
    [TestCase(-1, 100)]
    public void Sin(double res, double x)
    {
        Assert.AreEqual(res, obj.Sin(x), 0.0001);
    }

    [TestCase(-2.30259, 0.1)]
    [TestCase(0.641854, 1.9)]
    [TestCase(-1, 5)]
    [TestCase(-1, -3)]
    public void Log(double res, double x)
    {
        Assert.AreEqual(res, obj.Log(x), 0.0001);
    }

    [TestCase(1, 1, 2)]
    [TestCase(1, 123, 0)]
    [TestCase(-1, 20, -2)]
    [TestCase(-100000, -10, 5)]
    public void Pow(double res, double x, int n)
    {
        Assert.AreEqual(res, obj.Pow(x, n), 0.0001);
    }

    [TestCase(2432902008176640000, 20)]
    [TestCase(1, 0)]
    [TestCase(-1, -1)]
    [TestCase(-1, 21)]
    public void Factorial(double res, long x)
    {
        Assert.AreEqual(res, obj.Factorial(x), 0.0001);
    }

    [TestCase(1, 1)]
    [TestCase(1, -1)]
    [TestCase(100.5, -100.5)]
    [TestCase(10000, 10000)]
    public void Abs(double res, double x)
    {
        Assert.AreEqual(res, obj.Abs(x), 0.0001);
    }

    [TestCase(5, 25)]
    [TestCase(-1, -1)]
    [TestCase(3.240370, 10.5)]
    [TestCase(10, 100)]
    public void Sqrt(double res, double x)
    {
        Assert.AreEqual(res, obj.Sqrt(x), 0.0001);
    }

    //Проверка подставления в "x" в основных уравнениях вместо числа другой метод 

    [Test]
    public void SinfirstEquation()
    {
        Assert.AreEqual(0.0894, obj.firstEquation(obj.Sin(-0.201)), 0.001);
    }

    [Test]
    public void CosfirstEquation()
    {
        Assert.AreEqual(0.0894, obj.firstEquation(obj.Cos(1.772)), 0.001);
    }

    [Test]
    public void LogfirstEquation()
    {
        Assert.AreEqual(0.0825, obj.firstEquation(obj.Log(0.818)), 0.001);
    }

    [Test]
    public void SinsecondEquation()
    {
        Assert.AreEqual(0.2554, obj.secondEquation(obj.Sin(0.5236)), 0.001);
    }

    [Test]
    public void CossecondEquation()
    {
        Assert.AreEqual(0.2554, obj.secondEquation(obj.Cos(1.0472)), 0.001);
    }

    [Test]
    public void LogsecondEquation()
    {
        Assert.AreEqual(0.2554, obj.secondEquation(obj.Log(1.6487)), 0.001);
    }

    [Test]
    public void fXfirstEquation()
    {
        Assert.AreEqual(0.129, obj.fX(obj.firstEquation(-0.1)), 0.001);
    }

    [Test]
    public void fXsecondEquation()
    {
        Assert.AreEqual(0.129, obj.fX(obj.secondEquation(0.5)), 0.001);
    }

}