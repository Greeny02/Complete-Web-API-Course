using Microsoft.AspNetCore.Mvc;
using WebApiDemo.Filters;
using WebApiDemo.Models;
using WebApiDemo.Models.Repositories;

namespace WebApiDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShirtsController : ControllerBase
    {

        [HttpGet]
        public string GetShirts()
        {
            return "Reading all the shirts";
        }

        [HttpGet("{id}")]
        [Shirt_ValidateShirtIdFilter]
        public IActionResult GetShirtByID(int id)
        {
            return Ok(ShirtRepository.GetShirtByID(id));
        }

        [HttpPost]
        public string CreateShirt([FromBody]Shirt shirt)
        {
            return "Creating a shirt";
        }

        [HttpPut("{id}")]
        public string UpdateShirt(int id)
        {
            return $"Updating shirt with ID: {id}";
        }

        [HttpDelete("{id}")]
        public string DeleteShirt(int id) 
        {
            return $"Deleting shirt with ID: {id}";        
        }
    }
}
