using PromoAPI.Domain.Entities;
using PromoAPI.Domain.Interfaces.Services;
using PromoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace PromoAPI.Controllers
{
    public class PromocaoUsuarioController : ApiController
    {
        private readonly IPromocaoUsuarioService _promocaoUsuarioService;
        public PromocaoUsuarioController(IPromocaoUsuarioService promocaoUsuarioService)
        {
            _promocaoUsuarioService = promocaoUsuarioService;
        }
        // GET: api/PromocaoUsuario
        [Route("api/PromocaoUsuario/{id:Guid}")]
        public async Task<IEnumerable<Promocao>> Get(Guid id)
        {
            var promocoesUsuario = await _promocaoUsuarioService.GetAllAsync(x => x.UsuarioId == id);
            return promocoesUsuario.Select(x => x.Promocao);
        }

        // GET: api/PromocaoUsuario/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/PromocaoUsuario
        public async Task Post()
        {
            var promocaoUsuario = await Request.Content.ReadAsAsync<PromocaoUsuarioViewModel>();

            await _promocaoUsuarioService.AddAsync(new PromocaoUsuario
            {
                PromocaoId = promocaoUsuario.PromocaoId,
                UsuarioId = promocaoUsuario.UsuarioId
            });

            return;
        }

        // PUT: api/PromocaoUsuario/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/PromocaoUsuario/5
        public void Delete(int id)
        {
        }
    }
}
