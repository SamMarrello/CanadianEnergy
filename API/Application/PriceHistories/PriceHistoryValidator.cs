using API.Domain;
using FluentValidation;

namespace API.Application.PriceHistories;

public class PriceHistoryValidator : AbstractValidator<PriceHistory> 
{
    public PriceHistoryValidator()
    {
        RuleFor(x => x.Date).NotEmpty();
        RuleFor(x => x.CoalCost).NotEmpty();
        RuleFor(x => x.GeothermalBiomassCost).NotEmpty();
        RuleFor(x => x.NuclearCost).NotEmpty();
        RuleFor(x => x.OilCost).NotEmpty();
        RuleFor(x => x.SolarCost).NotEmpty();
        RuleFor(x => x.WindCost).NotEmpty();
        RuleFor(x => x.NaturalGasCost).NotEmpty();
        RuleFor(x => x.HydroCost).NotEmpty();
        RuleFor(x => x.ProvinceId).NotEmpty();
        RuleFor(x => x.Province).NotEmpty();
        
    }
}