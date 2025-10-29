# SmartWorkHub
Enterprise Project &amp; Workforce Management System

# 🧠 SmartWorkHub — Enterprise Project & Workforce Management System

SmartWorkHub is a **full-stack ASP.NET Core enterprise application** that demonstrates modern software engineering practices — including Clean Architecture, CQRS, EF Core, SignalR, Microservices, and CI/CD pipelines.  

It’s built to showcase **end-to-end ASP.NET Core proficiency** for professional portfolios or senior-level interviews.

---

## 🚀 Features

- ✅ **Modular Clean Architecture** (Domain, Application, Infrastructure, API)
- ⚙️ **Entity Framework Core + Dapper** (hybrid data access)
- 🗂️ **CQRS & MediatR** pattern
- 🧩 **REST API + gRPC + GraphQL**
- 🔔 **SignalR** for real-time task notifications
- 🕐 **Hangfire** background jobs (reminders, cleanup)
- 🧠 **FluentValidation + AutoMapper + Serilog**
- 🧰 **Redis Caching + Polly Resilience**
- 🧪 **Full Testing Suite** — XUnit, AutoFixture, NSubstitute
- 🐳 **Docker + Kubernetes Ready**
- 🔐 **JWT Authentication + Role-based Authorization**
- ☁️ **Azure / AWS Cloud Deployment**

---

## 🏗️ Project Structure

src/
├── SmartWorkHub.API/ → REST API Gateway
├── SmartWorkHub.Application/ → Business logic, CQRS, Handlers
├── SmartWorkHub.Domain/ → Entities, enums, core rules
├── SmartWorkHub.Infrastructure/ → EF Core, Repositories, Logging
├── SmartWorkHub.Realtime/ → SignalR Hubs
├── SmartWorkHub.BackgroundJobs/ → Hangfire jobs
├── SmartWorkHub.Web/ → Blazor UI
└── SmartWorkHub.Shared/ → Common DTOs, constants
tests/
├── SmartWorkHub.UnitTests/
└── SmartWorkHub.IntegrationTests/

## 🧩 Tech Stack

| Layer | Tech |
|-------|------|
| Backend | ASP.NET Core 9, C# 12 |
| Database | SQL Server, Redis |
| ORM | EF Core, Dapper |
| Messaging | RabbitMQ, MassTransit |
| Real-time | SignalR |
| Validation | FluentValidation |
| Logging | Serilog |
| Mapping | AutoMapper |
| Testing | XUnit, NSubstitute, AutoFixture |
| CI/CD | GitHub Actions / Azure DevOps |
| Frontend | Blazor Server / Razor Pages |

---

## 🧪 Run Locally

```bash
git clone https://github.com/<your-username>/SmartWorkHub.git
cd SmartWorkHub
dotnet restore
dotnet build
dotnet run --project src/SmartWorkHub.API