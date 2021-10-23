using Data.Interfaces;
using System;

namespace Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IFormRepository FormRepository { get; }
        void Commit();
    }
}
