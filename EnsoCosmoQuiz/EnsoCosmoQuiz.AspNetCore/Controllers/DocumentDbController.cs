using System.Threading.Tasks;
using EnsoCosmoQuiz.AspNetCore.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EnsoCosmoQuiz.AspNetCore.Controllers
{
    [Route("[controller]")]
    public class DocumentDbController : Controller
    {
        readonly DocumentDbRepository _repository = new DocumentDbRepository();
        

        [HttpGet("task1")]
        public async Task<IActionResult> GetNumberOfActorsInBladeRunner()
        {
            var result = await _repository.GetNumberOfActorsInBladeRunner();
            return Ok(result);
        }
    }
}
