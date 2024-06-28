# TaskManagerApp - Desafio de Programação

Bem-vindo ao desafio TaskManagerApp! Este repositório contém dois projetos:

- [TaskManagerApp-Frontend](TaskManagerApp-Frontend): Aplicativo frontend desenvolvido em React Native.
- [TaskManagerApp-Backend](TaskManagerApp-Backend): API backend desenvolvida em C#.

Cada projeto possui instruções específicas para configuração e execução. Siga as instruções abaixo para configurar e rodar os projetos.

## Sobre o Desafio

O TaskManagerApp possui algumas falhas intencionais, tanto de lógica quanto de ciclo de vida, além de alguns problemas de UI/UX e integração com API. Seu desafio é identificar e corrigir esses problemas, tornando a aplicação funcional e eficiente.

### Funcionalidades do Aplicativo

- **Criar Tarefas**: Adicione novas tarefas com título, descrição, status e data de vencimento.
- **Listar Tarefas**: Veja a lista de todas as tarefas criadas.
- **Editar Tarefas**: Atualize as informações de qualquer tarefa existente.
- **Excluir Tarefas**: Remova tarefas que não são mais necessárias.

## Estrutura do Repositório
```plaintext
TaskManagerApp/
├── TaskManagerApp-Backend/
│   ├── TaskManagerAPI/
│   │   ├── Controllers/
│   │   │   └── TasksController.cs
│   │   ├── Data/
│   │   │   ├── Migrations/
│   │   │   └── TaskContext.cs
│   │   ├── Models/
│   │   │   └── Task.cs
│   │   ├── Repositories/
│   │   │   ├── ITaskRepository.cs
│   │   │   └── TaskRepository.cs
│   │   ├── Services/
│   │   │   └── TaskService.cs
│   │   ├── appsettings.json
│   │   ├── Program.cs
│   │   ├── Startup.cs
│   │   └── tasks.db
├── TaskManagerApp-Frontend/
│   ├── assets/
│   ├── components/
│   │   ├── ApiComponent.js
│   │   ├── FeedbackModal.js
│   │   ├── TaskForm.js
│   │   ├── TaskItem.js
│   │   └── TaskList.js
│   ├── screens/
│   │   ├── HomeScreen.js
│   │   └── TaskScreen.js
│   ├── services/
│   │   └── api.js
│   ├── .gitignore
│   ├── App.js
│   ├── app.json
│   ├── babel.config.js
│   ├── metro.config.js
│   ├── package-lock.json
│   ├── package.json
│   └── yarn.lock
└── README.md
```



## Instruções para Execução

### Frontend (React Native)

1. **Clone o repositório**:
    ```sh
    git clone https://github.com/devtecnowise/TaskManagerApp.git
    ```
2. **Navegue até o diretório do frontend**:
    ```sh
    cd TaskManagerApp/TaskManagerApp-Frontend
    ```
3. **Instale as dependências**:
    ```sh
    npm install
    ```
4. **Inicie o projeto**:
    ```sh
    expo start
    ```

### Backend (C#)

1. **Navegue até o diretório do backend:**:
    ```sh
	cd TaskManagerApp/TaskManagerApp-Backend/TaskManagerAPI

    ```
2. **Restaure as dependências:**:
    ```sh
    dotnet restore
    ```
3. **Atualize o banco de dados:**:
    ```sh
    dotnet ef database update
    ```
4. **Inicie a aplicação:**:
    ```sh
    dotnet run
    ```

### Desafios que Você Encontrará

- **Erros de Sintaxe**: Corrija pequenos erros de sintaxe que impedem a compilação.
- **Erros de Ciclo de Vida**: Ajuste os métodos de ciclo de vida para garantir a atualização e o funcionamento correto dos componentes.
- **Erros de Lógica**: Corrija problemas de lógica, como variáveis não definidas e funções incorretas.
- **Problemas de Performance**: Otimize o código para melhor desempenho.
- **Erros de UI/UX**: Melhore a interface do usuário para uma experiência mais suave.
- **Erros de Integração com API**: Resolva falhas nas chamadas de API para garantir a comunicação correta com o backend.

## Como Participar

1. **Fork este repositório** para sua conta do GitHub.
2. Clone o repositório forkado para sua máquina local:
    ```sh
    git clone https://github.com/seu-usuario/TaskManagerApp.git
    ```
3. Resolva os problemas encontrados no código.
4. Faça commit e push das suas alterações para o seu repositório no GitHub.
5. Envie o link do seu repositório forkado para o e-mail: [dev@tecnowise.com.br](mailto:dev@tecnowise.com.br)

## Contato

Se tiver alguma dúvida ou precisar de assistência, não hesite em entrar em contato pelo e-mail: [dev@tecnowise.com.br](mailto:dev@tecnowise.com.br)

Boa Sorte =)
