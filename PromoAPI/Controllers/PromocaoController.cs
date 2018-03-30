using PromoAPI.Domain.Entities;
using PromoAPI.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace PromoAPI.Controllers
{
    public class PromocaoController : ApiController
    {
        private readonly IPromocaoService _promocaoService;

        public PromocaoController(IPromocaoService promocaoService)
        {
            _promocaoService = promocaoService;
        }
        // GET: api/Promocao
        public async Task<IEnumerable<Promocao>> Get()
        {
            return await _promocaoService.GetAllAsync();
        }

        // GET: api/Promocao/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Promocao
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Promocao/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Promocao/5
        public void Delete(int id)
        {
        }
    }
}
