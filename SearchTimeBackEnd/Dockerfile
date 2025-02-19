# This stage is used when running from VS in fast mode (Default for Debug configuration)
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 5000

# This stage is used to build the service project
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["SearchTimeBackEnd.csproj", "."]
RUN dotnet restore "./SearchTimeBackEnd.csproj"
COPY . . 
WORKDIR "/src/."
RUN dotnet build "./SearchTimeBackEnd.csproj" -c $BUILD_CONFIGURATION -o /app/build

# This stage is used to publish the service project to be copied to the final stage
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./SearchTimeBackEnd.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# This stage is used in production or when running from VS in regular mode (Default when not using the Debug configuration)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish . 

# Pass in environment variables (Connection String, etc) when the container runs
ENV ASPNETCORE_URLS=http://+:5000

# Copy the wait-for-it script into the container
COPY wait-for-it.sh /app/wait-for-it.sh

# Make sure the wait-for-it script is executable
USER root
RUN chown root:root /app/wait-for-it.sh && chmod +x /app/wait-for-it.sh
USER app

# to-do: remove
# ENTRYPOINT ["dotnet", "SearchTimeBackEnd.dll"]

ENTRYPOINT ["/bin/bash", "-c", "/app/wait-for-it.sh db:1433 -- dotnet /app/SearchTimeBackEnd.dll"]