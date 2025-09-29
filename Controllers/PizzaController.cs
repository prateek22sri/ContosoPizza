using Microsoft.AspNetCore.Mvc;
using ContosoPizza.Services;
using ContosoPizza.Models;

namespace ContosoPizza.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PizzaController : ControllerBase
    {
        private readonly IPizzaService _service;

        public PizzaController(IPizzaService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<Pizza>> GetAll() => _service.GetAll();
    }
}
