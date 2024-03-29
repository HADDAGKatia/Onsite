﻿using Microsoft.Extensions.DependencyInjection;

namespace Onsite.Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IEtudiantService, EtudiantService>();
            services.AddScoped<IMatiereService, MatiereService>();


            return services;
        }
    }
}
