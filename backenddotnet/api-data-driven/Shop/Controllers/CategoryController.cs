using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shop.Data;
using Shop.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    [Route("categories")]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> Get()
        {
            return new List<Category>();
        }

        [HttpGet("{categoryId:int}")]
        public async Task<ActionResult<Category>> GetById([FromRoute] int categoryId)
        {
            return new Category();
        }

        [HttpPost]
        public async Task<ActionResult<Category>> Post([FromBody] Category category,
                                                       [FromServices] DataContext context)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                await context.Categories.AddAsync(category);
                await context.SaveChangesAsync();

                return Ok(category);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = $"Erro ao salvar Categoria: {ex.Message}" });
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<Category>> Put([FromRoute] int id,
                                                      [FromBody] Category category,
                                                      [FromServices] DataContext context)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (category.Id != id)
                return NotFound(new { message = "Categoria não encontrada!" });

            try
            {
                context.Entry<Category>(category).State = EntityState.Modified;
                await context.SaveChangesAsync();

                return Ok(category);
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return BadRequest(new { message = $"Este registro acabou de ser atualizado: {ex.Message}" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = $"Erro ao atualizar Categoria: {ex.Message}" });
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Category>> Delete([FromRoute] int id)
        {
            return Ok();
        }
    }
}
