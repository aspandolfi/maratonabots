using PromoAPI.Domain.Interfaces;
using PromoAPI.Domain.Interfaces.Repositories;
using PromoAPI.Domain.Interfaces.Services;
using PromoAPI.Domain.Services;
using PromoAPI.Infra.Data.Context;
using PromoAPI.Infra.Data.Repositories;
using PromoAPI.Infra.Data.UoW;
using SimpleInjector;

namespace PromoAPI.Infra.IoC
{
    public class SimpleInjectorBootStrapper
    {
        public static void RegisterDependencies(Container container)
        {
            container.Register<PromoDbContext>();

            container.Register(typeof(IRepository<>), typeof(Repository<>));
            container.Register<IPromocaoRepository, PromocaoRepository>();
            container.Register<IPromocaoUsuarioRepository, PromocaoUsuarioRepository>();
            container.Register<IUoW, UoW>();

            container.Register(typeof(IService<>), typeof(Service<>));
            container.Register<IPromocaoService, PromocaoService>();
            container.Register<IPromocaoUsuarioService, PromocaoUsuarioService>();
        }
    }
}
