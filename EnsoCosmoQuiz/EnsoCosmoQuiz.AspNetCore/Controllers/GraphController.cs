using System.Threading.Tasks;
using EnsoCosmoQuiz.AspNetCore.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EnsoCosmoQuiz.AspNetCore.Controllers
{
    public class GraphController : Controller
    {
        private GraphRepository _repository = new GraphRepository();
        

        [HttpGet]
        public async Task<IActionResult> GetNumberOfActorsThatHaveActedInMoreThan1Movie()
        {
            var result = await _repository.GetNumberOfActorsThatHaveActedInMoreThan1Movie();
            return Ok(result);
        }
    }
}
