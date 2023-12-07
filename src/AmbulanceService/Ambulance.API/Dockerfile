#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/AmbulanceService/Ambulance.API/Ambulance.API.csproj", "src/AmbulanceService/Ambulance.API/"]
COPY ["src/AmbulanceService/Ambulance.DataAccess/Ambulance.Application.csproj", "src/AmbulanceService/Ambulance.DataAccess/"]
COPY ["src/AmbulanceService/Ambulance.Domain/Ambulance.Domain.csproj", "src/AmbulanceService/Ambulance.Domain/"]
COPY ["src/AmbulanceService/Ambulance.Infrastructure/Ambulance.Infrastructure.csproj", "src/AmbulanceService/Ambulance.Infrastructure/"]
RUN dotnet restore "./src/AmbulanceService/Ambulance.API/./Ambulance.API.csproj"
COPY . .
WORKDIR "/src/src/AmbulanceService/Ambulance.API"
RUN dotnet build "./Ambulance.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Ambulance.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Ambulance.API.dll"]