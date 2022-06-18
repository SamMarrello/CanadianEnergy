using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Domain;

namespace API.Persistance
{
    public class Seed
{
    public static async Task SeedData(Datacontext datacontext)
    {
        if (datacontext.Provinces.Any())
        {
            return;
        }

        var provinces = new List<Province>
        {
            new Province
            {
                Name = "Quebec",
                PercentCoal = 0,
                PercentHydro = 94,
                PercentNuclear = 0,
                PercentOil = 0.2,
                PercentSolar = 0,
                PercentWind = 5,
                PercentGeothermalBiomass = 0.7,
                PercentNaturalGas = 0.1
            },
            new Province
            {
                Name = "Ontario",
                PercentCoal = 0,
                PercentHydro = 24,
                PercentNuclear = 59,
                PercentOil = 0.3,
                PercentSolar = 1,
                PercentWind = 8,
                PercentGeothermalBiomass = 1,
                PercentNaturalGas = 7
            },
            new Province
            {
                Name = "New Brunswick",
                PercentCoal = 14,
                PercentHydro = 22,
                PercentNuclear = 38,
                PercentOil = 1,
                PercentSolar = 0,
                PercentWind = 7,
                PercentGeothermalBiomass = 4,
                PercentNaturalGas = 15
            },
            new Province
            {
                Name = "Nova Scotia",
                PercentCoal = 52,
                PercentHydro = 10,
                PercentNuclear = 0,
                PercentOil = 2,
                PercentSolar = 0,
                PercentWind = 11,
                PercentGeothermalBiomass = 3,
                PercentNaturalGas = 22
            },
            new Province
            {
                Name = "Manitoba",
                PercentHydro = 97,
                PercentCoal = 0,
                PercentNuclear = 0,
                PercentOil = 0,
                PercentSolar = 0,
                PercentWind = 3,
                PercentGeothermalBiomass = 0,
                PercentNaturalGas = 0
            },
            new Province
            {
                Name = "Northwest Territories",
                PercentCoal = 0,
                PercentHydro = 47,
                PercentNuclear = 0,
                PercentOil = 37,
                PercentSolar = 0,
                PercentWind = 2,
                PercentGeothermalBiomass = 0,
                PercentNaturalGas = 14
            },
            new Province
            {
                Name = "British Colombia",
                PercentCoal = 0,
                PercentHydro = 87,
                PercentNuclear = 0,
                PercentOil = 0.5,
                PercentSolar = 0,
                PercentWind = 2.5,
                PercentGeothermalBiomass = 5,
                PercentNaturalGas = 4
            },
            new Province
            {
                Name = "Prince Edward Island",
                PercentCoal = 0,
                PercentHydro = 0,
                PercentNuclear = 0,
                PercentOil = 0.5,
                PercentSolar = 0,
                PercentWind = 99,
                PercentGeothermalBiomass = 0.5,
                PercentNaturalGas = 0
            },
            new Province
            {
                Name = "Yukon",
                PercentCoal = 0,
                PercentHydro = 80,
                PercentNuclear = 0,
                PercentOil = 0,
                PercentSolar = 0,
                PercentWind = 0,
                PercentGeothermalBiomass = 0,
                PercentNaturalGas = 0
            },
            new Province
            {
                Name = "Alberta",
                PercentCoal = 36,
                PercentHydro = 3,
                PercentNuclear = 0,
                PercentOil = 0,
                PercentSolar = 0,
                PercentWind = 6,
                PercentGeothermalBiomass = 2,
                PercentNaturalGas = 54
            },
            new Province
            {
                Name = "Saskatchewan",
                PercentCoal = 41,
                PercentHydro = 15,
                PercentNuclear = 0,
                PercentOil = 0,
                PercentSolar = 0,
                PercentWind = 3,
                PercentGeothermalBiomass = 0.5,
                PercentNaturalGas = 40
            },
            new Province
            {
                Name = "Newfoundland",
                PercentCoal = 0,
                PercentHydro = 96,
                PercentNuclear = 0,
                PercentOil = 3,
                PercentSolar = 0,
                PercentWind = 0.4,
                PercentGeothermalBiomass = 0,
                PercentNaturalGas = 0.6
            },
            new Province
            {
                Name = "Nunavut",
                PercentOil = 100,
                PercentCoal = 0,
                PercentHydro = 0,
                PercentNuclear = 0,
                PercentSolar = 0,
                PercentWind = 0,
                PercentGeothermalBiomass = 0,
                PercentNaturalGas = 0
            }
        };

        await datacontext.Provinces.AddRangeAsync(provinces);
        await datacontext.SaveChangesAsync();
    }
}
}
