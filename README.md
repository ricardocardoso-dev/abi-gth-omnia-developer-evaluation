# DeveloperStore Developer Evaluation

Prototype project by the **DeveloperStore** team to handle beverage sales records.

## Table of Contents

- [Overview](#overview)
- [Architecture](#architecture)
- [Prerequisites](#prerequisites)
- [Configuration](#configuration)
- [Running the Project (Docker)](#running-the-project-docker)
- [Main Endpoints](#main-endpoints)
- [Published Events (Redis Pub/Sub)](#published-events-redis-pubsub)
- [Business Rules](#business-rules)
- [Technologies and Patterns](#technologies-and-patterns)
- [Tests](#tests)
- [Notes](#notes)

---

## Overview

This project is a prototype developed by the **DeveloperStore** team to manage beverage sales records.  
The system is designed to be scalable, auditable, and easy to integrate with other systems via events and polyglot persistence.

---

## Architecture

- **Vertical Slice Architecture**: Each feature is isolated, making maintenance and evolution easier.
- **CQRS**: Clear separation between commands (write) and queries (read).
- **Mediator**: Decoupled communication between handlers and controllers.
- **Polyglot Persistence**: PostgreSQL (relational) and MongoDB (documental).
- **Messaging**: Redis Pub/Sub for domain events.

---

## Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [Docker](https://www.docker.com/products/docker-desktop)
- [Docker Compose](https://docs.docker.com/compose/)

---

## Configuration

The main settings are in `src/Ambev.DeveloperEvaluation.WebApi/appsettings.json`:

```json
"ConnectionStrings": {
  "DefaultConnection": "Host=ambev.developerevaluation.database;Port=5432;Username=developer;Password=ev@luAt10n;Database=developer_evaluation;SSLMode=disable;"
},
"DocumentDbSettings": {
  "ConnectionString": "mongodb://developer:ev@luAt10n@ambev.developerevaluation.nosql:27017",
  "DatabaseName": "DeveloperEvaluationDb"
},
"MessagingSettings": {
  "ConnectionString": "ambev_developer_evaluation_cache:6379,password=ev@luAt10n"
}
```

---

## Running the Project (Docker)

1. **Clone the repository**
2. **Run:**
   ```sh
   docker-compose up --build
   ```
3. Access the API at: [http://localhost:8080/swagger](http://localhost:8080/swagger)

**Docker Services:**
- WebApi: `localhost:8080`
- PostgreSQL: `localhost:5432`
- MongoDB: `localhost:27017`
- Redis: `localhost:6379`

---

## Main Endpoints

### Sales (`/api/sales`)
- `POST /api/sales` — Create a new sale
- `GET /api/sales/{id}` — Get a sale by ID
- `GET /api/sales` — List all sales
- `PUT /api/sales/{id}` — Update a sale
- `DELETE /api/sales/{id}` — Delete a sale

**Example payload to create a sale:**
```json
{
  "saleNumber": 123456,
  "saleDate": "2024-06-01T12:00:00Z",
  "clientId": 1,
  "clientName": "Test Client",
  "branchId": 2,
  "branchName": "Test Branch",
  "items": [
    {
      "productId": 10,
      "productDescription": "Test Product",
      "quantity": 2,
      "unitPrice": 50.25
    }
  ]
}
```

---

## Published Events (Redis Pub/Sub)

For each relevant operation, the system publishes events to the Redis channel, enabling integration with other systems and traceability:

- **SaleCreated** — Sale created
- **SaleModified** — Sale modified
- **SaleCancelled** — Sale cancelled
- **ItemCancelled** — Sale item cancelled

---

## Business Rules

- Purchases **over 4 identical items** get a **10% discount**
- Purchases **between 10 and 20 identical items** get a **20% discount**
- **It is not possible to sell more than 20 identical items**
- Purchases **below 4 items** **cannot have a discount**

---

## Technologies and Patterns

- **Vertical Slice Architecture**
- **CQRS**
- **Mediator (MediatR)**
- **PostgreSQL** (relational data)
- **MongoDB** (documents, planned for auditing)
- **Redis** (messaging/pubsub)

---

## Tests

To run the tests (unit and integration):

```sh
dotnet test
```

---

## Notes

- **MongoDB:** Copying sales to MongoDB **has not been implemented yet**, but it is planned for the project.
- The project follows Clean Architecture and DDD best practices.
- Endpoint documentation is available via Swagger at `/swagger`.

---