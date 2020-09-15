FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Heartart/Heartart.csproj", "Heartart/"]

RUN dotnet restore "Heartart/Heartart.csproj"
COPY . .
WORKDIR "/src/Heartart"
RUN dotnet build "Heartart.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Heartart.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Heartart.dll"]