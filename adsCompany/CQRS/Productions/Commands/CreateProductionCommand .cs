using MediatR;
using System;
using System.Collections.Generic;

namespace adsCompany.CQRS.Productions.Commands
{

public class CreateProductionCommand : IRequest<int>
{
    public required string Title { get; set; }
    public int ProductionTypeId { get; set; }
}
}