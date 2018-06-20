FROM microsoft/dotnet:latest

ADD ./ /app
WORKDIR /app

RUN dotnet publish -c Release -o out

ENTRYPOINT ["dotnet", "out/netcoreapp2.0/Blog.dll"]