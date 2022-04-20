using Xunit;
using Xunit.Abstractions;

namespace CliFx.Tests;

public class Specs
{    
    [Fact]
    public void Throws()
    {
        Assert.True(1 == 2);
    }
}
