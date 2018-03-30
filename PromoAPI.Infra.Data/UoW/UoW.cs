using PromoAPI.Domain.Interfaces;
using PromoAPI.Infra.Data.Context;
using System;
using System.Threading.Tasks;

namespace PromoAPI.Infra.Data.UoW
{
    public class UoW : IUoW
    {
        private readonly PromoDbContext _context;
        public UoW(PromoDbContext context)
        {
            _context = context;
        }
        public Task<int> CommitAsync()
        {
            try
            {
                return _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                return Task.FromResult(-1);
            }
        }
        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
            GC.SuppressFinalize(this);
        }
    }
}
