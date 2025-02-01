# Etapa base: Imagem do .NET runtime para execução
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Etapa de build: SDK do .NET para compilar a aplicação
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["ProjetoPosDocker/ProjetoPosDocker.csproj", "ProjetoPosDocker/"]
RUN dotnet restore "./ProjetoPosDocker/Projeto Pos Docker.csproj" -c $BUILD_CONFIGURATION
COPY . .
WORKDIR "/src/ProjetoPosDocker"
RUN dotnet build "./ProjetoPosDocker.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Etapa de publicação: Publica a aplicação para ser copiada para a etapa final
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./ProjetoPosDocker.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Etapa final: Copia os arquivos para a imagem base
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ProjetoPosDocker.dll"]
