using API.Application.Core;
using API.Domain;
using API.Persistance;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace API.Application.Provinces;

public class ListProvinces
{
    public class Query : IRequest<Result<List<Province>>>
    {
        
    }

    public class Handler : IRequestHandler<Query, Result<List<Province>>>
    {
        private readonly Datacontext _datacontext;

        public Handler(Datacontext datacontext)
        {
            _datacontext = datacontext;
        }
        
        public async Task<Result<List<Province>>> Handle(Query request, CancellationToken cancellationToken)
        {
            return Result<List<Province>>.Success(await _datacontext.Provinces.ToListAsync(cancellationToken));
        }
    }
}