# Gifts Wishlist POC - High-Level Spec

## Goal
Build a Gifts Wishlist POC with autonomous AI-agent workflow and strict CI quality gates.

## Scope (POC)
- One wishlist per user.
- Auth model: email + password (simple).
- Scraping scope: Shopee only.
- Frontend language: PT-BR and responsive layout.
- Monorepo with separated backend/frontend deployment pipelines.

## Out of Scope (for setup phase)
- Real auth flows.
- Real Shopee scraping implementation.
- Wishlist CRUD business logic.

## Acceptance Criteria for Setup PR
- Monorepo scaffold created for backend/frontend/e2e/docs/.github.
- Backend, frontend and e2e skeletons are present and CI-wired.
- CI gates include build, lint/analyze, tests and deterministic E2E.
- Deploy placeholder workflows exist for AWS with TODO + required secrets documented.
- Governance files exist (issue templates, PR template, playbook, ADR, QA checklist).
