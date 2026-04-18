import { test, expect } from '@playwright/test';

test('frontend and backend smoke', async ({ page, request }) => {
  const health = await request.get('http://127.0.0.1:5000/health');
  expect(health.ok()).toBeTruthy();

  await page.goto('/');
  await expect(page.getByRole('heading', { name: 'Wishlist POC' })).toBeVisible();
});
