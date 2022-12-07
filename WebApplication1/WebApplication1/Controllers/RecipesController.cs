using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")] //api/recipies
    [ApiController]
    public class RecipesController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetRecipies([FromQuery]int count)
        {
            string[] recipes = { "Buglama", "Chicken", "Donner" };
            if (!recipes.Any())
            { 
                return NotFound(); 
            }
            return Ok(recipes.Take(count));
        }


       // [HttpPost]
      //  public ActionResult CreateRecipies()
       
        

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
