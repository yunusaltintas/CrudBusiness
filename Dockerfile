FROM mcr.microsoft.com/dotnet/sdk:5.0 as build
WORKDIR /app
COPY ./UserCRUD/*.csproj ./UserCRUD/
COPY ./UserCRUD.Core/*.csproj ./UserCRUD.Core/
COPY ./UserCRUD.DATA/*.csproj ./UserCRUD.DATA/
COPY ./UserCRUD.Repository/*.csproj ./UserCRUD.Repository/
COPY ./UserCRUD.Service/*.csproj ./UserCRUD.Service/
COPY *.sln .
RUN dotnet restore
COPY . .
RUN dotnet publish ./UserCRUD/*.csproj -o /publish/

FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=build /publish .
EXPOSE 1453/tcp
ENV ASPNETCORE_URLS="http://*:1453"
ENTRYPOINT ["dotnet","UserCRUD.dll"]