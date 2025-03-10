using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using ODS.DataEntry.Modules.WellMaster.Application.Service;
using ODS.DataEntry.Modules.WellMaster.Data.WellMaster;
using ODS.DataEntry.Modules.WellMaster.Domain.WellMaster;

namespace ODS.DataEntry.Modules.WellMaster.Application
{
    public static class WellMasterSetup
    {
        public static IServiceCollection AddWellMasterApplication(this IServiceCollection services)
        {
            var applicationAssembly = typeof(WellMasterSetup).Assembly;
            services.AddValidatorsFromAssembly(applicationAssembly);

            services.AddMediatR(config =>
            {
                config.RegisterServicesFromAssembly(applicationAssembly);
            });

            services.AddTransient<IWellMasterRepository, WellMasterRepository>();
            services.AddTransient<IWellMasterService, WellMasterService>();
            return services;
        }
    }
}
