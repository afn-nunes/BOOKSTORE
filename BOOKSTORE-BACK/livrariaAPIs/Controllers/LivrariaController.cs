using livrariaAPIs.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace livraria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivrariaController : ControllerBase
    {
        private readonly ToDoContext _context;

        public LivrariaController(ToDoContext context)
        {
            _context = context;
            //produtos sendo adicionados através do post
            //_context.todoProducts.Add(new Produto { ID = "1", Nome = "Senhor do aneis - O retorno do rei", Preco = 49.90, Categoria = "Ficção", Img = "1", Quantidade = 10 });
            //_context.todoProducts.Add(new Produto { ID = "2", Nome = "Hary Potter e a câmara secreta", Preco = 45.0, Categoria = "Ficção", Img = "2", Quantidade = 5 });
            //_context.todoProducts.Add(new Produto { ID = "3", Nome = "A arte de ligar o foda-se", Preco = 65.0, Categoria = "Drama", Img = "3", Quantidade = 3 });
            //_context.todoProducts.Add(new Produto { ID = "4", Nome = "O maior milagra de mundo", Preco = 125.0, Categoria = "Drama", Img = "4", Quantidade = 2 });
            //_context.todoProducts.Add(new Produto { ID = "5", Nome = "Os 10 negrinhos", Preco = 19.9, Categoria = "Suspense", Img = "5", Quantidade = 20 });

            //_context.SaveChanges();
        }
        
        [HttpGet]        
        public async Task<ActionResult<IEnumerable<Produto>>> Get()
        {
            return await _context.todoProducts.ToListAsync(); 
        }

        [HttpGet("{id}")]        
        public async Task<ActionResult<Produto>> Get(int id)
        {
            var item = await _context.todoProducts.FindAsync(id.ToString());
            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }

        [HttpPost]        
        public async Task<ActionResult> PostItem(Produto produto)
        {
            _context.todoProducts.Add(produto);

            _context.SaveChanges();

            return Created("", produto);
        }
    }
}
