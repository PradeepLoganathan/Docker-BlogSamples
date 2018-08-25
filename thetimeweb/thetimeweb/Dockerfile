FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY thetimeweb.csproj thetimeweb/
RUN dotnet restore thetimeweb/thetimeweb.csproj
COPY . thetimeweb/
WORKDIR /src/thetimeweb
RUN dotnet build thetimeweb.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish thetimeweb.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "thetimeweb.dll"]