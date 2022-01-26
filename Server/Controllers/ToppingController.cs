using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pizza5050.Server.Models;
using Pizza5050.Shared;
using System;
using System.Threading.Tasks;

namespace Pizza5050.Server.Controllers
{
    [Route("api/{controller}")]
    [ApiController]
    public class ToppingController : ControllerBase
    {
        private readonly IToppingRepo toppings;

        public ToppingController(IToppingRepo topping)
        {
            toppings = topping;
        }

        [HttpGet]
        public async Task<ActionResult> GetToppings()
        {
            try
            {
                return Ok(await toppings.GetToppings());
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error getting data!");
            }

        }


        [HttpGet("{id}")]
        public async Task<ActionResult<PizzaTopping>> GetTopping(int id)
        {
            try
            {
                var result = await toppings.GetTopping(id);
                if (result == null)
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
    }
}
