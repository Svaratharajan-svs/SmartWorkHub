Day 1 — Project Setup + Solution Structure
Goal: Create clean architecture folders, ensure build succeeds.

Tasks
1.Create solution SmartWorkHub.sln
2.Create projects:
        SmartWorkHub.Domain
        SmartWorkHub.Application
        SmartWorkHub.Infrastructure
        SmartWorkHub.Web
3.Add project references:
        Application → Domain
        Infrastructure → Application, Domain
        Web → Application, Infrastructure
4.Add base folders:
        Domain/Entities/

        Application/Features/

        Infrastructure/Persistence/

        Web/Controllers/

5.Run dotnet build ✅ app compiles successfully.

Deliverable: Empty API running on Swagger endpoint.


        