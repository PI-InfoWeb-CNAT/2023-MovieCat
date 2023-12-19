# Projeto MovieCat

## Especificação do caso de uso - Atualizar Funcionario
### Histórico da Revisão 

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 26/06/2023 | **1.00** | Versão Inicial  | Rita de Cassia |

### 1. Resumo 

Nesse caso de uso o funcionario pode editar funcionario existente no sistema.

### 2. Atores 

Usuarios admistradores.

### 3. Pré-condições

O admistrador pode editar um funcionario existente no sistema, acessando pelo home ou atravez do botão "funcionarios" no dashborad.

### 4. Pós-condições

O sistema mostra lista de funcionarios com os seguintes botões "Excluir", "ver" e "editar".

### 5. Fluxos de Evento

#### 5.1. Fluxo Básico

| Ator   | Sistema |
|:-------|:--------|
| 1. O admistrador  clica em “editar" na pagina de funcionarios| 2. O sistema mostra um formulario preenchido(Nome, cpf, data de nascimento, celular, email, senha, confirmar senha), permitindo a edição.|
| 3. O admistrador edita os campos desejado do formulario, e clica em "salvar"| 4. O sistema salva as alterações do funcionario do sistema e retorna para a listagem de funcionarios|


#### 5.2. Fluxos de Exceção

| Exceção | Sistema |
|:--------|:--------|
| 1. Erro nas informaçoes de funcionarios | se o admistrador tentar editar um funcionario com alguma informação invalida(Nome, cpf, data de nascimento, celular, email, senha, confirmar senha ) ou em campo vazio, o sistema retorna a mensagem de "Informaçoes invalidas" |
