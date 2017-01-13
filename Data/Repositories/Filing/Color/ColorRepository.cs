using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using YamDocumentManagementSystem.Configuration.Data;
using YamDocumentManagementSystem.Data.Repositories.Base;
using YamDocumentManagementSystem.Data.Repositories.Factories;
using YamDocumentManagementSystem.Types.General;
using ColorEntity = YamDocumentManagementSystem.Data.Entities.Filing.Color.Color;

namespace YamDocumentManagementSystem.Data.Repositories.Filing.Color
{
    internal sealed class ColorRepository : IDatabaseRepository, IColorRepository
    {
        private const string PrimaryKeyName = ColorEntity.IdColumnName;
        private const string TableName = ColorEntity.TableName;

        private readonly IDatabaseFactory _databaseFactory;

        internal ColorRepository(IDatabaseFactory databaseFactory)
        {
            _databaseFactory = databaseFactory;
        }

        public ColorEntity Get(Guid id)
        {
            ColorEntity colorEntity;

            using (var database = _databaseFactory.CreateForReadOnly(DatabaseConnectionInfo))
            {
                colorEntity = database.SingleOrDefault<ColorEntity>($"{PrimaryKeyName} == @0", id);
            }

            if (colorEntity == null)
            {
                throw new KeyNotFoundException(@"Color not found with the given Id");
            }

            return colorEntity;
        }

        public Task<ColorEntity> GetAsync(Guid id, CancellationToken cancellationToken = default(CancellationToken))
            => Task.Run(() => Get(id), cancellationToken);

        public Guid Add(ColorEntity entity)
        {
            Guard.ThrowIfNull(entity);

            using (var database = _databaseFactory.CreateForReadWrite(DatabaseConnectionInfo))
            {
                database.Insert(TableName, PrimaryKeyName, entity);
            }

            return entity.Id;
        }

        public Task<Guid> AddAsync(ColorEntity entity, CancellationToken cancellationToken = default(CancellationToken))
            => Task.Run(() => Add(entity), cancellationToken);

        public void Delete(Guid id)
        {
            using (var database = _databaseFactory.CreateForReadWrite(DatabaseConnectionInfo))
            {
                database.Delete(TableName, PrimaryKeyName, null, id);
            }
        }

        public Task DeleteAsync(Guid id, CancellationToken cancellationToken = default(CancellationToken))
            => Task.Run(() => Delete(id), cancellationToken);

        public string ConnectionName => Consts.ConfigurationDatabaseConnectionName;
        public IDatabaseConnectionInfo DatabaseConnectionInfo { private get; set; }
    }
}