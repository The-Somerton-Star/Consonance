FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Pod/Pod.csproj", "Pod/"]

RUN dotnet restore "Pod/Pod.csproj"
COPY . .
WORKDIR "/src/Pod"
RUN dotnet build "Pod.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Pod.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Pod.dll"]