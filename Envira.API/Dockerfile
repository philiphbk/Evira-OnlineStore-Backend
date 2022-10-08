#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Envira.API/Envira.API.csproj", "Envira.API/"]
RUN dotnet restore "Envira.API/Envira.API.csproj"
COPY . .
WORKDIR "/src/Envira.API"
RUN dotnet build "Envira.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Envira.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Envira.API.dll"]