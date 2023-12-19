# Projeto MovieCat
## Especificação do caso de uso - Efetuar pedido de pacote

### Histórico da Revisão 

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 26/06/2023 | **1.00** | Versão Inicial  | Rita de Cassia |

### 1. Resumo 

Nesse caso de uso o cliente acessa o sistema, e por meio da pagina "home" visualiza os filmes, e clicando neles os seus pacotes.

### 2. Atores 

Usuarios cliente. 

### 3. Pré-condições

O cliente deve estar registrado no sistema para ter exito no pedido, porem visitantes tambem podem visualizar os pacotes existentes.

### 4. Pós-condições

O sistema mostra as sessões dos pacotes atuais.
### 5. Fluxos de Evento

#### 5.1. Fluxo Básico

| Ator   | Sistema |
|:-------|:--------|
| 1. O cliente escolhe uma determinada sessão e clica nela.| 2. O sistema exibe um firmulario onde pode ser selecionado a sala, horario e o audio(LEG, DUB, ORIG) do filme |
| 3. O cliente escolhe determinado pacote de acordo com suas preferencias.| 4. O sistema reserva determinado pacote para o cliente.|


#### 5.2. Fluxos de Exceção

| Exceção | Sistema |
|:--------|:--------|
| 1. Erro nas credenciais | se o cliente tentar reservar um o pacote, sem estar logado no sistema, o mesmo sera rederecionado para uma pagina de login/cadsstro. |

### 6. Protótipos de Interface
`A ser desenvolvido pelo aluno.`
