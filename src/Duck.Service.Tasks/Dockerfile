#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
USER $APP_UID
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Duck.Service.Tasks/Duck.Service.Tasks.csproj", "Duck.Service.Tasks/"]
RUN dotnet restore "./Duck.Service.Tasks/./Duck.Service.Tasks.csproj"
COPY . .
WORKDIR "/src/Duck.Service.Tasks"
RUN dotnet build "./Duck.Service.Tasks.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "./Duck.Service.Tasks.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Duck.Service.Tasks.dll"]