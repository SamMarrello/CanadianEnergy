using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Domain
{
    public class Province
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public double PercentHydro { get; set; }
        [Required]
        public double PercentCoal { get; set; }
        [Required]
        public double PercentOil { get; set; }
        [Required]
        public double PercentNaturalGas { get; set; }
        [Required]
        public double PercentNuclear { get; set; }
        [Required]
        public double PercentWind { get; set; }
        [Required]
        public double PercentSolar { get; set; }
        [Required]
        public double PercentGeothermalBiomass { get; set; }
    }

}
