FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY Paises.API/Paises.API.csproj Paises.API/
RUN dotnet restore Paises.API/Paises.API.csproj
COPY . .
WORKDIR /src/Paises.API
RUN dotnet build Paises.API.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Paises.API.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Paises.API.dll"]
