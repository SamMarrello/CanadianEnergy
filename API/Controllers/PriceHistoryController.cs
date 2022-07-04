using API.Application.PriceHistories;
using API.Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class PriceHistoryController : BaseApiController
{

    [HttpPost("{id}")]

    public async Task<IActionResult> CreatePriceHistory(PriceHistory priceHistory)
    {
        return HandleResults(await Mediator.Send(new CreateHistory.Command {PriceHistory = priceHistory}));
    }

    [HttpDelete("{id}")]

    public async Task<IActionResult> DeletePriceHistory(int id)
    {
        return HandleResults(await Mediator.Send(new DeleteHistory.Command {Id = id}));
    }
}