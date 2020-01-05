FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Docker.WebApi/Docker.WebApi.csproj", "Docker.WebApi/"]
RUN dotnet restore "Docker.WebApi/Docker.WebApi.csproj"
COPY . .
WORKDIR "/src/Docker.WebApi"
RUN dotnet build "Docker.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Docker.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Docker.WebApi.dll"]