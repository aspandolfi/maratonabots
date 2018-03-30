using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PromoAPI.Domain.Entities
{
    public class Promocao
    {
        public Promocao()
        {
            PromocaoId = Guid.NewGuid();
            PromocaoUsuarios = new Collection<PromocaoUsuario>();
        }
        public Guid PromocaoId { get; set; }
        public DateTime Data { get; set; }
        public string ImagemUrl { get; set; }
        public decimal? Valor { get; set; }
        public string Descricao { get; set; }
        public string Comentario { get; set; }
        [JsonIgnore]
        public virtual ICollection<PromocaoUsuario> PromocaoUsuarios { get; set; }
    }
}
