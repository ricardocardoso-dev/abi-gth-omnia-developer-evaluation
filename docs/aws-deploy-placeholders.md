# AWS Deploy Placeholders

Os workflows `deploy-backend.yml` e `deploy-frontend.yml` estão em modo scaffold/manual (`workflow_dispatch`) e não fazem deploy real ainda.

## Secrets/variables esperados (quando ativar deploy real)
- `AWS_REGION`
- `AWS_ROLE_TO_ASSUME`
- `AWS_ACCOUNT_ID` (opcional, recomendado)
- `AWS_BACKEND_SERVICE` (placeholder para backend)
- `AWS_FRONTEND_BUCKET` (placeholder para frontend)
- `AWS_CLOUDFRONT_DISTRIBUTION_ID` (placeholder para frontend)

## TODOs
1. Definir serviço AWS para backend (App Runner, ECS/Fargate ou Elastic Beanstalk)
2. Definir estratégia frontend (S3 + CloudFront ou Amplify)
3. Configurar permissões mínimas em IAM
4. Adicionar etapas reais de build/artifact/deploy
