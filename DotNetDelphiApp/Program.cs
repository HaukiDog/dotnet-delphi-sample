using Delphi.Integration;
using System.Reflection;
using System.Runtime.InteropServices;

Console.Write("Enter your name: ");
var name = Console.ReadLine() ?? "whoever you are";

Assembly.GetAssembly(typeof(Delphi.Integration.Sample))!.Modules.First().GetPEKind(out var pekind, out var machine);
Console.WriteLine($"{nameof(pekind)}={pekind}");
Console.WriteLine($"{nameof(machine)}={machine}");
Console.WriteLine($"RuntimeEnvironment.GetSystemVersion()={RuntimeEnvironment.GetSystemVersion()}");
Console.WriteLine($"System.Environment.Is64BitProcess={System.Environment.Is64BitProcess}");
Console.WriteLine($"System.Environment.OSVersion.Platform={System.Environment.OSVersion.Platform}");
Console.WriteLine($"System.Environment.OSVersion.Platform={System.Environment.Version}");


Console.WriteLine($"{nameof(Sample.StringIn)}={Sample.StringIn(name)}");
Console.WriteLine($"{nameof(Sample.StringOut)}={Sample.StringOut()}");
Console.WriteLine($"{nameof(Sample.StringInOut)}={Sample.StringInOut(name)}");

Console.WriteLine($"Goodbye {name}, press enter to exit.");
_ = Console.ReadLine();
