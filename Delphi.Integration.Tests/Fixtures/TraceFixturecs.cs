using Xunit.Abstractions;
using Xunit.Sdk;

namespace Delphi.Integration.Tests.Fixtures;

public class TraceFixture
{
    private readonly IMessageSink _diagnosticMessageSink;

    public TraceFixture(IMessageSink diagnosticMessageSink)
    {
        _diagnosticMessageSink = diagnosticMessageSink;
    }

    public void WriteLine(string message)
    {
        _diagnosticMessageSink.OnMessage(new DiagnosticMessage(message));
    }
}
