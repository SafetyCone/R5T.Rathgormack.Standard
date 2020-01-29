using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;
using R5T.Mullingar.Standard;
using R5T.Rathgormack.Mullingar;


namespace R5T.Rathgormack.Standard
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddHelloWorldMessenger(this IServiceCollection services)
        {
            // Works!!! Hooray!!!
            //services
            //    .AddMullingarHelloWorldMessenger(ServiceAction.AddedElsewhere)
            //    .AddHelloWorldMessageProvider()
            //    ;

            // Works!!! Hooray!!!
            services.AddMullingarHelloWorldMessenger(services.AddHelloWorldMessageProviderAction());

            return services;
        }

        public static ServiceAction<IHelloWorldMessenger> AddHelloWorldMessengerAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<IHelloWorldMessenger>(() => services.AddHelloWorldMessenger());
            return serviceAction;
        }
    }
}
