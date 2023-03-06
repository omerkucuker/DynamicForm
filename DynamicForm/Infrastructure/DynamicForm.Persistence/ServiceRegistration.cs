using DynamicForm.Application.Abstractions.Services;
using DynamicForm.Application.Repositories;
using DynamicForm.Persistence.Context;
using DynamicForm.Persistence.Repositories;
using DynamicForm.Persistence.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DynamicForm.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<DynamicFormsContext>(options => options.UseSqlServer(Configuration.ConnectionString));

            services.AddScoped<IElementReadRepository, ElementReadRepository>();
            services.AddScoped<IElementWriteRepository, ElementWriteRepository>();
            services.AddScoped<IElementService, ElementService>();

            services.AddScoped<IFormElementReadRepository, FormElementReadRepository>();
            services.AddScoped<IFormElementWriteRepository, FormElementWriteRepository>();
            services.AddScoped<IFormElementService, FormElementService>();

            services.AddScoped<IFormReadRepository, FormReadRepository>();
            services.AddScoped<IFormWriteRepository, FormWriteRepository>();
            services.AddScoped<IFormService, FormService>();

        }
    }
}
