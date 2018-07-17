# Gateway Ocelot - API

API Gateway em ASP.NET Core utilizando middleware [Ocelot](https://github.com/ThreeMammals/Ocelot).

**Arquivo - configuration.json**

O arquivo **configuration.json** é responsável pela rota dos serviços. A configuração do **host/port** irá depender do ambiente onde a API Gateway será executada. A configuração do host/porta pode ser feita de 3 formas:

- Imagem dos serviços junto com a API Gateway (como neste projeto) - **Execução Docker**:

```json
{
    "DownstreamHostAndPorts": [
        {
          "Host": "estados.api",
          "Port": 80,
        }
    ]
}
```

- Imagem dos serviços em outro projeto - **Execução Docker**:

```json
{
    "DownstreamHostAndPorts": [
        {
          "Host": "SEU_IP",
          "Port": 37801,
        }
    ]
}
```

- Imagem dos serviços em outro projeto - **Execução IIS**:

```json
{
    "DownstreamHostAndPorts": [
        {
          "Host": "localhost",
          "Port": 80,
        }
    ]
}
```
 
 **Executar API**
 - Executar projeto via docker ou via Visual Studio ou Visual Studio Code 