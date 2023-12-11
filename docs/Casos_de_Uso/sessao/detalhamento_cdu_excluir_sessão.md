# Projeto AgendMovies

## Especificação do caso de uso - Excluir sessão

### Histórico da Revisão 

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 26/06/2023 | **1.00** | Versão Inicial  | Rita de Cassia |

### 1. Resumo 

Nesse caso de uso o adm pode excluir uma sessão do sistema.

### 2. Atores 
Usuarios administradores.

### 3. Pré-condições

O administrador deve estar registrado no sistema e acessar a pagina atravez do botão "sessão" no dashborad.

### 4. Pós-condições

O sistema mostra uma lista de sessões com os seguintes botões "Excluir" e "Adicionar".

### 5. Fluxos de Evento

#### 5.1. Fluxo Básico

| Ator   | Sistema |
|:-------|:--------|
| 1. O administrador clica em “Excluir"| 2. O sistema mostra a mensagem "Tem certeza que deseja excluir essa sessão?"|
| 1. O funcionário clica em “Sim,tenho certeza"| 2. O sistema exclui a sessão do sistema |


#### 5.2. Fluxos de Exceção

| Exceção | Sistema |
|:--------|:--------|
