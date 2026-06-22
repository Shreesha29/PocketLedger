# PocketLedger

> A privacy-first personal finance management application built with ASP.NET Core, React, SQL Server, and Clean Architecture.

## Overview

PocketLedger is a modern personal finance management platform designed to help users track income, expenses, budgets, and savings securely.

The project is being developed as a production-quality portfolio application to demonstrate enterprise-level backend engineering practices using the Microsoft technology stack.

The primary focus is backend architecture, maintainability, security, testing, and scalability rather than building a simple CRUD application.

---

## Goals

### Primary Goals

- Demonstrate Clean Architecture principles
- Implement secure authentication and authorization
- Build a maintainable and scalable backend
- Showcase modern .NET development practices
- Follow enterprise-level coding standards

### Secondary Goals

- Create a clean and responsive user interface
- Practice full-stack development with React and TypeScript
- Implement CI/CD and containerization

---

## Tech Stack

### Backend

- ASP.NET Core 8 Web API
- C#
- Entity Framework Core
- SQL Server
- Clean Architecture
- Repository Pattern
- Dependency Injection
- FluentValidation
- JWT Authentication
- Refresh Tokens
- Serilog
- Swagger / OpenAPI
- xUnit

### Frontend

- React
- TypeScript
- React Router
- Axios
- React Hook Form
- Material UI

### DevOps

- Git
- GitHub
- GitHub Actions
- Docker
- Azure App Service (planned)

---

## Solution Architecture

```text
PocketLedger.sln

src/

├── PocketLedger.API
├── PocketLedger.Application
├── PocketLedger.Domain
└── PocketLedger.Infrastructure

tests/

└── PocketLedger.Tests

frontend/

└── pocketledger-web
```

### Architecture Layers

#### Domain

Contains:

- Entities
- Value Objects
- Enums
- Domain Rules

#### Application

Contains:

- DTOs
- Interfaces
- Business Logic
- Validators
- Application Services

#### Infrastructure

Contains:

- EF Core
- Repositories
- Database Access
- Authentication
- External Services

#### API

Contains:

- Controllers
- Middleware
- Dependency Injection
- Authentication Configuration
- Swagger

---

## Planned Features

### Authentication

- User Registration
- Login
- JWT Authentication
- Refresh Tokens
- Logout
- Change Password

### Dashboard

- Monthly Income
- Monthly Expenses
- Savings Summary
- Budget Progress
- Recent Transactions

### Transactions

- Create Transaction
- Edit Transaction
- Delete Transaction
- Categories
- Search
- Filtering
- Pagination

### Budgets

- Monthly Budget
- Category Budget
- Spending Alerts

### Reports

- Monthly Reports
- CSV Export

### Settings

- User Profile
- Currency Preferences
- Theme Settings

---

## Security

The application will follow security best practices including:

- JWT Authentication
- Password Hashing
- Authorization Policies
- Input Validation
- Secure Configuration Management
- Protection of Sensitive Data

---

## Logging

Logging will be implemented using Serilog.

Logs will include:

- Information Logs
- Warning Logs
- Error Logs
- Request Logging
- Unhandled Exceptions

---

## Testing

The project will include automated tests using xUnit.

Planned test coverage:

- Business Logic
- Application Services
- Validators
- Authentication Logic

---

## Development Roadmap

### Phase 1

- Solution Setup
- Project Structure
- Clean Architecture Foundation

### Phase 2

- Domain Layer
- Core Entities
- Database Design

### Phase 3

- Authentication & Authorization

### Phase 4

- Transactions Module

### Phase 5

- Budget Management

### Phase 6

- Dashboard

### Phase 7

- Reports & CSV Export

### Phase 8

- Logging & Monitoring

### Phase 9

- Automated Testing

### Phase 10

- Docker & CI/CD

### Phase 11

- Azure Deployment

---

## Project Status

🚧 Currently under active development.

The project is being built incrementally following Clean Architecture principles and production-quality engineering practices.

---

## License

This project is licensed under the MIT License.
