#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Assa.Domain/Assa.Domain.csproj", "Assa.Domain/"]
COPY ["Assa.Application/Assa.Application.csproj", "Assa.Application/"]
COPY ["Assa.Infrastructure.Data/Assa.Infrastructure.Data.csproj", "Assa.Infrastructure.Data/"]
COPY ["Assa.ApiResources/Assa.ApiResources.csproj", "Assa.ApiResources/"]
RUN dotnet restore "Assa.ApiResources/Assa.ApiResources.csproj"
COPY . .
WORKDIR "/src/Assa.ApiResources"
RUN dotnet build "Assa.ApiResources.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Assa.ApiResources.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Assa.ApiResources.dll"]