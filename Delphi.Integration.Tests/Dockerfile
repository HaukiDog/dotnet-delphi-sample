FROM ubuntu:22.04 as base
RUN apt update
RUN apt install -y wget apt-transport-https
RUN wget https://packages.microsoft.com/config/ubuntu/22.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
RUN dpkg -i packages-microsoft-prod.deb
RUN rm packages-microsoft-prod.deb
RUN apt install -y dotnet7

FROM base AS build
WORKDIR /src
COPY . .
RUN dotnet restore .
RUN dotnet publish Delphi.Examples.Tests/Delphi.Examples.Tests.csproj -c Linux -o /publish --no-restore

FROM base AS final
WORKDIR /test
COPY --from=build /publish .
RUN ls
RUN echo hello
ENTRYPOINT ["dotnet", "test", "Delphi.Examples.Tests.dll"]