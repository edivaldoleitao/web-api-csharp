#### Tecnologias usadas

![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=csharp&logoColor=white)
![Swagger](https://img.shields.io/badge/-Swagger-%23Clojure?style=for-the-badge&logo=swagger&logoColor=white)
![MicrosoftSQLServer](https://img.shields.io/badge/Microsoft%20SQL%20Server-CC2927?style=for-the-badge&logo=microsoft%20sql%20server&logoColor=white)
![Azure](https://img.shields.io/badge/azure-%230072C6.svg?style=for-the-badge&logo=microsoftazure&logoColor=white)



### Inicializar Projeto WEB API

```dotnet
dotnet new webapi --use-controllers
```

### Instalando Entity Framework Globalmente

#### Instalação da Ferramenta
 ```dotnet
 dotnet tool install --global dotnet-ef
 ```
#### Instalação no pacote do projeto 
 ```dotnet
 dotnet add package Microsoft.EntityFrameworkCore.Design
 ```
```dotnet
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
```

### Executando o Projeto

Executa de forma que os arquivos sempre estejam sendo visto e
atualizados em tempo real  

 ```dotnet
 dotnet watch run
 ```
### Configurando conexão com SQL SERVER

No arquivo de **appsettings Development** para Development ou para produção apenas appsetting  
adicionado o valor para  conexão para o banco de dados a depender do tipo no caso usado  
o **SQLEXPRESSE** a chave adicionada foi , sendo no parâmetro **Initial Catalog** o nome do Banco  
e o  **Integrated Security** significa usar a autenticação padrão do windows
```json
"ConnectionStrings": {
    "ConexaoPadrao": "Server=localhost\\sqlexpress; Initial Catalog=Agenda; Integrated Security=True"
  }
```
