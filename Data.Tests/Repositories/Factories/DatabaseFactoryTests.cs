using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Moq.AutoMock;
using PetaPoco;
using YamDocumentManagementSystem.Configuration.Data;
using YamDocumentManagementSystem.Data.Repositories.Factories;

namespace YamDocumentManagementSystem.Data.Tests.Repositories.Factories
{
    [TestClass]
    public sealed class DatabaseFactoryTests
    {
        [TestMethod]
        public void
            CreateForReadOnly_GivenValidDatabaseConnectionInfo_ReturnsNewIDatabaseWithReadUncommittedIsolationLevelSet()
        {
            var autoMocker = new AutoMocker(MockBehavior.Loose);

            var databaseFactory = autoMocker.CreateInstance<DatabaseFactory>();

            var databaseConnectionInfo = new DatabaseConnectionFake
            {
                Name = @"SomeDatabase",
                ConnectionString = @"Data Source=(localdb)\ProjectsV17;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False",
                ProviderName = @"SqlServer"
            };

            var database = databaseFactory.CreateForReadOnly(databaseConnectionInfo);
        
            Assert.IsInstanceOfType(database, typeof(IDatabase));
            Assert.IsNotNull(database);
            Assert.IsNotNull(database.IsolationLevel);
            Assert.AreEqual(IsolationLevel.ReadUncommitted, database.IsolationLevel);
        }

        private sealed class DatabaseConnectionFake : IDatabaseConnectionInfo
        {
            public string Name { get; set; }
            public string ConnectionString { get; set; }
            public string ProviderName { get; set; }
        }
    }
}