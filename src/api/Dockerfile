FROM mcr.microsoft.com/dotnet/sdk:6.0 as build
WORKDIR /src
COPY EchoIp.csproj .
RUN dotnet restore
COPY . .
RUN dotnet publish -c Release -o /app


FROM mcr.microsoft.com/dotnet/aspnet:6.0 as runtime
ENV ASPNETCORE_URLS="http://+:5000"
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT [ "dotnet", "EchoIp.dll" ]
