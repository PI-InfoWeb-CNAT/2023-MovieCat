# Projeto MovieCat

## Especificação do caso de uso - Atualizar pacotes

### Histórico da Revisão 

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 26/06/2023 | **1.00** | Versão Inicial  | Rita de Cassia |

### 1. Resumo 

Nesse caso de uso o funcionario pode atualizar um pacote existente no sistema.

### 2. Atores 

Usuarios funcionario.

### 3. Pré-condições

O funcionario pode atualizar um pacote existente no sistema, acessando pelo home ou atravez do botão "pacotes" no dashborad.

### 4. Pós-condições

O sistema mostra lista de pacotes com os seguintes botões "Excluir", "Adicionar" e "editar".

### 5. Fluxos de Evento

#### 5.1. Fluxo Básico

| Ator   | Sistema |
|:-------|:--------|
| 1. O funcionario clica em “editar" na pagina de pacotes| 2. O sistema mostra um formulario preenchido(Nome do pacote, numero de ingressos e valor), permitindo a edição.|
| 3. O funcionario edita os campos desejado do formulario, e clica em salvar| 4. O sistema salva as alterações do pacote do sistema e retorna para a listagem de pacotes|


#### 5.2. Fluxos de Exceção

| Exceção | Sistema |
|:--------|:--------|
| 1. Erro nas informaçoes de pacotes | se o funcionario tentar editar o pacote com alguma informação invalida(nome do pacote, numero de ingressos, valor ) ou em campo vazio, o sistema retorna a mensagem de "Informaçoes invalidas" |
