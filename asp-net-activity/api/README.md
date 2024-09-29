# ASP.NET Core Web API .NET 8 2024 by Teddy Smith

- [Youtube](https://www.youtube.com/watch?v=qBTe6uHJS_Y&list=PL82C6-O4XrHfrGOCPmKmwTO7M0avXyQKc)
- [Github](https://github.com/teddysmithdev/FinShark)
- Special thanks to: Teddy Smith

Notes:
- "Default Connection"
    - "Data Source={PCNAME}\\SQLEXPRESS;Initial Catalog={DATABASENAME};Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
- dotnet tool install --global dotnet-ef --version 8.0.0
- dotnet ef migrations add init
- dotnet ef database update