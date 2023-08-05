using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieManagement.Domain.Repository;

namespace MovieManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ActorController(IUnitOfWork unitOfWork) 
        { 
          _unitOfWork = unitOfWork;
        }

       /* [HttpGet]
        public ActionResult Get()
        {
            var actorsFromRepo = _unitOfWork.Actor.GetAll();
            return Ok(actorsFromRepo);
        }*/

        [HttpGet]
        public ActionResult Get()
        {
            var moviesFromRepo = _unitOfWork.Movie.GetAll();
            return Ok(moviesFromRepo);
        }

        [HttpGet("movies")]
        public ActionResult GetWithMovies()
        {
            var actorsFromRepo = _unitOfWork.Actor.GetActorsWithMovies();
            return Ok(actorsFromRepo);
        }


    }
}
