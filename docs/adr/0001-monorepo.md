# ADR 0001 - Use Monorepo for Wishlist POC

## Status
Accepted

## Context
The project requires autonomous AI-agent development with one PR per feature, strict CI gates, and split frontend/backend deploy pipelines.

## Decision
Adopt a monorepo containing backend, frontend, e2e, docs, and GitHub governance/automation files.

## Consequences
### Positive
- Single source of truth for code, docs, and pipelines.
- Easier CI gate enforcement across components.
- Straightforward orchestration for autonomous sequential delivery.

### Negative
- CI config is more complex than single-app repos.
- Team must keep discipline on feature-scoped PRs.
