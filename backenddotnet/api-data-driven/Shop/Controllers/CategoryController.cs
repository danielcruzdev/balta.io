using Microsoft.AspNetCore.Mvc;

namespace Shop.Controllers
{
    [Route("categories")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [Route("")]
        public string MeuMetodo()
        {
            return "Olá mundo!";
        }
    }
}
