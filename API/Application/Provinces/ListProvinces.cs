using API.Domain;
using API.Persistance;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace API.Application.Provinces;

public class ListProvinces
{
    public class Query : IRequest<List<Province>>
    {
        
    }

    public class Handler : IRequestHandler<Query, List<Province>>
    {
        private readonly Datacontext _datacontext;

        public Handler(Datacontext datacontext)
        {
            _datacontext = datacontext;
        }
        
        public Task<List<Province>> Handle(Query request, CancellationToken cancellationToken)
        {
            return _datacontext.Provinces.ToListAsync();
        }
    }
}