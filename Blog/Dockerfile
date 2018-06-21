FROM microsoft/aspnetcore:latest

ADD ./out /app
WORKDIR /app

EXPOSE 5000:80
ENTRYPOINT ["dotnet", "Blog.dll"]