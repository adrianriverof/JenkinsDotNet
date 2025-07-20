namespace JenkinsDotNet.Tests;

public class Tests
{
    [Test]
    public void PassingTest()
    {
        //ruteruteruteruturetruteruteru
        Assert.Pass();
    }

    [Test, Ignore("")]
    public void FailingTest()
    {
        Assert.Fail();
    }
}