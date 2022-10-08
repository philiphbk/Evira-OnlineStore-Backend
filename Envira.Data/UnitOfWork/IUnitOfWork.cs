using Evira.Data.Repository;
using Evira.Models;


namespace Evira.Data.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Eviras> Eviras { get; }
        Task Save();
    }
}
