# Projeto AgendMovies

## Especificação do caso de uso - Cadastro de pacotes

### Histórico da Revisão 

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 00/06/2023 | **1.00** | Versão Inicial  | Rita de Cassia |

### 1. Resumo 

Nesse caso de uso o adm pode cadastrar novos pacotes no sistema.

### 2. Atores 

Adm

### 3. Pré-condições

O adm deve estar registrado no sistema e acessá lo com seu login (login e senha).

### 4. Pós-condições

O sistema mostra as condiçoes e espaço para adicionar um novo pacote.

### 5. Fluxos de Evento

#### 5.1. Fluxo Básico

| Ator   | Sistema |
|:-------|:--------|
| 1. O adm clica em “adicionar"| 2. O sistema redireciona para a parte de adicionar um novo pacote onde é exigido o número de ingressos (com limite mínimo de 10 ingressos por pacote), valor do pacote, tipo de sala (normal ou XD), tipo de assento(normal ou D-Box).|
| 3. O adm adiciona a quantidade de ingressos, tipo de sala, assento e o valor, respeitando todas as exigências do sistema.| 4. O sistema atualiza as informações da lista de pacotes mostrando agora o novo pacote.|
| 5. O adm visualiza o novo pacote na lista de pacotes atuais. |

#### 5.2. Fluxos de Exceção

| Exceção | Sistema |
|:--------|:--------|
| 1. Limite de pacotes excedido| Se o funcionário tentar inserir um novo pacote com o limite excedido o sistema deve apresentar a mensagem de “impossivel adicionar novo pacote  pois o limite de 6 pacotes foi excedido”. |
| 2. Erro nas informaçoes de pacotes | se o funcionario tentar adicionar um novo pacote com alguma informação invalida(numero de ingressos, valor, tipo de sala e tipo de assento) ou em campo vazio, o sistema retorna a mensagem de "Informaçoes invalidas" |


### 6. Protótipos de Interface
`A ser desenvolvido pelo aluno.`
