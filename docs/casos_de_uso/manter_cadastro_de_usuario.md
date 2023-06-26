# Projeto AgendMovies

## Especificação do caso de uso - Cadastro de usuario

### Histórico da Revisão 

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 00/06/2023 | **1.00** | Versão Inicial  | Rita de Cassia |

### 1. Resumo 

Nesse caso de uso um visitantese cadastra no site, o possibilitando fazer compras e acesar o seu perfil no site.

### 2. Atores 

Usuários visitantes.

### 3. Pré-condições

O visitante deve acessar o link do cadastro.

### 4. Pós-condições

O sistema mostra o formulario de cadastro de usuario.

### 5. Fluxos de Evento

#### 5.1. Fluxo Básico

| Ator   | Sistema |
|:-------|:--------|
| 1.O usuario acesa a pagina de cadastro por meio do icone de perfil na pagina de inicial do site | 2. O sistema exibe o formulario de cadastro de usuario, com os seguintes campos; nome completo, CPF, celular, email, senha e confirmar senha.  |
| 3.O usuario preenche os campos corretamente, e clica em cadastra | 4.O sistema grava o cadastro do usuario e retorna a pagina de inicio|


#### 5.2. Fluxos de Exceção

| Exceção | Sistema |
|:--------|:--------|
|1. Erro nas credenciais | Se o usuario colocar uma informação invalida(nome completo, CPF, celular, email, senha e confirmar senha) ou um campo em branco, vai da erro e retornar a mensagem "Informações invalidas"|
