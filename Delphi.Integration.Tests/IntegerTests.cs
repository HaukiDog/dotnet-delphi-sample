using Delphi.Integration.Tests.Fixtures;

namespace Delphi.Integration.Tests;

public class IntegerTests : IClassFixture<TraceFixture>
{
    private readonly TraceFixture _fixture;

    public IntegerTests(TraceFixture fixture)
    {
        _fixture = fixture;
    }

    [Fact]
    public void Integer()
    {
        _fixture.WriteLine(nameof(Integer));
        Sample.Multiply(2, 3).Should().Be(6);
    }

    [Fact]
    public void IntegerArray()
    {
        _fixture.WriteLine(nameof(IntegerArray));
        Sample.Total(new int[] { 1, 2, 3, 4 }).Should().Be(10);
    }
}
