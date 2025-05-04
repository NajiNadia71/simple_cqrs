using adsCompany.Entities;
using adsCompany.DTO;
using MediatR;
using System;

public class GetProductionByIdQuery : IRequest<ProductionDTO>
{
    public int Id { get; set; }
}