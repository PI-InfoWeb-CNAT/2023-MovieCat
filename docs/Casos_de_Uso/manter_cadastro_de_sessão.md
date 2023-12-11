# Projeto MovieCat

## Especificação do caso de uso - Cadastro de sessão

### Histórico da Revisão 

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 26/06/2023 | **1.00** | Versão Inicial  | Rita de Cassia |
| 24/09/2023 | **1.00** | Versão Atualizada  | Rita de Cassia |

### 1. Resumo 

Nesse caso o adm pode cadastrar varias sessões de um filme sendo DUB ou LEG, em horarios diferentes no sistema.

### 2. Atores 

Adm

### 3. Pré-condições

O Adm deve estar registrado no sistema e acessar a pagina pelo botão "Cadastrar sessão" no menu principal.

### 4. Pós-condições

O sistema mostra as condiçoes e espaço para adicionar uma nova sessão.

### 5. Fluxos de Evento

#### 5.1. Fluxo Básico

| Ator   | Sistema |
|:-------|:--------|
| 1. O adm clica em "Cadastrar sessão"| 2. O sistema redireciona para a parte de cadastrar uma nova sessão onde é exigido o nome do filme, data, sala, audio(LED ou DUB), horario de inicio e final de cada sessão.|
| 3. O adm adiciona o nome do filme, data, sala, audio(LED ou DUB), horario de inicio e final de cada sessão e clica em "Cadastrar".| 4. O sistema atualiza as informações da lista de sessões mostrando agora uma nova sessão.|
| 5. O adm visualiza a nova sessão na lista de sessões atuais. |

#### 5.2. Fluxos de Exceção

| Exceção | Sistema |
|:--------|:--------|
| 1. Erro nas informaçoes de sessões | se o funcionario tentar adicionar uma nova sessão com alguma informação invalida(nome do filme, data, sala, audio(LED ou DUB), horario de inicio e final de cada sessão.) ou um campo vazio, o sistema retorna a mensagem de "Informaçoes invalidas" |


### 6. Protótipos de Interface
`A ser desenvolvido pelo aluno.`
https://www.figma.com/file/Tf9R49Kc4vXWyyZdIGJ6oS/MovieCat?type=design&node-id=0-1&mode=design&t=jWPAjvdSx0PR4b4h-0
