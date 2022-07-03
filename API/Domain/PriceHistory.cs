using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Domain;

public class PriceHistory
{
    public int Id { get; set; }
    [Required]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTimeOffset Date{ get; set; }
    [Required]
    public double HydroCost { get; set; }
    [Required]
    public double CoalCost { get; set; }
    [Required]
    public double OilCost { get; set; }
    [Required]
    public double NaturalGasCost { get; set; }
    [Required]
    public double NuclearCost { get; set; }
    [Required]
    public double WindCost { get; set; }
    [Required]
    public double SolarCost { get; set; }
    [Required]
    public double GeothermalBiomassCost { get; set; }
    [Required, ForeignKey("Province")]
    public int ProvinceId { get; set; }
    public virtual Province Province { get; set; }
}