using PromoAPI.Domain.Entities;
using PromoAPI.Domain.Interfaces.Repositories;
using PromoAPI.Infra.Data.Context;

namespace PromoAPI.Infra.Data.Repositories
{
    public class PromocaoUsuarioRepository : Repository<PromocaoUsuario>, IPromocaoUsuarioRepository
    {
        public PromocaoUsuarioRepository(PromoDbContext context) : base(context)
        {
        }
    }
}
