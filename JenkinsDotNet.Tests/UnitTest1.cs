namespace JenkinsDotNet.Tests;

public class Tests
{
    [Test]
    public void PassingTest()
    {
        Assert.Pass();
    }

    //[Test, Ignore("")]
    [Test]
    public void FailingTest()
    {//rutorunorutno
        Assert.Fail();
    }
    
    // comment filler
}