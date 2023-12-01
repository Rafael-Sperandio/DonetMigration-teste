using f1DotnetTeste.API.Entities;
using f1DotnetTeste.API.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace f1DotnetTeste.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrimeiroAPIController : ControllerBase
    {
        private readonly MEUDBContext _context;

        public PrimeiroAPIController(MEUDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public  IActionResult GeyAll()
        {
            var produtos = _context.Produtos;
            //var produtos= _context.listarFrutas();
            return Ok(produtos);
        }
        [HttpGet("{id}")]
        public IActionResult GeyById(Guid id)
        {
            var produtos = _context.Produtos.SingleOrDefault(p=> p.id ==id);
            //var produtos= _context.listarFrutas();
            return Ok(produtos);
        }
        [HttpPost]
        public IActionResult Post(Produto p)
        {
            //var newprodut =
            _context.Produtos.Add(p);
            _context.SaveChanges();
           
            //var produtos= _context.listarFrutas();
            return CreatedAtAction(nameof(GeyById), new {id=p.id});
        }
    }
}
