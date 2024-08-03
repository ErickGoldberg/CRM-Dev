using CRM_Dev.Core.Repositories;
using CRM_Dev.Infraestructure.Persistence;
using CRM_Dev.Infraestructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace CRM_Dev.API.Extensions
{
    public static class ServiceConfiguration
    {
        public static WebApplicationBuilder ConfigureServices(this WebApplicationBuilder builder)
        {
            builder.ConfigureDependencyInjection();
            builder.ConfigureOthersServices();

            builder.Services.AddControllers();

            // Swagger
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "CRMDev.API",
                    Version = "v1",
                    Contact = new OpenApiContact
                    {
                        Name = "Erick Goldberg",
                        Email = "erick_goldberg@hotmail.com",
                        Url = new Uri("https://github.com/ErickGoldberg")
                    }
                });
            });

            return builder;
        }

        public static IServiceCollection ConfigureDependencyInjection(this WebApplicationBuilder builder)
        {
            var services = builder.Services;

            services.AddScoped<IContactRepository, ContactRepository>();
            services.AddScoped<IOpportunityRepository, OpportunityRepository>();
            
            return services;
        }

        public static IServiceCollection ConfigureOthersServices(this WebApplicationBuilder builder)
        {
            var services = builder.Services;

            //services.AddMediatR(config =>
            //{
            //    config.RegisterServicesFromAssembly(typeof().Assembly);
            //});

            //services.AddControllers(options => options.Filters.Add(typeof()))
            //        .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<RegisterGoalValidator>());

            builder.Services.AddDbContext<CRMDevDbContext>(options
                => options.UseSqlServer(builder.Configuration.GetConnectionString("CRMDevDb")));

            return services;
        }
    }
}
