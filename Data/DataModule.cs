using System;
using System.Linq;
using DryIoc;
using YamDocumentManagementSystem.Data.Repositories.Base;
using YamDocumentManagementSystem.Data.Repositories.Factories;
using YamDocumentManagementSystem.Helpers;
using YamDocumentManagementSystem.Helpers.Configuration;
using YamDocumentManagementSystem.Helpers.DependencyInjection;

namespace YamDocumentManagementSystem.Data
{
    public sealed class DataModule : IModule
    {
        private readonly Type[] _repositories;

        private DataModule()
        {
            var concreteTypes = this.ThisAssemblyConcreteTypes();

            _repositories = concreteTypes.Where(type => type.Name.EndsWith(@"Repository")).ToArray();
        }

        public static DataModule Instance { get; } = new DataModule();

        public void Load(IRegistrator registrator)
        {
            registrator.RegisterAll(HelperModule.Instance);
            registrator.Register<IDatabaseFactory, DatabaseFactory>(Reuse.Singleton);
            registrator.RegisterForAllImplementedInterfaces(_repositories, Reuse.Singleton);
            registrator.RegisterInitializer<IDatabaseRepository>(InitializeConnectionInfoForRepository);
        }

        private static void InitializeConnectionInfoForRepository(IDatabaseRepository databaseRepository,
            IResolver resolver)
        {
            var configurationHelper = resolver.Resolve<IConfigurationHelper>();
            var connectionName = databaseRepository.ConnectionName;
            var databaseConnectionInfo = configurationHelper.GetConnectionString(connectionName);
            databaseRepository.DatabaseConnectionInfo = databaseConnectionInfo;
        }
    }
}