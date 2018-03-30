using PromoAPI.Domain.Entities;
using PromoAPI.Domain.Interfaces.Repositories;
using PromoAPI.Infra.Data.Context;

namespace PromoAPI.Infra.Data.Repositories
{
    public class PromocaoRepository : Repository<Promocao>, IPromocaoRepository
    {
        public PromocaoRepository(PromoDbContext context) : base(context)
        {
        }
    }
}
