using System;
using BankingApp.Aids.Methods;
using Microsoft.Extensions.DependencyInjection;

namespace BankingApp.Domain.Common
{
    public static class GetRepository
    {

        public static IServiceProvider services;
        public static void SetServiceProvider(IServiceProvider provider) => services = provider;

        public static T Instance<T>() => instance<T>(services);

        public static object Instance(Type t) => instance(services, t);


        internal static T instance<T>(IServiceProvider h)
          => Safe.Run(() => {
              Type typeParameterType = typeof(T);
              if (h is null) return default;
              var i = h.GetRequiredService<T>();
              return i;
          }, null);
        internal static object instance(IServiceProvider h, Type t)
            => Safe.Run(() =>
            {
                var i = h?.GetRequiredService(t);
                return i;
            }, null);

    }
}
