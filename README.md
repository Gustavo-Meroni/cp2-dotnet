# Cafeteria

Projeto base em C# e Windows Forms para o trabalho em equipe. A tela inicial contém entradas para Produtos, Vendas e Relatórios. Os botões são pontos de partida; cada módulo deve ser desenvolvido em sua própria feature branch.

## Requisitos

- Windows com Visual Studio e suporte a desenvolvimento de aplicações .NET para desktop; ou SDK .NET 8 com suporte a Windows Forms.
- Git para o fluxo de branches e Pull Requests.

## Executar

Abra `Cafeteria.sln` no Visual Studio, restaure os pacotes se solicitado e pressione F5. No terminal Windows com o SDK instalado:

```powershell
dotnet run --project Cafeteria/Cafeteria.csproj
```

## Fluxo de trabalho

`main` guarda a versão principal. `dev` reúne as funcionalidades aprovadas. Cada tarefa começa em uma branch criada a partir de `dev`:

```bash
git clone https://github.com/Gustavo-Meroni/cp2-c-.git Cafeteria
cd Cafeteria
git switch dev
git pull origin dev
git switch -c feature/nome-da-tarefa
```

Faça pelo menos três commits pequenos e descritivos ao longo da tarefa. Depois publique a branch e abra um Pull Request **para `dev`**:

```bash
git push -u origin feature/nome-da-tarefa
```

O tech lead revisa o PR e aprova a integração. A passagem de `dev` para `main` também ocorre por PR. Não desenvolva diretamente nessas duas branches.

## Organização do projeto

- `Cafeteria/Program.cs`: entrada da aplicação.
- `Cafeteria/FormPrincipal.cs`: eventos da tela inicial.
- `Cafeteria/FormPrincipal.Designer.cs`: componentes visuais editáveis no designer do Visual Studio.

Cada novo formulário e classe de modelo pode ser adicionado dentro de `Cafeteria/`, em pastas como `Forms/` e `Models/`, conforme o módulo crescer.
