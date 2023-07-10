using API.DataContext;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
   [ApiController]
   [Route("[controller]")]
   public class DirectorsController : Controller
   {
      private readonly ApplicationDbContext _dbContext;
      public DirectorsController(ApplicationDbContext dbContext)
      {
         _dbContext = dbContext;
      }

      //get all directors
      [HttpGet("GetAllDirectors")]
      public ActionResult<List<Director>> GetDirectors()
      {
         return _dbContext.Directors.ToList();
      }
   }
}