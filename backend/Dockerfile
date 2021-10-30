FROM --platform=linux/x86_64 mcr.microsoft.com/dotnet/sdk:3.1-alpine

RUN dotnet tool install --global dotnet-ef
ENV PATH="$PATH:/root/.dotnet/tools"

WORKDIR /app

ADD ./APIServer/*.csproj /app
RUN dotnet restore

ADD ./APIServer /app

EXPOSE 3000
CMD ["dotnet", "watch", "run"]
