# Projeto MovieCat

## Especificação do caso de uso - Cadastro de filme

### Histórico da Revisão 

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 26/06/2023 | **1.00** | Versão Inicial  | Rita de Cassia |
| 24/09/2023 | **1.00** | Versão Atualizada  | Rita de Cassia |

### 1. Resumo 

Nesse caso o adm pode cadastrar novos filmes no sistema.

### 2. Atores 

Adm

### 3. Pré-condições

O Adm deve estar registrado no sistema e acessar a pagina apartir do botão " Cadastrar filmes" no dashbord de ADM.

### 4. Pós-condições

O sistema mostra as condições e espaço para adicionar um novo filme.

### 5. Fluxos de Evento

#### 5.1. Fluxo Básico

| Ator   | Sistema |
|:-------|:--------|
| 1. O adm clica em “Cadastra filme"| 2. O sistema redireciona para a parte de adicionar um novo filme onde é exigido; nome do filme, genero, categoria, classificação, duração, sinopse e poster.|
| 3. O adm adiciona o nome do filme, genero, categoria, classificação, duração, sinopse e poster no sistema.| 4. O sistema atualiza as informações da lista de filmes.|

#### 5.2. Fluxos de Exceção

| Exceção | Sistema |
|:--------|:--------|
| 1. Erro nas informaçoes do filme | se o administrador tentar adicionar um novo filme com alguma informação invalida(nome do filme, genero, categoria, classificação, duração, sinopse e poster) ou em campo vazio, o sistema retorna a mensagem de "Informaçoes invalidas" |


### 6. Protótipos de Interface
https://www.figma.com/file/Tf9R49Kc4vXWyyZdIGJ6oS/MovieCat?type=design&node-id=0-1&mode=design&t=jWPAjvdSx0PR4b4h-0
