# Usa la imagen oficial de .NET SDK (ajusta la versión si es necesario)
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Configurar el directorio de trabajo
WORKDIR /app

# Copiar archivos del proyecto
COPY . . 

# Instalar los workloads necesarios (si usa ASP.NET Core MVC)
RUN dotnet workload install web

# Restaurar dependencias
RUN dotnet restore

# Construir la aplicación en modo Release
RUN dotnet build -c Release --no-restore

# Publicar la aplicación
RUN dotnet publish -c Release --no-build -o /app/publish

# Usar una imagen más ligera para la ejecución
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime

# Configurar el directorio de trabajo
WORKDIR /app

# Copiar la publicación desde la fase anterior
COPY --from=build /app/publish .

# Exponer el puerto 80 para la aplicación
EXPOSE 80

# Comando de inicio
ENTRYPOINT ["dotnet", "Lab03_MVC_Meza.dll"]
