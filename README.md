# Api .NET CORE

Api feita com .NET CORE e Entity Framework Core.

## Explicação de como foi gerado o projeto e instalado os pacotes

Primeiramente foi verificado se o dotnet esta instalado, com o comando:

```sh
dotnet --version
```

Em seguida foram instalados os pacotes do Microsoft.EntityFrameworkCore com os comandos a seguir:

```sh
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
```

```sh
dotnet add package Microsoft.EntityFrameworkCore.Design
```

Para configurar as migrations foram feitos os seguintes procedimentos:

## Instalar Ferramentas Locais

Para instalar ferramentas locais.
Primeiro rode o comendo **dotnet new tool-manifest**, em seguida rode o comando para instalar a ferramenta que deseja, Ex: **dotnet tool install dotnet-ef**.

_Referência_: https://docs.microsoft.com/pt-br/dotnet/core/tools/global-tools#install-a-local-tool

## Comandos para rodar as migrations

- dotnet ef migrations add NomeDaMigration - Criar as migrations.
- dotnet ef migrations remove - Remover as migrations criadas.
- dotnet ef database update - Criar/Atualizar esquema de tabelas do banco de dados configurado.

_Referência_: https://docs.microsoft.com/pt-br/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli
