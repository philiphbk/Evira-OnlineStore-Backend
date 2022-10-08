using Evira.Data.DbContext;
using Evira.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evira.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EviraDbContext _context;
        //private IGenericRepository<> _;


        public UnitOfWork(EviraDbContext context)
        {
            _context = context;
        }

        //public IGenericRepository<> Myndas => _myndas ??= new GenericRepository<Entities.Myndas>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

    }
}
