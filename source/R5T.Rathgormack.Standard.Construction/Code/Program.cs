using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Richmond;


namespace R5T.Rathgormack.Standard.Construction
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = ServiceProviderBuilder.NewUseStartup<Startup>();

            var program = serviceProvider.GetRequiredService<Program>();

            program.Run();
        }


        private IHelloWorldMessenger HelloWorldMessenger { get; }


        public Program(IHelloWorldMessenger helloWorldMessenger)
        {
            this.HelloWorldMessenger = helloWorldMessenger;
        }

        public void Run()
        {
            this.HelloWorldMessenger.SendHelloWorldMessage();
        }
    }
}
