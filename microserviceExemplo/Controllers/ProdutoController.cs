using System.Collections.Generic;
using microserviceExemplo.Dominio;
using Microsoft.AspNetCore.Mvc;

namespace microserviceExemplo.Controllers
{
    [Produces("application/json")]
    [Route("api/Produto")]
    public class ProdutoController : Controller
    {
        // GET: api/Produto
        [HttpGet(Name ="GetAllProdutos")]
        public IActionResult Get()
        {
            var lista = new List<ProdutoDominio>();
            var obj1 = new ProdutoDominio();
            obj1.Id = 1;
            obj1.Nome = "Macarrão";

            var obj2 = new ProdutoDominio();
            obj2.Id = 2;
            obj2.Nome = "Arroz";

            lista.Add(obj1);
            lista.Add(obj2);

            return Ok(lista);
        }

        // GET: api/Produto/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Produto
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Produto/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
