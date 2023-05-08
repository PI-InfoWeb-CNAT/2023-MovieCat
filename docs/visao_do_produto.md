# Documento de Visão

## Sistema de Agendamento de Serviços

### Histórico da Revisão 

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 19/06/2021 |  **`1.00`** | Versão Inicial  | Gilbert Azevedo |
| 18/04/2023 |  **`1.01`** | Versão Atual  | Maria Cândida |
| 08/05/2023 |  **`1.02`** | Versão Atual  | Maria Cândida |



### 1. Objetivo do Projeto 

O projeto __AgendMovies__ tem como objetivo proporcionar uma alternativa simples e dinâmica para compras de sessões de cinema através da compra de múltiplos ingressos por somente um usuário. Dessa forma, o serviço se torna mais ágil e reduz a insatisfação e desistência do cliente, além de evitar perdas monetárias por parte da empresa. 

### 2. Descrição do Problema 

|         __        | __   |
|:------------------|:-----|
| **_O problema_**    | O metódo tradicional da compra de ingressos para um grupo numeroso de pessoas muitas vezes gera clientes insatisfeitos com o serviço em função do tempo gasto aguardando atendimento, o que pode acarretar uma perda monetária significativa para a empresa. Pois quando se é feito um passeio com 5 ou mais pessoas, é preciso comprar, pagar e confirmar todas as unidades de ingressos individualmente, sendo assim um processo longo e que não é prático.  |
| **_afetando_**      | A empresa, seus funcionários, clientes e o bom funcionamento do local.  |
| **_cujo impacto é_**| Perda e insatisfação de clientes. |
| **_uma boa solução seria_** | Uma aplicação web que permita que um cliente efetue a compra de um pacote de ingressos para múltiplas pessoas. Essa funcionalidade seria eficiente em atender passeios escolares ou famílias. |

### 3. Descrição dos Usuários

| Nome | Descrição | Responsabilidades |
|:---  |:--- |:--- |
| Administrador  | É o usuário responsável por manter os cadastros iniciais do sistema | Cadastra os filmes e funcionários | Cadastra as sessões dos filmes | Cadastra os pacotes de ingresso | 
| Funcionário  | Confere os códigos dos pacotes na entrada do cinema  | Consulta pedidos de pacote de ingresso e faz o cadastro de sessões | Confirma a compra de pedidos de pacote | 
| Cliente | Visualiza filmes, sessões e pacotes de ingresso | Realiza pedido de pacotes de ingresso | Compra de pacotes de ingresso
| Visitante | Visualiza filmes, sessões e pacotes de ingresso | Realiza cadastro como cliente | 


### 4. Descrição do Ambiente dos Usuários

O sistema irá atender a usuários em qualquer ambiente desde que tenha acesso à internet. A compra ou efetuação do pedido pelo usuário cliente será feita através de um computador ou celular e o contato com algum funcionário daquela empresa só ocorrerá presencialmente, sendo apenas possível a visualização e compra dos pacotes disponibilizados no site.
O uso da aplicação web deve ser intuitivo e descomplicado, não trazendo problemas ao usuário que está acessando o sistema.

O sistema será acessado pelos funcionários através de computadores disponibilizados no ambiente de trabalho.

### 5. Principais Necessidades dos Usuários

Para empresas, a necessidade é evitar perdas financeiras e promover uma melhoria na administração de compra e venda de ingressos.

Para os clientes, as necessidades são de evitar o gasto de tempo numa fila e efetuar uma compra de múltiplos ingressos de maneira prática.

### 6.	Alternativas Concorrentes

Já existe o processo de compra unitária de ingressos online e opções de pacotes. No entanto, a compra individual para um grande grupo resulta num tempo maior de espera; e os pacotes fornecidos por essas empresas de cinema são para atender grandes demandas (30 pessoas), sendo uma reserva da sala do cinema.

### 7.	Visão Geral do Produto

De um modo geral, nosso sistema busca a promoção de mais praticidade na compra de múltiplos ingressos para uma sessão de cinema.

### 8. Requisitos Funcionais

| Código | Nome | Descrição |
|:---  |:--- |:--- |
| RF01 | Autocadastro | Usuários fazem o auto cadastro no site para realizar pedido |
| RF02 | Entrar no sistema | Usuários entram no sistema para acessar as opções de pedidos e pagamentos |
| RF03 | Gerenciamento de pedidos | Cliente realiza o pedido, confirma a compra ou cancela compras já efetuadas |
| RF04 | Gerenciamento da Agenda | Administrador registra os horários disponíveis de sessões |
| RF05 | Cadastro de funcionários | Administrador insere funcionários no sistema |
| RF06 | Cadastro de filmes | Administrador registra os filmes disponíveis |
| RF07 | Consulta de Pedidos | Usuário consulta seus pedidos já feitos  |
| RF08 | Conferência dos códigos de pacotes | O funcionário confere os dados do pacote para liberar o acesso do cliente à sessão |
| RF09 | Gerenciamento de pacotes | Administrador registra opções de pacotes |
| RF10 | Visualização de sessões | O cliente visualiza filmes, sessões e pacotes |


### 9. Requisitos Não-funcionais

 Código | Nome | Descrição | Categoria | Classificação
|:---  |:--- |:--- |:--- |:--- |
| RNF01 | Design responsivo | O sistema deve adaptar-se a qualquer tamanho de tela de dispositivo, seja, computador, tablets ou smart phones. | Usabilidade| Obrigatório |
| RNF02 | Controle de acesso | Só usuários autenticados podem efetuar pedidos. | Segurança | Obrigatório |
| RNF03 | Sistema Web | A aplicação deve ser um site. | Arquitetura | Obrigatório |
| RNF04 | Dados pessoais | Os clientes não devem visualizar dados de outros clientes (na agenda, por exemplo). | Privacidade | Obrigatório |
