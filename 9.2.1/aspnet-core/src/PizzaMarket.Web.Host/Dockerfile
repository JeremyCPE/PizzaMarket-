FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/PizzaMarket.Web.Host/PizzaMarket.Web.Host.csproj", "src/PizzaMarket.Web.Host/"]
COPY ["src/PizzaMarket.Web.Core/PizzaMarket.Web.Core.csproj", "src/PizzaMarket.Web.Core/"]
COPY ["src/PizzaMarket.Application/PizzaMarket.Application.csproj", "src/PizzaMarket.Application/"]
COPY ["src/PizzaMarket.Core/PizzaMarket.Core.csproj", "src/PizzaMarket.Core/"]
COPY ["src/PizzaMarket.EntityFrameworkCore/PizzaMarket.EntityFrameworkCore.csproj", "src/PizzaMarket.EntityFrameworkCore/"]
WORKDIR "/src/src/PizzaMarket.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/PizzaMarket.Web.Host", "src/PizzaMarket.Web.Host"]
COPY ["src/PizzaMarket.Web.Core", "src/PizzaMarket.Web.Core"]
COPY ["src/PizzaMarket.Application", "src/PizzaMarket.Application"]
COPY ["src/PizzaMarket.Core", "src/PizzaMarket.Core"]
COPY ["src/PizzaMarket.EntityFrameworkCore", "src/PizzaMarket.EntityFrameworkCore"]
WORKDIR "/src/src/PizzaMarket.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "PizzaMarket.Web.Host.dll"]
