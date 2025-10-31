Day 3 — Repository + DI Setup 

Goal: Introduce repositories and register dependencies. 



Tasks 

1.Create ITaskRepository, TaskRepository implementing CRUD. 
2.Add IUnitOfWork if desired. Register EF + repos in DI (Program.cs). 
3.Run API → test repository with test controller endpoint. 



Deliverable: /api/tasks/test endpoint returns “Repository wired”.