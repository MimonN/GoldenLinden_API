FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env
WORKDIR /app

# copy csproj and restore as distinct layers
COPY GoldenLinden_API/*.csproj ./GoldenLinden_API/
RUN dotnet restore ./GoldenLinden_API/*.csproj

# copy everything else
COPY . ./
RUN dotnet publish -c Release -o out

# build a runtime image
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=build-env /app/out .
COPY GoldenLinden_API/Resourses ./Resourses
ENTRYPOINT ["dotnet", "GoldenLinden_API.dll"]
