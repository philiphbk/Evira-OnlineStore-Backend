using Evira.Data.DbContext;
using Evira.Data.Repository;
using Evira.Models;


namespace Evira.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EviraDbContext _context;
        private IGenericRepository<Eviras> _evira;


        public UnitOfWork(EviraDbContext context)
        {
            _context = context;
        }

        public IGenericRepository<Eviras> Eviras => _evira ??= new GenericRepository<Eviras>(_context);

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
