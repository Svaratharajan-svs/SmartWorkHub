Goal: Define domain model & EF Core integration. 


Tasks 
1.Add TaskItem and User entities. 
2.Create SmartWorkHubDbContext in Infrastructure.   
3.Configure EF Core SQL Server provider. 
4.Add basic migrations (dotnet ef migrations add InitialCreate). 
    dotnet ef database update --project ../SmartWorkHub.Infrastructure --startup-project .
5.Update connection string in appsettings.json. 
    dotnet ef database update --project ../SmartWorkHub.Infrastructure --startup-project .

6.Run API → verify database created. 




Deliverable: Database with tables for Users and Tasks.