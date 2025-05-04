CQRS pattern using MediatR in a .NET Core 
----------------------------------
CQRS (Command Query Responsibility Segregation) is a pattern that separates the operations that read data (Queries) from the operations that write data (Commands).
In this projecr I tried to implement implement this pattern:
Query classes only retrieve data
Command classes only modify data
Each has its own handler that specializes in that specific task

TO do SO :
How To Implement CQRS with MediatR :
1. dotnet add package MediatR
2. dotnet add package MediatR.Extensions.Microsoft.DependencyInjection					
Steps:
1	. Create forder CQRS					
2   . Create forder Commands for All Reads APIS  ,for each command create a class and create the interface IRequest<T> 
3   .Create folder Queies for All UPdate,Create Or Deletes ,For Each of them Create a class and the Interface  IRequest <T> 
4   .Create folder Handlers for all the commands and Queries ,For each of them create a class and implement the IRequestHandler<T> can Call Other 


---------------------------------------------------------
use dotnet run 
to see program running 