namespace JenkinsDotNet.Tests;

public class Tests
{
    [Test]
    public void PassingTest()
    {
        //ruteruteaaaaaruteruturetruteruteru
        Assert.Pass();
    }

    [Test, Ignore("")]
    public void FailingTest()
    {
        Assert.Fail();
    }
}