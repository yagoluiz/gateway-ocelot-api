FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY Estados.API/Estados.API.csproj Estados.API/
RUN dotnet restore Estados.API/Estados.API.csproj
COPY . .
WORKDIR /src/Estados.API
RUN dotnet build Estados.API.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Estados.API.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Estados.API.dll"]
