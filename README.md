
## Guía Rápida para Docker y Cobertura de Código

Este proyecto utiliza Docker y herramientas de cobertura de código para facilitar el desarrollo, ejecución de pruebas y generación de informes de cobertura.

## Ejecución con Docker

```bash
docker-compose up --build -d
```

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
