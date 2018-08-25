FROM microsoft/dotnet:2.1-runtime AS base
WORKDIR /app

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY thetime.csproj thetime/
RUN dotnet restore thetime/thetime.csproj
COPY . .
WORKDIR /src/thetime
RUN dotnet build thetime.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish thetime.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "thetime.dll"]
