# Sistema de Gestão de Tarefas Kanban

## Bem-vindo ao Projeto de Sistema de Kanban em C#

Seja muito bem-vindo! O objetivo deste projeto é criar um **Sistema de Gestão de Tarefas** utilizando **C# com o Framework .NET**. Este sistema simula um quadro Kanban para gerenciar o progresso de tarefas, com três categorias: "A Fazer", "Em Progresso" e "Concluído". O projeto permite adicionar tarefas, visualizar seu progresso e movê-las entre os estados.

---

## Interface do Sistema

### Menu de Opções

Aqui está a interface inicial do sistema, exibida no console:

```plaintext
1 - Adicionar nova tarefa
2 - Exibir tarefas
3 - Mover tarefa
4 - Sair
```

## Funcionalidades Implementadas

### 1. Menu de Opções
- **Descrição:** O menu principal oferece ao usuário diferentes opções de interação com o sistema.

- **Funcionalidades:**
  - Contém o cabeçalho, rodapé e menu de navegação.
  - Utiliza placeholders para inserção do conteúdo das páginas internas.
  - Adicionar novas tarefas à lista "A Fazer".
  - Exibir todas as tarefas nas listas "A Fazer", "Em Progresso" e "Concluído".
  - Mover tarefas entre as listas.
  - Sair do sistema.

### 2. Adição de Novas Tarefas
- **Descrição:** Permite ao usuário adicionar uma nova tarefa.
- **Funcionalidades:**
  - Solicita o nome da nova tarefa ao usuário.
  - Adiciona a tarefa à lista "A Fazer".

### 3. Exibição das Tarefas
- **Descrição:** Exibe as tarefas organizadas em três categorias.
- **Funcionalidades:**
  - Mostra as tarefas nas listas "A Fazer", "Em Progresso" e "Concluído".
  - Atualiza automaticamente a lista conforme as tarefas são adicionadas ou movidas.

### 4. Mover Tarefas
- **Descrição:** Permite mover uma tarefa de uma lista para outra.
- **Funcionalidades:**
  - As tarefas podem ser movidas:
    - De "A Fazer" para "Em Progresso".
    - De "Em Progresso" para "Concluído".
    - Podem ser retornadas para estágios anteriores, se necessário.

### 5. Validação Básica
- **Descrição:** Valida a entrada do usuário no menu.
- **Funcionalidades:**
  - Garante que o usuário escolha uma opção válida no menu.
  - Lida com entradas inválidas e exibe mensagens de erro apropriadas.

## Como Executar o Projeto

1. Clone este repositório:  
   ```bash
   git clone https://github.com/seuusuario/Simulator-Nivel4.git

2. Abra o projeto no Visual Studio.

3. Compile o projeto:
   ```bash
   dotnet build

4. Execute o projeto:
   ```bash
   dotnet run

## Tecnologias Utilizadas
- **.NET Framework 4.8**

- **Console Application**

- **C#**

