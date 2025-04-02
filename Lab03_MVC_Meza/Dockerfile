# Build image
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copiar los archivos del proyecto y restaurar dependencias
COPY *.sln ./
COPY Lab03_MVC_Meza/*.csproj ./Lab03_MVC_Meza/
RUN dotnet restore Lab03_MVC_Meza/Lab03_MVC_Meza.csproj

# Copiar el resto del código y compilar
COPY . .
WORKDIR /app/Lab03_MVC_Meza
RUN dotnet build -c Release --no-restore

# Publicar la aplicación
RUN dotnet publish -c Release -o /app/publish --no-build

# Runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "Lab03_MVC_Meza.dll"]
