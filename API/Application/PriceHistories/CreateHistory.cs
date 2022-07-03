using API.Application.Core;
using API.Application.Provinces;
using API.Domain;
using API.Persistance;
using FluentValidation;
using MediatR;

namespace API.Application.PriceHistories;

public class CreateHistory
{
    public class Command : IRequest<Result<Unit>>
    {
        public PriceHistory PriceHistory { get; set; }
    }

    public class CommandValidator : AbstractValidator<Command>
    {
        public CommandValidator()
        {
            RuleFor(x => x.PriceHistory).SetValidator(new PriceHistoryValidator());
        }
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
            _datacontext.PriceHistories.Add(request.PriceHistory);
            var result = await _datacontext.SaveChangesAsync() > 0;

            if (!result)
            {
                return Result<Unit>.Fail("Failed to create a Price History");
            }
            
            return Result<Unit>.Success(Unit.Value);
            
        }
    }
}