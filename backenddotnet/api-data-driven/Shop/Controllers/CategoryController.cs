using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shop.Data;
using Shop.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    [Route("v1/categories")]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        [AllowAnonymous]
        [ResponseCache(VaryByHeader = "User-Agent", Location = ResponseCacheLocation.Any, Duration = 30)]
        //[ResponseCache(NoStore = true, Location = ResponseCacheLocation.None, Duration = 0)]
        public async Task<ActionResult<IEnumerable<Category>>> Get([FromServices] DataContext context)
        {
            var categories = await context.Categories
                                          .AsNoTracking()
                                          .ToListAsync();

            return Ok(categories);
        }

        [HttpGet("{id:int}")]
        [AllowAnonymous]

        public async Task<ActionResult<Category>> GetById([FromRoute] int id,
                                                          [FromServices] DataContext context)
        {
            var category = await context.Categories
                                        .AsNoTracking()
                                        .FirstOrDefaultAsync(x => x.Id == id);

            if (category == null)
                return NotFound(new { message = "Categoria não encontrada" });

            return Ok(category);
        }

        [HttpPost]
        [Authorize(Roles = "employee")]
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
        [Authorize(Roles = "employee")]
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
                context.Entry(category).State = EntityState.Modified;
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
        [Authorize(Roles = "employee")]
        public async Task<ActionResult<Category>> Delete([FromRoute] int id,
                                                         [FromServices] DataContext context)
        {
            var category = await context.Categories
                                        .FirstOrDefaultAsync(x => x.Id == id);
            if (category == null)
                return NotFound(new { message = "Categoria não encontrada" });

            try
            {
                context.Categories.Remove(category);
                await context.SaveChangesAsync();
                return Ok(new { message = "Categoria removida com sucesso!" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = $"Erro ao excluir Categoria: {ex.Message}" });
            }
        }
    }
}
