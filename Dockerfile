# Build Stage
FROM mcr.microsoft.com/dotnet/sdk:10.0-preview AS build
WORKDIR /src

# Copy solution and project files first for better caching
COPY ["MyDentist.sln", "./"]
COPY ["src/MyDentist.Web/MyDentist.Web.csproj", "src/MyDentist.Web/"]
COPY ["src/MyDentist.Core/MyDentist.Core.csproj", "src/MyDentist.Core/"]
COPY ["src/MyDentist.Infrastructure/MyDentist.Infrastructure.csproj", "src/MyDentist.Infrastructure/"]
COPY ["tests/MyDentist.Tests/MyDentist.Tests.csproj", "tests/MyDentist.Tests/"]

# Restore dependencies for the entire solution
RUN dotnet restore

# Copy the rest of the source code
COPY . .

# Build and Publish the Web project
WORKDIR "/src/src/MyDentist.Web"
RUN dotnet publish "MyDentist.Web.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Runtime Stage
FROM mcr.microsoft.com/dotnet/aspnet:10.0-preview AS final
WORKDIR /app
EXPOSE 10000
ENV ASPNETCORE_URLS=http://+:10000

# Copy the published application
COPY --from=build /app/publish .

# Define entry point
ENTRYPOINT ["dotnet", "MyDentist.Web.dll"]
