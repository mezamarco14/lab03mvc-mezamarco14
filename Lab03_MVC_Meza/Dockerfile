# Usa la imagen base de .NET SDK para construir la aplicación
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Establece el directorio de trabajo
WORKDIR /app

# Copia los archivos del proyecto (y las dependencias)
COPY . ./

# Publica la aplicación en modo Release
RUN dotnet publish -c Release -o /app/publish

# Usa la imagen de runtime para ejecutar la aplicación
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final

# Establece el directorio de trabajo
WORKDIR /app

# Copia los archivos publicados desde el contenedor anterior
COPY --from=build /app/publish .

# Expón el puerto en el que la aplicación escuchará
EXPOSE 80

# Comando para iniciar la aplicación
ENTRYPOINT ["dotnet", "Lab03_MVC_Meza.dll"]
