using API.Domain;
using API.Persistance;
using MediatR;

namespace API.Application.Provinces;

public class DetailsProvinces
{
    public class Query : IRequest<Province>
    {
        public int Id { get; set; }
    }

    public class Handler : IRequestHandler<Query, Province>
    {
        private readonly Datacontext _datacontext;

        public Handler(Datacontext datacontext)
        {
            _datacontext = datacontext;
        }

        public async Task<Province> Handle(Query request, CancellationToken cancellationToken)
        {
            return await _datacontext.Provinces.FindAsync(request.Id);
        }
    }
}