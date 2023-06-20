# sample-console-app

Sample console app interacting with Delphi DLLs.

Exercises basic c#/Delphi interaction in win32, win64 and ubuntu linux.

## Getting started

### Compiling Delphi DLLs

The project depends on the 'sample-delphi-dll' repository. DLLs are built in Delphi and manually added to appropriate folders.
For information on how to recreate DLLs see that repository.

docker-compose -f docker-compose.testproject1.yml up -d --build

### Running Tests

#### Win32

Set configuration to release or debug and architecture to x86. Run tests in VS, make sure architecture is set to 'auto'.

#### Win64

Set configuration to release or debug and architecture to AnyCPU or x64. Run tests in VS, make sure architecture is set to 'auto'.

#### Ubuntu via Docker

Remove any previous containers and images.

```
docker-compose -f .\Delphi.Examples.Tests.docker-compose.yml up
```

Then...
```
docker-compose -f .\Delphi.Examples.Tests.docker-compose.yml down
```