using Evira.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evira.Data.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
       // IGenericRepository<>  { get; }
        Task Save();
    }
}
