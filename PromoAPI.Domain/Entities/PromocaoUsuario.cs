using System;

namespace PromoAPI.Domain.Entities
{
    public class PromocaoUsuario
    {
        public PromocaoUsuario()
        {
            PromocaoUsuarioId = Guid.NewGuid();
        }
        public Guid PromocaoUsuarioId { get; set; }
        public Guid UsuarioId { get; set; }
        public Guid PromocaoId { get; set; }

        public virtual Promocao Promocao { get; set; }
    }
}
