FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Somerton/Somerton.csproj", "Somerton/"]

RUN dotnet restore "Somerton/Somerton.csproj"
COPY . .
WORKDIR "/src/Somerton"
RUN dotnet build "Somerton.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Somerton.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Somerton.dll"]