namespace JenkinsDotNet.Tests;

public class Tests
{
    [Test]
    public void PassingTest()
    {
        //ruteruteruteru
        Assert.Pass();
    }

    [Test, Ignore("")]
    public void FailingTest()
    {
        Assert.Fail();
    }
}