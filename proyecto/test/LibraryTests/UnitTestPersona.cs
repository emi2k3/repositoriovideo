namespace LibraryTests;
using Library;
public class Tests
{
    [SetUp]
    public void Setup()
    {
        

    }

    [TestCase(20, "16/7/2002")]
    [TestCase(19, "16/10/2002")]
    [TestCase(19, "26/9/2002")]
    public void TestAge(int age, string fecha)
    {

        DateTime fecha1 = Convert.ToDateTime(fecha);
        Persona person1 = new Persona("Damian Piriz", fecha1);
        int testAge = person1.GetAge();
        Assert.AreEqual(age, testAge);
    }
    
}