using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.AutofacManager
{
    public class AutofacContainerModule
    {
        static private IServiceProvider _provider;
        public static void ConfigServiceProvider(IServiceProvider serviceProvider)
        {
            _provider = serviceProvider;
        }
        public static TService GetService<TService>() where TService : class
        {
            Type typeParameterType = typeof(TService);
            return (TService)_provider.GetService(typeParameterType);
        }
    }
}
