using API.Application.Core;
using API.Domain;
using API.Persistance;
using AutoMapper;
using FluentValidation;
using MediatR;

namespace API.Application.Provinces;

public class UpdateProvinces
{
    public class Command : IRequest<Result<Unit>>
    {
        public Province Province { get; set; }
    }

    public class CommandValidator : AbstractValidator<Command>
    {
        public CommandValidator()
        {
            RuleFor(x => x.Province).SetValidator(new ProvinceValidator());
        }
    }

    public class Handler : IRequestHandler<Command, Result<Unit>>
    {
        private readonly Datacontext _datacontext;
        private readonly IMapper _mapper;
        
        public Handler(Datacontext datacontext, IMapper mapper)
        {
            _datacontext = datacontext;
            _mapper = mapper;
        }

        public async Task<Result<Unit>> Handle(Command request, CancellationToken cancellationToken)
        {
            var province = await _datacontext.Provinces.FindAsync(request.Province.Id);

            if (province == null)
            {
                return null;
            }
            
            _mapper.Map(request.Province, province);
            
            var result = await _datacontext.SaveChangesAsync() > 0;

            if (!result)
            {
                return Result<Unit>.Fail("Failed to update activity");
            }
            
            return Result<Unit>.Success(Unit.Value);
        }
    }
}