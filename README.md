
# Central de Afiação

Projeto criado para gerenciar uma loja de vendas de ferramentas de marcenaria, onde o cadastro de clientes, produtos e pedidos fossem o core da aplicação.
- .Net Framework 4.6.1
- Windows Forms
- Access DB


## Rodando localmente

1. Clone o projeto

```bash
  git clone https://github.com/WilliamAbelo/CentralDeAfiacao.git
```
2. Rodando a aplicação pelo prompt
    - ***certifique-se de estar na pasta do projeto***
    - Restaures os pacotes Nuget [^1]
        ```bash
        dotnet restore
        ```
    - Build o projeto [^2]
        ```bash
        dotnet build
        ```
    - Rode o projeto [^3]
        ```bash
        dotnet run --project desktop
        ```
   [^1]: [Dotnet Restore](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-restore)

   [^2]: [Dotnet Build](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-build)
    
   [^3]: [Dotnet Run](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-run)



## Funcionalidades

- Gerenciamento de Usuarios, Authenticação e Autorização.
- Listagem, Seleção, Adição, Edição e Exclusão de Usuarios.
- Listagem, Seleção, Adição, Edição e Exclusão de Produtos.
- Listagem, Seleção, Adição, Edição e Exclusão de Pedidos.
- Sistema de classificação de pedidos baseado nos proximos vencimentos das faturas.
- Sistema de descontos de itens individuais ou pedidos inteiros.
- Alerta para pedidos com faturamento em atraso.
- Modulo de contas a receber.
- Modulo de contas a pagar (...in progress ![](https://geps.dev/progress/10)).
- Adição automatica do valor do frete nos pedidos (...in progress ![](https://geps.dev/progress/10)).


## Autores

- [@WilliamAbelo](https://github.com/WilliamAbelo)

