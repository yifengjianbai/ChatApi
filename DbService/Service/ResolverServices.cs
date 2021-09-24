using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace DbService.Service
{
   public  class ResolverServices: Autofac.Module
    {
        private static IContainer _container;

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterBuildCallback(container =>
            {
                _container = (IContainer)container;
            });
            base.Load(builder);
        }

        public static IContainer GetContainer()
        {
            return _container;

        }

    }
}
