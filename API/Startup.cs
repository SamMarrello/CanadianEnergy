using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Persistance;
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
            services.AddControllers();
            services.AddSwaggerGen(c => { c.SwaggerDoc("v1", new OpenApiInfo {Title = "WebAPIv5", Version = "v1"}); });
            /*
             * services.AddCors(opt =>
            {
                opt.AddPolicy("CorsPolicy",
                    policy => { policy.AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin(); });
            });
             */
            services.AddDbContext<Datacontext>(options =>
                options.UseNpgsql(Config.GetConnectionString("DefaultConnection")));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebAPIv5 v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            //app.UseCors("CorsPolicy");Dbcontex

            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}
