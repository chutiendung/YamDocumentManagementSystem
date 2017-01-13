using System;
using System.Collections.Generic;
using System.Linq;
using DryIoc;

namespace YamDocumentManagementSystem.Helpers.DependencyInjection
{
    public static class RegistratorExtensions
    {
        public static void RegisterAll(this IRegistrator registrator, IModule module) => module.Load(registrator);

        public static IEnumerable<Type> ThisAssemblyTypes<TModule>(this TModule module) where TModule : IModule
            => typeof(TModule).Assembly.GetTypes();

        public static IEnumerable<Type> ThisAssemblyConcreteTypes<TModule>(this TModule module) where TModule : IModule
            => module.ThisAssemblyTypes().Where(type => type.IsClass && !type.IsAbstract);

        public static void RegisterForAllImplementedInterfaces(this IRegistrator registrator, IEnumerable<Type> types,
            IReuse reuse = null)
        {
            foreach (var type in types)
            {
                registrator.RegisterForAllImplementedInterfaces(type, reuse);
            }
        }

        public static void RegisterForAllImplementedInterfaces(this IRegistrator registrator, Type type,
            IReuse reuse = null)
        {
            var implementedTypes = type.GetImplementedTypes();

            foreach (var implementedType in implementedTypes)
            {
                registrator.Register(implementedType, type, reuse);
            }
        }

        public static void RegisterForAllImplementedInterfaces<T>(this IRegistrator registrator, IReuse reuse = null)
            => registrator.RegisterForAllImplementedInterfaces(typeof(T));
    }
}