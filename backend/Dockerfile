FROM mcr.microsoft.com/dotnet/sdk:3.1-alpine

WORKDIR /app

ADD ./APIServer/*.csproj /app
RUN dotnet restore

ADD ./APIServer /app

EXPOSE 3000
CMD ["dotnet", "watch", "run"]
