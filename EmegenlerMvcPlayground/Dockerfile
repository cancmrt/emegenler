#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["EmegenlerMvcPlayground/EmegenlerMvcPlayground.csproj", "EmegenlerMvcPlayground/"]
COPY ["Guard.Emegenler/Guard.Emegenler.csproj", "Guard.Emegenler/"]
RUN dotnet restore "EmegenlerMvcPlayground/EmegenlerMvcPlayground.csproj"
COPY . .
WORKDIR "/src/EmegenlerMvcPlayground"
RUN dotnet build "EmegenlerMvcPlayground.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "EmegenlerMvcPlayground.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EmegenlerMvcPlayground.dll"]