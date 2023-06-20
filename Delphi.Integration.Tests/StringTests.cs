using Delphi.Integration.Tests.Fixtures;

namespace Delphi.Integration.Tests;

public class StringTests : IClassFixture<TraceFixture>
{
    private readonly TraceFixture _fixture;

    public StringTests(TraceFixture fixture)
    {
        _fixture = fixture;
    }

    [Fact]
    public void StringIn()
    {
        _fixture.WriteLine(nameof(StringIn));
        Sample.StringIn("Hello").Should().Be(5);
    }

#if LINUX
    [Fact(Skip="Not working in Linux64")]
#else
    [Fact]
#endif //Linux
    public void StringInOut()
    {
        _fixture.WriteLine(nameof(StringInOut));
        //Sample.StringInOut("Dave").Should().Be("Hello Dave");
    }

#if LINUX
    [Fact(Skip="Not working in Linux64")]
#else
    [Fact]
#endif //Linux
    public void StringOut()
    {
        _fixture.WriteLine(nameof(StringOut));
        Sample.StringOut().Should().Be("Hello");
    }

#if LINUX
    [Fact(Skip="Not working in Linux64")]
#else
    [Fact]
#endif //Linux
    public void PCharOut()
    {
        _fixture.WriteLine(nameof(PCharOut));
        Sample.PCharOut().Should().Be("Hello");
    }

    [Fact(Skip="Return values crash app")]
    public void StringReturn()
    {
        _fixture.WriteLine(nameof(StringReturn));
        Sample.StringReturn().Should().StartWith("Goodbye");
    }

    [Fact(Skip = "Return values crash app")]
    public void PCharReturn()
    {
        _fixture.WriteLine(nameof(PCharReturn));
        Sample.PCharReturn().Should().StartWith("Goodbye");
    }
}
