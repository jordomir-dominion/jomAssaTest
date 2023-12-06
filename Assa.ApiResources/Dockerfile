#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

# Stage 1: Build the application and run tests
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src

COPY ["Assa.Domain/Assa.Domain.csproj", "Assa.Domain/"]
COPY ["Assa.Application/Assa.Application.csproj", "Assa.Application/"]
COPY ["Assa.Infrastructure.Data/Assa.Infrastructure.Data.csproj", "Assa.Infrastructure.Data/"]
COPY ["Assa.ApiResources/Assa.ApiResources.csproj", "Assa.ApiResources/"]
COPY ["Assa.Application.Test/Assa.Application.Test.csproj", "Assa.Application.Test/"]

RUN dotnet restore "Assa.ApiResources/Assa.ApiResources.csproj"

# Copy everything else and build the application
COPY . .
WORKDIR "/src"
RUN dotnet build "Assa.ApiResources/Assa.ApiResources.csproj" -c Release -o /app/build

# Run tests
RUN dotnet test "Assa.Application.Test/Assa.Application.Test.csproj"

# Stage 2: Publish the application
FROM build AS publish
RUN dotnet publish "Assa.ApiResources/Assa.ApiResources.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Stage 3: Create the final image
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Assa.ApiResources.dll"]