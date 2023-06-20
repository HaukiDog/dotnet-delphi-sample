using Delphi.Integration.Tests.Fixtures;

namespace Delphi.Integration.Tests;

public class BooleanTests : IClassFixture<TraceFixture>
{
    private readonly TraceFixture _fixture;

    public BooleanTests(TraceFixture fixture)
    {
        _fixture = fixture;
    }

    [Fact]
    public void Boolean()
    {
        _fixture.WriteLine(nameof(Boolean));

        Sample.Negate(false).Should().BeTrue();
    }
}
