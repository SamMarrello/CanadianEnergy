using API.Application.Core;
using API.Domain;
using API.Persistance;
using MediatR;

namespace API.Application.Provinces;

public class DetailsProvinces
{
    public class Query : IRequest<Result<Province>>
    {
        public int Id { get; set; }
    }

    public class Handler : IRequestHandler<Query, Result<Province>>
    {
        private readonly Datacontext _datacontext;

        public Handler(Datacontext datacontext)
        {
            _datacontext = datacontext;
        }

        public async Task<Result<Province>> Handle(Query request, CancellationToken cancellationToken)
        {
            var province = await _datacontext.Provinces.FindAsync(request.Id);

            return Result<Province>.Success(province);
        }
    }
}