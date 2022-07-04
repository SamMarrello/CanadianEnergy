using API.Application.Core;
using API.Persistance;
using MediatR;

namespace API.Application.PriceHistories;

public class DeleteHistory
{
    public class Command : IRequest<Result<Unit>>
    {
        public int Id { get; set; }
    }

    public class Handler : IRequestHandler<Command, Result<Unit>>
    {
        private readonly Datacontext _datacontext;

        public Handler(Datacontext datacontext)
        {
            _datacontext = datacontext;
        }

        public async Task<Result<Unit>> Handle(Command request, CancellationToken cancellationToken)
        {
            var priceHistory = await _datacontext.PriceHistories.FindAsync(request.Id);

            if (priceHistory == null)
            {
                return null;
            }

            _datacontext.Remove(priceHistory);
            
            var result = await _datacontext.SaveChangesAsync() > 0;

            if (!result)
            {
                return Result<Unit>.Fail("Failed to delete Price Record");
            }

            return Result<Unit>.Success(Unit.Value);
        }
    }
}