
using System.Threading.Tasks;
using EnsoCosmoQuiz.AspNetCore.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EnsoCosmoQuiz.AspNetCore.Controllers
{
    [Route("[controller]")]
    public class MongoDbController : Controller
    {
        private readonly MongoDbRepository _repository  = new MongoDbRepository();
        

        [HttpGet("task1")]
        public async Task<IActionResult> GetNumberOfProductionCompanies()
        {
            var result = await _repository.GetNumberOfProductionCompanies();
            return Ok(result);
        }
    }
}
