# Climapi

## Descripcíon
> Pequeña api con dotnet core  webapi que consumira una api externa para generar sus propias respuestas

* Se consume la Api del sitio [WeatherApi](https://www.weatherapi.com) que entrega info en tiempo real del clima
* Devuelve respuestas en formato Json personalizadas basadas en la respuesta de la Api Externa
* Para crear las clases que almacenan las respuestas de la api externa se utilizo la extension de VSCode **Paste JSON As Code** para generarlas automaticamente
## Funcionamiento

> La app utiliza como url base https://localhost:6060/api/v1/Weather/ 

> El funcionamiento fundamental de la app es 

        // Get 
        https:localhost:6060/api/v1/Weather/{ciudad}/{opcion}[/parametro]

> Y por ahora como es solo de prueba posee solo dos funcionalidades:
- ***Tiempo actual:*** Devuelve la condicion climatica de la ciudad o codigo postal o cordenada pasada y se utiliza asi:

        https:localhost:6060/api/v1/Weather/oslo/current
- ***Pronostico:*** Devuelve el clima actual asi como un pronostico de hasta 3 dias siguientes
  - Utiliza un parametro adicional en la url q es el numero de dias del pronostico      

        https:localhost:6060/api/v1/Weather/oslo/forecast/3


## Nuget Requeriments
- Microsoft.AspNet.WebApi.Client
- Newtonsoft.Json