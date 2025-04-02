# Imagen base para compilar la aplicación
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copiar archivos de solución y proyecto para restaurar dependencias
COPY *.sln ./
COPY Lab03_MVC_Meza/*.csproj ./Lab03_MVC_Meza/
RUN dotnet restore

# Copiar todo el código fuente
COPY . ./
WORKDIR /app/Lab03_MVC_Meza

# Construcción y publicación de la aplicación
RUN dotnet build -c Release --no-restore
RUN dotnet publish -c Release --no-build -o /app/publish

# Imagen mínima de runtime para ejecutar la aplicación
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish ./

# Expone el puerto en el que corre la aplicación
EXPOSE 80
EXPOSE 443

# Comando de entrada para iniciar la aplicación
ENTRYPOINT ["dotnet", "Lab03_MVC_Meza.dll"]
