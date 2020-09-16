FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["ECO/ECO.csproj", "ECO/"]

RUN dotnet restore "ECO/ECO.csproj"
COPY . .
WORKDIR "/src/ECO"
RUN dotnet build "ECO.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ECO.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ECO.dll"]