using Delphi.Integration.Tests.Fixtures;
using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Xunit.Abstractions;
using Xunit.Sdk;
using static Delphi.Integration.Tests.Info;

namespace Delphi.Integration.Tests;

public class Info : IClassFixture<TraceFixture>
{
    private readonly TraceFixture _fixture;

    public Info(TraceFixture fixture)
    {
        _fixture = fixture;
    }

    [Fact]
    public void Display()
    {
        Assembly.GetAssembly(typeof(Delphi.Integration.Sample))!.Modules.First().GetPEKind(out var pekind, out var machine);
        _fixture.WriteLine($"{nameof(pekind)}={pekind}");
        _fixture.WriteLine($"{nameof(machine)}={machine}");
        _fixture.WriteLine($"RuntimeEnvironment.GetSystemVersion()={RuntimeEnvironment.GetSystemVersion()}");
        _fixture.WriteLine($"System.Environment.Is64BitProcess={System.Environment.Is64BitProcess}");
        _fixture.WriteLine($"System.Environment.OSVersion.Platform={System.Environment.OSVersion.Platform}");
        _fixture.WriteLine($"System.Environment.OSVersion.Platform={System.Environment.Version}");
    }
}
