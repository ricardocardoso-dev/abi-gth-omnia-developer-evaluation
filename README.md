# Wishlist POC - Autonomous Development Workspace

Monorepo scaffold para desenvolvimento orientado por agentes de IA, com execução sequencial por feature (PR por feature), CI obrigatório e documentação de governança.

## Estrutura

- `backend/` — ASP.NET Core Web API (.NET 10) + testes
- `frontend/` — Flutter web + testes
- `e2e/` — Playwright smoke tests
- `docs/` — especificação, checklist de QA, playbook autônomo e ADRs
- `.github/` — templates e workflows de CI/deploy

## Pré-requisitos locais

- .NET SDK 10
- Flutter (stable)
- Node.js 20+
- npm 10+

## Comandos padrão

### Backend

```bash
cd backend
dotnet restore Wishlist.Backend.sln
dotnet build Wishlist.Backend.sln --no-restore
dotnet test Wishlist.Backend.sln --no-build
```

### Frontend

```bash
cd frontend
flutter pub get
dart analyze
flutter test
flutter build web
```

### E2E (smoke)

```bash
cd e2e
npm ci
npx playwright install --with-deps
```

Em outro terminal, subir servidores locais:

```bash
# terminal 1
cd backend
dotnet run --project src/Wishlist.Api/Wishlist.Api.csproj --urls http://127.0.0.1:5000

# terminal 2
python3 -m http.server 4173 --directory frontend/web
```

Executar testes:

```bash
cd e2e
npm test
```

## Fluxo de desenvolvimento autônomo

1. Criar/selecionar issue de feature
2. Abrir branch `agent/issue-<numero>-<slug>`
3. Implementar somente o escopo da issue
4. Rodar comandos padrão (backend/frontend/e2e conforme aplicável)
5. Abrir PR preenchendo template e checklist de DoD
6. Só avançar para próxima issue com CI verde
