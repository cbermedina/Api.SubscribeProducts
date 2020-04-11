using Microsoft.Extensions.DependencyInjection;
using Products.Api.DataAccess.Contracts.Repositories;
using Products.Api.DataAccess.Repositories;

namespace Products.Api.CrossCutting.Register
{
    public static class IoCRegister
    {
        public static IServiceCollection AddRegistration(this IServiceCollection services)
        {

            AddRegisterServices(services);
            AddRegisterRepositories(services);
            AddRegisterOthers(services);

            return services;

        }
        /// <summary>
        /// Add Register Services
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        private static IServiceCollection AddRegisterServices(IServiceCollection services)
        {


            return services;
        }
        /// <summary>
        /// Add Register Repositories
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        private static IServiceCollection AddRegisterRepositories(IServiceCollection services)
        {
            services.AddTransient<IMongoContextRepository, MongoContextRepository>();
            return services;
        }
        /// <summary>
        /// Add Register Others
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        private static IServiceCollection AddRegisterOthers(IServiceCollection services)
        {
            //services.AddSingleton<IAppConfig, AppConfig>();
            //services.AddTransient<IApiCaller, ApiCaller>();
            //services.AddTransient<IInformationService, InformationService>();
            //services.AddTransient<ICacheService, CacheService>();
            //services.AddSingleton<IServiceLog, ServiceLog>();
            return services;
        }
    }
}
