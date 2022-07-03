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
        if (datacontext.PriceHistories.Any())
        {
            return;
        }

        var prices = new List<PriceHistory>
        {
            new PriceHistory
            {

            }
        };

        await datacontext.PriceHistories.AddRangeAsync(prices);
        await datacontext.SaveChangesAsync();
    }
}
}
