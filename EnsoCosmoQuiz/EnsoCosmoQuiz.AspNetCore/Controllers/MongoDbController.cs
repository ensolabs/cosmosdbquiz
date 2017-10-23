
using System.Threading.Tasks;
using EnsoCosmoQuiz.AspNetCore.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EnsoCosmoQuiz.AspNetCore.Controllers
{
    public class MongoDbController : Controller
    {
        private readonly MongoDbRepository _repository  = new MongoDbRepository();
        

        [HttpGet]
        public async Task<IActionResult> GetNumberOfProductionCompanies()
        {
            var result = await _repository.GetNumberOfProductionCompanies();
            return Ok(result);
        }
    }
}
