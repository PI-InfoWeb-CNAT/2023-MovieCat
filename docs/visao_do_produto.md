# Documento de Visão

## Sistema de Agendamento de Serviços

### Histórico da Revisão 

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 19/06/2021 |  **`1.00`** | Versão Inicial  | Gilbert Azevedo |


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

Em várias atividades do cotidiano humano é necessário agendar um horário determinado para que uma ação específica seja realizada. Isso ocorre, por exemplo, quando um automóvel vai ser revisado em uma oficina, quando um médico vai consultar um paciente ou quando consertos diversos (hidráulicos, elétricos, dentre outros) são realizados em uma residência. 

Em muitas dessas situações, o cliente precisa atualmente estabelecer um contato pessoal com o profissional ou com a empresa prestadora do serviço para agendar um atendimento. E, como isso é normalmente realizado por telefone ou aplicativo de mensagens, encontrar um horário de atendimento possível para ambas as partes pode ser custoso, pois há a necessidade de encontrar um horário viável para os dois envolvidos.

Desta forma, a ideia central do sistema é permitir que empresas e profissionais registrem suas disponibilidades de atendimento e que clientes, em geral, possam consultar e agendar horários para realização e contratação de serviços. Com isso, o sistema pode estabelecer um canal de comunicação mais ágil entre clientes e empresas ou profissionais.

### 5. Principais Necessidades dos Usuários

Para empresas e profissionais, a necessidade é divulgar sua disponibilidade de atendimentos para viabilizar, de forma mais eficiente, o atendimento dos seus clientes.

Para os clientes, as necessidades são encontrar profissionais e empresas prestadoras de serviço e agendar atendimentos com estes de acordo as disponibilidades de tempo dos envolvidos.

### 6.	Alternativas Concorrentes

As alternativas concorrentes são, em geral, específicas para uma empresa ou profissional. A ideia do sistema proposto é prover uma solução simples, acessível e padronizada para o agendamento de serviços e que pode ser utilizada por quaisquer profissionais e empresas.

### 7.	Visão Geral do Produto

Em resumo, o sistema de Agendamento de Serviços é uma aplicação que permite empresas e profissionais registrarem suas disponibilidades de atendimento aos seus clientes, de forma que estes possam consultar e agendar horários para realização de serviços.

O sistema deve ter uma interface amigável e permitir o acesso concorrente de clientes para agendamento de um horário de atendimento.

### 8. Requisitos Funcionais

| Código | Nome | Descrição |
|:---  |:--- |:--- |
| RF01 | Entrar no sistema | Usuários devem logar no sistema para acessar as funcionalidades relacionadas ao agendamento |
| RF02 | Cadastro de Funcionários | Administrador do sistema mantém o cadastro dos funcionários responsáveis pelo gerenciamento das agendas |
| RF03 | Gerenciamento de Serviços |  Funcionário mantém a relação de serviços prestados pela empresa ou profissional |
| RF04 | Gerenciamento da Agenda | Funcionário registra os horários disponíveis de atendimento, confirma e cancela o agendamento de clientes |
| RF05 | Cadastro de Clientes | Cliente deve realizar o auto cadastramento |
| RF06 | Consulta de Agendas | Cliente consulta agendas de atendimento dos serviços disponíveis, podendo agendar um serviço  |
| RF07 | Consulta de Agendamento | Cliente consulta atendimentos agendados, podendo cancelar um agendamento |


### 9. Requisitos Não-funcionais

 Código | Nome | Descrição | Categoria | Classificação
|:---  |:--- |:--- |:--- |:--- |
| RNF01 | Design responsivo | O sistema deve adaptar-se a qualquer tamanho de tela de dispositivo, seja, computador, tablets ou smart phones. | Usabilidade| Obrigatório |
| RNF02 | Criptografia de dados| Senhas de usuários devem ser gravadas de forma criptografada no banco de dados. | Segurança | Obrigatório |
| RNF03 | Controle de acesso | Só usuários autenticados podem ter acesso ao sistema, com exceção ao auto cadastramento do usuário. | Segurança | Obrigatório |
| RNF04 | Tempo de resposta |A comunicação entre o servidor e o cliente deve ocorrer em tempo hábil | Performance | Desejável |
| RNF05 | Sistema Web | A aplicação deve ser um site. | Arquitetura | Obrigatório |
| RNF06 | Dados pessoais | Os clientes não devem visualizar dados de outros clientes (na agenda, por exemplo). | Privacidade | Obrigatório |
