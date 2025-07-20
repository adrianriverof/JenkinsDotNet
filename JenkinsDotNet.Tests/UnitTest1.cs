namespace JenkinsDotNet.Tests;

public class Tests
{
    [Test]
    public void PassingTest()
    {
        //ruterutaaaaaaaaaaeaaaaaruteruturetruteruteru
        Assert.Pass();
    }

    [Test, Ignore("")]
    public void FailingTest()
    {
        Assert.Fail();
    }
}