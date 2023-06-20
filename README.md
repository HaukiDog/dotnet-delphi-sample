# dotnet-delphi-sample

Sample dotnet code interacting with Delphi DLLs.

Exercises basic c#/Delphi interaction in win32, win64 and ubuntu linux.

## Getting started

## Prerequisites

- dotnet 7 sdk
- RAD Studio 11


### Compiling Delphi DLLs

DLLs are built from the Delphi directory and manually added to appropriate folders. Alternatively, they can be copied via:
```
copydlls.bat
```
which resides in the Delphi folder. Initial compiled copies of the DLLs are part of the repository, which is a bit unsafe.

### Running Tests

#### Windows

Set configuration to release or debug and architecture to x86. Run tests in VS, make sure architecture is set to 'auto'.

#### Win64
```
dotnet test -c Release -r win-x64
```

##### Manually
Set configuration to release or debug and architecture to AnyCPU or x64. Run tests in VS, make sure architecture is set to 'auto'.

#### Win32
```
dotnet test -c Release /p:Platform=x86
```

##### Manually
Set configuration to release or debug and architecture to x86. Run tests in VS, make sure architecture is set to 'auto'.

#### Linux64
```
dotnet test -c Linux
```

#### Ubuntu via Docker

Remove any previous containers and images.

```
docker-compose -f .\Delphi.Examples.Tests.docker-compose.yml up
```

Then...
```
docker-compose -f .\Delphi.Examples.Tests.docker-compose.yml down
```

### Running Console App

#### Win64
```
dotnet run --project DotNetDelphiApp -c Release -r win-x64
```

#### Win32
```
dotnet build DotNetDelphiApp /p:Platform=x86 -c Release --runtime win-x86
```
then manually run exe

#### Linux
```
dotnet run --project DotNetDelphiApp -c Linux
```
then manually run exe

