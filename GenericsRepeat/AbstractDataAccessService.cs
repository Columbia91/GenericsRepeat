using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace GenericsRepeat
{
    public abstract class AbstractDataAccessService<T> : IDisposable
    {
        private readonly DbProviderFactory _factory;
        private readonly DbConnection _connection;
        public AbstractDataAccessService()
        {
            _factory = DbProviderFactories.GetFactory("имя провайдера");
            _connection = _factory.CreateConnection();
            _connection.Open();
        }

        public abstract List<T> GetAll();
        public abstract void Add(T entity);
        public abstract void Update(T entity);
        public abstract void Delete();

        public void Dispose()
        {
            _connection.Close();
        }
    }
}
