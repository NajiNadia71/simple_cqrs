using System.Collections.Generic;
using adsCompany.Entities;
using adsCompany.DTO;
using MediatR;
using System;
public class GetProductionsQuery : IRequest<List<ProductionDTO>> { }
