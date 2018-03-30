using PromoAPI.Domain.Entities;
using PromoAPI.Domain.Interfaces;
using PromoAPI.Domain.Interfaces.Repositories;
using PromoAPI.Domain.Interfaces.Services;

namespace PromoAPI.Domain.Services
{
    public class PromocaoService : Service<Promocao>, IPromocaoService
    {
        public PromocaoService(IRepository<Promocao> repository, IUoW uoW) : base(repository, uoW)
        {
        }
    }
}
