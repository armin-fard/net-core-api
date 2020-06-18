using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using Commander.Models;
using Commander.DataAccess;
using Microsoft.Extensions.Hosting;

namespace CommanderApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
        // Add framework services.
            services.AddControllers();
            var sqlConnectionString = "Server=postgres.jlmstrategic.com;Port=5432;Database=Invoicing Development;User Id=jlm;Password=SeekerTAL2?;";
        
            services.AddDbContext<CommanderContext>(options => options.UseNpgsql(sqlConnectionString));
            services.AddScoped<IDataAccessProvider, DataAccessProvider>(); 
            // MvcOptions.EnableEndpointRouting = false;
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)  
        {  
            if (env.IsDevelopment())  
            {  
                app.UseDeveloperExceptionPage();  
            }  

            app.UseRouting();  

            app.UseAuthorization();  

            app.UseEndpoints(endpoints =>  
            {  
                endpoints.MapControllers();  
            });  
        }
    }
}