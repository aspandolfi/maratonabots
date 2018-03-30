using PromoAPI.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace PromoAPI.Infra.Data.Config
{
    public class PromocaoConfiguration : EntityTypeConfiguration<Promocao>
    {
        public PromocaoConfiguration()
        {
            ToTable("Promocoes");

            HasKey(x => x.PromocaoId);

            Property(x => x.Valor)
                .IsOptional();

            Property(x => x.ImagemUrl)
                .HasMaxLength(1000);
        }
    }
}
