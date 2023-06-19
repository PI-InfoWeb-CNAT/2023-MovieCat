# Projeto AgendMovies

## Especificação do caso de uso - Listar pacotes

### Histórico da Revisão 

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 00/06/2023 | **1.00** | Versão Inicial  | Rita de Cassia |
| 00/06/2023 | **1.10** | Ajustes na redação  | Gilbert Azevedo |

### 1. Resumo 

Nesse caso de uso o usuário funcionário acessa o sistema e gerencia os pacotes, onde irá listar o número de ingressos e o valor do pacote, onde possibilita também a opção de exclusão de determinado pacote selecionado pelo usuário funcionário e também a opção de adicionar um novo pacote a lista.

### 2. Atores 

Funcionário

### 3. Pré-condições

O funcionário deve estar registrado no sistema e acessá lo com suas credenciais (login e senha) o sistema

### 4. Pós-condições

O sistema disponibiliza  os pacotes atuais (número de ingressos e valor do pacote), excluir pacotes e adicionar novo pacote (com o número de ingressos, valor, tipo de sala e tipo de assento) 
### 5. Fluxos de Evento

#### 5.1. Fluxo Básico

| Ator   | Sistema |
|:-------|:--------|
| 1. O Funcionário acessa a página de listar pacotes, a partir do painel de controle (dashborad) de funcionário do AgendMovies.| 2. O sistema lista os pacotes atuais do AgendMovies, permitindo ao funcionário adicionar novo pacote a lista ou excluir um já existente|
| 3. O Funcionário seleciona um pacote existente e aperta em excluir| 4. O sistema exclui o pacote selecionado pelo usuário|
| 5. O funcionário clica em “adicionar"| 6. O sistema redireciona para a parte de adicionar um novo pacote onde é exigido o número de ingressos (com limite mínimo de 10 ingressos por pacote), valor do pacote, tipo de sala (normal ou XD), tipo de assento(normal ou D-Box).|
| 7. O funcionário adiciona a quantidade de ingressos, tipo de sala, assento e o valor, respeitando todas as exigências do sistema.| 8. O sistema atualiza as informações da lista de pacotes mostrando agora o novo pacote.|
| 9. O funcionário visualiza o novo pacote na lista de pacotes atuais. |

#### 5.2. Fluxos de Exceção

| Exceção | Sistema |
|:--------|:--------|
| 1. Limite de pacotes excedido| Se o funcionário tentar inserir um novo pacote com o limite excedido o sistema deve apresentar a mensagem de “impossivel adicionar novo pacote  pois o limite de 6 pacotes foi excedido”. |

### 6. Protótipos de Interface
`A ser desenvolvido pelo aluno.`
