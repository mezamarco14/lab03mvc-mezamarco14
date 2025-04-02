# Usa la imagen oficial de .NET SDK
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /app

# Copiar archivos del proyecto y restaurar dependencias
COPY ["Lab03_MVC_Meza/Lab03_MVC_Meza.csproj", "./"]
RUN dotnet restore

# Copiar el resto del código fuente
COPY . .

# Construir la aplicación
RUN dotnet build -c Release --no-restore

# Publicar la aplicación
RUN dotnet publish -c Release -o /app/publish --no-build

# Usar una imagen más liviana para la ejecución
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .

# Definir el comando de inicio
ENTRYPOINT ["dotnet", "Lab03_MVC_Meza.dll"]
