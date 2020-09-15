FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["ECOcloud/ECOcloud.csproj", "ECOcloud/"]

RUN dotnet restore "ECOcloud/ECOcloud.csproj"
COPY . .
WORKDIR "/src/ECOcloud"
RUN dotnet build "ECOcloud.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ECOcloud.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ECOcloud.dll"]