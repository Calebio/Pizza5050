using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pizza5050.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza5050.Server.Controllers
{
    [Route("api/{controller}")]
    [ApiController]
    public class PizzaSpecialsController : ControllerBase
    {
        private readonly IPizzaSpecialsRepo pizzaSpecials;
        public PizzaSpecialsController(IPizzaSpecialsRepo pizzaSpecialsRepo)
        {
            pizzaSpecials = pizzaSpecialsRepo;
        }

        [HttpGet]
        public async Task<ActionResult> GetPizzas()
        {
            try
            {
                return Ok(await pizzaSpecials.GetPizzaSpecials());
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error getting data!");
            }

        }

    
        [HttpGet("{id}")]
        public async Task<ActionResult<PizzaSpecial>> GetPizza(int id)
        {
            try
            {
                var result = await pizzaSpecials.GetPizzaSpecial(id);
                if(result == null)
                {
                    return NotFound();
                }
                return result;
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error getting data!");
            }

        }
        [HttpPost]
        public async Task<ActionResult<PizzaSpecial>> CreatePizza(PizzaSpecial pizza)
        {
            try
            {
                if(pizza == null)
                    return BadRequest();

                    var createdPizza = await pizzaSpecials.AddPizza(pizza);

                return CreatedAtAction(nameof(GetPizza),
                    new { id = createdPizza.Id }, createdPizza);
                
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error creating record data!");
            }

        }

    }
}
