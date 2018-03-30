using PromoAPI.Domain.Entities;
using PromoAPI.Infra.Data.Config;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Diagnostics;

namespace PromoAPI.Infra.Data.Context
{
    public class PromoDbContext : DbContext
    {
        public PromoDbContext() : base("PromoDbConnection")
        {
            var ensureDLLIsCopied =
                System.Data.Entity.SqlServer.SqlProviderServices.Instance;
            Database.Log = (s) => Debug.WriteLine(s);
        }

        public IDbSet<Promocao> Promocoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Properties<decimal>()
                .Configure(p => p.HasPrecision(18, 2));

            modelBuilder.Properties<string>().
                Configure(p => p.HasColumnType("varchar").HasMaxLength(250));

            modelBuilder.Configurations.Add(new PromocaoConfiguration());
        }
    }
}
