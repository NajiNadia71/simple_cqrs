using adsCompany.Entities;
using adsCompany.DbContexts;
using adsCompany.DTO;
using System.Linq;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;


public class GetProductionsQueryHandler : IRequestHandler<GetProductionsQuery, List<ProductionDTO>>
{
    private readonly SqliteDbContext _dbContext;

    public GetProductionsQueryHandler(SqliteDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Task<List<ProductionDTO>> Handle(GetProductionsQuery request, CancellationToken cancellationToken)
    {

        var result = _dbContext.Productions
             .Select(item => new ProductionDTO
             {
                 Id = item.Id,
                 Count = item.Count,
                 Title = item.Title,
                 ProductionTypeId = item.ProductionTypeId,
                 CreateDate = item.CreateDate.ToString(),
                 Comment = item.Comment,
                 ProductTypeName = item.ProductionType.Title.ToString()
             })
            .ToList();
        return Task.FromResult(result);
    }
}
