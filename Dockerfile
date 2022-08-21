# Build Stage
FROM mcr.microsoft.com/dotnet/sdk:6.0-focal as build
WORKDIR /source
COPY . .
RUN dotnet restore "./LabApi-01.csproj" --disable-parallel
RUN dotnet publish "./LabApi-01.csproj" -c Release -o /app --no-restore

# Serve Stage
FROM mcr.microsoft.com/dotnet/aspnet:6.0-focal
WORKDIR /app
COPY --from=build /app ./

EXPOSE 5000

ENTRYPOINT ["dotnet", "LabApi-01.dll"]