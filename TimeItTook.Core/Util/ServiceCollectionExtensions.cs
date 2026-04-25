using Microsoft.Extensions.DependencyInjection;

namespace TimeItTook.Core.Util
{
    public static class ServiceCollectionExtensions
    {
        public static void AddFactory<T>(this IServiceCollection services)
            where T : class
        {
            services.AddTransient<T>();
            services.AddSingleton<Func<T>>(s => () => s.GetService<T>()!);
            services.AddSingleton<IAbstractFactory<T>, AbstractFactory<T>>();
        }
    }
}
