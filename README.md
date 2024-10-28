# Aplicação CRUD em C# com Dapper

## Visão Geral
Este repositório contém uma aplicação CRUD (Create, Read, Update, Delete) desenvolvida em C# utilizando o micro-ORM Dapper. O projeto demonstra como gerenciar operações de banco de dados de forma eficiente em uma aplicação .NET com Dapper, oferecendo uma abordagem simplificada para acesso e manipulação de dados.

## Funcionalidades
- **Integração com Dapper**: Acesso a dados de forma leve e com alta performance.
- **Operações CRUD**: Funcionalidades para criar, ler, atualizar e deletar registros.
- **Abstração de Banco de Dados**: Todas as operações de banco de dados são encapsuladas, tornando a aplicação fácil de manter e expandir.

## Tecnologias Utilizadas
- **C# (.NET 8)**: Linguagem principal e framework.
- **Dapper**: Micro-ORM para acesso simplificado ao banco de dados.

## Pré-requisitos
- **.NET 8 SDK**: Certifique-se de que o .NET 6 está instalado em seu ambiente de desenvolvimento.
- **Banco de Dados**: Configure a string de conexão no código para conectar ao banco de dados que deseja utilizar.

## Instalação e Execução
1. Clone o repositório:
   ```bash
   git clone https://github.com/ClaudioMatheusDev/CrudDapper.git
   ```
2. Acesse o diretório do projeto:
   ```bash
   cd CrudDapper
   ```
3. Restaure as dependências e compile o projeto:
   ```bash
   dotnet restore
   dotnet build
   ```
4. Execute a aplicação:
   ```bash
   dotnet run
   ```

## Contribuição
Contribuições são bem-vindas! Sinta-se à vontade para abrir issues e pull requests.

## Licença
Este projeto está sob a licença MIT - veja o arquivo [LICENSE](LICENSE) para detalhes.
