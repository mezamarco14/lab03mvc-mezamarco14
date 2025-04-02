# Usa la imagen base de .NET SDK para construir la aplicación
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Establece el directorio de trabajo
WORKDIR /app

# Copia los archivos del proyecto
COPY . ./

# Restaurar dependencias y compilar la aplicación
RUN dotnet restore
RUN dotnet publish -c Release -o /app/publish

# Usa la imagen de runtime de .NET para ejecutar la aplicación
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final

# Establece el directorio de trabajo
WORKDIR /app

# Copia los archivos publicados desde la fase anterior
COPY --from=build /app/publish .

# Expón el puerto en el que la aplicación escuchará
EXPOSE 80

# Comando de inicio (usamos CMD para evitar errores si falta el DLL)
CMD ["sh", "-c", "ls -la && dotnet Lab03_MVC_Meza.dll"]
