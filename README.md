# Gifts Wishlist POC Workspace

Monorepo scaffold for autonomous AI-agent-driven development of a Gifts Wishlist POC.

## Tech Stack
- Backend: .NET 10 (ASP.NET Core Web API)
- Frontend: Flutter Web (latest stable in CI)
- Database: SQLite (placeholder configuration)
- Auth: Email + password (placeholder configuration)
- E2E: Playwright (deterministic smoke test)

> This setup intentionally contains **no business features yet** (no wishlist CRUD, no auth flow, no Shopee scraping implementation).

## Repository Structure
- `backend/` - .NET 10 Web API + xUnit tests
- `frontend/` - Flutter web app scaffold
- `e2e/` - Playwright deterministic smoke tests
- `docs/` - specs, ADRs, QA checklist, autonomous execution playbook
- `.github/` - issue templates, PR template, CI/deploy workflows

## Local Run

### Backend
```bash
cd backend
dotnet build Wishlist.Backend.slnx
dotnet test Wishlist.Backend.slnx
cd src/Wishlist.Api
dotnet run
```
Backend health endpoint: `http://localhost:5000/health` (or assigned local port)

### Frontend
```bash
cd frontend
flutter pub get
dart analyze
flutter test
flutter build web
flutter run -d web-server --web-hostname 0.0.0.0 --web-port 3000
```

### E2E
```bash
cd e2e
npm ci
npx playwright install --with-deps chromium
npm test
```

## Standard Commands
- Backend build: `cd backend && dotnet build Wishlist.Backend.slnx`
- Backend test: `cd backend && dotnet test Wishlist.Backend.slnx`
- Frontend analyze: `cd frontend && dart analyze`
- Frontend test: `cd frontend && flutter test`
- Frontend build: `cd frontend && flutter build web`
- E2E smoke: `cd e2e && npm test`
