# Projeto AgendMovies

## Especificação do caso de uso - Página Inicial AgendMovies

### Histórico da Revisão 

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 19/06/2023 | **1.00** | Versão Inicial  | Milton Shyon |

### 1. Resumo 

Nesse caso de uso o usuário acessa o endereço do AgendMovies e o sistema exibe a LandPage com o menu de acesso para as demais páginas, a opção de login, uma exibição de filmes a serem exibidos, os filmes em cartaz e as funcionalidades que o cinema dispõe (cadeiras xd e salas d-box) 

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
| 1. O usuário acessa a página do AgendMovies.| 2. O sistema exibe o HomePage AgendMovies, permitindo ao usuário visualizar o menu de acesso para as demais páginas |
| 3. O usuário seleciona o ícone de perfil na página | 4. O sistema redireciona para página de login //e/ou de cadastro |
| 5. O usuário faz o login ou se cadastra no sistema| 6. O sistema redireciona novamente para a HomePage, agora com a possibilidade de fazer pedidos no site |
| 7. O usuário clica no ícone de tela com a opção “mudar tema”  | 8. O sistema altera o tema do site para o tema oposto ao que está naquele momento.|
| 9. O usuário clica em “filmes”  | 10. O sistema exibe a lista de filmes disponíveis separados por tópicos (Nesta semana, em promoção, em breve,D-Box e XD ) .|
| 11. O usuário clica em determinado filme. | 12. O sistema o redireciona para uma página interna onde ele pode visualizar detalhes do filme, os horários de exibição dele e também fazer o pedido de um pacote. |
| 13. O usuário volta a página home e seleciona calendário. | 14. O sistema exibe uma lista de filmes que estarão disponíveis em breve exibidos por ano e mês. |
| 15. O usuário volta a página home e seleciona cinema. | 16. O sistema  exibe a página de cinema mais próximos onde pode ser filtrado por localização . |
| 17. O usuário filtra por determinada localização. | 18. O sistema mostra o cinema mais próximo da localização filtrada. |
| 19. O usuário volta a pagina home e seleciona “compra ingresso” do cartaz. | 20. O sistema redireciona para a pagina de compra de ingresso daquele filme do cartaz.|
| 21. O usuario volta a pagina home, e seleciona “ver mais” em " Em breve”. | 22. O Sistema redireciona para o calendário. |
| 23. O usuário volta para homePage e seleciona “ver mais” em “em cartaz” | 24. O sistema redireciona para a pagina de filmes.|

#### 5.2. Fluxos de Exceção

| Exceção | Sistema |
|:--------|:--------|
| 1. Compra de ingresso sem cadastro| Se o funcionário tentar comprar um pacote de ingressos sem possuir cadastro prévio, o sistema deve apresentar a mensagem de “Para realizar compras no site necessita de cadastro prévio ou login deseja entrar ou fazer cadastro? *link para tela de login/cadastro*”. |

### 6. Protótipos de Interface
https://www.figma.com/file/kU2Ogqn2V2mUKLoDF249vz/AgendMovies?type=design&node-id=0%3A1&t=ppw9288UsgGnDo1W-1

