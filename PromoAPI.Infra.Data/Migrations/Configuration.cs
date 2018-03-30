namespace PromoAPI.Infra.Data.Migrations
{
    using PromoAPI.Domain.Entities;
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<PromoAPI.Infra.Data.Context.PromoDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PromoAPI.Infra.Data.Context.PromoDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Promocoes.AddOrUpdate(x => x.Descricao,
                new Promocao
                {
                    Data = DateTime.Now,
                    Descricao = @"Ovo de páscoa Fit",
                    ImagemUrl = @"https://instagram.fvix2-2.fna.fbcdn.net/vp/b57efc129b73465a38af15ce174a380c/5B709913/t51.2885-15/s150x150/e35/29088543_1438105429634437_6872713487743713280_n.jpg",
                    Comentario = @"Sabores: Brigadeiro, Beijinho e Doce de Leite",
                    Valor = 39.90M
                },
                new Promocao
                {
                    Data = DateTime.Now,
                    Descricao = @"BOLO REDONDO 15CM",
                    ImagemUrl = @"https://instagram.fvix2-2.fna.fbcdn.net/vp/b96cc126da5e3517716f9436b5e28891/5B401EE6/t51.2885-15/s150x150/e35/c0.14.1080.1080/28153530_1787380854900152_485828610121269248_n.jpg",
                    Comentario = @"Qualquer sabor",
                    Valor = 40.00M
                },
                new Promocao
                {
                    Data = DateTime.Now,
                    Descricao = @"Cookie de Cacau integral",
                    ImagemUrl = @"https://instagram.fvix2-2.fna.fbcdn.net/vp/c509ba5c949d2266fe17a1da9aa553e6/5B5716F1/t51.2885-15/s150x150/e35/c0.135.1080.1080/26158979_402757176823424_7953581328207708160_n.jpg",
                    Comentario = @"Cacau",
                    Valor = 3.00M
                },
                new Promocao
                {
                    Data = DateTime.Now,
                    Descricao = @"Pãozinho Proteico",
                    ImagemUrl = @"https://instagram.fvix2-2.fna.fbcdn.net/vp/ee650a93c2c515688e440e5b94f55b6a/5B53DE25/t51.2885-15/s150x150/e35/26403628_107077260096693_1917239161455116288_n.jpg",
                    Comentario = @"Frango",
                    Valor = 25.00M
                },
                new Promocao
                {
                    Data = DateTime.Now,
                    Descricao = @"Bolo de Cacau Low Carb",
                    ImagemUrl = @"https://instagram.fvix2-2.fna.fbcdn.net/vp/9668a4d6e38cf7f0af294138f0d963aa/5B56D727/t51.2885-15/s150x150/e35/c0.97.778.778/25010413_250277528840480_4780305317776850944_n.jpg",
                    Comentario = @"Farinha principal de Amêndoas, Chocolate Belga 70% e sem açúcar (Não usamos refinados)",
                    Valor = 32.00M
                },
                new Promocao
                {
                    Data = DateTime.Now,
                    Descricao = @"Quiche",
                    ImagemUrl = @"https://instagram.fvix2-2.fna.fbcdn.net/vp/ab0d603f2967e69ac271ffddb5962086/5B3E18E6/t51.2885-15/s150x150/e35/24175155_871767656321218_7831720242593136640_n.jpg",
                    Comentario = @"Frango, alho poró, milho e vegetais",
                    Valor = 15.00M
                },
                new Promocao
                {
                    Data = DateTime.Now,
                    Descricao = @"Bolo LowCarb",
                    ImagemUrl = @"https://instagram.fvix2-2.fna.fbcdn.net/vp/ecf31d7064f35f11209d3e035f74ca53/5B5377A9/t51.2885-15/s150x150/e35/c0.135.1080.1080/22352118_139989510068112_689967602541264896_n.jpg",
                    Comentario = @"Café, Castanhas e Nozes",
                    Valor = 32.00M
                },
                new Promocao
                {
                    Data = DateTime.Now,
                    Descricao = @"BOLO DE AMENDOIM COM COCO",
                    ImagemUrl = @"https://instagram.fvix2-2.fna.fbcdn.net/vp/d2eee2d69d89dd7a95bccd3382b52de7/5B52BAEB/t51.2885-15/s150x150/e35/c0.30.1080.1080/20760006_1400247113416562_6432194931464339456_n.jpg",
                    Comentario = @"Amendoim com coco",
                    Valor = 32.00M
                },
                new Promocao
                {
                    Data = DateTime.Now,
                    Descricao = @"Bolo de Pote",
                    ImagemUrl = @"https://instagram.fvix2-2.fna.fbcdn.net/vp/220f1caf29dd0c3f0f2968859912c77f/5B39F2AF/t51.2885-15/s150x150/e35/20837440_508742632798286_2969815128922390528_n.jpg",
                    Comentario = @"Cacau + Coco + Castanha, Bolo LowCarb feito com Castanhas e Farinha de Coco com cobertura de brigadeiro de coco. Sem Glúten, Sem Lactose",
                    Valor = 12.00M
                });
        }
    }
}
