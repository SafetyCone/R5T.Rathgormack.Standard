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
            //services
            //    .AddMullingarHelloWorldMessenger(ServiceAction.AddedElsewhere) // Works!!! Hooray!!!
            //    .AddHelloWorldMessageProvider()
            //    ;

            services.AddMullingarHelloWorldMessenger(services.AddHelloWorldMessageProviderAction()); // Works!

            return services;
        }

        public static ServiceAction<IHelloWorldMessenger> AddHelloWorldMessengerAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<IHelloWorldMessenger>(() => services.AddHelloWorldMessenger());
            return serviceAction;
        }
    }
}
