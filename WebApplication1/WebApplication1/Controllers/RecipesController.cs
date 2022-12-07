using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")] //api/recipies
    [ApiController]
    public class RecipesController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetRecipies([FromQuery]int count)
        {
            Recipe[] recipes = {
               new() { Title = "Buglama" },
               new() { Title = "Lavash" },
               new() { Title = "Khinkali" }
            };

            if (!recipes.Any())
            { 
                return NotFound(); 
            }
            return Ok(recipes.Take(count));
        }


        [HttpPost]
        public ActionResult CreateRecipies()
        {
            bool badThingsHappened = false;

            if (badThingsHappened)
                return BadRequest();

            return NoContent();

        }



        [HttpDelete("{id}")]
        public ActionResult DeleteRecipies(string id) 
        {
            bool badThingsHappened = false;

            if(badThingsHappened)
                return BadRequest();

            return NoContent();
            

        }
    }
}
