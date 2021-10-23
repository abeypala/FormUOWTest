using Data.Interfaces;
using Data;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private IDbConnection _connection;
        private IDbTransaction _transaction;
        private IFormRepository _formRepository;
        private bool _dispose;

        // ctor + tab tab
        public UnitOfWork(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
            _connection.Open();
            _transaction = _connection.BeginTransaction();
        }

        public IFormRepository FormRepository
        {
            get { return _formRepository ?? (_formRepository = new FormRepository(_transaction)); }
        }

        public void Commit()
        {
            try
            {
                _transaction.Commit();  // olması gereken bu 
            }
            catch
            {
                // yapılanları geri al 
                _transaction.Rollback();
                throw;
            }
            finally
            {
                // her ne olursa olsun bu işlemleri yap anlamında => ister try a girsib ister catch'e 
                _transaction.Dispose();
                _transaction = _connection.BeginTransaction();
                resetRepositories();
            }
        }

        private void resetRepositories()
        {
            // repositoryleri temizliyoruz.
            _formRepository = null;
        }

        public void Dispose()
        {
            dispose(true);
            GC.SuppressFinalize(this);
        }

        private void dispose(bool disposing)
        {
            if (!_dispose)
            {
                if (disposing)
                {
                    if (_transaction != null)
                    {
                        _transaction.Dispose();
                        _transaction = null;
                    }
                    if (_connection != null)
                    {
                        _connection.Dispose();
                        _connection = null;
                    }
                }
                _dispose = true;
            }
        }
        ~UnitOfWork()
        {
            dispose(false);
        }
    }
}
