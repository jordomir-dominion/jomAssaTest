
## Guía Rápida para Docker y Cobertura de Código

Este proyecto utiliza Docker y herramientas de cobertura de código para facilitar el desarrollo, ejecución de pruebas y generación de informes de cobertura.

## Ejecución con Docker

```bash
docker-compose up --build -d
```

Asegúrate de revisar el archivo `docker-compose.yml` para conocer los puertos configurados para la aplicación.

## Ejecución de Pruebas y Generación de Cobertura

```bash
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=opencover --settings Assa.Application.Test/coverlet.runsettings
```

```bash
reportgenerator "-reports:Assa.Application.Test/TestResults/*/coverage.opencover.xml" "-targetdir:Assa.Application.Test/TestResults/CoverageReport" "-reporttypes:HtmlInline_AzurePipelines;Badges"
```

## Configuración de Cobertura (coverlet.runsettings)

```xml
<?xml version="1.0" encoding="utf-8" ?>
<RunSettings>
  <DataCollectionRunSettings>
    <DataCollectors>
      <DataCollector friendlyName="XPlat Code Coverage">
        <Configuration>
          <Format>opencover</Format>
          <Exclude>[*]Assa.Infrastructure.Data.Migrations*</Exclude>
          <ExcludeByFile>**/Program.cs,</ExcludeByFile>
        </Configuration>
      </DataCollector>
    </DataCollectors>
  </DataCollectionRunSettings>
</RunSettings>
```

## Rutas Importantes

- **Swagger**: La documentación de la API está disponible en la ruta `http://localhost:{PUERTO_CONFIGURADO}/swagger/index.html`.
  
Asegúrate de reemplazar `{PUERTO_CONFIGURADO}` con el puerto específico configurado en tu archivo `docker-compose.yml`.
