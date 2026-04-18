# QA Checklist

## CI Gates (must pass)
- [ ] Backend restore/build/test
- [ ] Frontend pub get/analyze/test/build web
- [ ] E2E deterministic smoke test (Playwright)

## Manual Smoke Checklist
- [ ] Backend starts locally and `/health` returns 200
- [ ] Frontend opens and renders placeholder landing page in PT-BR
- [ ] E2E smoke test runs locally (`npm test` in `e2e/`)

## Notes
- E2E is deterministic and does not require real Shopee scraping.
- Real scraping validations should run in explicit opt-in flows in future PRs.
