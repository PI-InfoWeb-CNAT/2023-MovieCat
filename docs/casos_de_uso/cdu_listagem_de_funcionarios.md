# Projeto Agendamento de Serviços

## Especificação do caso de uso - Listagem de Funcionários

### Histórico da Revisão 

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 19/06/2023 | **1.00** | Versão Inicial  | Maria Cândida |

### 1. Resumo 

Nesse caso de uso, o usuário administrador acessa a listagem de funcionários e a funcionalidade "Adicionar funcionário".

### 2. Atores 

Administradores

### 3. Pré-condições

Estar logado no sistema e tido acesso ao dashboard em que continha a opção de acesso para a listagem de funcionários.

### 4. Pós-condições

Ter acesso a lista de funcionários cadastrados no sistema.

### 5. Fluxos de Evento

#### 5.1. Fluxo Básico

| Ator   | Sistema |
|:-------|:--------|
| 1. O Administrador acessa a página de listagem de funcionários, a partir do dashboard contido na tela inicial. | 2. O sistema lista todos os funcionários atuais do AgendMovies e permite que o administrador adicione um novo funcionário à página.|
| 3. O usuário aperta em "visualiza" um determinado funcionário. | 
| 4. O usuário seleciona e edita dados de um funcionário existente. | 5. O sistema atualiza os dados e exibe uma mensagem na tela indicando o sucesso na alteração de dados do funcionário. |
| 6. Usuário visualiza o funcionário na listagem com os dados já alterados.
| 7. O usuário clica em “adicionar" | 4. O sistema redireciona para a página de cadastro de funcionário.

#### 5.2. Fluxos de Exceção

| Exceção | Sistema |
|:--------|:--------|
| 1. Dados inválidos para a operação | Se o usuário tentar inserir ou atualizar funcionários com informações repetidas (como CPF, email e/ou celular) , o sistema deve apresentar um alerta de "dados já cadastrados" e não realizar a operação. | 

### 6. Protótipos de Interface
https://www.figma.com/file/kU2Ogqn2V2mUKLoDF249vz/AgendMovies?type=design&node-id=0%3A1&t=ppw9288UsgGnDo1W-1
