# ADR 0001 - Monorepo com pipelines separados

## Status
Aceito

## Contexto
Necessidade de acelerar desenvolvimento autônomo com PR por feature, mantendo governança e validação por stack.

## Decisão
Adotar monorepo com diretórios independentes (`backend`, `frontend`, `e2e`) e pipelines separados de CI, além de deploy workflows manuais placeholder para AWS.

## Consequências
- Facilita rastreabilidade e automação por feature
- Reduz acoplamento entre validações de backend e frontend
- Permite evoluir deploy em passos seguros sem bloquear setup inicial
