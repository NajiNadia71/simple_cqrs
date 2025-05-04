using adsCompany.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Threading.Tasks;
using System.Data.Entity;
using adsCompany.DbContexts;
using adsCompany.CQRS.Productions.Commands;
public class CreateProductionCommandHandler : IRequestHandler<CreateProductionCommand, int>
{
    private readonly SqliteDbContext _dbContext;


    public CreateProductionCommandHandler(SqliteDbContext dbContext)
    {

        _dbContext = dbContext;
      
    }

    public Task<int> Handle(CreateProductionCommand request, CancellationToken cancellationToken)
    {
        var production = new Production
        {
            Title = request.Title,
            ProductionTypeId = request.ProductionTypeId,
           // CreateTime=DateTime.Now.ToString(),
        };

        _dbContext.Productions.Add(production);
         _dbContext.SaveChanges();

        return Task.FromResult(production.Id);
    }
}