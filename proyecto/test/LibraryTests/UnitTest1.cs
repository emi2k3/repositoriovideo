namespace LibraryTests;
using Library;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void EsImpar3()
    {
        Paraimeter test = new Paraimeter();
        bool resultado = test.Impar(7);

        Assert.AreEqual(true, resultado);
    }
}