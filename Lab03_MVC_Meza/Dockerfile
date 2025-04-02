# Imagen base con el SDK de .NET
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Configurar directorio de trabajo
WORKDIR /app

# Copiar los archivos del proyecto y restaurar dependencias
COPY . . 
RUN dotnet restore

# Construir el proyecto
RUN dotnet build -c Release --no-restore

# Publicar la aplicación
RUN dotnet publish -c Release -o /app/publish --no-restore

# Imagen final con solo el runtime de .NET
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final

# Configurar directorio de trabajo
WORKDIR /app

# Copiar archivos publicados desde la etapa de compilación
COPY --from=build /app/publish .

# Exponer el puerto (ajustar según tu configuración)
EXPOSE 80

# Comando para ejecutar la aplicación
ENTRYPOINT ["dotnet", "Lab03_MVC_Meza.dll"]
