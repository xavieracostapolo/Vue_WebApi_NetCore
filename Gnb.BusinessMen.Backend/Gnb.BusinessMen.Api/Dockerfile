FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY Gnb.BusinessMen.Api/Gnb.BusinessMen.Api.csproj Gnb.BusinessMen.Api/
COPY Gnb.BusinessMen.Data/Gnb.BusinessMen.Data.csproj Gnb.BusinessMen.Data/
COPY Gnb.BusinessMen.Model/Gnb.BusinessMen.Model.csproj Gnb.BusinessMen.Model/
COPY Gnb.BusinessMen.Service/Gnb.BusinessMen.Service.csproj Gnb.BusinessMen.Service/
RUN dotnet restore Gnb.BusinessMen.Api/Gnb.BusinessMen.Api.csproj
COPY . .
WORKDIR /src/Gnb.BusinessMen.Api
RUN dotnet build Gnb.BusinessMen.Api.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Gnb.BusinessMen.Api.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Gnb.BusinessMen.Api.dll"]
