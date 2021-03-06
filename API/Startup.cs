using System;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Application.Core;
using API.Application.PriceHistories;
using API.Application.Provinces;
using API.Middleware;
using API.Persistance;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Config = configuration;
        }

        public IConfiguration Config { get; set; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers().AddFluentValidation(Config =>
            {
                Config.RegisterValidatorsFromAssemblyContaining<UpdateProvinces>();
            });
            services.AddSwaggerGen(c => { c.SwaggerDoc("v1", new OpenApiInfo {Title = "WebAPIv5", Version = "v1"}); });
            services.AddDbContext<Datacontext>(options =>
                options.UseNpgsql(Config.GetConnectionString("DefaultConnection")));
            services.AddMediatR(typeof(ListProvinces.Handler).Assembly);
            services.AddMediatR(typeof(CreateHistory.Handler).Assembly);
            services.AddAutoMapper(typeof(MappingProfiles).Assembly);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseMiddleware<ExceptionMiddleware>();
            
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebAPIv5 v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}
