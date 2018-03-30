using System.Threading.Tasks;
using PromoAPI.Domain.Entities;
using PromoAPI.Domain.Interfaces;
using PromoAPI.Domain.Interfaces.Repositories;
using PromoAPI.Domain.Interfaces.Services;

namespace PromoAPI.Domain.Services
{
    public class PromocaoUsuarioService : Service<PromocaoUsuario>, IPromocaoUsuarioService
    {
        private readonly IRepository<PromocaoUsuario> _promocaoUsuariorepository;
        private readonly IRepository<Promocao> _promocaoRepository;
        private readonly IUoW _uoW;
        public PromocaoUsuarioService(IRepository<PromocaoUsuario> repository, IUoW uoW, IRepository<Promocao> promocaoRepository) : base(repository, uoW)
        {
            _promocaoUsuariorepository = repository;
            _uoW = uoW;
            _promocaoRepository = promocaoRepository;
        }

        public override async Task<PromocaoUsuario> AddAsync(PromocaoUsuario obj)
        {
            var promocao = await _promocaoRepository.GetAsync(x => x.PromocaoId == obj.PromocaoId);

            obj.Promocao = promocao;

            return await base.AddAsync(obj);
        }
    }
}
