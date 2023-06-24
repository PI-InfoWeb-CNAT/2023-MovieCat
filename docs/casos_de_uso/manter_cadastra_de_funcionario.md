# Projeto AgendMovies

## Especificação do caso de uso - Cadastra funcionario

### Histórico da Revisão 

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 00/06/2023 | **1.00** | Versão Inicial  | Rita de Cassia |

### 1. Resumo 

Nesse caso de uso um adm cadastra um funcionario no sistema.

### 2. Atores 

Adm 

### 3. Pré-condições

O Adm deve existir no sistema.

### 4. Pós-condições

O sistema mostra o formulario de cadastro de funcionario.

### 5. Fluxos de Evento

#### 5.1. Fluxo Básico

| Ator   | Sistema |
|:-------|:--------|
| 1.O usuario acesa a pagina de cadastro por meio do botão "adicionar funcionario" na pagina de "listar funcionario" | 2. O sistema exibe o formulario de cadastro de funcionario, com os seguintes campos; nome completo, CPF, celular, email, senha e confirmar senha.  |
| 3.O usuario preenche os campos corretamente, e clica em cadastra | 4.O sistema retorna a mensagem "Funcionario cadastrado com sucesso", confirmando o cadastro|


#### 5.2. Fluxos de Exceção

| Exceção | Sistema |
|:--------|:--------|
|1. Erro nas credenciais | Se o usuario colocar uma informação invalida(nome completo, CPF, celular, email, senha e confirmar senha) ou um campo em branco, vai da erro e retornar a mensagem "Informações invalidas"|
