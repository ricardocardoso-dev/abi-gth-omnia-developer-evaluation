import { expect, test } from '@playwright/test';

test('smoke page renders', async ({ page }) => {
  await page.goto('/');
  await expect(page.getByRole('heading', { name: 'Wishlist POC E2E Smoke' })).toBeVisible();
  await expect(page.getByText('TODO: replace smoke page with real app flow E2E as features land.')).toBeVisible();
});
