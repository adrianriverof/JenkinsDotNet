namespace JenkinsDotNet.Tests;

public class Tests
{
    [Test]
    public void PassingTest()
    {
        //ruterutaaaaaaaaaaeaaaaaruteruuuuuturetruteruteru
        Assert.Pass();
    }

    [Test, Ignore("")]
    public void FailingTest()
    {
        Assert.Fail();
    }

    [Test]
    public void yes()
    {
        Assert.Fail();
    }
}