FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

WORKDIR /src
COPY ["src/MyProject3.Web.Host/MyProject3.Web.Host.csproj", "src/MyProject3.Web.Host/"]
COPY ["src/MyProject3.Web.Core/MyProject3.Web.Core.csproj", "src/MyProject3.Web.Core/"]
COPY ["src/MyProject3.Application/MyProject3.Application.csproj", "src/MyProject3.Application/"]
COPY ["src/MyProject3.Core/MyProject3.Core.csproj", "src/MyProject3.Core/"]
COPY ["src/MyProject3.EntityFrameworkCore/MyProject3.EntityFrameworkCore.csproj", "src/MyProject3.EntityFrameworkCore/"]
WORKDIR "/src/src/MyProject3.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/MyProject3.Web.Host", "src/MyProject3.Web.Host"]
COPY ["src/MyProject3.Web.Core", "src/MyProject3.Web.Core"]
COPY ["src/MyProject3.Application", "src/MyProject3.Application"]
COPY ["src/MyProject3.Core", "src/MyProject3.Core"]
COPY ["src/MyProject3.EntityFrameworkCore", "src/MyProject3.EntityFrameworkCore"]
WORKDIR "/src/src/MyProject3.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:6.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "MyProject3.Web.Host.dll"]
