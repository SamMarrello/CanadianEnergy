using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Domain
{
    public class Province
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double PercentHydro { get; set; }
        public double PercentCoal { get; set; }
        public double PercentOil { get; set; }
        public double PercentNaturalGas { get; set; }
        public double PercentNuclear { get; set; }
        public double PercentWind { get; set; }
        public double PercentSolar { get; set; }
        public double PercentGeothermalBiomass { get; set; }
    }

}
