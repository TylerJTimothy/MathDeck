namespace MathDeck.Core.Tests;

public class SanityTests
{
    [Fact]
    public void DeliberateFailure()
    {
        Assert.Equal(1, 2);
    }
}