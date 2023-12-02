FROM docker.arvancloud.ir/mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM docker.arvancloud.ir/mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["SinaMN75Api/SinaMN75Api.csproj", "SinaMN75Api/"]
COPY ["Utilities_aspnet/Utilities_aspnet.csproj", "Utilities_aspnet/"]
RUN dotnet restore "SinaMN75Api/SinaMN75Api.csproj"
COPY . .
WORKDIR "/src/SinaMN75Api"
RUN dotnet build "SinaMN75Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SinaMN75Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SinaMN75Api.dll"]
