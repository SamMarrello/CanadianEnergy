using API.Domain;
using API.Persistance;
using AutoMapper;
using MediatR;

namespace API.Application.Provinces;

public class UpdateProvinces
{
    public class Command : IRequest
    {
        public Province Province { get; set; }
    }

    public class Handler : IRequestHandler<Command>
    {
        private readonly Datacontext _datacontext;
        private readonly IMapper _mapper;
        
        public Handler(Datacontext datacontext, IMapper mapper)
        {
            _datacontext = datacontext;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
        {
            var province = await _datacontext.Provinces.FindAsync(request.Province.Id);

            _mapper.Map(request.Province, province);
            
            await _datacontext.SaveChangesAsync();
            
            return Unit.Value;
        }
    }
}