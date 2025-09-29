# Build stage
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /app
COPY *.csproj ./
RUN dotnet restore
COPY . ./
RUN dotnet publish -c Release -o out

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS runtime
WORKDIR /app
COPY --from=build /app/out ./

# Set ASP.NET Core to listen on all interfaces
ENV ASPNETCORE_URLS=http://+:80

# Expose port 80
EXPOSE 80

# Start the app
ENTRYPOINT ["dotnet", "ContosoPizza.dll"]
