# Autonomous Development Playbook

## Branch naming
- `agent/issue-<numero>-<slug-curto>`

## Sequenciamento obrigatório
1. Selecionar uma única issue pronta para execução
2. Planejar tarefas em checklist
3. Implementar + testar
4. Abrir PR
5. Aguardar CI verde
6. Só então iniciar próxima issue

## Comandos obrigatórios por PR
- Backend: `dotnet build` e `dotnet test`
- Frontend: `flutter pub get`, `dart analyze`, `flutter test`, `flutter build web`
- E2E: `npm ci`, `npx playwright install --with-deps`, `npm test`

## Quando CI falhar
1. Ler logs do job com falha
2. Corrigir a causa raiz mínima
3. Rodar localmente o mesmo comando
4. Atualizar PR com evidência da correção

## Papéis de agentes (subagentes lógicos)
- **Planner Agent**: quebra épico em features sequenciais
- **Backend Agent**: implementações e testes no backend
- **Frontend Agent**: implementações e testes no frontend
- **QA Agent**: e2e, checklist de DoD e validação final

## Prompt base para execução de feature
"Implemente apenas a issue <ID> nesta branch, mantenha mudanças mínimas, atualize testes e documentação necessários, rode os comandos obrigatórios e não avance para outra issue sem CI verde."

## Prompts prontos
Ver `docs/agent-prompts.md` para prompts de orquestrador e subagentes.
