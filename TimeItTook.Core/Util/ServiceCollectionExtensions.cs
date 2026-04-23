using Microsoft.Extensions.DependencyInjection;

namespace TimeItTook.Core.Util
{
    public static class ServiceCollectionExtensions
    {
        public static void AddFactory<TModal>(this IServiceCollection services)
            where TModal : class
        {
            services.AddTransient<TModal>();
            services.AddSingleton<Func<TModal>>(s => () => s.GetService<TModal>()!);
            services.AddSingleton<IAbstractFactory<TModal>, AbstractFactory<TModal>>();
        }
    }
}
