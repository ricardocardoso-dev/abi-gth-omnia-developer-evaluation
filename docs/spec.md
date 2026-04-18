# Especificação Inicial - Workspace Monorepo

## Objetivo
Configurar um workspace inicial para desenvolvimento autônomo de features em sequência, com gates de CI para backend, frontend e e2e.

## Escopo desta etapa (setup)
- Estrutura monorepo criada
- Projetos placeholder para backend/frontend/e2e
- Workflows CI para pull_request e push em main
- Templates de governança para PR e issues
- Workflows de deploy AWS em modo placeholder/manual

## Fora de escopo
- Implementação de regras de negócio da wishlist
- Scraping Shopee real
- Deploy produtivo em AWS

## Critérios de aceite
- Fresh checkout executa workflows de CI sem flakiness
- Smoke test e2e valida backend e frontend ativos
- Documentação de operação autônoma disponível em `docs/autonomous-dev-playbook.md`
