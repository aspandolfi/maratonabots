using System;
using System.Threading.Tasks;

namespace PromoAPI.Domain.Interfaces
{
    public interface IUoW : IDisposable
    {
        Task<int> CommitAsync();
    }
}
