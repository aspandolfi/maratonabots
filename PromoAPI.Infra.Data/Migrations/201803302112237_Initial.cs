namespace PromoAPI.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Promocoes",
                c => new
                    {
                        PromocaoId = c.Guid(nullable: false),
                        Data = c.DateTime(nullable: false),
                        ImagemUrl = c.String(maxLength: 1000, unicode: false),
                        Valor = c.Decimal(precision: 18, scale: 2),
                        Descricao = c.String(maxLength: 250, unicode: false),
                        Comentario = c.String(maxLength: 250, unicode: false),
                    })
                .PrimaryKey(t => t.PromocaoId);
            
            CreateTable(
                "dbo.PromocaoUsuario",
                c => new
                    {
                        PromocaoUsuarioId = c.Guid(nullable: false),
                        UsuarioId = c.Guid(nullable: false),
                        PromocaoId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.PromocaoUsuarioId)
                .ForeignKey("dbo.Promocoes", t => t.PromocaoId, cascadeDelete: true)
                .Index(t => t.PromocaoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PromocaoUsuario", "PromocaoId", "dbo.Promocoes");
            DropIndex("dbo.PromocaoUsuario", new[] { "PromocaoId" });
            DropTable("dbo.PromocaoUsuario");
            DropTable("dbo.Promocoes");
        }
    }
}
