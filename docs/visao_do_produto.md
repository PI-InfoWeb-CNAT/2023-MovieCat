# Documento de Visão

## Sistema de Agendamento de Serviços

### Histórico da Revisão 

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 19/06/2021 |  **`1.00`** | Versão Inicial  | Gilbert Azevedo |
| 18/04/2023 |  **`1.00`** | Versão Atual  | Maria Cândida |


### 1. Objetivo do Projeto 

O projeto __AgendMovies__ tem como objetivo proporcionar uma alternativa rápida, simples e dinâmica para ambas as faces do comércio: público/funcionário; promovendo, assim, um serviço mais ágil e tranquilo, evitando que o cliente despenda muito tempo em filas que possivelmente comprometem seu tempo de filme, logo prejudicando sua experiência e aumentando as possibilidades de desistência e não retorno ao local, o que por sua vez prejudica financeiramente a empresa e seus funcionários, que no método tradicional também trabalham sob muito mais pressão.

### 2. Descrição do Problema 

|         __        | __   |
|:------------------|:-----|
| **_O problema_**    | O metódo tradicional da compra de ingressos muitas vezes gera clientes insatisfeitos com o serviço em função do tempo gasto aguardando atendimento e da exaustão dos funcionários que são poucos para uma grande demanda diária, gerando assim um estresse mútuo desnecessário que pode causar uma perca monetária significativa para a empresa.  |
| **_afetando_**      | A empresa, seus funcionários, clientes e o bom funcionamento e imagem do local, que sem a automatização desse serviço se torna ineficaz em propiciar uma maior satisfação social. |
| **_cujo impacto é_**| Maiores dificuldades na administração e no atendimento, com impacto direto no bem estar de funcionários e clientes. |
| **_uma boa solução seria_** | Uma aplicação web que permita que os clientes agendem o horário da compra presencial de ingressos, se dirigindo em ordem de agendamento ao caixa para efetuar a compra, podendo assim aproveitar seu tempo de tela sem muitos problemas e não sendo preciso aguardar na fila. Essa funcionalidade promoveria atendimento da demanda daqueles usuários que por algum motivo não conseguem efetuar a compra de ingressos online (estudantes que não possuem a carteira oficial de estudante, pessoas sem acesso a dinheiro virtual e usuários não familiarizados com a tecnologia, já que a solicitação de atendimento fisico seria muito mais descomplicada). |

### 3. Descrição dos Usuários

| Nome | Descrição | Responsabilidades |
|:---  |:--- |:--- |
| Administrador  | Realiza as atividades básicas para o início da operação do sistema | Faz o gerenciamento de compras e atendimentos |
| Funcionário  | Realiza acesso constante ao sistema | Efetua o processo de compra do cliente; consulta a situação das agendas de serviços; mantém a agenda de atendimento; confirma o agendamento de clientes e exclui o agendamento de clientes |
| Usuário | Efetua o processo de agendamento do atendimento via web | Realiza o próprio cadastro no sistema; consulta a agenda de serviços e disponibilidades de atendimento; agenda um serviço; consulta seus agendamentos e cancela um agendamento |
| Cliente | Participa do processo de atendimento fisico | Confirma as informações empregues no site e faz a compra de ingressos |

### 4. Descrição do Ambiente dos Usuários

Atualmente a tecnologia avançou em níveis surpreendentes e vem ganhando cada vez mais espaço em nossas vidas e cotidianos, possibilitando hoje a realização de qualquer compra sem sair de casa, utilizando dinheiro virtual, aplicativos bancários etc.  No entanto, muitos indivíduos enfrentam dificuldades com a adaptação de uma vida conectada á internet e no manuseio desses apps financeiros e operações de compra web, realizando, assim, suas atividades referentes ao tópico anteriormente citado de modo presencial, a exigir do indíviduo seu deslocamento até o local e possivelmente uma experiência mais estressante.
 
A mediação do contato cliente/funcionário através de um agendamento de serviço evitaria a longa espera em filas e melhor direcionamento organizacional social levando em consideração os horários das sessões dos filmes, preservando assim o tempo do cliente e valorizando o tempo do funcionários, trazendo uma experência mais agradável e confortavél para o cliente que se torna mais suscetível ao retorno naquela empresa.

Desta forma, a ideia central do sistema é permitir que pessoas que por algum motivo não podem efetuar a compra online do ingresso também tenham uma boa e tranquila ida ao cinema, não precisando esperar em filas e dessa forma gerando um diferencial no atendimento daquela empresa que fornece opções mais acessível ao seu público. A ideia é que esse agendamento seja intuitivo e descomplicado, não trazendo problemas ao usuário que está fazendo o acesso.

### 5. Principais Necessidades dos Usuários

Para empresas, a necessidade é divulgar sua disponibilidade de atendimentos presenciais agendados para viabilizar, de forma mais eficiente, o atendimento dos seus clientes.

Para os clientes, as necessidades são evitar o gasto de tempo numa fila sem abrir mão do atendimento presencial, no qual ele pode receber orientações de um funcionário que guiará o processo de compra.

### 6.	Alternativas Concorrentes

No presente momento não há ideias semelhantes sendo postas em prática em nenhum estabelecimento comercial de modo geral, no entanto, o mais próximo disso que pode ser posto como objeto de comparação seria a compra online de ingressos - da qual já viabiliza o acesso rápido as telas e evita filas enormes, no entanto, existe a problemática de não atender a um determinado público frequentador do local; e também há a forma tradicional de filas, que por sua vez submete ao cliente muitas vezes um longo tempo de aguardo para poder comprar seu ingresso. Sendo nossa solução uma nova implementação efeciente e que não excluiria as opções anteriores mas certamente atenderia e promoveria satisfação ao seu público alvo.

### 7.	Visão Geral do Produto

De um modo geral, nosso sistema busca a introdução de alternativas de compra online de ingressos via web agendamento que sejam acessíveis à demanda de pessoas com pouca ou nenhuma familiaridade com a internet ou que por alguma outra razão não podem efetuar a compra, dessa forma atendendo um maior número de pessoas gerando uma satisfação maior associada a empresa que reflete em maiores lucros e no marketing.

### 8. Requisitos Funcionais

| Código | Nome | Descrição |
|:---  |:--- |:--- |
| RF01 | Entrar no sistema | Usuários devem logar no sistema para acessar as funcionalidades relacionadas ao agendamento |
| RF02 | Cadastro no sistema | Usuários disponibilizam algumas informações que serão confirmadas presencialmente |
| RF03 | Gerenciamento de Serviços | Funcionário faz a confirmação de informações e checa os horários de atendimentos  |
| RF04 | Gerenciamento da Agenda | Funcionário registra os horários disponíveis de atendimento, confirma e cancela o agendamento de clientes |
| RF05 | Consulta de Agendas | Cliente consulta agendas de atendimento dos serviços disponíveis, podendo agendar um serviço  |
| RF06 | Consulta de Agendamento | Cliente consulta atendimentos agendados, podendo cancelar um agendamento |


### 9. Requisitos Não-funcionais

 Código | Nome | Descrição | Categoria | Classificação
|:---  |:--- |:--- |:--- |:--- |
| RNF01 | Design responsivo | O sistema deve adaptar-se a qualquer tamanho de tela de dispositivo, seja, computador, tablets ou smart phones. | Usabilidade| Obrigatório |
| RNF02 | Criptografia de dados| Senhas de usuários devem ser gravadas de forma criptografada no banco de dados. | Segurança | Obrigatório |
| RNF03 | Controle de acesso | Só usuários autenticados podem ter acesso ao sistema, com exceção ao auto cadastramento do usuário. | Segurança | Obrigatório |
| RNF04 | Tempo de resposta |A comunicação entre o servidor e o cliente deve ocorrer em tempo hábil | Performance | Desejável |
| RNF05 | Sistema Web | A aplicação deve ser um site. | Arquitetura | Obrigatório |
| RNF06 | Dados pessoais | Os clientes não devem visualizar dados de outros clientes (na agenda, por exemplo). | Privacidade | Obrigatório |
