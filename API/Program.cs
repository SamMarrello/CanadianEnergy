using API;
using API.Persistance;
using Microsoft.EntityFrameworkCore;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureWebHostDefaults(webBuilder =>
    {
        webBuilder.UseStartup<Startup>();
    })
    .Build();

using var scope = host.Services.CreateScope();

var services = scope.ServiceProvider;

try
{
    var context = services.GetRequiredService<Datacontext>();
    await context.Database.MigrateAsync();
    //await Seed.SeedData(context);
}
catch (Exception ex)
{
    var logger = services.GetRequiredService<ILogger<Program>>();
    logger.LogError(ex, "An error occured during migration");
}

await host.RunAsync();
