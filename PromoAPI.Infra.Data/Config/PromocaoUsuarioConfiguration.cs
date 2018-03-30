using PromoAPI.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace PromoAPI.Infra.Data.Config
{
    public class PromocaoUsuarioConfiguration : EntityTypeConfiguration<PromocaoUsuario>
    {
        public PromocaoUsuarioConfiguration()
        {
            ToTable("UsuarioPromocoes");

            HasKey(x => x.PromocaoUsuarioId);

            HasRequired(x => x.Promocao)
                .WithMany(y => y.PromocaoUsuarios)
                .HasForeignKey(x => x.PromocaoId);
        }
    }
}
