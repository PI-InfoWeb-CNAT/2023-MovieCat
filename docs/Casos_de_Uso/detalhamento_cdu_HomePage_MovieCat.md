# Projeto MovieCat

## Especificação do caso de uso - Página Inicial MovieCat

### Histórico da Revisão 

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 19/06/2023 | **1.00** | Versão Inicial  | Milton Shyon |

### 1. Resumo 

Nesse caso de uso o usuário acessa o endereço do MovieCat e o sistema exibe a LandPage com o menu de acesso para as demais páginas(Filmes, em cartaz, sobre nos, dashbords(com os tipos de acesso, cliente, funcionario e adm).), a opção de login, uma exibição de filmes a serem exibidos, os filmes em cartaz, catalogo e os em breve.
### 2. Atores 

Visitantes, clientes, funcionários e administradores.

### 3. Pré-condições

_

### 4. Pós-condições

_
 
### 5. Fluxos de Evento

#### 5.1. Fluxo Básico - 

| Ator   | Sistema |
|:-------|:--------|
| 1. O usuário acessa a página do MovieCat.| 2. O sistema exibe o HomePage MovieCat, permitindo ao usuário visualizar o menu de acesso para as demais páginas |
| 3. O usuário seleciona o ícone de perfil na página | 4. O sistema redireciona para página de login //e/ou de cadastro |
| 5. O usuário faz o login ou se cadastra no sistema| 6. O sistema redireciona novamente para a HomePage, agora com a possibilidade de fazer pedidos no site |
| 7. O usuário clica em "Em cartaz". | 8. O sistema exibe uma lista de filmes que estão em cartaz no cinema. |
| 9. O usuário clica em “filmes”  | 10. O sistema exibe a redereciona para "catalogo" onde exibe uma lista de filmes disponíveis .|
| 11. O usuário clica em determinado filme. | 12. O sistema o redireciona para uma página interna onde ele pode visualizar detalhes do filme(Sinopse, diretor, genero, duração, destribuidora elenco e classificação), os horários(dia da semana e horario) de exibição e tipo da sessão(LEG ou DUB) e também fazer o pedido de um pacote. |
| 13. O usuário volta para homePage e seleciona “ver mais” em “em cartaz” | 14. O sistema redireciona para a pagina de filmes.|
| 15. O usuário Clica em "sobre nos". | 16. O sistema  exibe uma página com as considerações dos desenvolvedores do site. |
| 17. O usuário arrasta o mause sobre "dashbord". | 18. O sistema  exibe opções de acesso de diferentes usuarios, (ADM, funcionario e cliente) onde pode ser derecionado para diferentes tipos de acesso. |
| 19.O usuário Clica em "ver pacotes". | 20. O Sistema redireciona para tela de pacote do filme selecionado onde exide as seguintes informaçoes (Sinopse, diretor, genero, duração, destribuidora elenco e classificação) e os horarios (dia da semana e horario) de exibição e tipo de sessão (LEG ou DUB). |
| 21. *******O usuário clica no ícone de tela com a opção “mudar tema”  | 22. O sistema altera o tema do site para o tema oposto ao que está naquele momento.|
#### 5.2. Fluxos de Exceção

| Exceção | Sistema |
|:--------|:--------|
| 1. Compra de ingresso sem cadastro| Se o funcionário tentar comprar um pacote de ingressos sem possuir cadastro prévio, o sistema deve apresentar a mensagem de “Para realizar compras no site necessita de cadastro prévio ou login deseja entrar ou fazer cadastro? *link para tela de login/cadastro*”. |

### 6. Protótipos de Interface
https://www.figma.com/file/Tf9R49Kc4vXWyyZdIGJ6oS/MovieCat?type=design&node-id=0-1&mode=design&t=jWPAjvdSx0PR4b4h-0

