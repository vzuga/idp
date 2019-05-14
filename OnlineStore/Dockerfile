FROM microsoft/dotnet:2.2.0-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY OnlineStore/OnlineStore.csproj OnlineStore/
RUN dotnet restore OnlineStore/OnlineStore.csproj
COPY . .
WORKDIR /src/OnlineStore
RUN dotnet build OnlineStore.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish OnlineStore.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "OnlineStore.dll"]

RUN dotnet ef database update
