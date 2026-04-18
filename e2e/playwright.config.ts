import { defineConfig } from '@playwright/test';

export default defineConfig({
  testDir: './tests',
  fullyParallel: false,
  retries: 0,
  reporter: 'list',
  use: {
    baseURL: 'http://127.0.0.1:4173',
    trace: 'on-first-retry'
  },
  webServer: [
    {
      command:
        'dotnet run --project ../backend/src/Wishlist.Api/Wishlist.Api.csproj --urls http://127.0.0.1:5000',
      url: 'http://127.0.0.1:5000/health',
      reuseExistingServer: true,
      timeout: 120000
    },
    {
      command: 'python3 -m http.server 4173 --directory ../frontend/web',
      url: 'http://127.0.0.1:4173',
      reuseExistingServer: true,
      timeout: 120000
    }
  ]
});
