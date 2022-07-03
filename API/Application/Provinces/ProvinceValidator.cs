using API.Domain;
using FluentValidation;

namespace API.Application.Provinces;

public class ProvinceValidator : AbstractValidator<Province>
{
    public ProvinceValidator()
    {
        RuleFor(x => x.Name).NotEmpty();
        RuleFor(x => x.PercentCoal).NotEmpty();
        RuleFor(x => x.PercentHydro).NotEmpty();
        RuleFor(x => x.PercentNuclear).NotEmpty();
        RuleFor(x => x.PercentOil).NotEmpty();
        RuleFor(x => x.PercentSolar).NotEmpty();
        RuleFor(x => x.PercentWind).NotEmpty();
        RuleFor(x => x.PercentGeothermalBiomass).NotEmpty();
        RuleFor(x => x.PercentNaturalGas).NotEmpty();
    }
}