<h1 align="center">CasePan</h1>

![Image](https://github.com/user-attachments/assets/ac7013f7-42a3-4d6e-837d-9a9db8690165)

<h2>Descrição:</h2>

Este projeto foi desenvolvido como parte do teste técnico para a vaga de Engenheiro de Software Júnior no Banco Pan.

Trata-se de uma API que implementa operações CRUD (Create, Read, Update, Delete) e realiza a conexão com um banco de dados PostgreSQL. A API oferece endpoints para gerenciar usuários, permitindo a criação, atualização, exclusão e consulta de dados. O objetivo é fornecer uma estrutura robusta e eficiente para a manipulação dos dados dos usuários, com foco na simplicidade e escalabilidade das operações.


<h2>Estrutura do projeto</h2>

O projeto está organizado de forma a garantir clareza e escalabilidade. Abaixo está um resumo das principais pastas e arquivos:

- **`Controllers/`**: Responsável por gerenciar as requisições HTTP e delegar as ações para os serviços correspondentes.

- **`Services/`**: Contém a lógica de negócios, implementando os métodos CRUD e outras operações relacionadas aos usuários.

- **`DTOs/`**: Define os objetos de transferência de dados utilizados para comunicação entre as camadas da aplicação.

- **`Validators/`**: Contém as validações necessárias para garantir que os dados fornecidos sejam consistentes e válidos antes de serem processados.

- **`Exceptions/`**: Define as exceções personalizadas e o tratamento de erros para uma resposta clara e controlada em caso de falhas.

- **`Migrations/`**: Arquivos de migração para o banco de dados, gerenciando mudanças na estrutura do schema.

- **`Models/`**: Representa as entidades do banco de dados, como o modelo de Usuário.

- **`Data/`**: Contém a configuração de acesso ao banco de dados e a definição do contexto de dados, utilizando o Entity Framework para facilitar as operações de persistência.

<h2>Endpoints da API</h2>

A API expõe os seguintes endpoints para gerenciar os usuários:

- **`GET /api/user/GetAllUsers`**  
Retorna todos os usuários cadastrados no sistema.

- **`GET /api/user/GetUserById/{idUser}`**  
  Retorna os detalhes de um usuário específico, identificado pelo seu ID.

- **`POST /api/user/SaveUser`**  
  Cria um novo usuário a partir dos dados fornecidos no corpo da requisição.

- **`PUT /api/user/EditUser`**  
  Atualiza os dados de um usuário existente com base nas informações fornecidas.

- **`DELETE /api/user/DeleteUser`**  
  Deleta um usuário do sistema, identificado pelo seu ID.

<h2>Instalação:</h2>

Para instalar o projeto, você pode baixá-lo como um arquivo .zip ou cloná-lo diretamente do GitHub.

### Baixar como .zip

1. Acesse o repositório no GitHub: [CasePan](https://github.com/YuriLopess/CasePan)
2. Clique em "Code" e selecione "Download ZIP".
3. Extraia o arquivo ZIP no diretório de sua escolha.

### Clonar com Git

1. Abra o terminal.

2. Navegue até o diretório onde deseja clonar o repositório.

3. Execute o seguinte comando:

   ```sh
   git clone https://github.com/YuriLopess/CasePan.git
<h2>Pré-requisitos:</h2>

Antes de rodar o projeto, é necessário ter as seguintes ferramentas e tecnologias instaladas:


- .NET 8
- PostgreSQL
- Entity Framework Core
- Ferramentas para migração de banco de dados (Ex: EF Core CLI)


<h2>Rodando o Projeto Localmente:</h2>

1. Clone o repositório para sua máquina local.

2. Navegue até a pasta do projeto no terminal.

3. Configure a conexão com o banco de dados PostgreSQL no arquivo `appsettings.json`.

4. Execute as migrações do banco de dados com o comando:

   ```sh
   dotnet ef database update
5. Inicie o projeto com o comando:

    ```sh
    dotnet run
<h2>Contato:</h2>

Caso tenha alguma dúvida ou queira discutir sobre o projeto, sinta-se à vontade para entrar em contato comigo através desse e-mail: **[costalopesyuri@gmail.com](mailto:costalopesyuri@gmail.com)**