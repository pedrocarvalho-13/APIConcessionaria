# API Concessionária de Carros

## **Visão Geral**

  A API Concessionária é um projeto desenvolvido utilizando o framework .NET e o Entity Framework Core com o banco de dados PostgreSQL. O objetivo desta API é gerenciar o estoque de veículos de uma concessionária, permitindo operações como adicionar, atualizar, visualizar e deletar registros de carros.

## **Funcionalidades**

- Cadastrar Carro: Permite adicionar um novo carro ao estoque, fornecendo informações como placa, fabricante, modelo, ano, quilometragem, valor de compra e venda.

- Visualizar Carros: Retorna uma lista de todos os carros cadastrados no estoque ou permite consultar um veículo específico pela placa.

- Atualizar Carro: Atualiza as informações de um carro existente no estoque.

- Remover Carro: Remove um carro do estoque com base na placa.

## **Estrutura do Projeto**

- Program.cs: Configura os serviços necessários para a aplicação, como Entity Framework e Swagger.

- AppDbContext.cs: Configura o contexto do banco de dados, definindo o DbSet para a entidade EstoqueDeCarros.

- EstoqueDeCarros.cs: Define a entidade EstoqueDeCarros com suas propriedades, incluindo validações.

- EstoqueController.cs: Controlador que expõe os endpoints da API para manipulação do estoque de carros.

- appsettings.Development.json: Arquivo de configuração contendo strings de conexão e outras configurações específicas para o ambiente de desenvolvimento.

- Migrations: Contém as migrações do banco de dados geradas pelo Entity Framework Core.

## **Pré-requisitos**

  - .NET SDK

  - PostgreSQL

- Entity Framework Core

## **Configuração do Ambiente**

1. Clone este repositório:

-     git clone https://github.com/seu-usuario/APIConcessionaria.git

2. Crie um arquivo .env na raiz do projeto com as variáveis de ambiente necessárias para a conexão com o banco de dados:

-     DB_PASSWORD=sua_senha_postgres

3. Execute os seguintes comandos para preparar o banco de dados:
-     dotnet ef migrations add InitialCreate
-     dotnet ef database update

4. Inicie o projeto:
-     dotnet run

## **Tecnologias Utilizadas**
- .NET 6
- Entity Framework Core
- PostgreSQL
- Swagger

## **Endpoints**

Aqui estão alguns dos principais endpoints:

- POST /api/estoque - Adiciona um novo carro ao estoque.
- GET /api/estoque - Retorna todos os carros no estoque.
- GET /api/estoque/{placa} - Retorna um carro específico com base na placa.
- PUT /api/estoque/{placa} - Atualiza um carro existente no estoque.
- DELETE /api/estoque/{placa} - Remove um carro do estoque.

## **Contribuições**

Sinta-se à vontade para fazer fork deste repositório e enviar pull requests. Sugestões e melhorias são sempre bem-vindas!

## **Licença**

Este projeto está sob a licença MIT. Veja o arquivo LICENSE para mais detalhes.
