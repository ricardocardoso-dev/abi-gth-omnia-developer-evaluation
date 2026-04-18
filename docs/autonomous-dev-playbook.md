# Autonomous Development Playbook

## Objective
Enable sequential autonomous delivery with one PR per feature and strict CI gates.

## Branch/PR Conventions
- Branch: `agent/issue-<number>-<short-slug>`
- One feature per PR.
- PR must use `.github/pull_request_template.md` checklist.

## Agent Roles (sub-agent style orchestration)
1. **Planner Agent**
   - Break epic into ordered feature issues.
   - Define acceptance criteria and tests for each issue.
2. **Backend Agent**
   - Implements backend code + tests for current issue.
3. **Frontend Agent**
   - Implements frontend code + tests for current issue.
4. **QA Agent**
   - Adds/updates E2E and validates CI gates.
5. **Release Agent**
   - Verifies docs and readiness checklist before merge.

## Sequential Execution Loop
1. Pick top-priority open feature issue.
2. Create branch.
3. Implement minimal solution + tests.
4. Run local checks:
   - `cd backend && dotnet test Wishlist.Backend.slnx`
   - `cd frontend && dart analyze && flutter test && flutter build web`
   - `cd e2e && npm test`
5. Open PR with checklist.
6. Wait for CI green.
7. Merge and continue to next issue.

## Prompt Templates
### Planner Prompt
"Read `docs/spec.md` and create ordered feature issues with dependencies, acceptance criteria, and test strategy. Keep each issue small and mergeable."

### Implementer Prompt
"Implement only Issue #<id> on branch `agent/issue-<id>-<slug>`, add/update tests, run required commands, and update docs touched by the change."

### QA Prompt
"Validate PR against `docs/qa-checklist.md`, ensure deterministic E2E remains green, and report any gate failures with exact remediation steps."

## Required Commands by Area
- Backend: `dotnet build`, `dotnet test`
- Frontend: `flutter pub get`, `dart analyze`, `flutter test`, `flutter build web`
- E2E: `npm ci`, `npx playwright install --with-deps chromium`, `npm test`

## Guardrails
- No direct push to main.
- No multi-feature PR.
- No skipping tests.
- Scraping-real must not be required in default CI.
