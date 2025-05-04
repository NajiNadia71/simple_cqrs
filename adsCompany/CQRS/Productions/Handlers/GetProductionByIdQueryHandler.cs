using adsCompany.Entities;
using adsCompany.DbContexts;
using adsCompany.DTO;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;


public class GetProductionByIdQueryHandler : IRequestHandler<GetProductionByIdQuery, ProductionDTO>
{
    private readonly SqliteDbContext _dbContext;

    public GetProductionByIdQueryHandler(SqliteDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Task<ProductionDTO> Handle(GetProductionByIdQuery request, CancellationToken cancellationToken)
    {

        var x =  _dbContext.Productions.Find(request.Id);
        var result=  new ProductionDTO
        {
            Id = x.Id,
            Count = x.Count,
            Title = x.Title,
            ProductionTypeId = x.ProductionTypeId,
            CreateDate = x.CreateDate.ToString(),
            Comment = x.Comment,
            ProductTypeName = x.ProductionType.Title.ToString()
        };
        return Task.FromResult(result);
    }
}
