using API.DataContext;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DirectorsController : Controller
    {
        private readonly OtmsContext _otmsContext;
        public DirectorsController(OtmsContext otmsContext)
        {
            _otmsContext = otmsContext;
        }

        //get all directors
        [HttpGet("GetAllDirectors")]
        public ActionResult<List<Director>> GetDirectors()
        {
            return _otmsContext.Directors.ToList();
        }

        //create a director
        [HttpPost("CreateDirector")]
        public IActionResult CreateDirector(Director model)
        {
            Director director = new Director
            {
                Name = model.Name,
                Department = model.Department,
                Email = model.Email,
                PhoneNumber = model.PhoneNumber
            };

            _otmsContext.Directors.Add(director);

            _otmsContext.SaveChanges();

            return Ok();
        }
    }
}